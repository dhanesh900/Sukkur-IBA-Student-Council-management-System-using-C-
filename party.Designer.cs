
namespace Sisc
{
    partial class party
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnb = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddParties = new Guna.UI2.WinForms.Guna2Button();
            this.btnClaer = new Guna.UI2.WinForms.Guna2Button();
            this.txtPartyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.partyPic = new System.Windows.Forms.PictureBox();
            this.gvParty = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.guna2CirclePictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 93);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parties For SISC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::Sisc.Properties.Resources.siscIcon;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(28, 12);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 1;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnb);
            this.panel4.Controls.Add(this.btnAddParties);
            this.panel4.Controls.Add(this.btnClaer);
            this.panel4.Controls.Add(this.txtPartyName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnUpload);
            this.panel4.Controls.Add(this.partyPic);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 477);
            this.panel4.TabIndex = 1;
            // 
            // btnb
            // 
            this.btnb.Animated = true;
            this.btnb.AnimatedGIF = true;
            this.btnb.CheckedState.Parent = this.btnb;
            this.btnb.CustomImages.Parent = this.btnb;
            this.btnb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnb.DisabledState.Parent = this.btnb;
            this.btnb.FillColor = System.Drawing.Color.Black;
            this.btnb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnb.ForeColor = System.Drawing.Color.White;
            this.btnb.HoverState.Parent = this.btnb;
            this.btnb.Image = global::Sisc.Properties.Resources.icons8_back;
            this.btnb.Location = new System.Drawing.Point(6, 6);
            this.btnb.Name = "btnb";
            this.btnb.ShadowDecoration.Parent = this.btnb;
            this.btnb.Size = new System.Drawing.Size(32, 29);
            this.btnb.TabIndex = 7;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnAddParties
            // 
            this.btnAddParties.BorderRadius = 20;
            this.btnAddParties.CheckedState.Parent = this.btnAddParties;
            this.btnAddParties.CustomImages.Parent = this.btnAddParties;
            this.btnAddParties.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddParties.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddParties.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddParties.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddParties.DisabledState.Parent = this.btnAddParties;
            this.btnAddParties.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddParties.ForeColor = System.Drawing.Color.White;
            this.btnAddParties.HoverState.Parent = this.btnAddParties;
            this.btnAddParties.Location = new System.Drawing.Point(136, 408);
            this.btnAddParties.Name = "btnAddParties";
            this.btnAddParties.ShadowDecoration.Parent = this.btnAddParties;
            this.btnAddParties.Size = new System.Drawing.Size(92, 32);
            this.btnAddParties.TabIndex = 6;
            this.btnAddParties.Text = "Add";
            this.btnAddParties.Click += new System.EventHandler(this.btnAddParties_Click);
            // 
            // btnClaer
            // 
            this.btnClaer.BorderRadius = 20;
            this.btnClaer.CheckedState.Parent = this.btnClaer;
            this.btnClaer.CustomImages.Parent = this.btnClaer;
            this.btnClaer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClaer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClaer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClaer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClaer.DisabledState.Parent = this.btnClaer;
            this.btnClaer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClaer.ForeColor = System.Drawing.Color.White;
            this.btnClaer.HoverState.Parent = this.btnClaer;
            this.btnClaer.Location = new System.Drawing.Point(28, 408);
            this.btnClaer.Name = "btnClaer";
            this.btnClaer.ShadowDecoration.Parent = this.btnClaer;
            this.btnClaer.Size = new System.Drawing.Size(92, 32);
            this.btnClaer.TabIndex = 5;
            this.btnClaer.Text = "Clear";
            this.btnClaer.Click += new System.EventHandler(this.btnClaer_Click);
            // 
            // txtPartyName
            // 
            this.txtPartyName.BorderRadius = 20;
            this.txtPartyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPartyName.DefaultText = "Enter party Name";
            this.txtPartyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPartyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPartyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPartyName.DisabledState.Parent = this.txtPartyName;
            this.txtPartyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPartyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPartyName.FocusedState.Parent = this.txtPartyName;
            this.txtPartyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPartyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPartyName.HoverState.Parent = this.txtPartyName;
            this.txtPartyName.Location = new System.Drawing.Point(28, 332);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.PasswordChar = '\0';
            this.txtPartyName.PlaceholderText = "";
            this.txtPartyName.SelectedText = "";
            this.txtPartyName.SelectionStart = 16;
            this.txtPartyName.ShadowDecoration.Parent = this.txtPartyName;
            this.txtPartyName.Size = new System.Drawing.Size(200, 36);
            this.txtPartyName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Party Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpload
            // 
            this.btnUpload.BorderRadius = 20;
            this.btnUpload.CheckedState.Parent = this.btnUpload;
            this.btnUpload.CustomImages.Parent = this.btnUpload;
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.DisabledState.Parent = this.btnUpload;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.HoverState.Parent = this.btnUpload;
            this.btnUpload.Location = new System.Drawing.Point(63, 232);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.ShadowDecoration.Parent = this.btnUpload;
            this.btnUpload.Size = new System.Drawing.Size(92, 32);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // partyPic
            // 
            this.partyPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partyPic.Location = new System.Drawing.Point(48, 81);
            this.partyPic.Name = "partyPic";
            this.partyPic.Size = new System.Drawing.Size(124, 145);
            this.partyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.partyPic.TabIndex = 0;
            this.partyPic.TabStop = false;
            // 
            // gvParty
            // 
            this.gvParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvParty.Location = new System.Drawing.Point(236, 93);
            this.gvParty.Name = "gvParty";
            this.gvParty.Size = new System.Drawing.Size(526, 477);
            this.gvParty.TabIndex = 2;
            // 
            // party
            // 
            this.ClientSize = new System.Drawing.Size(789, 570);
            this.Controls.Add(this.gvParty);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "party";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.party_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvParty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAddParty;
        private Guna.UI2.WinForms.Guna2TextBox txtParty;
        private System.Windows.Forms.Label lblPartyName;
        private Guna.UI2.WinForms.Guna2Button btnLogoUplaod;
        private System.Windows.Forms.PictureBox PartyLogo;
        private System.Windows.Forms.DataGridView gvParties;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnAddParties;
        private Guna.UI2.WinForms.Guna2Button btnClaer;
        private Guna.UI2.WinForms.Guna2TextBox txtPartyName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private System.Windows.Forms.PictureBox partyPic;
        private System.Windows.Forms.DataGridView gvParty;
        private Guna.UI2.WinForms.Guna2Button btnb;
    }
}