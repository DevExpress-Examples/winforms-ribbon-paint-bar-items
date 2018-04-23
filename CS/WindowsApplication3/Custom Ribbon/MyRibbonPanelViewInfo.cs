using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;

namespace DXSample {
    public class MyRibbonPanelViewInfo : RibbonPanelViewInfo
    {
        public MyRibbonPanelViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) { }

        protected override DevExpress.XtraBars.Ribbon.Drawing.RibbonPanelGroupPainter CreatePanelGroupPainter()
        {
            return new MyRibbonPanelGroupPainter();
        }
    }
}