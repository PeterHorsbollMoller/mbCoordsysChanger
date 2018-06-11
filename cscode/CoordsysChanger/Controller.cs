using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoordsysChanger
{
    public class Controller
    {
        private static CoordsysChangerDialog coordsysDlg = null;

        /// <summary>
        /// This function is called from MapBasic code
        /// to display the Search dialog.
        /// </summary>
        /// <param name="hMainWnd"></param>
        /// <returns></returns>
        public static bool ShowCoordsysChangerDlg(int hMainWnd, string[] tables, bool floating)
        {

            if ((coordsysDlg == null) || (coordsysDlg.IsDisposed))
                coordsysDlg = new CoordsysChangerDialog();

            if (coordsysDlg.Visible == true)
                return true;

            InteropHelper.Do(string.Format("Set Application Window {0}", coordsysDlg.Handle));

            coordsysDlg.Tables = tables;
            if (floating)
                coordsysDlg.Show(GetWindowWrapper(hMainWnd));
            else
                coordsysDlg.ShowDialog(GetWindowWrapper(hMainWnd));
            //}

            InteropHelper.Do(string.Format("Set Application Window {0}", 0));
            return true;
        }

        /// <summary>
        /// Returns the window wrapper.
        /// If window wrapper is null it correctly initializes the static member
        /// </summary>
        /// <param name="hMainWnd">Handle to a window</param>
        /// <returns>Window wrapper for the given handle</returns>
        private static WindowWrapper GetWindowWrapper(int hMainWnd)
        {
            IntPtr hwnd = new IntPtr(hMainWnd);
            WindowWrapper winWrap = new WindowWrapper(hwnd);
            return winWrap;
        }
    }

    /// <summary>
    /// This class implements IWin32Window wrapping a handle to window.
    /// It is used to wrap the handle to a running instance of 
    /// MapInfo Professional application.
    /// </summary>
    public class WindowWrapper : System.Windows.Forms.IWin32Window
    {
        public WindowWrapper(IntPtr handle)
        {
            _hwnd = handle;
        }

        public IntPtr Handle
        {
            get { return _hwnd; }
        }

        private IntPtr _hwnd;
    }
}
