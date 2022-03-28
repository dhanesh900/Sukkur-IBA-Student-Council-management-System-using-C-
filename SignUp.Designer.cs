
namespace Sisc
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignup = new Guna.UI2.WinForms.Guna2Button();
            this.SemesterTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.departmentTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.StudentPic = new System.Windows.Forms.PictureBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.passTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.Cmstxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCMS = new System.Windows.Forms.Label();
            this.EmailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.FNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(146)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sisc.Properties.Resources.vote;
            this.pictureBox2.Location = new System.Drawing.Point(688, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(205, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(409, 56);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Student Registation For Vote";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sisc.Properties.Resources.logo_white;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.btnSignup);
            this.panel2.Controls.Add(this.SemesterTxt);
            this.panel2.Controls.Add(this.departmentTxt);
            this.panel2.Controls.Add(this.StudentPic);
            this.panel2.Controls.Add(this.lblSemester);
            this.panel2.Controls.Add(this.passTxt);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.Cmstxt);
            this.panel2.Controls.Add(this.lblCMS);
            this.panel2.Controls.Add(this.EmailTxt);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.FNameTxt);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 434);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpload.BorderRadius = 20;
            this.btnUpload.CheckedState.Parent = this.btnUpload;
            this.btnUpload.CustomImages.Parent = this.btnUpload;
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.DisabledState.Parent = this.btnUpload;
            this.btnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(146)))));
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.HoverState.Parent = this.btnUpload;
            this.btnUpload.Location = new System.Drawing.Point(531, 189);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.ShadowDecoration.Parent = this.btnUpload;
            this.btnUpload.Size = new System.Drawing.Size(146, 31);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.BorderColor = System.Drawing.Color.DimGray;
            this.btnSignup.BorderRadius = 20;
            this.btnSignup.CheckedState.Parent = this.btnSignup;
            this.btnSignup.CustomImages.Parent = this.btnSignup;
            this.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignup.DisabledState.Parent = this.btnSignup;
            this.btnSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(146)))));
            this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.HoverState.Parent = this.btnSignup;
            this.btnSignup.Location = new System.Drawing.Point(279, 377);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.ShadowDecoration.Parent = this.btnSignup;
            this.btnSignup.Size = new System.Drawing.Size(180, 45);
            this.btnSignup.TabIndex = 13;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // SemesterTxt
            // 
            this.SemesterTxt.BorderRadius = 10;
            this.SemesterTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SemesterTxt.DefaultText = "";
            this.SemesterTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SemesterTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SemesterTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SemesterTxt.DisabledState.Parent = this.SemesterTxt;
            this.SemesterTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SemesterTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SemesterTxt.FocusedState.Parent = this.SemesterTxt;
            this.SemesterTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SemesterTxt.HoverState.Parent = this.SemesterTxt;
            this.SemesterTxt.Location = new System.Drawing.Point(376, 316);
            this.SemesterTxt.Name = "SemesterTxt";
            this.SemesterTxt.PasswordChar = '\0';
            this.SemesterTxt.PlaceholderText = "";
            this.SemesterTxt.SelectedText = "";
            this.SemesterTxt.ShadowDecoration.Parent = this.SemesterTxt;
            this.SemesterTxt.Size = new System.Drawing.Size(251, 28);
            this.SemesterTxt.TabIndex = 12;
            // 
            // departmentTxt
            // 
            this.departmentTxt.BorderRadius = 10;
            this.departmentTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.departmentTxt.DefaultText = "";
            this.departmentTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.departmentTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.departmentTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.departmentTxt.DisabledState.Parent = this.departmentTxt;
            this.departmentTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.departmentTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departmentTxt.FocusedState.Parent = this.departmentTxt;
            this.departmentTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departmentTxt.HoverState.Parent = this.departmentTxt;
            this.departmentTxt.Location = new System.Drawing.Point(376, 237);
            this.departmentTxt.Name = "departmentTxt";
            this.departmentTxt.PasswordChar = '\0';
            this.departmentTxt.PlaceholderText = "";
            this.departmentTxt.SelectedText = "";
            this.departmentTxt.ShadowDecoration.Parent = this.departmentTxt;
            this.departmentTxt.Size = new System.Drawing.Size(251, 28);
            this.departmentTxt.TabIndex = 11;
            // 
            // StudentPic
            // 
            this.StudentPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudentPic.Location = new System.Drawing.Point(531, 38);
            this.StudentPic.Name = "StudentPic";
            this.StudentPic.Size = new System.Drawing.Size(146, 148);
            this.StudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudentPic.TabIndex = 10;
            this.StudentPic.TabStop = false;
            // 
            // lblSemester
            // 
            this.lblSemester.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(362, 290);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(106, 23);
            this.lblSemester.TabIndex = 9;
            this.lblSemester.Text = "Semester";
            this.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passTxt
            // 
            this.passTxt.BorderRadius = 10;
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.DefaultText = "";
            this.passTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxt.DisabledState.Parent = this.passTxt;
            this.passTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxt.FocusedState.Parent = this.passTxt;
            this.passTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxt.HoverState.Parent = this.passTxt;
            this.passTxt.Location = new System.Drawing.Point(64, 316);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '\0';
            this.passTxt.PlaceholderText = "";
            this.passTxt.SelectedText = "";
            this.passTxt.ShadowDecoration.Parent = this.passTxt;
            this.passTxt.Size = new System.Drawing.Size(251, 28);
            this.passTxt.TabIndex = 8;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(362, 211);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(106, 23);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "Department";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(42, 290);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmstxt
            // 
            this.Cmstxt.BorderRadius = 10;
            this.Cmstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cmstxt.DefaultText = "";
            this.Cmstxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Cmstxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Cmstxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cmstxt.DisabledState.Parent = this.Cmstxt;
            this.Cmstxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cmstxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmstxt.FocusedState.Parent = this.Cmstxt;
            this.Cmstxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmstxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmstxt.HoverState.Parent = this.Cmstxt;
            this.Cmstxt.Location = new System.Drawing.Point(64, 237);
            this.Cmstxt.Name = "Cmstxt";
            this.Cmstxt.PasswordChar = '\0';
            this.Cmstxt.PlaceholderText = "";
            this.Cmstxt.SelectedText = "";
            this.Cmstxt.ShadowDecoration.Parent = this.Cmstxt;
            this.Cmstxt.Size = new System.Drawing.Size(251, 28);
            this.Cmstxt.TabIndex = 5;
            // 
            // lblCMS
            // 
            this.lblCMS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMS.Location = new System.Drawing.Point(42, 211);
            this.lblCMS.Name = "lblCMS";
            this.lblCMS.Size = new System.Drawing.Size(89, 23);
            this.lblCMS.TabIndex = 4;
            this.lblCMS.Text = "CMS ID";
            this.lblCMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailTxt
            // 
            this.EmailTxt.BorderRadius = 10;
            this.EmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxt.DefaultText = "";
            this.EmailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxt.DisabledState.Parent = this.EmailTxt;
            this.EmailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxt.FocusedState.Parent = this.EmailTxt;
            this.EmailTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxt.HoverState.Parent = this.EmailTxt;
            this.EmailTxt.Location = new System.Drawing.Point(64, 158);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PasswordChar = '\0';
            this.EmailTxt.PlaceholderText = "";
            this.EmailTxt.SelectedText = "";
            this.EmailTxt.ShadowDecoration.Parent = this.EmailTxt;
            this.EmailTxt.Size = new System.Drawing.Size(251, 28);
            this.EmailTxt.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(42, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNameTxt
            // 
            this.FNameTxt.BorderRadius = 10;
            this.FNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FNameTxt.DefaultText = "";
            this.FNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FNameTxt.DisabledState.Parent = this.FNameTxt;
            this.FNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FNameTxt.FocusedState.Parent = this.FNameTxt;
            this.FNameTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FNameTxt.HoverState.Parent = this.FNameTxt;
            this.FNameTxt.Location = new System.Drawing.Point(64, 92);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.PasswordChar = '\0';
            this.FNameTxt.PlaceholderText = "";
            this.FNameTxt.SelectedText = "";
            this.FNameTxt.ShadowDecoration.Parent = this.FNameTxt;
            this.FNameTxt.Size = new System.Drawing.Size(251, 28);
            this.FNameTxt.TabIndex = 1;
            this.FNameTxt.TextChanged += new System.EventHandler(this.FNameTxt_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(42, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox FNameTxt;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxt;
        private Guna.UI2.WinForms.Guna2Button btnSignup;
        private Guna.UI2.WinForms.Guna2TextBox SemesterTxt;
        private Guna.UI2.WinForms.Guna2TextBox departmentTxt;
        private System.Windows.Forms.PictureBox StudentPic;
        private System.Windows.Forms.Label lblSemester;
        private Guna.UI2.WinForms.Guna2TextBox passTxt;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox Cmstxt;
        private System.Windows.Forms.Label lblCMS;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
    }
}