using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']"
	[global::Android.Runtime.Register ("com/facebook/rebound/Spring", DoNotGenerateAcw=true)]
	public partial class Spring : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring.PhysicsState']"
		[global::Android.Runtime.Register ("com/facebook/rebound/Spring$PhysicsState", DoNotGenerateAcw=true)]
		public partial class PhysicsState : global::Java.Lang.Object {

			protected PhysicsState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/Spring", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Spring); }
		}

		protected Spring (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCurrentDisplacementDistance;
#pragma warning disable 0169
		static Delegate GetGetCurrentDisplacementDistanceHandler ()
		{
			if (cb_getCurrentDisplacementDistance == null)
				cb_getCurrentDisplacementDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetCurrentDisplacementDistance);
			return cb_getCurrentDisplacementDistance;
		}

		static double n_GetCurrentDisplacementDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentDisplacementDistance;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentDisplacementDistance;
		public virtual unsafe double CurrentDisplacementDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getCurrentDisplacementDistance' and count(parameter)=0]"
			[Register ("getCurrentDisplacementDistance", "()D", "GetGetCurrentDisplacementDistanceHandler")]
			get {
				if (id_getCurrentDisplacementDistance == IntPtr.Zero)
					id_getCurrentDisplacementDistance = JNIEnv.GetMethodID (class_ref, "getCurrentDisplacementDistance", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDisplacementDistance);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentDisplacementDistance", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentValue;
#pragma warning disable 0169
		static Delegate GetGetCurrentValueHandler ()
		{
			if (cb_getCurrentValue == null)
				cb_getCurrentValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetCurrentValue);
			return cb_getCurrentValue;
		}

		static double n_GetCurrentValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentValue;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentValue;
		public virtual unsafe double CurrentValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getCurrentValue' and count(parameter)=0]"
			[Register ("getCurrentValue", "()D", "GetGetCurrentValueHandler")]
			get {
				if (id_getCurrentValue == IntPtr.Zero)
					id_getCurrentValue = JNIEnv.GetMethodID (class_ref, "getCurrentValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentValue", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getEndValue;
#pragma warning disable 0169
		static Delegate GetGetEndValueHandler ()
		{
			if (cb_getEndValue == null)
				cb_getEndValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetEndValue);
			return cb_getEndValue;
		}

		static double n_GetEndValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndValue;
		}
#pragma warning restore 0169

		static IntPtr id_getEndValue;
		public virtual unsafe double EndValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getEndValue' and count(parameter)=0]"
			[Register ("getEndValue", "()D", "GetGetEndValueHandler")]
			get {
				if (id_getEndValue == IntPtr.Zero)
					id_getEndValue = JNIEnv.GetMethodID (class_ref, "getEndValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getEndValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndValue", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAtRest;
#pragma warning disable 0169
		static Delegate GetIsAtRestHandler ()
		{
			if (cb_isAtRest == null)
				cb_isAtRest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAtRest);
			return cb_isAtRest;
		}

		static bool n_IsAtRest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAtRest;
		}
#pragma warning restore 0169

		static IntPtr id_isAtRest;
		public virtual unsafe bool IsAtRest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='isAtRest' and count(parameter)=0]"
			[Register ("isAtRest", "()Z", "GetIsAtRestHandler")]
			get {
				if (id_isAtRest == IntPtr.Zero)
					id_isAtRest = JNIEnv.GetMethodID (class_ref, "isAtRest", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAtRest);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAtRest", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOvershootClampingEnabled;
#pragma warning disable 0169
		static Delegate GetIsOvershootClampingEnabledHandler ()
		{
			if (cb_isOvershootClampingEnabled == null)
				cb_isOvershootClampingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOvershootClampingEnabled);
			return cb_isOvershootClampingEnabled;
		}

		static bool n_IsOvershootClampingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOvershootClampingEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isOvershootClampingEnabled;
		public virtual unsafe bool IsOvershootClampingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='isOvershootClampingEnabled' and count(parameter)=0]"
			[Register ("isOvershootClampingEnabled", "()Z", "GetIsOvershootClampingEnabledHandler")]
			get {
				if (id_isOvershootClampingEnabled == IntPtr.Zero)
					id_isOvershootClampingEnabled = JNIEnv.GetMethodID (class_ref, "isOvershootClampingEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOvershootClampingEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOvershootClampingEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOvershooting;
#pragma warning disable 0169
		static Delegate GetIsOvershootingHandler ()
		{
			if (cb_isOvershooting == null)
				cb_isOvershooting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOvershooting);
			return cb_isOvershooting;
		}

		static bool n_IsOvershooting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOvershooting;
		}
