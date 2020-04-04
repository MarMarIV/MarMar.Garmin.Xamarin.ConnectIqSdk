using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Apps.Connectmobile.Connectiq {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']"
	[global::Android.Runtime.Register ("com/garmin/android/apps/connectmobile/connectiq/IConnectIQService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ConnectIQServiceStub : global::Android.OS.Binder, global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/apps/connectmobile/connectiq/IConnectIQService$Stub", typeof (ConnectIQServiceStub));
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

		protected ConnectIQServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/constructor[@name='IConnectIQService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConnectIQServiceStub ()
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/garmin/android/apps/connectmobile/connectiq/IConnectIQService;", "")]
		public static unsafe global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/garmin/android/apps/connectmobile/connectiq/IConnectIQService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_Handler ()
		{
			if (cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ == null)
				cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_);
			return cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_;
		}

		static void n_GetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.GetApplicationInfo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getApplicationInfo' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.garmin.android.connectiq.IQDevice'] and parameter[4][@type='java.lang.String']]"
		[Register ("getApplicationInfo", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Ljava/lang/String;)V", "GetGetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_Handler")]
		public abstract void GetApplicationInfo (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, string p3);

		static Delegate cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_;
#pragma warning disable 0169
		static Delegate GetGetStatus_Lcom_garmin_android_connectiq_IQDevice_Handler ()
		{
			if (cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_ == null)
				cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetStatus_Lcom_garmin_android_connectiq_IQDevice_);
			return cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_;
		}

		static int n_GetStatus_Lcom_garmin_android_connectiq_IQDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetStatus (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getStatus' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("getStatus", "(Lcom/garmin/android/connectiq/IQDevice;)I", "GetGetStatus_Lcom_garmin_android_connectiq_IQDevice_Handler")]
		public abstract int GetStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0);

		static Delegate cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetOpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_OpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p3 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OpenApplication (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='openApplication' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.garmin.android.connectiq.IQDevice'] and parameter[4][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("openApplication", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetOpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		public abstract void OpenApplication (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, global::Com.Garmin.Android.Connectiq.IQApp p3);

		static Delegate cb_openStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenStore_Ljava_lang_String_Handler ()
		{
			if (cb_openStore_Ljava_lang_String_ == null)
				cb_openStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OpenStore_Ljava_lang_String_);
			return cb_openStore_Ljava_lang_String_;
		}

		static bool n_OpenStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OpenStore (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='openStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openStore", "(Ljava/lang/String;)Z", "GetOpenStore_Ljava_lang_String_Handler")]
		public abstract bool OpenStore (string p0);

		static Delegate cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RegisterApp (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='registerApp' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQApp'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerApp", "(Lcom/garmin/android/connectiq/IQApp;Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void RegisterApp (global::Com.Garmin.Android.Connectiq.IQApp p0, string p1, string p2);

		static Delegate cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetSendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_SendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendImage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='sendImage' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQMessage'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice'] and parameter[3][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("sendImage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetSendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		public abstract void SendImage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2);

		static Delegate cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_SendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQMessage'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice'] and parameter[3][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("sendMessage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetSendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		public abstract void SendMessage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2);

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
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.ConnectedDevices);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> ConnectedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/method[@name='getConnectedDevices' and count(parameter)=0]"
			[Register ("getConnectedDevices", "()Ljava/util/List;", "GetGetConnectedDevicesHandler")] get;
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
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.ConnectIQServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.KnownDevices);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> KnownDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/method[@name='getKnownDevices' and count(parameter)=0]"
			[Register ("getKnownDevices", "()Ljava/util/List;", "GetGetKnownDevicesHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/garmin/android/apps/connectmobile/connectiq/IConnectIQService$Stub", DoNotGenerateAcw=true)]
	internal partial class ConnectIQServiceStubInvoker : ConnectIQServiceStub {

		public ConnectIQServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/apps/connectmobile/connectiq/IConnectIQService$Stub", typeof (ConnectIQServiceStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> ConnectedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/method[@name='getConnectedDevices' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/class[@name='IConnectIQService.Stub']/method[@name='getKnownDevices' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getApplicationInfo' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.garmin.android.connectiq.IQDevice'] and parameter[4][@type='java.lang.String']]"
		[Register ("getApplicationInfo", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Ljava/lang/String;)V", "GetGetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_Handler")]
		public override unsafe void GetApplicationInfo (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, string p3)
		{
			const string __id = "getApplicationInfo.(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getStatus' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("getStatus", "(Lcom/garmin/android/connectiq/IQDevice;)I", "GetGetStatus_Lcom_garmin_android_connectiq_IQDevice_Handler")]
		public override unsafe int GetStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0)
		{
			const string __id = "getStatus.(Lcom/garmin/android/connectiq/IQDevice;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='openApplication' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.garmin.android.connectiq.IQDevice'] and parameter[4][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("openApplication", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetOpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		public override unsafe void OpenApplication (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, global::Com.Garmin.Android.Connectiq.IQApp p3)
		{
			const string __id = "openApplication.(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='openStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openStore", "(Ljava/lang/String;)Z", "GetOpenStore_Ljava_lang_String_Handler")]
		public override unsafe bool OpenStore (string p0)
		{
			const string __id = "openStore.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='registerApp' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQApp'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerApp", "(Lcom/garmin/android/connectiq/IQApp;Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void RegisterApp (global::Com.Garmin.Android.Connectiq.IQApp p0, string p1, string p2)
		{
			const string __id = "registerApp.(Lcom/garmin/android/connectiq/IQApp;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='sendImage' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQMessage'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice'] and parameter[3][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("sendImage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetSendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		public override unsafe void SendImage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2)
		{
			const string __id = "sendImage.(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQMessage'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice'] and parameter[3][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("sendMessage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetSendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler")]
		public override unsafe void SendMessage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2)
		{
			const string __id = "sendMessage.(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']"
	[Register ("com/garmin/android/apps/connectmobile/connectiq/IConnectIQService", "", "Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker")]
	public partial interface IConnectIQService : global::Android.OS.IInterface {

		global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> ConnectedDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getConnectedDevices' and count(parameter)=0]"
			[Register ("getConnectedDevices", "()Ljava/util/List;", "GetGetConnectedDevicesHandler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> KnownDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getKnownDevices' and count(parameter)=0]"
			[Register ("getKnownDevices", "()Ljava/util/List;", "GetGetKnownDevicesHandler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getApplicationInfo' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.garmin.android.connectiq.IQDevice'] and parameter[4][@type='java.lang.String']]"
		[Register ("getApplicationInfo", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Ljava/lang/String;)V", "GetGetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_Handler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
		void GetApplicationInfo (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='getStatus' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice']]"
		[Register ("getStatus", "(Lcom/garmin/android/connectiq/IQDevice;)I", "GetGetStatus_Lcom_garmin_android_connectiq_IQDevice_Handler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
		int GetStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='openApplication' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.garmin.android.connectiq.IQDevice'] and parameter[4][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("openApplication", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetOpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
		void OpenApplication (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, global::Com.Garmin.Android.Connectiq.IQApp p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='openStore' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openStore", "(Ljava/lang/String;)Z", "GetOpenStore_Ljava_lang_String_Handler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
		bool OpenStore (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='registerApp' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQApp'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("registerApp", "(Lcom/garmin/android/connectiq/IQApp;Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_Handler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
		void RegisterApp (global::Com.Garmin.Android.Connectiq.IQApp p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='sendImage' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQMessage'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice'] and parameter[3][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("sendImage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetSendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
		void SendImage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.apps.connectmobile.connectiq']/interface[@name='IConnectIQService']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.garmin.android.connectiq.IQMessage'] and parameter[2][@type='com.garmin.android.connectiq.IQDevice'] and parameter[3][@type='com.garmin.android.connectiq.IQApp']]"
		[Register ("sendMessage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V", "GetSendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler:Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQServiceInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")]
		void SendMessage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2);

	}

	[global::Android.Runtime.Register ("com/garmin/android/apps/connectmobile/connectiq/IConnectIQService", DoNotGenerateAcw=true)]
	internal partial class IConnectIQServiceInvoker : global::Java.Lang.Object, IConnectIQService {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/apps/connectmobile/connectiq/IConnectIQService", typeof (IConnectIQServiceInvoker));

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

		public static IConnectIQService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectIQService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.garmin.android.apps.connectmobile.connectiq.IConnectIQService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectIQServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.ConnectedDevices);
		}
#pragma warning restore 0169

		IntPtr id_getConnectedDevices;
		public unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> ConnectedDevices {
			get {
				if (id_getConnectedDevices == IntPtr.Zero)
					id_getConnectedDevices = JNIEnv.GetMethodID (class_ref, "getConnectedDevices", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectedDevices), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.ToLocalJniHandle (__this.KnownDevices);
		}
#pragma warning restore 0169

		IntPtr id_getKnownDevices;
		public unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Android.Connectiq.IQDevice> KnownDevices {
			get {
				if (id_getKnownDevices == IntPtr.Zero)
					id_getKnownDevices = JNIEnv.GetMethodID (class_ref, "getKnownDevices", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Garmin.Android.Connectiq.IQDevice>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKnownDevices), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_Handler ()
		{
			if (cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ == null)
				cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_);
			return cb_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_;
		}

		static void n_GetApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.GetApplicationInfo (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_;
		public unsafe void GetApplicationInfo (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, string p3)
		{
			if (id_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ == IntPtr.Zero)
				id_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getApplicationInfo", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationInfo_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_;
#pragma warning disable 0169
		static Delegate GetGetStatus_Lcom_garmin_android_connectiq_IQDevice_Handler ()
		{
			if (cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_ == null)
				cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetStatus_Lcom_garmin_android_connectiq_IQDevice_);
			return cb_getStatus_Lcom_garmin_android_connectiq_IQDevice_;
		}

		static int n_GetStatus_Lcom_garmin_android_connectiq_IQDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetStatus (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getStatus_Lcom_garmin_android_connectiq_IQDevice_;
		public unsafe int GetStatus (global::Com.Garmin.Android.Connectiq.IQDevice p0)
		{
			if (id_getStatus_Lcom_garmin_android_connectiq_IQDevice_ == IntPtr.Zero)
				id_getStatus_Lcom_garmin_android_connectiq_IQDevice_ = JNIEnv.GetMethodID (class_ref, "getStatus", "(Lcom/garmin/android/connectiq/IQDevice;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatus_Lcom_garmin_android_connectiq_IQDevice_, __args);
			return __ret;
		}

		static Delegate cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetOpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_OpenApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p3 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OpenApplication (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		public unsafe void OpenApplication (string p0, string p1, global::Com.Garmin.Android.Connectiq.IQDevice p2, global::Com.Garmin.Android.Connectiq.IQApp p3)
		{
			if (id_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == IntPtr.Zero)
				id_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNIEnv.GetMethodID (class_ref, "openApplication", "(Ljava/lang/String;Ljava/lang/String;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openApplication_Ljava_lang_String_Ljava_lang_String_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_openStore_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenStore_Ljava_lang_String_Handler ()
		{
			if (cb_openStore_Ljava_lang_String_ == null)
				cb_openStore_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OpenStore_Ljava_lang_String_);
			return cb_openStore_Ljava_lang_String_;
		}

		static bool n_OpenStore_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OpenStore (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_openStore_Ljava_lang_String_;
		public unsafe bool OpenStore (string p0)
		{
			if (id_openStore_Ljava_lang_String_ == IntPtr.Zero)
				id_openStore_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openStore", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_openStore_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RegisterApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RegisterApp (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void RegisterApp (global::Com.Garmin.Android.Connectiq.IQApp p0, string p1, string p2)
		{
			if (id_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerApp", "(Lcom/garmin/android/connectiq/IQApp;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerApp_Lcom_garmin_android_connectiq_IQApp_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetSendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_SendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendImage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		public unsafe void SendImage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2)
		{
			if (id_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == IntPtr.Zero)
				id_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNIEnv.GetMethodID (class_ref, "sendImage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendImage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_, __args);
		}

		static Delegate cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_Handler ()
		{
			if (cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == null)
				cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_);
			return cb_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		}

		static void n_SendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice p1 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQApp p2 = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_;
		public unsafe void SendMessage (global::Com.Garmin.Android.Connectiq.IQMessage p0, global::Com.Garmin.Android.Connectiq.IQDevice p1, global::Com.Garmin.Android.Connectiq.IQApp p2)
		{
			if (id_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ == IntPtr.Zero)
				id_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/garmin/android/connectiq/IQMessage;Lcom/garmin/android/connectiq/IQDevice;Lcom/garmin/android/connectiq/IQApp;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_garmin_android_connectiq_IQMessage_Lcom_garmin_android_connectiq_IQDevice_Lcom_garmin_android_connectiq_IQApp_, __args);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Apps.Connectmobile.Connectiq.IConnectIQService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
