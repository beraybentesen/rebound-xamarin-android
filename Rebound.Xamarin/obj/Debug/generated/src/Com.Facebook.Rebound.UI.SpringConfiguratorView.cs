using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView']"
	[global::Android.Runtime.Register ("com/facebook/rebound/ui/SpringConfiguratorView", DoNotGenerateAcw=true)]
	public partial class SpringConfiguratorView : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.OnNubTouchListener']"
		[global::Android.Runtime.Register ("com/facebook/rebound/ui/SpringConfiguratorView$OnNubTouchListener", DoNotGenerateAcw=true)]
		public partial class OnNubTouchListener : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/rebound/ui/SpringConfiguratorView$OnNubTouchListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OnNubTouchListener); }
			}

			protected OnNubTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.OnNubTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.OnNubTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTouch (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.OnNubTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
			{
				if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.RevealerSpringListener']"
		[global::Android.Runtime.Register ("com/facebook/rebound/ui/SpringConfiguratorView$RevealerSpringListener", DoNotGenerateAcw=true)]
		public partial class RevealerSpringListener : global::Java.Lang.Object, global::Com.Facebook.Rebound.ISpringListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/rebound/ui/SpringConfiguratorView$RevealerSpringListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RevealerSpringListener); }
			}

			protected RevealerSpringListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSpringActivate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSpringActivate_Lcom_facebook_rebound_Spring_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.RevealerSpringListener']/method[@name='onSpringActivate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSpringAtRest (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSpringAtRest_Lcom_facebook_rebound_Spring_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.RevealerSpringListener']/method[@name='onSpringAtRest' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSpringEndStateChange (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSpringEndStateChange_Lcom_facebook_rebound_Spring_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.RevealerSpringListener']/method[@name='onSpringEndStateChange' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.RevealerSpringListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Rebound.Spring p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.Spring> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSpringUpdate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSpringUpdate_Lcom_facebook_rebound_Spring_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.RevealerSpringListener']/method[@name='onSpringUpdate' and count(parameter)=1 and parameter[1][@type='com.facebook.rebound.Spring']]"
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SeekbarListener']"
		[global::Android.Runtime.Register ("com/facebook/rebound/ui/SpringConfiguratorView$SeekbarListener", DoNotGenerateAcw=true)]
		public partial class SeekbarListener : global::Java.Lang.Object, global::Android.Widget.SeekBar.IOnSeekBarChangeListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/rebound/ui/SpringConfiguratorView$SeekbarListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SeekbarListener); }
			}

			protected SeekbarListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onProgressChanged_Landroid_widget_SeekBar_IZ;
