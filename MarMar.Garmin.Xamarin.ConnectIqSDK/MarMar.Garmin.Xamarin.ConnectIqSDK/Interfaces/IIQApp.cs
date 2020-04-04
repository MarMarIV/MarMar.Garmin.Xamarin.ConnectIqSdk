using MarMar.Garmin.Xamarin.ConnectIqSDK.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarMar.Garmin.Xamarin.ConnectIqSDK.Interfaces
{
    public interface IIQApp
    {
        string ApplicationId { get; }

        string DisplayName { get; }

        IQAppStatus Status { get; }
    }
}
