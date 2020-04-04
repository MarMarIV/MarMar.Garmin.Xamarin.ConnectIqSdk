using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Garmin.Android.Connectiq;
using MarMar.Garmin.Xamarin.ConnectIqSDK.Interfaces;
using MarMar.Garmin.Xamarin.ConnectIqSDK.Enums;
using Xamarin.Forms;
using System.Threading.Tasks;

[assembly: Dependency(typeof(MarMar.Garmin.Xamarin.Android.ConnectIqSDK.ConnectIQService))]
namespace MarMar.Garmin.Xamarin.Android.ConnectIqSDK
{
    public class ConnectIQService : IConnectIQService
    {
        private class ConnectIqListener : Java.Lang.Object, ConnectIQ.IConnectIQListener
        {
            public Action<IQSdkErrorStatus> OnInitializeErrorCallback { private get; set; }

            public Action OnSdkReadyCallback { private get; set; }

            public Action OnSdkShutDownCallback { private get; set; }

            public void OnInitializeError(ConnectIQ.IQSdkErrorStatus p0)
            {
                IQSdkErrorStatus status =
                    IQSdkErrorStatus.Unknown;
                if (p0 == ConnectIQ.IQSdkErrorStatus.GcmNotInstalled)
                    status = IQSdkErrorStatus.GcmNotInstalled;
                if (p0 == ConnectIQ.IQSdkErrorStatus.GcmUpgradeNeeded)
                    status = IQSdkErrorStatus.GcmUpgradeNeeded;
                if (p0 == ConnectIQ.IQSdkErrorStatus.ServiceError)
                    status = IQSdkErrorStatus.ServiceError;

                OnInitializeErrorCallback?.Invoke(status);
            }

            public void OnSdkReady()
            {
                OnSdkReadyCallback?.Invoke();
            }

            public void OnSdkShutDown()
            {
                OnSdkShutDownCallback?.Invoke();
            }
        }

        private class ApplicationInfoListener : Java.Lang.Object, ConnectIQ.IQApplicationInfoListener
        {
            public Action<IIQApp> ApplicationInfoReceivedCallback { private get; set; }

            public Action<Exception> ApplicationNotInstalledCallback { private get; set; }

            public void OnApplicationInfoReceived(IQApp p0)
            {
                ApplicationInfoReceivedCallback?.Invoke(Converters.ConvertIQApp(p0));
            }

            public void OnApplicationNotInstalled(string p0)
            {
                ApplicationNotInstalledCallback?.Invoke(new Exception(p0));
            }
        }

        private class SendMessageListener : Java.Lang.Object, ConnectIQ.IQSendMessageListener
        {
            public Action<IIQDevice, IIQApp, IQMessageStatus> MessageStatusCallback { private get; set; }

            public void OnMessageStatus(IQDevice p0, IQApp p1, ConnectIQ.IQMessageStatus p2)
            {
                MessageStatusCallback?.Invoke(
                    Converters.ConvertIQDevice(p0),
                    Converters.ConvertIQApp(p1),
                    Converters.ConvertIQMessageStatus(p2)
                );
            }
        }

        private static class Converters
        {
            public static IIQDevice ConvertIQDevice(IQDevice device)
            {
                return new MarMar.Garmin.Xamarin.ConnectIqSDK.Models.IQDevice()
                {
                    DeviceIdentifier = device.DeviceIdentifier,
                    FriendlyName = device.FriendlyName,
                    Status = ConvertIQDeviceStatus(device.Status)
                };
            }

            public static IIQApp ConvertIQApp(IQApp app)
            {
                return new MarMar.Garmin.Xamarin.ConnectIqSDK.Models.IQApp()
                {
                    ApplicationId = app.ApplicationId,
                    DisplayName = app.DisplayName,
                    Status = ConvertIQAppStatus(app.Status)
                };
            }

            public static IQDeviceStatus ConvertIQDeviceStatus(IQDevice.IQDeviceStatus status)
            {
                IQDeviceStatus result = IQDeviceStatus.Unknown;

                if (status == IQDevice.IQDeviceStatus.Connected)
                    result = IQDeviceStatus.Connected;
                if (status == IQDevice.IQDeviceStatus.NotConnected)
                    result = IQDeviceStatus.NotConnected;
                if (status == IQDevice.IQDeviceStatus.NotPaired)
                    result = IQDeviceStatus.NotPaired;

                return result;
            }

            public static IQAppStatus ConvertIQAppStatus(IQApp.IQAppStatus status)
            {
                IQAppStatus result = IQAppStatus.Unknown;
                if (status == IQApp.IQAppStatus.Installed)
                    result = IQAppStatus.Installed;
                if (status == IQApp.IQAppStatus.NotInstalled)
                    result = IQAppStatus.NotInstalled;
                if (status == IQApp.IQAppStatus.NotSupported)
                    result = IQAppStatus.NotSupported;

                return result;
            }

