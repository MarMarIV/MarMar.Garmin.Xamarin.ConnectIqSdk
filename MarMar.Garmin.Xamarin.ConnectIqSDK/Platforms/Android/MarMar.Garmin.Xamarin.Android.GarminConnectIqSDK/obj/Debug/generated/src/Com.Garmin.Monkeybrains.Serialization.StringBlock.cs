using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='StringBlock']"
	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/StringBlock", DoNotGenerateAcw=true)]
	public partial class StringBlock : global::Java.Util.ArrayList {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/StringBlock", typeof (StringBlock));
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

		protected StringBlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='StringBlock']/constructor[@name='StringBlock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringBlock ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='StringBlock']/constructor[@name='StringBlock' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe StringBlock (byte[] bytes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
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

		static Delegate cb_getDeserializedStrings;
#pragma warning disable 0169
		static Delegate GetGetDeserializedStringsHandler ()
		{
			if (cb_getDeserializedStrings == null)
				cb_getDeserializedStrings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeserializedStrings);
			return cb_getDeserializedStrings;
		}

		static IntPtr n_GetDeserializedStrings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.StringBlock __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.StringBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, string>.ToLocalJniHandle (__this.DeserializedStrings);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, string> DeserializedStrings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='StringBlock']/method[@name='getDeserializedStrings' and count(parameter)=0]"
			[Register ("getDeserializedStrings", "()Ljava/util/HashMap;", "GetGetDeserializedStringsHandler")]
			get {
				const string __id = "getDeserializedStrings.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addString_Lcom_garmin_monkeybrains_serialization_MonkeyString_;
#pragma warning disable 0169
		static Delegate GetAddString_Lcom_garmin_monkeybrains_serialization_MonkeyString_Handler ()
		{
			if (cb_addString_Lcom_garmin_monkeybrains_serialization_MonkeyString_ == null)
				cb_addString_Lcom_garmin_monkeybrains_serialization_MonkeyString_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_AddString_Lcom_garmin_monkeybrains_serialization_MonkeyString_);
			return cb_addString_Lcom_garmin_monkeybrains_serialization_MonkeyString_;
		}

		static int n_AddString_Lcom_garmin_monkeybrains_serialization_MonkeyString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Garmin.Monkeybrains.Serialization.StringBlock __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.StringBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString type = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (native_type, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddString (type);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='StringBlock']/method[@name='addString' and count(parameter)=1 and parameter[1][@type='com.garmin.monkeybrains.serialization.MonkeyString']]"
		[Register ("addString", "(Lcom/garmin/monkeybrains/serialization/MonkeyString;)I", "GetAddString_Lcom_garmin_monkeybrains_serialization_MonkeyString_Handler")]
		public virtual unsafe int AddString (global::Com.Garmin.Monkeybrains.Serialization.MonkeyString type)
		{
			const string __id = "addString.(Lcom/garmin/monkeybrains/serialization/MonkeyString;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
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
			global::Com.Garmin.Monkeybrains.Serialization.StringBlock __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.StringBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Serialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='StringBlock']/method[@name='serialize' and count(parameter)=0]"
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
