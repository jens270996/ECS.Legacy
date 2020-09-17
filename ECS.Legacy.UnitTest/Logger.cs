using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.UnitTest
{
    public class Logger
    {
        private string Log_;
        public string Log
        {
            get
            {
                return Log_;
            }
            
            set
            {
                Log_ += value;
            }

        }

        public void Reset()
        {
            Log_=Log_.Remove(0);
        }
    }
}
