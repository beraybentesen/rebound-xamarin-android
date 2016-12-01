using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringListener']"
	[Register ("com/facebook/rebound/SpringListener", "", "Com.Facebook.Rebound.ISpringListenerInvoker")]
	public partial interface ISpringListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringListener']/method[@name='onSpringActivate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringActivate", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringActivate_Lcom_facebook_rebound_Spring_Handler:Com.Facebook.Rebound.ISpringListenerInvoker, Rebound.Xamarin")]
		void OnSpringActivate (global::Com.Facebook.Rebound.Spring p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringListener']/method[@name='onSpringAtRest' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringAtRest", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringAtRest_Lcom_facebook_rebound_Spring_Handler:Com.Facebook.Rebound.ISpringListenerInvoker, Rebound.Xamarin")]
		void OnSpringAtRest (global::Com.Facebook.Rebound.Spring p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringListener']/method[@name='onSpringEndStateChange' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringEndStateChange", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringEndStateChange_Lcom_facebook_rebound_Spring_Handler:Com.Facebook.Rebound.ISpringListenerInvoker, Rebound.Xamarin")]
		void OnSpringEndStateChange (global::Com.Facebook.Rebound.Spring p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringListener']/method[@name='onSpringUpdate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
		[Register ("onSpringUpdate", "(Lcom/facebook/rebound/Spring;)V", "GetOnSpringUpdate_Lcom_facebook_rebound_Spring_Handler:Com.Facebook.Rebound.ISpringListenerInvoker, Rebound.Xamarin")]
		void OnSpringUpdate (global::Com.Facebook.Rebound.Spring p0);

	}

	[global::Android.Runtime.Register ("com/facebook/rebound/SpringListener", DoNotGenerateAcw=true)]
	internal class ISpringListenerInvoker : global::Java.Lang.Object, ISpringListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/rebound/SpringListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISpringListenerInvoker); }
		}

		IntPtr class_ref;

		public static ISpringListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpringListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.rebound.SpringListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpringListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Rebound.ISpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringActivate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSpringActivate_Lcom_facebook_rebound_Spring_;
		public unsafe void OnSpringActivate (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringActivate_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringActivate_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringActivate", "(Lcom/facebook/rebound/Spring;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringActivate_Lcom_facebook_rebound_Spring_, __args);
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
			global::Com.Facebook.Rebound.ISpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringAtRest (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSpringAtRest_Lcom_facebook_rebound_Spring_;
		public unsafe void OnSpringAtRest (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringAtRest_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringAtRest_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringAtRest", "(Lcom/facebook/rebound/Spring;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringAtRest_Lcom_facebook_rebound_Spring_, __args);
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
			global::Com.Facebook.Rebound.ISpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringEndStateChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_;
		public unsafe void OnSpringEndStateChange (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringEndStateChange", "(Lcom/facebook/rebound/Spring;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_, __args);
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
			global::Com.Facebook.Rebound.ISpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringUpdate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSpringUpdate_Lcom_facebook_rebound_Spring_;
		public unsafe void OnSpringUpdate (global::Com.Facebook.Rebound.Spring p0)
		{
			if (id_onSpringUpdate_Lcom_facebook_rebound_Spring_ == IntPtr.Zero)
				id_onSpringUpdate_Lcom_facebook_rebound_Spring_ = JNIEnv.GetMethodID (class_ref, "onSpringUpdate", "(Lcom/facebook/rebound/Spring;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpringUpdate_Lcom_facebook_rebound_Spring_, __args);
		}

	}

	public partial class SpringActivateEventArgs : global::System.EventArgs {

		public SpringActivateEventArgs (global::Com.Facebook.Rebound.Spring p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Rebound.Spring p0;
		public global::Com.Facebook.Rebound.Spring P0 {
			get { return p0; }
		}
	}

	public partial class SpringAtRestEventArgs : global::System.EventArgs {

		public SpringAtRestEventArgs (global::Com.Facebook.Rebound.Spring p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Rebound.Spring p0;
		public global::Com.Facebook.Rebound.Spring P0 {
			get { return p0; }
		}
	}

	public partial class SpringEndStateChangeEventArgs : global::System.EventArgs {

		public SpringEndStateChangeEventArgs (global::Com.Facebook.Rebound.Spring p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Rebound.Spring p0;
		public global::Com.Facebook.Rebound.Spring P0 {
			get { return p0; }
		}
	}

	public partial class SpringUpdateEventArgs : global::System.EventArgs {

		public SpringUpdateEventArgs (global::Com.Facebook.Rebound.Spring p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Rebound.Spring p0;
		public global::Com.Facebook.Rebound.Spring P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/rebound/SpringListenerImplementor")]
	internal sealed partial class ISpringListenerImplementor : global::Java.Lang.Object, ISpringListener {

		object sender;

		public ISpringListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/rebound/SpringListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<SpringActivateEventArgs> OnSpringActivateHandler;
#pragma warning restore 0649

		public void OnSpringActivate (global::Com.Facebook.Rebound.Spring p0)
		{
			var __h = OnSpringActivateHandler;
			if (__h != null)
				__h (sender, new SpringActivateEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SpringAtRestEventArgs> OnSpringAtRestHandler;
#pragma warning restore 0649

		public void OnSpringAtRest (global::Com.Facebook.Rebound.Spring p0)
		{
			var __h = OnSpringAtRestHandler;
			if (__h != null)
				__h (sender, new SpringAtRestEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SpringEndStateChangeEventArgs> OnSpringEndStateChangeHandler;
#pragma warning restore 0649

		public void OnSpringEndStateChange (global::Com.Facebook.Rebound.Spring p0)
		{
			var __h = OnSpringEndStateChangeHandler;
			if (__h != null)
				__h (sender, new SpringEndStateChangeEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SpringUpdateEventArgs> OnSpringUpdateHandler;
#pragma warning restore 0649

		public void OnSpringUpdate (global::Com.Facebook.Rebound.Spring p0)
		{
			var __h = OnSpringUpdateHandler;
			if (__h != null)
				__h (sender, new SpringUpdateEventArgs (p0));
		}

		internal static bool __IsEmpty (ISpringListenerImplementor value)
		{
			return value.OnSpringActivateHandler == null && value.OnSpringAtRestHandler == null && value.OnSpringEndStateChangeHandler == null && value.OnSpringUpdateHandler == null;
		}
	}

}
