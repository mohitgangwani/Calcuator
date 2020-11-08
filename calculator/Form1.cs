using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool DotCount = true;
        string g_op = "+-.×÷";
        string gl_opp = "+-×÷";
        char gl_operation;
        int gl_eqlcounter = 0;
        bool gl_eqlenabled = false;
        string label;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            label1.Text += 1;
            gl_eqlenabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;
            
            gl_eqlenabled = true;
            label1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 9;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = null;

            gl_eqlenabled = true;
            label1.Text += 0;
        }
        private void buttondot_Click(object sender, EventArgs e)
        {
            if(DotCount == false)
            {

            }
            else
            {
                int len = label1.Text.Length;
                if(label1.Text[len - 1] == '+' || label1.Text[len - 1] == '-' || label1.Text[len - 1] == '×' || label1.Text[len - 1] == '÷')
                {
                    label1.Text += "0.";
                }
                else
                {
                    label1.Text += ".";
                }
                DotCount = false;
            }
            gl_eqlenabled = false;
        }


        private void buttonsub_Click(object sender, EventArgs e)
        {
            if(gl_eqlcounter>=1)
            {
                operate();
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '-';
                DotCount = true;
            }
            else
            {
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '-';
                DotCount = true;
            }
            gl_eqlcounter++;
            gl_eqlenabled = false;
        }
        private void buttonadd_Click(object sender, EventArgs e)
        {
            if(gl_eqlcounter>=1)
            {
                operate();
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '+';

                DotCount = true;
            }
            else
            {
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '+';

                DotCount = true;
            }
            gl_eqlcounter++;
            gl_eqlenabled = false;
        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            DotCount = true;
            gl_eqlcounter = 0;
            gl_eqlenabled = false;
        }

        private void buttonproduct_Click(object sender, EventArgs e)
        {
            if(gl_eqlcounter>=1)
            {
                operate();
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '×';
                DotCount = true;
            }
            else
            {
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '×';
                DotCount = true;
            }
            gl_eqlcounter++;
            gl_eqlenabled = false;
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            if(gl_eqlcounter>=1)
            {
                operate();
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '÷';
                DotCount = true;
            }
            else
            {
                int len = label1.Text.Length;
                if (g_op.Contains(label1.Text[len - 1]))
                {
                    label1.Text = label1.Text.Remove(len - 1);
                }
                label1.Text += '÷';
                DotCount = true;
            }
            gl_eqlcounter++;
            gl_eqlenabled = false;
        }

        private void buttonbs_Click(object sender, EventArgs e)
        {
            int len = label1.Text.Length;
           try
            {
                if (len == 1)
                {
                    label1.Text = label1.Text.Remove(len - 2);
                }
                
                if (label1.Text[len-1] == '+'|| label1.Text[len - 1] == '-'|| label1.Text[len - 1] == '×' || label1.Text[len - 1] == '÷')
                {
                    DotCount = false;
                }
                else if(label1.Text[len-1]=='.')
                {
                    DotCount = true;
                }
                label1.Text = label1.Text.Remove(len - 1);
            }
            catch(ArgumentOutOfRangeException)
            {
                label1.Text = "0";
            }
        }
        private void operate()
        {
            DotCount = false;
            int i, len;
            label = label1.Text;
            string substr;
            int checkneg = 0;
            int checkoperation = 2;
            float[] op = new float[16];
            float result = 0;
            int k = 0, opc = 0;
            len = label.Length;

            if (label[0] == '-')
            {
                StringBuilder sb = new StringBuilder(label);
                sb[0] = '0';
                label = sb.ToString();
                checkneg = 1;
            }
            for (i = 0; i < len; i++)
            {
                if (gl_opp.Contains(label[i]) || (i == len - 1))
                {

                    if ((gl_opp.Contains(label[i]) && i >= 1))
                    {
                        gl_operation = label[i];
                    }
                    if (k == i && k == (len - 1))
                    {
                        substr = label.Substring(i);
                        k = i + 1;
                    }

                    else if (i == len - 1)
                    {
                        substr = label.Substring(k, i - k + 1);
                    }
                    else if (k == 0)
                    {
                        substr = label.Substring(k, i - k);
                        k = i + 1;
                    }
                    else
                    {
                        substr = label.Substring(k, i - k);
                        k = i + 1;
                    }
                    if (opc == 0)
                    {
                        op[0] = float.Parse(substr);
                        opc++;
                    }
                    else
                    {
                        op[1] = float.Parse(substr);
                        label1.Text = op[0].ToString();

                    }

                }

                if (gl_opp.Contains(label[i]) || k == i + 1 || (op[0] != 0 && op[1] != 0))
                {
                    switch (gl_operation)
                    {
                        case '+':
                            result = op[0] + op[1];
                            checkoperation = 0;
                            break;

                        case '-':
                            result = op[0] - op[1];
                            checkoperation = 0;
                            break;

                        case '×':
                            result = op[0] * op[1];
                            checkoperation = 1;
                            break;

                        case '÷':
                            try
                            {
                                result = op[0] / op[1];
                            }
                            catch (DivideByZeroException)
                            {
                                label1.Text = "Can't divide by zero";
                            }
                            checkoperation = 1;
                            break;

                        default:
                            label1.Text = "Default ";
                            break;
                    }
                }
            }
            if (checkneg == 1)
            {
                if (checkoperation == 1)
                {
                    result = result * -1;
                }
                else if (checkoperation == 0)
                {
                    result = result - op[0] - op[0];
                }

            }
            label2.Text = label + " =";
            label1.Text = result.ToString();
            opc = 0;
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            if (gl_eqlenabled == true)
            {

                operate();
                gl_eqlenabled = false;
            }
            else
            {

            }
        }
    }
}