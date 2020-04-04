using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='DataBlock']"
	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/DataBlock", DoNotGenerateAcw=true)]
	public partial class DataBlock : global::Java.Util.ArrayList {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/DataBlock", typeof (DataBlock));
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

		protected DataBlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='DataBlock']/constructor[@name='DataBlock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataBlock ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='DataBlock']/constructor[@name='DataBlock' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.garmin.monkeybrains.serialization.StringBlock']]"
		[Register (".ctor", "([BLcom/garmin/monkeybrains/serialization/StringBlock;)V", "")]
		public unsafe DataBlock (byte[] bytes, global::Com.Garmin.Monkeybrains.Serialization.StringBlock stringBlock)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BLcom/garmin/monkeybrains/serialization/StringBlock;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue ((stringBlock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stringBlock).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_add_Lcom_garmin_monkeybrains_serialization_MonkeyType_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_garmin_monkeybrains_serialization_MonkeyType_Handler ()
		{
			if (cb_add_Lcom_garmin_monkeybrains_serialization_MonkeyType_ == null)
				cb_add_Lcom_garmin_monkeybrains_serialization_MonkeyType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Lcom_garmin_monkeybrains_serialization_MonkeyType_);
			return cb_add_Lcom_garmin_monkeybrains_serialization_MonkeyType_;
		}

		static bool n_Add_Lcom_garmin_monkeybrains_serialization_MonkeyType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Garmin.Monkeybrains.Serialization.DataBlock __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.DataBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyType type = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> (native_type, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (type);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='DataBlock']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.garmin.monkeybrains.serialization.MonkeyType&lt;?&gt;']]"
		[Register ("add", "(Lcom/garmin/monkeybrains/serialization/MonkeyType;)Z", "GetAdd_Lcom_garmin_monkeybrains_serialization_MonkeyType_Handler")]
		public virtual unsafe bool Add (global::Com.Garmin.Monkeybrains.Serialization.MonkeyType type)
		{
			const string __id = "add.(Lcom/garmin/monkeybrains/serialization/MonkeyType;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_serialize;
#pragma warning disable 0169
		static Delegate GetSerializeHandler ()
		{
			if (cb_serialize == null)
				cb_serialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Serialize);
			return cb_serialize;
		}

		static IntPtr n_Serialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.DataBlock __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.DataBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Serialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='DataBlock']/method[@name='serialize' and count(parameter)=0]"
		[Register ("serialize", "()[B", "GetSerializeHandler")]
		public virtual unsafe byte[] Serialize ()
		{
			const string __id = "serialize.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
