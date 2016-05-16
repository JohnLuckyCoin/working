using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaGSendEmail
{
    public partial class Form1 : Form
    {
        List<string> mailList = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMail(mailList);
        }

        private void SendMail(List<string> list)
        {
            try
            {
                int count = 0;
                foreach (var emailAdd in mailList)
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(txtAccount.Text);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(txtAccount.Text, txtPassword.Text);
                    SmtpServer.EnableSsl = true;

                    mail.To.Add(emailAdd);
                    mail.Subject = txtMailSubject.Text;
                    mail.Body = txtContent.Text;
                    
                    //Thread.Sleep(2);
                    count++;
                    Debug.WriteLine("Số mail đã gởi: " + count + " " + emailAdd);

                    SmtpServer.Send(mail);
                }

                MessageBox.Show(mailList.Count+ " mail sent");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Load text file which contained the list email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Text File|*.txt";
            if (oFile.ShowDialog()==DialogResult.OK)
            {
                string fname = oFile.FileName;
                mailList = new List<string>(File.ReadAllLines(fname));
                //txtMailTo.Enabled = false;
            }
        }
    }
}
