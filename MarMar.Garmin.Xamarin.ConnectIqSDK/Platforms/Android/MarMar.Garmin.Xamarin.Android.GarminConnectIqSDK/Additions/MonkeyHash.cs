using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Garmin.Monkeybrains.Serialization
{
	public partial class MonkeyHash : global::Com.Garmin.Monkeybrains.Serialization.MonkeyType, global::Com.Garmin.Monkeybrains.Serialization.IMonkeyContainer
	{
		static Delegate cb_toJava;
#pragma warning disable 0169
		static Delegate GetToJavaHandler()
		{
			if (cb_toJava == null)
				cb_toJava = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_ToJava);
			return cb_toJava;
		}

		static IntPtr n_ToJava(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash __this = global::Java.Lang.Object.GetObject<global::Com.Garmin.Monkeybrains.Serialization.MonkeyHash>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType, global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.ToLocalJniHandle((System.Collections.IDictionary)__this.ToJava());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.garmin.monkeybrains.serialization']/class[@name='MonkeyHash']/method[@name='toJava' and count(parameter)=0]"
		[Register("toJava", "()Ljava/util/HashMap;", "GetToJavaHandler")]
		public override unsafe global::Java.Lang.Object ToJava()
		{
			const string __id = "toJava.()Ljava/util/HashMap;";
			try
			{
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
				return (global::Java.Lang.Object)global::Android.Runtime.JavaDictionary<global::Com.Garmin.Monkeybrains.Serialization.MonkeyType, global::Com.Garmin.Monkeybrains.Serialization.MonkeyType>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}
}