#pragma warning restore 0169

		static IntPtr id_isOvershooting;
		public virtual unsafe bool IsOvershooting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='isOvershooting' and count(parameter)=0]"
			[Register ("isOvershooting", "()Z", "GetIsOvershootingHandler")]
			get {
				if (id_isOvershooting == IntPtr.Zero)
					id_isOvershooting = JNIEnv.GetMethodID (class_ref, "isOvershooting", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOvershooting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOvershooting", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRestDisplacementThreshold;
#pragma warning disable 0169
		static Delegate GetGetRestDisplacementThresholdHandler ()
		{
			if (cb_getRestDisplacementThreshold == null)
				cb_getRestDisplacementThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRestDisplacementThreshold);
			return cb_getRestDisplacementThreshold;
		}

		static double n_GetRestDisplacementThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RestDisplacementThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getRestDisplacementThreshold;
		public virtual unsafe double RestDisplacementThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getRestDisplacementThreshold' and count(parameter)=0]"
			[Register ("getRestDisplacementThreshold", "()D", "GetGetRestDisplacementThresholdHandler")]
			get {
				if (id_getRestDisplacementThreshold == IntPtr.Zero)
					id_getRestDisplacementThreshold = JNIEnv.GetMethodID (class_ref, "getRestDisplacementThreshold", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRestDisplacementThreshold);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRestDisplacementThreshold", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getRestSpeedThreshold;
#pragma warning disable 0169
		static Delegate GetGetRestSpeedThresholdHandler ()
		{
			if (cb_getRestSpeedThreshold == null)
				cb_getRestSpeedThreshold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRestSpeedThreshold);
			return cb_getRestSpeedThreshold;
		}

		static double n_GetRestSpeedThreshold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RestSpeedThreshold;
		}
#pragma warning restore 0169

		static IntPtr id_getRestSpeedThreshold;
		public virtual unsafe double RestSpeedThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getRestSpeedThreshold' and count(parameter)=0]"
			[Register ("getRestSpeedThreshold", "()D", "GetGetRestSpeedThresholdHandler")]
			get {
				if (id_getRestSpeedThreshold == IntPtr.Zero)
					id_getRestSpeedThreshold = JNIEnv.GetMethodID (class_ref, "getRestSpeedThreshold", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRestSpeedThreshold);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRestSpeedThreshold", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getSpringConfig;
#pragma warning disable 0169
		static Delegate GetGetSpringConfigHandler ()
		{
			if (cb_getSpringConfig == null)
				cb_getSpringConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpringConfig);
			return cb_getSpringConfig;
		}

		static IntPtr n_GetSpringConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SpringConfig);
		}
#pragma warning restore 0169

		static IntPtr id_getSpringConfig;
		public virtual unsafe global::Com.Facebook.Rebound.SpringConfig SpringConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getSpringConfig' and count(parameter)=0]"
			[Register ("getSpringConfig", "()Lcom/facebook/rebound/SpringConfig;", "GetGetSpringConfigHandler")]
			get {
				if (id_getSpringConfig == IntPtr.Zero)
					id_getSpringConfig = JNIEnv.GetMethodID (class_ref, "getSpringConfig", "()Lcom/facebook/rebound/SpringConfig;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpringConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpringConfig", "()Lcom/facebook/rebound/SpringConfig;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartValue;
#pragma warning disable 0169
		static Delegate GetGetStartValueHandler ()
		{
			if (cb_getStartValue == null)
				cb_getStartValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetStartValue);
			return cb_getStartValue;
		}

		static double n_GetStartValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartValue;
		}
