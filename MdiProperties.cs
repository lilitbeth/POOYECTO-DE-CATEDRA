using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOYECTO_DE_CATEDRA
{
    public static class MdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertafter, int X, int Y, int cx, int cy, uint uflags);

        private const int GWl_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0X200;
        private const uint SWP_NOSIZE = 0X0001;
        private const uint SWP_NOMOVE = 0X0002;
        private const uint SWP_NOZORDER = 0X0004;
        private const uint SWO_NOACTIVATE = 0X0010;
        private const uint SWP_FRAMECHARGED = 0X0020;
        private const uint SWO_NOOWNERZORDER = 0X0200; 

        public static bool SetBevel(this Form form, bool show)
        {
            foreach (Control c in form.Controls)
            {
                MdiClient cliente = c as MdiClient;
                if (cliente != null)
                {
                    int windowLong = GetWindowLong(c.Handle, GWl_EXSTYLE);
                    if (show)
                    {
                        windowLong |= WS_EX_CLIENTEDGE;
                    }
                    else
                    {
                        windowLong &= WS_EX_CLIENTEDGE;
                    }
                    SetWindowLong(c.Handle, GWl_EXSTYLE, windowLong);
                    SetWindowPos(cliente.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWO_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWO_NOOWNERZORDER | SWP_FRAMECHARGED);
                    return true;
                }
            }
         return false;
            
        }

    }
}
