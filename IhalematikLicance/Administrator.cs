using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhalematikLicance
{
    public partial class Administrator : DevExpress.XtraEditors.XtraForm
    {

        public CustomInstall _owner;
        public Administrator(CustomInstall Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string passWord = txtPassword.Text.Trim();

            if ((userName.Equals("MariaGezici") && passWord.Equals("FG!Selcuk!86")) || (userName.Equals("EyupCan") && passWord.Equals("01032013.sb")))
            {
                this._owner.IsAdministratorLogin = true;
            }
        }
    }
}
