using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRCBQuestionnaireStatistic.Model
{
    public class Answer
    {
        public enum Type
        {
            SingleChoice,
            MultipleChoices
        }

        public enum Symbol
        {
            None,
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            I
        }

        public string Text { get; set; }
        public Symbol Sym { get; set; }

        public override string ToString()
        {
            return string.Format("{0}. {1}", Sym, Text);
        }

        public static Answer Empty 
        { 
            get { 
                return new Answer() { Sym = Symbol.None, Text = string.Empty };
            }
        }
    }
}
