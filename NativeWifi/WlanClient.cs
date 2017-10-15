using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Win32.Wifi.Interop;

namespace Win32.Wifi
{
    public class WlanClient
    {
        int errorCode = 0;  //код ошибки
        public IntPtr handle;
        private uint negotiatedVersion;

        WlanClient()
        {
            errorCode = WlanInterop.WlanOpenHandle(2, IntPtr.Zero, out negotiatedVersion, out handle);
        }

        ~WlanClient()
        {
            try
            {
                WlanInterop.WlanCloseHandle(this.handle, IntPtr.Zero);
            }
            catch
            {
            }
        }

        public WlanInterface[] Interface
        {
            get
            {
                IntPtr intPtr;
                WlanInterop.WlanEnumInterfaces(handle, IntPtr.Zero, ref intPtr);
            }
        }
    }
}
