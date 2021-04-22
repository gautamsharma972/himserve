using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Himserve.Services
{
    public interface IEmailSender
    {
        void SendMail(Message message);
    }
}
