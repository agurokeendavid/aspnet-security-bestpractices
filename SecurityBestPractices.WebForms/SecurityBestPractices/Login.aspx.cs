﻿using System;
using System.Web.Security;

namespace SecurityBestPractices {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            FormsAuthentication.RedirectFromLoginPage(UserName.Text, true);
        }
    }
}