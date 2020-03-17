using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MSTest
{
    public partial class DemoEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLclass B = new BLclass();
            try
            {
                txtresult.Text = B.Divide(txtnum.Text, txtdeno.Text).ToString();
            }
            catch(DivideByZeroException E)
            {
                Response.Write(E.Message);
            }
            catch(FormatException E)
            {
                Response.Write(E.Message);
            }
        }
    }
}