using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Linq;
using System.Net.Mail;
using System.Net.Mime;
namespace common
{
    public class mail : configs,IDisposable
    {
        #region public vars
        public string ErrorMessage { get; set; }
        public List<string> attachments { get; set; }
        public List<string> mailto { get; set; }
        public List<string> mailcc { get; set; }
        public List<string> mailbcc { get; set; }
        public List<string> linksources { get; set; }
        #endregion
        #region private vars
        private NetworkCredential credentials;
        private bool isBodyHtml = false;
        private bool SSLEnabled = false;
        private string host = string.Empty;
        private string fromAddr = string.Empty;
        private string toAddr = string.Empty;
        private double port = 0;
        private SmtpClient client;
        private bool disposed;
        
        #endregion
        #region functions
        public mail(String mailXMLPath)
        {
            this.xmlpath = mailXMLPath;
            this.attachments = new List<string>();
            this.mailto = new List<string>();
            this.mailcc = new List<string>();
            this.mailbcc = new List<string>();
            this.linksources = new List<string>();
            _parseconnection();
        }
        private void _parseconnection()
        {
            XDocument doc = XDocument.Load(this.xmlpath);
            XElement main = doc.Descendants("mail").First(x => x.Name =="mail");
            String username = main.Element("username").Value;
            String password = main.Element("password").Value;
            this.credentials = new NetworkCredential(username, password);
            this.host = main.Element("host").Value;
            this.port = Convert.ToDouble(main.Element("port").Value);
            this.SSLEnabled = Convert.ToBoolean(main.Element("ssl").Value);
            this.isBodyHtml = Convert.ToBoolean(main.Element("htmlbody").Value);
            this.fromAddr = main.Element("sender").Value;
        }
        public bool sendMail(string message, string subject)
        {
            this.client = new SmtpClient();
            MailMessage msg = new MailMessage();
            msg.Priority = MailPriority.High;
            String[] tocc = this.mailto.ToArray();
            String[] ccs = this.mailcc.ToArray();
            String[] bcc = this.mailbcc.ToArray();
            try
            {
                if (tocc.Length > 0)
                {
                    if (!string.IsNullOrEmpty(tocc[0]))
                    {
                        msg.To.Add(string.Join(",", tocc));
                    }
                }

                if (ccs.Length > 0)
                {
                    if (!string.IsNullOrEmpty(ccs[0]))
                    {
                        msg.CC.Add(string.Join(",", ccs));
                    }
                }


                if (bcc.Length > 0)
                {
                    if (!string.IsNullOrEmpty(bcc[0]))
                    {
                        msg.Bcc.Add(string.Join(",", bcc));
                    }
                }
                msg.From = new MailAddress(this.fromAddr);
                msg.Subject = subject;
                msg.IsBodyHtml = this.isBodyHtml;
                msg.Body = message;

                foreach (string _a in this.attachments)
                {
                    msg.Attachments.Add(new Attachment(_a));
                }

                client.EnableSsl = this.SSLEnabled;
                client.Host = this.host;
                client.Port = Convert.ToInt32(this.port);
                if (string.IsNullOrEmpty(this.credentials.UserName))
                {
                    client.UseDefaultCredentials = true;
                }
                else
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = this.credentials;
                }

                client.Send(msg);

                msg.Dispose();
                client.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
                return false;
            }

        }
        public bool sendHMail(string body, string subject)
        {
            this.client = new SmtpClient();
            MailMessage msg = new MailMessage();
            msg.Priority = MailPriority.High;
            LinkedResource lr = null;
            Int32 counter = 0;
            String[] tocc = this.mailto.ToArray();
            String[] ccs = this.mailcc.ToArray();
            String[] bcc = this.mailbcc.ToArray();
            AlternateView view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
            foreach (string s in linksources)
            {
                lr = new LinkedResource(s);
                lr.ContentId = "img" + counter;
                view.LinkedResources.Add(lr);
                counter++;
            }

            try
            {
                if (tocc.Length > 0)
                {
                    if (!string.IsNullOrEmpty(tocc[0]))
                    {
                        msg.To.Add(string.Join(",", tocc));
                    }
                }

                if (ccs.Length > 0)
                {
                    if (!string.IsNullOrEmpty(ccs[0]))
                    {
                        msg.CC.Add(string.Join(",", ccs));
                    }
                }


                if (bcc.Length > 0)
                {
                    if (!string.IsNullOrEmpty(bcc[0]))
                    {
                        msg.Bcc.Add(string.Join(",", bcc));
                    }
                }
                msg.From = new MailAddress(this.fromAddr);
                msg.Subject = subject;
                msg.IsBodyHtml = this.isBodyHtml;
                msg.AlternateViews.Add(view);

                foreach (string _a in this.attachments)
                {
                    msg.Attachments.Add(new Attachment(_a));
                }

                client.EnableSsl = this.SSLEnabled;
                client.Host = this.host;
                client.Port = Convert.ToInt32(this.port);
                if (string.IsNullOrEmpty(this.credentials.UserName))
                {
                    client.UseDefaultCredentials = true;
                }
                else
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = this.credentials;
                }

                client.Send(msg);

                msg.Dispose();
                client.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
                return false;
            }

        }
        public void sendHTMLMail(string htmlbody, string subject)
        {
            this.client = new SmtpClient("10.0.2.174", 25);

            // Create a LinkedResource object for each embedded image
            LinkedResource pic1 = new LinkedResource(@"C:\Users\lmallado\Pictures\DSC05818.jpg", MediaTypeNames.Image.Jpeg);
            MailMessage newMail = new MailMessage();
            newMail.To.Add(new MailAddress("lmallado@rcbcsavings.com"));
            newMail.Subject = "Test Subject";
            newMail.IsBodyHtml = true;
            newMail.From = (new MailAddress("lmallado@rcbcsavings.com"));
            var inlineLogo = new LinkedResource(@"C:\Users\lmallado\Pictures\Collateral_AUTO.PNG");
            inlineLogo.ContentId = Guid.NewGuid().ToString();

            string body = string.Format(@"
            <p>Lorum Ipsum Blah Blah</p>
            <img src=""cid:{0}"" />
            <p>Lorum Ipsum Blah Blah</p>
        ", inlineLogo.ContentId);

            var view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
            view.LinkedResources.Add(inlineLogo);
            newMail.AlternateViews.Add(view);

            client.Send(newMail);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (client != null)
                    {
                        client.Dispose();
                       
                    }
                  
                }
                //this.mailto.Clear();
                //this.mailbcc.Clear();
                //this.mailcc.Clear();
                //this.attachments.Clear();
                //this.linksources.Clear();

                //this.linksources = null;
                //this.mailto = null;
                //this.mailcc = null;
                //this.mailbcc = null;
                //this.attachments = null;
                client = null;
                disposed = true;
            }
        }
        #endregion
    }
}
