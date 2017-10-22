using NativeWifi.Win32.Wifi.Interop;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Win32.Wifi.Interop;

namespace Win32.Wifi
{
   

    public class WlanClient
    {
        UInt32 errorCode = 0;  //код ошибки
        public IntPtr handle;
        
        public WlanClient()
        {
            
        }

        public void Open()
        {
            errorCode = WlanInterop.WlanOpenHandle(2u, IntPtr.Zero, out UInt32 pdwNegotiatedVersion, out handle);
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

        public WlanInterface[] Interfaces
        {
            get
            {
                WlanInterop.WlanEnumInterfaces(handle, IntPtr.Zero, out IntPtr pInterfaceList);
                
                UInt32 dwNumberOfItems = (UInt32)Marshal.ReadInt32(pInterfaceList, 0);
                UInt32 dwIndex = (UInt32)Marshal.ReadInt32(pInterfaceList, sizeof(UInt32));
                pInterfaceList += 2 * sizeof(UInt32);

                WlanInterfaceInfo wlanInterfaceInfo;
                WlanInterface[] wlanInterface = new WlanInterface[dwNumberOfItems];

                Int32 sizeOfStruct = Marshal.SizeOf(typeof(WlanInterfaceInfo));
                for (int i = 0; i < dwNumberOfItems; i++)
                {
                    wlanInterfaceInfo = (WlanInterfaceInfo)Marshal.PtrToStructure(pInterfaceList + sizeOfStruct * i, typeof(WlanInterfaceInfo));
                    wlanInterface[i] = new WlanInterface(this.handle, wlanInterfaceInfo.interfaceGuid, wlanInterfaceInfo.interfaceDescription);
                }
                return wlanInterface;                   
            }
        }

        
    }
}
