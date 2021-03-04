using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsClient.ServiceReference1;

namespace WebFormsClient
{
    public partial class TemperatureConvert : System.Web.UI.Page
    {
        ServiceClient sc = new ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInfo();
            }
        }

        protected void submitBTN_Click(object sender, EventArgs e)
        {
            int toIndex = toConvert.SelectedIndex + 1;
            int indexTo = convertTo.SelectedIndex + 1;
            double temp;
            if (double.TryParse(txt.Text, out temp)){
                if ((toIndex == 1 && temp >= 0) || (toIndex == 2 && temp >= -273) || (toIndex == 3 && temp >= -459.4))
                {
                    double converted = getConvertedTemperature(temp, toIndex, indexTo);
                    display.Text = converted.ToString();
                }
                else
                {
                    display.Text = "Could not convert, invalid temperatures below absolute 0";
                }
            }
            else
            {
                display.Text = "Could not convert";
            }
        }

        private void LoadInfo()
        {
            List<string> units = new List<string>();
            foreach (UnitTemp unit in sc.GetTempUnits())
                units.Add(unit.Name);
            convertTo.DataSource = units;
            convertTo.DataBind();
            toConvert.DataSource = units;
            toConvert.DataBind();
        }

        private double getConvertedTemperature(double temp, int toIndex, int indexTo)
        {
            return sc.ConvertTemp(toIndex, indexTo, temp);
        }

        protected void toConvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display.Text = toConvert.SelectedIndex.ToString();     
        }

        protected void convertTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display.Text = convertTo.SelectedIndex.ToString(); 
        }
    }
}