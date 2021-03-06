﻿using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace IhalematikProUI.Manager
{
    public class UIPopupManager : SingletonBase<UIPopupManager>
    {
        public void ShowPopup()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = IhalematikProUI.Properties.Resources.information_icon64;
            popup.HeaderHeight = 20;
            popup.HeaderColor = Color.Green;
            popup.TitleText = "  KAYIT ZAMANI:  " + DateTime.Now.ToString();
            popup.ContentFont.Bold.ToString();
            popup.ContentFont = new System.Drawing.Font("Arial Black", 14F);
            popup.TitleColor = Color.Red;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.ContentText = "\n İşlem Başarıyla Kaydedildi...";
            popup.Delay = 1000;
            popup.Popup();
        }
    }
}
