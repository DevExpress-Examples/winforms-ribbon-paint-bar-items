using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.ViewInfo;

namespace DXSample {
    public class MyRibbonBarManager : RibbonBarManager
    {
        public MyRibbonBarManager(RibbonControl ribbonControl) : base(ribbonControl) { }
        internal new BarSelectionInfo SelectionInfo
        {
            get { return base.SelectionInfo; }
        }
    }
}