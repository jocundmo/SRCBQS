using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRCBQuestionnaireStatistic.Model
{
    public class Answer
    {
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

        private Answer()
        {
        }

        public static Answer MakeNew(string text, Symbol sym)
        {
            Answer a = new Answer();
            a.Text = text;
            a.Sym = sym;
            return a;
        }

        public string FullText
        {
            get { return string.Format("{0}. {1}", Sym, Text); }
        }

        public override string ToString()
        {
            return FullText;
        }

        public static Answer Empty 
        { 
            get { 
                return new Answer() { Sym = Symbol.None, Text = string.Empty };
            }
        }

        public Answer MakeCopy()
        {
            Answer a = new Answer();
            a.Text = this.Text;
            a.Sym = this.Sym;
            return a;
        }
    }
}
