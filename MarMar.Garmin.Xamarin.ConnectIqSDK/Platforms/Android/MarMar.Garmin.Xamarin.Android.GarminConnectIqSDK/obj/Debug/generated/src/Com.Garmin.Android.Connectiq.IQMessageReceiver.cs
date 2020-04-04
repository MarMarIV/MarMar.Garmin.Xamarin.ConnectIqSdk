using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/IQMessageReceiver", DoNotGenerateAcw=true)]
	public partial class IQMessageReceiver : global::Android.Content.BroadcastReceiver {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/IQMessageReceiver", typeof (IQMessageReceiver));
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

		protected IQMessageReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']/constructor[@name='IQMessageReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IQMessageReceiver ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']/constructor[@name='IQMessageReceiver' and count(parameter)=2 and parameter[1][@type='com.garmin.android.connectiq.ConnectIQ.IQDeviceEventListener'] and parameter[2][@type='com.garmin.android.connectiq.ConnectIQ.IQApplicationEventListener']]"
		[Register (".ctor", "(Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V", "")]
		public unsafe IQMessageReceiver (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener listener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener applistener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue ((applistener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applistener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAppListener;
#pragma warning disable 0169
		static Delegate GetGetAppListenerHandler ()
		{
			if (cb_getAppListener == null)
				cb_getAppListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppListener);
			return cb_getAppListener;
		}

		static IntPtr n_GetAppListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppListener);
		}
#pragma warning restore 0169

		static Delegate cb_setAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_;
#pragma warning disable 0169
		static Delegate GetSetAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_Handler ()
		{
			if (cb_setAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ == null)
				cb_setAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_);
			return cb_setAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_;
		}

		static void n_SetAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_applistener)
		{
			global::Com.Garmin.Android.Connectiq.IQMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener applistener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener> (native_applistener, JniHandleOwnership.DoNotTransfer);
			__this.AppListener = applistener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener AppListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']/method[@name='getAppListener' and count(parameter)=0]"
			[Register ("getAppListener", "()Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;", "GetGetAppListenerHandler")]
			get {
				const string __id = "getAppListener.()Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']/method[@name='setAppListener' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.ConnectIQ.IQApplicationEventListener']]"
			[Register ("setAppListener", "(Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V", "GetSetAppListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationEventListener_Handler")]
			set {
				const string __id = "setAppListener.(Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationEventListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.IQMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Handler ()
		{
			if (cb_setListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_ == null)
				cb_setListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_);
			return cb_setListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_;
		}

		static void n_SetListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.IQMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Listener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;", "GetGetListenerHandler")]
			get {
				const string __id = "getListener.()Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.ConnectIQ.IQDeviceEventListener']]"
			[Register ("setListener", "(Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;)V", "GetSetListener_Lcom_garmin_android_connectiq_ConnectIQ_IQDeviceEventListener_Handler")]
			set {
				const string __id = "setListener.(Lcom/garmin/android/connectiq/ConnectIQ$IQDeviceEventListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			global::Com.Garmin.Android.Connectiq.IQMessageReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.IQMessageReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (context, intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='IQMessageReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener"
		public event EventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.QApplicationEventEventArgs> App {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListenerImplementor>(
						ref weak_implementor___SetAppListener,
						__CreateIQApplicationEventListenerImplementor,
						__v => AppListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListenerImplementor>(
						ref weak_implementor___SetAppListener,
						global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListenerImplementor.__IsEmpty,
						__v => AppListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetAppListener;

		global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListenerImplementor __CreateIQApplicationEventListenerImplementor ()
		{
			return new global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationEventListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListener"

		global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListenerImplementor __CreateIQDeviceEventListenerImplementor ()
		{
			return new global::Com.Garmin.Android.Connectiq.ConnectIQ.IQDeviceEventListenerImplementor (this);
		}
#endregion
	}
}
