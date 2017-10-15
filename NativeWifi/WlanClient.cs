using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Win32.Wifi.Interop;

namespace Win32.Wifi
{
    public class WlanClient
    {
        UInt32 errorCode = 0;  //код ошибки
        public IntPtr phClientHandle;
        
        WlanClient()
        {
            errorCode = WlanInterop.WlanOpenHandle(2u, IntPtr.Zero, out UInt32 pdwNegotiatedVersion, out phClientHandle);
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

        public WlanInterfaceInfoList Interface
        {
            get
            {
                WlanInterop.WlanEnumInterfaces(
                    phClientHandle, 
                    IntPtr.Zero, 
                    out WlanInterfaceInfoList wlanInterfaceList);
                return wlanInterfaceList;
            }
        }

        
            
    }
}
