using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']"
	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/MonkeyType", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class MonkeyType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='ARRAY']"
		[Register ("ARRAY")]
		public const sbyte Array = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='BOOLEAN']"
		[Register ("BOOLEAN")]
		public const sbyte Boolean = (sbyte) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='CHAR']"
		[Register ("CHAR")]
		public const sbyte Char = (sbyte) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='DOUBLE']"
		[Register ("DOUBLE")]
		public const sbyte Double = (sbyte) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='FLOAT']"
		[Register ("FLOAT")]
		public const sbyte Float = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='HASH']"
		[Register ("HASH")]
		public const sbyte Hash = (sbyte) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='INT']"
		[Register ("INT")]
		public const sbyte Int = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='LONG']"
		[Register ("LONG")]
		public const sbyte Long = (sbyte) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='NULL']"
		[Register ("NULL")]
		public const sbyte Null = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='STRING']"
		[Register ("STRING")]
		public const sbyte String = (sbyte) 3;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/field[@name='mType']"
		[Register ("mType")]
		public sbyte MType {
			get {
				const string __id = "mType.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mType.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/MonkeyType", typeof (MonkeyType));
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

		protected MonkeyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/constructor[@name='MonkeyType' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe MonkeyType (sbyte type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyType __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumBytes;
		}
#pragma warning restore 0169

		public abstract int NumBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='getNumBytes' and count(parameter)=0]"
			[Register ("getNumBytes", "()I", "GetGetNumBytesHandler")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='deserialize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("deserialize", "([B)Lcom/garmin/monkeybrains/serialization/MonkeyType;", "")]
		public static unsafe global::Com.Garmin.Monkeybrains.Serialization.MonkeyType Deserialize (byte[] bytes)
		{
			const string __id = "deserialize.([B)Lcom/garmin/monkeybrains/serialization/MonkeyType;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='fromJava' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("fromJava", "(Ljava/lang/Object;)Lcom/garmin/monkeybrains/serialization/MonkeyType;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Garmin.Monkeybrains.Serialization.MonkeyType FromJava (global::Java.Lang.Object obj)
		{
			const string __id = "fromJava.(Ljava/lang/Object;)Lcom/garmin/monkeybrains/serialization/MonkeyType;";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
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
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyType __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Serialize ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='serialize' and count(parameter)=0]"
		[Register ("serialize", "()[B", "GetSerializeHandler")]
		public abstract byte[] Serialize ();

		static Delegate cb_toJava;
#pragma warning disable 0169
		static Delegate GetToJavaHandler ()
		{
			if (cb_toJava == null)
				cb_toJava = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJava);
			return cb_toJava;
		}

		static IntPtr n_ToJava (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyType __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJava ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='toJava' and count(parameter)=0]"
		[Register ("toJava", "()Ljava/lang/Object;", "GetToJavaHandler")]
		public abstract global::Java.Lang.Object ToJava ();

	}

	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/MonkeyType", DoNotGenerateAcw=true)]
	internal partial class MonkeyTypeInvoker : MonkeyType {

		public MonkeyTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/MonkeyType", typeof (MonkeyTypeInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int NumBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='getNumBytes' and count(parameter)=0]"
			[Register ("getNumBytes", "()I", "GetGetNumBytesHandler")]
			get {
				const string __id = "getNumBytes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='serialize' and count(parameter)=0]"
		[Register ("serialize", "()[B", "GetSerializeHandler")]
		public override unsafe byte[] Serialize ()
		{
			const string __id = "serialize.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyType']/method[@name='toJava' and count(parameter)=0]"
		[Register ("toJava", "()Ljava/lang/Object;", "GetToJavaHandler")]
		public override unsafe global::Java.Lang.Object ToJava ()
		{
			const string __id = "toJava.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
