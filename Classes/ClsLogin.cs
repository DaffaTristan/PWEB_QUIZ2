using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Odbc;
using PWEB_quiz2.Classes;

namespace PWEB_quiz2.Classes
{
    public class ClsLogin
    {
        public static DataTable DtLogin(string Email, string Password)
        {
            DataTable Dt = new DataTable();
            OdbcConnection OdbcConn = new OdbcConnection(ClsModule.Conn.ToString());
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataAdapter da = new OdbcDataAdapter();

            OdbcConn.Open();
            cmd.Connection = OdbcConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from account where Email='"+Email+"' and Password='"+Password+"'";
            da.SelectCommand = cmd;
            da.Fill(Dt);
            OdbcConn.Close();
            return Dt;
        }

    }
}