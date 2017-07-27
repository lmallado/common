using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
namespace common
{
    public class logger : configs
    {
        public String ErrorMessage { get; set; }
        private String filename;
        private XDocument doc;
        private String ProgramName;
        public logger(string xmlpath, string ProgramDescription)
        {
            this.xmldirectory = xmlpath;
            this.ProgramName = ProgramDescription;
            this.filename = "LogEntries_" + " (" + DateTime.Now.ToString("ddMMyyyy") + ").xml";
            if (!File.Exists(Path.Combine(xmlpath, filename)))
            {
                this.doc = new XDocument(new XElement("LogRecords",
                            new XAttribute("date", DateTime.Now.ToString("MM/dd/yyy")),
                                new XAttribute("Program", this.ProgramName)));
                doc.Save(Path.Combine(xmlpath, filename));
            }
        }

        public logger() { }
        public void writeToLog(string eventLog, string message)
        {
            string fulldir = Path.Combine(this.xmldirectory, this.filename);
            XDocument openDoc;
            using (FileStream fs = new FileStream(fulldir, FileMode.Open, FileAccess.ReadWrite))
            {
                openDoc = XDocument.Load(fs);

                fs.Close();
            }
            openDoc.Element("LogRecords").Add(new XElement("LogEntry",
                                               new XAttribute("time", DateTime.Now.ToString("hh:mm:ss tt")),
                                                   new XElement("LogEvent", eventLog),
                                                   new XElement("LogMessage", message)
                                               ));
            openDoc.Save(fulldir);

        }

        public List<logentry> GetLogEntries(string xmlpath)
        {
            XDocument doc;
            List<logentry> entries = new List<logentry>();
            #region initialize file
            try
            {
                using (FileStream fs = new FileStream(xmlpath, FileMode.Open, FileAccess.Read))
                {
                    doc = XDocument.Load(fs);
                    fs.Close();
                }
            #endregion
                entries = (from p in doc.Element("LogRecords").Descendants("LogEntry")
                           select new logentry
                           {
                               LogEntryTime = p.Attribute("time").Value,
                               LogEventDescription = p.Element("LogEvent").Value,
                               Message = p.Element("LogMessage").Value
                           }).ToList<logentry>();

            }
            catch { }
            return entries;
        }
    }
}
