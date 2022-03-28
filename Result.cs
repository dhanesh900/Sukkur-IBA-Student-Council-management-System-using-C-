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
    public partial class Result : Form
    {

        public Result()
        {
            InitializeComponent();

        }
        public static int[] res = new int[] { 0, 0 };
        public static string name="";

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Cdc back = new Cdc();
            this.Hide();
            back.ShowDialog();
        }
        SiscdbDataContext con = new SiscdbDataContext();

        private void Result_Load(object sender, EventArgs e)
        {
            var query = from p in con.Parties select p;

            int count = 0;
            Reslt party1 = con.Reslts.Single(x => x.Id == 7);
            Result.res[0]= (int)party1.Votes;
            Reslt party2 = con.Reslts.Single(x => x.Id == 8);
            Result.res[1] = (int)party2.Votes;

            foreach (var v in query)
            {
                string[] row = new string[] { ""+v.Id, ""+v.PartyName ,""+ Result.res[count++]};
                newGrid.Rows.Add(row);
            }

            if(Result.res[0] > Result.res[1])
            {
                lblWinner.Text += "party1";
            }
            if (Result.res[1] > Result.res[0])
            {
                lblWinner.Text += "party2";
            }
            //  gvRes.Columns.Add

        }
    }
}
