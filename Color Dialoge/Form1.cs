using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Dialoge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectColor_Click(object sender, EventArgs e)
        {
            DialogResult rd = myColor.ShowDialog();
            if(rd == DialogResult.OK)
            {
                lblName.Text = myColor.Color.Name;
                lblA.Text = myColor.Color.A.ToString();
                lblR.Text = myColor.Color.R.ToString();
                lblG.Text = myColor.Color.G.ToString();
                lblB.Text = myColor.Color.B.ToString();
                picColor.BackColor = myColor.Color;
                if(myColor.Color != Color.White)
                {
                    btnSelectColor.BackColor = myColor.Color;
                }
            }
        }
    }
}
