using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bfbnetarith
{
    public partial class Form1 : Form
    {
        private setting s = new setting();
        public Form1()
        {
            InitializeComponent();
            //GenerateCalculate();
        }

        //public const int WM_NCLBUTTONDBLCLK = 0xA3;
        //const int WM_NCLBUTTONDOWN = 0x00A1;
        //const int HTCAPTION = 2;
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
        //        return;
        //    if (m.Msg == WM_NCLBUTTONDBLCLK)
        //        return;

        //    base.WndProc(ref m);
        //}

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(s.ShowDialog() == DialogResult.OK){
                GenerateCalculate();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //GenerateCalculate();
        }

        public void GenerateCalculate()
        {
            this.tableDock.Controls.Clear();

            for (var i=0;i<4;i++)
            {
                for(var j=0;j<25;j++)
                {
                    generateOneCell(i, j);
                }
            }
        }

        public void generateOneCell(int m, int n)
        {
            long tick = DateTime.Now.Ticks;
            Random r1 = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            //Random r1 = new Random();
            var curOP = "";
            int a = 0;
            int b = 0;
            int total = 0;
            // 1. 随机到运算符
            if(s.opStrings.Count>0)
            {
                if (s.opStrings.Count > 1)
                {
                    // 需要随机出运算符
                    
                    int i = r1.Next(s.opStrings.Count);
                    curOP = s.opStrings[i];
                }
                else
                {
                    curOP = s.opStrings[0];
                }
            }
            else
            {
                return;
            }

            // 2. 随机到a数字
            if(s.is10)
            {
                //Random r2 = new Random();
                a = r1.Next(11);
                total = 10;
            }
            else
            {
                //Random r2 = new Random();
                a = r1.Next(21);
                total = 20;
            }

            //根据运算符判断b能够随机的范围
            //Random r3 = new Random();
            switch (curOP)
            {
                case "+":
                    b = r1.Next(total-a);
                    break;
                case "-":
                    int c = total - a;
                    if(a<c)
                    {
                        c = a;
                    }
                    b = r1.Next(c);
                    break;
                case "*":

                    break;
                case "/":

                    break;
            }

            // 生成算式
            switch(s.qType)
            {
                case "得数运算":
                    setResult(m, n, curOP, a, b);
                    break;
                case "填空运算":
                    setResult(m, n, curOP, a, b);
                    break;
                case "两边填空":
                    setResult(m, n, curOP, a, b);
                    break;
            }
        }

        public void setResult(int m, int n, string curOP, int a, int b)
        {
            var pnlCell1 = new System.Windows.Forms.Panel();
            this.tableDock.Controls.Add(pnlCell1, m, n);
            pnlCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCell1.SuspendLayout();

            var label1a = new System.Windows.Forms.Label();
            label1a.AutoSize = true;
            label1a.Text = a.ToString();
            label1a.Location = new System.Drawing.Point(5, 11);

            var label1o = new System.Windows.Forms.Label();
            label1o.AutoSize = true;
            label1o.Text = curOP;
            label1o.Location = new System.Drawing.Point(30, 11);

            var label1b = new System.Windows.Forms.Label();
            label1b.AutoSize = true;
            label1b.Text = b.ToString();
            label1b.Location = new System.Drawing.Point(55, 11);

            var label1e = new System.Windows.Forms.Label();
            label1e.AutoSize = true;
            label1e.Text = "=";
            label1e.Location = new System.Drawing.Point(80, 11);

            var textBox1 = new System.Windows.Forms.TextBox();
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(30, 23);
            textBox1.Location = new System.Drawing.Point(110, 5);


            pnlCell1.Controls.Add(textBox1);
            pnlCell1.Controls.Add(label1e);
            pnlCell1.Controls.Add(label1b);
            pnlCell1.Controls.Add(label1o);
            pnlCell1.Controls.Add(label1a);
        }
    }
}
