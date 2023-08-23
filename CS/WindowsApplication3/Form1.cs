using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DXSample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }
        private void RibbonControl1_CustomDrawItem(object sender, DevExpress.XtraBars.BarItemCustomDrawEventArgs e) {
            if(e.RibbonItemInfo == null) return;
            var link = e.RibbonItemInfo.Item as BarItemLink;
            if(link is BarSubItemLink)
                e.RibbonItemInfo.Appearance.ForeColor = Color.Red;
            if(link.Item.Name == "barButtonItem1") {
                if(e.State == DevExpress.XtraBars.ViewInfo.BarLinkState.Highlighted) {
                    using(var backBrush = new LinearGradientBrush(e.Bounds, Color.DarkGreen, Color.LightGreen,
                            LinearGradientMode.BackwardDiagonal))
                        e.Cache.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.Right, e.Bounds.Y));
                    e.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.X, e.Bounds.Bottom), new Point(e.Bounds.Right, e.Bounds.Bottom));
                    e.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.X, e.Bounds.Bottom));
                    e.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.Right, e.Bounds.Y), new Point(e.Bounds.Right, e.Bounds.Bottom));
                }
                else
                    e.Cache.FillRectangle(Brushes.LightSeaGreen, e.Bounds);
                e.DrawText();
                e.DrawGlyph();
                e.Handled = true;
            }
            if(link.Item.Name == "barEditItem1") {
                if(e.State == DevExpress.XtraBars.ViewInfo.BarLinkState.Highlighted) {
                    using(var backBrush = new LinearGradientBrush(e.Bounds, Color.DarkOrange, Color.LightYellow,
                        LinearGradientMode.BackwardDiagonal)) {
                        e.Cache.Graphics.FillRectangle(backBrush, e.Bounds);
                        e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.Right, e.Bounds.Y));
                        e.Cache.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.X, e.Bounds.Bottom), new Point(e.Bounds.Right, e.Bounds.Bottom));
                        e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.X, e.Bounds.Bottom));
                        e.Cache.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.Right, e.Bounds.Y), new Point(e.Bounds.Right, e.Bounds.Bottom));
                    }
                }
                else
                    e.Cache.FillRectangle(Brushes.Yellow, e.Bounds);
                e.DrawText();
                e.DrawGlyph();
                e.DrawEditor();
                e.Handled = true;
            }
        }
    }
}
