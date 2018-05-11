using IhalematikProBL.Entity;
using IhalematikProBL.Manager;
using SimpleApplicationBase.BL.Base;
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
            get { return CompanyManager.Instance.CurrentCompany.MailAddress; }
            //set { this.mailSender = value; }
        }

        public string MailSenderDisplayName
        {
            get { return CompanyManager.Instance.CurrentCompany.Name; }
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
            get;set;
            //set { this.smtpServer = value; }
        }

        public string Password
        {
            get { return CompanyManager.Instance.CurrentCompany.MailPassword; }
            //set { this.password = value; }
        }

        public string UserName
        {
            get { return CompanyManager.Instance.CurrentCompany.MailAddress; }
            //set { this.userName = value; 
        }

        public bool IsAnonymous
        {
            get { return false; }
            //set { this.isAnonymous = value; }
        }

        public OperationResult SendEmail(string sender, string displayName, string recipient, string subject, string body, bool isBodyHtml, string BCC = null, string AttachmentFileName = null)
        {
            OperationResult result = new OperationResult();
            try
            {
                //if (string.IsNullOrEmpty(this.SmtpServer))
                //{
                //    return result;
                //}

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
                if (AttachmentFileName != null)
                    message.Attachments.Add(new Attachment(AttachmentFileName));

                if (!this.UserName.Contains("gmail"))
                {
                    this.SmtpServer = "smtp-mail.outlook.com";
                }
                else
                {
                    this.SmtpServer = "smtp.gmail.com";
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
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
                result.Success = false;
                if (ex.InnerException != null && (ex.InnerException.Message.Contains("The remote name could not be resolved") || ex.InnerException.Message.Contains("Uzak ad çözülemedi")))
                {
                    result.ValidationResults.Add("The remote name could not be resolved", "NoInternetconnection");
                }
                else if (ex.Message.Contains("The SMTP server requires a secure connection or the client was not authenticated") || ex.Message.Contains("SMTP sunucusu güvenli bir bağlantı gerektiriyor veya istemcinin kimliği doğrulanmadı. Sunucu yanıtı şöyleydi"))
                {
                    result.ValidationResults.Add("The SMTP server requires a secure connection or the client was not authenticated", "GmailLessSecureApps");
                }
                return result;
                //CustomLoggingManager.Instance.Log(ex);

                //MailingManager.Instance.SendErrorEmail(ex);
            }
            return result;
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
                LoggingManager.Instance.SaveErrorLog(ex);
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
