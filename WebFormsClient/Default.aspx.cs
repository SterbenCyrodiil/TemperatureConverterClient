using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsClient.ServiceReference1;
using WebFormsClient.ServiceReference2;

namespace WebFormsClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void runner_Click(object sender, EventArgs e)
        {
            ServiceClient sc = new ServiceClient();
            string data = sc.GetData("THIS");
            runner.Text=data;
            AcademiaClient ac = new AcademiaClient();
            bool online = ac.IsOnline();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('"+ online +"')", true);
        }
    }
}