﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinct.Common.Log
{
    public  class LogManger
    {
        public ILogger GetLogger()
        {
            return new Logger();
        }
    }
}
