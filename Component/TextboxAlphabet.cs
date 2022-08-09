using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Security.Permissions;

namespace APP
{
    public class TextBoxAlphabet : System.Windows.Forms.TextBox
    {
        const int WM_PASTE = 0x302;

        [SecurityPermission(SecurityAction.Demand,
            Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            //if (m.Msg == WM_PASTE)
            //  return;

            base.WndProc(ref m);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Ctrl+V
            if (((keyData & Keys.Control) == Keys.Control && (keyData & Keys.KeyCode) == Keys.V))
            {
                //foreach (var c in Clipboard.GetText())
                //{
                //    if (!IsValidChar(c))
                //    {
                //        MessageBox.Show("意図しない文字が含まれているのでペーストできません。", "Error");
                //        return true;
                //    }
                //}

                return base.ProcessCmdKey(ref msg, keyData);
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            /// CTRLキー
            if ((Control.ModifierKeys == Keys.Control))
            {
                Console.WriteLine("CTRLキー");
            }

            /// 
            else if (!IsValidChar(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        protected virtual bool IsValidChar(char c)
        {
            return (c >= 'a' && c <= 'z') 
                || (c >= 'A' && c <= 'Z')
                || (c >= '0' && c <= '9')
                || (c == ' ')
                || (c == ':')
                || (c == '#')
                || (c == '$')
                || (c == '@')
                || (c == '%')
                || (c == '&')
                || (c == '=')
                || (c == '(')
                || (c == ')')
                || (c == '[')
                || (c == ']')
                || (c == '+') 
                || (c == '-')
                || (c == '/')
                || (c == '*');
        }
    }
}
