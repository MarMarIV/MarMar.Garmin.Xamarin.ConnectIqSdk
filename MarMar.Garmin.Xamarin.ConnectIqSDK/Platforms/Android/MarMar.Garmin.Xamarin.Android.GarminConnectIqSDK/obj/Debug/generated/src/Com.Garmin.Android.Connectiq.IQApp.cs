using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/IQApp", DoNotGenerateAcw=true)]
	public partial class IQApp : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp.IQAppStatus']"
		[global::Android.Runtime.Register ("com/garmin/android/connectiq/IQApp$IQAppStatus", DoNotGenerateAcw=true)]
		public sealed partial class IQAppStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp.IQAppStatus']/field[@name='INSTALLED']"
			[Register ("INSTALLED")]
			public static global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus Installed {
				get {
					const string __id = "INSTALLED.Lcom/garmin/android/connectiq/IQApp$IQAppStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp.IQAppStatus']/field[@name='NOT_INSTALLED']"
			[Register ("NOT_INSTALLED")]
			public static global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus NotInstalled {
				get {
					const string __id = "NOT_INSTALLED.Lcom/garmin/android/connectiq/IQApp$IQAppStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp.IQAppStatus']/field[@name='NOT_SUPPORTED']"
			[Register ("NOT_SUPPORTED")]
			public static global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus NotSupported {
				get {
					const string __id = "NOT_SUPPORTED.Lcom/garmin/android/connectiq/IQApp$IQAppStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp.IQAppStatus']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/garmin/android/connectiq/IQApp$IQAppStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/IQApp$IQAppStatus", typeof (IQAppStatus));
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

			internal IQAppStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp.IQAppStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/garmin/android/connectiq/IQApp$IQAppStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/garmin/android/connectiq/IQApp$IQAppStatus;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp.IQAppStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/garmin/android/connectiq/IQApp$IQAppStatus;", "")]
			public static unsafe global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus[] Values ()
			{
				const string __id = "values.()[Lcom/garmin/android/connectiq/IQApp$IQAppStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/IQApp", typeof (IQApp));
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

		protected IQApp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/constructor[@name='IQApp' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe IQApp (global::Android.OS.Parcel @in)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/constructor[@name='IQApp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe IQApp (string applicationID)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_applicationID = JNIEnv.NewString (applicationID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_applicationID);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationID);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/constructor[@name='IQApp' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.garmin.android.connectiq.IQApp.IQAppStatus'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/garmin/android/connectiq/IQApp$IQAppStatus;Ljava/lang/String;I)V", "")]
		public unsafe IQApp (string applicationID, global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus status, string displayName, int version)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/garmin/android/connectiq/IQApp$IQAppStatus;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_applicationID = JNIEnv.NewString (applicationID);
			IntPtr native_displayName = JNIEnv.NewString (displayName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_applicationID);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				__args [2] = new JniArgumentValue (native_displayName);
				__args [3] = new JniArgumentValue (version);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationID);
				JNIEnv.DeleteLocalRef (native_displayName);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/constructor[@name='IQApp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe IQApp (string applicationID, int version)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_applicationID = JNIEnv.NewString (applicationID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_applicationID);
				__args [1] = new JniArgumentValue (version);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationID);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/constructor[@name='IQApp' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe IQApp (string applicationID, string displayName, int version)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_applicationID = JNIEnv.NewString (applicationID);
			IntPtr native_displayName = JNIEnv.NewString (displayName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_applicationID);
				__args [1] = new JniArgumentValue (native_displayName);
				__args [2] = new JniArgumentValue (version);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationID);
				JNIEnv.DeleteLocalRef (native_displayName);
			}
		}

		static Delegate cb_getApplicationId;
#pragma warning disable 0169
		static Delegate GetGetApplicationIdHandler ()
		{
			if (cb_getApplicationId == null)
				cb_getApplicationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationId);
			return cb_getApplicationId;
		}

		static IntPtr n_GetApplicationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQApp __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationId);
		}
#pragma warning restore 0169

		public virtual unsafe string ApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/method[@name='getApplicationId' and count(parameter)=0]"
			[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler")]
			get {
				const string __id = "getApplicationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQApp __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				const string __id = "getDisplayName.()Ljava/lang/String;";
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
			global::Com.Garmin.Android.Connectiq.IQApp __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/garmin/android/connectiq/IQApp$IQAppStatus;", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()Lcom/garmin/android/connectiq/IQApp$IQAppStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp.IQAppStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Garmin.Android.Connectiq.IQApp __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_version;
#pragma warning disable 0169
		static Delegate GetVersionHandler ()
		{
			if (cb_version == null)
				cb_version = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Version);
			return cb_version;
		}

		static int n_Version (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQApp __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/method[@name='version' and count(parameter)=0]"
		[Register ("version", "()I", "GetVersionHandler")]
		public virtual unsafe int Version ()
		{
			const string __id = "version.()I";
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
			global::Com.Garmin.Android.Connectiq.IQApp __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQApp']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
