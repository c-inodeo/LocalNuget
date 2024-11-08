using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNotificationMessages.Helpers
{
    public class UserNotifModel
    {
        public string? UserId { get; set; }
        public string? Message { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
