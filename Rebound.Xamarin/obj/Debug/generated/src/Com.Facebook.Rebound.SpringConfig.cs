using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfig']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SpringConfig", DoNotGenerateAcw=true)]
	public partial class SpringConfig : global::Java.Lang.Object {


		static IntPtr defaultConfig_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfig']/field[@name='defaultConfig']"
		[Register ("defaultConfig")]
		public static global::Com.Facebook.Rebound.SpringConfig DefaultConfig {
			get {
				if (defaultConfig_jfieldId == IntPtr.Zero)
					defaultConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultConfig", "Lcom/facebook/rebound/SpringConfig;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, defaultConfig_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (defaultConfig_jfieldId == IntPtr.Zero)
					defaultConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultConfig", "Lcom/facebook/rebound/SpringConfig;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, defaultConfig_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr friction_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfig']/field[@name='friction']"
		[Register ("friction")]
		public double Friction {
			get {
				if (friction_jfieldId == IntPtr.Zero)
					friction_jfieldId = JNIEnv.GetFieldID (class_ref, "friction", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, friction_jfieldId);
			}
			set {
				if (friction_jfieldId == IntPtr.Zero)
					friction_jfieldId = JNIEnv.GetFieldID (class_ref, "friction", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, friction_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr tension_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfig']/field[@name='tension']"
		[Register ("tension")]
		public double Tension {
			get {
				if (tension_jfieldId == IntPtr.Zero)
					tension_jfieldId = JNIEnv.GetFieldID (class_ref, "tension", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, tension_jfieldId);
			}
			set {
				if (tension_jfieldId == IntPtr.Zero)
					tension_jfieldId = JNIEnv.GetFieldID (class_ref, "tension", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tension_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SpringConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringConfig); }
		}

		protected SpringConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfig']/constructor[@name='SpringConfig' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe SpringConfig (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SpringConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

		static IntPtr id_fromBouncinessAndSpeed_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfig']/method[@name='fromBouncinessAndSpeed' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("fromBouncinessAndSpeed", "(DD)Lcom/facebook/rebound/SpringConfig;", "")]
		public static unsafe global::Com.Facebook.Rebound.SpringConfig FromBouncinessAndSpeed (double p0, double p1)
		{
			if (id_fromBouncinessAndSpeed_DD == IntPtr.Zero)
				id_fromBouncinessAndSpeed_DD = JNIEnv.GetStaticMethodID (class_ref, "fromBouncinessAndSpeed", "(DD)Lcom/facebook/rebound/SpringConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBouncinessAndSpeed_DD, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromOrigamiTensionAndFriction_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringConfig']/method[@name='fromOrigamiTensionAndFriction' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("fromOrigamiTensionAndFriction", "(DD)Lcom/facebook/rebound/SpringConfig;", "")]
		public static unsafe global::Com.Facebook.Rebound.SpringConfig FromOrigamiTensionAndFriction (double p0, double p1)
		{
			if (id_fromOrigamiTensionAndFriction_DD == IntPtr.Zero)
				id_fromOrigamiTensionAndFriction_DD = JNIEnv.GetStaticMethodID (class_ref, "fromOrigamiTensionAndFriction", "(DD)Lcom/facebook/rebound/SpringConfig;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromOrigamiTensionAndFriction_DD, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
