namespace LogReader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtDir = new System.Windows.Forms.Label();
            this.grdPrg = new Telerik.WinControls.UI.RadGridView();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.drpFiles = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.grdLogDetails = new Telerik.WinControls.UI.RadGridView();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.noti = new System.Windows.Forms.NotifyIcon(this.components);
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.txtEventName = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtDetails = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLogDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEventName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPageView1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanel1.Location = new System.Drawing.Point(0, 28);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(250, 520);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.Text = "radPanel1";
            this.radPanel1.ThemeName = "Office2010Silver";
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage2;
            this.radPageView1.Size = new System.Drawing.Size(250, 520);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "Office2007Black";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Outlook;
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.BackColor = System.Drawing.Color.White;
            this.radPageViewPage2.Controls.Add(this.txtDir);
            this.radPageViewPage2.Controls.Add(this.grdPrg);
            this.radPageViewPage2.Controls.Add(this.radButton2);
            this.radPageViewPage2.Controls.Add(this.radButton1);
            this.radPageViewPage2.Controls.Add(this.radLabel4);
            this.radPageViewPage2.Controls.Add(this.drpFiles);
            this.radPageViewPage2.Controls.Add(this.radLabel2);
            this.radPageViewPage2.Controls.Add(this.radLabel1);
            this.radPageViewPage2.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(240, 407);
            this.radPageViewPage2.Text = "Configurations";
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDir.ForeColor = System.Drawing.Color.Blue;
            this.txtDir.Location = new System.Drawing.Point(8, 183);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(203, 41);
            this.txtDir.TabIndex = 11;
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged_1);
            // 
            // grdPrg
            // 
            this.grdPrg.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.grdPrg.Location = new System.Drawing.Point(7, 25);
            // 
            // grdPrg
            // 
            this.grdPrg.MasterTemplate.AllowAddNewRow = false;
            this.grdPrg.MasterTemplate.AllowCellContextMenu = false;
            this.grdPrg.MasterTemplate.AllowColumnChooser = false;
            this.grdPrg.MasterTemplate.AllowColumnReorder = false;
            this.grdPrg.MasterTemplate.AllowDeleteRow = false;
            this.grdPrg.MasterTemplate.AllowDragToGroup = false;
            this.grdPrg.MasterTemplate.AllowEditRow = false;
            this.grdPrg.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdPrg.Name = "grdPrg";
            this.grdPrg.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.grdPrg.ShowGroupPanel = false;
            this.grdPrg.Size = new System.Drawing.Size(204, 131);
            this.grdPrg.TabIndex = 10;
            this.grdPrg.ThemeName = "Office2007Black";
            this.grdPrg.SelectionChanged += new System.EventHandler(this.grdPrg_SelectionChanged);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(11, 318);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(204, 24);
            this.radButton2.TabIndex = 9;
            this.radButton2.Text = "Clear<<";
            this.radButton2.ThemeName = "Office2007Black";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(11, 288);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(204, 24);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Load >>";
            this.radButton1.ThemeName = "Office2007Black";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.White;
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel4.ForeColor = System.Drawing.Color.Black;
            this.radLabel4.Location = new System.Drawing.Point(7, 231);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(83, 18);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Available File :";
            // 
            // drpFiles
            // 
            this.drpFiles.DropDownAnimationEnabled = true;
            this.drpFiles.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.drpFiles.Location = new System.Drawing.Point(11, 255);
            this.drpFiles.Name = "drpFiles";
            this.drpFiles.ShowImageInEditorArea = true;
            this.drpFiles.Size = new System.Drawing.Size(204, 22);
            this.drpFiles.TabIndex = 6;
            this.drpFiles.Text = "Select One";
            this.drpFiles.ThemeName = "Office2007Black";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.White;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(7, 162);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(122, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Associated Directory :";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.White;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(116, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Available Programs :";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.grdLogDetails);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(250, 28);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(711, 269);
            this.radPanel2.TabIndex = 1;
            this.radPanel2.Text = "radPanel2";
            this.radPanel2.ThemeName = "Office2010Silver";
            // 
            // grdLogDetails
            // 
            this.grdLogDetails.AutoSizeRows = true;
            this.grdLogDetails.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.grdLogDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLogDetails.Location = new System.Drawing.Point(0, 0);
            // 
            // grdLogDetails
            // 
            this.grdLogDetails.MasterTemplate.AllowAddNewRow = false;
            this.grdLogDetails.MasterTemplate.AllowCellContextMenu = false;
            this.grdLogDetails.MasterTemplate.AllowColumnChooser = false;
            this.grdLogDetails.MasterTemplate.AllowDeleteRow = false;
            this.grdLogDetails.MasterTemplate.AllowDragToGroup = false;
            this.grdLogDetails.MasterTemplate.AllowEditRow = false;
            this.grdLogDetails.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdLogDetails.MasterTemplate.EnableFiltering = true;
            this.grdLogDetails.MasterTemplate.ShowRowHeaderColumn = false;
            this.grdLogDetails.Name = "grdLogDetails";
            this.grdLogDetails.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.grdLogDetails.ShowGroupPanel = false;
            this.grdLogDetails.Size = new System.Drawing.Size(711, 269);
            this.grdLogDetails.TabIndex = 0;
            this.grdLogDetails.Text = "radGridView1";
            this.grdLogDetails.ThemeName = "Office2007Black";
            this.grdLogDetails.SelectionChanged += new System.EventHandler(this.grdLogDetails_SelectionChanged);
            this.grdLogDetails.Click += new System.EventHandler(this.grdLogDetails_Click);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.Location = new System.Drawing.Point(106, 5);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.ShowImageInEditorArea = true;
            this.radDropDownList1.Size = new System.Drawing.Size(226, 16);
            this.radDropDownList1.TabIndex = 2;
            this.radDropDownList1.Text = "Select One";
            this.radDropDownList1.ThemeName = "Office2010Silver";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(961, 28);
            this.radMenu1.TabIndex = 2;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "Office2007Black";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "File";
            this.radMenuItem1.AccessibleName = "File";
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2,
            this.radMenuItem3});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Start";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Save";
            this.radMenuItem2.AccessibleName = "Save";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Hide";
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem2.Click += new System.EventHandler(this.radMenuItem2_Click);
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Exit";
            this.radMenuItem3.AccessibleName = "Exit";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Exit";
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // noti
            // 
            this.noti.Icon = ((System.Drawing.Icon)(resources.GetObject("noti.Icon")));
            this.noti.Text = "Log Entry Viewer";
            this.noti.Visible = true;
            this.noti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noti_MouseDoubleClick);
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.radPanel3.Controls.Add(this.txtEventName);
            this.radPanel3.Controls.Add(this.radLabel5);
            this.radPanel3.Controls.Add(this.txtDetails);
            this.radPanel3.Controls.Add(this.radLabel3);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel3.Location = new System.Drawing.Point(250, 297);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Padding = new System.Windows.Forms.Padding(10);
            // 
            // 
            // 
            this.radPanel3.RootElement.Padding = new System.Windows.Forms.Padding(10);
            this.radPanel3.Size = new System.Drawing.Size(711, 251);
            this.radPanel3.TabIndex = 3;
            this.radPanel3.ThemeName = "Office2007Black";
            // 
            // txtEventName
            // 
            this.txtEventName.AutoSize = false;
            this.txtEventName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEventName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtEventName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEventName.Location = new System.Drawing.Point(11, 35);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(685, 23);
            this.txtEventName.TabIndex = 11;
            this.txtEventName.Text = "----------";
            // 
            // radLabel5
            // 
            this.radLabel5.BackColor = System.Drawing.Color.Gainsboro;
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel5.ForeColor = System.Drawing.Color.Black;
            this.radLabel5.Location = new System.Drawing.Point(10, 13);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(106, 18);
            this.radLabel5.TabIndex = 10;
            this.radLabel5.Text = "Event Description :";
            // 
            // txtDetails
            // 
            this.txtDetails.AutoSize = false;
            this.txtDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtDetails.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDetails.Location = new System.Drawing.Point(10, 81);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(691, 160);
            this.txtDetails.TabIndex = 9;
            this.txtDetails.Text = "No Selected Entry";
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(10, 57);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(59, 18);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "Message :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 548);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Main Window";
            this.ThemeName = "Office2007Black";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage2.ResumeLayout(false);
            this.radPageViewPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLogDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEventName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadGridView grdLogDetails;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList drpFiles;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadGridView grdPrg;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private System.Windows.Forms.Label txtDir;
        private System.Windows.Forms.NotifyIcon noti;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel txtDetails;
        private Telerik.WinControls.UI.RadLabel txtEventName;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
    }
}
