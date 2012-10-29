using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRCBQuestionnaireStatistic.Model
{
    public class Questionnaire
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string QuestionnairXmlPath { get; set; }

        private QuestionList _questions = new QuestionList();

        public BossList Bosses { get; set; }
        public BranchList Branches { get; set; }

        private Questionnaire()
        {
            // Nothing to do.
        }

        private bool ReadQuestions()
        {
            try
            {

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public Questionnaire MakeNew(string subject, string desc, BossList bosses, BranchList branches)
        {
            Questionnaire qn = new Questionnaire();
            qn.Id = Guid.NewGuid();
            qn.Subject = subject;
            qn.Description = desc;
            qn.Bosses = bosses;
            qn.Branches = branches;
            qn.ReadQuestions();
            return qn;
        }

        public Questionnaire MakeCopy()
        {
            Questionnaire qn = new Questionnaire();
            qn.Id = Guid.NewGuid();
            qn.Subject = this.Subject;
            qn.Description = this.Description;
            qn.Bosses = this.Bosses;
            qn.Branches = this.Branches;
            qn._questions = this._questions.MakeCopy();

            return qn;
        }
    }
}
