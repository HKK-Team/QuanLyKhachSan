using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "hkkteamsp@gmail.com";
            password = "Admin111";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
