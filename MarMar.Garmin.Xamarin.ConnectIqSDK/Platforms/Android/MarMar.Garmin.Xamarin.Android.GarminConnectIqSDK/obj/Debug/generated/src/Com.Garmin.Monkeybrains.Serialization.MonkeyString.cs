using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']"
	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/MonkeyString", DoNotGenerateAcw=true)]
	public partial class MonkeyString : global::Com.Garmin.Monkeybrains.Serialization.MonkeyType {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/MonkeyString", typeof (MonkeyString));
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

		protected MonkeyString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/constructor[@name='MonkeyString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe MonkeyString (byte[] bytes)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/constructor[@name='MonkeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MonkeyString (string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getNumBytes;
#pragma warning disable 0169
		static Delegate GetGetNumBytesHandler ()
		{
			if (cb_getNumBytes == null)
				cb_getNumBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumBytes);
			return cb_getNumBytes;
		}

		static int n_GetNumBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumBytes;
		}
#pragma warning restore 0169

		public override unsafe int NumBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/method[@name='getNumBytes' and count(parameter)=0]"
			[Register ("getNumBytes", "()I", "GetGetNumBytesHandler")]
			get {
				const string __id = "getNumBytes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOffset);
			return cb_getOffset;
		}

		static int n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_I;
#pragma warning disable 0169
		static Delegate GetSetOffset_IHandler ()
		{
			if (cb_setOffset_I == null)
				cb_setOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOffset_I);
			return cb_setOffset_I;
		}

		static void n_SetOffset_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offset = offset;
		}
#pragma warning restore 0169

		public virtual unsafe int Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()I", "GetGetOffsetHandler")]
			get {
				const string __id = "getOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOffset", "(I)V", "GetSetOffset_IHandler")]
			set {
				const string __id = "setOffset.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_;
		}

		static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__string)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString (native__string, JniHandleOwnership.DoNotTransfer);
			__this.Value = @string;
		}
#pragma warning restore 0169

		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")]
			set {
				const string __id = "setValue.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Serialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/method[@name='serialize' and count(parameter)=0]"
		[Register ("serialize", "()[B", "GetSerializeHandler")]
		public override unsafe byte[] Serialize ()
		{
			const string __id = "serialize.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_serializeString;
#pragma warning disable 0169
		static Delegate GetSerializeStringHandler ()
		{
			if (cb_serializeString == null)
				cb_serializeString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SerializeString);
			return cb_serializeString;
		}

		static IntPtr n_SerializeString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyString __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.SerializeString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyString']/method[@name='serializeString' and count(parameter)=0]"
		[Register ("serializeString", "()[B", "GetSerializeStringHandler")]
		public virtual unsafe byte[] SerializeString ()
		{
			const string __id = "serializeString.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
