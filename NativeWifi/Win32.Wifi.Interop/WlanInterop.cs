using System;
using System.Runtime.InteropServices;

namespace Win32.Wifi.Interop
{
    static class WlanInterop
    {
        //    #region 01 WlanAllocateMemory NO INFO
        //    #endregion

        #region 02 WlanCloseHandle
        [DllImport("Wlanapi", EntryPoint = "seseHandle")]
        public static extern uint WlanCloseHandle(
            [In] IntPtr hClientHandle,
            IntPtr pReserved);
        #endregion

        //    #region 03 WlanConnect
        //    [DllImport("Wlanapi.dll", SetLastError = true)]
        //    public static extern uint WlanConnect(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        ref WLAN_CONNECTION_PARAMETERS pConnectionParameters, 
        //        IntPtr pReserved);
        //    #endregion

        //    #region 04 WlanDeleteProfile
        //    [DllImport("Wlanapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        //    public static extern uint WlanDeleteProfile(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        string strProfileName, 
        //        IntPtr pReserved);
        //    #endregion

        //    #region 05 WlanDisconnect
        //    [DllImport("Wlanapi.dll", SetLastError = true)]
        //    public static extern uint WlanDisconnect(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        IntPtr pReserved);
        //    #endregion

        #region 06 WlanEnumInterfaces
        //перечисляет все интерфейсы беспроводной локальной сети, которые в настоящее время включены на локальном компьютере
        [DllImport("wlanapi.dll")]
    public static extern UInt32 WlanEnumInterfaces(
            [In] IntPtr hClientHandle,
            [In, Out] IntPtr pReserved,
            [Out] out IntPtr ppInterfaceList);
        #endregion

        //    #region 07 WlanExtractPsdIEDataList	NO INFO

        //    #endregion

        //    #region 08 WlanFreeMemory
        //    [DllImport("Wlanapi", EntryPoint = "WlanFreeMemory")]
        //    public static extern void WlanFreeMemory(
        //        [In] IntPtr pMemory);
        //    #endregion

        #region 09 WlanGetAvailableNetworkList
        [DllImport("wlanapi.dll", SetLastError = true)]
        public static extern UInt32 WlanGetAvailableNetworkList(
            [In] IntPtr hClientHandle,
            [In] ref Guid pInterfaceGuid,
            [In] UInt32 dwFlags,
            [In, Out] IntPtr pReserved,
            [Out] out IntPtr ppAvailableNetworkList);
        #endregion

        //    #region 10 WlanGetFilterList NO INFO

        //    #endregion

        //    #region 11 WlanGetInterfaceCapability NO INFO

        //    #endregion

        //    #region 12 WlanGetNetworkBssList NO INFO

        //    #endregion

        //    #region 13 WlanGetProfile
        //    [DllImport("wlanapi.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        //    private static extern uint WlanGetProfileList(
        //        [In] IntPtr clientHandle,
        //        [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid,
        //        [In] IntPtr pReserved,
        //        [Out] out IntPtr profileList
        //    );

        //    #endregion

        //    #region 14 WlanGetProfileCustomUserData NO INFO

        //    #endregion

        //    #region 15 WlanGetProfileList
        //    [DllImport("Wlanapi.dll", SetLastError = true)]
        //    public static extern uint WlanGetProfileList(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        IntPtr pReserved, 
        //        ref IntPtr ppProfileList);
        //    #endregion

        //    #region 16 WlanGetSecuritySettings NO INFO
        //    #endregion

        //    #region 17 WlanHostedNetworkForceStart
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkForceStart")]
        //    public static extern uint WlanHostedNetworkForceStart(
        //        IntPtr hClientHandle,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 18 WlanHostedNetworkForceStop
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkForceStop")]
        //    public static extern uint WlanHostedNetworkForceStop(
        //        IntPtr hClientHandle,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 19 WlanHostedNetworkInitSettings
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkInitSettings")]
        //    public static extern uint WlanHostedNetworkInitSettings(
        //        IntPtr hClientHandle,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 20 WlanHostedNetworkQueryProperty NO INFO
        //    #endregion

        //    #region 21 WlanHostedNetworkQuerySecondaryKey
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkQuerySecondaryKey")]
        //    public static extern uint WlanHostedNetworkQuerySecondaryKey(
        //        IntPtr hClientHandle,
        //        [Out] out uint pKeyLength,
        //        [Out, MarshalAs(UnmanagedType.LPStr)] out string ppucKeyData,
        //        [Out] out bool pbIsPassPhrase,
        //        [Out] out bool pbPersistent,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 22 WlanHostedNetworkQueryStatus
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkQueryStatus")]
        //    public static extern uint WlanHostedNetworkQueryStatus(
        //        IntPtr hClientHandle,
        //        [Out] out WLAN_HOSTED_NETWORK_STATUS pWlanHostedNetworkStatus,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 23 WlanHostedNetworkRefreshSecuritySettings
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkRefreshSecuritySettings")]
        //    public static extern uint WlanHostedNetworkRefreshSecuritySettings(
        //        IntPtr hClientHandle,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 24 WlanHostedNetworkSetProperty
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkSetProperty")]
        //    public static extern uint WlanHostedNetworkSetProperty(
        //        IntPtr hClientHandle,
        //        WLAN_HOSTED_NETWORK_OPCODE OpCode,
        //        uint dwDataSize,
        //        IntPtr pvData,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 25 WlanHostedNetworkSetSecondaryKey NO INFO
        //    #endregion

