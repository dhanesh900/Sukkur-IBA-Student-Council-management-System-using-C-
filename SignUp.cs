using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisc
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void FNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("wait for CDC approval");
            using (SiscdbDataContext context = new SiscdbDataContext())
            {
                Student s = new Student();
                s.FullName = FNameTxt.Text;
                s.Email = EmailTxt.Text;
                s.CMS = Cmstxt.Text;
                s.Department = departmentTxt.Text;
                s.Password = passTxt.Text;
                s.Semester = SemesterTxt.Text;
                //Bitmap default_image = new Bitmap(StudentPic.Image);
                /*
                try
                {
                    FileStream fileStream = new FileStream(this.StudentPic.ImageLocation, FileMode.Open, FileAccess.Read);

                    byte[] buffer = new byte[fileStream.Length];
                    fileStream.Read(buffer, 0, (int)fileStream.Length);
                    s.photo = buffer;
                    fileStream.Close();
                }
                catch
                {

                }*/

                using (MemoryStream ms = new MemoryStream())
               {
                    StudentPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    var binary = new System.Data.Linq.Binary(ms.GetBuffer());
                    s.photo = binary;
                }
                // s.photo = binary;
                //s.photo = StudentPic.Image;
                context.Students.InsertOnSubmit(s);
                context.SubmitChanges();
            }
            this.Hide();
            frmLogin back = new frmLogin();
            back.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StudentPic.Image = new Bitmap(ofd.FileName);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
