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

namespace DivTracker
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();

            if (File.Exists("API.Config") == true)
            {
                string text = System.IO.File.ReadAllText(@"API.Config");
                this.APIKey.Text = text;
            }

            if (File.Exists("Stocks.Config") == true)
            {
                string [] Stocks = File.ReadAllLines("Stocks.Config");

                foreach (string Temp in Stocks)
                {
                    string[] Result = Temp.Split(',');
                    dataGridView1.Rows.Add(Result[0], Result[1]);
                }
                    
            }

            


        }

        public static string DGVtoString(DataGridView dgv)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value);
                        sb.Append(',');
                    }
                    sb.Remove(sb.Length - 1, 1); // Removes the last delimiter 
                    sb.AppendLine();
                
            }
            sb.Remove(sb.Length - 5, 5);

            return sb.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Config.ActiveForm.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Stocks.Config", DGVtoString(dataGridView1));
            File.WriteAllText("API.Config", APIKey.Text);
            Config.ActiveForm.Visible = false;
        }
    }
}
