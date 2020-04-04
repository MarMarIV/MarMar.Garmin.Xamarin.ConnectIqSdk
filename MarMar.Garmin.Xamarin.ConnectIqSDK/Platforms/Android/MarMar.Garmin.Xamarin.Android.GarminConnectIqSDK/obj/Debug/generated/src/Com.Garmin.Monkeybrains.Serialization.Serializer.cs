using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='Serializer']"
	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/Serializer", DoNotGenerateAcw=true)]
	public partial class Serializer : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/Serializer", typeof (Serializer));
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

		protected Serializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='Serializer']/constructor[@name='Serializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Serializer ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='Serializer']/constructor[@name='Serializer' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe Serializer (global::Java.Lang.Object obj)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddObject_Ljava_lang_Object_Handler ()
		{
			if (cb_addObject_Ljava_lang_Object_ == null)
				cb_addObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddObject_Ljava_lang_Object_);
			return cb_addObject_Ljava_lang_Object_;
		}

		static void n_AddObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Com.Garmin.Monkeybrains.Serialization.Serializer __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.AddObject (obj);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='Serializer']/method[@name='addObject' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("addObject", "(Ljava/lang/Object;)V", "GetAddObject_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe void AddObject (global::Java.Lang.Object obj)
		{
			const string __id = "addObject.(Ljava/lang/Object;)V";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='Serializer']/method[@name='deserialize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("deserialize", "([B)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> Deserialize (byte[] bytes)
		{
			const string __id = "deserialize.([B)Ljava/util/List;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
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
			global::Com.Garmin.Monkeybrains.Serialization.Serializer __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.Serializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Serialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='Serializer']/method[@name='serialize' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='Serializer']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("serialize", "(Ljava/lang/Object;)[B", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe byte[] Serialize (global::Java.Lang.Object obj)
		{
			const string __id = "serialize.(Ljava/lang/Object;)[B";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

	}
}
