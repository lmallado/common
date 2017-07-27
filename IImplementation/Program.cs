using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using common;
using System.Net.Mail;
using System.Net.Mime;
namespace IImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            mail m = new mail(@"W:\NIKKI\config.xml");
            string body = string.Empty;
            body = "<html><body><h1>Picture</h1><br><img src=\"cid:img0\"></body></html>";
            m.linksources.Add(@"C:\Users\lmallado\Pictures\Collateral_AUTO.PNG");
            m.mailto.Add("lmallado@rcbcsavings.com");
            m.mailcc.Add("njlorenzana@rcbcsavings.com");
            if (!m.sendHMail(body, "Test"))
            {
                Console.WriteLine(m.ErrorMessage);
            }
            //Console.ReadKey();
            //string xmldir = @"W:\";
            //logger log = new logger(xmldir,"IImplementation");
            ////String xmlpath = @"W:\NIKKI\config.xml";
            //while (true)
            //{
            //    if (DateTime.Now.ToString("ss").EndsWith("0"))
            //    {
            //        log.writeToLog("Triggering for :" + DateTime.Now.ToString("ss"), "Everything is smooth");
            //        //using (mail mail = new mail(xmlpath))
            //        //{
            //        //    mail.mailto.Add("lmallado@rcbcsavings.com");
            //        //    mail.mailcc.Add("njlorenzana@rcbcsavings.com");
            //        //    if (!mail.sendMail("Hi there", "Test"))
            //        //    {
            //        //        Console.WriteLine(mail.ErrorMessage);
            //        //    }
            //        //    else
            //        //    {
            //        //        Console.WriteLine("Done");
            //        //    }
            //        //}
            //        System.Threading.Thread.Sleep(5000);
            //    }


            //}




        }
    }
}
