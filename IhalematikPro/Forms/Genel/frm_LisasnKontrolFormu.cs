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

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_LisasnKontrolFormu : DevExpress.XtraEditors.XtraForm
    {
        public frm_LisasnKontrolFormu()
        {
            InitializeComponent();
        }

        private void frm_LisasnKontrolFormu_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLisansla_Click(object sender, EventArgs e)
        {

        }
    }
}