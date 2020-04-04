using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ", DoNotGenerateAcw=true)]
	public abstract partial class ConnectIQ : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='APPLICATION_INFO']"
		[Register ("APPLICATION_INFO")]
		public const string ApplicationInfo = (string) "com.garmin.android.connectiq.APPLICATION_INFO";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='DEVICE_STATUS']"
		[Register ("DEVICE_STATUS")]
		public const string DeviceStatus = (string) "com.garmin.android.connectiq.DEVICE_STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_APPLICATION_ID']"
		[Register ("EXTRA_APPLICATION_ID")]
		public const string ExtraApplicationId = (string) "com.garmin.android.connectiq.EXTRA_APPLICATION_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_APPLICATION_VERSION']"
		[Register ("EXTRA_APPLICATION_VERSION")]
		public const string ExtraApplicationVersion = (string) "com.garmin.android.connectiq.EXTRA_APPLICATION_VERSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_OPEN_APPLICATION_DEVICE']"
		[Register ("EXTRA_OPEN_APPLICATION_DEVICE")]
		public const string ExtraOpenApplicationDevice = (string) "com.garmin.android.connectiq.EXTRA_OPEN_APPLICATION_DEVICE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_OPEN_APPLICATION_ID']"
		[Register ("EXTRA_OPEN_APPLICATION_ID")]
		public const string ExtraOpenApplicationId = (string) "com.garmin.android.connectiq.EXTRA_OPEN_APPLICATION_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_OPEN_APPLICATION_RESULT_CODE']"
		[Register ("EXTRA_OPEN_APPLICATION_RESULT_CODE")]
		public const string ExtraOpenApplicationResultCode = (string) "com.garmin.android.connectiq.EXTRA_OPEN_APPLICATION_RESULT_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_PAYLOAD']"
		[Register ("EXTRA_PAYLOAD")]
		public const string ExtraPayload = (string) "com.garmin.android.connectiq.EXTRA_PAYLOAD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_REMOTE_APPLICATION']"
		[Register ("EXTRA_REMOTE_APPLICATION")]
		public const string ExtraRemoteApplication = (string) "com.garmin.android.connectiq.EXTRA_REMOTE_APPLICATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_REMOTE_DEVICE']"
		[Register ("EXTRA_REMOTE_DEVICE")]
		public const string ExtraRemoteDevice = (string) "com.garmin.android.connectiq.EXTRA_REMOTE_DEVICE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='EXTRA_STATUS']"
		[Register ("EXTRA_STATUS")]
		public const string ExtraStatus = (string) "com.garmin.android.connectiq.EXTRA_STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='GCM_CONNECTIQ_SERVICE_ACTION']"
		[Register ("GCM_CONNECTIQ_SERVICE_ACTION")]
		protected const string GcmConnectiqServiceAction = (string) "com.garmin.android.apps.connectmobile.CONNECTIQ_SERVICE_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='GCM_CONNECTIQ_SERVICE_CLASS']"
		[Register ("GCM_CONNECTIQ_SERVICE_CLASS")]
		protected const string GcmConnectiqServiceClass = (string) "com.garmin.android.apps.connectmobile.connectiq.ConnectIQService";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='GCM_PACKAGE_NAME']"
		[Register ("GCM_PACKAGE_NAME")]
		protected const string GcmPackageName = (string) "com.garmin.android.apps.connectmobile";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='INCOMING_MESSAGE']"
		[Register ("INCOMING_MESSAGE")]
		public const string IncomingMessage = (string) "com.garmin.android.connectiq.INCOMING_MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='MIN_GCM_VERSION']"
		[Register ("MIN_GCM_VERSION")]
		protected const int MinGcmVersion = (int) 2000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='SEND_MESSAGE_STATUS']"
		[Register ("SEND_MESSAGE_STATUS")]
		public const string SendMessageStatus = (string) "com.garmin.android.connectiq.SEND_MESSAGE_STATUS";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='mInitialized']"
		[Register ("mInitialized")]
		protected bool MInitialized {
			get {
				const string __id = "mInitialized.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mInitialized.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='mListener']"
		[Register ("mListener")]
		protected global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener MListener {
			get {
				const string __id = "mListener.Lcom/garmin/android/connectiq/ConnectIQ$ConnectIQListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mListener.Lcom/garmin/android/connectiq/ConnectIQ$ConnectIQListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='sConnectType']"
		[Register ("sConnectType")]
		protected static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType SConnectType {
			get {
				const string __id = "sConnectType.Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sConnectType.Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/field[@name='sInstance']"
		[Register ("sInstance")]
		protected static global::Com.Garmin.Android.Connectiq.ConnectIQ SInstance {
			get {
				const string __id = "sInstance.Lcom/garmin/android/connectiq/ConnectIQ;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sInstance.Lcom/garmin/android/connectiq/ConnectIQ;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.ConnectIQListener']"
		[Register ("com/garmin/android/connectiq/ConnectIQ$ConnectIQListener", "", "Com.Garmin.Android.Connectiq.ConnectIQ/IConnectIQListenerInvoker")]
		public partial interface IConnectIQListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.ConnectIQListener']/method[@name='onInitializeError' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.ConnectIQ.IQSdkErrorStatus']]"
			[Register ("onInitializeError", "(Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;)V", "GetOnInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IConnectIQListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnInitializeError (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.ConnectIQListener']/method[@name='onSdkReady' and count(parameter)=0]"
			[Register ("onSdkReady", "()V", "GetOnSdkReadyHandler:Com.Garmin.Android.Connectiq.ConnectIQ/IConnectIQListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnSdkReady ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.ConnectIQListener']/method[@name='onSdkShutDown' and count(parameter)=0]"
			[Register ("onSdkShutDown", "()V", "GetOnSdkShutDownHandler:Com.Garmin.Android.Connectiq.ConnectIQ/IConnectIQListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnSdkShutDown ();

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$ConnectIQListener", DoNotGenerateAcw=true)]
		internal partial class IConnectIQListenerInvoker : global::Java.Lang.Object, IConnectIQListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$ConnectIQListener", typeof (IConnectIQListenerInvoker));

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

			public static IConnectIQListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConnectIQListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.ConnectIQ.ConnectIQListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConnectIQListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_;
#pragma warning disable 0169
			static Delegate GetOnInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_Handler ()
			{
				if (cb_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_ == null)
					cb_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_);
				return cb_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_;
			}

			static void n_OnInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInitializeError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_;
			public unsafe void OnInitializeError (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus p0)
			{
				if (id_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_ == IntPtr.Zero)
					id_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_ = JNIEnv.GetMethodID (class_ref, "onInitializeError", "(Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitializeError_Lcom_garmin_android_connectiq_ConnectIQ_IQSdkErrorStatus_, __args);
			}

			static Delegate cb_onSdkReady;
#pragma warning disable 0169
			static Delegate GetOnSdkReadyHandler ()
			{
				if (cb_onSdkReady == null)
					cb_onSdkReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSdkReady);
				return cb_onSdkReady;
			}

			static void n_OnSdkReady (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSdkReady ();
			}
#pragma warning restore 0169

			IntPtr id_onSdkReady;
			public unsafe void OnSdkReady ()
			{
				if (id_onSdkReady == IntPtr.Zero)
					id_onSdkReady = JNIEnv.GetMethodID (class_ref, "onSdkReady", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSdkReady);
			}

			static Delegate cb_onSdkShutDown;
#pragma warning disable 0169
			static Delegate GetOnSdkShutDownHandler ()
			{
				if (cb_onSdkShutDown == null)
					cb_onSdkShutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSdkShutDown);
				return cb_onSdkShutDown;
			}

			static void n_OnSdkShutDown (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSdkShutDown ();
			}
#pragma warning restore 0169

			IntPtr id_onSdkShutDown;
			public unsafe void OnSdkShutDown ()
			{
				if (id_onSdkShutDown == IntPtr.Zero)
					id_onSdkShutDown = JNIEnv.GetMethodID (class_ref, "onSdkShutDown", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSdkShutDown);
			}

		}

		// event args for com.garmin.android.connectiq.ConnectIQ.ConnectIQListener.onInitializeError
		public partial class InitializeErrorEventArgs : global::System.EventArgs {

			public InitializeErrorEventArgs (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus p0;
			public global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/ConnectIQ_ConnectIQListenerImplementor")]
		internal sealed partial class IConnectIQListenerImplementor : global::Java.Lang.Object, IConnectIQListener {

			object sender;

			public IConnectIQListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/ConnectIQ_ConnectIQListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InitializeErrorEventArgs> OnInitializeErrorHandler;
#pragma warning restore 0649

			public void OnInitializeError (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus p0)
			{
				var __h = OnInitializeErrorHandler;
				if (__h != null)
					__h (sender, new InitializeErrorEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnSdkReadyHandler;
#pragma warning restore 0649

			public void OnSdkReady ()
			{
				var __h = OnSdkReadyHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnSdkShutDownHandler;
#pragma warning restore 0649

			public void OnSdkShutDown ()
			{
				var __h = OnSdkShutDownHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IConnectIQListenerImplementor value)
			{
				return value.OnInitializeErrorHandler == null && value.OnSdkReadyHandler == null && value.OnSdkShutDownHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQApplicationEventListener']"
		[Register ("com/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener", "", "Com.Garmin.Android.Connectiq.ConnectIQ/IQApplicationEventListenerInvoker")]
		public partial interface IQApplicationEventListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQApplicationEventListener']/method[@name='onMessageReceived' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='java.util.List&lt;java.lang.Object&gt;'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQMessageStatus']]"
			[Register ("onMessageReceived", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Ljava/util/List;Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;)V", "GetOnMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IQApplicationEventListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnMessageReceived (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::System.Collections.Generic.IList<global::Java.Lang.Object> p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p3);

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener", DoNotGenerateAcw=true)]
		internal partial class IQApplicationEventListenerInvoker : global::Java.Lang.Object, IQApplicationEventListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener", typeof (IQApplicationEventListenerInvoker));

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

			public static IQApplicationEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQApplicationEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.ConnectIQ.IQApplicationEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQApplicationEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
#pragma warning disable 0169
			static Delegate GetOnMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_Handler ()
			{
				if (cb_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ == null)
					cb_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_);
				return cb_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
			}

			static void n_OnMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQApp p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p3 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageReceived (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
			public unsafe void OnMessageReceived (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::System.Collections.Generic.IList<global::Java.Lang.Object> p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p3)
			{
				if (id_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ == IntPtr.Zero)
					id_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ = JNIEnv.GetMethodID (class_ref, "onMessageReceived", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Ljava/util/List;Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;)V");
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageReceived_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_util_List_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		// event args for com.garmin.android.connectiq.ConnectIQ.IQApplicationEventListener.onMessageReceived
		public partial class QApplicationEventEventArgs : global::System.EventArgs {

			public QApplicationEventEventArgs (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::System.Collections.Generic.IList<global::Java.Lang.Object> p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Com.Garmin.Android.Connectiq.IQDevice p0;
			public global::Com.Garmin.Android.Connectiq.IQDevice P0 {
				get { return p0; }
			}

			global::Com.Garmin.Android.Connectiq.IQApp p1;
			public global::Com.Garmin.Android.Connectiq.IQApp P1 {
				get { return p1; }
			}

			global::System.Collections.Generic.IList<global::Java.Lang.Object> p2;
			public global::System.Collections.Generic.IList<global::Java.Lang.Object> P2 {
				get { return p2; }
			}

			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p3;
			public global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/ConnectIQ_IQApplicationEventListenerImplementor")]
		internal sealed partial class IQApplicationEventListenerImplementor : global::Java.Lang.Object, IQApplicationEventListener {

			object sender;

			public IQApplicationEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/ConnectIQ_IQApplicationEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<QApplicationEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnMessageReceived (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::System.Collections.Generic.IList<global::Java.Lang.Object> p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new QApplicationEventEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IQApplicationEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQApplicationInfoListener']"
		[Register ("com/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener", "", "Com.Garmin.Android.Connectiq.ConnectIQ/IQApplicationInfoListenerInvoker")]
		public partial interface IQApplicationInfoListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQApplicationInfoListener']/method[@name='onApplicationInfoReceived' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQApp']]"
			[Register ("onApplicationInfoReceived", "(Lcom/garmin/android/connectiq/IQApp;)V", "GetOnApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IQApplicationInfoListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnApplicationInfoReceived (global::Com.Garmin.Android.Connectiq.IQApp p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQApplicationInfoListener']/method[@name='onApplicationNotInstalled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onApplicationNotInstalled", "(Ljava/lang/String;)V", "GetOnApplicationNotInstalled_Ljava_lang_String_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IQApplicationInfoListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnApplicationNotInstalled (string p0);

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener", DoNotGenerateAcw=true)]
		internal partial class IQApplicationInfoListenerInvoker : global::Java.Lang.Object, IQApplicationInfoListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener", typeof (IQApplicationInfoListenerInvoker));

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

			public static IQApplicationInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQApplicationInfoListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.ConnectIQ.IQApplicationInfoListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQApplicationInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
			static Delegate GetOnApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_Handler ()
			{
				if (cb_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_ == null)
					cb_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_);
				return cb_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_;
			}

			static void n_OnApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQApp p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnApplicationInfoReceived (p0);
			}
#pragma warning restore 0169

			IntPtr id_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_;
			public unsafe void OnApplicationInfoReceived (global::Com.Garmin.Android.Connectiq.IQApp p0)
			{
				if (id_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_ == IntPtr.Zero)
					id_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_ = JNIEnv.GetMethodID (class_ref, "onApplicationInfoReceived", "(Lcom/garmin/android/connectiq/IQApp;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationInfoReceived_Lcom_garmin_android_connectiq_IQApp_, __args);
			}

			static Delegate cb_onApplicationNotInstalled_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnApplicationNotInstalled_Ljava_lang_String_Handler ()
			{
				if (cb_onApplicationNotInstalled_Ljava_lang_String_ == null)
					cb_onApplicationNotInstalled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnApplicationNotInstalled_Ljava_lang_String_);
				return cb_onApplicationNotInstalled_Ljava_lang_String_;
			}

			static void n_OnApplicationNotInstalled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnApplicationNotInstalled (p0);
			}
#pragma warning restore 0169

			IntPtr id_onApplicationNotInstalled_Ljava_lang_String_;
			public unsafe void OnApplicationNotInstalled (string p0)
			{
				if (id_onApplicationNotInstalled_Ljava_lang_String_ == IntPtr.Zero)
					id_onApplicationNotInstalled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onApplicationNotInstalled", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationNotInstalled_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.garmin.android.connectiq.ConnectIQ.IQApplicationInfoListener.onApplicationInfoReceived
		public partial class ApplicationInfoReceivedEventArgs : global::System.EventArgs {

			public ApplicationInfoReceivedEventArgs (global::Com.Garmin.Android.Connectiq.IQApp p0)
			{
				this.p0 = p0;
			}

			global::Com.Garmin.Android.Connectiq.IQApp p0;
			public global::Com.Garmin.Android.Connectiq.IQApp P0 {
				get { return p0; }
			}
		}

		// event args for com.garmin.android.connectiq.ConnectIQ.IQApplicationInfoListener.onApplicationNotInstalled
		public partial class ApplicationNotInstalledEventArgs : global::System.EventArgs {

			public ApplicationNotInstalledEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/ConnectIQ_IQApplicationInfoListenerImplementor")]
		internal sealed partial class IQApplicationInfoListenerImplementor : global::Java.Lang.Object, IQApplicationInfoListener {

			object sender;

			public IQApplicationInfoListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/ConnectIQ_IQApplicationInfoListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ApplicationInfoReceivedEventArgs> OnApplicationInfoReceivedHandler;
#pragma warning restore 0649

			public void OnApplicationInfoReceived (global::Com.Garmin.Android.Connectiq.IQApp p0)
			{
				var __h = OnApplicationInfoReceivedHandler;
				if (__h != null)
					__h (sender, new ApplicationInfoReceivedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ApplicationNotInstalledEventArgs> OnApplicationNotInstalledHandler;
#pragma warning restore 0649

			public void OnApplicationNotInstalled (string p0)
			{
				var __h = OnApplicationNotInstalledHandler;
				if (__h != null)
					__h (sender, new ApplicationNotInstalledEventArgs (p0));
			}

			internal static bool __IsEmpty (IQApplicationInfoListenerImplementor value)
			{
				return value.OnApplicationInfoReceivedHandler == null && value.OnApplicationNotInstalledHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQConnectType']"
		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQConnectType", DoNotGenerateAcw=true)]
		public sealed partial class IQConnectType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQConnectType']/field[@name='TETHERED']"
			[Register ("TETHERED")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType Tethered {
				get {
					const string __id = "TETHERED.Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQConnectType']/field[@name='WIRELESS']"
			[Register ("WIRELESS")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType Wireless {
				get {
					const string __id = "WIRELESS.Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQConnectType", typeof (IQConnectType));
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

			internal IQConnectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQConnectType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQConnectType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType[] Values ()
			{
				const string __id = "values.()[Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQDeviceEventListener']"
		[Register ("com/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener", "", "Com.Garmin.Android.Connectiq.ConnectIQ/IQDeviceEventListenerInvoker")]
		public partial interface IQDeviceEventListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQDeviceEventListener']/method[@name='onDeviceStatusChanged' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice.IQDeviceStatus']]"
			[Register ("onDeviceStatusChanged", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V", "GetOnDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IQDeviceEventListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnDeviceStatusChanged (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1);

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener", DoNotGenerateAcw=true)]
		internal partial class IQDeviceEventListenerInvoker : global::Java.Lang.Object, IQDeviceEventListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener", typeof (IQDeviceEventListenerInvoker));

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

			public static IQDeviceEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQDeviceEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.ConnectIQ.IQDeviceEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQDeviceEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
#pragma warning disable 0169
			static Delegate GetOnDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler ()
			{
				if (cb_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ == null)
					cb_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_);
				return cb_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
			}

			static void n_OnDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDeviceStatusChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
			public unsafe void OnDeviceStatusChanged (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1)
			{
				if (id_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ == IntPtr.Zero)
					id_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ = JNIEnv.GetMethodID (class_ref, "onDeviceStatusChanged", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_, __args);
			}

		}

		// event args for com.garmin.android.connectiq.ConnectIQ.IQDeviceEventListener.onDeviceStatusChanged
		public partial class QDeviceEventEventArgs : global::System.EventArgs {

			public QDeviceEventEventArgs (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1)
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

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/ConnectIQ_IQDeviceEventListenerImplementor")]
		internal sealed partial class IQDeviceEventListenerImplementor : global::Java.Lang.Object, IQDeviceEventListener {

			object sender;

			public IQDeviceEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/ConnectIQ_IQDeviceEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<QDeviceEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnDeviceStatusChanged (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new QDeviceEventEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IQDeviceEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']"
		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQMessageStatus", DoNotGenerateAcw=true)]
		public sealed partial class IQMessageStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='FAILURE_DEVICE_NOT_CONNECTED']"
			[Register ("FAILURE_DEVICE_NOT_CONNECTED")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus FailureDeviceNotConnected {
				get {
					const string __id = "FAILURE_DEVICE_NOT_CONNECTED.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='FAILURE_DURING_TRANSFER']"
			[Register ("FAILURE_DURING_TRANSFER")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus FailureDuringTransfer {
				get {
					const string __id = "FAILURE_DURING_TRANSFER.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='FAILURE_INVALID_DEVICE']"
			[Register ("FAILURE_INVALID_DEVICE")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus FailureInvalidDevice {
				get {
					const string __id = "FAILURE_INVALID_DEVICE.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='FAILURE_INVALID_FORMAT']"
			[Register ("FAILURE_INVALID_FORMAT")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus FailureInvalidFormat {
				get {
					const string __id = "FAILURE_INVALID_FORMAT.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='FAILURE_MESSAGE_TOO_LARGE']"
			[Register ("FAILURE_MESSAGE_TOO_LARGE")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus FailureMessageTooLarge {
				get {
					const string __id = "FAILURE_MESSAGE_TOO_LARGE.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='FAILURE_UNKNOWN']"
			[Register ("FAILURE_UNKNOWN")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus FailureUnknown {
				get {
					const string __id = "FAILURE_UNKNOWN.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='FAILURE_UNSUPPORTED_TYPE']"
			[Register ("FAILURE_UNSUPPORTED_TYPE")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus FailureUnsupportedType {
				get {
					const string __id = "FAILURE_UNSUPPORTED_TYPE.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus Success {
				get {
					const string __id = "SUCCESS.Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQMessageStatus", typeof (IQMessageStatus));
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

			internal IQMessageStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQMessageStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus[] Values ()
			{
				const string __id = "values.()[Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQOpenApplicationListener']"
		[Register ("com/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener", "", "Com.Garmin.Android.Connectiq.ConnectIQ/IQOpenApplicationListenerInvoker")]
		public partial interface IQOpenApplicationListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQOpenApplicationListener']/method[@name='onOpenApplicationResponse' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='com.garmin.android.connectiq.ConnectIQ.IQOpenApplicationStatus']]"
			[Register ("onOpenApplicationResponse", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;)V", "GetOnOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IQOpenApplicationListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnOpenApplicationResponse (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus p2);

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener", DoNotGenerateAcw=true)]
		internal partial class IQOpenApplicationListenerInvoker : global::Java.Lang.Object, IQOpenApplicationListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener", typeof (IQOpenApplicationListenerInvoker));

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

			public static IQOpenApplicationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQOpenApplicationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.ConnectIQ.IQOpenApplicationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQOpenApplicationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_;
#pragma warning disable 0169
			static Delegate GetOnOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_Handler ()
			{
				if (cb_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_ == null)
					cb_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_);
				return cb_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_;
			}

			static void n_OnOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQApp p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnOpenApplicationResponse (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_;
			public unsafe void OnOpenApplicationResponse (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus p2)
			{
				if (id_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_ == IntPtr.Zero)
					id_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_ = JNIEnv.GetMethodID (class_ref, "onOpenApplicationResponse", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpenApplicationResponse_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationStatus_, __args);
			}

		}

		// event args for com.garmin.android.connectiq.ConnectIQ.IQOpenApplicationListener.onOpenApplicationResponse
		public partial class QOpenApplicationEventArgs : global::System.EventArgs {

			public QOpenApplicationEventArgs (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Garmin.Android.Connectiq.IQDevice p0;
			public global::Com.Garmin.Android.Connectiq.IQDevice P0 {
				get { return p0; }
			}

			global::Com.Garmin.Android.Connectiq.IQApp p1;
			public global::Com.Garmin.Android.Connectiq.IQApp P1 {
				get { return p1; }
			}

			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus p2;
			public global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/ConnectIQ_IQOpenApplicationListenerImplementor")]
		internal sealed partial class IQOpenApplicationListenerImplementor : global::Java.Lang.Object, IQOpenApplicationListener {

			object sender;

			public IQOpenApplicationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/ConnectIQ_IQOpenApplicationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<QOpenApplicationEventArgs> Handler;
#pragma warning restore 0649

			public void OnOpenApplicationResponse (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new QOpenApplicationEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IQOpenApplicationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']"
		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus", DoNotGenerateAcw=true)]
		public sealed partial class IQOpenApplicationStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/field[@name='APP_IS_ALREADY_RUNNING']"
			[Register ("APP_IS_ALREADY_RUNNING")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus AppIsAlreadyRunning {
				get {
					const string __id = "APP_IS_ALREADY_RUNNING.Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/field[@name='APP_IS_NOT_INSTALLED']"
			[Register ("APP_IS_NOT_INSTALLED")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus AppIsNotInstalled {
				get {
					const string __id = "APP_IS_NOT_INSTALLED.Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/field[@name='PROMPT_NOT_SHOWN_ON_DEVICE']"
			[Register ("PROMPT_NOT_SHOWN_ON_DEVICE")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus PromptNotShownOnDevice {
				get {
					const string __id = "PROMPT_NOT_SHOWN_ON_DEVICE.Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/field[@name='PROMPT_SHOWN_ON_DEVICE']"
			[Register ("PROMPT_SHOWN_ON_DEVICE")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus PromptShownOnDevice {
				get {
					const string __id = "PROMPT_SHOWN_ON_DEVICE.Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/field[@name='UNKNOWN_FAILURE']"
			[Register ("UNKNOWN_FAILURE")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus UnknownFailure {
				get {
					const string __id = "UNKNOWN_FAILURE.Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus", typeof (IQOpenApplicationStatus));
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

			internal IQOpenApplicationStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromInt", "(I)Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus FromInt (int code)
			{
				const string __id = "fromInt.(I)Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (code);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQOpenApplicationStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus[] Values ()
			{
				const string __id = "values.()[Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQSdkErrorStatus']"
		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus", DoNotGenerateAcw=true)]
		public sealed partial class IQSdkErrorStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQSdkErrorStatus']/field[@name='GCM_NOT_INSTALLED']"
			[Register ("GCM_NOT_INSTALLED")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus GcmNotInstalled {
				get {
					const string __id = "GCM_NOT_INSTALLED.Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQSdkErrorStatus']/field[@name='GCM_UPGRADE_NEEDED']"
			[Register ("GCM_UPGRADE_NEEDED")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus GcmUpgradeNeeded {
				get {
					const string __id = "GCM_UPGRADE_NEEDED.Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQSdkErrorStatus']/field[@name='SERVICE_ERROR']"
			[Register ("SERVICE_ERROR")]
			public static global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus ServiceError {
				get {
					const string __id = "SERVICE_ERROR.Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus", typeof (IQSdkErrorStatus));
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

			internal IQSdkErrorStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQSdkErrorStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ.IQSdkErrorStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus[] Values ()
			{
				const string __id = "values.()[Lcom/garmin/android/connectiq/ConnectIQ$IQSdkErrorStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSdkErrorStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQSendImageListener']"
		[Register ("com/garmin/android/connectiq/ConnectIQ$IQSendImageListener", "", "Com.Garmin.Android.Connectiq.ConnectIQ/IQSendImageListenerInvoker")]
		public partial interface IQSendImageListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQSendImageListener']/method[@name='onImageStatus' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='com.garmin.android.connectiq.ConnectIQ.IQMessageStatus']]"
			[Register ("onImageStatus", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;)V", "GetOnImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IQSendImageListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnImageStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2);

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQSendImageListener", DoNotGenerateAcw=true)]
		internal partial class IQSendImageListenerInvoker : global::Java.Lang.Object, IQSendImageListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQSendImageListener", typeof (IQSendImageListenerInvoker));

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

			public static IQSendImageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQSendImageListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.ConnectIQ.IQSendImageListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQSendImageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
#pragma warning disable 0169
			static Delegate GetOnImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_Handler ()
			{
				if (cb_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ == null)
					cb_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_);
				return cb_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
			}

			static void n_OnImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQApp p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnImageStatus (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
			public unsafe void OnImageStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2)
			{
				if (id_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ == IntPtr.Zero)
					id_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ = JNIEnv.GetMethodID (class_ref, "onImageStatus", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_, __args);
			}

		}

		// event args for com.garmin.android.connectiq.ConnectIQ.IQSendImageListener.onImageStatus
		public partial class QSendImageEventArgs : global::System.EventArgs {

			public QSendImageEventArgs (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Garmin.Android.Connectiq.IQDevice p0;
			public global::Com.Garmin.Android.Connectiq.IQDevice P0 {
				get { return p0; }
			}

			global::Com.Garmin.Android.Connectiq.IQApp p1;
			public global::Com.Garmin.Android.Connectiq.IQApp P1 {
				get { return p1; }
			}

			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2;
			public global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/ConnectIQ_IQSendImageListenerImplementor")]
		internal sealed partial class IQSendImageListenerImplementor : global::Java.Lang.Object, IQSendImageListener {

			object sender;

			public IQSendImageListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/ConnectIQ_IQSendImageListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<QSendImageEventArgs> Handler;
#pragma warning restore 0649

			public void OnImageStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new QSendImageEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IQSendImageListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQSendMessageListener']"
		[Register ("com/garmin/android/connectiq/ConnectIQ$IQSendMessageListener", "", "Com.Garmin.Android.Connectiq.ConnectIQ/IQSendMessageListenerInvoker")]
		public partial interface IQSendMessageListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/interface[@name='ConnectIQ.IQSendMessageListener']/method[@name='onMessageStatus' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='com.garmin.android.connectiq.ConnectIQ.IQMessageStatus']]"
			[Register ("onMessageStatus", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;)V", "GetOnMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_Handler:Com.Garmin.Android.Connectiq.ConnectIQ/IQSendMessageListenerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
			void OnMessageStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2);

		}

		[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ$IQSendMessageListener", DoNotGenerateAcw=true)]
		internal partial class IQSendMessageListenerInvoker : global::Java.Lang.Object, IQSendMessageListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ$IQSendMessageListener", typeof (IQSendMessageListenerInvoker));

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

			public static IQSendMessageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQSendMessageListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.connectiq.ConnectIQ.IQSendMessageListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQSendMessageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
#pragma warning disable 0169
			static Delegate GetOnMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_Handler ()
			{
				if (cb_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ == null)
					cb_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_);
				return cb_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
			}

			static void n_OnMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.IQApp p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageStatus (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_;
			public unsafe void OnMessageStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2)
			{
				if (id_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ == IntPtr.Zero)
					id_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_ = JNIEnv.GetMethodID (class_ref, "onMessageStatus", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQMessageStatus;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageStatus_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQMessageStatus_, __args);
			}

		}

		// event args for com.garmin.android.connectiq.ConnectIQ.IQSendMessageListener.onMessageStatus
		public partial class QSendMessageEventArgs : global::System.EventArgs {

			public QSendMessageEventArgs (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Garmin.Android.Connectiq.IQDevice p0;
			public global::Com.Garmin.Android.Connectiq.IQDevice P0 {
				get { return p0; }
			}

			global::Com.Garmin.Android.Connectiq.IQApp p1;
			public global::Com.Garmin.Android.Connectiq.IQApp P1 {
				get { return p1; }
			}

			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2;
			public global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/garmin/android/connectiq/ConnectIQ_IQSendMessageListenerImplementor")]
		internal sealed partial class IQSendMessageListenerImplementor : global::Java.Lang.Object, IQSendMessageListener {

			object sender;

			public IQSendMessageListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/garmin/android/connectiq/ConnectIQ_IQSendMessageListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<QSendMessageEventArgs> Handler;
#pragma warning restore 0649

			public void OnMessageStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQMessageStatus p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new QSendMessageEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IQSendMessageListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ", typeof (ConnectIQ));
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

		protected ConnectIQ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/constructor[@name='ConnectIQ' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ConnectIQ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAdbPort;
#pragma warning disable 0169
		static Delegate GetGetAdbPortHandler ()
		{
			if (cb_getAdbPort == null)
				cb_getAdbPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdbPort);
			return cb_getAdbPort;
		}

		static int n_GetAdbPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdbPort;
		}
#pragma warning restore 0169

		static Delegate cb_setAdbPort_I;
#pragma warning disable 0169
		static Delegate GetSetAdbPort_IHandler ()
		{
			if (cb_setAdbPort_I == null)
				cb_setAdbPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAdbPort_I);
			return cb_setAdbPort_I;
		}

		static void n_SetAdbPort_I (IntPtr jnienv, IntPtr native__this, int port)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdbPort = port;
		}
#pragma warning restore 0169

		public virtual unsafe int AdbPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getAdbPort' and count(parameter)=0]"
			[Register ("getAdbPort", "()I", "GetGetAdbPortHandler")]
			get {
				const string __id = "getAdbPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='setAdbPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAdbPort", "(I)V", "GetSetAdbPort_IHandler")]
			set {
				const string __id = "setAdbPort.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

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
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.ConnectedDevices);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> ConnectedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getConnectedDevices' and count(parameter)=0]"
			[Register ("getConnectedDevices", "()Ljava/util/List;", "GetGetConnectedDevicesHandler")] get;
		}

		public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/garmin/android/connectiq/ConnectIQ;", "")]
			get {
				const string __id = "getInstance.()Lcom/garmin/android/connectiq/ConnectIQ;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.KnownDevices);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> KnownDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getKnownDevices' and count(parameter)=0]"
			[Register ("getKnownDevices", "()Ljava/util/List;", "GetGetKnownDevicesHandler")] get;
		}

		static Delegate cb_deviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
#pragma warning disable 0169
		static Delegate GetDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler ()
		{
			if (cb_deviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ == null)
				cb_deviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_);
			return cb_deviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
		}

		static void n_DeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_newStatus)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus newStatus = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (native_newStatus, JniHandleOwnership.DoNotTransfer);
			__this.DeviceStatusChanged (device, newStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='deviceStatusChanged' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice.IQDeviceStatus']]"
		[Register ("deviceStatusChanged", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V", "GetDeviceStatusChanged_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler")]
		protected virtual unsafe void DeviceStatusChanged (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus newStatus)
		{
			const string __id = "deviceStatusChanged.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((newStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newStatus).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_displayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisplayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_displayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_displayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisplayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_displayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DisplayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title, IntPtr native_message, IntPtr native_negButton, IntPtr native_posButton)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			string negButton = JNIEnv.GetString (native_negButton, JniHandleOwnership.DoNotTransfer);
			string posButton = JNIEnv.GetString (native_posButton, JniHandleOwnership.DoNotTransfer);
			__this.DisplayGCMDialog (title, message, negButton, posButton);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='displayGCMDialog' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("displayGCMDialog", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetDisplayGCMDialog_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void DisplayGCMDialog (string title, string message, string negButton, string posButton)
		{
			const string __id = "displayGCMDialog.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_title = JNIEnv.NewString (title);
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_negButton = JNIEnv.NewString (negButton);
			IntPtr native_posButton = JNIEnv.NewString (posButton);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_title);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (native_negButton);
				__args [3] = new JniArgumentValue (native_posButton);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_negButton);
				JNIEnv.DeleteLocalRef (native_posButton);
			}
		}

		static Delegate cb_getApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_Handler ()
		{
			if (cb_getApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_ == null)
				cb_getApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_);
			return cb_getApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_;
		}

		static void n_GetApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_applicationId, IntPtr native_device, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string applicationId = JNIEnv.GetString (native_applicationId, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetApplicationInfo (applicationId, device, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getApplicationInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice'] and parameter[3][@type='com.garmin.android.connectiq.ConnectIQ.IQApplicationInfoListener']]"
		[Register ("getApplicationInfo", "(Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener;)V", "GetGetApplicationInfo_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_Handler")]
		public virtual unsafe void GetApplicationInfo (string applicationId, global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener listener)
		{
			const string __id = "getApplicationInfo.(Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener;)V";
			IntPtr native_applicationId = JNIEnv.NewString (applicationId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_applicationId);
				__args [1] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationId);
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

		static IntPtr n_GetDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeviceStatus (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getDeviceStatus' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("getDeviceStatus", "(Lcom/garmin/android/connectiq/IQDevice;)Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;", "GetGetDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_Handler")]
		public abstract global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus GetDeviceStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.garmin.android.connectiq.ConnectIQ.IQConnectType']]"
		[Register ("getInstance", "(Landroid/content/Context;Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;)Lcom/garmin/android/connectiq/ConnectIQ;", "")]
		public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ GetInstance (global::Android.Content.Context context, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQConnectType connectType)
		{
			const string __id = "getInstance.(Landroid/content/Context;Lcom/garmin/android/connectiq/ConnectIQ$IQConnectType;)Lcom/garmin/android/connectiq/ConnectIQ;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((connectType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) connectType).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_Handler ()
		{
			if (cb_initialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_ == null)
				cb_initialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Initialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_);
			return cb_initialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_;
		}

		static void n_Initialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, bool autoUI, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (context, autoUI, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='com.garmin.android.connectiq.ConnectIQ.ConnectIQListener']]"
		[Register ("initialize", "(Landroid/content/Context;ZLcom/garmin/android/connectiq/ConnectIQ$ConnectIQListener;)V", "GetInitialize_Landroid_content_Context_ZLcom_garmin_android_connectiq_ConnectIQ_ConnectIQListener_Handler")]
		public virtual unsafe void Initialize (global::Android.Content.Context context, bool autoUI, global::Com.Garmin.Android.Connectiq.ConnectIQ.IConnectIQListener listener)
		{
			const string __id = "initialize.(Landroid/content/Context;ZLcom/garmin/android/connectiq/ConnectIQ$ConnectIQListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (autoUI);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_openApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_;
#pragma warning disable 0169
		static Delegate GetOpenApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_Handler ()
		{
			if (cb_openApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_ == null)
				cb_openApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_);
			return cb_openApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_;
		}

		static void n_OpenApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_application, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp application = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_application, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OpenApplication (device, application, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='openApplication' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='com.garmin.android.connectiq.ConnectIQ.IQOpenApplicationListener']]"
		[Register ("openApplication", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener;)V", "GetOpenApplication_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_Handler")]
		public virtual unsafe void OpenApplication (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQApp application, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener listener)
		{
			const string __id = "openApplication.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_openStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenStore_Ljava_lang_String_Handler ()
		{
			if (cb_openStore_Ljava_lang_String_ == null)
				cb_openStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OpenStore_Ljava_lang_String_);
			return cb_openStore_Ljava_lang_String_;
		}

		static bool n_OpenStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_storeID)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string storeID = JNIEnv.GetString (native_storeID, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OpenStore (storeID);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='openStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openStore", "(Ljava/lang/String;)Z", "GetOpenStore_Ljava_lang_String_Handler")]
		public virtual unsafe bool OpenStore (string storeID)
		{
			const string __id = "openStore.(Ljava/lang/String;)Z";
			IntPtr native_storeID = JNIEnv.NewString (storeID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_storeID);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_storeID);
			}
		}

		static Delegate cb_registerForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_Handler ()
		{
			if (cb_registerForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ == null)
				cb_registerForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_);
			return cb_registerForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_;
		}

		static void n_RegisterForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_app, IntPtr native_applistener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp app = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_app, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener applistener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener> (native_applistener, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForAppEvents (device, app, applistener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='registerForAppEvents' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='com.garmin.android.connectiq.ConnectIQ.IQApplicationEventListener']]"
		[Register ("registerForAppEvents", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V", "GetRegisterForAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_Handler")]
		public virtual unsafe void RegisterForAppEvents (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQApp app, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener applistener)
		{
			const string __id = "registerForAppEvents.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [2] = new JniArgumentValue ((applistener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applistener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Handler ()
		{
			if (cb_registerForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_ == null)
				cb_registerForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_);
			return cb_registerForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_;
		}

		static void n_RegisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForDeviceEvents (device, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='registerForDeviceEvents' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.ConnectIQ.IQDeviceEventListener']]"
		[Register ("registerForDeviceEvents", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;)V", "GetRegisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Handler")]
		public virtual unsafe void RegisterForDeviceEvents (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener listener)
		{
			const string __id = "registerForDeviceEvents.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_;
#pragma warning disable 0169
		static Delegate GetRegisterForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_Handler ()
		{
			if (cb_registerForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ == null)
				cb_registerForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_);
			return cb_registerForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_;
		}

		static void n_RegisterForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_listener, IntPtr native_app, IntPtr native_applistener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp app = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_app, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener applistener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener> (native_applistener, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForEvents (device, listener, app, applistener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='registerForEvents' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.ConnectIQ.IQDeviceEventListener'] and parameter[3][@type='com.garmin.android.connectiq.IQApp'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQApplicationEventListener']]"
		[Register ("registerForEvents", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V", "GetRegisterForEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Lcom_garmin_android_connectiq_IQApp_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_Handler")]
		public virtual unsafe void RegisterForEvents (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener listener, global::Com.Garmin.Android.Connectiq.IQApp app, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener applistener)
		{
			const string __id = "registerForEvents.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;Lcom/garmin/android/connectiq/IQApp;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [3] = new JniArgumentValue ((applistener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applistener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		static void n_RegisterForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForRemoteAppEvents (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='registerForRemoteAppEvents' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("registerForRemoteAppEvents", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetRegisterForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		protected abstract void RegisterForRemoteAppEvents (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1);

		static Delegate cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_;
#pragma warning disable 0169
		static Delegate GetSendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_Handler ()
		{
			if (cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_ == null)
				cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_);
			return cb_sendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_;
		}

		static void n_SendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener p3 = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendImageProtocol (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='sendImageProtocol' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQSendImageListener']]"
		[Register ("sendImageProtocol", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendImageListener;)V", "GetSendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_Handler")]
		protected abstract void SendImageProtocol (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, byte[] p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener p3);

		static Delegate cb_sendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler ()
		{
			if (cb_sendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ == null)
				cb_sendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_);
			return cb_sendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_;
		}

		static void n_SendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_application, IntPtr native_javaObject, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp application = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_application, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object javaObject = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_javaObject, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (device, application, javaObject, listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='sendMessage' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQSendMessageListener']]"
		[Register ("sendMessage", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Ljava/lang/Object;Lcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V", "GetSendMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_Object_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler")]
		public virtual unsafe void SendMessage (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQApp application, global::Java.Lang.Object javaObject, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener listener)
		{
			const string __id = "sendMessage.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;Ljava/lang/Object;Lcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [2] = new JniArgumentValue ((javaObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) javaObject).Handle);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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

		static void n_SendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener p3 = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageProtocol (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='sendMessageProtocol' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQSendMessageListener']]"
		[Register ("sendMessageProtocol", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V", "GetSendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler")]
		protected abstract void SendMessageProtocol (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, byte[] p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener p3);

		static Delegate cb_shutdown_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShutdown_Landroid_content_Context_Handler ()
		{
			if (cb_shutdown_Landroid_content_Context_ == null)
				cb_shutdown_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Shutdown_Landroid_content_Context_);
			return cb_shutdown_Landroid_content_Context_;
		}

		static void n_Shutdown_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='shutdown' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("shutdown", "(Landroid/content/Context;)V", "GetShutdown_Landroid_content_Context_Handler")]
		public virtual unsafe void Shutdown (global::Android.Content.Context context)
		{
			const string __id = "shutdown.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterAllForEvents;
#pragma warning disable 0169
		static Delegate GetUnregisterAllForEventsHandler ()
		{
			if (cb_unregisterAllForEvents == null)
				cb_unregisterAllForEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterAllForEvents);
			return cb_unregisterAllForEvents;
		}

		static void n_UnregisterAllForEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterAllForEvents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='unregisterAllForEvents' and count(parameter)=0]"
		[Register ("unregisterAllForEvents", "()V", "GetUnregisterAllForEventsHandler")]
		public virtual unsafe void UnregisterAllForEvents ()
		{
			const string __id = "unregisterAllForEvents.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetUnregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_unregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_unregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_unregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_UnregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device, IntPtr native_application)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp application = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_application, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterForApplicationEvents (device, application);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='unregisterForApplicationEvents' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("unregisterForApplicationEvents", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetUnregisterForApplicationEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		public virtual unsafe void UnregisterForApplicationEvents (global::Com.Garmin.Android.Connectiq.IQDevice device, global::Com.Garmin.Android.Connectiq.IQApp application)
		{
			const string __id = "unregisterForApplicationEvents.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [1] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_;
#pragma warning disable 0169
		static Delegate GetUnregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Handler ()
		{
			if (cb_unregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_ == null)
				cb_unregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_);
			return cb_unregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_;
		}

		static void n_UnregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterForDeviceEvents (device);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='unregisterForDeviceEvents' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("unregisterForDeviceEvents", "(Lcom/garmin/android/connectiq/IQDevice;)V", "GetUnregisterForDeviceEvents_Lcom_garmin_android_connectiq_IQDevice_Handler")]
		public virtual unsafe void UnregisterForDeviceEvents (global::Com.Garmin.Android.Connectiq.IQDevice device)
		{
			const string __id = "unregisterForDeviceEvents.(Lcom/garmin/android/connectiq/IQDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_;
#pragma warning disable 0169
		static Delegate GetUnregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_Handler ()
		{
			if (cb_unregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_ == null)
				cb_unregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_);
			return cb_unregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_;
		}

		static void n_UnregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice device = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_device, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterForEvents (device);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='unregisterForEvents' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("unregisterForEvents", "(Lcom/garmin/android/connectiq/IQDevice;)V", "GetUnregisterForEvents_Lcom_garmin_android_connectiq_IQDevice_Handler")]
		public virtual unsafe void UnregisterForEvents (global::Com.Garmin.Android.Connectiq.IQDevice device)
		{
			const string __id = "unregisterForEvents.(Lcom/garmin/android/connectiq/IQDevice;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_verifyInitialized;
#pragma warning disable 0169
		static Delegate GetVerifyInitializedHandler ()
		{
			if (cb_verifyInitialized == null)
				cb_verifyInitialized = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_VerifyInitialized);
			return cb_verifyInitialized;
		}

		static void n_VerifyInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQ __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VerifyInitialized ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='verifyInitialized' and count(parameter)=0]"
		[Register ("verifyInitialized", "()V", "GetVerifyInitializedHandler")]
		protected virtual unsafe void VerifyInitialized ()
		{
			const string __id = "verifyInitialized.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQ", DoNotGenerateAcw=true)]
	internal partial class ConnectIQInvoker : ConnectIQ {

		public ConnectIQInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQ", typeof (ConnectIQInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> ConnectedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getConnectedDevices' and count(parameter)=0]"
			[Register ("getConnectedDevices", "()Ljava/util/List;", "GetGetConnectedDevicesHandler")]
			get {
				const string __id = "getConnectedDevices.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> KnownDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getKnownDevices' and count(parameter)=0]"
			[Register ("getKnownDevices", "()Ljava/util/List;", "GetGetKnownDevicesHandler")]
			get {
				const string __id = "getKnownDevices.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='getDeviceStatus' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("getDeviceStatus", "(Lcom/garmin/android/connectiq/IQDevice;)Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;", "GetGetDeviceStatus_Lcom_garmin_android_connectiq_IQDevice_Handler")]
		public override unsafe global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus GetDeviceStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0)
		{
			const string __id = "getDeviceStatus.(Lcom/garmin/android/connectiq/IQDevice;)Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='registerForRemoteAppEvents' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("registerForRemoteAppEvents", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetRegisterForRemoteAppEvents_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		protected override unsafe void RegisterForRemoteAppEvents (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1)
		{
			const string __id = "registerForRemoteAppEvents.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='sendImageProtocol' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQSendImageListener']]"
		[Register ("sendImageProtocol", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendImageListener;)V", "GetSendImageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendImageListener_Handler")]
		protected override unsafe void SendImageProtocol (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, byte[] p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendImageListener p3)
		{
			const string __id = "sendImageProtocol.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendImageListener;)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQ']/method[@name='sendMessageProtocol' and count(parameter)=4 and parameter[1][@type='com.garmin.android.connectiq.IQDevice'] and parameter[2][@type='com.garmin.android.connectiq.IQApp'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.garmin.android.connectiq.ConnectIQ.IQSendMessageListener']]"
		[Register ("sendMessageProtocol", "(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V", "GetSendMessageProtocol_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_arrayBLcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler")]
		protected override unsafe void SendMessageProtocol (global::Com.Garmin.Android.Connectiq.IQDevice p0, global::Com.Garmin.Android.Connectiq.IQApp p1, byte[] p2, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener p3)
		{
			const string __id = "sendMessageProtocol.(Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;[BLcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}

}
