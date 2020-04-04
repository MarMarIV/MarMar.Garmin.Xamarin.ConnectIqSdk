using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='SerializedObject']"
	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/SerializedObject", DoNotGenerateAcw=true)]
	public partial class SerializedObject : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/SerializedObject", typeof (SerializedObject));
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

		protected SerializedObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='SerializedObject']/constructor[@name='SerializedObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SerializedObject ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='SerializedObject']/constructor[@name='SerializedObject' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe SerializedObject (byte[] bytes)
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

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.SerializedObject __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.SerializedObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.ToLocalJniHandle (__this.Values);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> Values {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='SerializedObject']/method[@name='getValues' and count(parameter)=0]"
			[Register ("getValues", "()Ljava/util/List;", "GetGetValuesHandler")]
			get {
				const string __id = "getValues.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_;
#pragma warning disable 0169
		static Delegate GetAddObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_Handler ()
		{
			if (cb_addObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_ == null)
				cb_addObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_);
			return cb_addObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_;
		}

		static void n_AddObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Garmin.Monkeybrains.Serialization.SerializedObject __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.SerializedObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyType type = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.AddObject (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='SerializedObject']/method[@name='addObject' and count(parameter)=1 and parameter[1][@type='com.garmin.monkeybrains.serialization.MonkeyType&lt;?&gt;']]"
		[Register ("addObject", "(Lcom/garmin/monkeybrains/serialization/MonkeyType;)V", "GetAddObject_Lcom_garmin_monkeybrains_serialization_MonkeyType_Handler")]
		public virtual unsafe void AddObject (global::Com.Garmin.Monkeybrains.Serialization.MonkeyType type)
		{
			const string __id = "addObject.(Lcom/garmin/monkeybrains/serialization/MonkeyType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Garmin.Monkeybrains.Serialization.SerializedObject __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.SerializedObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Serialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='SerializedObject']/method[@name='serialize' and count(parameter)=0]"
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
