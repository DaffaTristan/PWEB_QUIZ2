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
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void BtnSignup_Click(object sender, EventArgs e)
        {
            DataTable DtSignup = new DataTable();
            DtSignup = ClsSignup.DtSignup(TxtName.Text, TxtEmail.Text, TxtPassword.Text);

            LblWarning.Text = "Data Berhasil Disimpan!";
            LblWarning.Visible = true;
            TxtName.Text = "";
            TxtEmail.Text = "";
            TxtPassword.Text = "";
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}