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
    public partial class AddCandidateForm : Form
    {
        public AddCandidateForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSemester_Click(object sender, EventArgs e)
        {

        }

        private void lblGPA_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cabinet c = new cabinet();
            this.Hide();
            c.ShowDialog();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SiscdbDataContext context = new SiscdbDataContext())
            {
                Cabinet cdb = new Cabinet();
                cdb.fullName = txtFName.Text;
                cdb.Email = txtEmail.Text;
                cdb.Department = txtDepartment.Text;
                cdb.CGPA = txtCGPA.Text;
                cdb.Semester = txtSemester.Text;
                cdb.Mobile = TxtMobile.Text;
                cdb.CMS = txtCmsId.Text;
                cdb.partyID = (cbParty.SelectedIndex)+7;
                cdb.positionID = (cbPosition.SelectedIndex)+4;

                using (MemoryStream ms = new MemoryStream())
                {
                    cabinetPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    var binary = new System.Data.Linq.Binary(ms.GetBuffer());
                    cdb.cpic = binary;
                }
                context.Cabinets.InsertOnSubmit(cdb);

                context.SubmitChanges();
            }

            cabinet c = new cabinet();
            this.Hide();
            c.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cabinetPic.Image = new Bitmap(ofd.FileName);
            }

        }

        private void AddCandidateForm_Load(object sender, EventArgs e)
        {
            SiscdbDataContext context = new SiscdbDataContext();
            var listparties = (from i in context.Parties select i).ToList();
            cbParty.ValueMember = "PartyName";
            cbParty.DataSource = listparties;

          
            var listposition = (from j in context.partyPositions select j).ToList();
            cbPosition.ValueMember = "PositionName";
            cbPosition.DataSource = listposition;

        }
        int position_id = 0;

        private void cbParty_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  int party = (cbParty.SelectedIndex)+1;

            //SiscdbDataContext context = new SiscdbDataContext();

            //partyPosition p = context.partyPositions.SingleOrDefault(x => x.PositionName == cbParty.SelectedItem.ToString());
            //position_id = p.Id;
           // MessageBox.Show(Convert.ToString(party));
        }
    }
}
