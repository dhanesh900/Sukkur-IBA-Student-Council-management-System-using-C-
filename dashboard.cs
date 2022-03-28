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
    public partial class Cdc : Form
    {
        int totStudents = 0, totCast = 0;
        public Cdc()
        {
            InitializeComponent();
            totStudents = (from s in con.Students
                           select s).Count();
            totCast = (from s in con.Students
                       where s.casting == "1"
                       select s).Count();
            lblTVoter.Text = "" + totStudents;
            lblCast.Text = " " + totCast;
        }
        SiscdbDataContext con = new SiscdbDataContext();
        
        private void Cdc_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
      
            lblAddress.Text += " " + "\n\n" + "Activity: SISC Elections 2021" + "\n\n" +
"Date: March 20, 2021" + "\n" +
"Time: 09:30 AM to 04:30 PM" + "\n" +
"Polling Station: Auditorium, Sukkur IBA University";
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            Position p = new Position();
            this.Hide();
            p.ShowDialog();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin l=new frmLogin();
            this.Hide();
            l.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cdc c = new Cdc();
            c.ShowDialog();
        }
        private int xPos = 12;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, \n dd MMMM yyyy \n \n       HH:mm:ss");
            if (912 == xPos)
            {
                //repeat marquee
                this.lblMain.Location = new System.Drawing.Point(12, 140);
                xPos = 12;
            }
            else
            {
                this.lblMain.Location = new System.Drawing.Point(xPos, 140);
                xPos+=10;
            }
        }

        private void btnElection_Click(object sender, EventArgs e)
        {
            party p = new party();
            this.Hide();
            p.ShowDialog();
        }

       
        private void btnCabinet_Click(object sender, EventArgs e)
        {
            cabinet c = new cabinet();
            this.Hide();
            c.ShowDialog();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoter_Click(object sender, EventArgs e)
        {
            voters v = new voters();
            this.Hide();
            v.ShowDialog();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            this.Hide();
            res.ShowDialog();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
