using System;
using System.Collections.Generic;
using System.Text;

namespace MarMar.Garmin.Xamarin.ConnectIqSDK.Enums
{
    public enum IQMessageStatus
    {
        FailureDeviceNotConnected,
        FailureDuringTransfer,
        FailureInvalidDevice,
        FailureInvalidFormat,
        FailureMessageTooLarge,
        FailureUnknown,
        FailureUnsupportedType,
        Success
    }
}
