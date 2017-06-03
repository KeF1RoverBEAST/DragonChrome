using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace DragonChrome
{
    class Program
    {
        #region VAR
        public static int x = 775;
        public static int y = 250;

        #endregion
        #region DLL
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hDC, int x, int y);

        #endregion
        static void Main(string[] args)
        {
            IntPtr hDC = GetDC(IntPtr.Zero);
            while (true)
            {
                uint pixel1 = GetPixel(hDC, Convert.ToInt32(x), y);
                if (pixel1 == 5460819)
                {
                    SendKeys.SendWait("{UP}");
                }
            }
        }
    }
}
