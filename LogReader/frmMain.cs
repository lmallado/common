using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Configuration;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using common;
namespace LogReader
{
    public partial class frmMain : Telerik.WinControls.UI.RadForm
    {
        private static String xmlfile = ConfigurationManager.AppSettings["xmlpath"].ToString();
        public frmMain()
        {
            InitializeComponent();
        }

        private void notify(string statement)
        {
            this.noti.Visible = true;
            this.noti.ShowBalloonTip(3000, "Log Entry Viewer", statement.Trim(), ToolTipIcon.Info);
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(xmlfile);
            List<prg> prgs = (from p in doc.Element("Programs").Descendants("Program")
                              select new prg { Name = p.Attribute("name").Value, Directory = p.Element("Directory").Value.ToString() }).ToList<prg>();

            this.grdPrg.DataSource = prgs;
            this.grdPrg.Columns["Directory"].IsVisible = false;
        }

        private void grdPrg_SelectionChanged(object sender, EventArgs e)
        {
            this.txtDir.Text = this.grdPrg.SelectedRows[0].Cells[1].Value.ToString();
            if (this.drpFiles.Items.Count == 0)
            {
                this.drpFiles.Text = "Select One";
            }
        }



        private void txtDir_TextChanged_1(object sender, EventArgs e)
        {
            List<String> _files = new List<string>();

            if (!String.IsNullOrEmpty(this.txtDir.Text))
            {
                string[] files = System.IO.Directory.GetFiles(this.txtDir.Text, "*.xml");
                foreach (string s in files)
                {
                    if (s.Contains("LogEntries"))
                    {
                        _files.Add(Path.GetFileNameWithoutExtension(s));
                    }
                }
                this.drpFiles.DataSource = from p in _files
                                           orderby p descending
                                           select p;
                this.drpFiles.SelectedIndex = 0;
                
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            common.logger logger = new common.logger();

            if (this.drpFiles.Text != "Select One")
            {
                path = Path.Combine(this.txtDir.Text, this.drpFiles.Text + ".xml");
                this.grdLogDetails.DataSource = logger.GetLogEntries(path);
            }
            else
            {
                MessageBox.Show("Please choose a valid file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notify("Log Entry Viewer will now run in background.");
                this.Hide();
            }
            else
            {
                this.noti.Visible = false;
            }
        }

        private void noti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            notify("Log Entry Viewer will now run in background.");
            this.Hide();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            logger _lg = new logger();

            this.grdLogDetails.DataSource = _lg.GetLogEntries(string.Empty);
        }

        private void grdLogDetails_Click(object sender, EventArgs e)
        {

        }

        private void grdLogDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdLogDetails.SelectedRows.Count > 0)
            {
                this.txtDetails.Text = this.grdLogDetails.SelectedRows[0].Cells[2].Value.ToString();
                this.txtEventName.Text = this.grdLogDetails.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
