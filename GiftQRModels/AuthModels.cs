using System;
using System.Collections.Generic;
using System.Text;

namespace GiftQRModels
{
    public class AuthRequestModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AuthResponseModel
    {
        public string Token { get; set; }
        public string Username { get; set; }
    }
}
