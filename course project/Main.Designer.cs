namespace course_project
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_location = new System.Windows.Forms.Label();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.lab_conditions = new System.Windows.Forms.Label();
            this.lab_details = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_temperature = new System.Windows.Forms.Label();
            this.lab_temp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.format24hStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.format12hStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nrmldateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_date = new System.Windows.Forms.Label();
            this.btn_clock = new System.Windows.Forms.Button();
            this.btn_date = new System.Windows.Forms.Button();
            this.btn_newforecast = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(775, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn_search.Location = new System.Drawing.Point(386, 45);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 32);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_location
            // 
            this.lab_location.AutoSize = true;
            this.lab_location.BackColor = System.Drawing.Color.Transparent;
            this.lab_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_location.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_location.Location = new System.Drawing.Point(43, 49);
            this.lab_location.Name = "lab_location";
            this.lab_location.Size = new System.Drawing.Size(97, 24);
            this.lab_location.TabIndex = 2;
            this.lab_location.Text = "Location:";
            // 
            // TbCity
            // 
            this.TbCity.Font = new System.Drawing.Font("Arial", 15.75F);
            this.TbCity.Location = new System.Drawing.Point(146, 45);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(221, 32);
            this.TbCity.TabIndex = 3;
            // 
            // lab_conditions
            // 
            this.lab_conditions.AutoSize = true;
            this.lab_conditions.BackColor = System.Drawing.Color.Transparent;
            this.lab_conditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_conditions.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_conditions.Location = new System.Drawing.Point(43, 219);
            this.lab_conditions.Name = "lab_conditions";
            this.lab_conditions.Size = new System.Drawing.Size(115, 24);
            this.lab_conditions.TabIndex = 4;
            this.lab_conditions.Text = "Conditions:";
            // 
            // lab_details
            // 
            this.lab_details.AutoSize = true;
            this.lab_details.BackColor = System.Drawing.Color.Transparent;
            this.lab_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_details.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_details.Location = new System.Drawing.Point(43, 267);
            this.lab_details.Name = "lab_details";
            this.lab_details.Size = new System.Drawing.Size(81, 24);
            this.lab_details.TabIndex = 7;
            this.lab_details.Text = "Details:";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_windspeed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_windspeed.Location = new System.Drawing.Point(382, 219);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(43, 24);
            this.lab_windspeed.TabIndex = 10;
            this.lab_windspeed.Text = "N/A";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_pressure.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.Location = new System.Drawing.Point(382, 276);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(43, 24);
            this.lab_pressure.TabIndex = 11;
            this.lab_pressure.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_sunset.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.Location = new System.Drawing.Point(118, 376);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(43, 24);
            this.lab_sunset.TabIndex = 12;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_sunrise.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.Location = new System.Drawing.Point(118, 318);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(43, 24);
            this.lab_sunrise.TabIndex = 14;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_temperature
            // 
            this.lab_temperature.AutoSize = true;
            this.lab_temperature.BackColor = System.Drawing.Color.Transparent;
            this.lab_temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_temperature.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temperature.Location = new System.Drawing.Point(164, 139);
            this.lab_temperature.Name = "lab_temperature";
            this.lab_temperature.Size = new System.Drawing.Size(132, 24);
            this.lab_temperature.TabIndex = 16;
            this.lab_temperature.Text = "Temperature:";
            // 
            // lab_temp
            // 
            this.lab_temp.AutoSize = true;
            this.lab_temp.BackColor = System.Drawing.Color.Transparent;
            this.lab_temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_temp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_temp.Location = new System.Drawing.Point(323, 139);
            this.lab_temp.Name = "lab_temp";
            this.lab_temp.Size = new System.Drawing.Size(43, 24);
            this.lab_temp.TabIndex = 17;
            this.lab_temp.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(312, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(47, 362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(312, 267);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 50);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(47, 97);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.backgroundChangeToolStripMenuItem});
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
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
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
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.format24hStripMenuItem,
            this.format12hStripMenuItem});
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.timeToolStripMenuItem.Text = "Time format";
            // 
            // format24hStripMenuItem
            // 
            this.format24hStripMenuItem.Name = "format24hStripMenuItem";
            this.format24hStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.format24hStripMenuItem.Text = "24h";
            this.format24hStripMenuItem.Click += new System.EventHandler(this.format24hStripMenuItem_Click);
            // 
            // format12hStripMenuItem
            // 
            this.format12hStripMenuItem.Name = "format12hStripMenuItem";
            this.format12hStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.format12hStripMenuItem.Text = "12h";
            this.format12hStripMenuItem.Click += new System.EventHandler(this.format12hToolStripMenuItem1_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nrmldateToolStripMenuItem,
            this.usdateToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dateToolStripMenuItem.Text = "Date format";
            // 
            // nrmldateToolStripMenuItem
            // 
            this.nrmldateToolStripMenuItem.Name = "nrmldateToolStripMenuItem";
            this.nrmldateToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nrmldateToolStripMenuItem.Text = "DD-MM-YYYY";
            this.nrmldateToolStripMenuItem.Click += new System.EventHandler(this.nrmldateToolStripMenuItem_Click);
            // 
            // usdateToolStripMenuItem
            // 
            this.usdateToolStripMenuItem.Name = "usdateToolStripMenuItem";
            this.usdateToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usdateToolStripMenuItem.Text = "YYYY-MM-DD";
            this.usdateToolStripMenuItem.Click += new System.EventHandler(this.usdateToolStripMenuItem_Click);
            // 
            // backgroundChangeToolStripMenuItem
            // 
            this.backgroundChangeToolStripMenuItem.Name = "backgroundChangeToolStripMenuItem";
            this.backgroundChangeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.backgroundChangeToolStripMenuItem.Text = "Change background";
            this.backgroundChangeToolStripMenuItem.Click += new System.EventHandler(this.backgroundChangeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.BackColor = System.Drawing.Color.Transparent;
            this.lab_time.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_time.Location = new System.Drawing.Point(598, 139);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(16, 24);
            this.lab_time.TabIndex = 25;
            this.lab_time.Text = " ";
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.BackColor = System.Drawing.Color.Transparent;
            this.lab_date.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_date.Location = new System.Drawing.Point(598, 209);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(16, 24);
            this.lab_date.TabIndex = 26;
            this.lab_date.Text = " ";
            // 
            // btn_clock
            // 
            this.btn_clock.BackColor = System.Drawing.Color.Transparent;
            this.btn_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clock.BackgroundImage")));
            this.btn_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clock.Location = new System.Drawing.Point(510, 128);
            this.btn_clock.Name = "btn_clock";
            this.btn_clock.Size = new System.Drawing.Size(50, 50);
            this.btn_clock.TabIndex = 27;
            this.btn_clock.UseVisualStyleBackColor = false;
            this.btn_clock.Click += new System.EventHandler(this.btn_clock_Click);
            // 
            // btn_date
            // 
            this.btn_date.BackColor = System.Drawing.Color.Transparent;
            this.btn_date.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_date.BackgroundImage")));
            this.btn_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_date.Location = new System.Drawing.Point(510, 193);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(50, 50);
            this.btn_date.TabIndex = 28;
            this.btn_date.UseVisualStyleBackColor = false;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // btn_newforecast
            // 
            this.btn_newforecast.BackColor = System.Drawing.Color.Transparent;
            this.btn_newforecast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_newforecast.BackgroundImage")));
            this.btn_newforecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_newforecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newforecast.Location = new System.Drawing.Point(738, 388);
            this.btn_newforecast.Name = "btn_newforecast";
            this.btn_newforecast.Size = new System.Drawing.Size(50, 50);
            this.btn_newforecast.TabIndex = 29;
            this.btn_newforecast.UseVisualStyleBackColor = false;
            this.btn_newforecast.Click += new System.EventHandler(this.btn_newforecast_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_help.BackgroundImage")));
            this.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Location = new System.Drawing.Point(671, 388);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(50, 50);
            this.btn_help.TabIndex = 30;
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_profile.BackgroundImage")));
            this.btn_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Location = new System.Drawing.Point(738, 49);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(50, 50);
            this.btn_profile.TabIndex = 31;
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(602, 387);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 50);
            this.btn_back.TabIndex = 32;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_newforecast);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.btn_clock);
            this.Controls.Add(this.lab_date);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_temp);
            this.Controls.Add(this.lab_temperature);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.lab_details);
            this.Controls.Add(this.lab_conditions);
            this.Controls.Add(this.TbCity);
            this.Controls.Add(this.lab_location);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_location;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label lab_conditions;
        private System.Windows.Forms.Label lab_details;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_temperature;
        private System.Windows.Forms.Label lab_temp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem format24hStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem format12hStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundChangeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Button btn_clock;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.Button btn_newforecast;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nrmldateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usdateToolStripMenuItem;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_back;
    }
}

