using System;
using System.Runtime.InteropServices;

namespace Win32.Wifi.Interop
{
    //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    //public struct WLAN_CONNECTION_PARAMETERS
    //{
    //    public WLAN_CONNECTION_MODE wlanConnectionMode;
    //    public string strProfile;
    //    public DOT11_SSID[] pDot11Ssid;
    //    public DOT11_BSSID_LIST[] pDesiredBssidList;
    //    public DOT11_BSS_TYPE dot11BssType;
    //    public uint dwFlags;
    //}

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DOT11_SSID
    {
        public UInt32 uSSIDLength;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public String ucSSID;
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

    ////реализовать
    //[StructLayout(LayoutKind.Sequential)]
    //public struct WLAN_NOTIFICATION_DATA
    //{
    //    /// <summary>
    //    /// Specifies where the notification comes from.
    //    /// </summary>
    //    /// <remarks>
    //    /// On Windows XP SP2, this field must be set to <see cref="WlanNotificationSource.None"/>, <see cref="WlanNotificationSource.All"/> or <see cref="WlanNotificationSource.ACM"/>.
    //    /// </remarks>
    //    public WLAN_NOTIFICATION_SOURCE notificationSource;
    //    /// <summary>
    //    /// Indicates the type of notification. The value of this field indicates what type of associated data will be present in <see cref="dataPtr"/>.
    //    /// </summary>
    //    public int notificationCode;
    //    /// <summary>
    //    /// Indicates which interface the notification is for.
    //    /// </summary>
    //    public Guid interfaceGuid;
    //    /// <summary>
    //    /// Specifies the size of <see cref="dataPtr"/>, in bytes.
    //    /// </summary>
    //    public int dataSize;
    //    /// <summary>
    //    /// Pointer to additional data needed for the notification, as indicated by <see cref="notificationCode"/>.
    //    /// </summary>
    //    public IntPtr dataPtr;

    //    /// <summary>
    //    /// Gets the notification code (in the correct enumeration type) according to the notification source.
    //    /// </summary>
    //    public object NotificationCode
    //    {
    //        get
    //        {
    //            //if (notificationSource == WLAN_NOTIFICATION_SOURCE.MSM)
    //            //    return (WLAN_NOTIFICATION_CODE_MSM)notificationCode;
    //            //else if (notificationSource == WLAN_NOTIFICATION_SOURCE.ACM)
    //            //    return (WLAN_NOTIFICATION_CODE_ACM)notificationCode;
    //            //else
    //                return notificationCode;
    //        }

    //    }
    //}


    //public struct WlanNotificationData
    //{
    //    public WlanNotificationSource notificationSource;

    //    public int notificationCode;

    //    public Guid interfaceGuid;

    //    public int dataSize;

    //    public IntPtr dataPtr;

    //    public object NotificationCode
    //    {
    //        get
    //        {
    //            if (this.notificationSource == WlanNotificationSource.MSM)
    //            {
    //                return (WlanNotificationCodeMsm)this.notificationCode;
    //            }
    //            if (this.notificationSource == WlanNotificationSource.ACM)
    //            {
    //                return (WlanNotificationCodeAcm)this.notificationCode;
    //            }
    //            return this.notificationCode;
    //        }
    //    }
    //}

    /// <summary>
    /// 
    /// </summary>
    //Перечислите беспроводные интерфейсы
    [StructLayout(LayoutKind.Sequential)]
    public struct WlanInterfaceInfoList
    {
        public UInt32 dwNumberOfItems;
        public UInt32 dwIndex;
        public IntPtr InterfaceInfo;       
    }

    //для WlanInterfaceInfoList
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WlanInterfaceInfo
    {
        public Guid interfaceGuid;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string interfaceDescription;

        //public WlanInterfaceState isState;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WLAN_CONNECTION_ATTRIBUTES
    {
        public InterfaceState isState;
        public ConnectionMode wlanConnectionMode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string strProfileName;
        public WLAN_ASSOCIATION_ATTRIBUTES wlanAssociationAttributes;
        public WLAN_SECURITY_ATTRIBUTES wlanSecurityAttributes;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WLAN_ASSOCIATION_ATTRIBUTES
    {
        public DOT11_SSID dot11Ssid;
        public Dot11BSSType dot11BssType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        public String dot11Bssid;
        public Dot11PHYType dot11PhyType;
        public UInt32 uDot11PhyIndex;
        public UInt32 wlanSignalQuality; //WLAN_SIGNAL_QUALITY
        public UInt32 ulRxRate;
        public UInt32 ulTxRate;
    }

    public struct WLAN_SECURITY_ATTRIBUTES
    {
        Boolean bSecurityEnabled;
        Boolean bOneXEnabled;
        Dot11AuthAlgorithm dot11AuthAlgorithm;
        Dot11CipherAlgorithm dot11CipherAlgorithm;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct AvailableNetwork
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        String strProfileName;
        DOT11_SSID dot11Ssid;
        Dot11BssType dot11BssType;
        UInt32 uNumberOfBssids;
        Boolean bNetworkConnectable;
        WlanReasonCode wlanNotConnectableReason;
        UInt32 uNumberOfPhyTypes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        Dot11PHYType[] dot11PhyTypes;
        Boolean bMorePhyTypes;
        UInt32 wlanSignalQuality;
        Boolean bSecurityEnabled;
        Dot11AuthAlgorithm dot11DefaultAuthAlgorithm;
        Dot11CipherAlgorithm dot11DefaultCipherAlgorithm;
        UInt32 dwFlags;
        UInt32 dwReserved;
    }
 
}
