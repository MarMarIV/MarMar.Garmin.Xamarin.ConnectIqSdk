using System;
using System.Collections.Generic;
using System.Text;

namespace MarMar.Garmin.Xamarin.ConnectIqSDK.Enums
{
    public enum IQSdkErrorStatus
    {
        GcmNotInstalled = 0,

        GcmUpgradeNeeded = 1,

        ServiceError = 2,


        Success = 500,
        Unknown = 1000
    }
}
