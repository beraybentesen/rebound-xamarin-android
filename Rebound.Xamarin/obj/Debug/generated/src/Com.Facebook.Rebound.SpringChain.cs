using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SpringChain", DoNotGenerateAcw=true)]
	public partial class SpringChain : global::Java.Lang.Object, global::Com.Facebook.Rebound.ISpringListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SpringChain", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringChain); }
		}

		protected SpringChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Facebook.Rebound.Spring>.ToLocalJniHandle (__this.AllSprings);
		}
#pragma warning restore 0169

		static IntPtr id_getAllSprings;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Rebound.Spring> AllSprings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='getAllSprings' and count(parameter)=0]"
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

		static Delegate cb_getAttachmentSpringConfig;
#pragma warning disable 0169
		static Delegate GetGetAttachmentSpringConfigHandler ()
		{
			if (cb_getAttachmentSpringConfig == null)
				cb_getAttachmentSpringConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttachmentSpringConfig);
			return cb_getAttachmentSpringConfig;
		}

		static IntPtr n_GetAttachmentSpringConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AttachmentSpringConfig);
		}
#pragma warning restore 0169

		static IntPtr id_getAttachmentSpringConfig;
		public virtual unsafe global::Com.Facebook.Rebound.SpringConfig AttachmentSpringConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='getAttachmentSpringConfig' and count(parameter)=0]"
			[Register ("getAttachmentSpringConfig", "()Lcom/facebook/rebound/SpringConfig;", "GetGetAttachmentSpringConfigHandler")]
			get {
				if (id_getAttachmentSpringConfig == IntPtr.Zero)
					id_getAttachmentSpringConfig = JNIEnv.GetMethodID (class_ref, "getAttachmentSpringConfig", "()Lcom/facebook/rebound/SpringConfig;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttachmentSpringConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttachmentSpringConfig", "()Lcom/facebook/rebound/SpringConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControlSpring;
#pragma warning disable 0169
		static Delegate GetGetControlSpringHandler ()
		{
			if (cb_getControlSpring == null)
				cb_getControlSpring = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControlSpring);
			return cb_getControlSpring;
		}

		static IntPtr n_GetControlSpring (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ControlSpring);
		}
#pragma warning restore 0169

		static IntPtr id_getControlSpring;
		public virtual unsafe global::Com.Facebook.Rebound.Spring ControlSpring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='getControlSpring' and count(parameter)=0]"
			[Register ("getControlSpring", "()Lcom/facebook/rebound/Spring;", "GetGetControlSpringHandler")]
			get {
				if (id_getControlSpring == IntPtr.Zero)
					id_getControlSpring = JNIEnv.GetMethodID (class_ref, "getControlSpring", "()Lcom/facebook/rebound/Spring;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getControlSpring), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getControlSpring", "()Lcom/facebook/rebound/Spring;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMainSpringConfig;
#pragma warning disable 0169
		static Delegate GetGetMainSpringConfigHandler ()
		{
			if (cb_getMainSpringConfig == null)
				cb_getMainSpringConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMainSpringConfig);
			return cb_getMainSpringConfig;
		}

		static IntPtr n_GetMainSpringConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MainSpringConfig);
		}
#pragma warning restore 0169

		static IntPtr id_getMainSpringConfig;
		public virtual unsafe global::Com.Facebook.Rebound.SpringConfig MainSpringConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='getMainSpringConfig' and count(parameter)=0]"
			[Register ("getMainSpringConfig", "()Lcom/facebook/rebound/SpringConfig;", "GetGetMainSpringConfigHandler")]
			get {
				if (id_getMainSpringConfig == IntPtr.Zero)
					id_getMainSpringConfig = JNIEnv.GetMethodID (class_ref, "getMainSpringConfig", "()Lcom/facebook/rebound/SpringConfig;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMainSpringConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMainSpringConfig", "()Lcom/facebook/rebound/SpringConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addSpring_Lcom_facebook_rebound_SpringListener_;
#pragma warning disable 0169
		static Delegate GetAddSpring_Lcom_facebook_rebound_SpringListener_Handler ()
		{
			if (cb_addSpring_Lcom_facebook_rebound_SpringListener_ == null)
				cb_addSpring_Lcom_facebook_rebound_SpringListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddSpring_Lcom_facebook_rebound_SpringListener_);
			return cb_addSpring_Lcom_facebook_rebound_SpringListener_;
		}

		static IntPtr n_AddSpring_Lcom_facebook_rebound_SpringListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ISpringListener p0 = (global::Com.Facebook.Rebound.ISpringListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddSpring (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addSpring_Lcom_facebook_rebound_SpringListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='addSpring' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringListener']]"
		[Register ("addSpring", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/SpringChain;", "GetAddSpring_Lcom_facebook_rebound_SpringListener_Handler")]
		public virtual unsafe global::Com.Facebook.Rebound.SpringChain AddSpring (global::Com.Facebook.Rebound.ISpringListener p0)
		{
			if (id_addSpring_Lcom_facebook_rebound_SpringListener_ == IntPtr.Zero)
				id_addSpring_Lcom_facebook_rebound_SpringListener_ = JNIEnv.GetMethodID (class_ref, "addSpring", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/SpringChain;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Facebook.Rebound.SpringChain __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addSpring_Lcom_facebook_rebound_SpringListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSpring", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/SpringChain;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/facebook/rebound/SpringChain;", "")]
		public static unsafe global::Com.Facebook.Rebound.SpringChain Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/facebook/rebound/SpringChain;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='create' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("create", "(IIII)Lcom/facebook/rebound/SpringChain;", "")]
		public static unsafe global::Com.Facebook.Rebound.SpringChain Create (int p0, int p1, int p2, int p3)
		{
			if (id_create_IIII == IntPtr.Zero)
				id_create_IIII = JNIEnv.GetStaticMethodID (class_ref, "create", "(IIII)Lcom/facebook/rebound/SpringChain;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_IIII, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringActivate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringActivate_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='onSpringActivate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringAtRest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringAtRest_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='onSpringAtRest' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringEndStateChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='onSpringEndStateChange' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSpringUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSpringUpdate_Lcom_facebook_rebound_Spring_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='onSpringUpdate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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

		static Delegate cb_setControlSpringIndex_I;
#pragma warning disable 0169
		static Delegate GetSetControlSpringIndex_IHandler ()
		{
			if (cb_setControlSpringIndex_I == null)
				cb_setControlSpringIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetControlSpringIndex_I);
			return cb_setControlSpringIndex_I;
		}

		static IntPtr n_SetControlSpringIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Facebook.Rebound.SpringChain __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetControlSpringIndex (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setControlSpringIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringChain']/method[@name='setControlSpringIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setControlSpringIndex", "(I)Lcom/facebook/rebound/SpringChain;", "GetSetControlSpringIndex_IHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.SpringChain SetControlSpringIndex (int p0)
		{
			if (id_setControlSpringIndex_I == IntPtr.Zero)
				id_setControlSpringIndex_I = JNIEnv.GetMethodID (class_ref, "setControlSpringIndex", "(I)Lcom/facebook/rebound/SpringChain;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setControlSpringIndex_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringChain> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setControlSpringIndex", "(I)Lcom/facebook/rebound/SpringChain;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
