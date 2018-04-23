using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.XtraBars;
using System.Drawing.Drawing2D;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void OnCustomDrawBarItemLink(object sender, CustomDrawBarItemEventArgs e)
        {
            if(e.ItemLink is BarSubItemLink)
                e.Appearance.ForeColor = Color.Red;
            if (e.ItemLink.Item.Name == "barButtonItem1")
            {
                if (e.IsItemHotTracked)
                {
                    e.Cache.Graphics.FillRectangle(new LinearGradientBrush(e.Bounds, Color.DarkGreen, Color.LightGreen, 
                        LinearGradientMode.BackwardDiagonal), e.Bounds);
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.Right, e.Bounds.Y));
                    e.Cache.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.X, e.Bounds.Bottom), new Point(e.Bounds.Right, e.Bounds.Bottom));
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.X, e.Bounds.Bottom));
                    e.Cache.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.Right, e.Bounds.Y), new Point(e.Bounds.Right, e.Bounds.Bottom));
                }
                else
                    e.Cache.Graphics.FillRectangle(new SolidBrush(Color.LightSeaGreen), e.Bounds);
                e.Appearance.DrawString(e.Cache, e.ItemLink.Caption, e.CaptionBounds);
                if (e.ItemLink.ImageIndex != -1)
                {
                    Image image = (e.ItemLink.Item.Images as ImageCollection).Images[e.ItemLink.ImageIndex];
                    e.Cache.Graphics.DrawImage(image, e.GlyphBounds);
                }
                e.Handled = true;
            }
            if (e.ItemLink.Item.Name == "barEditItem1")
            {
                if (e.IsItemHotTracked)
                {
                    e.Cache.Graphics.FillRectangle(new LinearGradientBrush(e.Bounds, Color.DarkOrange, Color.LightYellow,
                        LinearGradientMode.BackwardDiagonal), e.Bounds);
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.Right, e.Bounds.Y));
                    e.Cache.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.X, e.Bounds.Bottom), new Point(e.Bounds.Right, e.Bounds.Bottom));
                    e.Cache.Graphics.DrawLine(Pens.White, e.Bounds.Location, new Point(e.Bounds.X, e.Bounds.Bottom));
                    e.Cache.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.Right, e.Bounds.Y), new Point(e.Bounds.Right, e.Bounds.Bottom));
                }
                else
                    e.Cache.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
                e.Appearance.DrawString(e.Cache, e.ItemLink.Caption, e.CaptionBounds);
                if (e.ItemLink.ImageIndex != -1)
                {
                    Image image = (e.ItemLink.Item.Images as ImageCollection).Images[e.ItemLink.ImageIndex];
                    e.Cache.Graphics.DrawImage(image, e.GlyphBounds);
                }
                e.Handled = true;
            }
        }
    }
}
