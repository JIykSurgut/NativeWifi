using System;
using System.Runtime.InteropServices;
using Win32.Wifi.Interop;

namespace NativeWifi.Win32.Wifi.Interop
{
    public struct InfoParam<TKey>
    {
        public TKey value;
        public OpcodeValueType type;
    }
    public class WlanInterface
    { 
        public Guid guid;
        public Guid Guid { get { return guid;} }
        public string Description { get; private set; }
        private IntPtr handle;

        public WlanInterface(IntPtr handle, Guid guid, string description)
        {
            this.handle = handle;
            this.guid = guid;
            Description = description;
        }
       
        public InfoParam<Boolean> Autoconf
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.autoconf_enabled,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<Boolean>() { value = Marshal.ReadInt32(ppData)!=0, type = pWlanOpcodeValueType };              
            }
            set
            {

            }
        }
        public InfoParam<Boolean> BackgroundScan
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.background_scan_enabled,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<Boolean>() { value = Marshal.ReadInt32(ppData) != 0, type = pWlanOpcodeValueType };
            }
            
        }
        ////public bool RadioState { get; set; }
        public InfoParam<Dot11BSSType> BssType
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.bss_type,                    
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<Dot11BSSType>() { value = (Dot11BSSType)Marshal.ReadInt32(ppData), type = pWlanOpcodeValueType };
            }
            set { }
        }
        public InfoParam<InterfaceState> InterfaceState
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.interface_state,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<InterfaceState>() { value = (InterfaceState)Marshal.ReadInt32(ppData), type = pWlanOpcodeValueType };
            }

        }
        public InfoParam<WLAN_CONNECTION_ATTRIBUTES> CurrentConnection
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.current_connection,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,                   
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<WLAN_CONNECTION_ATTRIBUTES>()
                {
                    value = (WLAN_CONNECTION_ATTRIBUTES)Marshal.PtrToStructure(ppData, typeof(WLAN_CONNECTION_ATTRIBUTES)),
                    type = pWlanOpcodeValueType
                };
            }
            set { }
        }
        public InfoParam<UInt32> ChannelNumber
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.channel_number,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<UInt32>() { value = (UInt32)Marshal.ReadInt32(ppData), type = pWlanOpcodeValueType };
            }
            set { }
        }
        //public bool SupportedInfrastructureAuthCipherPairs { get; set; }
        //public bool SupportedAdhocAuthCipherPairs { get; set; }
        //public bool SupportedCountryOrRegionStringList { get; set; }
        public InfoParam<Boolean> MediaStreamingMode
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.media_streaming_mode,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<Boolean>() { value = Marshal.ReadInt32(ppData) != 0, type = pWlanOpcodeValueType };
            }
            
        }
        //public bool Statistics { get; set; }
        public InfoParam<Int32> Rssi
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.rssi,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<Int32>() { value = Marshal.ReadInt32(ppData), type = pWlanOpcodeValueType };
            }
           
        }
        public InfoParam<UInt32> CurrentOperationMode
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    handle,
                    ref guid,
                    IntfOpcode.current_operation_mode,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out OpcodeValueType pWlanOpcodeValueType);

                return new InfoParam<UInt32>() { value = (UInt32)Marshal.ReadInt32(ppData), type = pWlanOpcodeValueType };
            }

        }
        public InfoParam<Boolean> SupportedSafeMode
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                   handle,
                   ref guid,
                   IntfOpcode.supported_safe_mode,
                   IntPtr.Zero,
                   out UInt32 pdwDataSize,
                   out IntPtr ppData,
                   out OpcodeValueType pWlanOpcodeValueType);
                return new InfoParam<Boolean>() { value = Marshal.ReadInt32(ppData) != 0, type = pWlanOpcodeValueType };
            }
            
        }
        public InfoParam<Boolean> CertifiedSafeMode
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                   handle,
                   ref guid,
                   IntfOpcode.certified_safe_mode,
                   IntPtr.Zero,
                   out UInt32 pdwDataSize,
                   out IntPtr ppData,
                   out OpcodeValueType pWlanOpcodeValueType);
                return new InfoParam<Boolean>() { value = Marshal.ReadInt32(ppData) != 0, type = pWlanOpcodeValueType };
            }
            
        }

        public void GetNetwork()
        {
            WlanInterop.WlanGetAvailableNetworkList(handle, ref guid, 1, IntPtr.Zero, out IntPtr ppAvailableNetworkList);

            UInt32 dwNumberOfItems = (UInt32)Marshal.ReadInt32(ppAvailableNetworkList, 0);
            UInt32 dwIndex = (UInt32)Marshal.ReadInt32(ppAvailableNetworkList, sizeof(UInt32));
            ppAvailableNetworkList += 2 * sizeof(UInt32);


            AvailableNetwork[] wlanInterface = new AvailableNetwork[dwNumberOfItems];

            Int32 sizeOfStruct = Marshal.SizeOf(typeof(AvailableNetwork));
            for (int i = 0; i < dwNumberOfItems; i++)
            {
                wlanInterface[i] = (AvailableNetwork)Marshal.PtrToStructure(ppAvailableNetworkList + sizeOfStruct * i, typeof(AvailableNetwork));

            }


        }

        //public void Scan()
        //{
        //    //запрашивает сканирование доступных сетей на указанном интерфейсе
        //    //Функция WlanScan запрашивает, чтобы собственный драйвер беспроводной локальной сети 802.11 просматривал доступные беспроводные сети.
        //    WlanInterop.WlanScan(
        //        handle,
        //        ref guid,
        //        IntPtr.Zero,
        //        IntPtr.Zero,
        //        IntPtr.Zero
        //        );
        //}



    }
}
