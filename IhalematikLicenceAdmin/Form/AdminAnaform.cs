using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;


namespace IhalematikLicenceAdmin
{
    public partial class AdminAnaform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminAnaform()
        {
            InitializeComponent();
        }




        MusteriOlustur pl;
        private void btnMusteri_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnMusteri.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (pl == null)
            {
                pl = new MusteriOlustur();
                pl.MdiParent = this;
                pl.FormClosed +=new FormClosedEventHandler(Pl_FormClosed);
                pl.Show();
            }
            else
            {
                pl.Activate();
            }

        }

        private void Pl_FormClosed(object sender, FormClosedEventArgs e)
        {
            pl = null;
            RibonAktif();
            btnMusteri.ButtonStyle = BarButtonStyle.Default;
        }

        private void AdminAnaform_Load(object sender, EventArgs e)
        {

        }
        public void RibonAktif()
        {
            mainPanel.Visible = true;
            ribbon.Enabled = true;
        }
        public void RibonPasif()
        {
            mainPanel.Visible = false;
            ribbon.Enabled = false;
        }
        private void AdminAnaform_Shown(object sender, EventArgs e)
        {
            picLogo.Left = (mainPanel.Width / 2) - (picLogo.Width / 2);
            picLogo.Top = (mainPanel.Height / 2) - (picLogo.Height / 2);
        }
    }
}