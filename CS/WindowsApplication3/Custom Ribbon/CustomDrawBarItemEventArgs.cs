using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.XtraBars;

namespace DXSample {
    public delegate void CustomDrawBarItemEventHandler(object sender, CustomDrawBarItemEventArgs e);
    public class CustomDrawBarItemEventArgs : EventArgs
    {
        GraphicsCache cache;
        AppearanceObject appearance;
        Rectangle bounds, captionBounds, glyphBounds;
        BarItemLink itemLink;
        bool isItemHotTracked, handled = false;

        public CustomDrawBarItemEventArgs(GraphicsCache cache, AppearanceObject appearance, Rectangle bounds,
            Rectangle captionBounds, Rectangle glyphBounds, BarItemLink itemLink, bool isItemHotTracked)
        {
            this.cache = cache;
            this.appearance = appearance;
            this.bounds = bounds;
            this.captionBounds = captionBounds;
            this.glyphBounds = glyphBounds;
            this.itemLink = itemLink;
            this.isItemHotTracked = isItemHotTracked;
        }

        public GraphicsCache Cache
        {
            get { return cache; }
        }

        public AppearanceObject Appearance
        {
            get { return appearance; }
        }

        public Rectangle Bounds
        {
            get { return bounds; }
        }

        public Rectangle CaptionBounds
        {
            get { return captionBounds; }
        }

        public Rectangle GlyphBounds
        {
            get { return glyphBounds; }
        }

        public BarItemLink ItemLink
        {
            get { return itemLink; }
        }

        public bool IsItemHotTracked
        {
            get { return isItemHotTracked; }
        }

        public bool Handled
        {
            get { return handled; }
            set { handled = value; }
        }
    }
}