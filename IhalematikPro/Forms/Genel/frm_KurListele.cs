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
using System.Xml;
using IhalematikProUI.Forms;
using IhalematikProBL.Manager;

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_KurListele : DevExpress.XtraEditors.XtraForm
    {
        public frm_KurListele()
        {
            InitializeComponent();
        }
        public DataTable source()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new DataColumn("Adı", typeof(string)));
            dt.Columns.Add(new DataColumn("Kod", typeof(string)));
            dt.Columns.Add(new DataColumn("Döviz alış", typeof(string)));
            dt.Columns.Add(new DataColumn("Döviz satış", typeof(string)));
            XmlTextReader rdr = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlDocument myxml = new XmlDocument();
            myxml.Load(rdr);
            XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
            XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
            XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
            XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
            XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
            XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
            int x = 19;


            for (int i = 0; i < x; i++)
            {
                dr = dt.NewRow();
                dr[0] = adi.Item(i).InnerText.ToString();
                dr[1] = kod.Item(i).InnerText.ToString();
                dr[2] = doviz_alis.Item(i).InnerText.ToString();
                dr[3] = doviz_satis.Item(i).InnerText.ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_KurListele_Shown(object sender, EventArgs e)
        {
            {
                try
                {
                    dataGrid1.DataSource = source();
                }
                catch (Exception ex)
                {
                    LoggingManager.Instance.SaveErrorLog(ex);
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "İnternet Bağlantınız olmadığından\n Döviz kurları alınamadı...";
                    mf.ShowDialog();
                }
            }
        }
    }
}
