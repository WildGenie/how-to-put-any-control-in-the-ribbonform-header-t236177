using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Example
{
    public class RibbonHeaderControlHelper : Component
    {
        #region Fields
        private RibbonControl _RibbonControl;
        private Control _HeaderControl;
        #endregion


        public RibbonHeaderControlHelper()
        {
            _RibbonControl = null;
            _HeaderControl = null;
        }

        #region Properties
        public RibbonControl RibbonControl
        {
            get { return _RibbonControl; }
            set
            {
                _RibbonControl = value;
                OnRibbonControlChanged();
            }
        }

        protected virtual void OnRibbonControlChanged()
        {
            SubscribeRibbonEvents(true);
        }

        public Control HeaderControl
        {
            get { return _HeaderControl; }
            set
            {
                if (_HeaderControl != null)
                    _HeaderControl.Visible = false;
                _HeaderControl = value;
                OnHeaderControlChanged();
            }
        }

        protected virtual void OnHeaderControlChanged()
        {
            if (RibbonControlNotNull)
                ReplaceUserControl();
        }

        protected bool RibbonControlNotNull { get { return _RibbonControl != null; } }
        protected bool HeaderControlNotNull { get { return _HeaderControl != null; } }
        #endregion


        private void SubscribeRibbonEvents(bool subscribe)
        {
            if (RibbonControlNotNull)
            {
                _RibbonControl.Paint -= RibbonControl_Paint;
                if (subscribe)
                    _RibbonControl.Paint += RibbonControl_Paint;
            }
        }

        void RibbonControl_Paint(object sender, PaintEventArgs e)
        {
            ReplaceUserControl();
        }

        protected virtual void ReplaceUserControl()
        {
            if (HeaderControlNotNull)
            {
                HeaderControl.Parent = RibbonControl;
                HeaderControl.Visible = true;
                RibbonViewInfo vi = RibbonControl.ViewInfo;
                RibbonCaptionViewInfo captionInfo = vi.Caption;
                int height = HeaderControl.Height <= 1 ? 17 : HeaderControl.Height;
                int width = HeaderControl.Width;
                Rectangle buttonRect = new Rectangle(captionInfo.ContentBounds.Right - width, captionInfo.ContentBounds.Y + (captionInfo.ContentBounds.Height - height) / 2, width, height);
                HeaderControl.Bounds = buttonRect;
            }
        }

        protected override void Dispose(bool disposing)
        {
            SubscribeRibbonEvents(false);
            base.Dispose(disposing);
        }
    }
}
