using System;

namespace Win32.Wifi.Interop
{
    public enum Dot11AuthAlgorithm : UInt32
    {
        _80211_Open = 1,
        _80211_SharedKey = 2,
        WPA = 3,
        WPA_PSK = 4,
        WPA_NONE = 5,
        RSNA = 6,
        RSNA_PSK = 7,
        IHV_START = 0x80000000,
        IHV_END = 0xffffffff
    }

    public enum Dot11BSSType : UInt32
    {
        infrastructure = 1,
        independent = 2,
        typeAny = 3
    }

    public enum Dot11CipherAlgorithm : UInt32
    {
        NONE = 0x00,
        WEP40 = 0x01,
        TKIP = 0x02,
        CCMP = 0x04,
        WEP104 = 0x05,
        WPA_USE_GROUP = 0x100,
        RSN_USE_GROUP = 0x100,
        WEP = 0x101,
        IHV_START = 0x80000000,
        IHV_END = 0xffffffff
    }

    public enum Dot11PHYType : UInt32
    {
        unknown = 0,
        any = 0,
        fhss = 1,
        dsss = 2,
        irbaseband = 3,
        ofdm = 4,
        hrdsss = 5,
        erp = 6,
        ht = 7,
        vht = 8,
        IHV_start = 0x80000000,
        IHV_end = 0xffffffff
    }

    public enum Dot11RadioState : UInt32
    {
        unknown,
        on,
        off
    }

    public enum OneXAuthIdentity : UInt32
    {
        None,
        Machine,
        User,
        ExplicitUser,
        Guest,
        Invalid
    }

    public enum OneXRestartReason : UInt32
    {
        PeerInitiated,
        MsmInitiated,
        OneXHeldStateTimeout,
        OneXAuthTimeout,
        OneXConfigurationChanged,
        OneXUserChanged,
        QuarantineStateChanged,
        AltCredsTrial,
        Invalid
    }

    public enum OneXAuth : UInt32
    {
        NotStarted,
        InProgress,
        NoAuthenticatorFound,
        Success,
        Failure,
        Invalid
    }

    public enum OneXEapMethodBackend : UInt32
    {
        SupportUnknown,
        Supported,
        Unsupported
    }

    public enum OneXNotificationType : UInt32
    {
        PublicNotificationBase = 0,
        ResultUpdate,
        AuthRestarted,
        EventInvalid,
        NumNotifications = EventInvalid
    }

    public enum ONEX_REASON_CODE : UInt32
    {
        ONEX_REASON_CODE_SUCCESS = 0,
        ONEX_REASON_START = 0x5000,
        ONEX_UNABLE_TO_IDENTIFY_USER,
        ONEX_IDENTITY_NOT_FOUND,
        ONEX_UI_DISABLED,
        ONEX_UI_FAILURE,
        ONEX_EAP_FAILURE_RECEIVED,
        ONEX_AUTHENTICATOR_NO_LONGER_PRESENT,
        ONEX_NO_RESPONSE_TO_IDENTITY,
        ONEX_PROFILE_VERSION_NOT_SUPPORTED,
        ONEX_PROFILE_INVALID_LENGTH,
        ONEX_PROFILE_DISALLOWED_EAP_TYPE,
        ONEX_PROFILE_INVALID_EAP_TYPE_OR_FLAG,
        ONEX_PROFILE_INVALID_ONEX_FLAGS,
        ONEX_PROFILE_INVALID_TIMER_VALUE,
        ONEX_PROFILE_INVALID_SUPPLICANT_MODE,
        ONEX_PROFILE_INVALID_AUTH_MODE,
        ONEX_PROFILE_INVALID_EAP_CONNECTION_PROPERTIES,
        ONEX_UI_CANCELLED,
        ONEX_PROFILE_INVALID_EXPLICIT_CREDENTIALS,
        ONEX_PROFILE_EXPIRED_EXPLICIT_CREDENTIALS,
        ONEX_UI_NOT_PERMITTED
    }

    //Wlan
    public enum AdHocNetworkState : UInt32
    {
        formed = 0,
        connected = 1
    }

    public enum AutoconfOpcode : UInt32
    {
        start = 0,
        show_denied_networks = 1,
        power_setting = 2,
        only_use_gp_profiles_for_allowed_networks = 3,
        allow_explicit_creds = 4,
        block_period = 5,
        allow_virtual_station_extensibility = 6,
        end = 7
    }

    public enum ConnectionMode : UInt32
    {
        Profile,
        TemporaryProfile,
        DiscoverySecure,
        DiscoveryUnsecure,
        Auto,
        Invalid
    }

