using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Surveys {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']"
	[global::Android.Runtime.Register ("com/mixpanel/android/surveys/CardCarouselLayout", DoNotGenerateAcw=true)]
	public partial class CardCarouselLayout : global::Android.Views.ViewGroup {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.Direction']"
		[global::Android.Runtime.Register ("com/mixpanel/android/surveys/CardCarouselLayout$Direction", DoNotGenerateAcw=true)]
		public sealed partial class Direction : global::Java.Lang.Enum {


			static IntPtr BACKWARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.Direction']/field[@name='BACKWARD']"
			[Register ("BACKWARD")]
			public static global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction Backward {
				get {
					if (BACKWARD_jfieldId == IntPtr.Zero)
						BACKWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKWARD", "Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKWARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BACKWARD_jfieldId == IntPtr.Zero)
						BACKWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKWARD", "Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BACKWARD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr FORWARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.Direction']/field[@name='FORWARD']"
			[Register ("FORWARD")]
			public static global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction Forward {
				get {
					if (FORWARD_jfieldId == IntPtr.Zero)
						FORWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORWARD", "Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORWARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (FORWARD_jfieldId == IntPtr.Zero)
						FORWARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORWARD", "Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, FORWARD_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mixpanel/android/surveys/CardCarouselLayout$Direction", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Direction); }
			}

			internal Direction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.Direction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;", "")]
			public static global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction __ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.Direction']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;", "")]
			public static global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;");
				return (global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mixpanel.android.surveys']/interface[@name='CardCarouselLayout.OnQuestionAnsweredListener']"
		[Register ("com/mixpanel/android/surveys/CardCarouselLayout$OnQuestionAnsweredListener", "", "Com.Mixpanel.Android.Surveys.CardCarouselLayout/IOnQuestionAnsweredListenerInvoker")]
		public partial interface IOnQuestionAnsweredListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/interface[@name='CardCarouselLayout.OnQuestionAnsweredListener']/method[@name='onQuestionAnswered' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.mpmetrics.Survey.Question'] and parameter[2][@type='java.lang.String']]"
			[Register ("onQuestionAnswered", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V", "GetOnQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Handler:Com.Mixpanel.Android.Surveys.CardCarouselLayout/IOnQuestionAnsweredListenerInvoker, Xamarin-Mixpanel")]
			void OnQuestionAnswered (global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0, string p1);

		}

		[global::Android.Runtime.Register ("com/mixpanel/android/surveys/CardCarouselLayout$OnQuestionAnsweredListener", DoNotGenerateAcw=true)]
		internal class IOnQuestionAnsweredListenerInvoker : global::Java.Lang.Object, IOnQuestionAnsweredListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mixpanel/android/surveys/CardCarouselLayout$OnQuestionAnsweredListener");
			IntPtr class_ref;

			public static IOnQuestionAnsweredListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnQuestionAnsweredListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mixpanel.android.surveys.CardCarouselLayout.OnQuestionAnsweredListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnQuestionAnsweredListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnQuestionAnsweredListenerInvoker); }
			}

			static Delegate cb_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Handler ()
			{
				if (cb_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ == null)
					cb_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_);
				return cb_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
			}

			static void n_OnQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnQuestionAnswered (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
			public void OnQuestionAnswered (global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0, string p1)
			{
				if (id_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ == IntPtr.Zero)
					id_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQuestionAnswered", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JNIEnv.CallVoidMethod (Handle, id_onQuestionAnswered_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		public partial class QuestionAnsweredEventArgs : global::System.EventArgs {

			public QuestionAnsweredEventArgs (global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0, string p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0;
			public global::Com.Mixpanel.Android.Mpmetrics.Survey.Question P0 {
				get { return p0; }
			}

			string p1;
			public string P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mixpanel/android/surveys/CardCarouselLayout_OnQuestionAnsweredListenerImplementor")]
		internal sealed class IOnQuestionAnsweredListenerImplementor : global::Java.Lang.Object, IOnQuestionAnsweredListener {

			object sender;

			public IOnQuestionAnsweredListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mixpanel/android/surveys/CardCarouselLayout_OnQuestionAnsweredListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<QuestionAnsweredEventArgs> Handler;
#pragma warning restore 0649

			public void OnQuestionAnswered (global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0, string p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new QuestionAnsweredEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnQuestionAnsweredListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.QuestionCard']"
		[global::Android.Runtime.Register ("com/mixpanel/android/surveys/CardCarouselLayout$QuestionCard", DoNotGenerateAcw=true)]
		public partial class QuestionCard : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mixpanel/android/surveys/CardCarouselLayout$QuestionCard", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QuestionCard); }
			}

			protected QuestionCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_mixpanel_android_surveys_CardCarouselLayout_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.QuestionCard']/constructor[@name='CardCarouselLayout.QuestionCard' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.surveys.CardCarouselLayout'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/mixpanel/android/surveys/CardCarouselLayout;Landroid/view/View;)V", "")]
			public QuestionCard (global::Com.Mixpanel.Android.Surveys.CardCarouselLayout __self, global::Android.Views.View p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (QuestionCard)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_mixpanel_android_surveys_CardCarouselLayout_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Lcom_mixpanel_android_surveys_CardCarouselLayout_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mixpanel/android/surveys/CardCarouselLayout;Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mixpanel_android_surveys_CardCarouselLayout_Landroid_view_View_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mixpanel_android_surveys_CardCarouselLayout_Landroid_view_View_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_getView;
#pragma warning disable 0169
			static Delegate GetGetViewHandler ()
			{
				if (cb_getView == null)
					cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
				return cb_getView;
			}

			static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.QuestionCard __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.QuestionCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.View);
			}
#pragma warning restore 0169

			static IntPtr id_getView;
			public virtual global::Android.Views.View View {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.QuestionCard']/method[@name='getView' and count(parameter)=0]"
				[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
				get {
					if (id_getView == IntPtr.Zero)
						id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetShowQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Handler ()
			{
				if (cb_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ == null)
					cb_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_);
				return cb_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
			}

			static void n_ShowQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.QuestionCard __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.QuestionCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ShowQuestionOnCard (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.QuestionCard']/method[@name='showQuestionOnCard' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.mpmetrics.Survey.Question'] and parameter[2][@type='java.lang.String']]"
			[Register ("showQuestionOnCard", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V", "GetShowQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Handler")]
			public virtual void ShowQuestionOnCard (global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0, string p1)
			{
				if (id_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ == IntPtr.Zero)
					id_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showQuestionOnCard", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showQuestionOnCard_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showQuestionOnCard", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout.UnrecognizedAnswerTypeException']"
		[global::Android.Runtime.Register ("com/mixpanel/android/surveys/CardCarouselLayout$UnrecognizedAnswerTypeException", DoNotGenerateAcw=true)]
		public partial class UnrecognizedAnswerTypeException : global::Java.Lang.Exception {

			protected UnrecognizedAnswerTypeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/surveys/CardCarouselLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardCarouselLayout); }
		}

		protected CardCarouselLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']/constructor[@name='CardCarouselLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public CardCarouselLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CardCarouselLayout)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']/constructor[@name='CardCarouselLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public CardCarouselLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CardCarouselLayout)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']/constructor[@name='CardCarouselLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public CardCarouselLayout (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CardCarouselLayout)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_;
#pragma warning disable 0169
		static Delegate GetMoveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_Handler ()
		{
			if (cb_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_ == null)
				cb_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MoveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_);
			return cb_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_;
		}

		static void n_MoveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mixpanel.Android.Surveys.CardCarouselLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction p2 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.MoveTo (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']/method[@name='moveTo' and count(parameter)=3 and parameter[1][@type='com.mixpanel.android.mpmetrics.Survey.Question'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mixpanel.android.surveys.CardCarouselLayout.Direction']]"
		[Register ("moveTo", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;)V", "GetMoveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_Handler")]
		public virtual void MoveTo (global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0, string p1, global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.Direction p2)
		{
			if (id_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_ == IntPtr.Zero)
				id_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_ = JNIEnv.GetMethodID (class_ref, "moveTo", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_moveTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Lcom_mixpanel_android_surveys_CardCarouselLayout_Direction_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveTo", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;Lcom/mixpanel/android/surveys/CardCarouselLayout$Direction;)V"), new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Mixpanel.Android.Surveys.CardCarouselLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Handler ()
		{
			if (cb_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ == null)
				cb_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReplaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_);
			return cb_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
		}

		static void n_ReplaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mixpanel.Android.Surveys.CardCarouselLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']/method[@name='replaceTo' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.mpmetrics.Survey.Question'] and parameter[2][@type='java.lang.String']]"
		[Register ("replaceTo", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V", "GetReplaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_Handler")]
		public virtual void ReplaceTo (global::Com.Mixpanel.Android.Mpmetrics.Survey.Question p0, string p1)
		{
			if (id_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replaceTo", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_replaceTo_Lcom_mixpanel_android_mpmetrics_Survey_Question_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceTo", "(Lcom/mixpanel/android/mpmetrics/Survey$Question;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_;
#pragma warning disable 0169
		static Delegate GetSetOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_Handler ()
		{
			if (cb_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_ == null)
				cb_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_);
			return cb_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_;
		}

		static void n_SetOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Surveys.CardCarouselLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener p0 = (global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnQuestionAnsweredListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.surveys']/class[@name='CardCarouselLayout']/method[@name='setOnQuestionAnsweredListener' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.surveys.CardCarouselLayout.OnQuestionAnsweredListener']]"
		[Register ("setOnQuestionAnsweredListener", "(Lcom/mixpanel/android/surveys/CardCarouselLayout$OnQuestionAnsweredListener;)V", "GetSetOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_Handler")]
		public virtual void SetOnQuestionAnsweredListener (global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener p0)
		{
			if (id_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_ == IntPtr.Zero)
				id_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_ = JNIEnv.GetMethodID (class_ref, "setOnQuestionAnsweredListener", "(Lcom/mixpanel/android/surveys/CardCarouselLayout$OnQuestionAnsweredListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnQuestionAnsweredListener_Lcom_mixpanel_android_surveys_CardCarouselLayout_OnQuestionAnsweredListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnQuestionAnsweredListener", "(Lcom/mixpanel/android/surveys/CardCarouselLayout$OnQuestionAnsweredListener;)V"), new JValue (p0));
		}

#region "Event implementation for Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener"
		public event EventHandler<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.QuestionAnsweredEventArgs> QuestionAnswered {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener, global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListenerImplementor>(
						ref weak_implementor_SetOnQuestionAnsweredListener,
						__CreateIOnQuestionAnsweredListenerImplementor,
						SetOnQuestionAnsweredListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListener, global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListenerImplementor>(
						ref weak_implementor_SetOnQuestionAnsweredListener,
						global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListenerImplementor.__IsEmpty,
						__v => SetOnQuestionAnsweredListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnQuestionAnsweredListener;

		global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListenerImplementor __CreateIOnQuestionAnsweredListenerImplementor ()
		{
			return new global::Com.Mixpanel.Android.Surveys.CardCarouselLayout.IOnQuestionAnsweredListenerImplementor (this);
		}
#endregion
	}
}
