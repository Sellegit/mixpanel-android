using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Mpmetrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']"
	[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/InAppNotification", DoNotGenerateAcw=true)]
	public partial class InAppNotification : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/field[@name='CREATOR']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification.Type']"
		[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/InAppNotification$Type", DoNotGenerateAcw=true)]
		public partial class Type : global::Java.Lang.Enum {


			static IntPtr MINI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification.Type']/field[@name='MINI']"
			[Register ("MINI")]
			public static global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type Mini {
				get {
					if (MINI_jfieldId == IntPtr.Zero)
						MINI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MINI", "Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MINI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MINI_jfieldId == IntPtr.Zero)
						MINI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MINI", "Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MINI_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TAKEOVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification.Type']/field[@name='TAKEOVER']"
			[Register ("TAKEOVER")]
			public static global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type Takeover {
				get {
					if (TAKEOVER_jfieldId == IntPtr.Zero)
						TAKEOVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAKEOVER", "Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAKEOVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TAKEOVER_jfieldId == IntPtr.Zero)
						TAKEOVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAKEOVER", "Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TAKEOVER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/InAppNotification$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			protected Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;", "")]
			public static global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;", "")]
			public static global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mixpanel/android/mpmetrics/InAppNotification$Type;");
				return (global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mixpanel.Android.Mpmetrics.InAppNotification.Type));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/InAppNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InAppNotification); }
		}

		protected InAppNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/constructor[@name='InAppNotification' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public InAppNotification (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InAppNotification)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
				id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0));
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Body);
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		public virtual string Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCallToAction;
#pragma warning disable 0169
		static Delegate GetGetCallToActionHandler ()
		{
			if (cb_getCallToAction == null)
				cb_getCallToAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallToAction);
			return cb_getCallToAction;
		}

		static IntPtr n_GetCallToAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallToAction);
		}
#pragma warning restore 0169

		static IntPtr id_getCallToAction;
		public virtual string CallToAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getCallToAction' and count(parameter)=0]"
			[Register ("getCallToAction", "()Ljava/lang/String;", "GetGetCallToActionHandler")]
			get {
				if (id_getCallToAction == IntPtr.Zero)
					id_getCallToAction = JNIEnv.GetMethodID (class_ref, "getCallToAction", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCallToAction), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallToAction", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCallToActionUrl;
#pragma warning disable 0169
		static Delegate GetGetCallToActionUrlHandler ()
		{
			if (cb_getCallToActionUrl == null)
				cb_getCallToActionUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallToActionUrl);
			return cb_getCallToActionUrl;
		}

		static IntPtr n_GetCallToActionUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallToActionUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getCallToActionUrl;
		public virtual string CallToActionUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getCallToActionUrl' and count(parameter)=0]"
			[Register ("getCallToActionUrl", "()Ljava/lang/String;", "GetGetCallToActionUrlHandler")]
			get {
				if (id_getCallToActionUrl == IntPtr.Zero)
					id_getCallToActionUrl = JNIEnv.GetMethodID (class_ref, "getCallToActionUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCallToActionUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallToActionUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		public virtual global::Android.Graphics.Bitmap Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/Bitmap;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/Bitmap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImage2xUrl;
#pragma warning disable 0169
		static Delegate GetGetImage2xUrlHandler ()
		{
			if (cb_getImage2xUrl == null)
				cb_getImage2xUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage2xUrl);
			return cb_getImage2xUrl;
		}

		static IntPtr n_GetImage2xUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Image2xUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getImage2xUrl;
		public virtual string Image2xUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getImage2xUrl' and count(parameter)=0]"
			[Register ("getImage2xUrl", "()Ljava/lang/String;", "GetGetImage2xUrlHandler")]
			get {
				if (id_getImage2xUrl == IntPtr.Zero)
					id_getImage2xUrl = JNIEnv.GetMethodID (class_ref, "getImage2xUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImage2xUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage2xUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImage4xUrl;
#pragma warning disable 0169
		static Delegate GetGetImage4xUrlHandler ()
		{
			if (cb_getImage4xUrl == null)
				cb_getImage4xUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage4xUrl);
			return cb_getImage4xUrl;
		}

		static IntPtr n_GetImage4xUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Image4xUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getImage4xUrl;
		public virtual string Image4xUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getImage4xUrl' and count(parameter)=0]"
			[Register ("getImage4xUrl", "()Ljava/lang/String;", "GetGetImage4xUrlHandler")]
			get {
				if (id_getImage4xUrl == IntPtr.Zero)
					id_getImage4xUrl = JNIEnv.GetMethodID (class_ref, "getImage4xUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImage4xUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage4xUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImageUrl;
#pragma warning disable 0169
		static Delegate GetGetImageUrlHandler ()
		{
			if (cb_getImageUrl == null)
				cb_getImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUrl);
			return cb_getImageUrl;
		}

		static IntPtr n_GetImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getImageUrl;
		public virtual string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getImageUrl' and count(parameter)=0]"
			[Register ("getImageUrl", "()Ljava/lang/String;", "GetGetImageUrlHandler")]
			get {
				if (id_getImageUrl == IntPtr.Zero)
					id_getImageUrl = JNIEnv.GetMethodID (class_ref, "getImageUrl", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getImageUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageId);
			return cb_getMessageId;
		}

		static int n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageId;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		public virtual int MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()I", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMessageId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageId", "()I"));
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='InAppNotification']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
