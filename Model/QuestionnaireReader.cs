using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SRCBQuestionnaireStatistic.Model
{
    public class QuestionnaireReader
    {
        private int index = -1;
        public Questionnaire Entity { get; private set; }
        public QuestionnaireReader(Questionnaire entity)
        {
            Entity = entity;
        }
        public Question Question { get { return Entity.Questions[index]; } }
        public void Reset()
        {
            index = -1;
        }
        public void SetIndex(int index)
        {
            this.index = index;
        }
        public bool Read()
        {
            index++;
            bool isNext = index < Entity.Questions.Count;
            if (!isNext)
                MessageBox.Show("没有下一题了！");

            return isNext;
        }
    }
}
