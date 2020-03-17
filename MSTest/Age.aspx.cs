using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;

namespace MSTest
{
    public partial class Age : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLAge B = new BLAge();
            DateTime dob = DateTime.Parse(TextBox1.Text);
            try
            {
                TextBox2.Text = B.Age(dob).ToString();
            }
            catch (CustomException E)
            {
                Console.WriteLine(E.Message);
            }

        }
    }
}