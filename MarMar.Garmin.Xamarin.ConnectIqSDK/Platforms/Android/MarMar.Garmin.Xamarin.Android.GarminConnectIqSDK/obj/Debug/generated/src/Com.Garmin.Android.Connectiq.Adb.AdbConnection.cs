using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq.Adb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/adb/AdbConnection", DoNotGenerateAcw=true)]
	public partial class AdbConnection : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/field[@name='DEFAULT_PORT']"
		[Register ("DEFAULT_PORT")]
		public const int DefaultPort = (int) 7381;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/interface[@name='AdbConnection.AdbConnectionListener']"
		[Register ("com/garmin/android/connectiq/adb/AdbConnection$AdbConnectionListener", "", "Com.Garmin.Android.Connectiq.Adb.AdbConnection/IAdbConnectionListenerInvoker")]
		public partial interface IAdbConnectionListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/interface[@name='AdbConnection.AdbConnectionListener']/method[@name='onConnectionStatusChanged' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice.IQDeviceStatus']]"
			[Register ("onConnectionStatusChanged", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V", "GetOnConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler:Com.Garmin.Android.Connectiq.Adb.AdbConnection/IAdbConnectionListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnConnectionStatusChanged (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1);

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/adb/AdbConnection$AdbConnectionListener", DoNotGenerateAcw=true)]
		internal partial class IAdbConnectionListenerInvoker : global::Java.Lang.Object, IAdbConnectionListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/adb/AdbConnection$AdbConnectionListener", typeof (IAdbConnectionListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IAdbConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAdbConnectionListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.adb.AdbConnection.AdbConnectionListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAdbConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
#pragma warning disable 0169
			static Delegate GetOnConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler ()
			{
				if (cb_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ == null)
					cb_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_);
				return cb_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
			}

			static void n_OnConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.IAdbConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.IAdbConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionStatusChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
			public unsafe void OnConnectionStatusChanged (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1)
			{
				if (id_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ == IntPtr.Zero)
					id_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ = JNIEnv.GetMethodID (class_ref, "onConnectionStatusChanged", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_, __args);
			}

		}

		// event args for com.garmin.android.connectiq.adb.AdbConnection.AdbConnectionListener.onConnectionStatusChanged
		public partial class AdbConnectionEventArgs : global::System.EventArgs {

			public AdbConnectionEventArgs (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Garmin.Android.Connectiq.IQDevice p0;
			public global::Com.Garmin.Android.Connectiq.IQDevice P0 {
				get { return p0; }
			}

			global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1;
			public global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/adb/AdbConnection_AdbConnectionListenerImplementor")]
		internal sealed partial class IAdbConnectionListenerImplementor : global::Java.Lang.Object, IAdbConnectionListener {

			object sender;

			public IAdbConnectionListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/adb/AdbConnection_AdbConnectionListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AdbConnectionEventArgs> Handler;
#pragma warning restore 0649

			public void OnConnectionStatusChanged (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AdbConnectionEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IAdbConnectionListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection.ServerThread']"
		[global::Android.Runtime.Register ("com/garmin/android/connectiq/adb/AdbConnection$ServerThread", DoNotGenerateAcw=true)]
		public partial class ServerThread : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/adb/AdbConnection$ServerThread", typeof (ServerThread));
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

			protected ServerThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.ServerThread __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.ServerThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection.ServerThread']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/adb/AdbConnection", typeof (AdbConnection));
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

		protected AdbConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Garmin.Android.Connectiq.Adb.AdbConnection Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/garmin/android/connectiq/adb/AdbConnection;", "")]
			get {
				const string __id = "getInstance.()Lcom/garmin/android/connectiq/adb/AdbConnection;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler")]
			get {
				const string __id = "isActive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		static Delegate cb_setPort_I;
#pragma warning disable 0169
		static Delegate GetSetPort_IHandler ()
		{
			if (cb_setPort_I == null)
				cb_setPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPort_I);
			return cb_setPort_I;
		}

		static void n_SetPort_I (IntPtr jnienv, IntPtr native__this, int port)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Port = port;
		}
#pragma warning restore 0169

		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				const string __id = "getPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='setPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPort", "(I)V", "GetSetPort_IHandler")]
			set {
				const string __id = "setPort.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_establishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_;
#pragma warning disable 0169
		static Delegate GetEstablishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_Handler ()
		{
			if (cb_establishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_ == null)
				cb_establishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EstablishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_);
			return cb_establishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_;
		}

		static void n_EstablishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.IAdbConnectionListener listener = (global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.IAdbConnectionListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.IAdbConnectionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.EstablishConnection (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='establishConnection' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.adb.AdbConnection.AdbConnectionListener']]"
		[Register ("establishConnection", "(Lcom/garmin/android/connectiq/adb/AdbConnection$AdbConnectionListener;)V", "GetEstablishConnection_Lcom_garmin_android_connectiq_adb_AdbConnection_AdbConnectionListener_Handler")]
		public virtual unsafe void EstablishConnection (global::Com.Garmin.Android.Connectiq.Adb.AdbConnection.IAdbConnectionListener listener)
		{
			const string __id = "establishConnection.(Lcom/garmin/android/connectiq/adb/AdbConnection$AdbConnectionListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendMessage_arrayB;
#pragma warning disable 0169
		static Delegate GetSendMessage_arrayBHandler ()
		{
			if (cb_sendMessage_arrayB == null)
				cb_sendMessage_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendMessage_arrayB);
			return cb_sendMessage_arrayB;
		}

		static bool n_SendMessage_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SendMessage (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("sendMessage", "([B)Z", "GetSendMessage_arrayBHandler")]
		public virtual unsafe bool SendMessage (byte[] data)
		{
			const string __id = "sendMessage.([B)Z";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Garmin.Android.Connectiq.Adb.AdbConnection __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.Adb.AdbConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbConnection']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetContext (global::Android.Content.Context context)
		{
			const string __id = "setContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
