using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;

namespace DXSample {
    public class MyRibbonViewInfo : RibbonViewInfo
    {
        public MyRibbonViewInfo(RibbonControl ribbonControl) : base(ribbonControl) { }
        protected override RibbonItemViewInfoCalculator CreateItemCalculator()
        {
            return new MyRibbonItemViewInfoCalculator(this);
        }

        public new MyRibbonBarManager Manager
        {
            get { return base.Manager as MyRibbonBarManager; }
        }
        protected override RibbonPanelViewInfo CreatePanelInfo()
        {
            return new MyRibbonPanelViewInfo(this);
        }
    }
}