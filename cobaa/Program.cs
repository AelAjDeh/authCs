//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace cobaa
//{
//    internal static class Program
//    {
//        / <summary>
//        / The main entry point for the application.
//        / </summary>
//        [STAThread]
//        static void Main()
//        {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new Welcome());
//        }
//    }
//}

using System;
using System.Collections.Generic;
using Devart.Data.PostgreSql;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace Projectsms
{
    class datalayer
    {
        PgSqlConnection conn_;
        PgSqlCommand cmd_;
        PgSqlDataReader reader_;
        PgSqlDataAdapter adptr_;
        System.Data.DataSet dset_;
        System.Data.DataTable dt_;
        static string getmessage { get; set; }
        public datalayer()
        {

            string cs = "User Id=postgres;Host=localhost;Database=Jagad;Port=5432;Initial Schema=public;password=Aurelius_22";
            conn_ = new PgSqlConnection(cs);
            cmd_ = new PgSqlCommand();
            adptr_ = new PgSqlDataAdapter();
            dset_ = new System.Data.DataSet();
        }
        public bool Connect()
        {
            try
            {
                conn_.Open();
                getmessage = "Connection established!";
                return true;
            }
            catch (Exception exp)
            {
                getmessage = "error while opening connection (Datalayer=>Connect()) : " + exp.Message;
                return false;
            }
        }
        public bool Disconnect()
        {
            try
            {
                conn_.Close();
                getmessage = "Connection Closed Successfully!";
                return true;
            }
            catch (Exception exp)
            {
                getmessage = "error while Closing connection (Datalayer=>Disconnect()) : " + exp.Message;
                return false;
            }
        }
        public string insertUpdateCreateOrDelete(string query)
        {
            string ret = "";
            string allqueries = query.ToLower();
            try
            {
                cmd_.CommandText = query;
                cmd_.Connection = conn_;
                Connect();
                cmd_.ExecuteNonQuery();
                if (allqueries.Contains("insert into "))
                {
                    ret = getmessage = "inserted Successfully!";
                }
                else if (allqueries.Contains("delete from "))
                {
                    ret = getmessage = "Deleted Successfully!";
                }
                else if (allqueries.Contains("create table "))
                {
                    ret = getmessage = "Table Created Successfully!";
                }
                else if (allqueries.Contains("update ") && allqueries.Contains("set= "))
                {
                    ret = getmessage = "Updated Successfully";
                }
            }
            catch (Exception exp)
            {
                ret = getmessage = "Failed to execute " + query + " \n Reason : " + exp.Message;
            }
            finally { Disconnect(); }
            return ret;
        }
        public string fillgridView(string query, System.Web.UI.WebControls.GridView dgv)
        {
            dt_ = new System.Data.DataTable();
            string stret;
            try
            {
                cmd_.Connection = conn_;
                cmd_.CommandText = query.ToLower();
                Connect();
                adptr_.SelectCommand = cmd_;
                adptr_.Fill(dt_);
                dgv.DataSource = dt_;
                dgv.DataBind();
                stret = "Code Executed Successfully (filldatagridView()=> datalayer.cs)";
            }
            catch (Exception exp)
            {
                stret = "Failed (filldatagridView()=> datalayer.cs) : " + exp.Message;
            }
            finally
            {
                Disconnect();
                dt_ = null;
            }
            return stret;
        }

        internal void getsingleColumnValueByIndex(string qry, out string s_id, int v)
        {
            throw new NotImplementedException();
        }
    }
}