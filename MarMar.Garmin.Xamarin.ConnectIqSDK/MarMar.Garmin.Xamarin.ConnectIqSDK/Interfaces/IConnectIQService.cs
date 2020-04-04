using MarMar.Garmin.Xamarin.ConnectIqSDK.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarMar.Garmin.Xamarin.ConnectIqSDK.Interfaces
{
    public interface IConnectIQService
    {
        Task<IQSdkErrorStatus> Init(bool useSimulator = false);

        Task<IEnumerable<IIQDevice>> GetKnownDevices();

        Task<IEnumerable<IIQDevice>> GetConnectedDevices();

        Task<IIQApp> GetApplicationInfo(string appId, IIQDevice device);

        Task<IQMessageStatus> SendMessage(IIQApp app, IIQDevice device, object data);
    }
}
