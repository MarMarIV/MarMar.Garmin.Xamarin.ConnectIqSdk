using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/IQDevice", DoNotGenerateAcw=true)]
	public partial class IQDevice : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice.IQDeviceStatus']"
		[global::Android.Runtime.Register ("com/garmin/android/connectiq/IQDevice$IQDeviceStatus", DoNotGenerateAcw=true)]
		public sealed partial class IQDeviceStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice.IQDeviceStatus']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus Connected {
				get {
					const string __id = "CONNECTED.Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice.IQDeviceStatus']/field[@name='NOT_CONNECTED']"
			[Register ("NOT_CONNECTED")]
			public static global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus NotConnected {
				get {
					const string __id = "NOT_CONNECTED.Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice.IQDeviceStatus']/field[@name='NOT_PAIRED']"
			[Register ("NOT_PAIRED")]
			public static global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus NotPaired {
				get {
					const string __id = "NOT_PAIRED.Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice.IQDeviceStatus']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/IQDevice$IQDeviceStatus", typeof (IQDeviceStatus));
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

			internal IQDeviceStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice.IQDeviceStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice.IQDeviceStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus[] Values ()
			{
				const string __id = "values.()[Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/IQDevice", typeof (IQDevice));
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

		protected IQDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/constructor[@name='IQDevice' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe IQDevice (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/constructor[@name='IQDevice' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(JLjava/lang/String;)V", "")]
		public unsafe IQDevice (long deviceIdentifier, string friendlyName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_friendlyName = JNIEnv.NewString (friendlyName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (deviceIdentifier);
				__args [1] = new JniArgumentValue (native_friendlyName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_friendlyName);
			}
		}

		static Delegate cb_getDeviceIdentifier;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdentifierHandler ()
		{
			if (cb_getDeviceIdentifier == null)
				cb_getDeviceIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDeviceIdentifier);
			return cb_getDeviceIdentifier;
		}

		static long n_GetDeviceIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQDevice __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceIdentifier;
		}
#pragma warning restore 0169

		public virtual unsafe long DeviceIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/method[@name='getDeviceIdentifier' and count(parameter)=0]"
			[Register ("getDeviceIdentifier", "()J", "GetGetDeviceIdentifierHandler")]
			get {
				const string __id = "getDeviceIdentifier.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFriendlyName;
#pragma warning disable 0169
		static Delegate GetGetFriendlyNameHandler ()
		{
			if (cb_getFriendlyName == null)
				cb_getFriendlyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFriendlyName);
			return cb_getFriendlyName;
		}

		static IntPtr n_GetFriendlyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQDevice __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FriendlyName);
		}
#pragma warning restore 0169

		public virtual unsafe string FriendlyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/method[@name='getFriendlyName' and count(parameter)=0]"
			[Register ("getFriendlyName", "()Ljava/lang/String;", "GetGetFriendlyNameHandler")]
			get {
				const string __id = "getFriendlyName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQDevice __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler ()
		{
			if (cb_setStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ == null)
				cb_setStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_);
			return cb_setStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_;
		}

		static void n_SetStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::Com.Garmin.Android.Connectiq.IQDevice __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus status = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (native_status, JniHandleOwnership.DoNotTransfer);
			__this.Status = status;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice.IQDeviceStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.IQDevice.IQDeviceStatus']]"
			[Register ("setStatus", "(Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V", "GetSetStatus_Lcom_garmin_android_connectiq_IQDevice_IQDeviceStatus_Handler")]
			set {
				const string __id = "setStatus.(Lcom/garmin/android/connectiq/IQDevice$IQDeviceStatus;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQDevice __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Garmin.Android.Connectiq.IQDevice __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQDevice']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
