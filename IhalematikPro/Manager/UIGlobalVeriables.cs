using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProUI.Manager
{
    public class UIGlobalVeriables : SingletonBase<UIGlobalVeriables>
    {
        public string MalzemeMaliyetListesiPath
        {
            get
            {
                string fileName = "MalzemeMaliyetListesi.xls";
                //string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", string.Empty).Replace("Program Files (x86)", "ProgramFiles(x86)"), "ExcelFiles");
                string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", string.Empty), "ExcelFiles");
                string sourceFilePath = Path.Combine(sourcePath, fileName);
                return sourceFilePath;
            }
        }
    }
}
