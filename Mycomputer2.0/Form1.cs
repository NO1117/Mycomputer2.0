using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mycomputer2._0
{
    public partial class frmcs : Form
    {
        private double num1 = 0;    //第一操作数
        private double num2;        //第二操作数
        private string sign;        //运算符号
        private double num3;        //运算结果
        private bool check = true;  //检查是否为第一操作数
        private bool check1 = true;
        private double ans;         //记录上次运算结果
        private string error = "Error";
        public frmcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      //全部清除
        {
            textBox1.Text = "";     //文本框的值置空
            textBox2.Text = "";
            num1 = 0;
            num2 = 0;
            num3 = 0;
            ans = 0;
        }

        private void button2_Click(object sender, EventArgs e)      //撤销操作数
        {
            textBox1.Text = "";     //文本框的值置空
            if (check == true)
            {
                num1 = 0;
            } 
            else
            {
                num2 = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)      //除法运算
        {
            sign = "/";
            textBox2.Text = num1.ToString();
            textBox1.Text = "/";
            check = false;
        }

        private void button4_Click(object sender, EventArgs e)      //乘法运算
        {
            sign = "*";
            textBox2.Text = num1.ToString();
            textBox1.Text = "*";
            check = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";     
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)      //减法运算
        {
            sign = "-";
            textBox2.Text = num1.ToString();
            textBox1.Text = "-";
            check = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)         //加法运算
        {
            sign = "+";
            textBox2.Text = num1.ToString();
            textBox1.Text = "+";
            check = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (check1 == true)
            {
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                check1 = true;
                if (check == true)
                {
                    Button b = (Button)sender;                  //将该按钮的属性值赋给按钮b
                    textBox1.Text += b.Text;                    //追加文本框的值（PS：用于解决位数在两位或三位以上得值）
                    num1 = double.Parse(textBox1.Text);         //将文本框的值强制为double类型，并赋值给num1
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                    textBox1.Text = "";
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)         //“=”处理
        {
            switch (sign)
            {
                case "+":
                    num3 = num1 + num2;
                    break;
                case "-":
                    num3 = num1 - num2;
                    break;
                case "*":
                    num3 = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        textBox1.Text = error;
                    }
                    else
                    {
                        num3 = num1 / num2;
                    }
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        textBox1.Text = error;
                    }
                    else
                    {
                        num3 = num1 % num2;
                    }
                    break;
            }
            num1 = num3;
            textBox1.Text = num3.ToString();
            check = true;
            check1 = false;
        }

        private void button17_Click(object sender, EventArgs e)         //求余运算
        {
            sign = "%";
            textBox2.Text = num1.ToString();
            textBox1.Text = "%";
            check = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num1 = double.Parse(textBox1.Text);
            }
            else
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";    
                Button b = (Button)sender;
                textBox1.Text += b.Text;
                num2 = double.Parse(textBox1.Text);
            }
        }

        private void button19_Click(object sender, EventArgs e)     //小数点处理
        {
            if (textBox1.Text != "")                                //判断文本框不为空
            {
                if (check == true)
                {
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num1 = double.Parse(textBox1.Text);

                }
                else if (check == false)
                {
                    Button b = (Button)sender;
                    textBox1.Text += b.Text;
                    num2 = double.Parse(textBox1.Text);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
