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
using IhalematikProUI.Forms;
using IhalematikProBL.Manager;

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
           
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGizliKapat_Click(object sender, EventArgs e)
        {
             this.Close();
        }
      

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class Currency
        {
            public string Code { get; set; }
            public decimal Rate { get; set; }
        }
        private decimal GetRate(string code)
        {
            string url = string.Empty;
            var date = DateTime.Now;
            if (date.Date == DateTime.Today)
                url = "http://www.tcmb.gov.tr/kurlar/today.xml";
            else
                url = string.Format("http://www.tcmb.gov.tr/kurlar/{0}{1}/{2}{1}{0}.xml", date.Year, addZero(date.Month), addZero(date.Day));

            System.Xml.Linq.XDocument document = System.Xml.Linq.XDocument.Load(url);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var result = document.Descendants("Currency")
            .Where(v => v.Element("ForexBuying") != null && v.Element("ForexBuying").Value.Length > 0)
            .Select(v => new Currency
            {
                Code = v.Attribute("Kod").Value,
                Rate = decimal.Parse(v.Element("ForexBuying").Value.Replace('.', ','))
            }).ToList();
            return result.FirstOrDefault(s => s.Code == code).Rate;
        }
        private string addZero(int p)
        {
            if (p.ToString().Length == 1)
                return "0" + p;
            return p.ToString();
        }

      

        private void btnOnlineAl_Click(object sender, EventArgs e)
        {
            try
            {
                txtDolar.Text = GetRate("USD").ToString();
                txtEuro.Text = GetRate("EUR").ToString();
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