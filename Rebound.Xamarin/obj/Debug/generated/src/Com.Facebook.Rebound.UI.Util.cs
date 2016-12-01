using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/facebook/rebound/ui/Util", DoNotGenerateAcw=true)]
	public abstract partial class Util : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/ui/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Util)) {
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

		static IntPtr id_createLayoutParams_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']/method[@name='createLayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createLayoutParams", "(II)Landroid/widget/FrameLayout$LayoutParams;", "")]
		public static unsafe global::Android.Widget.FrameLayout.LayoutParams CreateLayoutParams (int p0, int p1)
		{
			if (id_createLayoutParams_II == IntPtr.Zero)
				id_createLayoutParams_II = JNIEnv.GetStaticMethodID (class_ref, "createLayoutParams", "(II)Landroid/widget/FrameLayout$LayoutParams;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLayoutParams_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMatchParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']/method[@name='createMatchParams' and count(parameter)=0]"
		[Register ("createMatchParams", "()Landroid/widget/FrameLayout$LayoutParams;", "")]
		public static unsafe global::Android.Widget.FrameLayout.LayoutParams CreateMatchParams ()
		{
			if (id_createMatchParams == IntPtr.Zero)
				id_createMatchParams = JNIEnv.GetStaticMethodID (class_ref, "createMatchParams", "()Landroid/widget/FrameLayout$LayoutParams;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMatchParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createMatchWrapParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']/method[@name='createMatchWrapParams' and count(parameter)=0]"
		[Register ("createMatchWrapParams", "()Landroid/widget/FrameLayout$LayoutParams;", "")]
		public static unsafe global::Android.Widget.FrameLayout.LayoutParams CreateMatchWrapParams ()
		{
			if (id_createMatchWrapParams == IntPtr.Zero)
				id_createMatchWrapParams = JNIEnv.GetStaticMethodID (class_ref, "createMatchWrapParams", "()Landroid/widget/FrameLayout$LayoutParams;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMatchWrapParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createWrapMatchParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']/method[@name='createWrapMatchParams' and count(parameter)=0]"
		[Register ("createWrapMatchParams", "()Landroid/widget/FrameLayout$LayoutParams;", "")]
		public static unsafe global::Android.Widget.FrameLayout.LayoutParams CreateWrapMatchParams ()
		{
			if (id_createWrapMatchParams == IntPtr.Zero)
				id_createWrapMatchParams = JNIEnv.GetStaticMethodID (class_ref, "createWrapMatchParams", "()Landroid/widget/FrameLayout$LayoutParams;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWrapMatchParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createWrapParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']/method[@name='createWrapParams' and count(parameter)=0]"
		[Register ("createWrapParams", "()Landroid/widget/FrameLayout$LayoutParams;", "")]
		public static unsafe global::Android.Widget.FrameLayout.LayoutParams CreateWrapParams ()
		{
			if (id_createWrapParams == IntPtr.Zero)
				id_createWrapParams = JNIEnv.GetStaticMethodID (class_ref, "createWrapParams", "()Landroid/widget/FrameLayout$LayoutParams;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createWrapParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dpToPx_FLandroid_content_res_Resources_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='Util']/method[@name='dpToPx' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.content.res.Resources']]"
		[Register ("dpToPx", "(FLandroid/content/res/Resources;)I", "")]
		public static unsafe int DpToPx (float p0, global::Android.Content.Res.Resources p1)
		{
			if (id_dpToPx_FLandroid_content_res_Resources_ == IntPtr.Zero)
				id_dpToPx_FLandroid_content_res_Resources_ = JNIEnv.GetStaticMethodID (class_ref, "dpToPx", "(FLandroid/content/res/Resources;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_dpToPx_FLandroid_content_res_Resources_, __args);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/facebook/rebound/ui/Util", DoNotGenerateAcw=true)]
	internal partial class UtilInvoker : Util {

		public UtilInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UtilInvoker); }
		}

	}

}
