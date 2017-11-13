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
using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;

namespace IhalematikPro.Forms
{
    public partial class frm_CalisanEkle : DevExpress.XtraEditors.XtraForm
    {

        frm_CalisanTanimlama _owner = null;
        public frm_CalisanEkle(frm_CalisanTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TitleModel model = new TitleModel();
            model.Name = txtUnvan.Text;
            List<Title> existingItems = TitleProvider.Instance.GetItems("Name", model.Name.Trim());
            if (existingItems.Count == 0)
            {
                model.Save();
                MessageBox.Show("Ünvan Kaydedildi");
                txtUnvan.ResetText();
                txtUnvan.Focus();
                this._owner.InitilalizeForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu unvan zaten mevcut");
                txtUnvan.ResetText();
                txtUnvan.Focus();
            }
        }
    }
}