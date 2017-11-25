using IhalematikProBL.Entity;
using IhalematikProBL.Mailing;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    [Serializable]
    public class MailingManager : SingletonBase<MailingManager>
    {
        public EmailHelper EmailHelper { get; set; }

        public string SubjectPrefix { get; set; }

        public MailingManager()
        {
            this.EmailHelper = new EmailHelper();
        }

        protected void SendEmail(EmailData EMail)
        {
            try
            {
                bool isValid = EMail != null;//&& validationResults.Count == 0;

                if (isValid)
                {
                    string Subject = EMail.Subject;

                    if (!string.IsNullOrEmpty(this.SubjectPrefix))
                    {
                        Subject = this.SubjectPrefix + Subject;
                    }

                    this.EmailHelper.SendEmail(this.EmailHelper.MailSender, this.EmailHelper.MailSenderDisplayName, EMail.Recipient, Subject, EMail.Body, true, null, EMail.AttachmentFileName);
                }

                else
                {
                    throw new Exception("Invalid Email message");
                }
            }

            catch (Exception ex)
            {
                MailingManager.Instance.SendErrorEmail(ex);
            }
        }

        protected void SendEmail(string Subject, string Body, string Recipient, string AttachmentFilename = null)
        {
            EmailData emailData = new EmailData();
            emailData.Subject = Subject;
            emailData.Body = Body;
            emailData.Recipient = Recipient;
            emailData.AttachmentFileName = AttachmentFilename;
            this.SendEmail(emailData);
        }

        private void SendEmail(string Code, Hashtable Parameters, string EmailAddress, string CultureCode)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("CultureCode", CultureCode);
            parameters.Add("Code", Code);

            EmailSetting emailSetting = new EmailSetting(); //EmailSettingProvider.Instance.GetOne(parameters);

            if (emailSetting != null)
            {
                string template = emailSetting.Template;
                string subject = emailSetting.Subject;
                string message = this.GenerateEmailMessage(template, Parameters);
                this.SendEmail(subject, message, EmailAddress);
            }
        }

        public void SendMemberActivationCode(string CultureCode, string FullName, string EmailAddress, string ApplicationUrl)
        {
            Hashtable parameters = new Hashtable();
            parameters.Add("ApplicationUrl", ApplicationUrl);
            parameters.Add("FullName", FullName);
            this.SendEmail("EmailActivation", parameters, EmailAddress, CultureCode);
        }

        public void SendNewPassword(string CultureCode, string FullName, string EmailAddress, string NewPassword, string ApplicationUrl)
        {
            Hashtable parameters = new Hashtable();
            parameters.Add("ApplicationUrl", ApplicationUrl);
            parameters.Add("FullName", FullName);
            parameters.Add("NewPassword", NewPassword);
            this.SendEmail("ForgotPassword", parameters, EmailAddress, CultureCode);
        }

        public void SendReservationEmail(string CultureCode, string template, string EmailAddress)
        {
            if (CultureCode == "tr-TR")
            {
                this.SendEmail("Rezervasyon Bilgileriniz", template, EmailAddress);
            }
            else
            {
                this.SendEmail("Booking information", template, EmailAddress);
            }

        }

        public void SendErrorEmail(string CultureCode, string EmailAddress, Guid TransactionId, Exception ex = null, string Message = null)
        {
            Hashtable parameters = new Hashtable();

            parameters.Add("TransactionId", TransactionId);

            if (ex != null && ex.Message != null)
            {
                parameters.Add("Message", ex.Message);
                parameters.Add("StackTrace", ex.StackTrace);
                parameters.Add("InnerExceptionMessage", ex.InnerException == null ? string.Empty : ex.InnerException.Message);
                parameters.Add("InnerExceptionStackTrace", ex.InnerException == null ? string.Empty : ex.InnerException.StackTrace);
            }

            else
            {
                parameters.Add("Message", Message);
                parameters.Add("StackTrace", string.Empty);
                parameters.Add("InnerExceptionMessage", string.Empty);
                parameters.Add("InnerExceptionStackTrace", string.Empty);
            }

            this.SendEmail("ErrorMessage", parameters, CustomConfigurationManager.Instance.ErrorEMailAddresses, CultureCode);
        }

        public void SendErrorEmail(Exception ex = null, Guid? TransactionId = null)
        {
            string cultureCode = "tr-TR";

            this.SendErrorEmail(cultureCode, CustomConfigurationManager.Instance.ErrorEMailAddresses, TransactionId == null ? Guid.Empty : TransactionId.Value, ex);
        }

        private string GenerateEmailMessage(string Template, Hashtable Parameters)
        {
            IDictionaryEnumerator ienum = Parameters.GetEnumerator();

            while (ienum.MoveNext())
            {
                Template = Template.Replace("#" + ienum.Key.ToString() + "#", ienum.Value.ToString());
            }

            return Template;
        }

        public void SendMaterialToSupplier(string SupplierEmail, string Body, string AttachmentFilename)
        {
            this.SendEmail("IhaleMatik", Body, SupplierEmail, AttachmentFilename);
        }

        #region HelperMethods

        #endregion
    }
}
