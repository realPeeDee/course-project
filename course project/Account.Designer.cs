namespace course_project
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.lab_log = new System.Windows.Forms.Label();
            this.lab_phone = new System.Windows.Forms.Label();
            this.lab_mail = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_back = new System.Windows.Forms.Button();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.lab_namsurnam = new System.Windows.Forms.Label();
            this.TbNameSurname = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_log
            // 
            this.lab_log.AutoSize = true;
            this.lab_log.BackColor = System.Drawing.Color.Transparent;
            this.lab_log.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_log.Location = new System.Drawing.Point(54, 42);
            this.lab_log.Name = "lab_log";
            this.lab_log.Size = new System.Drawing.Size(112, 22);
            this.lab_log.TabIndex = 0;
            this.lab_log.Text = "Your login:";
            // 
            // lab_phone
            // 
            this.lab_phone.AutoSize = true;
            this.lab_phone.BackColor = System.Drawing.Color.Transparent;
            this.lab_phone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_phone.Location = new System.Drawing.Point(54, 169);
            this.lab_phone.Name = "lab_phone";
            this.lab_phone.Size = new System.Drawing.Size(202, 22);
            this.lab_phone.TabIndex = 1;
            this.lab_phone.Text = "Your phone number:";
            // 
            // lab_mail
            // 
            this.lab_mail.AutoSize = true;
            this.lab_mail.BackColor = System.Drawing.Color.Transparent;
            this.lab_mail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_mail.Location = new System.Drawing.Point(54, 127);
            this.lab_mail.Name = "lab_mail";
            this.lab_mail.Size = new System.Drawing.Size(115, 22);
            this.lab_mail.TabIndex = 4;
            this.lab_mail.Text = "Your email:";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(58, 205);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(50, 50);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.russianToolStripMenuItem.Text = "Русский";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(248, 205);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 50);
            this.btn_back.TabIndex = 70;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // TbLogin
            // 
            this.TbLogin.Location = new System.Drawing.Point(354, 42);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(183, 20);
            this.TbLogin.TabIndex = 71;
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(354, 173);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(183, 20);
            this.TbPhone.TabIndex = 72;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(354, 131);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(183, 20);
            this.TbEmail.TabIndex = 73;
            // 
            // lab_namsurnam
            // 
            this.lab_namsurnam.AutoSize = true;
            this.lab_namsurnam.BackColor = System.Drawing.Color.Transparent;
            this.lab_namsurnam.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_namsurnam.Location = new System.Drawing.Point(54, 82);
            this.lab_namsurnam.Name = "lab_namsurnam";
            this.lab_namsurnam.Size = new System.Drawing.Size(244, 22);
            this.lab_namsurnam.TabIndex = 2;
            this.lab_namsurnam.Text = "Your name and surname:";
            // 
            // TbNameSurname
            // 
            this.TbNameSurname.Location = new System.Drawing.Point(354, 86);
            this.TbNameSurname.Name = "TbNameSurname";
            this.TbNameSurname.Size = new System.Drawing.Size(183, 20);
            this.TbNameSurname.TabIndex = 74;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbNameSurname);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbPhone);
            this.Controls.Add(this.TbLogin);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lab_mail);
            this.Controls.Add(this.lab_namsurnam);
            this.Controls.Add(this.lab_phone);
            this.Controls.Add(this.lab_log);
            this.Name = "Account";
            this.Text = "account";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_log;
        private System.Windows.Forms.Label lab_phone;
        private System.Windows.Forms.Label lab_mail;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label lab_namsurnam;
        private System.Windows.Forms.TextBox TbNameSurname;
    }
}