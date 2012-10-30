using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRCBQuestionnaireStatistic.Model
{
    public class AnswerList : List<Answer>
    {
        internal AnswerList MakeCopy()
        {
            AnswerList al = new AnswerList();
            foreach (Answer a in this)
            {
                al.Add(a.MakeCopy());
            }
            return al;
        }
    }
}
