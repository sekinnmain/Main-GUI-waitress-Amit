using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waiter_Service
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InstructionBox.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 9)
            {
                i++;
                if (i % 2 != 0)
                {
                    panel1.Visible = true;
                }
                else
                {
                    panel2.Visible = true;
                }
            }
            else
            {
                panel5.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 9)
            {
                WorkersMenu workersMenu = new WorkersMenu();
                workersMenu.Show();
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }
    }
}