        //    #region 26 WlanHostedNetworkStartUsing
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkStartUsing")]
        //    public static extern uint WlanHostedNetworkStartUsing(
        //        IntPtr hClientHandle,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 27 WlanHostedNetworkStopUsing
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanHostedNetworkStopUsing")]
        //    public static extern uint WlanHostedNetworkStopUsing(
        //        IntPtr hClientHandle,
        //        [Out] out WLAN_HOSTED_NETWORK_REASON pFailReason,
        //        IntPtr pReserved);
        //    #endregion

        //    #region 28 WlanIhvControl NO INFO
        //    #endregion

        #region 29 WlanOpenHandle
        [DllImport("wlanapi.dll")]
        public static extern UInt32 WlanOpenHandle(
            [In] UInt32 dwClientVersion,
            [In, Out] IntPtr pReserved,
            [Out] out UInt32 pdwNegotiatedVersion,
            [Out] out IntPtr phClientHandle
            );
        #endregion

        //    #region 30 WlanQueryAutoConfigParameter NO INFO
        //    #endregion

        #region 31 WlanQueryInterface
        /// <summary>
        /// Функция запрашивает различные параметры указанного интерфейса
        /// </summary>
        /// <param name="hClientHandle">Handle сеанса клиента</param>
        /// <param name="pInterfaceGuid">GUID интерфейса для запроса</param>
        /// <param name="OpCode">Значение задающее параметр, подлежащий запросу</param>
        /// <param name="pReserved"></param>
        /// <param name="pdwDataSize">Размер параметра ppData в байтах</param>
        /// <param name="ppData">Указатель на ячейку памяти, содержащую запрошенное значение параметра, заданного параметром OpCode</param>
        /// <param name="pWlanOpcodeValueType">Значение WLAN_OPCODE_VALUE_TYPE, которое указывает тип возвращаемого кода операции</param>
        /// <returns></returns>
        [DllImport("Wlanapi", EntryPoint = "WlanQueryInterface")]
        public static extern UInt32 WlanQueryInterface(
            [In] IntPtr hClientHandle,
            [In] ref Guid pInterfaceGuid,
            [In] IntfOpcode OpCode,
            [In] [Out] IntPtr pReserved,
            [Out] out UInt32 pdwDataSize,
            [Out] out IntPtr ppData,
            [Out] out OpcodeValueType pWlanOpcodeValueType
            );
        #endregion

        //    #region 32 WlanReasonCodeToString
        //    [DllImport("Wlanapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        //    public static extern uint WlanReasonCodeToString(
        //        uint dwReasonCode, 
        //        uint dwBufferSize, 
        //        string pStringBuffer, 
        //        IntPtr pReserved);
        //    #endregion

        //    #region 33 WlanRegisterNotification !!!
        //    public delegate void WLAN_NOTIFICATION_CALLBACK(ref WLAN_NOTIFICATION_DATA notificationData, IntPtr context);

        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanRegisterNotification")]
        //    public static extern uint WlanRegisterNotification(
        //         IntPtr hClientHandle, WLAN_NOTIFICATION_SOURCE dwNotifSource,
        //         bool bIgnoreDuplicate, WLAN_NOTIFICATION_CALLBACK funcCallback,
        //         IntPtr pCallbackContext, IntPtr pReserved,
        //         [Out] out WLAN_NOTIFICATION_SOURCE pdwPrevNotifSource);
        //    #endregion

        //    #region 34 WlanRegisterVirtualStationNotification
        //    [DllImport("Wlanapi.dll", EntryPoint = "WlanRegisterVirtualStationNotification")]
        //    public static extern uint WlanRegisterVirtualStationNotification(
        //        IntPtr hClientHandle,
        //        bool bRegister,
        //        IntPtr pvReserved);
        //    #endregion

        //    #region 35 WlanRenameProfile NO INFO

        //    #endregion

        //    #region 36 WlanSaveTemporaryProfile NO INFO
        //    #endregion

        //    #region 37 WlanScan
        //    [DllImport("Wlanapi.dll", SetLastError = true)]
        //    public static extern uint WlanScan(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        IntPtr pDot11Ssid, 
        //        IntPtr pIeData, 
        //        IntPtr pReserved);
        //    #endregion

        //    #region 38 WlanSetAutoConfigParameter NO INFO
        //    #endregion

        //    #region 39 WlanSetFilterList NO INFO
        //    #endregion

        //    #region 40 WlanSetInterface
        //    [DllImport("Wlanapi.dll")]
        //    public static extern uint WlanSetInterface(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        WLAN_INTF_OPCODE OpCode, 
        //        uint dwDataSize, 
        //        ref object obj, 
        //        IntPtr pReserved);
        //    #endregion

        //    #region 41 WlanSetProfile
        //    [DllImport("Wlanapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        //    public static extern uint WlanSetProfilePosition(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        string strProfileName, 
        //        uint dwPosition, 
        //        IntPtr pReserved);
        //    #endregion

        //    #region 42 WlanSetProfileCustomUserData NO INFO
        //    #endregion

        //    #region 43 WlanSetProfileEapUserData NO INFO
        //    #endregion

        //    #region 44 WlanSetProfileEapXmlUserData NO INFO
        //    #endregion

        //    #region 45 WlanSetProfileList
        //    [DllImport("Wlanapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        //    public static extern uint WlanSetProfileList(
        //        IntPtr hClientHandle, 
        //        ref Guid pInterfaceGuid, 
        //        uint dwItems, 
        //        string[] strProfileNames, 
        //        IntPtr pReserved);
        //    #endregion

        //    #region 46 WlanSetProfilePosition NO INFO
        //    #endregion

        //    #region 47 WlanSetPsdIEDataList NO INFO
        //    #endregion

        //    #region 48 WlanSetSecuritySettings NO INFO
        //    #endregion

    }
}
