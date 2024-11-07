using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paving_And_Fencing_Quote
{
    public partial class Main : Form
    {
        double pavingLength = 0;
        double pavingWidth = 0;
        double fencingLength = 0;
        double pavingArea = 0;
        double costPaving = 0;
        double costFencing = 0;
        double totalCostPaving = 0;
        double totalCostFencing = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            pavingLength = Convert.ToDouble(tbLengthPaving_Main.Text);
            pavingWidth = Convert.ToDouble(tbWidthPaving_Main.Text);
            pavingArea = pavingLength * pavingWidth;

            fencingLength = Convert.ToDouble(tbLengthFence_Main.Text);

            costPaving = Convert.ToDouble(tbCostPaving_Main.Text);
            costFencing = Convert.ToDouble(tbCostFencing_Main.Text);

            totalCostPaving = pavingArea * costPaving;
            totalCostFencing = fencingLength * costFencing;

            tbCostFence_Main.Text = totalCostFencing.ToString();
            tbCostPave_Main.Text = totalCostPaving.ToString();
        }

        private void btnNextQ_Main_Click(object sender, EventArgs e)
        {
            tbLengthPaving_Main.Text = "";
            tbWidthPaving_Main.Text = "";
            tbLengthFence_Main.Text = "";
            tbCostPaving_Main.Text = "";
            tbCostFencing_Main.Text = "";
            tbCostFence_Main.Text = "";
            tbCostPave_Main.Text = "";
        }

        private void btnExit_Main_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
