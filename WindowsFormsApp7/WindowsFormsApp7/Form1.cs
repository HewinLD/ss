using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i=1;
        string 字符="一";
        int[] 数组 = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {           
            if (i != 11)
            {
                i++;
                if (i == 2) { 字符 = "二"; label1.Text = null; }
                else if (i == 3) 字符 = "三";
                else if (i == 4) 字符 = "四";
                else if (i == 5) 字符 = "五";
                else if (i == 6) 字符 = "六";
                else if (i == 7) 字符 = "七";
                else if (i == 8) 字符 = "八";
                else if (i == 9) 字符 = "九";
                else if (i == 10) 字符 = "十";
                button1.Text = i==11? "点击以排序":"请输入第" + 字符 + "个数";
                label1.Text += " " + textBox1.Text;
                数组[i - 2] = int.Parse(textBox1.Text);
                textBox1.Text = null;
            }
            else
            {
                List<int> numbers = new List<int>(数组);
                i = 1;
                label1.Text = "从小到大排序为：";
                button1.Text = "请输入第一个数";
                while (numbers.Count!=0)
                {
                    foreach (int j in numbers)
                    {
                        bool b = true;
                        foreach (int k in numbers)
                        {
                            if (j > k) { b = false; break; }
                        }
                        if (b)
                        {
                            numbers.Remove(j);
                            label1.Text += " " + j.ToString();
                            break;
                        }
                    }
                }
            }
        }
    }
}
