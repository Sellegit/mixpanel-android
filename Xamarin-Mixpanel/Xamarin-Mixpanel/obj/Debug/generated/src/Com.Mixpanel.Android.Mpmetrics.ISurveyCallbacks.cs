using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Mpmetrics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='SurveyCallbacks']"
	[Register ("com/mixpanel/android/mpmetrics/SurveyCallbacks", "", "Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacksInvoker")]
	public partial interface ISurveyCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='SurveyCallbacks']/method[@name='foundSurvey' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.Survey']]"
		[Register ("foundSurvey", "(Lcom/mixpanel/android/mpmetrics/Survey;)V", "GetFoundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Handler:Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacksInvoker, Xamarin-Mixpanel")]
		void FoundSurvey (global::Com.Mixpanel.Android.Mpmetrics.Survey p0);

	}

	[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/SurveyCallbacks", DoNotGenerateAcw=true)]
	internal class ISurveyCallbacksInvoker : global::Java.Lang.Object, ISurveyCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/SurveyCallbacks");
		IntPtr class_ref;

		public static ISurveyCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurveyCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mixpanel.android.mpmetrics.SurveyCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurveyCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISurveyCallbacksInvoker); }
		}

		static Delegate cb_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_;
#pragma warning disable 0169
		static Delegate GetFoundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Handler ()
		{
			if (cb_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_ == null)
				cb_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FoundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_);
			return cb_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_;
		}

		static void n_FoundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mixpanel.Android.Mpmetrics.Survey p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FoundSurvey (p0);
		}
#pragma warning restore 0169

		IntPtr id_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_;
		public void FoundSurvey (global::Com.Mixpanel.Android.Mpmetrics.Survey p0)
		{
			if (id_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_ == IntPtr.Zero)
				id_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_ = JNIEnv.GetMethodID (class_ref, "foundSurvey", "(Lcom/mixpanel/android/mpmetrics/Survey;)V");
			JNIEnv.CallVoidMethod (Handle, id_foundSurvey_Lcom_mixpanel_android_mpmetrics_Survey_, new JValue (p0));
		}

	}

}
