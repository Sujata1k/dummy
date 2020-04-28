using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace EuladoxTSApp.Model
{
    public class LoginModel
    {
        public int id_eladox_user { get; set; }

        public string Agent { get; set; }

        public string user_name { get; set; }

        public string user_password { get; set; }

        public string caller_type { get; set; }

        public string client_host_name { get; set; }

        public string client_serial_number { get; set; }

        public string session_key { get; set; }

        public string key_valid_till { get; set; }

        public bool IsLoginCredenntialValid { get; set; }

        public bool RetsultHasCriticalError { get; set; }

        public string ErrorMessage { get; set; }
        public string login_by { get; set; }

    
}
}
