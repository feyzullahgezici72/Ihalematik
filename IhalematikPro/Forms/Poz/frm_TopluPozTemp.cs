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
using IhalematikPro.Forms;
using IhalematikProBL.Provider;

namespace IhalematikProUI.Forms.PozTem
{
    public partial class frm_TopluPozTemp : DevExpress.XtraEditors.XtraForm
    {
        private frm_PozListesi _owner = null;
        public List<Poz> pozItems = null;
        public frm_TopluPozTemp(frm_PozListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydetme işlemi veri uzunluğuna göre biraz zaman alabilir...");
            if (this.pozItems != null)
            {
                foreach (IhalematikProBL.Entity.Poz item in pozItems)
                {
                    PozProvider.Instance.Save(item);
                }
                MessageBox.Show("Poz listesi kaydedildi.");
                this._owner.LoadPozGrid();
            }
            else
            {
                MessageBox.Show("Kaydedilecek Poz bulunamadı.");
            }
            this.Close();
        }

        private void frm_TopluPozTemp_Shown(object sender, EventArgs e)
        {
            grdPozTempList.DataSource = this.pozItems;
        }
    }
}