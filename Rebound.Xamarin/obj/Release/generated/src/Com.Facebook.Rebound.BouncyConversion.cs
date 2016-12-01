using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Rebound {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BouncyConversion']"
	[global::Android.Runtime.Register ("com/facebook/rebound/BouncyConversion", DoNotGenerateAcw=true)]
	public partial class BouncyConversion : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/facebook/rebound/BouncyConversion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BouncyConversion); }
		}

		protected BouncyConversion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BouncyConversion']/constructor[@name='BouncyConversion' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe BouncyConversion (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BouncyConversion)) {
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

		static Delegate cb_getBounciness;
#pragma warning disable 0169
		static Delegate GetGetBouncinessHandler ()
		{
			if (cb_getBounciness == null)
				cb_getBounciness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBounciness);
			return cb_getBounciness;
		}

		static double n_GetBounciness (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BouncyConversion __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BouncyConversion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bounciness;
		}
#pragma warning restore 0169

		static IntPtr id_getBounciness;
		public virtual unsafe double Bounciness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BouncyConversion']/method[@name='getBounciness' and count(parameter)=0]"
			[Register ("getBounciness", "()D", "GetGetBouncinessHandler")]
			get {
				if (id_getBounciness == IntPtr.Zero)
					id_getBounciness = JNIEnv.GetMethodID (class_ref, "getBounciness", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBounciness);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBounciness", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getBouncyFriction;
#pragma warning disable 0169
		static Delegate GetGetBouncyFrictionHandler ()
		{
			if (cb_getBouncyFriction == null)
				cb_getBouncyFriction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBouncyFriction);
			return cb_getBouncyFriction;
		}

		static double n_GetBouncyFriction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BouncyConversion __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BouncyConversion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BouncyFriction;
		}
#pragma warning restore 0169

		static IntPtr id_getBouncyFriction;
		public virtual unsafe double BouncyFriction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BouncyConversion']/method[@name='getBouncyFriction' and count(parameter)=0]"
			[Register ("getBouncyFriction", "()D", "GetGetBouncyFrictionHandler")]
			get {
				if (id_getBouncyFriction == IntPtr.Zero)
					id_getBouncyFriction = JNIEnv.GetMethodID (class_ref, "getBouncyFriction", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBouncyFriction);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBouncyFriction", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getBouncyTension;
#pragma warning disable 0169
		static Delegate GetGetBouncyTensionHandler ()
		{
			if (cb_getBouncyTension == null)
				cb_getBouncyTension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBouncyTension);
			return cb_getBouncyTension;
		}

		static double n_GetBouncyTension (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BouncyConversion __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BouncyConversion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BouncyTension;
		}
#pragma warning restore 0169

		static IntPtr id_getBouncyTension;
		public virtual unsafe double BouncyTension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BouncyConversion']/method[@name='getBouncyTension' and count(parameter)=0]"
			[Register ("getBouncyTension", "()D", "GetGetBouncyTensionHandler")]
			get {
				if (id_getBouncyTension == IntPtr.Zero)
					id_getBouncyTension = JNIEnv.GetMethodID (class_ref, "getBouncyTension", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBouncyTension);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBouncyTension", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getSpeed;
#pragma warning disable 0169
		static Delegate GetGetSpeedHandler ()
		{
			if (cb_getSpeed == null)
				cb_getSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetSpeed);
			return cb_getSpeed;
		}

		static double n_GetSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Rebound.BouncyConversion __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Rebound.BouncyConversion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Speed;
		}
#pragma warning restore 0169

		static IntPtr id_getSpeed;
		public virtual unsafe double Speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.rebound']/class[@name='BouncyConversion']/method[@name='getSpeed' and count(parameter)=0]"
			[Register ("getSpeed", "()D", "GetGetSpeedHandler")]
			get {
				if (id_getSpeed == IntPtr.Zero)
					id_getSpeed = JNIEnv.GetMethodID (class_ref, "getSpeed", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getSpeed);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpeed", "()D"));
				} finally {
				}
			}
		}

	}
}
