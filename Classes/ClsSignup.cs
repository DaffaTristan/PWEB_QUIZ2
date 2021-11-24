using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Odbc;
using PWEB_quiz2.Classes;

namespace PWEB_quiz2.Classes
{
    public class ClsSignup
    {
        public static DataTable DtSignup(string Name, string Email, string Password)
        {
            DataTable Dt = new DataTable();
            OdbcConnection OdbcConn = new OdbcConnection(ClsModule.Conn.ToString());
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd1 = new OdbcCommand();
            OdbcDataAdapter da = new OdbcDataAdapter();

            OdbcConn.Open();
            cmd.Connection = OdbcConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO account (Email, Password) VALUES('"+Email+"', '"+Password+"'); ";
            da.SelectCommand = cmd;
            da.Fill(Dt);
            cmd1.Connection = OdbcConn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "INSERT INTO profile (Name) VALUES('"+Name+"'); ";
            da.SelectCommand = cmd1;
            da.Fill(Dt);
            OdbcConn.Close();
            return Dt;
        }
    }
}