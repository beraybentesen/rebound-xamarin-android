using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SimpleSpringListener']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SimpleSpringListener", DoNotGenerateAcw=true)]
	public partial class SimpleSpringListener : global::Java.Lang.Object, global::Com.Facebook.Rebound.ISpringListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SimpleSpringListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleSpringListener); }
		}

		protected SimpleSpringListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SimpleSpringListener']/constructor[@name='SimpleSpringListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleSpringListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SimpleSpringListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_onSpringActivate_Lcom_facebook_rebound_Spring_;
#pragma warning disable 0169
		static Delegate GetOnSpringActivate_Lcom_facebook_rebound_Spring_Handler ()
		{
			if (cb_onSpringActivate_Lcom_facebook_rebound_Spring_ == null)
				cb_onSpringActivate_Lcom_facebook_rebound_Spring_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSpringActivate_Lcom_facebook_rebound_Spring_);
			return cb_onSpringActivate_Lcom_facebook_rebound_Spring_;
		}

		static void n_OnSpringActivate_Lcom_facebook_rebound_Spring_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.SimpleSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SimpleSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringActivate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringActivate_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SimpleSpringListener']/method[@name='onSpringActivate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringActivate", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringActivate_Lcom_facebook_rebound_Spring_Handler")]
		public virtual unsafe void OnSpringActivate (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringActivate_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringActivate_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringActivate", "(Lcom/facebook/rebound/Spring;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringActivate_Lcom_facebook_rebound_Spring_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSpringActivate", "(Lcom/facebook/rebound/Spring;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSpringAtRest_Lcom_facebook_rebound_Spring_;
#pragma warning disable 0169
		static Delegate GetOnSpringAtRest_Lcom_facebook_rebound_Spring_Handler ()
		{
			if (cb_onSpringAtRest_Lcom_facebook_rebound_Spring_ == null)
				cb_onSpringAtRest_Lcom_facebook_rebound_Spring_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSpringAtRest_Lcom_facebook_rebound_Spring_);
			return cb_onSpringAtRest_Lcom_facebook_rebound_Spring_;
		}

		static void n_OnSpringAtRest_Lcom_facebook_rebound_Spring_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.SimpleSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SimpleSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringAtRest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringAtRest_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SimpleSpringListener']/method[@name='onSpringAtRest' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringAtRest", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringAtRest_Lcom_facebook_rebound_Spring_Handler")]
		public virtual unsafe void OnSpringAtRest (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringAtRest_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringAtRest_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringAtRest", "(Lcom/facebook/rebound/Spring;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringAtRest_Lcom_facebook_rebound_Spring_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSpringAtRest", "(Lcom/facebook/rebound/Spring;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSpringEndStateChange_Lcom_facebook_rebound_Spring_;
#pragma warning disable 0169
		static Delegate GetOnSpringEndStateChange_Lcom_facebook_rebound_Spring_Handler ()
		{
			if (cb_onSpringEndStateChange_Lcom_facebook_rebound_Spring_ == null)
				cb_onSpringEndStateChange_Lcom_facebook_rebound_Spring_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSpringEndStateChange_Lcom_facebook_rebound_Spring_);
			return cb_onSpringEndStateChange_Lcom_facebook_rebound_Spring_;
		}

		static void n_OnSpringEndStateChange_Lcom_facebook_rebound_Spring_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.SimpleSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SimpleSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringEndStateChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SimpleSpringListener']/method[@name='onSpringEndStateChange' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringEndStateChange", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringEndStateChange_Lcom_facebook_rebound_Spring_Handler")]
		public virtual unsafe void OnSpringEndStateChange (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringEndStateChange", "(Lcom/facebook/rebound/Spring;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSpringEndStateChange", "(Lcom/facebook/rebound/Spring;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSpringUpdate_Lcom_facebook_rebound_Spring_;
#pragma warning disable 0169
		static Delegate GetOnSpringUpdate_Lcom_facebook_rebound_Spring_Handler ()
		{
			if (cb_onSpringUpdate_Lcom_facebook_rebound_Spring_ == null)
				cb_onSpringUpdate_Lcom_facebook_rebound_Spring_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSpringUpdate_Lcom_facebook_rebound_Spring_);
			return cb_onSpringUpdate_Lcom_facebook_rebound_Spring_;
		}

		static void n_OnSpringUpdate_Lcom_facebook_rebound_Spring_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.SimpleSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SimpleSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringUpdate_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SimpleSpringListener']/method[@name='onSpringUpdate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringUpdate", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringUpdate_Lcom_facebook_rebound_Spring_Handler")]
		public virtual unsafe void OnSpringUpdate (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringUpdate_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringUpdate_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringUpdate", "(Lcom/facebook/rebound/Spring;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringUpdate_Lcom_facebook_rebound_Spring_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSpringUpdate", "(Lcom/facebook/rebound/Spring;)V"), __args);
			} finally {
			}
		}

	}
}