            public static IQMessageStatus ConvertIQMessageStatus(ConnectIQ.IQMessageStatus status)
            {
                IQMessageStatus result = IQMessageStatus.FailureUnknown;

                if (status == ConnectIQ.IQMessageStatus.FailureDeviceNotConnected)
                    result = IQMessageStatus.FailureDeviceNotConnected;
                if (status == ConnectIQ.IQMessageStatus.FailureDuringTransfer)
                    result = IQMessageStatus.FailureDuringTransfer;
                if (status == ConnectIQ.IQMessageStatus.FailureInvalidDevice)
                    result = IQMessageStatus.FailureInvalidDevice;
                if (status == ConnectIQ.IQMessageStatus.FailureInvalidFormat)
                    result = IQMessageStatus.FailureInvalidFormat;
                if (status == ConnectIQ.IQMessageStatus.FailureMessageTooLarge)
                    result = IQMessageStatus.FailureMessageTooLarge;
                if (status == ConnectIQ.IQMessageStatus.FailureUnknown)
                    result = IQMessageStatus.FailureUnknown;
                if (status == ConnectIQ.IQMessageStatus.FailureUnsupportedType)
                    result = IQMessageStatus.FailureUnsupportedType;
                if (status == ConnectIQ.IQMessageStatus.Success)
                    result = IQMessageStatus.Success;

                return result;
            }
        }




        private static Context _context;
        private ConnectIQ _instance;
        private bool _initialized = false;

        public static void Init(Context context)
        {
            _context = context;
        }

        public async Task<IQSdkErrorStatus> Init(bool useSimulator = false)
        {
            if (_initialized)
            {
                return IQSdkErrorStatus.Success;
            }

            TaskCompletionSource<IQSdkErrorStatus> taskCompletionSource = new TaskCompletionSource<IQSdkErrorStatus>();

            var connectionType = useSimulator ? ConnectIQ.IQConnectType.Tethered : ConnectIQ.IQConnectType.Wireless;

            _instance = null;
            _instance = ConnectIQ.GetInstance(_context, connectionType);
            _instance.Initialize(_context, true, new ConnectIqListener()
            {
                OnInitializeErrorCallback = (_) => taskCompletionSource.SetResult(_),
                OnSdkReadyCallback = () => taskCompletionSource.SetResult(IQSdkErrorStatus.Success),
                OnSdkShutDownCallback = () => { }
            });

            var initResult = await taskCompletionSource.Task;
            if (initResult == IQSdkErrorStatus.Success)
            {
                _initialized = true;
            }

            return initResult;
        }

        public Task<IEnumerable<IIQDevice>> GetKnownDevices()
        {
            var results = _instance.KnownDevices.Select(_ => Converters.ConvertIQDevice(_));

            return Task.FromResult(results);
        }

        public Task<IEnumerable<IIQDevice>> GetConnectedDevices()
        {
            var results = _instance.ConnectedDevices.Select(_ => Converters.ConvertIQDevice(_));

            return Task.FromResult(results);
        }

        public Task<IIQApp> GetApplicationInfo(string appId, IIQDevice device)
        {
            TaskCompletionSource<IIQApp> taskCompletionSource = new TaskCompletionSource<IIQApp>();

            _instance.GetApplicationInfo(
                appId,
                new IQDevice(device.DeviceIdentifier, device.FriendlyName),
                new ApplicationInfoListener()
                {
                    ApplicationInfoReceivedCallback = (_) => taskCompletionSource.SetResult(_),
                    ApplicationNotInstalledCallback = (_) => taskCompletionSource.SetException(_)
                });

            return taskCompletionSource.Task;
        }

        public Task<IQMessageStatus> SendMessage(IIQApp app, IIQDevice device, object data)
        {
            TaskCompletionSource<IQMessageStatus> taskCompletionSource = new TaskCompletionSource<IQMessageStatus>();

            _instance.SendMessage(
                new IQDevice(device.DeviceIdentifier, device.FriendlyName),
                new IQApp(app.ApplicationId),
                ConvertData(data),
                new SendMessageListener()
                {
                    MessageStatusCallback = (cbApp, cbDevice, status) =>
                    {
                        taskCompletionSource.SetResult(status);
                    }
                });

            return taskCompletionSource.Task;
        }

        private Java.Lang.Object ConvertData(object data)
        {
            if (data != null)
            {
                if (data is string s)
                    return new Java.Lang.String(s);
            }

            return null;
        }
    }
}