using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRCBQuestionnaireStatistic.Model
{
    public class QuestionList : List<Question>
    {
        internal QuestionList MakeCopy(Questionnaire qn)
        {
            QuestionList ql = new QuestionList();
            foreach (Question q in this)
            {
                ql.Add(q.MakeCopy(qn));
            }
            return ql;
        }
    }
}
