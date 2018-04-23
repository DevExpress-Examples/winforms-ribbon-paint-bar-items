using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;

namespace DXSample {

    public class MyRibbonPanelGroupPainter : RibbonPanelGroupPainter
    {
        public MyRibbonPanelGroupPainter() : base() { }
        protected override void DrawItem(RibbonViewInfo viewInfo, DevExpress.Utils.Drawing.GraphicsCache cache, RibbonItemViewInfo itemInfo)
        {
            MyRibbonItemViewInfoCalculator.DrawItem(cache, itemInfo);
        }

    }
}