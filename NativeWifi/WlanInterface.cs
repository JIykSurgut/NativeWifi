using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Win32.Wifi.Interop;

namespace NativeWifi.Win32.Wifi.Interop
{
    class WlanInterface
    {
        //private object WlanQueryInterfaceHelper(WLAN_INTF_OPCODE opCode)
        //{
        //    WlanInterop.WlanQueryInterface(
        //            hClientHandle,
        //            ref interfaceInfo.interfaceGuid,
        //            opCode,
        //            IntPtr.Zero,
        //            out UInt32 pdwDataSize,
        //            out IntPtr ppData,
        //            out WLAN_OPCODE_VALUE_TYPE pWlanOpcodeValueType);

        //    switch (opCode)
        //    {
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_autoconf_enabled:                   
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_background_scan_enabled:
        //            {
        //                return Marshal.ReadInt32(ppData);
        //            }
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_media_streaming_mode: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_radio_state: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_bss_type:
        //            {
        //                return Marshal.ReadInt32(ppData); 
        //            }
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_interface_state: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_current_connection: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_channel_number: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_supported_infrastructure_auth_cipher_pairs: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_supported_adhoc_auth_cipher_pairs: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_supported_country_or_region_string_list: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_current_operation_mode: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_supported_safe_mode: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_certified_safe_mode: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_hosted_network_capable: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_management_frame_protection_capable: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_statistics: break;
        //        case WLAN_INTF_OPCODE.wlan_intf_opcode_rssi: break;

        //    }

        //    return null;
        //}

        public Boolean Autoconf {
            get
            {
                WlanInterop.WlanQueryInterface(
                    hClientHandle,
                    ref interfaceInfo.interfaceGuid,
                    WLAN_INTF_OPCODE.wlan_intf_opcode_autoconf_enabled,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out WLAN_OPCODE_VALUE_TYPE pWlanOpcodeValueType);

                return Marshal.ReadInt32(ppData) != 0;
            }
            set
            {

            }
        }
        //public bool BackgroundScan { get; set; }
        //public bool RadioState { get; set; }
        public DOT11_BSS_TYPE BssType
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    hClientHandle,
                    ref interfaceInfo.interfaceGuid,
                    WLAN_INTF_OPCODE.wlan_intf_opcode_bss_type,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out WLAN_OPCODE_VALUE_TYPE pWlanOpcodeValueType);

                return (DOT11_BSS_TYPE)Marshal.ReadInt32(ppData);
            }
            set { }
        }
        //public bool InterfaceState { get; set; }
        public WLAN_CONNECTION_ATTRIBUTES CurrentConnection
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    hClientHandle,
                    ref interfaceInfo.interfaceGuid,
                    WLAN_INTF_OPCODE.wlan_intf_opcode_current_connection,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out WLAN_OPCODE_VALUE_TYPE pWlanOpcodeValueType);

                return (WLAN_CONNECTION_ATTRIBUTES)Marshal.PtrToStructure(ppData, typeof(WLAN_CONNECTION_ATTRIBUTES));
            }
            set { }
        }
        public UInt32 ChannelNumber
        {
            get
            {
                WlanInterop.WlanQueryInterface(
                    hClientHandle,
                    ref interfaceInfo.interfaceGuid,
                    WLAN_INTF_OPCODE.wlan_intf_opcode_bss_type,
                    IntPtr.Zero,
                    out UInt32 pdwDataSize,
                    out IntPtr ppData,
                    out WLAN_OPCODE_VALUE_TYPE pWlanOpcodeValueType);

                return (UInt32)Marshal.ReadInt32(ppData);
            }
            set { }
        }
        //public bool SupportedInfrastructureAuthCipherPairs { get; set; }
        //public bool SupportedAdhocAuthCipherPairs { get; set; }
        //public bool SupportedCountryOrRegionStringList { get; set; }
        //public bool MediaStreamingMode { get; set; }
        //public bool Statistics { get; set; }
        //public bool Rssi { get; set; }
        //public bool CurrentOperationMode { get; set; }
        //public bool SupportedSafeMode { get; set; }
        //public bool CertifiedSafeMode { get; set; }

        private WlanInterfaceInfo interfaceInfo;
        private IntPtr hClientHandle; 

        WlanInterface(WlanInterfaceInfo interfaceInfo, IntPtr hClientHandle)
        {
            this.interfaceInfo = interfaceInfo;
            this.hClientHandle = hClientHandle;
        }

        public void Scan()
        {
            //запрашивает сканирование доступных сетей на указанном интерфейсе
            //Функция WlanScan запрашивает, чтобы собственный драйвер беспроводной локальной сети 802.11 просматривал доступные беспроводные сети.
            WlanInterop.WlanScan(
                handle, 
                ref interfaceInfo.interfaceGuid, 
                IntPtr.Zero, 
                IntPtr.Zero, 
                IntPtr.Zero
                );
        }

        public void GetInterfaceInfo(WLAN_INTF_OPCODE opCode)
        {
            UInt32 pdwDataSize;
            IntPtr ppData;
            WLAN_OPCODE_VALUE_TYPE pWlanOpcodeValueType;

            WlanInterop.WlanQueryInterface(
                hClientHandle,
                ref interfaceInfo.interfaceGuid,  
                opCode, 
                IntPtr.Zero, 
                out pdwDataSize,
                out ppData,
                out pWlanOpcodeValueType); 
        }

    }
}
