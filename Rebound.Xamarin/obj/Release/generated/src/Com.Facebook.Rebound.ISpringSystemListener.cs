using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringSystemListener']"
	[Register ("com/facebook/rebound/SpringSystemListener", "", "Com.Facebook.Rebound.ISpringSystemListenerInvoker")]
	public partial interface ISpringSystemListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringSystemListener']/method[@name='onAfterIntegrate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.BaseSpringSystem']]"
		[Register ("onAfterIntegrate", "(Lcom/facebook/rebound/BaseSpringSystem;)V", "GetOnAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_Handler:Com.Facebook.Rebound.ISpringSystemListenerInvoker, Rebound.Xamarin")]
		void OnAfterIntegrate (global::Com.Facebook.Rebound.BaseSpringSystem p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='SpringSystemListener']/method[@name='onBeforeIntegrate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.BaseSpringSystem']]"
		[Register ("onBeforeIntegrate", "(Lcom/facebook/rebound/BaseSpringSystem;)V", "GetOnBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_Handler:Com.Facebook.Rebound.ISpringSystemListenerInvoker, Rebound.Xamarin")]
		void OnBeforeIntegrate (global::Com.Facebook.Rebound.BaseSpringSystem p0);

	}

	[global::Android.Runtime.Register ("com/facebook/rebound/SpringSystemListener", DoNotGenerateAcw=true)]
	internal class ISpringSystemListenerInvoker : global::Java.Lang.Object, ISpringSystemListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/rebound/SpringSystemListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISpringSystemListenerInvoker); }
		}

		IntPtr class_ref;

		public static ISpringSystemListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpringSystemListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.rebound.SpringSystemListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpringSystemListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_;
#pragma warning disable 0169
		static Delegate GetOnAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_Handler ()
		{
			if (cb_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ == null)
				cb_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_);
			return cb_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_;
		}

		static void n_OnAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.ISpringSystemListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringSystemListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.BaseSpringSystem p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAfterIntegrate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_;
		public unsafe void OnAfterIntegrate (global::Com.Facebook.Rebound.BaseSpringSystem p0)
		{
			if (id_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ == IntPtr.Zero)
				id_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ = JNIEnv.GetMethodID (class_ref, "onAfterIntegrate", "(Lcom/facebook/rebound/BaseSpringSystem;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAfterIntegrate_Lcom_facebook_rebound_BaseSpringSystem_, __args);
		}

		static Delegate cb_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_;
#pragma warning disable 0169
		static Delegate GetOnBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_Handler ()
		{
			if (cb_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ == null)
				cb_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_);
			return cb_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_;
		}

		static void n_OnBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.ISpringSystemListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringSystemListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.BaseSpringSystem p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeIntegrate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_;
		public unsafe void OnBeforeIntegrate (global::Com.Facebook.Rebound.BaseSpringSystem p0)
		{
			if (id_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ == IntPtr.Zero)
				id_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_ = JNIEnv.GetMethodID (class_ref, "onBeforeIntegrate", "(Lcom/facebook/rebound/BaseSpringSystem;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeforeIntegrate_Lcom_facebook_rebound_BaseSpringSystem_, __args);
		}

	}

	public partial class AfterIntegrateEventArgs : global::System.EventArgs {

		public AfterIntegrateEventArgs (global::Com.Facebook.Rebound.BaseSpringSystem p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Rebound.BaseSpringSystem p0;
		public global::Com.Facebook.Rebound.BaseSpringSystem P0 {
			get { return p0; }
		}
	}

	public partial class BeforeIntegrateEventArgs : global::System.EventArgs {

		public BeforeIntegrateEventArgs (global::Com.Facebook.Rebound.BaseSpringSystem p0)
		{
			this.p0 = p0;
		}

		global::Com.Facebook.Rebound.BaseSpringSystem p0;
		public global::Com.Facebook.Rebound.BaseSpringSystem P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/rebound/SpringSystemListenerImplementor")]
	internal sealed partial class ISpringSystemListenerImplementor : global::Java.Lang.Object, ISpringSystemListener {

		object sender;

		public ISpringSystemListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/rebound/SpringSystemListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AfterIntegrateEventArgs> OnAfterIntegrateHandler;
#pragma warning restore 0649

		public void OnAfterIntegrate (global::Com.Facebook.Rebound.BaseSpringSystem p0)
		{
			var __h = OnAfterIntegrateHandler;
			if (__h != null)
				__h (sender, new AfterIntegrateEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<BeforeIntegrateEventArgs> OnBeforeIntegrateHandler;
#pragma warning restore 0649

		public void OnBeforeIntegrate (global::Com.Facebook.Rebound.BaseSpringSystem p0)
		{
			var __h = OnBeforeIntegrateHandler;
			if (__h != null)
				__h (sender, new BeforeIntegrateEventArgs (p0));
		}

		internal static bool __IsEmpty (ISpringSystemListenerImplementor value)
		{
			return value.OnAfterIntegrateHandler == null && value.OnBeforeIntegrateHandler == null;
		}
	}

}
