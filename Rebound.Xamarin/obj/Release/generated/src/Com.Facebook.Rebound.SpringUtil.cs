using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringUtil']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SpringUtil", DoNotGenerateAcw=true)]
	public partial class SpringUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SpringUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringUtil); }
		}

		protected SpringUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringUtil']/constructor[@name='SpringUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpringUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SpringUtil)) {
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

		static IntPtr id_clamp_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringUtil']/method[@name='clamp' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("clamp", "(DDD)D", "")]
		public static unsafe double Clamp (double p0, double p1, double p2)
		{
			if (id_clamp_DDD == IntPtr.Zero)
				id_clamp_DDD = JNIEnv.GetStaticMethodID (class_ref, "clamp", "(DDD)D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_clamp_DDD, __args);
			} finally {
			}
		}

		static IntPtr id_mapValueFromRangeToRange_DDDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringUtil']/method[@name='mapValueFromRangeToRange' and count(parameter)=5 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double']]"
		[Register ("mapValueFromRangeToRange", "(DDDDD)D", "")]
		public static unsafe double MapValueFromRangeToRange (double p0, double p1, double p2, double p3, double p4)
		{
			if (id_mapValueFromRangeToRange_DDDDD == IntPtr.Zero)
				id_mapValueFromRangeToRange_DDDDD = JNIEnv.GetStaticMethodID (class_ref, "mapValueFromRangeToRange", "(DDDDD)D");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_mapValueFromRangeToRange_DDDDD, __args);
			} finally {
			}
		}

	}
}
