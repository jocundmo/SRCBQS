using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRCBQuestionnaireStatistic.Model;

namespace SRCBQuestionnaireStatistic.Command
{
    public class FillAnswerCommand : ICommand
    {
        public Question Question { get; private set; }
        public Answer.Symbol Sym { get; set; }
        public FillAnswerCommand(Question parent)
        {
            this.Question = parent;
        }

        public void Do()
        {
            foreach (Answer a in Question.AvailableAnswers)
            {
                if (a.Sym == Sym)
                {
                    Question.SelectedAnswer = a;
                    break;
                }
            }
        }

        public void Undo()
        {
            Question.SelectedAnswer = Answer.Empty;
        }

        public void Redo()
        {
            Do();
        }
    }
}
