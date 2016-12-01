using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SynchronousLooper']"
	[global::Android.Runtime.Register ("com/facebook/rebound/SynchronousLooper", DoNotGenerateAcw=true)]
	public partial class SynchronousLooper : global::Com.Facebook.Rebound.SpringLooper {


		static IntPtr SIXTY_FPS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SynchronousLooper']/field[@name='SIXTY_FPS']"
		[Register ("SIXTY_FPS")]
		public static double SixtyFps {
			get {
				if (SIXTY_FPS_jfieldId == IntPtr.Zero)
					SIXTY_FPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIXTY_FPS", "D");
				return JNIEnv.GetStaticDoubleField (class_ref, SIXTY_FPS_jfieldId);
			}
			set {
				if (SIXTY_FPS_jfieldId == IntPtr.Zero)
					SIXTY_FPS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIXTY_FPS", "D");
				try {
					JNIEnv.SetStaticField (class_ref, SIXTY_FPS_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/SynchronousLooper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SynchronousLooper); }
		}

		protected SynchronousLooper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SynchronousLooper']/constructor[@name='SynchronousLooper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SynchronousLooper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SynchronousLooper)) {
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

		static Delegate cb_getTimeStep;
#pragma warning disable 0169
		static Delegate GetGetTimeStepHandler ()
		{
			if (cb_getTimeStep == null)
				cb_getTimeStep = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTimeStep);
			return cb_getTimeStep;
		}

		static double n_GetTimeStep (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SynchronousLooper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SynchronousLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStep;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeStep_D;
#pragma warning disable 0169
		static Delegate GetSetTimeStep_DHandler ()
		{
			if (cb_setTimeStep_D == null)
				cb_setTimeStep_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetTimeStep_D);
			return cb_setTimeStep_D;
		}

		static void n_SetTimeStep_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Facebook.Rebound.SynchronousLooper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SynchronousLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimeStep = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStep;
		static IntPtr id_setTimeStep_D;
		public virtual unsafe double TimeStep {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SynchronousLooper']/method[@name='getTimeStep' and count(parameter)=0]"
			[Register ("getTimeStep", "()D", "GetGetTimeStepHandler")]
			get {
				if (id_getTimeStep == IntPtr.Zero)
					id_getTimeStep = JNIEnv.GetMethodID (class_ref, "getTimeStep", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getTimeStep);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStep", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SynchronousLooper']/method[@name='setTimeStep' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setTimeStep", "(D)V", "GetSetTimeStep_DHandler")]
			set {
				if (id_setTimeStep_D == IntPtr.Zero)
					id_setTimeStep_D = JNIEnv.GetMethodID (class_ref, "setTimeStep", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeStep_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeStep", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SynchronousLooper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SynchronousLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SynchronousLooper']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.SynchronousLooper __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.SynchronousLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='SynchronousLooper']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
