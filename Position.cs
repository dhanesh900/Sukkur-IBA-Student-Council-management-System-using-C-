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
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }
        SiscdbDataContext con = new SiscdbDataContext();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cdc back = new Cdc();
            this.Hide();
            back.ShowDialog();
        }

         private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SiscdbDataContext context = new SiscdbDataContext())
            {
                partyPosition PP = new partyPosition();


                PP.PositionName = txtPosition.Text;
               

                context.partyPositions.InsertOnSubmit(PP);

                context.SubmitChanges();
                txtPosition.Text = "";
                var query = from p in con.partyPositions select p;
                gvp.DataSource = query;

            }
        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }
        
        private void Position_Load(object sender, EventArgs e)
        {
            var query = from p in con.partyPositions select p;
            gvp.DataSource = query;
        }
    }
}
