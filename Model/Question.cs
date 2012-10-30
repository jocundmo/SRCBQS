using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRCBQuestionnaireStatistic.Command;

namespace SRCBQuestionnaireStatistic.Model
{
    public class Question
    {
        public enum Typee
        {
            SingleChoice,
            MultipleChoices
        }

        public int Index { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public Typee QuestionType { get; set; }
        public string Subject { get { return string.Format("{0}.{1}", Title, Subtitle); } }
        public AnswerList AvailableAnswers { get; set; }
        public Answer SelectedAnswer { get; set; }
        public Questionnaire Questionnaire { get; private set; }
        //public FillAnswerCommand FillAnswerCommand;

        private Question()
        {
            //FillAnswerCommand = new FillAnswerCommand(this);
        }

        //public void FillAnswer(Answer.Symbol answerSym)
        //{
        //    FillAnswerCommand.Sym = answerSym;
        //    FillAnswerCommand.Do();
        //}

        public static Question MakeNew(int index, Typee questionType, string title, string subtitle, Questionnaire qn)
        {
            Question q = new Question();
            q.Index = index;
            q.Title = title;
            q.Subtitle = subtitle;
            q.QuestionType = questionType;
            q.AvailableAnswers = new AnswerList();
            q.SelectedAnswer = Answer.Empty;
            q.Questionnaire = qn;
            return q;
        }

        public Question MakeCopy(Questionnaire qn)
        {
            Question q = new Question();
            q.Index = this.Index;
            q.Title = this.Title;
            q.Subtitle = this.Subtitle;
            q.QuestionType = this.QuestionType;
            q.AvailableAnswers = this.AvailableAnswers.MakeCopy();
            q.SelectedAnswer = Answer.Empty;
            q.Questionnaire = qn;
            return q;
        }
    }
}
