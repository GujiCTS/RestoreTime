using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRestoreTime
{
    public partial class Form1 : Form
    {
        private Factory factory = new Factory();
        private string originMsg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbRestoreType.SelectedIndex = 0;
            originMsg = lblMsg.Text;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            string Msg = factory.calculation(cbRestoreType.SelectedItem.ToString(), tbCurrentHP.Text.Trim(), tbMaxHP.Text.Trim());
            if (Msg.Contains("!"))
            {
                MessageBox.Show(Msg.Replace("!",""), "系統訊息", MessageBoxButtons.OK);
            }
            else
            {
                lblMsg.Text = originMsg + Msg;
            }
        }
    }
}
