
namespace POSales
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRePass2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCurPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAccNote = new System.Windows.Forms.Label();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAccSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPassCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPassSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 80);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podešavanje Naloga";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(32, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(928, 452);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.btnAccCancel);
            this.metroTabPage1.Controls.Add(this.btnAccSave);
            this.metroTabPage1.Controls.Add(this.txtName);
            this.metroTabPage1.Controls.Add(this.cbRole);
            this.metroTabPage1.Controls.Add(this.txtRePass);
            this.metroTabPage1.Controls.Add(this.txtPass);
            this.metroTabPage1.Controls.Add(this.txtUsername);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(920, 410);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Kreiraj Nalog";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(265, 273);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(527, 26);
            this.txtName.TabIndex = 5;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Administrator",
            "Radnik"});
            this.cbRole.Location = new System.Drawing.Point(265, 220);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(527, 28);
            this.cbRole.TabIndex = 4;
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(265, 169);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(527, 26);
            this.txtRePass.TabIndex = 3;
            this.txtRePass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(265, 118);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(527, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(265, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(527, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Puno ime :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Uloga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ponovite Lozinku :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisničko ime :";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.btnPassCancel);
            this.metroTabPage2.Controls.Add(this.btnPassSave);
            this.metroTabPage2.Controls.Add(this.lblUsername);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.Controls.Add(this.txtRePass2);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.txtNPass);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.txtCurPass);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(920, 410);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Promeni Lozinku";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(176, 73);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 18);
            this.lblUsername.TabIndex = 36;
            this.lblUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtRePass2
            // 
            this.txtRePass2.Location = new System.Drawing.Point(280, 234);
            this.txtRePass2.Name = "txtRePass2";
            this.txtRePass2.Size = new System.Drawing.Size(527, 26);
            this.txtRePass2.TabIndex = 11;
            this.txtRePass2.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ponovite Lozinku :";
            // 
            // txtNPass
            // 
            this.txtNPass.Location = new System.Drawing.Point(280, 176);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.Size = new System.Drawing.Size(527, 26);
            this.txtNPass.TabIndex = 9;
            this.txtNPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nova Lozinka :";
            // 
            // txtCurPass
            // 
            this.txtCurPass.Location = new System.Drawing.Point(280, 121);
            this.txtCurPass.Name = "txtCurPass";
            this.txtCurPass.Size = new System.Drawing.Size(527, 26);
            this.txtCurPass.TabIndex = 7;
            this.txtCurPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Trenutna Lozinka :";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.gbUser);
            this.metroTabPage3.Controls.Add(this.btnProperties);
            this.metroTabPage3.Controls.Add(this.btnRemove);
            this.metroTabPage3.Controls.Add(this.dgvUser);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 1;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(920, 410);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Aktivni/ Neaktivni Nalozi";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 1;
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.White;
            this.gbUser.Controls.Add(this.pictureBox2);
            this.gbUser.Controls.Add(this.lblAccNote);
            this.gbUser.Controls.Add(this.btnResetPass);
            this.gbUser.Location = new System.Drawing.Point(14, 307);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(890, 100);
            this.gbUser.TabIndex = 23;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Lozinka Za Korisničko Ime";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblAccNote
            // 
            this.lblAccNote.AutoSize = true;
            this.lblAccNote.Location = new System.Drawing.Point(103, 27);
            this.lblAccNote.Name = "lblAccNote";
            this.lblAccNote.Size = new System.Drawing.Size(522, 20);
            this.lblAccNote.TabIndex = 0;
            this.lblAccNote.Text = "Da biste promenili lozinku za korisničko ime, kliknite na Restartuj Lozinku.";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnResetPass.FlatAppearance.BorderSize = 0;
            this.btnResetPass.ForeColor = System.Drawing.Color.Black;
            this.btnResetPass.Location = new System.Drawing.Point(662, 59);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(222, 35);
            this.btnResetPass.TabIndex = 22;
            this.btnResetPass.Text = "Restartuj Lozinku...";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProperties.FlatAppearance.BorderSize = 0;
            this.btnProperties.ForeColor = System.Drawing.Color.Black;
            this.btnProperties.Location = new System.Drawing.Point(793, 246);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(111, 35);
            this.btnProperties.TabIndex = 22;
            this.btnProperties.Text = "Svojstva";
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(676, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 35);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Ukloni";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.ColumnHeadersHeight = 30;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(14, 3);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.Size = new System.Drawing.Size(890, 237);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Br";
            this.Column1.Name = "Column1";
            this.Column1.Width = 46;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Korisničko Ime";
            this.Column2.Name = "Column2";
            this.Column2.Width = 137;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Puno Ime";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Aktiviranje Naloga";
            this.Column5.Name = "Column5";
            this.Column5.Width = 167;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Uloga";
            this.Column4.Name = "Column4";
            this.Column4.Width = 76;
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnAccCancel.BorderRadius = 18;
            this.btnAccCancel.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.CheckedState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.CheckedState.Parent = this.btnAccCancel;
            this.btnAccCancel.CustomImages.Parent = this.btnAccCancel;
            this.btnAccCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAccCancel.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.HoverState.Parent = this.btnAccCancel;
            this.btnAccCancel.Location = new System.Drawing.Point(697, 320);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.ShadowDecoration.BorderRadius = 50;
            this.btnAccCancel.ShadowDecoration.Parent = this.btnAccCancel;
            this.btnAccCancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnAccCancel.Size = new System.Drawing.Size(95, 35);
            this.btnAccCancel.TabIndex = 37;
            this.btnAccCancel.Text = "Poništi";
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // btnAccSave
            // 
            this.btnAccSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccSave.BackColor = System.Drawing.Color.Transparent;
            this.btnAccSave.BorderRadius = 18;
            this.btnAccSave.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnAccSave.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnAccSave.CheckedState.Parent = this.btnAccSave;
            this.btnAccSave.CustomImages.Parent = this.btnAccSave;
            this.btnAccSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnAccSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnAccSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccSave.ForeColor = System.Drawing.Color.White;
            this.btnAccSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnAccSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnAccSave.HoverState.Parent = this.btnAccSave;
            this.btnAccSave.Location = new System.Drawing.Point(596, 320);
            this.btnAccSave.Name = "btnAccSave";
            this.btnAccSave.ShadowDecoration.BorderRadius = 50;
            this.btnAccSave.ShadowDecoration.Parent = this.btnAccSave;
            this.btnAccSave.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnAccSave.Size = new System.Drawing.Size(95, 35);
            this.btnAccSave.TabIndex = 36;
            this.btnAccSave.Text = "Sačuvaj";
            this.btnAccSave.Click += new System.EventHandler(this.btnAccSave_Click);
            // 
            // btnPassCancel
            // 
            this.btnPassCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnPassCancel.BorderRadius = 18;
            this.btnPassCancel.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.CheckedState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.CheckedState.Parent = this.btnPassCancel;
            this.btnPassCancel.CustomImages.Parent = this.btnPassCancel;
            this.btnPassCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassCancel.ForeColor = System.Drawing.Color.Black;
            this.btnPassCancel.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.HoverState.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.HoverState.Parent = this.btnPassCancel;
            this.btnPassCancel.Location = new System.Drawing.Point(712, 284);
            this.btnPassCancel.Name = "btnPassCancel";
            this.btnPassCancel.ShadowDecoration.BorderRadius = 50;
            this.btnPassCancel.ShadowDecoration.Parent = this.btnPassCancel;
            this.btnPassCancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnPassCancel.Size = new System.Drawing.Size(95, 35);
            this.btnPassCancel.TabIndex = 39;
            this.btnPassCancel.Text = "Poništi";
            this.btnPassCancel.Click += new System.EventHandler(this.btnPassCancel_Click);
            // 
            // btnPassSave
            // 
            this.btnPassSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassSave.BackColor = System.Drawing.Color.Transparent;
            this.btnPassSave.BorderRadius = 18;
            this.btnPassSave.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnPassSave.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnPassSave.CheckedState.Parent = this.btnPassSave;
            this.btnPassSave.CustomImages.Parent = this.btnPassSave;
            this.btnPassSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnPassSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnPassSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassSave.ForeColor = System.Drawing.Color.White;
            this.btnPassSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnPassSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(174)))), ((int)(((byte)(117)))));
            this.btnPassSave.HoverState.Parent = this.btnPassSave;
            this.btnPassSave.Location = new System.Drawing.Point(611, 284);
            this.btnPassSave.Name = "btnPassSave";
            this.btnPassSave.ShadowDecoration.BorderRadius = 50;
            this.btnPassSave.ShadowDecoration.Parent = this.btnPassSave;
            this.btnPassSave.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.btnPassSave.Size = new System.Drawing.Size(95, 35);
            this.btnPassSave.TabIndex = 38;
            this.btnPassSave.Text = "Sačuvaj";
            this.btnPassSave.Click += new System.EventHandler(this.btnPassSave_Click);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KORISNICI";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.TextBox txtRePass2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAccNote;
        public System.Windows.Forms.Button btnResetPass;
        public System.Windows.Forms.Button btnProperties;
        public System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public Guna.UI2.WinForms.Guna2GradientButton btnAccCancel;
        public Guna.UI2.WinForms.Guna2GradientButton btnAccSave;
        public Guna.UI2.WinForms.Guna2GradientButton btnPassCancel;
        public Guna.UI2.WinForms.Guna2GradientButton btnPassSave;
    }
}