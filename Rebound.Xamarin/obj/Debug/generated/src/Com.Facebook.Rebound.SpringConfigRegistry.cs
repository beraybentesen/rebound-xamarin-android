using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfigRegistry']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SpringConfigRegistry", DoNotGenerateAcw=true)]
	public partial class SpringConfigRegistry : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SpringConfigRegistry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringConfigRegistry); }
		}

		protected SpringConfigRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllSpringConfig;
#pragma warning disable 0169
		static Delegate GetGetAllSpringConfigHandler ()
		{
			if (cb_getAllSpringConfig == null)
				cb_getAllSpringConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllSpringConfig);
			return cb_getAllSpringConfig;
		}

		static IntPtr n_GetAllSpringConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SpringConfigRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfigRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Facebook.Rebound.SpringConfig, string>.ToLocalJniHandle (__this.AllSpringConfig);
		}
#pragma warning restore 0169

		static IntPtr id_getAllSpringConfig;
		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Com.Facebook.Rebound.SpringConfig, string> AllSpringConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfigRegistry']/method[@name='getAllSpringConfig' and count(parameter)=0]"
			[Register ("getAllSpringConfig", "()Ljava/util/Map;", "GetGetAllSpringConfigHandler")]
			get {
				if (id_getAllSpringConfig == IntPtr.Zero)
					id_getAllSpringConfig = JNIEnv.GetMethodID (class_ref, "getAllSpringConfig", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<global::Com.Facebook.Rebound.SpringConfig, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllSpringConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<global::Com.Facebook.Rebound.SpringConfig, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllSpringConfig", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Facebook.Rebound.SpringConfigRegistry Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfigRegistry']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/facebook/rebound/SpringConfigRegistry;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/facebook/rebound/SpringConfigRegistry;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfigRegistry> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_Handler ()
		{
			if (cb_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_ == null)
				cb_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_);
			return cb_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_;
		}

		static bool n_AddSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Rebound.SpringConfigRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfigRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.SpringConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddSpringConfig (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfigRegistry']/method[@name='addSpringConfig' and count(parameter)=2 and parameter[1][@type='com.facebook.rebound.SpringConfig'] and parameter[2][@type='java.lang.String']]"
		[Register ("addSpringConfig", "(Lcom/facebook/rebound/SpringConfig;Ljava/lang/String;)Z", "GetAddSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddSpringConfig (global::Com.Facebook.Rebound.SpringConfig p0, string p1)
		{
			if (id_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_ == IntPtr.Zero)
				id_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addSpringConfig", "(Lcom/facebook/rebound/SpringConfig;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addSpringConfig_Lcom_facebook_rebound_SpringConfig_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSpringConfig", "(Lcom/facebook/rebound/SpringConfig;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeAllSpringConfig;
#pragma warning disable 0169
		static Delegate GetRemoveAllSpringConfigHandler ()
		{
			if (cb_removeAllSpringConfig == null)
				cb_removeAllSpringConfig = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllSpringConfig);
			return cb_removeAllSpringConfig;
		}

		static void n_RemoveAllSpringConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SpringConfigRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfigRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllSpringConfig ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllSpringConfig;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfigRegistry']/method[@name='removeAllSpringConfig' and count(parameter)=0]"
		[Register ("removeAllSpringConfig", "()V", "GetRemoveAllSpringConfigHandler")]
		public virtual unsafe void RemoveAllSpringConfig ()
		{
			if (id_removeAllSpringConfig == IntPtr.Zero)
				id_removeAllSpringConfig = JNIEnv.GetMethodID (class_ref, "removeAllSpringConfig", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllSpringConfig);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllSpringConfig", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_;
#pragma warning disable 0169
		static Delegate GetRemoveSpringConfig_Lcom_facebook_rebound_SpringConfig_Handler ()
		{
			if (cb_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_ == null)
				cb_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveSpringConfig_Lcom_facebook_rebound_SpringConfig_);
			return cb_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_;
		}

		static bool n_RemoveSpringConfig_Lcom_facebook_rebound_SpringConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Rebound.SpringConfigRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfigRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Rebound.SpringConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveSpringConfig (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfigRegistry']/method[@name='removeSpringConfig' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.SpringConfig']]"
		[Register ("removeSpringConfig", "(Lcom/facebook/rebound/SpringConfig;)Z", "GetRemoveSpringConfig_Lcom_facebook_rebound_SpringConfig_Handler")]
		public virtual unsafe bool RemoveSpringConfig (global::Com.Facebook.Rebound.SpringConfig p0)
		{
			if (id_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_ == IntPtr.Zero)
				id_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_ = JNIEnv.GetMethodID (class_ref, "removeSpringConfig", "(Lcom/facebook/rebound/SpringConfig;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeSpringConfig_Lcom_facebook_rebound_SpringConfig_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSpringConfig", "(Lcom/facebook/rebound/SpringConfig;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
