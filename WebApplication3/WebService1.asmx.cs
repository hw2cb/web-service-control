using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
//https://www.youtube.com/watch?v=8gFIX_QpUAE 22:45
namespace WebApplication3
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public int sum(int a, int b)
        {
            return a + b;
        }
        [WebMethod]
        public DataSet getCustomers()
        {
            SqlConnection con;
            SqlDataAdapter adap;
            DataSet dataset;
            string cmdString = "SELECT * FROM Customers";
            string connectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            con = new SqlConnection(connectionStr);
            adap = new SqlDataAdapter(cmdString, con);
            dataset = new DataSet();
            adap.Fill(dataset, "Customers");
            return dataset;
        }
    }
}
