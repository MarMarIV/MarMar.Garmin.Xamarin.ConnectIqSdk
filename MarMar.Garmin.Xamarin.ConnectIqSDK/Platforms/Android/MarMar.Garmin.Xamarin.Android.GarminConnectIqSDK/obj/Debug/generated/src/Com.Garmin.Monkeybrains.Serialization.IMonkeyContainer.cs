using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Monkeybrains.Serialization {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/interface[@name='MonkeyContainer']"
	[Register ("com/garmin/monkeybrains/serialization/MonkeyContainer", "", "Com.Garmin.Monkeybrains.Serialization.IMonkeyContainerInvoker")]
	public partial interface IMonkeyContainer : IJavaObject, IJavaPeerable {

		int ChildCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/interface[@name='MonkeyContainer']/method[@name='getChildCount' and count(parameter)=0]"
			[Register ("getChildCount", "()I", "GetGetChildCountHandler:Com.Garmin.Monkeybrains.Serialization.IMonkeyContainerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> Children {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/interface[@name='MonkeyContainer']/method[@name='getChildren' and count(parameter)=0]"
			[Register ("getChildren", "()Ljava/util/List;", "GetGetChildrenHandler:Com.Garmin.Monkeybrains.Serialization.IMonkeyContainerInvoker, MarMar.Garmin.Xamarin.Android.GarminConnectIqSDK")] get;
		}

	}

	[global::Android.Runtime.Register ("com/garmin/monkeybrains/serialization/MonkeyContainer", DoNotGenerateAcw=true)]
	internal partial class IMonkeyContainerInvoker : global::Java.Lang.Object, IMonkeyContainer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/monkeybrains/serialization/MonkeyContainer", typeof (IMonkeyContainerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMonkeyContainer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMonkeyContainer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.garmin.monkeybrains.serialization.MonkeyContainer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMonkeyContainerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Garmin.Monkeybrains.Serialization.IMonkeyContainer __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.IMonkeyContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChildCount;
		}
#pragma warning restore 0169

		IntPtr id_getChildCount;
		public unsafe int ChildCount {
			get {
				if (id_getChildCount == IntPtr.Zero)
					id_getChildCount = JNIEnv.GetMethodID (class_ref, "getChildCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChildCount);
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
			global::Com.Garmin.Monkeybrains.Serialization.IMonkeyContainer __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.IMonkeyContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.ToLocalJniHandle (__this.Children);
		}
#pragma warning restore 0169

		IntPtr id_getChildren;
		public unsafe global::System.Collections.Generic.IList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType> Children {
			get {
				if (id_getChildren == IntPtr.Zero)
					id_getChildren = JNIEnv.GetMethodID (class_ref, "getChildren", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChildren), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
