﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BT5.Models
{
    public class MailModel

    {
        public string From { get; set; }
        public string Password { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}