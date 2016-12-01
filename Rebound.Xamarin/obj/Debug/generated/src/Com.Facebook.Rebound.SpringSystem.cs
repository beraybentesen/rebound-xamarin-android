using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringSystem']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SpringSystem", DoNotGenerateAcw=true)]
	public partial class SpringSystem : global::Com.Facebook.Rebound.BaseSpringSystem {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SpringSystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringSystem); }
		}

		protected SpringSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SpringSystem']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/facebook/rebound/SpringSystem;", "")]
		public static unsafe global::Com.Facebook.Rebound.SpringSystem Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/facebook/rebound/SpringSystem;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SpringSystem> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
