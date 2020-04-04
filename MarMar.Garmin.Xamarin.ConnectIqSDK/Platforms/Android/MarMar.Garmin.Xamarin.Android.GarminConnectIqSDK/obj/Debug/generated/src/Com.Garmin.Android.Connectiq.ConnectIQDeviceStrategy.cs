using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQDeviceStrategy']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQDeviceStrategy", DoNotGenerateAcw=true)]
	public partial class ConnectIQDeviceStrategy : global::Com.Garmin.Android.Connectiq.ConnectIQ {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQDeviceStrategy", typeof (ConnectIQDeviceStrategy));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ConnectIQDeviceStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConnectedDevices;
#pragma warning disable 0169
		static Delegate GetGetConnectedDevicesHandler ()
		{
			if (cb_getConnectedDevices == null)
				cb_getConnectedDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedDevices);
			return cb_getConnectedDevices;
		}

		static IntPtr n_GetConnectedDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.ConnectedDevices);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> ConnectedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQDeviceStrategy']/method[@name='getConnectedDevices' and count(parameter)=0]"
			[Register ("getConnectedDevices", "()Ljava/util/List;", "GetGetConnectedDevicesHandler")]
			get {
				const string __id = "getConnectedDevices.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKnownDevices;
#pragma warning disable 0169
		static Delegate GetGetKnownDevicesHandler ()
		{
			if (cb_getKnownDevices == null)
				cb_getKnownDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKnownDevices);
			return cb_getKnownDevices;
		}

		static IntPtr n_GetKnownDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.KnownDevices);
		}
#pragma warning restore 0169

		public override unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> KnownDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQDeviceStrategy']/method[@name='getKnownDevices' and count(parameter)=0]"
			[Register ("getKnownDevices", "()Ljava/util/List;", "GetGetKnownDevicesHandler")]
			get {
				const string __id = "getKnownDevices.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_;
#pragma warning disable 0169
		static Delegate GetGetDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_Handler ()
		{
			if (cb_getDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_ == null)
				cb_getDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_);
			return cb_getDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_;
		}

		static IntPtr n_GetDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeviceStatus (device));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQDeviceStrategy']/method[@name='getDeviceStatus' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("getDeviceStatus", "(Lcom/garmin/android/connectiq/IQDevice;)Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;", "GetGetDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_Handler")]
		public override unsafe global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus GetDeviceStatus (global::Com.Garmin.Android.Connectiq.IQDevice device)
		{
			const string __id = "getDeviceStatus.(Lcom/garmin/android/connectiq/IQDevice;)Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_registerForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetRegisterForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_registerForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_registerForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_registerForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_RegisterForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_app)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp app = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_app, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForRemoteAppEvents (device, app);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQDeviceStrategy']/method[@name='registerForRemoteAppEvents' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("registerForRemoteAppEvents", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetRegisterForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		protected override unsafe void RegisterForRemoteAppEvents (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQApp app)
		{
			const string __id = "registerForRemoteAppEvents.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_;
#pragma warning disable 0169
		static Delegate GetSendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_Handler ()
		{
			if (cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_ == null)
				cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_);
			return cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_;
		}

		static void n_SendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_application, IntPtr native_imageData, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp application = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_application, JniHandleOwnership.DoNotTransfer);
			byte[] imageData = (byte[]) JNIEnv.GetArray (native_imageData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SendImageProtocol (device, application, imageData, listener);
			if (imageData != null)
				JNIEnv.CopyArray (imageData, native_imageData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQDeviceStrategy']/method[@name='sendImageProtocol' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQSendImageListener']]"
		[Register ("sendImageProtocol", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendImageListener;)V", "GetSendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_Handler")]
		protected override unsafe void SendImageProtocol (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQApp application, byte[] imageData, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener listener)
		{
			const string __id = "sendImageProtocol.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendImageListener;)V";
			IntPtr native_imageData = JNIEnv.NewArray (imageData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_imageData);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (imageData != null) {
					JNIEnv.CopyArray (native_imageData, imageData);
					JNIEnv.DeleteLocalRef (native_imageData);
				}
			}
		}

		static Delegate cb_sendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_;
#pragma warning disable 0169
		static Delegate GetSendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler ()
		{
			if (cb_sendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ == null)
				cb_sendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_);
			return cb_sendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_;
		}

		static void n_SendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_application, IntPtr native_data, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQDeviceStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp application = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_application, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageProtocol (device, application, data, listener);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQDeviceStrategy']/method[@name='sendMessageProtocol' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQSendMessageListener']]"
		[Register ("sendMessageProtocol", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V", "GetSendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler")]
		protected override unsafe void SendMessageProtocol (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQApp application, byte[] data, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener listener)
		{
			const string __id = "sendMessageProtocol.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue (native_data);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
