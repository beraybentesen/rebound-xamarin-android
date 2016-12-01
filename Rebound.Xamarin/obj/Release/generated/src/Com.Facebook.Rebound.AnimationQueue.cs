using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']"
	[global::Android.Runtime.Register ("com/facebook/rebound/AnimationQueue", DoNotGenerateAcw=true)]
	public partial class AnimationQueue : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='AnimationQueue.Callback']"
		[Register ("com/facebook/rebound/AnimationQueue$Callback", "", "Com.Facebook.Rebound.AnimationQueue/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/interface[@name='AnimationQueue.Callback']/method[@name='onFrame' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("onFrame", "(Ljava/lang/Double;)V", "GetOnFrame_Ljava_lang_Double_Handler:Com.Facebook.Rebound.AnimationQueue/ICallbackInvoker, Rebound.Xamarin")]
			void OnFrame (global::Java.Lang.Double p0);

		}

		[global::Android.Runtime.Register ("com/facebook/rebound/AnimationQueue$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/facebook/rebound/AnimationQueue$Callback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.rebound.AnimationQueue.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFrame_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetOnFrame_Ljava_lang_Double_Handler ()
			{
				if (cb_onFrame_Ljava_lang_Double_ == null)
					cb_onFrame_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrame_Ljava_lang_Double_);
				return cb_onFrame_Ljava_lang_Double_;
			}

			static void n_OnFrame_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Rebound.AnimationQueue.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFrame (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFrame_Ljava_lang_Double_;
			public unsafe void OnFrame (global::Java.Lang.Double p0)
			{
				if (id_onFrame_Ljava_lang_Double_ == IntPtr.Zero)
					id_onFrame_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "onFrame", "(Ljava/lang/Double;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrame_Ljava_lang_Double_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/AnimationQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimationQueue); }
		}

		protected AnimationQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']/constructor[@name='AnimationQueue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimationQueue ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AnimationQueue)) {
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

		static Delegate cb_addAllValues_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAllValues_Ljava_util_Collection_Handler ()
		{
			if (cb_addAllValues_Ljava_util_Collection_ == null)
				cb_addAllValues_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAllValues_Ljava_util_Collection_);
			return cb_addAllValues_Ljava_util_Collection_;
		}

		static void n_AddAllValues_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.AnimationQueue __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection<global::Java.Lang.Double>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAllValues (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addAllValues_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']/method[@name='addAllValues' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.Double&gt;']]"
		[Register ("addAllValues", "(Ljava/util/Collection;)V", "GetAddAllValues_Ljava_util_Collection_Handler")]
		public virtual unsafe void AddAllValues (global::System.Collections.Generic.ICollection<global::Java.Lang.Double> p0)
		{
			if (id_addAllValues_Ljava_util_Collection_ == IntPtr.Zero)
				id_addAllValues_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "addAllValues", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addAllValues_Ljava_util_Collection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAllValues", "(Ljava/util/Collection;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_;
#pragma warning disable 0169
		static Delegate GetAddCallback_Lcom_facebook_rebound_AnimationQueue_Callback_Handler ()
		{
			if (cb_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ == null)
				cb_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCallback_Lcom_facebook_rebound_AnimationQueue_Callback_);
			return cb_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_;
		}

		static void n_AddCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.AnimationQueue __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.AnimationQueue.ICallback p0 = (global::Com.Facebook.Rebound.AnimationQueue.ICallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.AnimationQueue.Callback']]"
		[Register ("addCallback", "(Lcom/facebook/rebound/AnimationQueue$Callback;)V", "GetAddCallback_Lcom_facebook_rebound_AnimationQueue_Callback_Handler")]
		public virtual unsafe void AddCallback (global::Com.Facebook.Rebound.AnimationQueue.ICallback p0)
		{
			if (id_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ == IntPtr.Zero)
				id_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/facebook/rebound/AnimationQueue$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCallback_Lcom_facebook_rebound_AnimationQueue_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCallback", "(Lcom/facebook/rebound/AnimationQueue$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addValue_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetAddValue_Ljava_lang_Double_Handler ()
		{
			if (cb_addValue_Ljava_lang_Double_ == null)
				cb_addValue_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddValue_Ljava_lang_Double_);
			return cb_addValue_Ljava_lang_Double_;
		}

		static void n_AddValue_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.AnimationQueue __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addValue_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']/method[@name='addValue' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("addValue", "(Ljava/lang/Double;)V", "GetAddValue_Ljava_lang_Double_Handler")]
		public virtual unsafe void AddValue (global::Java.Lang.Double p0)
		{
			if (id_addValue_Ljava_lang_Double_ == IntPtr.Zero)
				id_addValue_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "addValue", "(Ljava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addValue_Ljava_lang_Double_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addValue", "(Ljava/lang/Double;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearCallbacks;
#pragma warning disable 0169
		static Delegate GetClearCallbacksHandler ()
		{
			if (cb_clearCallbacks == null)
				cb_clearCallbacks = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCallbacks);
			return cb_clearCallbacks;
		}

		static void n_ClearCallbacks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.AnimationQueue __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCallbacks ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCallbacks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']/method[@name='clearCallbacks' and count(parameter)=0]"
		[Register ("clearCallbacks", "()V", "GetClearCallbacksHandler")]
		public virtual unsafe void ClearCallbacks ()
		{
			if (id_clearCallbacks == IntPtr.Zero)
				id_clearCallbacks = JNIEnv.GetMethodID (class_ref, "clearCallbacks", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearCallbacks);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCallbacks", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearValues;
#pragma warning disable 0169
		static Delegate GetClearValuesHandler ()
		{
			if (cb_clearValues == null)
				cb_clearValues = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearValues);
			return cb_clearValues;
		}

		static void n_ClearValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.AnimationQueue __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearValues ();
		}
#pragma warning restore 0169

		static IntPtr id_clearValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']/method[@name='clearValues' and count(parameter)=0]"
		[Register ("clearValues", "()V", "GetClearValuesHandler")]
		public virtual unsafe void ClearValues ()
		{
			if (id_clearValues == IntPtr.Zero)
				id_clearValues = JNIEnv.GetMethodID (class_ref, "clearValues", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearValues);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearValues", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_;
#pragma warning disable 0169
		static Delegate GetRemoveCallback_Lcom_facebook_rebound_AnimationQueue_Callback_Handler ()
		{
			if (cb_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ == null)
				cb_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallback_Lcom_facebook_rebound_AnimationQueue_Callback_);
			return cb_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_;
		}

		static void n_RemoveCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.AnimationQueue __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.AnimationQueue.ICallback p0 = (global::Com.Facebook.Rebound.AnimationQueue.ICallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.AnimationQueue.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='AnimationQueue']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.AnimationQueue.Callback']]"
		[Register ("removeCallback", "(Lcom/facebook/rebound/AnimationQueue$Callback;)V", "GetRemoveCallback_Lcom_facebook_rebound_AnimationQueue_Callback_Handler")]
		public virtual unsafe void RemoveCallback (global::Com.Facebook.Rebound.AnimationQueue.ICallback p0)
		{
			if (id_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ == IntPtr.Zero)
				id_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/facebook/rebound/AnimationQueue$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback_Lcom_facebook_rebound_AnimationQueue_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallback", "(Lcom/facebook/rebound/AnimationQueue$Callback;)V"), __args);
			} finally {
			}
		}

	}
}
