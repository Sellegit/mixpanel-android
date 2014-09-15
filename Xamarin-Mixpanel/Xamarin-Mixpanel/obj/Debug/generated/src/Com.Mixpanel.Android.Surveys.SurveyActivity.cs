using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Surveys {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='SurveyActivity']"
	[global::Android.Runtime.Register ("com/mixpanel/android/surveys/SurveyActivity", DoNotGenerateAcw=true)]
	public partial class SurveyActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='SurveyActivity']/field[@name='INTENT_ID_KEY']"
		[Register ("INTENT_ID_KEY")]
		public const string IntentIdKey = (string) "com.mixpanel.android.surveys.SurveyActivity.INTENT_ID_KEY";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/surveys/SurveyActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveyActivity); }
		}

		protected SurveyActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='SurveyActivity']/constructor[@name='SurveyActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SurveyActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SurveyActivity)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_completeSurvey_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCompleteSurvey_Landroid_view_View_Handler ()
		{
			if (cb_completeSurvey_Landroid_view_View_ == null)
				cb_completeSurvey_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CompleteSurvey_Landroid_view_View_);
			return cb_completeSurvey_Landroid_view_View_;
		}

		static void n_CompleteSurvey_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Surveys.SurveyActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.SurveyActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CompleteSurvey (p0);
		}
#pragma warning restore 0169

		static IntPtr id_completeSurvey_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='SurveyActivity']/method[@name='completeSurvey' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("completeSurvey", "(Landroid/view/View;)V", "GetCompleteSurvey_Landroid_view_View_Handler")]
		public virtual void CompleteSurvey (global::Android.Views.View p0)
		{
			if (id_completeSurvey_Landroid_view_View_ == IntPtr.Zero)
				id_completeSurvey_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "completeSurvey", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_completeSurvey_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "completeSurvey", "(Landroid/view/View;)V"), new JValue (p0));
		}

		static Delegate cb_goToNextQuestion_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGoToNextQuestion_Landroid_view_View_Handler ()
		{
			if (cb_goToNextQuestion_Landroid_view_View_ == null)
				cb_goToNextQuestion_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GoToNextQuestion_Landroid_view_View_);
			return cb_goToNextQuestion_Landroid_view_View_;
		}

		static void n_GoToNextQuestion_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Surveys.SurveyActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.SurveyActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GoToNextQuestion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_goToNextQuestion_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='SurveyActivity']/method[@name='goToNextQuestion' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("goToNextQuestion", "(Landroid/view/View;)V", "GetGoToNextQuestion_Landroid_view_View_Handler")]
		public virtual void GoToNextQuestion (global::Android.Views.View p0)
		{
			if (id_goToNextQuestion_Landroid_view_View_ == IntPtr.Zero)
				id_goToNextQuestion_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "goToNextQuestion", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_goToNextQuestion_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "goToNextQuestion", "(Landroid/view/View;)V"), new JValue (p0));
		}

		static Delegate cb_goToPreviousQuestion_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGoToPreviousQuestion_Landroid_view_View_Handler ()
		{
			if (cb_goToPreviousQuestion_Landroid_view_View_ == null)
				cb_goToPreviousQuestion_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GoToPreviousQuestion_Landroid_view_View_);
			return cb_goToPreviousQuestion_Landroid_view_View_;
		}

		static void n_GoToPreviousQuestion_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Surveys.SurveyActivity __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.SurveyActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GoToPreviousQuestion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_goToPreviousQuestion_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='SurveyActivity']/method[@name='goToPreviousQuestion' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("goToPreviousQuestion", "(Landroid/view/View;)V", "GetGoToPreviousQuestion_Landroid_view_View_Handler")]
		public virtual void GoToPreviousQuestion (global::Android.Views.View p0)
		{
			if (id_goToPreviousQuestion_Landroid_view_View_ == IntPtr.Zero)
				id_goToPreviousQuestion_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "goToPreviousQuestion", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_goToPreviousQuestion_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "goToPreviousQuestion", "(Landroid/view/View;)V"), new JValue (p0));
		}

	}
}
