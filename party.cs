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
    public partial class party : Form
    {
        public party()
        {
            InitializeComponent();
        }

        string partyName;

        private void b1_Click(object sender, EventArgs e)
        {

        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                partyPic.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnClaer_Click(object sender, EventArgs e)
        {
            txtPartyName.Text = "";
            partyPic.Image = null;
        }

       
          


        

        private void btnAddParties_Click(object sender, EventArgs e)
        {
            using (SiscdbDataContext context = new SiscdbDataContext())
            {
                Party p = new Party();
                

                p.PartyName = txtPartyName.Text;
                using (MemoryStream ms = new MemoryStream())
                {
                    partyPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    var binary = new System.Data.Linq.Binary(ms.GetBuffer());
                    p.Partylogo = binary;
                }

                context.Parties.InsertOnSubmit(p);
                    
                context.SubmitChanges();
                txtPartyName.Text = "";
                partyPic.Image = null;
                var query = from pp in con.Parties select pp;
                gvParty.DataSource = query;
                //  gvParties.DataSource = dt;
                // gvParty.DataBind();
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            Cdc back = new Cdc();
            this.Hide();
            back.ShowDialog();
        }
        SiscdbDataContext con = new SiscdbDataContext();
        private void party_Load(object sender, EventArgs e)
        {
            var query = from p in con.Parties select p;
            gvParty.DataSource = query;
        }
    }
}
