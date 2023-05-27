using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Entities
{
    public class LogRecord
    {
        public string? UserName { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = obj as LogRecord ?? throw new ArgumentNullException(nameof(obj));
            return UserName!.Equals(other!.UserName);
        }

        public override int GetHashCode()
        {
            return UserName!.GetHashCode();
        }
    }
}
