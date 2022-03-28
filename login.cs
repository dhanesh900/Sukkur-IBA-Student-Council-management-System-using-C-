using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisc
{
    public partial class frmLogin : Form
    {
        string username, pass;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Modecmbox.Items.Add("Admin");
            Modecmbox.Items.Add("Student");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (Modecmbox.SelectedIndex == 0)
            {
                if (this.UserTxt.Text == "")
                {
                    username = "";

                }
                if (PasswordTxt.Text == "")
                {
                    pass = "";
                }
                username = UserTxt.Text;
                pass = PasswordTxt.Text;
                if (username == "admin" && pass == "admin")
                {
                    //MessageBox.Show("authentication was successful");
                  //  lblLoginRes.Text = "authentication was successful";
                   Cdc dashboard = new Cdc();
                    this.Hide();
                    dashboard.ShowDialog();
                }
                else if (username == ""  || pass == "")
                {
                    lblLoginRes.Text="username and password must be provided";
                }
                else
                {
                    lblLoginRes.Text = "the authentication was not successful ";
                    this.UserTxt.Text = "";
                    this.PasswordTxt.Text = "";
                }


               // SiscdbDataContext context = new SiscdbDataContext();
               // var user = (from s in context.Users
              //              where s.CMS_ == 123
                //            select s).First();
                //MessageBox.Show(user.CMS_.ToString());

               

            }
            if (Modecmbox.SelectedIndex == 1)
            {
                if (this.UserTxt.Text == "")
                {
                    username = "";

                }
                if (PasswordTxt.Text == "")
                {
                    pass = "";
                }
                username = UserTxt.Text;
                pass = PasswordTxt.Text;
                SiscdbDataContext context = new SiscdbDataContext();
                var StudentTable = from s in context.GetTable<Student>()
                                   select s;
                foreach (var item in StudentTable)
                {
                    if (username == item.CMS && pass == item.Password)
                    {

                        studentDashBoard Sdashboard = new studentDashBoard(username);
                        this.Hide();
                        Sdashboard.ShowDialog();
                    }
                }
                 if (username == "" || pass == "")
                {
                    lblLoginRes.Text = "username and password must be provided";
                }
                else
                {
                    lblLoginRes.Text = "the authentication was not successful ";
                    this.UserTxt.Text = "";
                    this.PasswordTxt.Text = "";
                }
              
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            this.Hide();
            s.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
