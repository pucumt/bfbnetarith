using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bfbnetarith
{
    public partial class setting : Form
    {
        public bool is10 = true;
        public List<string> opStrings = new List<string>();
        public string qType = "";
        public setting()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.is10 = rdb10.Checked;
            this.opStrings.Clear();
            if(chkplus.Checked)
            {
                this.opStrings.Add("+");
            }
            if (chkminus.Checked)
            {
                this.opStrings.Add("-");
            }
            if (chkMulti.Checked)
            {
                this.opStrings.Add("*");
            }
            if (chkDivide.Checked)
            {
                this.opStrings.Add("/");
            }
            this.qType = cmbType.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
        }
    }
}
