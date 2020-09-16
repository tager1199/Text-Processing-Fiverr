using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MattyCon3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            double profit = 0.0;
            double total = 0.0;
            int place = 0;
            string[] lines = Input.Text.Split('\n');
            foreach (string i in lines)
            {
                string[] words = i.Split(' ');
                
                foreach (string j in words)
                {
                    bool isDouble = Double.TryParse(j, out profit);
                    bool isInt = Int32.TryParse(j, out place);
                    if (isDouble && !isInt)
                        break;
                }
                total += profit;
            }
            Total.Text = "£" + total.ToString();
        }
    }
}
