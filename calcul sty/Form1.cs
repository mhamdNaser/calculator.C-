using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcul_sty
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;
        string pro;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lb_result.Text == "0")
            {
                lb_result.Text = null;
                lb_result.Text = lb_result.Text + btn.Text;
            }
            else
            {
                lb_result.Text = lb_result.Text + btn.Text;
            }


            if(lb_calculating.Text!=null)
            {
                lb_calculating.Text = lb_calculating.Text + btn.Text;
            }
            else
            {
                lb_calculating.Text = lb_result.Text;
            }

        }

        private void pro_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Convert.ToDouble(lb_result.Text);
            pro = btn.Text;
            if(lb_calculating.Text!=null)
            {
                lb_calculating.Text = lb_calculating.Text + pro;
            }
            else
            {
                lb_calculating.Text = lb_result.Text + pro;
            }
            
            lb_result.Text = null;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            lb_result.Text = null;
            lb_calculating.Text = null;
            button43.Enabled = true;
            button44.Enabled = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num2 = Convert.ToDouble(lb_result.Text);
            if (pro == "+")
            {
                result = num1 + num2;
                lb_result.Text = Convert.ToString(result);
            }
            else if (pro == "-")
            {
                result = num1 - num2;
                lb_result.Text = Convert.ToString(result);
            }
            else if (pro == "*")
            {
                result = num1 * num2;
                lb_result.Text = Convert.ToString(result);
            }
            else if (pro == "/")
            {
                result = num1 / num2;
                lb_result.Text = Convert.ToString(result);
            }
        }

        private void pow_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Convert.ToDouble(lb_result.Text);
            result = num1 * num1;
            lb_result.Text = Convert.ToString(result);
            lb_calculating.Text = null;
        }

        private void sqrt_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Convert.ToDouble(lb_result.Text);
            result = Math.Sqrt(num1);
            lb_result.Text = Convert.ToString(result);
            lb_calculating.Text = null;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lb_result.Text == null)
            {
                lb_result.Text = "0";
            }
            else
            {
                lb_result.Text = lb_result.Text.Remove(lb_result.Text.Length - 1);
            }
            lb_calculating.Text = null;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (lb_calculating.Text == null)
            {
                lb_result.Text = "0";
            }
            else
            {
                int neg = System.Math.Abs(Convert.ToUInt16(lb_result.Text)) * (-1);
                lb_result.Text = Convert.ToString(neg);
                lb_calculating.Text = lb_result.Text;
            }
            button43.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            double per = Convert.ToDouble(lb_result.Text) / (100);
            lb_result.Text = Convert.ToString(per);
            lb_calculating.Text = null;
            button44.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double sina = System.Math.Sin(Convert.ToDouble(lb_result.Text));
            lb_result.Text = Convert.ToString(sina);
            lb_calculating.Text = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double cosa = System.Math.Cos(Convert.ToDouble(lb_result.Text));
            lb_result.Text = Convert.ToString(cosa);
            lb_calculating.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double sinb = System.Math.Sin(Convert.ToDouble(lb_result.Text));
            double cosb = System.Math.Cos(Convert.ToDouble(lb_result.Text));
            double tang = sinb / cosb;
            lb_calculating.Text = null;
            lb_result.Text = Convert.ToString(tang);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ( mem1.Text == "0")
            {
                mem1.Text = lb_result.Text;
                mem1.Visible = true;
            }
            else if (mem2.Text == "0")
            {
                mem2.Text = lb_result.Text;
                mem2.Visible = true;
            }
            else if (mem3.Text == "0")
            {
                mem3.Text = lb_result.Text;
                mem3.Visible = true;
            }
            else if (mem4.Text == "0")
            {
                mem4.Text = lb_result.Text;
                mem4.Visible = true;
            }
            else if (mem5.Text == "0")
            {
                mem5.Text = lb_result.Text;
                mem5.Visible = true;
            }
            else
            {
                MessageBox.Show("Mmory Is Full");
            }
            lb_result.Text = null;
            lb_calculating.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            mem1.Visible = false;
            mem1.Text = "0";
            mem2.Visible = false;
            mem2.Text = "0";
            mem3.Visible = false;
            mem3.Text = "0";
            mem4.Visible = false;
            mem4.Text = "0";
            mem5.Visible = false;
            mem5.Text = "0";
        }

        private void mem1_Click(object sender, EventArgs e)
        {
            lb_result.Text = mem1.Text;
            lb_calculating.Text = lb_calculating.Text + mem1.Text;
            mem1.Text = "0";
            mem1.Visible = false;
        }

        private void mem2_Click(object sender, EventArgs e)
        {
            lb_result.Text = mem2.Text;
            lb_calculating.Text = lb_calculating.Text + mem2.Text;
            mem2.Text = "0";
            mem2.Visible = false;
        }

        private void mem3_Click(object sender, EventArgs e)
        {
            lb_result.Text = mem3.Text;
            lb_calculating.Text = lb_calculating.Text + mem3.Text;
            mem3.Text = "0";
            mem3.Visible = false;
        }

        private void mem4_Click(object sender, EventArgs e)
        {
            lb_result.Text = mem4.Text;
            lb_calculating.Text = lb_calculating.Text + mem4.Text;
            mem4.Text = "0";
            mem4.Visible = false;
        }

        private void mem5_Click(object sender, EventArgs e)
        {
            lb_result.Text = mem5.Text;
            lb_calculating.Text = lb_calculating.Text + mem5.Text;
            mem5.Text = "0";
            mem5.Visible = false;
        }
    }
}
