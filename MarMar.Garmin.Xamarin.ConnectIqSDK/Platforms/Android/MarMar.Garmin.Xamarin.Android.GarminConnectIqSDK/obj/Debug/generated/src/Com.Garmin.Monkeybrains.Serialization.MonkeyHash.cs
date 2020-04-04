using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']"
	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/MonkeyHash", DoNotGenerateAcw=true)]
	public partial class MonkeyHash : global::Com.Garmin.Monkeybrains.Serialization.MonkeyType, global::Com.Garmin.Monkeybrains.Serialization.IMonkeyContainer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/MonkeyHash", typeof (MonkeyHash));
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

		protected MonkeyHash (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/constructor[@name='MonkeyHash' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe MonkeyHash (byte[] bytes)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/constructor[@name='MonkeyHash' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Object, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe MonkeyHash (global::System.Collections.Generic.IDictionary<global::Java.Lang.Object, global::Java.Lang.Object> hash)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_hash = global::Android.Runtime.JavaDictionary<global::Java.Lang.Object, global::Java.Lang.Object>.ToLocalJniHandle (hash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hash);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hash);
			}
		}

		static Delegate cb_getChildCount;
#pragma warning disable 0169
		static Delegate GetGetChildCountHandler ()
		{
			if (cb_getChildCount == null)
				cb_getChildCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChildCount);
			return cb_getChildCount;
		}

		static int n_GetChildCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChildCount;
		}
#pragma warning restore 0169

		public virtual unsafe int ChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/method[@name='getChildCount' and count(parameter)=0]"
			[Register ("getChildCount", "()I", "GetGetChildCountHandler")]
			get {
				const string __id = "getChildCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getChildren;
#pragma warning disable 0169
		static Delegate GetGetChildrenHandler ()
		{
			if (cb_getChildren == null)
				cb_getChildren = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildren);
			return cb_getChildren;
		}

		static IntPtr n_GetChildren (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.ToLocalJniHandle (__this.Children);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> Children {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/method[@name='getChildren' and count(parameter)=0]"
			[Register ("getChildren", "()Ljava/util/List;", "GetGetChildrenHandler")]
			get {
				const string __id = "getChildren.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHashMap;
#pragma warning disable 0169
		static Delegate GetGetHashMapHandler ()
		{
			if (cb_getHashMap == null)
				cb_getHashMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHashMap);
			return cb_getHashMap;
		}

		static IntPtr n_GetHashMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType, global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.ToLocalJniHandle (__this.HashMap);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType, global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> HashMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/method[@name='getHashMap' and count(parameter)=0]"
			[Register ("getHashMap", "()Ljava/util/HashMap;", "GetGetHashMapHandler")]
			get {
				const string __id = "getHashMap.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType, global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumBytes;
		}
#pragma warning restore 0169

		public override unsafe int NumBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/method[@name='getNumBytes' and count(parameter)=0]"
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
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Serialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/method[@name='serialize' and count(parameter)=0]"
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

	}
}
