using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace APP
{
    public class SelectBoxEx : System.Windows.Forms.ComboBox
    {
        private Color _borderColor = Color.Silver;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.None;
        private static int WM_PAINT = 0x000F;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public ButtonBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }

        public void SelectedIndexEx(int index)
        {
            try
            {
                this.SelectedIndex = index;
            }
            catch
            {
                this.SelectedIndex = 0;
            }
        }


        public void SelectedItemEx (string item)
        {
            try
            {
                this.SelectedItem = item;
            }
            catch
            {
                this.SelectedItem = "";
            }
        }

        public void SelectedItemEx(string item, string initial)
        {
            try
            {
                this.SelectedItem = item;
            }
            catch
            {
                this.SelectedItem = initial;
            }
        }

        public string SelectedItemEx()
        {
            try
            {
                return this.SelectedItem.ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}
