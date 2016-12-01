using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SpringLooper", DoNotGenerateAcw=true)]
	public abstract partial class SpringLooper : global::Java.Lang.Object {


		static IntPtr mSpringSystem_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']/field[@name='mSpringSystem']"
		[Register ("mSpringSystem")]
		protected global::Com.Facebook.Rebound.BaseSpringSystem MSpringSystem {
			get {
				if (mSpringSystem_jfieldId == IntPtr.Zero)
					mSpringSystem_jfieldId = JNIEnv.GetFieldID (class_ref, "mSpringSystem", "Lcom/facebook/rebound/BaseSpringSystem;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSpringSystem_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSpringSystem_jfieldId == IntPtr.Zero)
					mSpringSystem_jfieldId = JNIEnv.GetFieldID (class_ref, "mSpringSystem", "Lcom/facebook/rebound/BaseSpringSystem;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSpringSystem_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SpringLooper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringLooper); }
		}

		protected SpringLooper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']/constructor[@name='SpringLooper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpringLooper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SpringLooper)) {
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

		static Delegate cb_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_;
#pragma warning disable 0169
		static Delegate GetSetSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_Handler ()
		{
			if (cb_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_ == null)
				cb_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_);
			return cb_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_;
		}

		static void n_SetSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.SpringLooper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.BaseSpringSystem p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSpringSystem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']/method[@name='setSpringSystem' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.BaseSpringSystem']]"
		[Register ("setSpringSystem", "(Lcom/facebook/rebound/BaseSpringSystem;)V", "GetSetSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_Handler")]
		public virtual unsafe void SetSpringSystem (global::Com.Facebook.Rebound.BaseSpringSystem p0)
		{
			if (id_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_ == IntPtr.Zero)
				id_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_ = JNIEnv.GetMethodID (class_ref, "setSpringSystem", "(Lcom/facebook/rebound/BaseSpringSystem;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpringSystem_Lcom_facebook_rebound_BaseSpringSystem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpringSystem", "(Lcom/facebook/rebound/BaseSpringSystem;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SpringLooper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public abstract void Start ();

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SpringLooper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public abstract void Stop ();

	}

	[global::Android.Runtime.Register ("com/facebook/rebound/SpringLooper", DoNotGenerateAcw=true)]
	internal partial class SpringLooperInvoker : SpringLooper {

		public SpringLooperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringLooperInvoker); }
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
			} finally {
			}
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringLooper']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
			} finally {
			}
		}

	}

}
