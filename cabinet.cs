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
    public partial class cabinet : Form
    {
        public cabinet()
        {
            InitializeComponent();
        }
        SiscdbDataContext con = new SiscdbDataContext();

        private void cabinet_Load(object sender, EventArgs e)
        {
            var query = from c in con.Cabinets select c;
            gvCabi.DataSource = query;
        }

        private void btnAddCabinet_Click(object sender, EventArgs e)
        {
            AddCandidateForm acf = new AddCandidateForm();
            acf.ShowDialog();
            
            var query = from c in con.Cabinets select c;
            gvCabi.DataSource = query;
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cdc back = new Cdc();
            this.Hide();
            back.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
