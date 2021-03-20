using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string MyText
        {
            get { return TextBox1.Text; }
            set { TextBox1.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(TextBox1.Text);
            int second = Convert.ToInt32(TextBox2.Text);
            var res = first + second;
            Label1.Text = Convert.ToString(res);
        }
        //вычитание
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text));        
        }
        //умножение
        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text));
        }
        //деление
        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text));
        }
    }
}