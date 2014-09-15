using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Mpmetrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']"
	[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/MPConfig", DoNotGenerateAcw=true)]
	public partial class MPConfig : global::Java.Lang.Object {


		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
			set {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "4.3.1";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/MPConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPConfig); }
		}

		protected MPConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAutoShowMixpanelUpdates;
#pragma warning disable 0169
		static Delegate GetGetAutoShowMixpanelUpdatesHandler ()
		{
			if (cb_getAutoShowMixpanelUpdates == null)
				cb_getAutoShowMixpanelUpdates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoShowMixpanelUpdates);
			return cb_getAutoShowMixpanelUpdates;
		}

		static bool n_GetAutoShowMixpanelUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoShowMixpanelUpdates;
		}
#pragma warning restore 0169

		static IntPtr id_getAutoShowMixpanelUpdates;
		public virtual bool AutoShowMixpanelUpdates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getAutoShowMixpanelUpdates' and count(parameter)=0]"
			[Register ("getAutoShowMixpanelUpdates", "()Z", "GetGetAutoShowMixpanelUpdatesHandler")]
			get {
				if (id_getAutoShowMixpanelUpdates == IntPtr.Zero)
					id_getAutoShowMixpanelUpdates = JNIEnv.GetMethodID (class_ref, "getAutoShowMixpanelUpdates", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getAutoShowMixpanelUpdates);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutoShowMixpanelUpdates", "()Z"));
			}
		}

		static Delegate cb_getBulkUploadLimit;
#pragma warning disable 0169
		static Delegate GetGetBulkUploadLimitHandler ()
		{
			if (cb_getBulkUploadLimit == null)
				cb_getBulkUploadLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBulkUploadLimit);
			return cb_getBulkUploadLimit;
		}

		static int n_GetBulkUploadLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BulkUploadLimit;
		}
#pragma warning restore 0169

		static IntPtr id_getBulkUploadLimit;
		public virtual int BulkUploadLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getBulkUploadLimit' and count(parameter)=0]"
			[Register ("getBulkUploadLimit", "()I", "GetGetBulkUploadLimitHandler")]
			get {
				if (id_getBulkUploadLimit == IntPtr.Zero)
					id_getBulkUploadLimit = JNIEnv.GetMethodID (class_ref, "getBulkUploadLimit", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getBulkUploadLimit);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBulkUploadLimit", "()I"));
			}
		}

		static Delegate cb_getDataExpiration;
#pragma warning disable 0169
		static Delegate GetGetDataExpirationHandler ()
		{
			if (cb_getDataExpiration == null)
				cb_getDataExpiration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataExpiration);
			return cb_getDataExpiration;
		}

		static int n_GetDataExpiration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataExpiration;
		}
#pragma warning restore 0169

		static IntPtr id_getDataExpiration;
		public virtual int DataExpiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getDataExpiration' and count(parameter)=0]"
			[Register ("getDataExpiration", "()I", "GetGetDataExpirationHandler")]
			get {
				if (id_getDataExpiration == IntPtr.Zero)
					id_getDataExpiration = JNIEnv.GetMethodID (class_ref, "getDataExpiration", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDataExpiration);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataExpiration", "()I"));
			}
		}

		static Delegate cb_getDecideEndpoint;
#pragma warning disable 0169
		static Delegate GetGetDecideEndpointHandler ()
		{
			if (cb_getDecideEndpoint == null)
				cb_getDecideEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecideEndpoint);
			return cb_getDecideEndpoint;
		}

		static IntPtr n_GetDecideEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DecideEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getDecideEndpoint;
		public virtual string DecideEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getDecideEndpoint' and count(parameter)=0]"
			[Register ("getDecideEndpoint", "()Ljava/lang/String;", "GetGetDecideEndpointHandler")]
			get {
				if (id_getDecideEndpoint == IntPtr.Zero)
					id_getDecideEndpoint = JNIEnv.GetMethodID (class_ref, "getDecideEndpoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDecideEndpoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecideEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDecideFallbackEndpoint;
#pragma warning disable 0169
		static Delegate GetGetDecideFallbackEndpointHandler ()
		{
			if (cb_getDecideFallbackEndpoint == null)
				cb_getDecideFallbackEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecideFallbackEndpoint);
			return cb_getDecideFallbackEndpoint;
		}

		static IntPtr n_GetDecideFallbackEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DecideFallbackEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getDecideFallbackEndpoint;
		public virtual string DecideFallbackEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getDecideFallbackEndpoint' and count(parameter)=0]"
			[Register ("getDecideFallbackEndpoint", "()Ljava/lang/String;", "GetGetDecideFallbackEndpointHandler")]
			get {
				if (id_getDecideFallbackEndpoint == IntPtr.Zero)
					id_getDecideFallbackEndpoint = JNIEnv.GetMethodID (class_ref, "getDecideFallbackEndpoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDecideFallbackEndpoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecideFallbackEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDisableFallback;
#pragma warning disable 0169
		static Delegate GetGetDisableFallbackHandler ()
		{
			if (cb_getDisableFallback == null)
				cb_getDisableFallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetDisableFallback);
			return cb_getDisableFallback;
		}

		static bool n_GetDisableFallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableFallback;
		}
#pragma warning restore 0169

		static IntPtr id_getDisableFallback;
		public virtual bool DisableFallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getDisableFallback' and count(parameter)=0]"
			[Register ("getDisableFallback", "()Z", "GetGetDisableFallbackHandler")]
			get {
				if (id_getDisableFallback == IntPtr.Zero)
					id_getDisableFallback = JNIEnv.GetMethodID (class_ref, "getDisableFallback", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getDisableFallback);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisableFallback", "()Z"));
			}
		}

		static Delegate cb_getEventsEndpoint;
