using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksFuntion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2TextBox1.KeyPress += guna2TextBox1_KeyPress;

            guna2TextBox1.KeyPress += guna2TextBox1_KeyPress;
            guna2TextBox2.KeyPress += guna2TextBox2_KeyPress;
            guna2TextBox3.KeyPress += guna2TextBox3_KeyPress;
            guna2TextBox4.KeyPress += guna2TextBox4_KeyPress;
            guna2TextBox5.KeyPress += guna2TextBox5_KeyPress;
            guna2TextBox6.KeyPress += guna2TextBox6_KeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Get the current textbox
                Guna2TextBox textBox = sender as Guna2TextBox;

                // Get the index of the current textbox
                int index = Controls.IndexOf(textBox);

                // Check if there is a next textbox in the sequence
                if (index < Controls.Count - 1)
                {
                    // Get the next textbox
                    Guna2TextBox nextTextBox = Controls[index + 1] as Guna2TextBox;

                    // Set focus to the next textbox
                    nextTextBox.Focus();
                }

                // Consume the Enter key press event
                e.Handled = true;
            }

        }
        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
            {
           
 
        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
      } 