using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRCBQuestionnaireStatistic.Command;

namespace SRCBQuestionnaireStatistic.Model
{
    public class Question
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public string Subject { get { return string.Format("{0}.{1}", Title, Subtitle); } }
        public AnswerList AvailableAnswers { get; set; }
        public Answer SelectedAnswer { get; set; }

        public FillAnswerCommand FillAnswerCommand;

        private Question()
        {
            FillAnswerCommand = new FillAnswerCommand(this);
        }

        //public void FillAnswer(Answer.Symbol answerSym)
        //{
        //    FillAnswerCommand.Sym = answerSym;
        //    FillAnswerCommand.Do();
        //}

        internal Question MakeNew(string title, string subtitle)
        {
            Question q = new Question();
            q.Title = title;
            q.Subtitle = subtitle;
            q.AvailableAnswers = new AnswerList();
            q.SelectedAnswer = Answer.Empty;
            return q;
        }

        internal Question MakeCopy()
        {
            Question q = new Question();
            q.Title = this.Title;
            q.Subtitle = this.Subtitle;

            return q;
        }
    }
}
