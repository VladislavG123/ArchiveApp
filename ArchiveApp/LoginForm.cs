using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveApp
{
    public partial class LoginForm : Form
    {
        private string login = "admin";
        private string password = "123";

        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginFormLoad(object sender, EventArgs e)
        {

        }

        private void EnterButtonClick(object sender, EventArgs e)
        {
            if (loginTextBox.Text == login && passwordTextBox.Text == password)
            {
                Close();
                return;
            }
            MessageBox.Show("Логин или пароль введены неверно!");
        }
    }
}
