using System;

namespace Win32.Wifi.Interop
{
    public enum WLAN_CONNECTION_MODE
    {
        wlan_connection_mode_profile,
        wlan_connection_mode_temporary_profile,
        wlan_connection_mode_discovery_secure,
        wlan_connection_mode_discovery_unsecure,
        wlan_connection_mode_auto,
        wlan_connection_mode_invalid,
    }

    public enum DOT11_BSS_TYPE
    {
        dot11_BSS_type_infrastructure = 1,
        dot11_BSS_type_independent = 2,
        dot11_BSS_type_any = 3,
    }

    public enum WLAN_HOSTED_NETWORK_REASON
    {
        wlan_hosted_network_reason_success = 0,
        wlan_hosted_network_reason_unspecified,
        wlan_hosted_network_reason_bad_parameters,
        wlan_hosted_network_reason_service_shutting_down,
        wlan_hosted_network_reason_insufficient_resources,
        wlan_hosted_network_reason_elevation_required,
        wlan_hosted_network_reason_read_only,
        wlan_hosted_network_reason_persistence_failed,
        wlan_hosted_network_reason_crypt_error,
        wlan_hosted_network_reason_impersonation,
        wlan_hosted_network_reason_stop_before_start,
        wlan_hosted_network_reason_interface_available,
        wlan_hosted_network_reason_interface_unavailable,
        wlan_hosted_network_reason_miniport_stopped,
        wlan_hosted_network_reason_miniport_started,
        wlan_hosted_network_reason_incompatible_connection_started,
        wlan_hosted_network_reason_incompatible_connection_stopped,
        wlan_hosted_network_reason_user_action,
        wlan_hosted_network_reason_client_abort,
        wlan_hosted_network_reason_ap_start_failed,
        wlan_hosted_network_reason_peer_arrived,
        wlan_hosted_network_reason_peer_departed,
        wlan_hosted_network_reason_peer_timeout,
        wlan_hosted_network_reason_gp_denied,
        wlan_hosted_network_reason_service_unavailable,
        wlan_hosted_network_reason_device_change,
        wlan_hosted_network_reason_properties_change,
        wlan_hosted_network_reason_virtual_station_blocking_use,
        wlan_hosted_network_reason_service_available_on_virtual_station
    }

    //реализовать
    public enum WLAN_HOSTED_NETWORK_STATUS  
    {
    }

    //реализовать
    public enum WLAN_HOSTED_NETWORK_OPCODE
    {

    }

    public enum WLAN_INTF_OPCODE
    {

        /// wlan_intf_opcode_autoconf_start -> 0x000000000
        wlan_intf_opcode_autoconf_start = 0,

        wlan_intf_opcode_autoconf_enabled,

        wlan_intf_opcode_background_scan_enabled,

        wlan_intf_opcode_media_streaming_mode,

        wlan_intf_opcode_radio_state,

        wlan_intf_opcode_bss_type,

        wlan_intf_opcode_interface_state,

        wlan_intf_opcode_current_connection,

        wlan_intf_opcode_channel_number,

        wlan_intf_opcode_supported_infrastructure_auth_cipher_pairs,

        wlan_intf_opcode_supported_adhoc_auth_cipher_pairs,

        wlan_intf_opcode_supported_country_or_region_string_list,

        wlan_intf_opcode_current_operation_mode,

        wlan_intf_opcode_supported_safe_mode,

        wlan_intf_opcode_certified_safe_mode,

        /// wlan_intf_opcode_autoconf_end -> 0x0fffffff
        wlan_intf_opcode_autoconf_end = 268435455,

        /// wlan_intf_opcode_msm_start -> 0x10000100
        wlan_intf_opcode_msm_start = 268435712,

        wlan_intf_opcode_statistics,

        wlan_intf_opcode_rssi,

        /// wlan_intf_opcode_msm_end -> 0x1fffffff
        wlan_intf_opcode_msm_end = 536870911,

        /// wlan_intf_opcode_security_start -> 0x20010000
        wlan_intf_opcode_security_start = 536936448,

        /// wlan_intf_opcode_security_end -> 0x2fffffff
        wlan_intf_opcode_security_end = 805306367,

        /// wlan_intf_opcode_ihv_start -> 0x30000000
        wlan_intf_opcode_ihv_start = 805306368,

        /// wlan_intf_opcode_ihv_end -> 0x3fffffff
        wlan_intf_opcode_ihv_end = 1073741823,
    }

    //реализовать
    public enum WLAN_NOTIFICATION_SOURCE : uint
    {

    }

    public enum WlanNotificationCodeMsm
    {
        Associating = 1,
        Associated,
        Authenticating,
        Connected,
        RoamingStart,
        RoamingEnd,
        RadioStateChange,
        SignalQualityChange,
        Disassociating,
        Disconnected,
        PeerJoin,
        PeerLeave,
        AdapterRemoval,
        AdapterOperationModeChange
    }

    public enum WlanNotificationCodeAcm
    {
        AutoconfEnabled = 1,
        AutoconfDisabled,
        BackgroundScanEnabled,
        BackgroundScanDisabled,
        BssTypeChange,
        PowerSettingChange,
        ScanComplete,
        ScanFail,
        ConnectionStart,
        ConnectionComplete,
        ConnectionAttemptFail,
        FilterListChange,
        InterfaceArrival,
        InterfaceRemoval,
        ProfileChange,
        ProfileNameChange,
        ProfilesExhausted,
        NetworkNotAvailable,
        NetworkAvailable,
        Disconnecting,
        Disconnected,
        AdhocNetworkStateChange
    }


    /// <summary>
    /// 
    /// </summary>
    public enum WlanInterfaceState
    {
        NotReady,
        Connected,
        AdHocNetworkFormed,
        Disconnecting,
        Disconnected,
        Associating,
        Discovering,
        Authenticating
    }
}
