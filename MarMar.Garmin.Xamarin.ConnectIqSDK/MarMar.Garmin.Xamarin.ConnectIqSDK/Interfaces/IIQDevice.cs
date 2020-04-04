using MarMar.Garmin.Xamarin.ConnectIqSDK.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarMar.Garmin.Xamarin.ConnectIqSDK.Interfaces
{
    public interface IIQDevice
    {
        long DeviceIdentifier { get; }

        string FriendlyName { get; }

        IQDeviceStatus Status { get; }
    }
}
