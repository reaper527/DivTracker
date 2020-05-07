using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Management;

namespace DivTracker
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        public float YearlyTotal(string frequency, float amount, int quantity)
        {
            if (frequency == "quarterly")
            {

                return (amount * quantity * 4);
            }

            else if (frequency == "semi-annual")
            {
                return (amount * quantity * 2);
            }
            else
            {
                return 0;
            }
        }

        void ProcessData(string Symbol, int Quantity, string apikey)
        {
            RestClient client = new RestClient("https://cloud.iexapis.com/stable");
            RestRequest request = new RestRequest("/stock/" + Symbol + "/dividends/next?token=" + apikey , Method.GET);
            IRestResponse restResponse = client.Execute(request);

            try
            {
                var ProcessingData = JObject.Parse(restResponse.Content);


                dataGridView1.Rows.Add(Symbol, Quantity, ProcessingData.GetValue("exDate"), ProcessingData.GetValue("paymentDate"), ProcessingData.GetValue("amount"), float.Parse(ProcessingData.GetValue("amount").ToString()) * Quantity, ProcessingData.GetValue("frequency"), YearlyTotal(ProcessingData.GetValue("frequency").ToString(), float.Parse(ProcessingData.GetValue("amount").ToString()), Quantity));

            }

            catch
            {
                RestClient client2 = new RestClient("https://cloud.iexapis.com/stable");
                RestRequest request2 = new RestRequest("/stock/" + Symbol + "/dividends/6m?token=" + apikey, Method.GET);
                IRestResponse restResponse2 = client2.Execute(request2);

                string response2 = restResponse2.Content;




                try
                {
                    response2 = response2.Replace("[", string.Empty);
                    response2 = response2.Replace("]", string.Empty);

                    var ProcessingData2 = JObject.Parse(response2);


                    dataGridView2.Rows.Add(Symbol, Quantity, ProcessingData2.GetValue("exDate"), ProcessingData2.GetValue("amount"), float.Parse(ProcessingData2.GetValue("amount").ToString()) * Quantity, ProcessingData2.GetValue("frequency"), YearlyTotal(ProcessingData2.GetValue("frequency").ToString(), float.Parse(ProcessingData2.GetValue("amount").ToString()), Quantity));
                }

                catch
                {

                    dataGridView3.Rows.Add(Symbol, Quantity);

                }
            }
 
        }

        //load stock lists and populate tables
        private void FetchDividends_Click(object sender, EventArgs e)
        {

            string apikey = "Check Setup";

            if (File.Exists("API.Config") == true)
            {
                apikey = File.ReadAllText("API.Config");
            }

            else
            {
                MessageBox.Show("The API  Key is not present. Check the configuration menu.");
                return;
            }

            if (File.Exists("Stocks.Config") == true)
            {
                string[] Stocks = File.ReadAllLines("Stocks.Config");

                foreach (string Temp in Stocks)
                {
                    string[] Result = Temp.Split(',');
                    ProcessData(Result[0], int.Parse(Result[1]), apikey);
                }

            }

        }


        //open config menu
        private void ConfigButton_Click(object sender, EventArgs e)
        {
            Config MyConfig = new Config();
            MyConfig.Show();
        }
    }
}
