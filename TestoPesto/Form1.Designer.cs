namespace TestoPesto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pause = new System.Windows.Forms.Button();
            this.txt_gameSheet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_notLoaded = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_countGames = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_timeLeft = new System.Windows.Forms.Label();
            this.txt_folderLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_rowCount = new System.Windows.Forms.Label();
            this.txt_accountNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.cmb_server = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_language = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timeToLoadPage = new System.Windows.Forms.TextBox();
            this.btn_ExportToExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dg_gameList = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clm_pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.Loadtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_clearGrid = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.tmr_timeLeft = new System.Windows.Forms.Timer(this.components);
            this.btn_openFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_gameList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 741);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_go
            // 
            this.btn_go.BackColor = System.Drawing.Color.Honeydew;
            this.btn_go.Location = new System.Drawing.Point(15, 312);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(53, 23);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pause);
            this.groupBox1.Controls.Add(this.txt_gameSheet);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_url);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_notLoaded);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_countGames);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_timeLeft);
            this.groupBox1.Controls.Add(this.txt_folderLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_rowCount);
            this.groupBox1.Controls.Add(this.txt_accountNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_stop);
            this.groupBox1.Controls.Add(this.cmb_server);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_language);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_timeToLoadPage);
            this.groupBox1.Controls.Add(this.btn_go);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 407);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // btn_pause
            // 
            this.btn_pause.Enabled = false;
            this.btn_pause.Location = new System.Drawing.Point(129, 312);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 30;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // txt_gameSheet
            // 
            this.txt_gameSheet.Location = new System.Drawing.Point(147, 168);
            this.txt_gameSheet.Name = "txt_gameSheet";
            this.txt_gameSheet.Size = new System.Drawing.Size(179, 20);
            this.txt_gameSheet.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Game list sheet";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(100, 132);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(226, 20);
            this.txt_url.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "URL (Not Default)";
            // 
            // lbl_notLoaded
            // 
            this.lbl_notLoaded.AutoSize = true;
            this.lbl_notLoaded.Location = new System.Drawing.Point(133, 379);
            this.lbl_notLoaded.Name = "lbl_notLoaded";
            this.lbl_notLoaded.Size = new System.Drawing.Size(13, 13);
            this.lbl_notLoaded.TabIndex = 25;
            this.lbl_notLoaded.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Not loaded";
            // 
            // lbl_countGames
            // 
            this.lbl_countGames.AutoSize = true;
            this.lbl_countGames.Location = new System.Drawing.Point(191, 351);
            this.lbl_countGames.Name = "lbl_countGames";
            this.lbl_countGames.Size = new System.Drawing.Size(13, 13);
            this.lbl_countGames.TabIndex = 23;
            this.lbl_countGames.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Time Left";
            this.label8.Visible = false;
            // 
            // lbl_timeLeft
            // 
            this.lbl_timeLeft.AutoSize = true;
            this.lbl_timeLeft.Location = new System.Drawing.Point(262, 322);
            this.lbl_timeLeft.Name = "lbl_timeLeft";
            this.lbl_timeLeft.Size = new System.Drawing.Size(49, 13);
            this.lbl_timeLeft.TabIndex = 20;
            this.lbl_timeLeft.Text = "00:00:00";
            this.lbl_timeLeft.Visible = false;
            // 
            // txt_folderLabel
            // 
            this.txt_folderLabel.Location = new System.Drawing.Point(147, 262);
            this.txt_folderLabel.Name = "txt_folderLabel";
            this.txt_folderLabel.Size = new System.Drawing.Size(179, 20);
            this.txt_folderLabel.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Folder lable";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(147, 231);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(179, 20);
            this.txt_pass.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Game count to test";
            // 
            // lbl_rowCount
            // 
            this.lbl_rowCount.AutoSize = true;
            this.lbl_rowCount.Location = new System.Drawing.Point(134, 351);
            this.lbl_rowCount.Name = "lbl_rowCount";
            this.lbl_rowCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_rowCount.TabIndex = 5;
            this.lbl_rowCount.Text = "0";
            // 
            // txt_accountNo
            // 
            this.txt_accountNo.Location = new System.Drawing.Point(147, 199);
            this.txt_accountNo.Name = "txt_accountNo";
            this.txt_accountNo.Size = new System.Drawing.Size(179, 20);
            this.txt_accountNo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Account No";
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(74, 312);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(49, 23);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // cmb_server
            // 
            this.cmb_server.FormattingEnabled = true;
            this.cmb_server.Items.AddRange(new object[] {
            "TNG",
            "MIT",
            "TNG1",
            "TNG2",
            "TNG3",
            "TNG4",
            "TNG5"});
            this.cmb_server.Location = new System.Drawing.Point(230, 20);
            this.cmb_server.Name = "cmb_server";
            this.cmb_server.Size = new System.Drawing.Size(96, 21);
            this.cmb_server.TabIndex = 9;
            this.cmb_server.Text = "TNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select server";
            // 
            // cmb_language
            // 
            this.cmb_language.AutoCompleteCustomSource.AddRange(new string[] {
            "en",
            "fr",
            "de",
            "el"});
            this.cmb_language.FormattingEnabled = true;
            this.cmb_language.Items.AddRange(new object[] {
            "en",
            "zh",
            "zh-tw"});
            this.cmb_language.Location = new System.Drawing.Point(230, 93);
            this.cmb_language.Name = "cmb_language";
            this.cmb_language.Size = new System.Drawing.Size(96, 21);
            this.cmb_language.TabIndex = 5;
            this.cmb_language.Text = "en";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time To load page (Seconds)";
            // 
            // txt_timeToLoadPage
            // 
            this.txt_timeToLoadPage.Location = new System.Drawing.Point(230, 57);
            this.txt_timeToLoadPage.Name = "txt_timeToLoadPage";
            this.txt_timeToLoadPage.Size = new System.Drawing.Size(96, 20);
            this.txt_timeToLoadPage.TabIndex = 2;
            this.txt_timeToLoadPage.Text = "60";
            // 
            // btn_ExportToExcel
            // 
            this.btn_ExportToExcel.Location = new System.Drawing.Point(99, 30);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(78, 23);
            this.btn_ExportToExcel.TabIndex = 18;
            this.btn_ExportToExcel.Text = "ExpToExcel";
            this.btn_ExportToExcel.UseVisualStyleBackColor = true;
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_ExportToExcel_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dg_gameList
            // 
            this.dg_gameList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dg_gameList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dg_gameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_gameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.GameName,
            this.Size,
            this.Link,
            this.clm_pic,
            this.Loadtime});
            this.dg_gameList.Location = new System.Drawing.Point(355, 55);
            this.dg_gameList.Name = "dg_gameList";
            this.dg_gameList.Size = new System.Drawing.Size(624, 682);
            this.dg_gameList.TabIndex = 3;
            this.dg_gameList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_gameList_CellContentClick);
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 21;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "clm_games";
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GameName.Width = 21;
            // 
            // Size
            // 
            this.Size.HeaderText = "clm_size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 21;
            // 
            // Link
            // 
            this.Link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Link.HeaderText = "link";
            this.Link.Name = "Link";
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clm_pic
            // 
            this.clm_pic.HeaderText = "picture";
            this.clm_pic.Name = "clm_pic";
            this.clm_pic.ReadOnly = true;
            this.clm_pic.Width = 21;
            // 
            // Loadtime
            // 
            this.Loadtime.HeaderText = "LoadTime";
            this.Loadtime.Name = "Loadtime";
            this.Loadtime.ReadOnly = true;
            this.Loadtime.Width = 21;
            // 
            // btn_clearGrid
            // 
            this.btn_clearGrid.Location = new System.Drawing.Point(904, 743);
            this.btn_clearGrid.Name = "btn_clearGrid";
            this.btn_clearGrid.Size = new System.Drawing.Size(75, 23);
            this.btn_clearGrid.TabIndex = 4;
            this.btn_clearGrid.Text = "Clear grid";
            this.btn_clearGrid.UseVisualStyleBackColor = true;
            this.btn_clearGrid.Click += new System.EventHandler(this.btn_clearGrid_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(399, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(150, 20);
            this.txt_search.TabIndex = 19;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(352, 22);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_search.TabIndex = 18;
            this.lbl_search.Text = "Search";
            // 
            // tmr_timeLeft
            // 
            this.tmr_timeLeft.Interval = 1010;
            this.tmr_timeLeft.Tick += new System.EventHandler(this.tmr_timeLeft_Tick);
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.Location = new System.Drawing.Point(13, 30);
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_openFolder.TabIndex = 18;
            this.btn_openFolder.Text = "Open Folder";
            this.btn_openFolder.UseVisualStyleBackColor = true;
            this.btn_openFolder.Click += new System.EventHandler(this.btn_openFolder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ExportToExcel);
            this.groupBox2.Controls.Add(this.btn_openFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 72);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_clearGrid);
            this.Controls.Add(this.dg_gameList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Flash teser 9.1.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_gameList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timeToLoadPage;
        private System.Windows.Forms.ComboBox cmb_language;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmb_server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_accountNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_gameList;
        private System.Windows.Forms.Button btn_clearGrid;
        private System.Windows.Forms.Label lbl_rowCount;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_folderLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_ExportToExcel;
        private System.Windows.Forms.Timer tmr_timeLeft;
        private System.Windows.Forms.Button btn_openFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_timeLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_countGames;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_notLoaded;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewImageColumn clm_pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loadtime;
        private System.Windows.Forms.TextBox txt_gameSheet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_pause;
    }
}

