﻿using System;
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
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProUI.Forms;
using System.Threading;

namespace IhalematikPro.Forms
{
    public partial class frm_PozListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_PozListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PozListesi_Load(object sender, EventArgs e)
        {
            MesajVer();
            LoadGrid();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        public void bekleyiniz()
        {
            Thread.Sleep(1000);
        }
        public void MesajVer()
        {
            using (frm_wait frm = new frm_wait(bekleyiniz))
            {
                frm.ShowDialog();
            }
        }
        public void LoadGrid()
        {
            List<PozModel> pozs = UIPozManager.Instance.GetPozs();
            grdPozList.DataSource = pozs;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            PozModel model = new PozModel();
            model.Description = txtDescription.Text;
            model.Number = txtNumber.Text;
            model.Unit = txtUnit.Text;
            model.UnitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtUnitPrice.Text);
            model.Save();
            FormClear();
            LoadGrid();
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Kayıt Yapıldı...";
            mf.ShowDialog();

        }
        private void FormClear()
        {
            this.txtNumber.ResetText();
            this.txtDescription.ResetText();
            this.txtUnit.ResetText();
            this.txtUnitPrice.ResetText();
            this.txtNumber.Focus();
        }
        private void grdPozList_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDescription.ResetText();
            txtNumber.ResetText();
            txtUnit.ResetText();
            txtUnitPrice.ResetText();
            txtNumber.Focus();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_pozGuncelle frm = new frm_pozGuncelle(this);
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewPozList.GetFocusedRowCellValue("Id"));
            frm.CurrentPozId = id;

            pozMenu.Visible = false;
            grdPozList.Enabled = false;

            frm.ShowDialog();
            pozMenu.Visible = true;
            grdPozList.Enabled = true;
        }
    }
}