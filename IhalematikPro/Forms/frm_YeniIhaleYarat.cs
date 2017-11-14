using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProBL.Manager;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using System.Threading;
using IhalematikProUI.Forms;

namespace IhalematikPro.Forms
{
    public partial class frm_YeniIhaleYarat : DevExpress.XtraEditors.XtraForm
    {
        private object a1;

        public frm_YeniIhaleYarat()
        {
            InitializeComponent();
        }

        private void frm_YeniIhaleYarat_Load(object sender, EventArgs e)
        {
            int lastTenderNumber = TenderManager.Instance.GetLastTenderNumber();
            txtTeklifNo.Text = string.Format("{0}", (lastTenderNumber + 1).ToString().PadLeft(8, '0'));

            //CurrentManager.Vehicles = UIVehicleManager.Instance.GetVehicles();
            //CurrentManager.Workers = UIWorkerManager.Instance.GetWorkers();

            //grdVehicle.DataSource = CurrentManager.Vehicles;
            //grdWorker.DataSource = CurrentManager.Workers;
            pbControl.Visible = false;
        }

        private void a1_FormClosed(object sender, FormClosedEventArgs e)
        {
            a1 = null;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_YeniIhaleYarat_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frm_YeniIhaleYarat_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnIhaleOlustur_Click(object sender, EventArgs e)
        {
            pbControl.Visible = true;
            Tender tender = new Tender();
            tender.Equipments = new List<TenderEquipment>();
            int lastTenderNumber = TenderManager.Instance.GetLastTenderNumber();
            tender.Number = lastTenderNumber + 1;
            tender.Description = txtAciklama.Text;
            tender.LastOfferDate = LastOfferDate.DateTime;
            tender.CompanyName = txtcompanyName.Text;
            tender.EkapNumber = txtEkapNumber.Text;
            tender.Type = txtType.Text;
            tender.Scope = txtScope.Text;
            tender.Procedure = txtProcedure.Text;
            tender.Place = txtPlace.Text;
            tender.Management = txtManagement.Text;
            tender.IsActive = true;

            bool result = TenderManager.Instance.Save(tender);
            if (!result)
            {
                //TODO feyzullahg hata olustuysa yonlendir
            }
            else
            {
                CurrentManager.Instance.CurrentTender = tender;
            }

            for (int i = 0; i < 101; i++)
            {
                Thread.Sleep(0);
                pbControl.Position = i;
                Application.DoEvents();
            }
            this.Enabled = false;
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Yeni İhale Oluşturuldu";
            mf.ShowDialog();




            frm_IhaleGrup ig = new frm_IhaleGrup();
            ig.ShowDialog();
            this.Close();
            frm_Teklif_Adim1 a1 = (frm_Teklif_Adim1)Application.OpenForms["frm_Teklif_Adim1"];
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            if (a1 == null)
            {
                a1 = new frm_Teklif_Adim1();
                a1.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                a1.FormClosed += new FormClosedEventHandler(a1_FormClosed);
                af.MainPanel.Visible = false;
                a1.Show();

            }
            else
            {
                a1.Activate();
            }
            pbControl.Visible = false;
        }

    }
}