#pragma warning disable 0169
		static Delegate GetGetEventsEndpointHandler ()
		{
			if (cb_getEventsEndpoint == null)
				cb_getEventsEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventsEndpoint);
			return cb_getEventsEndpoint;
		}

		static IntPtr n_GetEventsEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventsEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEventsEndpoint;
		public virtual string EventsEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getEventsEndpoint' and count(parameter)=0]"
			[Register ("getEventsEndpoint", "()Ljava/lang/String;", "GetGetEventsEndpointHandler")]
			get {
				if (id_getEventsEndpoint == IntPtr.Zero)
					id_getEventsEndpoint = JNIEnv.GetMethodID (class_ref, "getEventsEndpoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEventsEndpoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventsEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEventsFallbackEndpoint;
#pragma warning disable 0169
		static Delegate GetGetEventsFallbackEndpointHandler ()
		{
			if (cb_getEventsFallbackEndpoint == null)
				cb_getEventsFallbackEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventsFallbackEndpoint);
			return cb_getEventsFallbackEndpoint;
		}

		static IntPtr n_GetEventsFallbackEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventsFallbackEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEventsFallbackEndpoint;
		public virtual string EventsFallbackEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getEventsFallbackEndpoint' and count(parameter)=0]"
			[Register ("getEventsFallbackEndpoint", "()Ljava/lang/String;", "GetGetEventsFallbackEndpointHandler")]
			get {
				if (id_getEventsFallbackEndpoint == IntPtr.Zero)
					id_getEventsFallbackEndpoint = JNIEnv.GetMethodID (class_ref, "getEventsFallbackEndpoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEventsFallbackEndpoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventsFallbackEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFlushInterval;
#pragma warning disable 0169
		static Delegate GetGetFlushIntervalHandler ()
		{
			if (cb_getFlushInterval == null)
				cb_getFlushInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFlushInterval);
			return cb_getFlushInterval;
		}

		static int n_GetFlushInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FlushInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getFlushInterval;
		public virtual int FlushInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getFlushInterval' and count(parameter)=0]"
			[Register ("getFlushInterval", "()I", "GetGetFlushIntervalHandler")]
			get {
				if (id_getFlushInterval == IntPtr.Zero)
					id_getFlushInterval = JNIEnv.GetMethodID (class_ref, "getFlushInterval", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getFlushInterval);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlushInterval", "()I"));
			}
		}

		static Delegate cb_getPeopleEndpoint;
#pragma warning disable 0169
		static Delegate GetGetPeopleEndpointHandler ()
		{
			if (cb_getPeopleEndpoint == null)
				cb_getPeopleEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeopleEndpoint);
			return cb_getPeopleEndpoint;
		}

		static IntPtr n_GetPeopleEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PeopleEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getPeopleEndpoint;
		public virtual string PeopleEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getPeopleEndpoint' and count(parameter)=0]"
			[Register ("getPeopleEndpoint", "()Ljava/lang/String;", "GetGetPeopleEndpointHandler")]
			get {
				if (id_getPeopleEndpoint == IntPtr.Zero)
					id_getPeopleEndpoint = JNIEnv.GetMethodID (class_ref, "getPeopleEndpoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPeopleEndpoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeopleEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPeopleFallbackEndpoint;
#pragma warning disable 0169
		static Delegate GetGetPeopleFallbackEndpointHandler ()
		{
			if (cb_getPeopleFallbackEndpoint == null)
				cb_getPeopleFallbackEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeopleFallbackEndpoint);
			return cb_getPeopleFallbackEndpoint;
		}

		static IntPtr n_GetPeopleFallbackEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PeopleFallbackEndpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getPeopleFallbackEndpoint;
		public virtual string PeopleFallbackEndpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getPeopleFallbackEndpoint' and count(parameter)=0]"
			[Register ("getPeopleFallbackEndpoint", "()Ljava/lang/String;", "GetGetPeopleFallbackEndpointHandler")]
			get {
				if (id_getPeopleFallbackEndpoint == IntPtr.Zero)
					id_getPeopleFallbackEndpoint = JNIEnv.GetMethodID (class_ref, "getPeopleFallbackEndpoint", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPeopleFallbackEndpoint), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeopleFallbackEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTestMode;
#pragma warning disable 0169
		static Delegate GetGetTestModeHandler ()
		{
			if (cb_getTestMode == null)
				cb_getTestMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTestMode);
			return cb_getTestMode;
		}

		static bool n_GetTestMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TestMode;
		}
#pragma warning restore 0169

		static IntPtr id_getTestMode;
		public virtual bool TestMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getTestMode' and count(parameter)=0]"
			[Register ("getTestMode", "()Z", "GetGetTestModeHandler")]
			get {
				if (id_getTestMode == IntPtr.Zero)
					id_getTestMode = JNIEnv.GetMethodID (class_ref, "getTestMode", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getTestMode);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTestMode", "()Z"));
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MPConfig']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/mixpanel/android/mpmetrics/MPConfig;", "")]
		public static global::Com.Mixpanel.Android.Mpmetrics.MPConfig GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/mixpanel/android/mpmetrics/MPConfig;");
			global::Com.Mixpanel.Android.Mpmetrics.MPConfig __ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MPConfig> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
