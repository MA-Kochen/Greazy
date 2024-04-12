using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Greazy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox12.Enabled = true;
                checkBox13.Enabled = true;
                checkBox14.Enabled = true;
                checkBox15.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label9.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                label12.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
                checkBox14.Enabled = false;
                checkBox15.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                checkBox16.Enabled = true;
                checkBox17.Enabled = true;
                checkBox27.Enabled = true;
                checkBox28.Enabled = true;
                checkBox29.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                label14.Enabled = true;
                label15.Enabled = true;
                label16.Enabled = true;
                textBox9.Enabled = true;
                textBox10.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
                textBox16.Enabled = true;
            }
            if (checkBox30.Checked == false)
            {
                checkBox16.Enabled = false;
                checkBox17.Enabled = false;
                checkBox27.Enabled = false;
                checkBox28.Enabled = false;
                checkBox29.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                textBox14.Enabled = false;
                textBox16.Enabled = false;
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                label19.Enabled = true;
                label20.Enabled = true;
                label21.Enabled = true;
                label22.Enabled = true;
                label5.Enabled = true;
                label13.Enabled = true;
                label17.Enabled = true;
                label18.Enabled = true;
                label23.Enabled = true;
                label24.Enabled = true;
                label25.Enabled = true;
                label26.Enabled = true;
                label27.Enabled = true;
                label28.Enabled = true;
                label29.Enabled = true;
                label30.Enabled = true;
                textBox19.Enabled = true;
                textBox20.Enabled = true;
                textBox21.Enabled = true;
                textBox22.Enabled = true;
                textBox11.Enabled = true;
                textBox15.Enabled = true;
                textBox17.Enabled = true;
                textBox18.Enabled = true;
                textBox27.Enabled = true;
                textBox28.Enabled = true;
                textBox29.Enabled = true;
                textBox30.Enabled = true;
                textBox23.Enabled = true;
                textBox24.Enabled = true;
                textBox25.Enabled = true;
                textBox26.Enabled = true;
            }
            if (checkBox36.Checked == false)
            {
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label5.Enabled = false;
                label13.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                textBox19.Enabled = false;
                textBox20.Enabled = false;
                textBox21.Enabled = false;
                textBox22.Enabled = false;
                textBox11.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                textBox27.Enabled = false;
                textBox28.Enabled = false;
                textBox29.Enabled = false;
                textBox30.Enabled = false;
                textBox23.Enabled = false;
                textBox24.Enabled = false;
                textBox25.Enabled = false;
                textBox26.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label32.Enabled = true;
                label34.Enabled = true;
                textBox32.Enabled = true;
                textBox34.Enabled = true;
            }
            if (radioButton1.Checked == false)
            {
                label32.Enabled = false;
                label34.Enabled = false;
                textBox32.Enabled = false;
                textBox34.Enabled = false;
            }
            if (radioButton2.Checked == true)
            {
                label31.Enabled = true;
                label33.Enabled = true;
                textBox31.Enabled = true;
                textBox33.Enabled = true;
            }
            if (radioButton2.Checked == false)
            {
                label31.Enabled = false;
                label33.Enabled = false;
                textBox31.Enabled = false;
                textBox33.Enabled = false;
            }
        }
    }
}
