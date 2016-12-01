using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='OrigamiValueConverter']"
	[global::Android.Runtime.Register ("com/facebook/rebound/OrigamiValueConverter", DoNotGenerateAcw=true)]
	public partial class OrigamiValueConverter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/OrigamiValueConverter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OrigamiValueConverter); }
		}

		protected OrigamiValueConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='OrigamiValueConverter']/constructor[@name='OrigamiValueConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OrigamiValueConverter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OrigamiValueConverter)) {
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

		static IntPtr id_frictionFromOrigamiValue_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='OrigamiValueConverter']/method[@name='frictionFromOrigamiValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("frictionFromOrigamiValue", "(D)D", "")]
		public static unsafe double FrictionFromOrigamiValue (double p0)
		{
			if (id_frictionFromOrigamiValue_D == IntPtr.Zero)
				id_frictionFromOrigamiValue_D = JNIEnv.GetStaticMethodID (class_ref, "frictionFromOrigamiValue", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_frictionFromOrigamiValue_D, __args);
			} finally {
			}
		}

		static IntPtr id_origamiValueFromFriction_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='OrigamiValueConverter']/method[@name='origamiValueFromFriction' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("origamiValueFromFriction", "(D)D", "")]
		public static unsafe double OrigamiValueFromFriction (double p0)
		{
			if (id_origamiValueFromFriction_D == IntPtr.Zero)
				id_origamiValueFromFriction_D = JNIEnv.GetStaticMethodID (class_ref, "origamiValueFromFriction", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_origamiValueFromFriction_D, __args);
			} finally {
			}
		}

		static IntPtr id_origamiValueFromTension_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='OrigamiValueConverter']/method[@name='origamiValueFromTension' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("origamiValueFromTension", "(D)D", "")]
		public static unsafe double OrigamiValueFromTension (double p0)
		{
			if (id_origamiValueFromTension_D == IntPtr.Zero)
				id_origamiValueFromTension_D = JNIEnv.GetStaticMethodID (class_ref, "origamiValueFromTension", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_origamiValueFromTension_D, __args);
			} finally {
			}
		}

		static IntPtr id_tensionFromOrigamiValue_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='OrigamiValueConverter']/method[@name='tensionFromOrigamiValue' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("tensionFromOrigamiValue", "(D)D", "")]
		public static unsafe double TensionFromOrigamiValue (double p0)
		{
			if (id_tensionFromOrigamiValue_D == IntPtr.Zero)
				id_tensionFromOrigamiValue_D = JNIEnv.GetStaticMethodID (class_ref, "tensionFromOrigamiValue", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_tensionFromOrigamiValue_D, __args);
			} finally {
			}
		}

	}
}
