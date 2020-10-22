using System;
using System.Collections.Generic;
using System.Text;

namespace TimeCreated
{
    class LogFile
    {
        public LogFile()
        {
            CreationDate = DateTimeOffset.Now;
        }
        public DateTimeOffset CreationDate { get; }
    }
}
