using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SRCBQuestionnaireStatistic.Command
{
    public class CommandStack : Stack<ICommand>
    {
        public void UndoAll()
        {
            while (this.Count > 0)
            {
                ICommand cmd = Pop();
                cmd.Undo();
            }
        }

        public void UndoOnce()
        {
            ICommand cmd = Pop();
            cmd.Undo();
        }
    }
}
