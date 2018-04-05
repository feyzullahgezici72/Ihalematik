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
using IhalematikPro.Manager;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_TopluObfYukleIhaleTemp : IhalematikBaseForm
    {
        public frm_Teklif_Adim1 _owner { get; set; }
        public List<MaterialList> MaterialListItems = null;
        public frm_TopluObfYukleIhaleTemp(frm_Teklif_Adim1 Owner)
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
            this.Enabled = false;
            LoadingManager.Instance.Show(this);
            foreach (var item in this.MaterialListItems)
            {
                MaterialListProvider.Instance.Save(item);
                CurrentManager.Instance.CurrentTender.MaterialList.Add(item);

                IhalematikProBL.Entity.OBF currentOBF = OBFProvider.Instance.GetItem(item.PozOBFId);
                if (currentOBF != null)
                {
                    currentOBF.UnitPrice = item.PozOBFUnitePrice;
                    OBFProvider.Instance.Save(currentOBF);
                }
            }
            LoadingManager.Instance.Hide();
            this.Enabled = true;
            this.Close();
            this._owner.LoadTenderGroupGrid();
        }

        private void frm_TopluObfYukleIhaleTemp_Shown(object sender, EventArgs e)
        {
            LoadingManager.Instance.Show(this);
            if (this.MaterialListItems != null)
            {
                foreach (var item in this.MaterialListItems)
                {
                    item.PozOBFUnitePrice = item.PozOBF.UnitPrice;
                }
            }
            grdMaterialList.DataSource = this.MaterialListItems;
            LoadingManager.Instance.Hide();
        }
    }
}