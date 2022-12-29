using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Application {
    public static class SuspendLayoutUpdate {

        // Constant found in windows.h
        private const int WM_SETREDRAW = 0x000B;

        /*
         * Suspends the update event for a control. Getting this to work properly was not fun.
         */
        public static void Suspend(Control controlToSuspend) {

            Message suspendUpdate = Message.Create(controlToSuspend.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);

            NativeWindow window = NativeWindow.FromHandle(controlToSuspend.Handle);
            window.DefWndProc(ref suspendUpdate);
        }

        /*
         * Resumes the update event for a control. Will assume update event is already suspended.
         */
        public static void Resume(Control controlToResume) {
            
            IntPtr wparam = new IntPtr(1);
            Message msgResumeUpdate = Message.Create(controlToResume.Handle, WM_SETREDRAW, wparam, IntPtr.Zero);

            NativeWindow window = NativeWindow.FromHandle(controlToResume.Handle);
            window.DefWndProc(ref msgResumeUpdate);
            controlToResume.Invalidate();
        }
    }
}