    public enum FilterListType : UInt32
    {
        GpPermit,
        GpDeny,
        UserPermit,
        UserDeny
    }

    public enum HostedNetworkNotificationCode : UInt32
    {
        HostedNetworkStateChange = 0x00001000,
        HostedNetworkPeerStateChange,
        HostedNetworkRadioStateChange
    }

    public enum HostedNetworkOpcode : UInt32
    {
        ConnectionSettings,
        SecuritySettings,
        StationProfile,
        OpcodeEnable
    }

    public enum HostedNetworkPeerAuthState : UInt32
    {
        Invalid,
        Authenticated
    }

    public enum HostedNetworkReason : UInt32
    {
        success = 0,
        unspecified,
        bad_parameters,
        service_shutting_down,
        insufficient_resources,
        elevation_required,
        read_only,
        persistence_failed,
        crypt_error,
        impersonation,
        stop_before_start,
        interface_available,
        interface_unavailable,
        miniport_stopped,
        miniport_started,
        incompatible_connection_started,
        incompatible_connection_stopped,
        user_action,
        client_abort,
        ap_start_failed,
        peer_arrived,
        peer_departed,
        peer_timeout,
        gp_denied,
        service_unavailable,
        device_change,
        properties_change,
        virtual_station_blocking_use,
        service_available_on_virtual_station
    }

    public enum HostedNetworkState : UInt32
    {
        unavailable,
        idle,
        active
    }

    public enum IHVControlType : UInt32
    {
        service,
        driver
    }

    public enum InterfaceState : UInt32
    {
        not_ready = 0,
        connected = 1,
        ad_hoc_network_formed = 2,
        disconnecting = 3,
        disconnected = 4,
        associating = 5,
        discovering = 6,
        authenticating = 7
    }

    public enum InterfaceType : UInt32
    {
        emulated_802_11 = 0,
        native_802_11,
        invalid
    }

    public enum IntfOpcode : UInt32
    {
        autoconf_start = 0x000000000,
        autoconf_enabled,
        background_scan_enabled,
        media_streaming_mode,
        radio_state,
        bss_type,
        interface_state,
        current_connection,
        channel_number,
        supported_infrastructure_auth_cipher_pairs,
        supported_adhoc_auth_cipher_pairs,
        supported_country_or_region_string_list,
        current_operation_mode,
        supported_safe_mode,
        certified_safe_mode,
        hosted_network_capable,
        management_frame_protection_capable,
        autoconf_end = 0x0fffffff,
        msm_start = 0x10000100,
        statistics,
        rssi,
        msm_end = 0x1fffffff,
        security_start = 0x20010000,
        security_end = 0x2fffffff,
        ihv_start = 0x30000000,
        ihv_end = 0x3fffffff
    }

    public enum NotificationACM : UInt32
    {
        start = 0,
        autoconf_enabled,
        autoconf_disabled,
        background_scan_enabled,
        background_scan_disabled,
        bss_type_change,
        power_setting_change,
        scan_complete,
        scan_fail,
        connection_start,
        connection_complete,
        connection_attempt_fail,
        filter_list_change,
        interface_arrival,
        interface_removal,
        profile_change,
        profile_name_change,
        profiles_exhausted,
        network_not_available,
        network_available,
        disconnecting,
        disconnected,
        adhoc_network_state_change,
        profile_unblocked,
        screen_power_change,
        profile_blocked,
        scan_list_refresh,
        end
    }

    public enum NotificationMSM : UInt32
    {
        start = 0,
        associating,
        associated,
        authenticating,
        connected,
        roaming_start,
        roaming_end,
        radio_state_change,
        signal_quality_change,
        disassociating,
        disconnected,
        peer_join,
        peer_leave,
        adapter_removal,
        adapter_operation_mode_change,
        end
    }

    public enum OpcodeValueType : UInt32
    {
        query_only = 0,
        set_by_group_policy = 1,
        set_by_user = 2,
        invalid = 3
    }

    public enum PowerSetting : UInt32
    {
        no_saving,
        low_saving,
        medium_saving,
        maximum_saving,
        invalid
    }

    public enum SecurableObject : UInt32
    {
        permit_list = 0,
        deny_list = 1,
        ac_enabled = 2,
        bc_scan_enabled = 3,
        bss_type = 4,
        show_denied = 5,
        interface_properties = 6,
        ihv_control = 7,
        all_user_profiles_order = 8,
        add_new_all_user_profiles = 9,
        add_new_per_user_profiles = 10,
        media_streaming_mode_enabled = 11,
        current_operation_mode = 12,
        get_plaintext_key = 13,
        hosted_network_elevated_access = 14,
        virtual_station_extensibility = 15,
        wfd_elevated_access = 16
    }
}
