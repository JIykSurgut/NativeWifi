using System;
using System.Runtime.InteropServices;

namespace Win32.Wifi.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WLAN_CONNECTION_PARAMETERS
    {
        public WLAN_CONNECTION_MODE wlanConnectionMode;
        public string strProfile;
        public DOT11_SSID[] pDot11Ssid;
        public DOT11_BSSID_LIST[] pDesiredBssidList;
        public DOT11_BSS_TYPE dot11BssType;
        public uint dwFlags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DOT11_SSID
    {
        public uint uSSIDLength;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string ucSSID;
    }

    public struct DOT11_BSSID_LIST
    {
        NDIS_OBJECT_HEADER Header;
        ulong uNumOfEntries;
        ulong uTotalNumOfEntries;
        IntPtr BSSIDs;
    }

    public struct NDIS_OBJECT_HEADER
    {
        byte Type;
        byte Revision;
        ushort Size;
    }

    //реализовать
    [StructLayout(LayoutKind.Sequential)]
    public struct WLAN_NOTIFICATION_DATA
    {
        /// <summary>
        /// Specifies where the notification comes from.
        /// </summary>
        /// <remarks>
        /// On Windows XP SP2, this field must be set to <see cref="WlanNotificationSource.None"/>, <see cref="WlanNotificationSource.All"/> or <see cref="WlanNotificationSource.ACM"/>.
        /// </remarks>
        public WLAN_NOTIFICATION_SOURCE notificationSource;
        /// <summary>
        /// Indicates the type of notification. The value of this field indicates what type of associated data will be present in <see cref="dataPtr"/>.
        /// </summary>
        public int notificationCode;
        /// <summary>
        /// Indicates which interface the notification is for.
        /// </summary>
        public Guid interfaceGuid;
        /// <summary>
        /// Specifies the size of <see cref="dataPtr"/>, in bytes.
        /// </summary>
        public int dataSize;
        /// <summary>
        /// Pointer to additional data needed for the notification, as indicated by <see cref="notificationCode"/>.
        /// </summary>
        public IntPtr dataPtr;

        /// <summary>
        /// Gets the notification code (in the correct enumeration type) according to the notification source.
        /// </summary>
        public object NotificationCode
        {
            get
            {
                //if (notificationSource == WLAN_NOTIFICATION_SOURCE.MSM)
                //    return (WLAN_NOTIFICATION_CODE_MSM)notificationCode;
                //else if (notificationSource == WLAN_NOTIFICATION_SOURCE.ACM)
                //    return (WLAN_NOTIFICATION_CODE_ACM)notificationCode;
                //else
                    return notificationCode;
            }

        }
    }


    public struct WlanNotificationData
    {
        public WlanNotificationSource notificationSource;

        public int notificationCode;

        public Guid interfaceGuid;

        public int dataSize;

        public IntPtr dataPtr;

        public object NotificationCode
        {
            get
            {
                if (this.notificationSource == WlanNotificationSource.MSM)
                {
                    return (WlanNotificationCodeMsm)this.notificationCode;
                }
                if (this.notificationSource == WlanNotificationSource.ACM)
                {
                    return (WlanNotificationCodeAcm)this.notificationCode;
                }
                return this.notificationCode;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    //Перечислите беспроводные интерфейсы
    [StructLayout(LayoutKind.Sequential)]
    public struct WlanInterfaceInfoList
    {
        public Int32 dwNumberOfItems;
        public Int32 dwIndex;
        public WlanInterfaceInfo[] InterfaceInfo;
        public WlanInterfaceInfoList(IntPtr pList)
        {
            dwNumberOfItems = Marshal.ReadInt32(pList, 0);
            dwIndex = Marshal.ReadInt32(pList, 4);
            InterfaceInfo = new WlanInterfaceInfo[dwNumberOfItems];
            for (int i = 0; i <= dwNumberOfItems - 1; i++)
            {
                IntPtr pItemList = new IntPtr(pList.ToInt64() + (i * 532) + 8);
                InterfaceInfo[i] = (WlanInterfaceInfo)Marshal.PtrToStructure(pItemList, typeof(WlanInterfaceInfo));
            }
        }
    }

    //для WlanInterfaceInfoList
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WlanInterfaceInfo
    {
        public Guid interfaceGuid;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string interfaceDescription;

        public WlanInterfaceState isState;
    }

    
}