#pragma warning disable 0169
			static Delegate GetOnProgressChanged_Landroid_widget_SeekBar_IZHandler ()
			{
				if (cb_onProgressChanged_Landroid_widget_SeekBar_IZ == null)
					cb_onProgressChanged_Landroid_widget_SeekBar_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_OnProgressChanged_Landroid_widget_SeekBar_IZ);
				return cb_onProgressChanged_Landroid_widget_SeekBar_IZ;
			}

			static void n_OnProgressChanged_Landroid_widget_SeekBar_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SeekbarListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SeekbarListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.SeekBar p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.SeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onProgressChanged_Landroid_widget_SeekBar_IZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SeekbarListener']/method[@name='onProgressChanged' and count(parameter)=3 and parameter[1][@type='android.widget.SeekBar'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("onProgressChanged", "(Landroid/widget/SeekBar;IZ)V", "GetOnProgressChanged_Landroid_widget_SeekBar_IZHandler")]
			public virtual unsafe void OnProgressChanged (global::Android.Widget.SeekBar p0, int p1, bool p2)
			{
				if (id_onProgressChanged_Landroid_widget_SeekBar_IZ == IntPtr.Zero)
					id_onProgressChanged_Landroid_widget_SeekBar_IZ = JNIEnv.GetMethodID (class_ref, "onProgressChanged", "(Landroid/widget/SeekBar;IZ)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressChanged_Landroid_widget_SeekBar_IZ, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProgressChanged", "(Landroid/widget/SeekBar;IZ)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onStartTrackingTouch_Landroid_widget_SeekBar_;
#pragma warning disable 0169
			static Delegate GetOnStartTrackingTouch_Landroid_widget_SeekBar_Handler ()
			{
				if (cb_onStartTrackingTouch_Landroid_widget_SeekBar_ == null)
					cb_onStartTrackingTouch_Landroid_widget_SeekBar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStartTrackingTouch_Landroid_widget_SeekBar_);
				return cb_onStartTrackingTouch_Landroid_widget_SeekBar_;
			}

			static void n_OnStartTrackingTouch_Landroid_widget_SeekBar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SeekbarListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SeekbarListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.SeekBar p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.SeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStartTrackingTouch (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onStartTrackingTouch_Landroid_widget_SeekBar_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SeekbarListener']/method[@name='onStartTrackingTouch' and count(parameter)=1 and parameter[1][@type='android.widget.SeekBar']]"
			[Register ("onStartTrackingTouch", "(Landroid/widget/SeekBar;)V", "GetOnStartTrackingTouch_Landroid_widget_SeekBar_Handler")]
			public virtual unsafe void OnStartTrackingTouch (global::Android.Widget.SeekBar p0)
			{
				if (id_onStartTrackingTouch_Landroid_widget_SeekBar_ == IntPtr.Zero)
					id_onStartTrackingTouch_Landroid_widget_SeekBar_ = JNIEnv.GetMethodID (class_ref, "onStartTrackingTouch", "(Landroid/widget/SeekBar;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartTrackingTouch_Landroid_widget_SeekBar_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartTrackingTouch", "(Landroid/widget/SeekBar;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onStopTrackingTouch_Landroid_widget_SeekBar_;
#pragma warning disable 0169
			static Delegate GetOnStopTrackingTouch_Landroid_widget_SeekBar_Handler ()
			{
				if (cb_onStopTrackingTouch_Landroid_widget_SeekBar_ == null)
					cb_onStopTrackingTouch_Landroid_widget_SeekBar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStopTrackingTouch_Landroid_widget_SeekBar_);
				return cb_onStopTrackingTouch_Landroid_widget_SeekBar_;
			}

			static void n_OnStopTrackingTouch_Landroid_widget_SeekBar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SeekbarListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SeekbarListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.SeekBar p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.SeekBar> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStopTrackingTouch (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onStopTrackingTouch_Landroid_widget_SeekBar_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SeekbarListener']/method[@name='onStopTrackingTouch' and count(parameter)=1 and parameter[1][@type='android.widget.SeekBar']]"
			[Register ("onStopTrackingTouch", "(Landroid/widget/SeekBar;)V", "GetOnStopTrackingTouch_Landroid_widget_SeekBar_Handler")]
			public virtual unsafe void OnStopTrackingTouch (global::Android.Widget.SeekBar p0)
			{
				if (id_onStopTrackingTouch_Landroid_widget_SeekBar_ == IntPtr.Zero)
					id_onStopTrackingTouch_Landroid_widget_SeekBar_ = JNIEnv.GetMethodID (class_ref, "onStopTrackingTouch", "(Landroid/widget/SeekBar;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopTrackingTouch_Landroid_widget_SeekBar_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStopTrackingTouch", "(Landroid/widget/SeekBar;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']"
		[global::Android.Runtime.Register ("com/facebook/rebound/ui/SpringConfiguratorView$SpinnerAdapter", DoNotGenerateAcw=true)]
		public partial class SpinnerAdapter : global::Android.Widget.BaseAdapter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/rebound/ui/SpringConfiguratorView$SpinnerAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpinnerAdapter); }
			}

			protected SpinnerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_facebook_rebound_ui_SpringConfiguratorView_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']/constructor[@name='SpringConfiguratorView.SpinnerAdapter' and count(parameter)=2 and parameter[1][@type='com.facebook.rebound.ui.SpringConfiguratorView'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/facebook/rebound/ui/SpringConfiguratorView;Landroid/content/Context;)V", "")]
			public unsafe SpinnerAdapter (global::Com.Facebook.Rebound.UI.SpringConfiguratorView __self, global::Android.Content.Context p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (SpinnerAdapter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Lcom_facebook_rebound_ui_SpringConfiguratorView_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Lcom_facebook_rebound_ui_SpringConfiguratorView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/facebook/rebound/ui/SpringConfiguratorView;Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_facebook_rebound_ui_SpringConfiguratorView_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_facebook_rebound_ui_SpringConfiguratorView_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static Delegate cb_getCount;
#pragma warning disable 0169
			static Delegate GetGetCountHandler ()
			{
				if (cb_getCount == null)
					cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
				return cb_getCount;
			}

			static int n_GetCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Count;
			}
#pragma warning restore 0169

			static IntPtr id_getCount;
			public override unsafe int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()I", "GetGetCountHandler")]
				get {
					if (id_getCount == IntPtr.Zero)
						id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_add_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAdd_Ljava_lang_String_Handler ()
			{
				if (cb_add_Ljava_lang_String_ == null)
					cb_add_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_);
				return cb_add_Ljava_lang_String_;
			}

			static void n_Add_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0);
			}
#pragma warning restore 0169

			static IntPtr id_add_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("add", "(Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Handler")]
			public virtual unsafe void Add (string p0)
			{
				if (id_add_Ljava_lang_String_ == IntPtr.Zero)
					id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_clear;
#pragma warning disable 0169
			static Delegate GetClearHandler ()
			{
				if (cb_clear == null)
					cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
				return cb_clear;
			}

			static void n_Clear (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clear ();
			}
#pragma warning restore 0169

			static IntPtr id_clear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']/method[@name='clear' and count(parameter)=0]"
			[Register ("clear", "()V", "GetClearHandler")]
			public virtual unsafe void Clear ()
			{
				if (id_clear == IntPtr.Zero)
					id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
				} finally {
				}
			}

			static Delegate cb_getItem_I;
#pragma warning disable 0169
			static Delegate GetGetItem_IHandler ()
			{
				if (cb_getItem_I == null)
					cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
				return cb_getItem_I;
			}

			static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getItem_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
			public override unsafe global::Java.Lang.Object GetItem (int p0)
			{
				if (id_getItem_I == IntPtr.Zero)
					id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getItemId_I;
#pragma warning disable 0169
			static Delegate GetGetItemId_IHandler ()
			{
				if (cb_getItemId_I == null)
					cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
				return cb_getItemId_I;
			}

			static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetItemId (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getItemId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
			public override unsafe long GetItemId (int p0)
			{
				if (id_getItemId_I == IntPtr.Zero)
					id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getItemId_I, __args);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
				} finally {
				}
			}

			static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
			static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
			{
				if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
					cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
				return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
			}

			static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpinnerAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
			[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
			public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
			{
				if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
					id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Android.Views.View __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpringSelectedListener']"
		[global::Android.Runtime.Register ("com/facebook/rebound/ui/SpringConfiguratorView$SpringSelectedListener", DoNotGenerateAcw=true)]
		public partial class SpringSelectedListener : global::Java.Lang.Object, global::Android.Widget.AdapterView.IOnItemSelectedListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/facebook/rebound/ui/SpringConfiguratorView$SpringSelectedListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpringSelectedListener); }
			}

			protected SpringSelectedListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;
