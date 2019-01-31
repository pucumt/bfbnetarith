using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void GenerateCalculate()
        {
            this.tableDock.Controls.Clear();
            for(var j=0;j<25;j++)
            {
            for (var i=0;i<4;i++)
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
            Thread.Sleep(2);
        }

        public void setResult(int m, int n, string curOP, int a, int b)
        {
            var pnlCell1 = new System.Windows.Forms.Panel();
            this.tableDock.Controls.Add(pnlCell1, m, n);
            pnlCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCell1.SuspendLayout();

            var font = Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableDock.Font = font;

            var label1a = new System.Windows.Forms.Label();
            label1a.AutoSize = true;
            label1a.Text = a.ToString();
            //label1a.Font = font;
            label1a.Location = new System.Drawing.Point(5, 3);

            var label1o = new System.Windows.Forms.Label();
            label1o.AutoSize = true;
            label1o.Text = curOP;
            //label1o.Font = font;
            label1o.Location = new System.Drawing.Point(30, 3);

            var label1b = new System.Windows.Forms.Label();
            label1b.AutoSize = true;
            label1b.Text = b.ToString();
            //label1b.Font = font;
            label1b.Location = new System.Drawing.Point(55, 3);

            var label1e = new System.Windows.Forms.Label();
            label1e.AutoSize = true;
            label1e.Text = "=";
            //label1e.Font = font;
            label1e.Location = new System.Drawing.Point(80, 3);

            var textBox1 = new System.Windows.Forms.TextBox();
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(30, 23);
            textBox1.Location = new System.Drawing.Point(110, 0);


            pnlCell1.Controls.Add(textBox1);
            pnlCell1.Controls.Add(label1e);
            pnlCell1.Controls.Add(label1b);
            pnlCell1.Controls.Add(label1o);
            pnlCell1.Controls.Add(label1a);
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // export
            XSSFWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("test");
            try
            {
                FileStream fs = File.OpenWrite("test.xlsx");
                workbook.Write(fs);
                fs.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void RegeneratgeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (s.ShowDialog() == DialogResult.OK)
            {
                GenerateCalculate();
            }
        }
    }
}
