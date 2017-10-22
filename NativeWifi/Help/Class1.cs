using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win32.Wifi.Interop
{
    //public delegate void WlanNotificationCallbackDelegate(ref WlanNotificationData notificationData, IntPtr context);

    [Flags]
    public enum WlanNotificationSource
    {
        None = 0,
        All = 65535,
        ACM = 8,
        MSM = 16,
        Security = 32,
        IHV = 64
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WlanConnectionNotificationData
    {
        public WlanConnectionMode wlanConnectionMode;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string profileName;

        public Dot11Ssid dot11Ssid;

        public Dot11BssType dot11BssType;

        public bool securityEnabled;

        public WlanReasonCode wlanReasonCode;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        public string profileXml;
    }

    public enum WlanConnectionMode
    {
        Profile,
        TemporaryProfile,
        DiscoverySecure,
        DiscoveryUnsecure,
        Auto,
        Invalid
    }

    public enum WlanReasonCode
    {
        Success,
        UNKNOWN = 65537,
        RANGE_SIZE = 65536,
        BASE = 131072,
        AC_BASE = 131072,
        AC_CONNECT_BASE = 163840,
        AC_END = 196607,
        PROFILE_BASE = 524288,
        PROFILE_CONNECT_BASE = 557056,
        PROFILE_END = 589823,
        MSM_BASE = 196608,
        MSM_CONNECT_BASE = 229376,
        MSM_END = 262143,
        MSMSEC_BASE,
        MSMSEC_CONNECT_BASE = 294912,
        MSMSEC_END = 327679,
        NETWORK_NOT_COMPATIBLE = 131073,
        PROFILE_NOT_COMPATIBLE,
        NO_AUTO_CONNECTION = 163841,
        NOT_VISIBLE,
        GP_DENIED,
        USER_DENIED,
        BSS_TYPE_NOT_ALLOWED,
        IN_FAILED_LIST,
        IN_BLOCKED_LIST,
        SSID_LIST_TOO_LONG,
        CONNECT_CALL_FAIL,
        SCAN_CALL_FAIL,
        NETWORK_NOT_AVAILABLE,
        PROFILE_CHANGED_OR_DELETED,
        KEY_MISMATCH,
        USER_NOT_RESPOND,
        INVALID_PROFILE_SCHEMA = 524289,
        PROFILE_MISSING,
        INVALID_PROFILE_NAME,
        INVALID_PROFILE_TYPE,
        INVALID_PHY_TYPE,
        MSM_SECURITY_MISSING,
        IHV_SECURITY_NOT_SUPPORTED,
        IHV_OUI_MISMATCH,
        IHV_OUI_MISSING,
        IHV_SETTINGS_MISSING,
        CONFLICT_SECURITY,
        SECURITY_MISSING,
        INVALID_BSS_TYPE,
        INVALID_ADHOC_CONNECTION_MODE,
        NON_BROADCAST_SET_FOR_ADHOC,
        AUTO_SWITCH_SET_FOR_ADHOC,
        AUTO_SWITCH_SET_FOR_MANUAL_CONNECTION,
        IHV_SECURITY_ONEX_MISSING,
        PROFILE_SSID_INVALID,
        TOO_MANY_SSID,
        UNSUPPORTED_SECURITY_SET_BY_OS = 196609,
        UNSUPPORTED_SECURITY_SET,
        BSS_TYPE_UNMATCH,
        PHY_TYPE_UNMATCH,
        DATARATE_UNMATCH,
        USER_CANCELLED = 229377,
        ASSOCIATION_FAILURE,
        ASSOCIATION_TIMEOUT,
        PRE_SECURITY_FAILURE,
        START_SECURITY_FAILURE,
        SECURITY_FAILURE,
        SECURITY_TIMEOUT,
        ROAMING_FAILURE,
        ROAMING_SECURITY_FAILURE,
        ADHOC_SECURITY_FAILURE,
        DRIVER_DISCONNECTED,
        DRIVER_OPERATION_FAILURE,
        IHV_NOT_AVAILABLE,
        IHV_NOT_RESPONDING,
        DISCONNECT_TIMEOUT,
        INTERNAL_FAILURE,
        UI_REQUEST_TIMEOUT,
        TOO_MANY_SECURITY_ATTEMPTS,
        MSMSEC_MIN = 262144,
        MSMSEC_PROFILE_INVALID_KEY_INDEX,
        MSMSEC_PROFILE_PSK_PRESENT,
        MSMSEC_PROFILE_KEY_LENGTH,
        MSMSEC_PROFILE_PSK_LENGTH,
        MSMSEC_PROFILE_NO_AUTH_CIPHER_SPECIFIED,
        MSMSEC_PROFILE_TOO_MANY_AUTH_CIPHER_SPECIFIED,
        MSMSEC_PROFILE_DUPLICATE_AUTH_CIPHER,
        MSMSEC_PROFILE_RAWDATA_INVALID,
        MSMSEC_PROFILE_INVALID_AUTH_CIPHER,
        MSMSEC_PROFILE_ONEX_DISABLED,
        MSMSEC_PROFILE_ONEX_ENABLED,
        MSMSEC_PROFILE_INVALID_PMKCACHE_MODE,
        MSMSEC_PROFILE_INVALID_PMKCACHE_SIZE,
        MSMSEC_PROFILE_INVALID_PMKCACHE_TTL,
        MSMSEC_PROFILE_INVALID_PREAUTH_MODE,
        MSMSEC_PROFILE_INVALID_PREAUTH_THROTTLE,
        MSMSEC_PROFILE_PREAUTH_ONLY_ENABLED,
        MSMSEC_CAPABILITY_NETWORK,
        MSMSEC_CAPABILITY_NIC,
        MSMSEC_CAPABILITY_PROFILE,
        MSMSEC_CAPABILITY_DISCOVERY,
        MSMSEC_PROFILE_PASSPHRASE_CHAR,
        MSMSEC_PROFILE_KEYMATERIAL_CHAR,
        MSMSEC_PROFILE_WRONG_KEYTYPE,
        MSMSEC_MIXED_CELL,
        MSMSEC_PROFILE_AUTH_TIMERS_INVALID,
        MSMSEC_PROFILE_INVALID_GKEY_INTV,
        MSMSEC_TRANSITION_NETWORK,
        MSMSEC_PROFILE_KEY_UNMAPPED_CHAR,
        MSMSEC_CAPABILITY_PROFILE_AUTH,
        MSMSEC_CAPABILITY_PROFILE_CIPHER,
        MSMSEC_UI_REQUEST_FAILURE = 294913,
        MSMSEC_AUTH_START_TIMEOUT,
        MSMSEC_AUTH_SUCCESS_TIMEOUT,
        MSMSEC_KEY_START_TIMEOUT,
        MSMSEC_KEY_SUCCESS_TIMEOUT,
        MSMSEC_M3_MISSING_KEY_DATA,
        MSMSEC_M3_MISSING_IE,
        MSMSEC_M3_MISSING_GRP_KEY,
        MSMSEC_PR_IE_MATCHING,
        MSMSEC_SEC_IE_MATCHING,
        MSMSEC_NO_PAIRWISE_KEY,
        MSMSEC_G1_MISSING_KEY_DATA,
        MSMSEC_G1_MISSING_GRP_KEY,
        MSMSEC_PEER_INDICATED_INSECURE,
        MSMSEC_NO_AUTHENTICATOR,
        MSMSEC_NIC_FAILURE,
        MSMSEC_CANCELLED,
        MSMSEC_KEY_FORMAT,
        MSMSEC_DOWNGRADE_DETECTED,
        MSMSEC_PSK_MISMATCH_SUSPECTED,
        MSMSEC_FORCED_FAILURE,
        MSMSEC_SECURITY_UI_FAILURE,
        MSMSEC_MAX = 327679
    }

    public enum Dot11BssType
    {
        Infrastructure = 1,
        Independent,
        Any
    }

    public struct Dot11Ssid
    {
        public uint SSIDLength;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] SSID;
    }
}
