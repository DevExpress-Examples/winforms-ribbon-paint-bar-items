using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;

namespace DXSample {
    public class MyRibbonControl : RibbonControl
    {
        public MyRibbonControl() : base() { }
        protected override DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo CreateViewInfo()
        {
            return new MyRibbonViewInfo(this);
        }
        protected override RibbonBarManager CreateBarManager()
        {
            return new MyRibbonBarManager(this);
        }

        public event CustomDrawBarItemEventHandler CustomDrawBarItemLink;
        internal void RaiseCustomDrawBarItemLink(CustomDrawBarItemEventArgs e)
        {
            if (CustomDrawBarItemLink != null)
                CustomDrawBarItemLink(this, e);
        }
    }
}