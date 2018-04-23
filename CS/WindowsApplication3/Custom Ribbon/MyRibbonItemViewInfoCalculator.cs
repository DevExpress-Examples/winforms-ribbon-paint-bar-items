using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Drawing;
using System.Drawing;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.Utils.Paint;
using DevExpress.XtraEditors.Drawing;

namespace DXSample {
    public class MyRibbonItemViewInfoCalculator : RibbonItemViewInfoCalculator
    {
        public MyRibbonItemViewInfoCalculator(BaseRibbonViewInfo viewInfo) : base(viewInfo) { }

        public static new void DrawItem(GraphicsCache cache, RibbonItemViewInfo itemInfo)
        {
            XtraAnimator.Current.DrawAnimationHelper(cache, itemInfo.Owner as ISupportXtraAnimation, itemInfo,
                new RibbonItemPainter(), new RibbonDrawInfo(itemInfo), null, itemInfo);
        }

        public override void DrawButton(DevExpress.Utils.Drawing.GraphicsCache cache, RibbonItemViewInfo item)
        {
            CheckItemViewInfo(cache, item);
            CustomDrawBarItemEventArgs args = new CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds,
                item.CaptionBounds, item.GlyphBounds, item.Item as BarItemLink, IsItemHotTracked(item));
            Ribbon.RaiseCustomDrawBarItemLink(args);
            if (!args.Handled)
                base.DrawButton(cache, item);
            else
                DrawSelection(cache, item);
        }

        public override void DrawDropDownButton(GraphicsCache cache, RibbonItemViewInfo item)
        {
            CheckItemViewInfo(cache, item);
            CustomDrawBarItemEventArgs args = new CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds,
                  item.CaptionBounds, item.GlyphBounds, item.Item as BarItemLink, IsItemHotTracked(item));
            Ribbon.RaiseCustomDrawBarItemLink(args);
            if (!args.Handled)
                base.DrawDropDownButton(cache, item);
            else
                DrawSelection(cache, item);
          
        }
        public override void DrawLargeDropDownButton(GraphicsCache cache, RibbonItemViewInfo item)
        {
            CheckItemViewInfo(cache, item);
            CustomDrawBarItemEventArgs args = new CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds,
                 item.CaptionBounds, item.GlyphBounds, item.Item as BarItemLink, IsItemHotTracked(item));
            Ribbon.RaiseCustomDrawBarItemLink(args);
            if (!args.Handled)
                base.DrawLargeDropDownButton(cache, item);
            else
                DrawSelection(cache, item);
        }

        public override void DrawEditItem(DevExpress.Utils.Drawing.GraphicsCache cache, RibbonItemViewInfo item)
        {
            CheckItemViewInfo(cache, item);
            CustomDrawBarItemEventArgs args = new CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds,
                 item.CaptionBounds, item.GlyphBounds, item.Item as BarItemLink, IsItemHotTracked(item));
            Ribbon.RaiseCustomDrawBarItemLink(args);
            if (!args.Handled)
                base.DrawEditItem(cache, item);
            else
            {
                RibbonEditItemViewInfo editItem = (RibbonEditItemViewInfo)item;
                if (editItem.EditBounds.IsEmpty) return;
                XPaint oldPaint = null;
                ControlGraphicsInfoArgs infoArgs = new ControlGraphicsInfoArgs(editItem.EditViewInfo, cache, editItem.EditBounds, ShouldDrawTextOnGlass(item));
                if (!ViewInfo.OwnerControl.Enabled)
                    infoArgs.ViewInfo.State = ObjectState.Disabled;
                editItem.EditPainter.Draw(infoArgs);
                if (oldPaint != null) cache.Paint = oldPaint;
                DrawSelection(cache, item);
            }
        }

        public override void DrawLargeButton(GraphicsCache cache, RibbonItemViewInfo item)
        {
            CheckItemViewInfo(cache, item);
            CustomDrawBarItemEventArgs args = new CustomDrawBarItemEventArgs(cache, item.Appearance, item.Bounds,
                 item.CaptionBounds, item.GlyphBounds, item.Item as BarItemLink, IsItemHotTracked(item));
            Ribbon.RaiseCustomDrawBarItemLink(args);
            if (!args.Handled)
                base.DrawLargeButton(cache, item);
            else
                DrawSelection(cache, item);
        }

        protected virtual bool IsItemHotTracked(RibbonItemViewInfo item)
        {
            return ViewInfo.Manager.SelectionInfo.HighlightedLink == item.Item;
        }

        public new MyRibbonViewInfo ViewInfo
        {
            get { return base.ViewInfo as MyRibbonViewInfo; }
        }

        public MyRibbonControl Ribbon
        {
            get { return ViewInfo.Ribbon as MyRibbonControl; }
        }
    }
}