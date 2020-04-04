using MarMar.Garmin.Xamarin.ConnectIqSDK.Enums;
using MarMar.Garmin.Xamarin.ConnectIqSDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarMar.Garmin.Xamarin.ConnectIqSDK.Models
{
    public class IQDevice : IIQDevice
    {
        public long DeviceIdentifier { get; set; }

        public string FriendlyName { get; set; }

        public IQDeviceStatus Status { get; set; }
    }
}
