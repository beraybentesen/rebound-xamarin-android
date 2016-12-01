using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']"
	[global::Android.Runtime.Register ("com/facebook/rebound/BaseSpringSystem", DoNotGenerateAcw=true)]
	public partial class BaseSpringSystem : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/BaseSpringSystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseSpringSystem); }
		}

		protected BaseSpringSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_facebook_rebound_SpringLooper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/constructor[@name='BaseSpringSystem' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringLooper']]"
		[Register (".ctor", "(Lcom/facebook/rebound/SpringLooper;)V", "")]
		public unsafe BaseSpringSystem (global::Com.Facebook.Rebound.SpringLooper p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseSpringSystem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/facebook/rebound/SpringLooper;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/facebook/rebound/SpringLooper;)V", __args);
					return;
				}

				if (id_ctor_Lcom_facebook_rebound_SpringLooper_ == IntPtr.Zero)
					id_ctor_Lcom_facebook_rebound_SpringLooper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/rebound/SpringLooper;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_rebound_SpringLooper_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_rebound_SpringLooper_, __args);
			} finally {
			}
		}

		static Delegate cb_getAllSprings;
#pragma warning disable 0169
		static Delegate GetGetAllSpringsHandler ()
		{
			if (cb_getAllSprings == null)
				cb_getAllSprings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllSprings);
			return cb_getAllSprings;
		}

		static IntPtr n_GetAllSprings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Facebook.Rebound.Spring>.ToLocalJniHandle (__this.AllSprings);
		}
#pragma warning restore 0169

		static IntPtr id_getAllSprings;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Rebound.Spring> AllSprings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='getAllSprings' and count(parameter)=0]"
			[Register ("getAllSprings", "()Ljava/util/List;", "GetGetAllSpringsHandler")]
			get {
				if (id_getAllSprings == IntPtr.Zero)
					id_getAllSprings = JNIEnv.GetMethodID (class_ref, "getAllSprings", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Facebook.Rebound.Spring>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllSprings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Facebook.Rebound.Spring>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllSprings", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIsIdle;
#pragma warning disable 0169
		static Delegate GetGetIsIdleHandler ()
		{
			if (cb_getIsIdle == null)
				cb_getIsIdle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsIdle);
			return cb_getIsIdle;
		}

		static bool n_GetIsIdle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIdle;
		}
#pragma warning restore 0169

		static IntPtr id_getIsIdle;
		public virtual unsafe bool IsIdle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='getIsIdle' and count(parameter)=0]"
			[Register ("getIsIdle", "()Z", "GetGetIsIdleHandler")]
			get {
				if (id_getIsIdle == IntPtr.Zero)
					id_getIsIdle = JNIEnv.GetMethodID (class_ref, "getIsIdle", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getIsIdle);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsIdle", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addListener_Lcom_facebook_rebound_SpringSystemListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_facebook_rebound_SpringSystemListener_Handler ()
		{
			if (cb_addListener_Lcom_facebook_rebound_SpringSystemListener_ == null)
				cb_addListener_Lcom_facebook_rebound_SpringSystemListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_facebook_rebound_SpringSystemListener_);
			return cb_addListener_Lcom_facebook_rebound_SpringSystemListener_;
		}

		static void n_AddListener_Lcom_facebook_rebound_SpringSystemListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ISpringSystemListener p0 = (global::Com.Facebook.Rebound.ISpringSystemListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringSystemListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lcom_facebook_rebound_SpringSystemListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringSystemListener']]"
		[Register ("addListener", "(Lcom/facebook/rebound/SpringSystemListener;)V", "GetAddListener_Lcom_facebook_rebound_SpringSystemListener_Handler")]
		public virtual unsafe void AddListener (global::Com.Facebook.Rebound.ISpringSystemListener p0)
		{
			if (id_addListener_Lcom_facebook_rebound_SpringSystemListener_ == IntPtr.Zero)
				id_addListener_Lcom_facebook_rebound_SpringSystemListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/facebook/rebound/SpringSystemListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Lcom_facebook_rebound_SpringSystemListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Lcom/facebook/rebound/SpringSystemListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createSpring;
#pragma warning disable 0169
		static Delegate GetCreateSpringHandler ()
		{
			if (cb_createSpring == null)
				cb_createSpring = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateSpring);
			return cb_createSpring;
		}

		static IntPtr n_CreateSpring (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateSpring ());
		}
