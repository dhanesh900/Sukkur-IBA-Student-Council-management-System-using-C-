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
    public partial class studentDashBoard : Form
    {
        string CmsID=null;
        public studentDashBoard()
        {
            InitializeComponent();

        }
       //  Result r = new Result();
        public studentDashBoard(string id)
        {
            InitializeComponent();
            CmsID = id;
          //  Result.name = "ss";

        }
            SiscdbDataContext con = new SiscdbDataContext();
        int P1count = 0,P2count=0;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pParty1_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to vote for this?", "Confirm Vote", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Student s = con.Students.SingleOrDefault(x=>x.CMS == CmsID);
                s.casting = "1";
                con.SubmitChanges();
                if(btnp1.Checked==true)
                {
                    P1count++;
                    Reslt party = con.Reslts.Single(x => x.Id == 7);
                    party.Votes = party.Votes + 1;
                    con.SubmitChanges();

                }
                if (btnp2.Checked == true)
                {
                    P2count++;
                    Reslt party = con.Reslts.Single(x => x.Id == 8);
                    party.Votes = party.Votes + 1;
                    con.SubmitChanges();
                }
                Result.res[0] = P1count;
                Result.res[1] = P2count;
                MessageBox.Show("confrm msg is displayed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            this.Hide();
            l.ShowDialog();
               

        }

        private void studentDashBoard_Load(object sender, EventArgs e)
        {
            //var q = from p in con.Parties
            //      select p;
           Party p = con.Parties.SingleOrDefault(x => x.Id == 7);
            //pbParty1.Image =  p.Partylogo

            byte[] buffer = p.Partylogo.ToArray();
            MemoryStream memStream = new MemoryStream();
            memStream.Write(buffer, 0, buffer.Length);

            this.pbParty1.Image = Image.FromStream(memStream);
            this.lblparty1.Text = p.PartyName;

            Party p2 = con.Parties.SingleOrDefault(x => x.Id == 8);
            byte[] buffer2 = p2.Partylogo.ToArray();
            MemoryStream memStream2 = new MemoryStream();
            memStream2.Write(buffer2, 0, buffer2.Length);

            this.pbParty2.Image = Image.FromStream(memStream2);
            this.lblparty2.Text = p2.PartyName;

            // Dim sqlEmpmaster = con.Parties(GlobalVariable.CurrentCompany, 11111).FirstOrDefault;
            //  pbParty1.Image = byteArrayToImage(sqlEmpmaster.EMP_PT.ToArray());

            //  Image byteArrayToImage(byte[] byteArrayIn)
            //{
            //  MemoryStream stream = new MemoryStream(byteArrayIn);
            // Image ret = Image.FromStream(stream);
            //return ret;
            //}
        }

        

       
       
    }
}
