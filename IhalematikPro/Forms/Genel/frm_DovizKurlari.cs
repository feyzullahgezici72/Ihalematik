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
using System.Xml;
namespace IhalematikPro.Forms
{
    public partial class frm_DovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public frm_DovizKurlari()
        {
            InitializeComponent();
        }

        private void frm_DovizKurlari_Load(object sender, EventArgs e)
        {
            dataGrid1.DataSource = source();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGizliKapat_Click(object sender, EventArgs e)
        {
             this.Close();
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
    }
}