#pragma warning disable 0169
			static Delegate GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler ()
			{
				if (cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
					cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ);
				return cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;
			}

			static void n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpringSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpringSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AdapterView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnItemSelected (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpringSelectedListener']/method[@name='onItemSelected' and count(parameter)=4 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register ("onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
			public virtual unsafe void OnItemSelected (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3)
			{
				if (id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ == IntPtr.Zero)
					id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNIEnv.GetMethodID (class_ref, "onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onNothingSelected_Landroid_widget_AdapterView_;
#pragma warning disable 0169
			static Delegate GetOnNothingSelected_Landroid_widget_AdapterView_Handler ()
			{
				if (cb_onNothingSelected_Landroid_widget_AdapterView_ == null)
					cb_onNothingSelected_Landroid_widget_AdapterView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNothingSelected_Landroid_widget_AdapterView_);
				return cb_onNothingSelected_Landroid_widget_AdapterView_;
			}

			static void n_OnNothingSelected_Landroid_widget_AdapterView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpringSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView.SpringSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AdapterView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNothingSelected (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onNothingSelected_Landroid_widget_AdapterView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView.SpringSelectedListener']/method[@name='onNothingSelected' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;']]"
			[Register ("onNothingSelected", "(Landroid/widget/AdapterView;)V", "GetOnNothingSelected_Landroid_widget_AdapterView_Handler")]
			public virtual unsafe void OnNothingSelected (global::Android.Widget.AdapterView p0)
			{
				if (id_onNothingSelected_Landroid_widget_AdapterView_ == IntPtr.Zero)
					id_onNothingSelected_Landroid_widget_AdapterView_ = JNIEnv.GetMethodID (class_ref, "onNothingSelected", "(Landroid/widget/AdapterView;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNothingSelected_Landroid_widget_AdapterView_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNothingSelected", "(Landroid/widget/AdapterView;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/ui/SpringConfiguratorView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpringConfiguratorView); }
		}

		protected SpringConfiguratorView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView']/constructor[@name='SpringConfiguratorView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SpringConfiguratorView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SpringConfiguratorView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView']/constructor[@name='SpringConfiguratorView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SpringConfiguratorView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SpringConfiguratorView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView']/constructor[@name='SpringConfiguratorView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SpringConfiguratorView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SpringConfiguratorView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
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
			global::Com.Facebook.Rebound.UI.SpringConfiguratorView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView']/method[@name='destroy' and count(parameter)=0]"
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

		static Delegate cb_refreshSpringConfigurations;
#pragma warning disable 0169
		static Delegate GetRefreshSpringConfigurationsHandler ()
		{
			if (cb_refreshSpringConfigurations == null)
				cb_refreshSpringConfigurations = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RefreshSpringConfigurations);
			return cb_refreshSpringConfigurations;
		}

		static void n_RefreshSpringConfigurations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.UI.SpringConfiguratorView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.UI.SpringConfiguratorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshSpringConfigurations ();
		}
#pragma warning restore 0169

		static IntPtr id_refreshSpringConfigurations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound.ui']/class[@name='SpringConfiguratorView']/method[@name='refreshSpringConfigurations' and count(parameter)=0]"
		[Register ("refreshSpringConfigurations", "()V", "GetRefreshSpringConfigurationsHandler")]
		public virtual unsafe void RefreshSpringConfigurations ()
		{
			if (id_refreshSpringConfigurations == IntPtr.Zero)
				id_refreshSpringConfigurations = JNIEnv.GetMethodID (class_ref, "refreshSpringConfigurations", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshSpringConfigurations);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshSpringConfigurations", "()V"));
			} finally {
			}
		}

	}
}