#pragma warning restore 0169

		static IntPtr id_getStartValue;
		public virtual unsafe double StartValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getStartValue' and count(parameter)=0]"
			[Register ("getStartValue", "()D", "GetGetStartValueHandler")]
			get {
				if (id_getStartValue == IntPtr.Zero)
					id_getStartValue = JNIEnv.GetMethodID (class_ref, "getStartValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getStartValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartValue", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getVelocity;
#pragma warning disable 0169
		static Delegate GetGetVelocityHandler ()
		{
			if (cb_getVelocity == null)
				cb_getVelocity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetVelocity);
			return cb_getVelocity;
		}

		static double n_GetVelocity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Velocity;
		}
#pragma warning restore 0169

		static IntPtr id_getVelocity;
		public virtual unsafe double Velocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='getVelocity' and count(parameter)=0]"
			[Register ("getVelocity", "()D", "GetGetVelocityHandler")]
			get {
				if (id_getVelocity == IntPtr.Zero)
					id_getVelocity = JNIEnv.GetMethodID (class_ref, "getVelocity", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getVelocity);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVelocity", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_addListener_Lcom_facebook_rebound_SpringListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_facebook_rebound_SpringListener_Handler ()
		{
			if (cb_addListener_Lcom_facebook_rebound_SpringListener_ == null)
				cb_addListener_Lcom_facebook_rebound_SpringListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_facebook_rebound_SpringListener_);
			return cb_addListener_Lcom_facebook_rebound_SpringListener_;
		}

		static IntPtr n_AddListener_Lcom_facebook_rebound_SpringListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ISpringListener p0 = (global::Com.Facebook.Rebound.ISpringListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Lcom_facebook_rebound_SpringListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringListener']]"
		[Register ("addListener", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/Spring;", "GetAddListener_Lcom_facebook_rebound_SpringListener_Handler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring AddListener (global::Com.Facebook.Rebound.ISpringListener p0)
		{
			if (id_addListener_Lcom_facebook_rebound_SpringListener_ == IntPtr.Zero)
				id_addListener_Lcom_facebook_rebound_SpringListener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Facebook.Rebound.Spring __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Lcom_facebook_rebound_SpringListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_currentValueIsApproximately_D;
#pragma warning disable 0169
		static Delegate GetCurrentValueIsApproximately_DHandler ()
		{
			if (cb_currentValueIsApproximately_D == null)
				cb_currentValueIsApproximately_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, bool>) n_CurrentValueIsApproximately_D);
			return cb_currentValueIsApproximately_D;
		}

		static bool n_CurrentValueIsApproximately_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentValueIsApproximately (p0);
		}
#pragma warning restore 0169

		static IntPtr id_currentValueIsApproximately_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='currentValueIsApproximately' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("currentValueIsApproximately", "(D)Z", "GetCurrentValueIsApproximately_DHandler")]
		public virtual unsafe bool CurrentValueIsApproximately (double p0)
		{
			if (id_currentValueIsApproximately_D == IntPtr.Zero)
				id_currentValueIsApproximately_D = JNIEnv.GetMethodID (class_ref, "currentValueIsApproximately", "(D)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_currentValueIsApproximately_D, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "currentValueIsApproximately", "(D)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllListeners;
#pragma warning disable 0169
		static Delegate GetRemoveAllListenersHandler ()
		{
			if (cb_removeAllListeners == null)
				cb_removeAllListeners = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveAllListeners);
			return cb_removeAllListeners;
		}

		static IntPtr n_RemoveAllListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveAllListeners ());
		}
