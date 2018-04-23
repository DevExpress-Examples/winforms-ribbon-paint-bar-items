using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.Utils.Drawing;

namespace DXSample {
    public class MyRibbonPanelViewInfo : RibbonPanelViewInfo
    {
        public MyRibbonPanelViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) { }

 

        protected override RibbonPageGroupViewInfo CreateGroupViewInfo(RibbonPageGroup group)
        {
            return new MyRibbonPageGroupViewInfo(ViewInfo, group);
        }

    }


    class MyRibbonPageGroupViewInfo : RibbonPageGroupViewInfo
    {
        public MyRibbonPageGroupViewInfo(RibbonViewInfo viewInfo, RibbonPageGroup group) : base(viewInfo, group)
        {
        }

        protected override RibbonPanelGroupPainter CreatePanelGroupPainter()
        {
            return new MyRibbonPanelGroupPainter();
        }
    }
}
