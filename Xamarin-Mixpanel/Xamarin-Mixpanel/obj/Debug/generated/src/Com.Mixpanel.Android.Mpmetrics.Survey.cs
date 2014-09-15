using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Mpmetrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey']"
	[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/Survey", DoNotGenerateAcw=true)]
	public partial class Survey : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.Question']"
		[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/Survey$Question", DoNotGenerateAcw=true)]
		public partial class Question : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/Survey$Question", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Question); }
			}

			protected Question (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getChoices;
#pragma warning disable 0169
			static Delegate GetGetChoicesHandler ()
			{
				if (cb_getChoices == null)
					cb_getChoices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChoices);
				return cb_getChoices;
			}

			static IntPtr n_GetChoices (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.Survey.Question __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Choices);
			}
#pragma warning restore 0169

			static IntPtr id_getChoices;
			public virtual global::System.Collections.Generic.IList<string> Choices {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.Question']/method[@name='getChoices' and count(parameter)=0]"
				[Register ("getChoices", "()Ljava/util/List;", "GetGetChoicesHandler")]
				get {
					if (id_getChoices == IntPtr.Zero)
						id_getChoices = JNIEnv.GetMethodID (class_ref, "getChoices", "()Ljava/util/List;");

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getChoices), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChoices", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getId;
#pragma warning disable 0169
			static Delegate GetGetIdHandler ()
			{
				if (cb_getId == null)
					cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
				return cb_getId;
			}

			static int n_GetId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.Survey.Question __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Id;
			}
#pragma warning restore 0169

			static IntPtr id_getId;
			public virtual int Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.Question']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()I", "GetGetIdHandler")]
				get {
					if (id_getId == IntPtr.Zero)
						id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()I"));
				}
			}

			static Delegate cb_getPrompt;
#pragma warning disable 0169
			static Delegate GetGetPromptHandler ()
			{
				if (cb_getPrompt == null)
					cb_getPrompt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrompt);
				return cb_getPrompt;
			}

			static IntPtr n_GetPrompt (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.Survey.Question __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Prompt);
			}
#pragma warning restore 0169

			static IntPtr id_getPrompt;
			public virtual string Prompt {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.Question']/method[@name='getPrompt' and count(parameter)=0]"
				[Register ("getPrompt", "()Ljava/lang/String;", "GetGetPromptHandler")]
				get {
					if (id_getPrompt == IntPtr.Zero)
						id_getPrompt = JNIEnv.GetMethodID (class_ref, "getPrompt", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPrompt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrompt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.Survey.Question __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Type);
			}
#pragma warning restore 0169

			static IntPtr id_getType;
			public virtual global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.Question']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;")), JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.QuestionType']"
		[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/Survey$QuestionType", DoNotGenerateAcw=true)]
		public partial class QuestionType : global::Java.Lang.Enum {


			static IntPtr MULTIPLE_CHOICE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.QuestionType']/field[@name='MULTIPLE_CHOICE']"
			[Register ("MULTIPLE_CHOICE")]
			public static global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType MultipleChoice {
				get {
					if (MULTIPLE_CHOICE_jfieldId == IntPtr.Zero)
						MULTIPLE_CHOICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTIPLE_CHOICE", "Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTIPLE_CHOICE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MULTIPLE_CHOICE_jfieldId == IntPtr.Zero)
						MULTIPLE_CHOICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTIPLE_CHOICE", "Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MULTIPLE_CHOICE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.QuestionType']/field[@name='TEXT']"
			[Register ("TEXT")]
			public static global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType Text {
				get {
					if (TEXT_jfieldId == IntPtr.Zero)
						TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TEXT_jfieldId == IntPtr.Zero)
						TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TEXT_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.QuestionType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/Survey$QuestionType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QuestionType); }
			}

			protected QuestionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.QuestionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;", "")]
			public static global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType __ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey.QuestionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;", "")]
			public static global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mixpanel/android/mpmetrics/Survey$QuestionType;");
				return (global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mixpanel.Android.Mpmetrics.Survey.QuestionType));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/Survey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Survey); }
		}

		protected Survey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCollectionId;
#pragma warning disable 0169
		static Delegate GetGetCollectionIdHandler ()
		{
			if (cb_getCollectionId == null)
				cb_getCollectionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCollectionId);
			return cb_getCollectionId;
		}

		static int n_GetCollectionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.Survey __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CollectionId;
		}
#pragma warning restore 0169

		static IntPtr id_getCollectionId;
		public virtual int CollectionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey']/method[@name='getCollectionId' and count(parameter)=0]"
			[Register ("getCollectionId", "()I", "GetGetCollectionIdHandler")]
			get {
				if (id_getCollectionId == IntPtr.Zero)
					id_getCollectionId = JNIEnv.GetMethodID (class_ref, "getCollectionId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCollectionId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCollectionId", "()I"));
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.Survey __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()I"));
			}
		}

		static Delegate cb_getQuestions;
#pragma warning disable 0169
		static Delegate GetGetQuestionsHandler ()
		{
			if (cb_getQuestions == null)
				cb_getQuestions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuestions);
			return cb_getQuestions;
		}

		static IntPtr n_GetQuestions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.Survey __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question>.ToLocalJniHandle (__this.Questions);
		}
#pragma warning restore 0169

		static IntPtr id_getQuestions;
		public virtual global::System.Collections.Generic.IList<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question> Questions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey']/method[@name='getQuestions' and count(parameter)=0]"
			[Register ("getQuestions", "()Ljava/util/List;", "GetGetQuestionsHandler")]
			get {
				if (id_getQuestions == IntPtr.Zero)
					id_getQuestions = JNIEnv.GetMethodID (class_ref, "getQuestions", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getQuestions), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Mixpanel.Android.Mpmetrics.Survey.Question>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuestions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.Survey __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Mixpanel.Android.Mpmetrics.Survey __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='Survey']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
		}

	}
}
