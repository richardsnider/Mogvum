using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Testing
{
    public class LogEvent
    {
        public DateTime Timestamp;
        public string Message;
        public Type Source;

        public LogEvent(string message, Type source)
        {
            Message = message;
            Source = source;
            Timestamp = DateTime.Now;
        }
    }
}
