using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SRCBQuestionnaireStatistic.Model
{
    public class Questionnaire
    {
        public Guid Id { get; private set; }
        public int Index { get; private set; }
        public string Subject { get; private set; }
        public string Description { get; private set; }
        public bool IsBossManager { get; private set; }
        public bool IsBranchManager { get; private set; }

        public QuestionList Questions { get; private set; }

        public BossList Bosses { get; private set; }
        public BranchList Branches { get; private set; }

        private Questionnaire()
        {
            Questions = new QuestionList();
            Bosses = new BossList();
            Branches = new BranchList();
        }

        private bool ReadQuestions(string xmlPath)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlPath);

                XmlNodeList xnlRoot = xml.SelectNodes("//Questionnaire");
                if (xnlRoot.Count != 1)
                    throw new Exception("There should be one (and only one) <Questionnaire> section defined");

                XmlNode xnlSubject = ((XmlElement)xnlRoot[0]).SelectSingleNode("Subject");
                this.Subject = xnlSubject.InnerText;

                XmlNode xnlDescription = ((XmlElement)xnlRoot[0]).SelectSingleNode("Description");
                this.Description = xnlDescription.InnerText;

                this.IsBossManager = bool.Parse(Utility.GetAttributeValue(xnlRoot[0], "IsBossManager", "false"));
                this.IsBranchManager = bool.Parse(Utility.GetAttributeValue(xnlRoot[0], "IsBranchManager", "false"));
                
                XmlNodeList xnlQuestions = ((XmlElement)xnlRoot[0]).SelectNodes("Questions/Question");
                int questionIndex = 0;
                foreach (XmlElement xeQuestion in xnlQuestions)
                {
                    string title = xeQuestion.SelectSingleNode("Title").InnerText;
                    string subtitle = xeQuestion.SelectSingleNode("Subtitle").InnerText;
                    string type = Utility.GetAttributeValue(xeQuestion, "Type", "SingleChoice");

                    Question q = Question.MakeNew(questionIndex, Utility.ConvertToTypee(type), title, subtitle, this);
                    questionIndex++;
                    foreach (XmlElement xeAnswer in xeQuestion.SelectNodes("Answers/Answer"))
                    {
                        string text = xeAnswer.SelectSingleNode("Text").InnerText;
                        string sym = xeAnswer.SelectSingleNode("Symbol").InnerText;
                        Answer a = Answer.MakeNew(text, Utility.ConvertToSymbol(sym));

                        q.AvailableAnswers.Add(a);
                    }
                    this.Questions.Add(q);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static Questionnaire MakeNew(string xmlPath)
        {
            Questionnaire qn = new Questionnaire();
            qn.Id = Guid.NewGuid();
            qn.Index = 0;
            //qn.Subject = subject;
            //qn.Description = desc;
            //qn.Bosses = bosses;
            //qn.Branches = branches;
            qn.ReadQuestions(xmlPath);
            return qn;
        }

        public Questionnaire MakeCopy()
        {
            Questionnaire qn = new Questionnaire();
            qn.Id = Guid.NewGuid();
            qn.Index = this.Index + 1;
            qn.Subject = this.Subject;
            qn.Description = this.Description;
            qn.Bosses = this.Bosses;
            qn.Branches = this.Branches;
            qn.Questions = this.Questions.MakeCopy(qn);

            return qn;
        }

        public bool IsQuestionnaireFinished()
        {
            foreach (Question q in this.Questions)
            {
                if (q.SelectedAnswer == null || q.SelectedAnswer.Sym == Answer.Empty.Sym)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
