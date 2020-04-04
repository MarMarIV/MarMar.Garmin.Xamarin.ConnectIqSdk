using MarMar.Garmin.Xamarin.ConnectIqSDK.Enums;
using MarMar.Garmin.Xamarin.ConnectIqSDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarMar.Garmin.Xamarin.ConnectIqSDK.Models
{
    public class IQApp : IIQApp
    {
        public string ApplicationId { get; set; }

        public string DisplayName { get; set; }

        public IQAppStatus Status { get; set; }
    }
}
