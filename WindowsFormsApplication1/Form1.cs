using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 0 +   1 -   2 *   3 /
        int Type = 0;
        Double Num1 = 0;
        Double Num0 = 0;
        bool LastChara = false;

        #region Add Numbers
        private void AddNum(int x)
        {
            if (LastChara)
            {
                LastChara = false;
                textBox.Text = x.ToString();
                return;
            } 
            textBox.Text += x.ToString();
            if (textBox.Text.Length > 1 && textBox.Text[0] == '0' && textBox.Text[1] != '.')
                textBox.Text = textBox.Text.Substring(1);
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            AddNum(0);
        }

        private void Num_1_Click(object sender, EventArgs e)
        {
            AddNum(1);
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            AddNum(2);
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            AddNum(3);
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            AddNum(4);
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            AddNum(5);
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            AddNum(6);
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            AddNum(7);
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            AddNum(8);
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            AddNum(9);
        }
        #endregion

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void Run()
        {
            Num1 = Convert.ToDouble(textBox.Text);
            if (!LastChara)
                switch (Type)
                {
                    case 0:
                        Num0 += Num1;
                        break;
                    case 1:
                        Num0 -= Num1;
                        break;
                    case 2:
                        Num0 *= Num1;
                        break;
                    case 3:
                        Num0 /= Num1;
                        break;
                }
            textBox.Text = Num0.ToString("#.####");
            LastChara = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            Num0 = 0;
            Num1 = 0;
            Type = 0;
            LastChara = false;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Run();
            Type = 0;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Run();
            Type = 0;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Run();
            Type = 1;
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Run();
            Type = 2;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Run();
            Type = 3;
        }

        //键盘按键
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return false;
        }
    }
}
