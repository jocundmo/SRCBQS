﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRCBQuestionnaireStatistic.Command
{
    public interface ICommand
    {
        void Do();
        void Undo();
    }
}
