﻿using IhalematikProBL.Entity;
using IhalematikProBL.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Mailing
{
    public class EmailHelper
    {
        public string MailSender
        {
            get { return CustomConfigurationManager.Instance.SmtpMailSender; }
            //set { this.mailSender = value; }
        }

        public string MailSenderDisplayName
        {
            get { return CustomConfigurationManager.Instance.SmtpMailSenderDisplayName; }
            //set { this.mailSenderDisplayName = value; }
        }

        public bool PickupDirectoryFromIIS
        {
            get { return false; }
            //set { pickupDirectoryFromIIS = value; }
        }

        public int SmtpPort
        {
            get { return CustomConfigurationManager.Instance.SmtpPort; }
            //set { this.smtpPort = value; }
        }

        public string SmtpServer
        {
            get { return CustomConfigurationManager.Instance.SmtpAdress; }
            //set { this.smtpServer = value; }
        }

        public string Password
        {
            get { return CustomConfigurationManager.Instance.SmtpPassword; }
            //set { this.password = value; }
        }

        public string UserName
        {
            get { return CustomConfigurationManager.Instance.SmtpUserName; }
            //set { this.userName = value; }
        }

        public bool IsAnonymous
        {
            get { return false; }
            //set { this.isAnonymous = value; }
        }

        public void SendEmail(string sender, string displayName, string recipient, string subject, string body, bool isBodyHtml, string BCC = null)
        {
            try
            {
                if (string.IsNullOrEmpty(this.SmtpServer))
                {
                    return;
                }

                MailMessage message = new MailMessage();
                message.Sender = new MailAddress(sender, displayName);
                message.From = message.Sender;

                string[] recipientAddresses = recipient.Split(';');

                if (recipientAddresses != null && recipientAddresses.Length != 0)
                {
                    foreach (string recipientAddress in recipientAddresses)
                    {
                        message.To.Add(new MailAddress(recipientAddress));
                    }
                }

                message.Body = body;
                message.Subject = subject;
                message.IsBodyHtml = isBodyHtml;

                if (!string.IsNullOrEmpty(BCC))
                {
                    string[] bccAddresses = BCC.Split(';');
                    if (bccAddresses != null && bccAddresses.Length != 0)
                    {
                        foreach (string bccAddress in bccAddresses)
                        {
                            message.Bcc.Add(new MailAddress(bccAddress));
                        }
                    }
                }

                SmtpClient client = new SmtpClient(SmtpServer, SmtpPort);

                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                if (PickupDirectoryFromIIS)
                {
                    client.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
                }

                if (IsAnonymous)
                {
                    client.UseDefaultCredentials = true;
                }

                else
                {
                    //client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential(UserName, Password);
                }

                client.Send(message);
            }
            catch (System.Exception ex)
            {
                //CustomLoggingManager.Instance.Log(ex);

                //MailingManager.Instance.SendErrorEmail(ex);
            }
        }

        public void SendEmail(string sender, string displayName, List<string> recipients, string subject, string body, bool isBodyHtml)
        {
            foreach (string recipient in recipients)
            {
                this.SendEmail(sender, displayName, recipient, subject, body, isBodyHtml);
            }
        }

        public void SendEmailAsync(string sender, string displayName, List<string> recipients, string subject, string body, bool isBodyHtml)
        {
            foreach (string recipient in recipients)
            {
                SendEmailAsync(sender, displayName, recipient, subject, body, isBodyHtml);
            }
        }

        protected void SendEmail(object obj)
        {
            if (obj is EmailData)
            {
                EmailData data = (EmailData)obj;
                SendEmail(data.Sender, data.DisplayName, data.Recipient, data.Subject, data.Body, data.IsBodyHtml, data.BCC);
            }
        }

        public bool SendEmailAsync(string sender, string displayName, string recipient, string subject, string body, bool isBodyHtml, string Bcc = null)
        {
            EmailData info = new EmailData();
            info.Body = body;
            info.Sender = sender;
            info.DisplayName = displayName;
            info.Recipient = recipient;
            info.Subject = subject;
            info.IsBodyHtml = isBodyHtml;
            info.BCC = Bcc;

            try
            {
                this.SendEmail(info);
                return true;
            }
            catch (Exception ex)
            {
                //CustomLoggingManager.Instance.Log(Guid.NewGuid(), ex, string.Empty);
                //MailingManager.Instance.SendErrorEmail(ex);
                return false;
            }
        }

        public void SendEmail(string recipient, string subject, string body, string Bcc = null)
        {
            SendEmail(MailSender, MailSenderDisplayName, recipient, subject, body, true, Bcc);
        }
    }
}
