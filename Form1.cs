using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        // Close program when button Cancel is press
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close program ");
            this.Close();
        }

        // Validate user and password when button Login is press
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUser.Text.Equals("admin") && textPassword.Text.Equals("1234"))
                {
                    MessageBox.Show("Login successful");
                    MenuSucessLogin menuSucessLogin = new MenuSucessLogin();
                    menuSucessLogin.Show();
                    this.Hide(); // hide form1 form after successful login
                }
                else
                {
                    MessageBox.Show("Password or User incorrect","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            } catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
