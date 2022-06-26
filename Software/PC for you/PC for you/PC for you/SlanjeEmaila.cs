using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using FluentEmail.Core;
using System.Web;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace PC_for_you
{
    public static class SlanjeEmaila
    {
        public static void PosaljiEmail(string to)
        {
            MailMessage mail = new MailMessage("pc4youpc4you@gmail.com", to, "Račun za narudžbu PC for you", "Hvala što ste kupovali kod nas!");
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("pc4youpc4you@gmail.com", "bsnjfejlqglzrdnh");
            client.EnableSsl = true;
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            string fileName = Path.Combine(path, "PCforYouRacun.pdf");
            mail.Attachments.Add(new Attachment(fileName));
            client.Send(mail);
            MessageBox.Show("Poslan mail!");
            mail.Dispose();
        }
    }
}