#pragma warning restore 0169

		static IntPtr id_createSpring;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='createSpring' and count(parameter)=0]"
		[Register ("createSpring", "()Lcom/facebook/rebound/Spring;", "GetCreateSpringHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring CreateSpring ()
		{
			if (id_createSpring == IntPtr.Zero)
				id_createSpring = JNIEnv.GetMethodID (class_ref, "createSpring", "()Lcom/facebook/rebound/Spring;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSpring), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSpring", "()Lcom/facebook/rebound/Spring;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSpringById_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSpringById_Ljava_lang_String_Handler ()
		{
			if (cb_getSpringById_Ljava_lang_String_ == null)
				cb_getSpringById_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSpringById_Ljava_lang_String_);
			return cb_getSpringById_Ljava_lang_String_;
		}

		static IntPtr n_GetSpringById_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSpringById (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSpringById_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='getSpringById' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSpringById", "(Ljava/lang/String;)Lcom/facebook/rebound/Spring;", "GetGetSpringById_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring GetSpringById (string p0)
		{
			if (id_getSpringById_Ljava_lang_String_ == IntPtr.Zero)
				id_getSpringById_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSpringById", "(Ljava/lang/String;)Lcom/facebook/rebound/Spring;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Facebook.Rebound.Spring __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpringById_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpringById", "(Ljava/lang/String;)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loop_D;
#pragma warning disable 0169
		static Delegate GetLoop_DHandler ()
		{
			if (cb_loop_D == null)
				cb_loop_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Loop_D);
			return cb_loop_D;
		}

		static void n_Loop_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Loop (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loop_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='loop' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("loop", "(D)V", "GetLoop_DHandler")]
		public virtual unsafe void Loop (double p0)
		{
			if (id_loop_D == IntPtr.Zero)
				id_loop_D = JNIEnv.GetMethodID (class_ref, "loop", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loop_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loop", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAllListeners;
#pragma warning disable 0169
		static Delegate GetRemoveAllListenersHandler ()
		{
			if (cb_removeAllListeners == null)
				cb_removeAllListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllListeners);
			return cb_removeAllListeners;
		}

		static void n_RemoveAllListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='removeAllListeners' and count(parameter)=0]"
		[Register ("removeAllListeners", "()V", "GetRemoveAllListenersHandler")]
		public virtual unsafe void RemoveAllListeners ()
		{
			if (id_removeAllListeners == IntPtr.Zero)
				id_removeAllListeners = JNIEnv.GetMethodID (class_ref, "removeAllListeners", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllListeners);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllListeners", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeListener_Lcom_facebook_rebound_SpringSystemListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_facebook_rebound_SpringSystemListener_Handler ()
		{
			if (cb_removeListener_Lcom_facebook_rebound_SpringSystemListener_ == null)
				cb_removeListener_Lcom_facebook_rebound_SpringSystemListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_facebook_rebound_SpringSystemListener_);
			return cb_removeListener_Lcom_facebook_rebound_SpringSystemListener_;
		}

		static void n_RemoveListener_Lcom_facebook_rebound_SpringSystemListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.BaseSpringSystem __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BaseSpringSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ISpringSystemListener p0 = (global::Com.Facebook.Rebound.ISpringSystemListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringSystemListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_facebook_rebound_SpringSystemListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BaseSpringSystem']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringSystemListener']]"
		[Register ("removeListener", "(Lcom/facebook/rebound/SpringSystemListener;)V", "GetRemoveListener_Lcom_facebook_rebound_SpringSystemListener_Handler")]
		public virtual unsafe void RemoveListener (global::Com.Facebook.Rebound.ISpringSystemListener p0)
		{
			if (id_removeListener_Lcom_facebook_rebound_SpringSystemListener_ == IntPtr.Zero)
				id_removeListener_Lcom_facebook_rebound_SpringSystemListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/facebook/rebound/SpringSystemListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Lcom_facebook_rebound_SpringSystemListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Lcom/facebook/rebound/SpringSystemListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Facebook.Rebound.ISpringSystemListener"

		global::Com.Facebook.Rebound.ISpringSystemListenerImplementor __CreateISpringSystemListenerImplementor ()
		{
			return new global::Com.Facebook.Rebound.ISpringSystemListenerImplementor (this);
		}
#endregion
	}
}
