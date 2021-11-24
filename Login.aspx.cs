using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
using PWEB_quiz2.Classes;

namespace PWEB_quiz2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable DtLogin = new DataTable();
            DtLogin = ClsLogin.DtLogin(TxtEmail.Text,TxtPassword.Text);

            if(DtLogin.Rows.Count != 0)
            {
                Response.Redirect("~/WebForm1.aspx");
            }
            else
            {
                LblWarning.Text = "Email atau Password Anda Salah ...";
                LblWarning.Visible = true;
            }
        }

        protected void BtnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Signup.aspx");
        }
    }
}