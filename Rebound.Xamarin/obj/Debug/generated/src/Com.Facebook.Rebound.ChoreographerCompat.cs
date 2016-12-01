using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat']"
	[global::Android.Runtime.Register ("com/facebook/rebound/ChoreographerCompat", DoNotGenerateAcw=true)]
	public partial class ChoreographerCompat : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat.FrameCallback']"
		[global::Android.Runtime.Register ("com/facebook/rebound/ChoreographerCompat$FrameCallback", DoNotGenerateAcw=true)]
		public abstract partial class FrameCallback : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/rebound/ChoreographerCompat$FrameCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FrameCallback); }
			}

			protected FrameCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat.FrameCallback']/constructor[@name='ChoreographerCompat.FrameCallback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe FrameCallback ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (FrameCallback)) {
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

			static Delegate cb_doFrame_J;
#pragma warning disable 0169
			static Delegate GetDoFrame_JHandler ()
			{
				if (cb_doFrame_J == null)
					cb_doFrame_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DoFrame_J);
				return cb_doFrame_J;
			}

			static void n_DoFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DoFrame (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat.FrameCallback']/method[@name='doFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("doFrame", "(J)V", "GetDoFrame_JHandler")]
			public abstract void DoFrame (long p0);

		}

		[global::Android.Runtime.Register ("com/facebook/rebound/ChoreographerCompat$FrameCallback", DoNotGenerateAcw=true)]
		internal partial class FrameCallbackInvoker : FrameCallback {

			public FrameCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (FrameCallbackInvoker); }
			}

			static IntPtr id_doFrame_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat.FrameCallback']/method[@name='doFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("doFrame", "(J)V", "GetDoFrame_JHandler")]
			public override unsafe void DoFrame (long p0)
			{
				if (id_doFrame_J == IntPtr.Zero)
					id_doFrame_J = JNIEnv.GetMethodID (class_ref, "doFrame", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doFrame_J, __args);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/ChoreographerCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChoreographerCompat); }
		}

		protected ChoreographerCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Facebook.Rebound.ChoreographerCompat Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/facebook/rebound/ChoreographerCompat;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/facebook/rebound/ChoreographerCompat;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_;
#pragma warning disable 0169
		static Delegate GetPostFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_Handler ()
		{
			if (cb_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ == null)
				cb_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_);
			return cb_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_;
		}

		static void n_PostFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.ChoreographerCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostFrameCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat']/method[@name='postFrameCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.ChoreographerCompat.FrameCallback']]"
		[Register ("postFrameCallback", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;)V", "GetPostFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_Handler")]
		public virtual unsafe void PostFrameCallback (global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback p0)
		{
			if (id_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ == IntPtr.Zero)
				id_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ = JNIEnv.GetMethodID (class_ref, "postFrameCallback", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postFrameCallback", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J;
#pragma warning disable 0169
		static Delegate GetPostFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_JHandler ()
		{
			if (cb_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J == null)
				cb_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PostFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J);
			return cb_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J;
		}

		static void n_PostFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Facebook.Rebound.ChoreographerCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostFrameCallbackDelayed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat']/method[@name='postFrameCallbackDelayed' and count(parameter)=2 and parameter[1][@type='com.facebook.rebound.ChoreographerCompat.FrameCallback'] and parameter[2][@type='long']]"
		[Register ("postFrameCallbackDelayed", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;J)V", "GetPostFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_JHandler")]
		public virtual unsafe void PostFrameCallbackDelayed (global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback p0, long p1)
		{
			if (id_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J == IntPtr.Zero)
				id_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J = JNIEnv.GetMethodID (class_ref, "postFrameCallbackDelayed", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postFrameCallbackDelayed_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postFrameCallbackDelayed", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_Handler ()
		{
			if (cb_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ == null)
				cb_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_);
			return cb_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_;
		}

		static void n_RemoveFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.ChoreographerCompat __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFrameCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='ChoreographerCompat']/method[@name='removeFrameCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.ChoreographerCompat.FrameCallback']]"
		[Register ("removeFrameCallback", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;)V", "GetRemoveFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_Handler")]
		public virtual unsafe void RemoveFrameCallback (global::Com.Facebook.Rebound.ChoreographerCompat.FrameCallback p0)
		{
			if (id_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ == IntPtr.Zero)
				id_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_ = JNIEnv.GetMethodID (class_ref, "removeFrameCallback", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeFrameCallback_Lcom_facebook_rebound_ChoreographerCompat_FrameCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFrameCallback", "(Lcom/facebook/rebound/ChoreographerCompat$FrameCallback;)V"), __args);
			} finally {
			}
		}

	}
}
