using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Garmin.Android.Connectiq {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']"
	[global::Android.Runtime.Register ("com/garmin/android/connectiq/ConnectIQStateManager", DoNotGenerateAcw=true)]
	public partial class ConnectIQStateManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/garmin/android/connectiq/ConnectIQStateManager", typeof (ConnectIQStateManager));
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

		protected ConnectIQStateManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApplicationInfoListener;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfoListenerHandler ()
		{
			if (cb_getApplicationInfoListener == null)
				cb_getApplicationInfoListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationInfoListener);
			return cb_getApplicationInfoListener;
		}

		static IntPtr n_GetApplicationInfoListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationInfoListener);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_Handler ()
		{
			if (cb_setApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_ == null)
				cb_setApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_);
			return cb_setApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_;
		}

		static void n_SetApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationInfoListener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener ApplicationInfoListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']/method[@name='getApplicationInfoListener' and count(parameter)=0]"
			[Register ("getApplicationInfoListener", "()Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener;", "GetGetApplicationInfoListenerHandler")]
			get {
				const string __id = "getApplicationInfoListener.()Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']/method[@name='setApplicationInfoListener' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.ConnectIQ.IQApplicationInfoListener']]"
			[Register ("setApplicationInfoListener", "(Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener;)V", "GetSetApplicationInfoListener_Lcom_garmin_android_connectiq_ConnectIQ_IQApplicationInfoListener_Handler")]
			set {
				const string __id = "setApplicationInfoListener.(Lcom/garmin/android/connectiq/ConnectIQ$IQApplicationInfoListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Garmin.Android.Connectiq.ConnectIQStateManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/garmin/android/connectiq/ConnectIQStateManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/garmin/android/connectiq/ConnectIQStateManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQStateManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOpenApplicationListener;
#pragma warning disable 0169
		static Delegate GetGetOpenApplicationListenerHandler ()
		{
			if (cb_getOpenApplicationListener == null)
				cb_getOpenApplicationListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenApplicationListener);
			return cb_getOpenApplicationListener;
		}

		static IntPtr n_GetOpenApplicationListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenApplicationListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_;
#pragma warning disable 0169
		static Delegate GetSetOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_Handler ()
		{
			if (cb_setOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_ == null)
				cb_setOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_);
			return cb_setOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_;
		}

		static void n_SetOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OpenApplicationListener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener OpenApplicationListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']/method[@name='getOpenApplicationListener' and count(parameter)=0]"
			[Register ("getOpenApplicationListener", "()Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener;", "GetGetOpenApplicationListenerHandler")]
			get {
				const string __id = "getOpenApplicationListener.()Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']/method[@name='setOpenApplicationListener' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.ConnectIQ.IQOpenApplicationListener']]"
			[Register ("setOpenApplicationListener", "(Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener;)V", "GetSetOpenApplicationListener_Lcom_garmin_android_connectiq_ConnectIQ_IQOpenApplicationListener_Handler")]
			set {
				const string __id = "setOpenApplicationListener.(Lcom/garmin/android/connectiq/ConnectIQ$IQOpenApplicationListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSendMessageListener;
#pragma warning disable 0169
		static Delegate GetGetSendMessageListenerHandler ()
		{
			if (cb_getSendMessageListener == null)
				cb_getSendMessageListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSendMessageListener);
			return cb_getSendMessageListener;
		}

		static IntPtr n_GetSendMessageListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SendMessageListener);
		}
#pragma warning restore 0169

		static Delegate cb_setSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_;
#pragma warning disable 0169
		static Delegate GetSetSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler ()
		{
			if (cb_setSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ == null)
				cb_setSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_);
			return cb_setSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_;
		}

		static void n_SetSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Garmin.Android.Connectiq.ConnectIQStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener listener = (global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener)global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageListener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener SendMessageListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']/method[@name='getSendMessageListener' and count(parameter)=0]"
			[Register ("getSendMessageListener", "()Lcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;", "GetGetSendMessageListenerHandler")]
			get {
				const string __id = "getSendMessageListener.()Lcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.android.connectiq']/class[@name='ConnectIQStateManager']/method[@name='setSendMessageListener' and count(parameter)=1 and parameter[1][@type='com.garmin.android.connectiq.ConnectIQ.IQSendMessageListener']]"
			[Register ("setSendMessageListener", "(Lcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V", "GetSetSendMessageListener_Lcom_garmin_android_connectiq_ConnectIQ_IQSendMessageListener_Handler")]
			set {
				const string __id = "setSendMessageListener.(Lcom/garmin/android/connectiq/ConnectIQ$IQSendMessageListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

#region "Event implementation for Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener"
		public event EventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.ApplicationInfoReceivedEventArgs> ApplicationInfoReceived {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor>(
						ref weak_implementor___SetApplicationInfoListener,
						__CreateIQApplicationInfoListenerImplementor,
						__v => ApplicationInfoListener = __v,
						__h => __h.OnApplicationInfoReceivedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor>(
						ref weak_implementor___SetApplicationInfoListener,
						global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor.__IsEmpty,
						__v => ApplicationInfoListener = null,
						__h => __h.OnApplicationInfoReceivedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.ApplicationNotInstalledEventArgs> ApplicationNotInstalled {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor>(
						ref weak_implementor___SetApplicationInfoListener,
						__CreateIQApplicationInfoListenerImplementor,
						__v => ApplicationInfoListener = __v,
						__h => __h.OnApplicationNotInstalledHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor>(
						ref weak_implementor___SetApplicationInfoListener,
						global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor.__IsEmpty,
						__v => ApplicationInfoListener = null,
						__h => __h.OnApplicationNotInstalledHandler -= value);
			}
		}

		WeakReference weak_implementor___SetApplicationInfoListener;

		global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor __CreateIQApplicationInfoListenerImplementor ()
		{
			return new global::Com.Garmin.Android.Connectiq.ConnectIQ.IQApplicationInfoListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener"
		public event EventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.QOpenApplicationEventArgs> OpenApplication {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListenerImplementor>(
						ref weak_implementor___SetOpenApplicationListener,
						__CreateIQOpenApplicationListenerImplementor,
						__v => OpenApplicationListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListenerImplementor>(
						ref weak_implementor___SetOpenApplicationListener,
						global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListenerImplementor.__IsEmpty,
						__v => OpenApplicationListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOpenApplicationListener;

		global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListenerImplementor __CreateIQOpenApplicationListenerImplementor ()
		{
			return new global::Com.Garmin.Android.Connectiq.ConnectIQ.IQOpenApplicationListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener"
		public event EventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.QSendMessageEventArgs> SendMessage {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListenerImplementor>(
						ref weak_implementor___SetSendMessageListener,
						__CreateIQSendMessageListenerImplementor,
						__v => SendMessageListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListener, global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListenerImplementor>(
						ref weak_implementor___SetSendMessageListener,
						global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListenerImplementor.__IsEmpty,
						__v => SendMessageListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetSendMessageListener;

		global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListenerImplementor __CreateIQSendMessageListenerImplementor ()
		{
			return new global::Com.Garmin.Android.Connectiq.ConnectIQ.IQSendMessageListenerImplementor (this);
		}
#endregion
	}
}
