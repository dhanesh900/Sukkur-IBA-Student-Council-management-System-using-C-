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
    public partial class voters : Form
    {
        public voters()
        {
            InitializeComponent();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cdc back = new Cdc();
            this.Hide();
            back.ShowDialog();
        }
        SiscdbDataContext con = new SiscdbDataContext();

        private void voters_Load(object sender, EventArgs e)
        {
            var query = from s in con.Students select s;
            gvVoter.DataSource = query;
        }
    }
}
