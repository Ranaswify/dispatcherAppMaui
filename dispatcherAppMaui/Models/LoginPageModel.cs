﻿using FreshMvvm.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispatcherAppMaui.Models
{
    internal class LoginPageModel : FreshBasePageModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string clientId { get; set; }
        public string secret { get; set; }
        public string deviceId { get; set; }
        public string grant_type { get; set; }
        public bool IsDispatcherLogin { get; set; }

    }
}
