using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq.Adb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbDataHandler']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/adb/AdbDataHandler", DoNotGenerateAcw=true)]
	public partial class AdbDataHandler : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/adb/AdbDataHandler", typeof (AdbDataHandler));
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

		protected AdbDataHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbDataHandler']/constructor[@name='AdbDataHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdbDataHandler ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq.adb']/class[@name='AdbDataHandler']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]']]"
		[Register ("handleMessage", "(Landroid/content/Context;[B)V", "")]
		public static unsafe void HandleMessage (global::Android.Content.Context context, byte[] data)
		{
			const string __id = "handleMessage.(Landroid/content/Context;[B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