#pragma warning restore 0169

		static IntPtr id_removeAllListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='removeAllListeners' and count(parameter)=0]"
		[Register ("removeAllListeners", "()Lcom/facebook/rebound/Spring;", "GetRemoveAllListenersHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring RemoveAllListeners ()
		{
			if (id_removeAllListeners == IntPtr.Zero)
				id_removeAllListeners = JNIEnv.GetMethodID (class_ref, "removeAllListeners", "()Lcom/facebook/rebound/Spring;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeAllListeners), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllListeners", "()Lcom/facebook/rebound/Spring;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeListener_Lcom_facebook_rebound_SpringListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_facebook_rebound_SpringListener_Handler ()
		{
			if (cb_removeListener_Lcom_facebook_rebound_SpringListener_ == null)
				cb_removeListener_Lcom_facebook_rebound_SpringListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_facebook_rebound_SpringListener_);
			return cb_removeListener_Lcom_facebook_rebound_SpringListener_;
		}

		static IntPtr n_RemoveListener_Lcom_facebook_rebound_SpringListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.ISpringListener p0 = (global::Com.Facebook.Rebound.ISpringListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.ISpringListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Lcom_facebook_rebound_SpringListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringListener']]"
		[Register ("removeListener", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/Spring;", "GetRemoveListener_Lcom_facebook_rebound_SpringListener_Handler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring RemoveListener (global::Com.Facebook.Rebound.ISpringListener p0)
		{
			if (id_removeListener_Lcom_facebook_rebound_SpringListener_ == IntPtr.Zero)
				id_removeListener_Lcom_facebook_rebound_SpringListener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Facebook.Rebound.Spring __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Lcom_facebook_rebound_SpringListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Lcom/facebook/rebound/SpringListener;)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAtRest;
#pragma warning disable 0169
		static Delegate GetSetAtRestHandler ()
		{
			if (cb_setAtRest == null)
				cb_setAtRest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetAtRest);
			return cb_setAtRest;
		}

		static IntPtr n_SetAtRest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAtRest ());
		}
#pragma warning restore 0169

		static IntPtr id_setAtRest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setAtRest' and count(parameter)=0]"
		[Register ("setAtRest", "()Lcom/facebook/rebound/Spring;", "GetSetAtRestHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetAtRest ()
		{
			if (id_setAtRest == IntPtr.Zero)
				id_setAtRest = JNIEnv.GetMethodID (class_ref, "setAtRest", "()Lcom/facebook/rebound/Spring;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAtRest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAtRest", "()Lcom/facebook/rebound/Spring;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCurrentValue_D;
#pragma warning disable 0169
		static Delegate GetSetCurrentValue_DHandler ()
		{
			if (cb_setCurrentValue_D == null)
				cb_setCurrentValue_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetCurrentValue_D);
			return cb_setCurrentValue_D;
		}

		static IntPtr n_SetCurrentValue_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCurrentValue (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentValue_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setCurrentValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setCurrentValue", "(D)Lcom/facebook/rebound/Spring;", "GetSetCurrentValue_DHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetCurrentValue (double p0)
		{
			if (id_setCurrentValue_D == IntPtr.Zero)
				id_setCurrentValue_D = JNIEnv.GetMethodID (class_ref, "setCurrentValue", "(D)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentValue_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentValue", "(D)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCurrentValue_DZ;
#pragma warning disable 0169
		static Delegate GetSetCurrentValue_DZHandler ()
		{
			if (cb_setCurrentValue_DZ == null)
				cb_setCurrentValue_DZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, bool, IntPtr>) n_SetCurrentValue_DZ);
			return cb_setCurrentValue_DZ;
		}

		static IntPtr n_SetCurrentValue_DZ (IntPtr jnienv, IntPtr native__this, double p0, bool p1)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCurrentValue (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentValue_DZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setCurrentValue' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='boolean']]"
		[Register ("setCurrentValue", "(DZ)Lcom/facebook/rebound/Spring;", "GetSetCurrentValue_DZHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetCurrentValue (double p0, bool p1)
		{
			if (id_setCurrentValue_DZ == IntPtr.Zero)
				id_setCurrentValue_DZ = JNIEnv.GetMethodID (class_ref, "setCurrentValue", "(DZ)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentValue_DZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentValue", "(DZ)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEndValue_D;
#pragma warning disable 0169
		static Delegate GetSetEndValue_DHandler ()
		{
			if (cb_setEndValue_D == null)
				cb_setEndValue_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetEndValue_D);
			return cb_setEndValue_D;
		}

		static IntPtr n_SetEndValue_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEndValue (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setEndValue_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setEndValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setEndValue", "(D)Lcom/facebook/rebound/Spring;", "GetSetEndValue_DHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetEndValue (double p0)
		{
			if (id_setEndValue_D == IntPtr.Zero)
				id_setEndValue_D = JNIEnv.GetMethodID (class_ref, "setEndValue", "(D)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEndValue_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndValue", "(D)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOvershootClampingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetOvershootClampingEnabled_ZHandler ()
		{
			if (cb_setOvershootClampingEnabled_Z == null)
				cb_setOvershootClampingEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetOvershootClampingEnabled_Z);
			return cb_setOvershootClampingEnabled_Z;
		}

		static IntPtr n_SetOvershootClampingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOvershootClampingEnabled (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setOvershootClampingEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setOvershootClampingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOvershootClampingEnabled", "(Z)Lcom/facebook/rebound/Spring;", "GetSetOvershootClampingEnabled_ZHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetOvershootClampingEnabled (bool p0)
		{
			if (id_setOvershootClampingEnabled_Z == IntPtr.Zero)
				id_setOvershootClampingEnabled_Z = JNIEnv.GetMethodID (class_ref, "setOvershootClampingEnabled", "(Z)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOvershootClampingEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOvershootClampingEnabled", "(Z)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRestDisplacementThreshold_D;
#pragma warning disable 0169
		static Delegate GetSetRestDisplacementThreshold_DHandler ()
		{
			if (cb_setRestDisplacementThreshold_D == null)
				cb_setRestDisplacementThreshold_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetRestDisplacementThreshold_D);
			return cb_setRestDisplacementThreshold_D;
		}

		static IntPtr n_SetRestDisplacementThreshold_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRestDisplacementThreshold (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setRestDisplacementThreshold_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setRestDisplacementThreshold' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setRestDisplacementThreshold", "(D)Lcom/facebook/rebound/Spring;", "GetSetRestDisplacementThreshold_DHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetRestDisplacementThreshold (double p0)
		{
			if (id_setRestDisplacementThreshold_D == IntPtr.Zero)
				id_setRestDisplacementThreshold_D = JNIEnv.GetMethodID (class_ref, "setRestDisplacementThreshold", "(D)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRestDisplacementThreshold_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRestDisplacementThreshold", "(D)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRestSpeedThreshold_D;
#pragma warning disable 0169
		static Delegate GetSetRestSpeedThreshold_DHandler ()
		{
			if (cb_setRestSpeedThreshold_D == null)
				cb_setRestSpeedThreshold_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetRestSpeedThreshold_D);
			return cb_setRestSpeedThreshold_D;
		}

		static IntPtr n_SetRestSpeedThreshold_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRestSpeedThreshold (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setRestSpeedThreshold_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setRestSpeedThreshold' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setRestSpeedThreshold", "(D)Lcom/facebook/rebound/Spring;", "GetSetRestSpeedThreshold_DHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetRestSpeedThreshold (double p0)
		{
			if (id_setRestSpeedThreshold_D == IntPtr.Zero)
				id_setRestSpeedThreshold_D = JNIEnv.GetMethodID (class_ref, "setRestSpeedThreshold", "(D)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRestSpeedThreshold_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRestSpeedThreshold", "(D)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSpringConfig_Lcom_facebook_rebound_SpringConfig_;
#pragma warning disable 0169
		static Delegate GetSetSpringConfig_Lcom_facebook_rebound_SpringConfig_Handler ()
		{
			if (cb_setSpringConfig_Lcom_facebook_rebound_SpringConfig_ == null)
				cb_setSpringConfig_Lcom_facebook_rebound_SpringConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSpringConfig_Lcom_facebook_rebound_SpringConfig_);
			return cb_setSpringConfig_Lcom_facebook_rebound_SpringConfig_;
		}

		static IntPtr n_SetSpringConfig_Lcom_facebook_rebound_SpringConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.SpringConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSpringConfig (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSpringConfig_Lcom_facebook_rebound_SpringConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setSpringConfig' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringConfig']]"
		[Register ("setSpringConfig", "(Lcom/facebook/rebound/SpringConfig;)Lcom/facebook/rebound/Spring;", "GetSetSpringConfig_Lcom_facebook_rebound_SpringConfig_Handler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetSpringConfig (global::Com.Facebook.Rebound.SpringConfig p0)
		{
			if (id_setSpringConfig_Lcom_facebook_rebound_SpringConfig_ == IntPtr.Zero)
				id_setSpringConfig_Lcom_facebook_rebound_SpringConfig_ = JNIEnv.GetMethodID (class_ref, "setSpringConfig", "(Lcom/facebook/rebound/SpringConfig;)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Facebook.Rebound.Spring __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSpringConfig_Lcom_facebook_rebound_SpringConfig_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpringConfig", "(Lcom/facebook/rebound/SpringConfig;)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setVelocity_D;
#pragma warning disable 0169
		static Delegate GetSetVelocity_DHandler ()
		{
			if (cb_setVelocity_D == null)
				cb_setVelocity_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetVelocity_D);
			return cb_setVelocity_D;
		}

		static IntPtr n_SetVelocity_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetVelocity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setVelocity_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='setVelocity' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setVelocity", "(D)Lcom/facebook/rebound/Spring;", "GetSetVelocity_DHandler")]
		public virtual unsafe global::Com.Facebook.Rebound.Spring SetVelocity (double p0)
		{
			if (id_setVelocity_D == IntPtr.Zero)
				id_setVelocity_D = JNIEnv.GetMethodID (class_ref, "setVelocity", "(D)Lcom/facebook/rebound/Spring;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVelocity_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVelocity", "(D)Lcom/facebook/rebound/Spring;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_systemShouldAdvance;
#pragma warning disable 0169
		static Delegate GetSystemShouldAdvanceHandler ()
		{
			if (cb_systemShouldAdvance == null)
				cb_systemShouldAdvance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SystemShouldAdvance);
			return cb_systemShouldAdvance;
		}

		static bool n_SystemShouldAdvance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SystemShouldAdvance ();
		}
#pragma warning restore 0169

		static IntPtr id_systemShouldAdvance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='systemShouldAdvance' and count(parameter)=0]"
		[Register ("systemShouldAdvance", "()Z", "GetSystemShouldAdvanceHandler")]
		public virtual unsafe bool SystemShouldAdvance ()
		{
			if (id_systemShouldAdvance == IntPtr.Zero)
				id_systemShouldAdvance = JNIEnv.GetMethodID (class_ref, "systemShouldAdvance", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_systemShouldAdvance);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "systemShouldAdvance", "()Z"));
			} finally {
			}
		}

		static Delegate cb_wasAtRest;
#pragma warning disable 0169
		static Delegate GetWasAtRestHandler ()
		{
			if (cb_wasAtRest == null)
				cb_wasAtRest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_WasAtRest);
			return cb_wasAtRest;
		}

		static bool n_WasAtRest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.Spring __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WasAtRest ();
		}
#pragma warning restore 0169

		static IntPtr id_wasAtRest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='Spring']/method[@name='wasAtRest' and count(parameter)=0]"
		[Register ("wasAtRest", "()Z", "GetWasAtRestHandler")]
		public virtual unsafe bool WasAtRest ()
		{
			if (id_wasAtRest == IntPtr.Zero)
				id_wasAtRest = JNIEnv.GetMethodID (class_ref, "wasAtRest", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_wasAtRest);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wasAtRest", "()Z"));
			} finally {
			}
		}

	}
}
