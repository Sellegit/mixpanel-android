using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Mpmetrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']"
	[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/MixpanelAPI", DoNotGenerateAcw=true)]
	public partial class MixpanelAPI : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "4.3.1";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.InstanceProcessor']"
		[Register ("com/mixpanel/android/mpmetrics/MixpanelAPI$InstanceProcessor", "", "Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IInstanceProcessorInvoker")]
		public partial interface IInstanceProcessor : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.InstanceProcessor']/method[@name='process' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.MixpanelAPI']]"
			[Register ("process", "(Lcom/mixpanel/android/mpmetrics/MixpanelAPI;)V", "GetProcess_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IInstanceProcessorInvoker, Xamarin-Mixpanel")]
			void Process (global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI p0);

		}

		[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/MixpanelAPI$InstanceProcessor", DoNotGenerateAcw=true)]
		internal class IInstanceProcessorInvoker : global::Java.Lang.Object, IInstanceProcessor {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/MixpanelAPI$InstanceProcessor");
			IntPtr class_ref;

			public static IInstanceProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInstanceProcessor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mixpanel.android.mpmetrics.MixpanelAPI.InstanceProcessor"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInstanceProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IInstanceProcessorInvoker); }
			}

			static Delegate cb_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_;
#pragma warning disable 0169
			static Delegate GetProcess_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_Handler ()
			{
				if (cb_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_ == null)
					cb_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_);
				return cb_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_;
			}

			static void n_Process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IInstanceProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IInstanceProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Process (p0);
			}
#pragma warning restore 0169

			IntPtr id_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_;
			public void Process (global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI p0)
			{
				if (id_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_ == IntPtr.Zero)
					id_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_ = JNIEnv.GetMethodID (class_ref, "process", "(Lcom/mixpanel/android/mpmetrics/MixpanelAPI;)V");
				JNIEnv.CallVoidMethod (Handle, id_process_Lcom_mixpanel_android_mpmetrics_MixpanelAPI_, new JValue (p0));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']"
		[Register ("com/mixpanel/android/mpmetrics/MixpanelAPI$People", "", "Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker")]
		public partial interface IPeople : IJavaObject {

			string DistinctId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='getDistinctId' and count(parameter)=0]"
				[Register ("getDistinctId", "()Ljava/lang/String;", "GetGetDistinctIdHandler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")] get;
			}

			global::Com.Mixpanel.Android.Mpmetrics.InAppNotification NotificationIfAvailable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='getNotificationIfAvailable' and count(parameter)=0]"
				[Register ("getNotificationIfAvailable", "()Lcom/mixpanel/android/mpmetrics/InAppNotification;", "GetGetNotificationIfAvailableHandler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")] get;
			}

			global::Com.Mixpanel.Android.Mpmetrics.Survey SurveyIfAvailable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='getSurveyIfAvailable' and count(parameter)=0]"
				[Register ("getSurveyIfAvailable", "()Lcom/mixpanel/android/mpmetrics/Survey;", "GetGetSurveyIfAvailableHandler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='addOnMixpanelUpdatesReceivedListener' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.OnMixpanelUpdatesReceivedListener']]"
			[Register ("addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V", "GetAddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void AddOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("append", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetAppend_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Append (string p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='checkForSurvey' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.SurveyCallbacks']]"
[Obsolete (@"deprecated")]
			[Register ("checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;)V", "GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void CheckForSurvey (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='checkForSurvey' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.mpmetrics.SurveyCallbacks'] and parameter[2][@type='android.app.Activity']]"
[Obsolete (@"deprecated")]
			[Register ("checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;Landroid/app/Activity;)V", "GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void CheckForSurvey (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0, global::Android.App.Activity p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='clearCharges' and count(parameter)=0]"
			[Register ("clearCharges", "()V", "GetClearChargesHandler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void ClearCharges ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='clearPushRegistrationId' and count(parameter)=0]"
			[Register ("clearPushRegistrationId", "()V", "GetClearPushRegistrationIdHandler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void ClearPushRegistrationId ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='deleteUser' and count(parameter)=0]"
			[Register ("deleteUser", "()V", "GetDeleteUserHandler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void DeleteUser ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='identify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("identify", "(Ljava/lang/String;)V", "GetIdentify_Ljava_lang_String_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Identify (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='increment' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
			[Register ("increment", "(Ljava/lang/String;D)V", "GetIncrement_Ljava_lang_String_DHandler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Increment (string p0, double p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("increment", "(Ljava/util/Map;)V", "GetIncrement_Ljava_util_Map_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Increment (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Number> p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='initPushHandling' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("initPushHandling", "(Ljava/lang/String;)V", "GetInitPushHandling_Ljava_lang_String_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void InitPushHandling (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='removeOnMixpanelUpdatesReceivedListener' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.OnMixpanelUpdatesReceivedListener']]"
			[Register ("removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V", "GetRemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void RemoveOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Set (string p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='set' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("set", "(Lorg/json/JSONObject;)V", "GetSet_Lorg_json_JSONObject_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Set (global::Org.Json.JSONObject p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='setOnce' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("setOnce", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetOnce_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void SetOnce (string p0, global::Java.Lang.Object p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='setOnce' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setOnce", "(Lorg/json/JSONObject;)V", "GetSetOnce_Lorg_json_JSONObject_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void SetOnce (global::Org.Json.JSONObject p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='setPushRegistrationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPushRegistrationId", "(Ljava/lang/String;)V", "GetSetPushRegistrationId_Ljava_lang_String_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void SetPushRegistrationId (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='showNotificationById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity']]"
			[Register ("showNotificationById", "(ILandroid/app/Activity;)V", "GetShowNotificationById_ILandroid_app_Activity_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void ShowNotificationById (int p0, global::Android.App.Activity p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='showNotificationIfAvailable' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("showNotificationIfAvailable", "(Landroid/app/Activity;)V", "GetShowNotificationIfAvailable_Landroid_app_Activity_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void ShowNotificationIfAvailable (global::Android.App.Activity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='showSurvey' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.mpmetrics.Survey'] and parameter[2][@type='android.app.Activity']]"
[Obsolete (@"deprecated")]
			[Register ("showSurvey", "(Lcom/mixpanel/android/mpmetrics/Survey;Landroid/app/Activity;)V", "GetShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void ShowSurvey (global::Com.Mixpanel.Android.Mpmetrics.Survey p0, global::Android.App.Activity p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='showSurveyById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity']]"
			[Register ("showSurveyById", "(ILandroid/app/Activity;)V", "GetShowSurveyById_ILandroid_app_Activity_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void ShowSurveyById (int p0, global::Android.App.Activity p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='showSurveyIfAvailable' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("showSurveyIfAvailable", "(Landroid/app/Activity;)V", "GetShowSurveyIfAvailable_Landroid_app_Activity_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void ShowSurveyIfAvailable (global::Android.App.Activity p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='trackCharge' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='org.json.JSONObject']]"
			[Register ("trackCharge", "(DLorg/json/JSONObject;)V", "GetTrackCharge_DLorg_json_JSONObject_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void TrackCharge (double p0, global::Org.Json.JSONObject p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='union' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray']]"
			[Register ("union", "(Ljava/lang/String;Lorg/json/JSONArray;)V", "GetUnion_Ljava_lang_String_Lorg_json_JSONArray_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Union (string p0, global::Org.Json.JSONArray p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='unset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("unset", "(Ljava/lang/String;)V", "GetUnset_Ljava_lang_String_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			void Unset (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='MixpanelAPI.People']/method[@name='withIdentity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withIdentity", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;", "GetWithIdentity_Ljava_lang_String_Handler:Com.Mixpanel.Android.Mpmetrics.MixpanelAPI/IPeopleInvoker, Xamarin-Mixpanel")]
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople WithIdentity (string p0);

		}

		[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/MixpanelAPI$People", DoNotGenerateAcw=true)]
		internal class IPeopleInvoker : global::Java.Lang.Object, IPeople {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/MixpanelAPI$People");
			IntPtr class_ref;

			public static IPeople GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPeople> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mixpanel.android.mpmetrics.MixpanelAPI.People"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPeopleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPeopleInvoker); }
			}

			static Delegate cb_getDistinctId;
#pragma warning disable 0169
			static Delegate GetGetDistinctIdHandler ()
			{
				if (cb_getDistinctId == null)
					cb_getDistinctId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistinctId);
				return cb_getDistinctId;
			}

			static IntPtr n_GetDistinctId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DistinctId);
			}
#pragma warning restore 0169

			IntPtr id_getDistinctId;
			public string DistinctId {
				get {
					if (id_getDistinctId == IntPtr.Zero)
						id_getDistinctId = JNIEnv.GetMethodID (class_ref, "getDistinctId", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDistinctId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getNotificationIfAvailable;
#pragma warning disable 0169
			static Delegate GetGetNotificationIfAvailableHandler ()
			{
				if (cb_getNotificationIfAvailable == null)
					cb_getNotificationIfAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationIfAvailable);
				return cb_getNotificationIfAvailable;
			}

			static IntPtr n_GetNotificationIfAvailable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NotificationIfAvailable);
			}
#pragma warning restore 0169

			IntPtr id_getNotificationIfAvailable;
			public global::Com.Mixpanel.Android.Mpmetrics.InAppNotification NotificationIfAvailable {
				get {
					if (id_getNotificationIfAvailable == IntPtr.Zero)
						id_getNotificationIfAvailable = JNIEnv.GetMethodID (class_ref, "getNotificationIfAvailable", "()Lcom/mixpanel/android/mpmetrics/InAppNotification;");
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (JNIEnv.CallObjectMethod (Handle, id_getNotificationIfAvailable), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getSurveyIfAvailable;
#pragma warning disable 0169
			static Delegate GetGetSurveyIfAvailableHandler ()
			{
				if (cb_getSurveyIfAvailable == null)
					cb_getSurveyIfAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurveyIfAvailable);
				return cb_getSurveyIfAvailable;
			}

			static IntPtr n_GetSurveyIfAvailable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SurveyIfAvailable);
			}
#pragma warning restore 0169

			IntPtr id_getSurveyIfAvailable;
			public global::Com.Mixpanel.Android.Mpmetrics.Survey SurveyIfAvailable {
				get {
					if (id_getSurveyIfAvailable == IntPtr.Zero)
						id_getSurveyIfAvailable = JNIEnv.GetMethodID (class_ref, "getSurveyIfAvailable", "()Lcom/mixpanel/android/mpmetrics/Survey;");
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (JNIEnv.CallObjectMethod (Handle, id_getSurveyIfAvailable), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
#pragma warning disable 0169
			static Delegate GetAddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler ()
			{
				if (cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == null)
					cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_);
				return cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			}

			static void n_AddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0 = (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddOnMixpanelUpdatesReceivedListener (p0);
			}
#pragma warning restore 0169

			IntPtr id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			public void AddOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0)
			{
				if (id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == IntPtr.Zero)
					id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNIEnv.GetMethodID (class_ref, "addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V");
				JNIEnv.CallVoidMethod (Handle, id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_, new JValue (p0));
			}

			static Delegate cb_append_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetAppend_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_append_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_append_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_Ljava_lang_String_Ljava_lang_Object_);
				return cb_append_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_Append_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Append (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_append_Ljava_lang_String_Ljava_lang_Object_;
			public void Append (string p0, global::Java.Lang.Object p1)
			{
				if (id_append_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_append_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_append_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_;
#pragma warning disable 0169
			static Delegate GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Handler ()
			{
				if (cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ == null)
					cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_);
				return cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_;
			}

			static void n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0 = (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.CheckForSurvey (p0);
			}
#pragma warning restore 0169

			IntPtr id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_;
			public void CheckForSurvey (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0)
			{
				if (id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ == IntPtr.Zero)
					id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ = JNIEnv.GetMethodID (class_ref, "checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;)V");
				JNIEnv.CallVoidMethod (Handle, id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_, new JValue (p0));
			}

			static Delegate cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_Handler ()
			{
				if (cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ == null)
					cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_);
				return cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_;
			}

			static void n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0 = (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.CheckForSurvey (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_;
			public void CheckForSurvey (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0, global::Android.App.Activity p1)
			{
				if (id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ == IntPtr.Zero)
					id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;Landroid/app/Activity;)V");
				JNIEnv.CallVoidMethod (Handle, id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_clearCharges;
#pragma warning disable 0169
			static Delegate GetClearChargesHandler ()
			{
				if (cb_clearCharges == null)
					cb_clearCharges = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCharges);
				return cb_clearCharges;
			}

			static void n_ClearCharges (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ClearCharges ();
			}
#pragma warning restore 0169

			IntPtr id_clearCharges;
			public void ClearCharges ()
			{
				if (id_clearCharges == IntPtr.Zero)
					id_clearCharges = JNIEnv.GetMethodID (class_ref, "clearCharges", "()V");
				JNIEnv.CallVoidMethod (Handle, id_clearCharges);
			}

			static Delegate cb_clearPushRegistrationId;
#pragma warning disable 0169
			static Delegate GetClearPushRegistrationIdHandler ()
			{
				if (cb_clearPushRegistrationId == null)
					cb_clearPushRegistrationId = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPushRegistrationId);
				return cb_clearPushRegistrationId;
			}

			static void n_ClearPushRegistrationId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ClearPushRegistrationId ();
			}
#pragma warning restore 0169

			IntPtr id_clearPushRegistrationId;
			public void ClearPushRegistrationId ()
			{
				if (id_clearPushRegistrationId == IntPtr.Zero)
					id_clearPushRegistrationId = JNIEnv.GetMethodID (class_ref, "clearPushRegistrationId", "()V");
				JNIEnv.CallVoidMethod (Handle, id_clearPushRegistrationId);
			}

			static Delegate cb_deleteUser;
#pragma warning disable 0169
			static Delegate GetDeleteUserHandler ()
			{
				if (cb_deleteUser == null)
					cb_deleteUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteUser);
				return cb_deleteUser;
			}

			static void n_DeleteUser (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DeleteUser ();
			}
#pragma warning restore 0169

			IntPtr id_deleteUser;
			public void DeleteUser ()
			{
				if (id_deleteUser == IntPtr.Zero)
					id_deleteUser = JNIEnv.GetMethodID (class_ref, "deleteUser", "()V");
				JNIEnv.CallVoidMethod (Handle, id_deleteUser);
			}

			static Delegate cb_identify_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIdentify_Ljava_lang_String_Handler ()
			{
				if (cb_identify_Ljava_lang_String_ == null)
					cb_identify_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Identify_Ljava_lang_String_);
				return cb_identify_Ljava_lang_String_;
			}

			static void n_Identify_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Identify (p0);
			}
#pragma warning restore 0169

			IntPtr id_identify_Ljava_lang_String_;
			public void Identify (string p0)
			{
				if (id_identify_Ljava_lang_String_ == IntPtr.Zero)
					id_identify_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "identify", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_identify_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_increment_Ljava_lang_String_D;
#pragma warning disable 0169
			static Delegate GetIncrement_Ljava_lang_String_DHandler ()
			{
				if (cb_increment_Ljava_lang_String_D == null)
					cb_increment_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_Increment_Ljava_lang_String_D);
				return cb_increment_Ljava_lang_String_D;
			}

			static void n_Increment_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Increment (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_increment_Ljava_lang_String_D;
			public void Increment (string p0, double p1)
			{
				if (id_increment_Ljava_lang_String_D == IntPtr.Zero)
					id_increment_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/lang/String;D)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_increment_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_increment_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetIncrement_Ljava_util_Map_Handler ()
			{
				if (cb_increment_Ljava_util_Map_ == null)
					cb_increment_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Increment_Ljava_util_Map_);
				return cb_increment_Ljava_util_Map_;
			}

			static void n_Increment_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IDictionary<string, Java.Lang.Number> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Number>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Increment (p0);
			}
#pragma warning restore 0169

			IntPtr id_increment_Ljava_util_Map_;
			public void Increment (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Number> p0)
			{
				if (id_increment_Ljava_util_Map_ == IntPtr.Zero)
					id_increment_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/util/Map;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Number>.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod (Handle, id_increment_Ljava_util_Map_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_initPushHandling_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetInitPushHandling_Ljava_lang_String_Handler ()
			{
				if (cb_initPushHandling_Ljava_lang_String_ == null)
					cb_initPushHandling_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitPushHandling_Ljava_lang_String_);
				return cb_initPushHandling_Ljava_lang_String_;
			}

			static void n_InitPushHandling_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.InitPushHandling (p0);
			}
#pragma warning restore 0169

			IntPtr id_initPushHandling_Ljava_lang_String_;
			public void InitPushHandling (string p0)
			{
				if (id_initPushHandling_Ljava_lang_String_ == IntPtr.Zero)
					id_initPushHandling_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initPushHandling", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_initPushHandling_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
#pragma warning disable 0169
			static Delegate GetRemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler ()
			{
				if (cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == null)
					cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_);
				return cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			}

			static void n_RemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0 = (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RemoveOnMixpanelUpdatesReceivedListener (p0);
			}
#pragma warning restore 0169

			IntPtr id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			public void RemoveOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0)
			{
				if (id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == IntPtr.Zero)
					id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNIEnv.GetMethodID (class_ref, "removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V");
				JNIEnv.CallVoidMethod (Handle, id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_, new JValue (p0));
			}

			static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_Object_);
				return cb_set_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Set (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_set_Ljava_lang_String_Ljava_lang_Object_;
			public void Set (string p0, global::Java.Lang.Object p1)
			{
				if (id_set_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_set_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_set_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_set_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetSet_Lorg_json_JSONObject_Handler ()
			{
				if (cb_set_Lorg_json_JSONObject_ == null)
					cb_set_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Lorg_json_JSONObject_);
				return cb_set_Lorg_json_JSONObject_;
			}

			static void n_Set_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Set (p0);
			}
#pragma warning restore 0169

			IntPtr id_set_Lorg_json_JSONObject_;
			public void Set (global::Org.Json.JSONObject p0)
			{
				if (id_set_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_set_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "set", "(Lorg/json/JSONObject;)V");
				JNIEnv.CallVoidMethod (Handle, id_set_Lorg_json_JSONObject_, new JValue (p0));
			}

			static Delegate cb_setOnce_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetOnce_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_setOnce_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_setOnce_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnce_Ljava_lang_String_Ljava_lang_Object_);
				return cb_setOnce_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_SetOnce_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetOnce (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_setOnce_Ljava_lang_String_Ljava_lang_Object_;
			public void SetOnce (string p0, global::Java.Lang.Object p1)
			{
				if (id_setOnce_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_setOnce_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setOnce", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_setOnce_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_setOnce_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetSetOnce_Lorg_json_JSONObject_Handler ()
			{
				if (cb_setOnce_Lorg_json_JSONObject_ == null)
					cb_setOnce_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnce_Lorg_json_JSONObject_);
				return cb_setOnce_Lorg_json_JSONObject_;
			}

			static void n_SetOnce_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetOnce (p0);
			}
#pragma warning restore 0169

			IntPtr id_setOnce_Lorg_json_JSONObject_;
			public void SetOnce (global::Org.Json.JSONObject p0)
			{
				if (id_setOnce_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setOnce_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setOnce", "(Lorg/json/JSONObject;)V");
				JNIEnv.CallVoidMethod (Handle, id_setOnce_Lorg_json_JSONObject_, new JValue (p0));
			}

			static Delegate cb_setPushRegistrationId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPushRegistrationId_Ljava_lang_String_Handler ()
			{
				if (cb_setPushRegistrationId_Ljava_lang_String_ == null)
					cb_setPushRegistrationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPushRegistrationId_Ljava_lang_String_);
				return cb_setPushRegistrationId_Ljava_lang_String_;
			}

			static void n_SetPushRegistrationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetPushRegistrationId (p0);
			}
#pragma warning restore 0169

			IntPtr id_setPushRegistrationId_Ljava_lang_String_;
			public void SetPushRegistrationId (string p0)
			{
				if (id_setPushRegistrationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setPushRegistrationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPushRegistrationId", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_setPushRegistrationId_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_showNotificationById_ILandroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowNotificationById_ILandroid_app_Activity_Handler ()
			{
				if (cb_showNotificationById_ILandroid_app_Activity_ == null)
					cb_showNotificationById_ILandroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ShowNotificationById_ILandroid_app_Activity_);
				return cb_showNotificationById_ILandroid_app_Activity_;
			}

			static void n_ShowNotificationById_ILandroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ShowNotificationById (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_showNotificationById_ILandroid_app_Activity_;
			public void ShowNotificationById (int p0, global::Android.App.Activity p1)
			{
				if (id_showNotificationById_ILandroid_app_Activity_ == IntPtr.Zero)
					id_showNotificationById_ILandroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showNotificationById", "(ILandroid/app/Activity;)V");
				JNIEnv.CallVoidMethod (Handle, id_showNotificationById_ILandroid_app_Activity_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_showNotificationIfAvailable_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowNotificationIfAvailable_Landroid_app_Activity_Handler ()
			{
				if (cb_showNotificationIfAvailable_Landroid_app_Activity_ == null)
					cb_showNotificationIfAvailable_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowNotificationIfAvailable_Landroid_app_Activity_);
				return cb_showNotificationIfAvailable_Landroid_app_Activity_;
			}

			static void n_ShowNotificationIfAvailable_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShowNotificationIfAvailable (p0);
			}
#pragma warning restore 0169

			IntPtr id_showNotificationIfAvailable_Landroid_app_Activity_;
			public void ShowNotificationIfAvailable (global::Android.App.Activity p0)
			{
				if (id_showNotificationIfAvailable_Landroid_app_Activity_ == IntPtr.Zero)
					id_showNotificationIfAvailable_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showNotificationIfAvailable", "(Landroid/app/Activity;)V");
				JNIEnv.CallVoidMethod (Handle, id_showNotificationIfAvailable_Landroid_app_Activity_, new JValue (p0));
			}

			static Delegate cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_Handler ()
			{
				if (cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ == null)
					cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_);
				return cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_;
			}

			static void n_ShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.Survey p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ShowSurvey (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_;
			public void ShowSurvey (global::Com.Mixpanel.Android.Mpmetrics.Survey p0, global::Android.App.Activity p1)
			{
				if (id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ == IntPtr.Zero)
					id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showSurvey", "(Lcom/mixpanel/android/mpmetrics/Survey;Landroid/app/Activity;)V");
				JNIEnv.CallVoidMethod (Handle, id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_showSurveyById_ILandroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowSurveyById_ILandroid_app_Activity_Handler ()
			{
				if (cb_showSurveyById_ILandroid_app_Activity_ == null)
					cb_showSurveyById_ILandroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ShowSurveyById_ILandroid_app_Activity_);
				return cb_showSurveyById_ILandroid_app_Activity_;
			}

			static void n_ShowSurveyById_ILandroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ShowSurveyById (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_showSurveyById_ILandroid_app_Activity_;
			public void ShowSurveyById (int p0, global::Android.App.Activity p1)
			{
				if (id_showSurveyById_ILandroid_app_Activity_ == IntPtr.Zero)
					id_showSurveyById_ILandroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showSurveyById", "(ILandroid/app/Activity;)V");
				JNIEnv.CallVoidMethod (Handle, id_showSurveyById_ILandroid_app_Activity_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_showSurveyIfAvailable_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowSurveyIfAvailable_Landroid_app_Activity_Handler ()
			{
				if (cb_showSurveyIfAvailable_Landroid_app_Activity_ == null)
					cb_showSurveyIfAvailable_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowSurveyIfAvailable_Landroid_app_Activity_);
				return cb_showSurveyIfAvailable_Landroid_app_Activity_;
			}

			static void n_ShowSurveyIfAvailable_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShowSurveyIfAvailable (p0);
			}
#pragma warning restore 0169

			IntPtr id_showSurveyIfAvailable_Landroid_app_Activity_;
			public void ShowSurveyIfAvailable (global::Android.App.Activity p0)
			{
				if (id_showSurveyIfAvailable_Landroid_app_Activity_ == IntPtr.Zero)
					id_showSurveyIfAvailable_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showSurveyIfAvailable", "(Landroid/app/Activity;)V");
				JNIEnv.CallVoidMethod (Handle, id_showSurveyIfAvailable_Landroid_app_Activity_, new JValue (p0));
			}

			static Delegate cb_trackCharge_DLorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetTrackCharge_DLorg_json_JSONObject_Handler ()
			{
				if (cb_trackCharge_DLorg_json_JSONObject_ == null)
					cb_trackCharge_DLorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_TrackCharge_DLorg_json_JSONObject_);
				return cb_trackCharge_DLorg_json_JSONObject_;
			}

			static void n_TrackCharge_DLorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.TrackCharge (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_trackCharge_DLorg_json_JSONObject_;
			public void TrackCharge (double p0, global::Org.Json.JSONObject p1)
			{
				if (id_trackCharge_DLorg_json_JSONObject_ == IntPtr.Zero)
					id_trackCharge_DLorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "trackCharge", "(DLorg/json/JSONObject;)V");
				JNIEnv.CallVoidMethod (Handle, id_trackCharge_DLorg_json_JSONObject_, new JValue (p0), new JValue (p1));
			}

			static Delegate cb_union_Ljava_lang_String_Lorg_json_JSONArray_;
#pragma warning disable 0169
			static Delegate GetUnion_Ljava_lang_String_Lorg_json_JSONArray_Handler ()
			{
				if (cb_union_Ljava_lang_String_Lorg_json_JSONArray_ == null)
					cb_union_Ljava_lang_String_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Union_Ljava_lang_String_Lorg_json_JSONArray_);
				return cb_union_Ljava_lang_String_Lorg_json_JSONArray_;
			}

			static void n_Union_Ljava_lang_String_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONArray p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Union (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_union_Ljava_lang_String_Lorg_json_JSONArray_;
			public void Union (string p0, global::Org.Json.JSONArray p1)
			{
				if (id_union_Ljava_lang_String_Lorg_json_JSONArray_ == IntPtr.Zero)
					id_union_Ljava_lang_String_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "union", "(Ljava/lang/String;Lorg/json/JSONArray;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_union_Ljava_lang_String_Lorg_json_JSONArray_, new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_unset_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetUnset_Ljava_lang_String_Handler ()
			{
				if (cb_unset_Ljava_lang_String_ == null)
					cb_unset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unset_Ljava_lang_String_);
				return cb_unset_Ljava_lang_String_;
			}

			static void n_Unset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Unset (p0);
			}
#pragma warning restore 0169

			IntPtr id_unset_Ljava_lang_String_;
			public void Unset (string p0)
			{
				if (id_unset_Ljava_lang_String_ == IntPtr.Zero)
					id_unset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unset", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JNIEnv.CallVoidMethod (Handle, id_unset_Ljava_lang_String_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_withIdentity_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithIdentity_Ljava_lang_String_Handler ()
			{
				if (cb_withIdentity_Ljava_lang_String_ == null)
					cb_withIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIdentity_Ljava_lang_String_);
				return cb_withIdentity_Ljava_lang_String_;
			}

			static IntPtr n_WithIdentity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIdentity (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_withIdentity_Ljava_lang_String_;
			public global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople WithIdentity (string p0)
			{
				if (id_withIdentity_Ljava_lang_String_ == IntPtr.Zero)
					id_withIdentity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withIdentity", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (JNIEnv.CallObjectMethod (Handle, id_withIdentity_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']"
		[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/MixpanelAPI$PeopleImpl", DoNotGenerateAcw=true)]
		public partial class PeopleImpl : global::Java.Lang.Object, global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/MixpanelAPI$PeopleImpl", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PeopleImpl); }
			}

			protected PeopleImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getDistinctId;
#pragma warning disable 0169
			static Delegate GetGetDistinctIdHandler ()
			{
				if (cb_getDistinctId == null)
					cb_getDistinctId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistinctId);
				return cb_getDistinctId;
			}

			static IntPtr n_GetDistinctId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DistinctId);
			}
#pragma warning restore 0169

			static IntPtr id_getDistinctId;
			public virtual string DistinctId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='getDistinctId' and count(parameter)=0]"
				[Register ("getDistinctId", "()Ljava/lang/String;", "GetGetDistinctIdHandler")]
				get {
					if (id_getDistinctId == IntPtr.Zero)
						id_getDistinctId = JNIEnv.GetMethodID (class_ref, "getDistinctId", "()Ljava/lang/String;");

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDistinctId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistinctId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getNotificationIfAvailable;
#pragma warning disable 0169
			static Delegate GetGetNotificationIfAvailableHandler ()
			{
				if (cb_getNotificationIfAvailable == null)
					cb_getNotificationIfAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationIfAvailable);
				return cb_getNotificationIfAvailable;
			}

			static IntPtr n_GetNotificationIfAvailable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NotificationIfAvailable);
			}
#pragma warning restore 0169

			static IntPtr id_getNotificationIfAvailable;
			public virtual global::Com.Mixpanel.Android.Mpmetrics.InAppNotification NotificationIfAvailable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='getNotificationIfAvailable' and count(parameter)=0]"
				[Register ("getNotificationIfAvailable", "()Lcom/mixpanel/android/mpmetrics/InAppNotification;", "GetGetNotificationIfAvailableHandler")]
				get {
					if (id_getNotificationIfAvailable == IntPtr.Zero)
						id_getNotificationIfAvailable = JNIEnv.GetMethodID (class_ref, "getNotificationIfAvailable", "()Lcom/mixpanel/android/mpmetrics/InAppNotification;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (JNIEnv.CallObjectMethod  (Handle, id_getNotificationIfAvailable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.InAppNotification> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationIfAvailable", "()Lcom/mixpanel/android/mpmetrics/InAppNotification;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getSurveyIfAvailable;
#pragma warning disable 0169
			static Delegate GetGetSurveyIfAvailableHandler ()
			{
				if (cb_getSurveyIfAvailable == null)
					cb_getSurveyIfAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurveyIfAvailable);
				return cb_getSurveyIfAvailable;
			}

			static IntPtr n_GetSurveyIfAvailable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SurveyIfAvailable);
			}
#pragma warning restore 0169

			static IntPtr id_getSurveyIfAvailable;
			public virtual global::Com.Mixpanel.Android.Mpmetrics.Survey SurveyIfAvailable {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='getSurveyIfAvailable' and count(parameter)=0]"
				[Register ("getSurveyIfAvailable", "()Lcom/mixpanel/android/mpmetrics/Survey;", "GetGetSurveyIfAvailableHandler")]
				get {
					if (id_getSurveyIfAvailable == IntPtr.Zero)
						id_getSurveyIfAvailable = JNIEnv.GetMethodID (class_ref, "getSurveyIfAvailable", "()Lcom/mixpanel/android/mpmetrics/Survey;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (JNIEnv.CallObjectMethod  (Handle, id_getSurveyIfAvailable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurveyIfAvailable", "()Lcom/mixpanel/android/mpmetrics/Survey;")), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
#pragma warning disable 0169
			static Delegate GetAddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler ()
			{
				if (cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == null)
					cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_);
				return cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			}

			static void n_AddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0 = (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddOnMixpanelUpdatesReceivedListener (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='addOnMixpanelUpdatesReceivedListener' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.OnMixpanelUpdatesReceivedListener']]"
			[Register ("addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V", "GetAddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler")]
			public virtual void AddOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0)
			{
				if (id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == IntPtr.Zero)
					id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNIEnv.GetMethodID (class_ref, "addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V"), new JValue (p0));
			}

			static Delegate cb_append_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetAppend_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_append_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_append_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_Ljava_lang_String_Ljava_lang_Object_);
				return cb_append_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_Append_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Append (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_append_Ljava_lang_String_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='append' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("append", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetAppend_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual void Append (string p0, global::Java.Lang.Object p1)
			{
				if (id_append_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_append_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "append", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_append_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_;
#pragma warning disable 0169
			static Delegate GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Handler ()
			{
				if (cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ == null)
					cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_);
				return cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_;
			}

			static void n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0 = (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.CheckForSurvey (p0);
			}
#pragma warning restore 0169

			static IntPtr id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='checkForSurvey' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.SurveyCallbacks']]"
			[Register ("checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;)V", "GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Handler")]
			public virtual void CheckForSurvey (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0)
			{
				if (id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ == IntPtr.Zero)
					id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_ = JNIEnv.GetMethodID (class_ref, "checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;)V"), new JValue (p0));
			}

			static Delegate cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_Handler ()
			{
				if (cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ == null)
					cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_);
				return cb_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_;
			}

			static void n_CheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0 = (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.CheckForSurvey (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='checkForSurvey' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.mpmetrics.SurveyCallbacks'] and parameter[2][@type='android.app.Activity']]"
			[Register ("checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;Landroid/app/Activity;)V", "GetCheckForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_Handler")]
			public virtual void CheckForSurvey (global::Com.Mixpanel.Android.Mpmetrics.ISurveyCallbacks p0, global::Android.App.Activity p1)
			{
				if (id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ == IntPtr.Zero)
					id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;Landroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_checkForSurvey_Lcom_mixpanel_android_mpmetrics_SurveyCallbacks_Landroid_app_Activity_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkForSurvey", "(Lcom/mixpanel/android/mpmetrics/SurveyCallbacks;Landroid/app/Activity;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_clearCharges;
#pragma warning disable 0169
			static Delegate GetClearChargesHandler ()
			{
				if (cb_clearCharges == null)
					cb_clearCharges = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCharges);
				return cb_clearCharges;
			}

			static void n_ClearCharges (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ClearCharges ();
			}
#pragma warning restore 0169

			static IntPtr id_clearCharges;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='clearCharges' and count(parameter)=0]"
			[Register ("clearCharges", "()V", "GetClearChargesHandler")]
			public virtual void ClearCharges ()
			{
				if (id_clearCharges == IntPtr.Zero)
					id_clearCharges = JNIEnv.GetMethodID (class_ref, "clearCharges", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearCharges);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCharges", "()V"));
			}

			static Delegate cb_clearPushRegistrationId;
#pragma warning disable 0169
			static Delegate GetClearPushRegistrationIdHandler ()
			{
				if (cb_clearPushRegistrationId == null)
					cb_clearPushRegistrationId = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPushRegistrationId);
				return cb_clearPushRegistrationId;
			}

			static void n_ClearPushRegistrationId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ClearPushRegistrationId ();
			}
#pragma warning restore 0169

			static IntPtr id_clearPushRegistrationId;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='clearPushRegistrationId' and count(parameter)=0]"
			[Register ("clearPushRegistrationId", "()V", "GetClearPushRegistrationIdHandler")]
			public virtual void ClearPushRegistrationId ()
			{
				if (id_clearPushRegistrationId == IntPtr.Zero)
					id_clearPushRegistrationId = JNIEnv.GetMethodID (class_ref, "clearPushRegistrationId", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearPushRegistrationId);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPushRegistrationId", "()V"));
			}

			static Delegate cb_deleteUser;
#pragma warning disable 0169
			static Delegate GetDeleteUserHandler ()
			{
				if (cb_deleteUser == null)
					cb_deleteUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteUser);
				return cb_deleteUser;
			}

			static void n_DeleteUser (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DeleteUser ();
			}
#pragma warning restore 0169

			static IntPtr id_deleteUser;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='deleteUser' and count(parameter)=0]"
			[Register ("deleteUser", "()V", "GetDeleteUserHandler")]
			public virtual void DeleteUser ()
			{
				if (id_deleteUser == IntPtr.Zero)
					id_deleteUser = JNIEnv.GetMethodID (class_ref, "deleteUser", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deleteUser);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteUser", "()V"));
			}

			static Delegate cb_identify_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIdentify_Ljava_lang_String_Handler ()
			{
				if (cb_identify_Ljava_lang_String_ == null)
					cb_identify_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Identify_Ljava_lang_String_);
				return cb_identify_Ljava_lang_String_;
			}

			static void n_Identify_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Identify (p0);
			}
#pragma warning restore 0169

			static IntPtr id_identify_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='identify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("identify", "(Ljava/lang/String;)V", "GetIdentify_Ljava_lang_String_Handler")]
			public virtual void Identify (string p0)
			{
				if (id_identify_Ljava_lang_String_ == IntPtr.Zero)
					id_identify_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "identify", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_identify_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identify", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_increment_Ljava_lang_String_D;
#pragma warning disable 0169
			static Delegate GetIncrement_Ljava_lang_String_DHandler ()
			{
				if (cb_increment_Ljava_lang_String_D == null)
					cb_increment_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_Increment_Ljava_lang_String_D);
				return cb_increment_Ljava_lang_String_D;
			}

			static void n_Increment_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Increment (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_increment_Ljava_lang_String_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='increment' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
			[Register ("increment", "(Ljava/lang/String;D)V", "GetIncrement_Ljava_lang_String_DHandler")]
			public virtual void Increment (string p0, double p1)
			{
				if (id_increment_Ljava_lang_String_D == IntPtr.Zero)
					id_increment_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/lang/String;D)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_increment_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increment", "(Ljava/lang/String;D)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_increment_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetIncrement_Ljava_util_Map_Handler ()
			{
				if (cb_increment_Ljava_util_Map_ == null)
					cb_increment_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Increment_Ljava_util_Map_);
				return cb_increment_Ljava_util_Map_;
			}

			static void n_Increment_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IDictionary<string, Java.Lang.Number> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Number>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Increment (p0);
			}
#pragma warning restore 0169

			static IntPtr id_increment_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='increment' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("increment", "(Ljava/util/Map;)V", "GetIncrement_Ljava_util_Map_Handler")]
			public virtual void Increment (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Number> p0)
			{
				if (id_increment_Ljava_util_Map_ == IntPtr.Zero)
					id_increment_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "increment", "(Ljava/util/Map;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Number>.ToLocalJniHandle (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_increment_Ljava_util_Map_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increment", "(Ljava/util/Map;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_initPushHandling_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetInitPushHandling_Ljava_lang_String_Handler ()
			{
				if (cb_initPushHandling_Ljava_lang_String_ == null)
					cb_initPushHandling_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitPushHandling_Ljava_lang_String_);
				return cb_initPushHandling_Ljava_lang_String_;
			}

			static void n_InitPushHandling_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.InitPushHandling (p0);
			}
#pragma warning restore 0169

			static IntPtr id_initPushHandling_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='initPushHandling' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("initPushHandling", "(Ljava/lang/String;)V", "GetInitPushHandling_Ljava_lang_String_Handler")]
			public virtual void InitPushHandling (string p0)
			{
				if (id_initPushHandling_Ljava_lang_String_ == IntPtr.Zero)
					id_initPushHandling_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initPushHandling", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initPushHandling_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initPushHandling", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
#pragma warning disable 0169
			static Delegate GetRemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler ()
			{
				if (cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == null)
					cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_);
				return cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			}

			static void n_RemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0 = (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RemoveOnMixpanelUpdatesReceivedListener (p0);
			}
#pragma warning restore 0169

			static IntPtr id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='removeOnMixpanelUpdatesReceivedListener' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.OnMixpanelUpdatesReceivedListener']]"
			[Register ("removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V", "GetRemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler")]
			public virtual void RemoveOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0)
			{
				if (id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == IntPtr.Zero)
					id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNIEnv.GetMethodID (class_ref, "removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V"), new JValue (p0));
			}

			static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_Object_);
				return cb_set_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Set (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_set_Ljava_lang_String_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual void Set (string p0, global::Java.Lang.Object p1)
			{
				if (id_set_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_set_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_set_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetSet_Lorg_json_JSONObject_Handler ()
			{
				if (cb_set_Lorg_json_JSONObject_ == null)
					cb_set_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Lorg_json_JSONObject_);
				return cb_set_Lorg_json_JSONObject_;
			}

			static void n_Set_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Set (p0);
			}
#pragma warning restore 0169

			static IntPtr id_set_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='set' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("set", "(Lorg/json/JSONObject;)V", "GetSet_Lorg_json_JSONObject_Handler")]
			public virtual void Set (global::Org.Json.JSONObject p0)
			{
				if (id_set_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_set_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "set", "(Lorg/json/JSONObject;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_Lorg_json_JSONObject_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Lorg/json/JSONObject;)V"), new JValue (p0));
			}

			static Delegate cb_setOnce_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetOnce_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_setOnce_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_setOnce_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnce_Ljava_lang_String_Ljava_lang_Object_);
				return cb_setOnce_Ljava_lang_String_Ljava_lang_Object_;
			}

			static void n_SetOnce_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetOnce (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setOnce_Ljava_lang_String_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='setOnce' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("setOnce", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetOnce_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual void SetOnce (string p0, global::Java.Lang.Object p1)
			{
				if (id_setOnce_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_setOnce_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setOnce", "(Ljava/lang/String;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnce_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnce", "(Ljava/lang/String;Ljava/lang/Object;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_setOnce_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetSetOnce_Lorg_json_JSONObject_Handler ()
			{
				if (cb_setOnce_Lorg_json_JSONObject_ == null)
					cb_setOnce_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnce_Lorg_json_JSONObject_);
				return cb_setOnce_Lorg_json_JSONObject_;
			}

			static void n_SetOnce_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetOnce (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setOnce_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='setOnce' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setOnce", "(Lorg/json/JSONObject;)V", "GetSetOnce_Lorg_json_JSONObject_Handler")]
			public virtual void SetOnce (global::Org.Json.JSONObject p0)
			{
				if (id_setOnce_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setOnce_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setOnce", "(Lorg/json/JSONObject;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnce_Lorg_json_JSONObject_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnce", "(Lorg/json/JSONObject;)V"), new JValue (p0));
			}

			static Delegate cb_setPushRegistrationId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPushRegistrationId_Ljava_lang_String_Handler ()
			{
				if (cb_setPushRegistrationId_Ljava_lang_String_ == null)
					cb_setPushRegistrationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPushRegistrationId_Ljava_lang_String_);
				return cb_setPushRegistrationId_Ljava_lang_String_;
			}

			static void n_SetPushRegistrationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetPushRegistrationId (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setPushRegistrationId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='setPushRegistrationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPushRegistrationId", "(Ljava/lang/String;)V", "GetSetPushRegistrationId_Ljava_lang_String_Handler")]
			public virtual void SetPushRegistrationId (string p0)
			{
				if (id_setPushRegistrationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setPushRegistrationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPushRegistrationId", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPushRegistrationId_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushRegistrationId", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_showNotificationById_ILandroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowNotificationById_ILandroid_app_Activity_Handler ()
			{
				if (cb_showNotificationById_ILandroid_app_Activity_ == null)
					cb_showNotificationById_ILandroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ShowNotificationById_ILandroid_app_Activity_);
				return cb_showNotificationById_ILandroid_app_Activity_;
			}

			static void n_ShowNotificationById_ILandroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ShowNotificationById (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_showNotificationById_ILandroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='showNotificationById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity']]"
			[Register ("showNotificationById", "(ILandroid/app/Activity;)V", "GetShowNotificationById_ILandroid_app_Activity_Handler")]
			public virtual void ShowNotificationById (int p0, global::Android.App.Activity p1)
			{
				if (id_showNotificationById_ILandroid_app_Activity_ == IntPtr.Zero)
					id_showNotificationById_ILandroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showNotificationById", "(ILandroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showNotificationById_ILandroid_app_Activity_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showNotificationById", "(ILandroid/app/Activity;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_showNotificationIfAvailable_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowNotificationIfAvailable_Landroid_app_Activity_Handler ()
			{
				if (cb_showNotificationIfAvailable_Landroid_app_Activity_ == null)
					cb_showNotificationIfAvailable_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowNotificationIfAvailable_Landroid_app_Activity_);
				return cb_showNotificationIfAvailable_Landroid_app_Activity_;
			}

			static void n_ShowNotificationIfAvailable_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShowNotificationIfAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_showNotificationIfAvailable_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='showNotificationIfAvailable' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("showNotificationIfAvailable", "(Landroid/app/Activity;)V", "GetShowNotificationIfAvailable_Landroid_app_Activity_Handler")]
			public virtual void ShowNotificationIfAvailable (global::Android.App.Activity p0)
			{
				if (id_showNotificationIfAvailable_Landroid_app_Activity_ == IntPtr.Zero)
					id_showNotificationIfAvailable_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showNotificationIfAvailable", "(Landroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showNotificationIfAvailable_Landroid_app_Activity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showNotificationIfAvailable", "(Landroid/app/Activity;)V"), new JValue (p0));
			}

			static Delegate cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_Handler ()
			{
				if (cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ == null)
					cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_);
				return cb_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_;
			}

			static void n_ShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.Survey p0 = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.Survey> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ShowSurvey (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='showSurvey' and count(parameter)=2 and parameter[1][@type='com.mixpanel.android.mpmetrics.Survey'] and parameter[2][@type='android.app.Activity']]"
			[Register ("showSurvey", "(Lcom/mixpanel/android/mpmetrics/Survey;Landroid/app/Activity;)V", "GetShowSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_Handler")]
			public virtual void ShowSurvey (global::Com.Mixpanel.Android.Mpmetrics.Survey p0, global::Android.App.Activity p1)
			{
				if (id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ == IntPtr.Zero)
					id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showSurvey", "(Lcom/mixpanel/android/mpmetrics/Survey;Landroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showSurvey_Lcom_mixpanel_android_mpmetrics_Survey_Landroid_app_Activity_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSurvey", "(Lcom/mixpanel/android/mpmetrics/Survey;Landroid/app/Activity;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_showSurveyById_ILandroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowSurveyById_ILandroid_app_Activity_Handler ()
			{
				if (cb_showSurveyById_ILandroid_app_Activity_ == null)
					cb_showSurveyById_ILandroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ShowSurveyById_ILandroid_app_Activity_);
				return cb_showSurveyById_ILandroid_app_Activity_;
			}

			static void n_ShowSurveyById_ILandroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p1 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ShowSurveyById (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_showSurveyById_ILandroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='showSurveyById' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Activity']]"
			[Register ("showSurveyById", "(ILandroid/app/Activity;)V", "GetShowSurveyById_ILandroid_app_Activity_Handler")]
			public virtual void ShowSurveyById (int p0, global::Android.App.Activity p1)
			{
				if (id_showSurveyById_ILandroid_app_Activity_ == IntPtr.Zero)
					id_showSurveyById_ILandroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showSurveyById", "(ILandroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showSurveyById_ILandroid_app_Activity_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSurveyById", "(ILandroid/app/Activity;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_showSurveyIfAvailable_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetShowSurveyIfAvailable_Landroid_app_Activity_Handler ()
			{
				if (cb_showSurveyIfAvailable_Landroid_app_Activity_ == null)
					cb_showSurveyIfAvailable_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowSurveyIfAvailable_Landroid_app_Activity_);
				return cb_showSurveyIfAvailable_Landroid_app_Activity_;
			}

			static void n_ShowSurveyIfAvailable_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShowSurveyIfAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_showSurveyIfAvailable_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='showSurveyIfAvailable' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("showSurveyIfAvailable", "(Landroid/app/Activity;)V", "GetShowSurveyIfAvailable_Landroid_app_Activity_Handler")]
			public virtual void ShowSurveyIfAvailable (global::Android.App.Activity p0)
			{
				if (id_showSurveyIfAvailable_Landroid_app_Activity_ == IntPtr.Zero)
					id_showSurveyIfAvailable_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "showSurveyIfAvailable", "(Landroid/app/Activity;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showSurveyIfAvailable_Landroid_app_Activity_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSurveyIfAvailable", "(Landroid/app/Activity;)V"), new JValue (p0));
			}

			static Delegate cb_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetStdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_Handler ()
			{
				if (cb_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_ == null)
					cb_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_);
				return cb_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_;
			}

			static IntPtr n_StdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StdPeopleMessage (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='stdPeopleMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("stdPeopleMessage", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;", "GetStdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_Handler")]
			public virtual global::Org.Json.JSONObject StdPeopleMessage (string p0, global::Java.Lang.Object p1)
			{
				if (id_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "stdPeopleMessage", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Org.Json.JSONObject __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_stdPeopleMessage_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stdPeopleMessage", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_trackCharge_DLorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetTrackCharge_DLorg_json_JSONObject_Handler ()
			{
				if (cb_trackCharge_DLorg_json_JSONObject_ == null)
					cb_trackCharge_DLorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr>) n_TrackCharge_DLorg_json_JSONObject_);
				return cb_trackCharge_DLorg_json_JSONObject_;
			}

			static void n_TrackCharge_DLorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.TrackCharge (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_trackCharge_DLorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='trackCharge' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='org.json.JSONObject']]"
			[Register ("trackCharge", "(DLorg/json/JSONObject;)V", "GetTrackCharge_DLorg_json_JSONObject_Handler")]
			public virtual void TrackCharge (double p0, global::Org.Json.JSONObject p1)
			{
				if (id_trackCharge_DLorg_json_JSONObject_ == IntPtr.Zero)
					id_trackCharge_DLorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "trackCharge", "(DLorg/json/JSONObject;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_trackCharge_DLorg_json_JSONObject_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackCharge", "(DLorg/json/JSONObject;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_union_Ljava_lang_String_Lorg_json_JSONArray_;
#pragma warning disable 0169
			static Delegate GetUnion_Ljava_lang_String_Lorg_json_JSONArray_Handler ()
			{
				if (cb_union_Ljava_lang_String_Lorg_json_JSONArray_ == null)
					cb_union_Ljava_lang_String_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Union_Ljava_lang_String_Lorg_json_JSONArray_);
				return cb_union_Ljava_lang_String_Lorg_json_JSONArray_;
			}

			static void n_Union_Ljava_lang_String_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONArray p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Union (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_union_Ljava_lang_String_Lorg_json_JSONArray_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='union' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray']]"
			[Register ("union", "(Ljava/lang/String;Lorg/json/JSONArray;)V", "GetUnion_Ljava_lang_String_Lorg_json_JSONArray_Handler")]
			public virtual void Union (string p0, global::Org.Json.JSONArray p1)
			{
				if (id_union_Ljava_lang_String_Lorg_json_JSONArray_ == IntPtr.Zero)
					id_union_Ljava_lang_String_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "union", "(Ljava/lang/String;Lorg/json/JSONArray;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_union_Ljava_lang_String_Lorg_json_JSONArray_, new JValue (native_p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "union", "(Ljava/lang/String;Lorg/json/JSONArray;)V"), new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_unset_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetUnset_Ljava_lang_String_Handler ()
			{
				if (cb_unset_Ljava_lang_String_ == null)
					cb_unset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unset_Ljava_lang_String_);
				return cb_unset_Ljava_lang_String_;
			}

			static void n_Unset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Unset (p0);
			}
#pragma warning restore 0169

			static IntPtr id_unset_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='unset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("unset", "(Ljava/lang/String;)V", "GetUnset_Ljava_lang_String_Handler")]
			public virtual void Unset (string p0)
			{
				if (id_unset_Ljava_lang_String_ == IntPtr.Zero)
					id_unset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unset", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_unset_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unset", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_withIdentity_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWithIdentity_Ljava_lang_String_Handler ()
			{
				if (cb_withIdentity_Ljava_lang_String_ == null)
					cb_withIdentity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIdentity_Ljava_lang_String_);
				return cb_withIdentity_Ljava_lang_String_;
			}

			static IntPtr n_WithIdentity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.PeopleImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIdentity (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withIdentity_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.PeopleImpl']/method[@name='withIdentity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("withIdentity", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;", "GetWithIdentity_Ljava_lang_String_Handler")]
			public virtual global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople WithIdentity (string p0)
			{
				if (id_withIdentity_Ljava_lang_String_ == IntPtr.Zero)
					id_withIdentity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withIdentity", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (JNIEnv.CallObjectMethod  (Handle, id_withIdentity_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIdentity", "(Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

#region "Event implementation for Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener"
			public event EventHandler MixpanelUpdatesReceived {
				add {
					global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener, global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor>(
							ref weak_implementor_AddOnMixpanelUpdatesReceivedListener,
							__CreateIOnMixpanelUpdatesReceivedListenerImplementor,
							AddOnMixpanelUpdatesReceivedListener,
							__h => __h.Handler += value);
				}
				remove {
					global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener, global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor>(
							ref weak_implementor_AddOnMixpanelUpdatesReceivedListener,
							global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor.__IsEmpty,
							RemoveOnMixpanelUpdatesReceivedListener,
							__h => __h.Handler -= value);
				}
			}

			WeakReference weak_implementor_AddOnMixpanelUpdatesReceivedListener;

			global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor __CreateIOnMixpanelUpdatesReceivedListenerImplementor ()
			{
				return new global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor (this);
			}
#endregion
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.UpdatesListener']"
		[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/MixpanelAPI$UpdatesListener", DoNotGenerateAcw=true)]
		public partial class UpdatesListener : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/MixpanelAPI$UpdatesListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdatesListener); }
			}

			protected UpdatesListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
#pragma warning disable 0169
			static Delegate GetAddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler ()
			{
				if (cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == null)
					cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_);
				return cb_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			}

			static void n_AddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0 = (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddOnMixpanelUpdatesReceivedListener (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.UpdatesListener']/method[@name='addOnMixpanelUpdatesReceivedListener' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.OnMixpanelUpdatesReceivedListener']]"
			[Register ("addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V", "GetAddOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler")]
			public virtual void AddOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0)
			{
				if (id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == IntPtr.Zero)
					id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNIEnv.GetMethodID (class_ref, "addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V"), new JValue (p0));
			}

			static Delegate cb_onNewResults_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnNewResults_Ljava_lang_String_Handler ()
			{
				if (cb_onNewResults_Ljava_lang_String_ == null)
					cb_onNewResults_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewResults_Ljava_lang_String_);
				return cb_onNewResults_Ljava_lang_String_;
			}

			static void n_OnNewResults_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNewResults (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onNewResults_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.UpdatesListener']/method[@name='onNewResults' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onNewResults", "(Ljava/lang/String;)V", "GetOnNewResults_Ljava_lang_String_Handler")]
			public virtual void OnNewResults (string p0)
			{
				if (id_onNewResults_Ljava_lang_String_ == IntPtr.Zero)
					id_onNewResults_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onNewResults", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onNewResults_Ljava_lang_String_, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewResults", "(Ljava/lang/String;)V"), new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
#pragma warning disable 0169
			static Delegate GetRemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler ()
			{
				if (cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == null)
					cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_);
				return cb_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			}

			static void n_RemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0 = (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener)global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RemoveOnMixpanelUpdatesReceivedListener (p0);
			}
#pragma warning restore 0169

			static IntPtr id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.UpdatesListener']/method[@name='removeOnMixpanelUpdatesReceivedListener' and count(parameter)=1 and parameter[1][@type='com.mixpanel.android.mpmetrics.OnMixpanelUpdatesReceivedListener']]"
			[Register ("removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V", "GetRemoveOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_Handler")]
			public virtual void RemoveOnMixpanelUpdatesReceivedListener (global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener p0)
			{
				if (id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ == IntPtr.Zero)
					id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_ = JNIEnv.GetMethodID (class_ref, "removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeOnMixpanelUpdatesReceivedListener_Lcom_mixpanel_android_mpmetrics_OnMixpanelUpdatesReceivedListener_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOnMixpanelUpdatesReceivedListener", "(Lcom/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener;)V"), new JValue (p0));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.UpdatesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI.UpdatesListener']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

#region "Event implementation for Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener"
			public event EventHandler MixpanelUpdatesReceived {
				add {
					global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener, global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor>(
							ref weak_implementor_AddOnMixpanelUpdatesReceivedListener,
							__CreateIOnMixpanelUpdatesReceivedListenerImplementor,
							AddOnMixpanelUpdatesReceivedListener,
							__h => __h.Handler += value);
				}
				remove {
					global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener, global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor>(
							ref weak_implementor_AddOnMixpanelUpdatesReceivedListener,
							global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor.__IsEmpty,
							RemoveOnMixpanelUpdatesReceivedListener,
							__h => __h.Handler -= value);
				}
			}

			WeakReference weak_implementor_AddOnMixpanelUpdatesReceivedListener;

			global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor __CreateIOnMixpanelUpdatesReceivedListenerImplementor ()
			{
				return new global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerImplementor (this);
			}
#endregion
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/MixpanelAPI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MixpanelAPI); }
		}

		protected MixpanelAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDistinctId;
#pragma warning disable 0169
		static Delegate GetGetDistinctIdHandler ()
		{
			if (cb_getDistinctId == null)
				cb_getDistinctId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistinctId);
			return cb_getDistinctId;
		}

		static IntPtr n_GetDistinctId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DistinctId);
		}
#pragma warning restore 0169

		static IntPtr id_getDistinctId;
		public virtual string DistinctId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='getDistinctId' and count(parameter)=0]"
			[Register ("getDistinctId", "()Ljava/lang/String;", "GetGetDistinctIdHandler")]
			get {
				if (id_getDistinctId == IntPtr.Zero)
					id_getDistinctId = JNIEnv.GetMethodID (class_ref, "getDistinctId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDistinctId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistinctId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPeople;
#pragma warning disable 0169
		static Delegate GetGetPeopleHandler ()
		{
			if (cb_getPeople == null)
				cb_getPeople = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeople);
			return cb_getPeople;
		}

		static IntPtr n_GetPeople (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.People);
		}
#pragma warning restore 0169

		static IntPtr id_getPeople;
		public virtual global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople People {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='getPeople' and count(parameter)=0]"
			[Register ("getPeople", "()Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;", "GetGetPeopleHandler")]
			get {
				if (id_getPeople == IntPtr.Zero)
					id_getPeople = JNIEnv.GetMethodID (class_ref, "getPeople", "()Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (JNIEnv.CallObjectMethod  (Handle, id_getPeople), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI.IPeople> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeople", "()Lcom/mixpanel/android/mpmetrics/MixpanelAPI$People;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSuperProperties;
#pragma warning disable 0169
		static Delegate GetGetSuperPropertiesHandler ()
		{
			if (cb_getSuperProperties == null)
				cb_getSuperProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuperProperties);
			return cb_getSuperProperties;
		}

		static IntPtr n_GetSuperProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SuperProperties);
		}
#pragma warning restore 0169

		static IntPtr id_getSuperProperties;
		public virtual global::Org.Json.JSONObject SuperProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='getSuperProperties' and count(parameter)=0]"
			[Register ("getSuperProperties", "()Lorg/json/JSONObject;", "GetGetSuperPropertiesHandler")]
			get {
				if (id_getSuperProperties == IntPtr.Zero)
					id_getSuperProperties = JNIEnv.GetMethodID (class_ref, "getSuperProperties", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getSuperProperties), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuperProperties", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_alias_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAlias_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_alias_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_alias_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Alias_Ljava_lang_String_Ljava_lang_String_);
			return cb_alias_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Alias_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Alias (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_alias_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='alias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("alias", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAlias_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void Alias (string p0, string p1)
		{
			if (id_alias_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_alias_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "alias", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_alias_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "alias", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_clearSuperProperties;
#pragma warning disable 0169
		static Delegate GetClearSuperPropertiesHandler ()
		{
			if (cb_clearSuperProperties == null)
				cb_clearSuperProperties = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearSuperProperties);
			return cb_clearSuperProperties;
		}

		static void n_ClearSuperProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearSuperProperties ();
		}
#pragma warning restore 0169

		static IntPtr id_clearSuperProperties;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='clearSuperProperties' and count(parameter)=0]"
		[Register ("clearSuperProperties", "()V", "GetClearSuperPropertiesHandler")]
		public virtual void ClearSuperProperties ()
		{
			if (id_clearSuperProperties == IntPtr.Zero)
				id_clearSuperProperties = JNIEnv.GetMethodID (class_ref, "clearSuperProperties", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearSuperProperties);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearSuperProperties", "()V"));
		}

		static IntPtr id_enableFallbackServer_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='enableFallbackServer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableFallbackServer", "(Landroid/content/Context;Z)V", "")]
		public static void EnableFallbackServer (global::Android.Content.Context p0, bool p1)
		{
			if (id_enableFallbackServer_Landroid_content_Context_Z == IntPtr.Zero)
				id_enableFallbackServer_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "enableFallbackServer", "(Landroid/content/Context;Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_enableFallbackServer_Landroid_content_Context_Z, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_flush);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flush", "()V"));
		}

		static IntPtr id_getInstance_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/MixpanelAPI;", "")]
		public static global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI GetInstance (global::Android.Content.Context p0, string p1)
		{
			if (id_getInstance_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/mixpanel/android/mpmetrics/MixpanelAPI;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __ret = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_identify_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIdentify_Ljava_lang_String_Handler ()
		{
			if (cb_identify_Ljava_lang_String_ == null)
				cb_identify_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Identify_Ljava_lang_String_);
			return cb_identify_Ljava_lang_String_;
		}

		static void n_Identify_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Identify (p0);
		}
#pragma warning restore 0169

		static IntPtr id_identify_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='identify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("identify", "(Ljava/lang/String;)V", "GetIdentify_Ljava_lang_String_Handler")]
		public virtual void Identify (string p0)
		{
			if (id_identify_Ljava_lang_String_ == IntPtr.Zero)
				id_identify_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "identify", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_identify_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "identify", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_logPosts;
#pragma warning disable 0169
		static Delegate GetLogPostsHandler ()
		{
			if (cb_logPosts == null)
				cb_logPosts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LogPosts);
			return cb_logPosts;
		}

		static void n_LogPosts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LogPosts ();
		}
#pragma warning restore 0169

		static IntPtr id_logPosts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='logPosts' and count(parameter)=0]"
		[Register ("logPosts", "()V", "GetLogPostsHandler")]
		public virtual void LogPosts ()
		{
			if (id_logPosts == IntPtr.Zero)
				id_logPosts = JNIEnv.GetMethodID (class_ref, "logPosts", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_logPosts);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logPosts", "()V"));
		}

		static Delegate cb_registerSuperProperties_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetRegisterSuperProperties_Lorg_json_JSONObject_Handler ()
		{
			if (cb_registerSuperProperties_Lorg_json_JSONObject_ == null)
				cb_registerSuperProperties_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterSuperProperties_Lorg_json_JSONObject_);
			return cb_registerSuperProperties_Lorg_json_JSONObject_;
		}

		static void n_RegisterSuperProperties_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterSuperProperties (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerSuperProperties_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='registerSuperProperties' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("registerSuperProperties", "(Lorg/json/JSONObject;)V", "GetRegisterSuperProperties_Lorg_json_JSONObject_Handler")]
		public virtual void RegisterSuperProperties (global::Org.Json.JSONObject p0)
		{
			if (id_registerSuperProperties_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_registerSuperProperties_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "registerSuperProperties", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerSuperProperties_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerSuperProperties", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static Delegate cb_registerSuperPropertiesOnce_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetRegisterSuperPropertiesOnce_Lorg_json_JSONObject_Handler ()
		{
			if (cb_registerSuperPropertiesOnce_Lorg_json_JSONObject_ == null)
				cb_registerSuperPropertiesOnce_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterSuperPropertiesOnce_Lorg_json_JSONObject_);
			return cb_registerSuperPropertiesOnce_Lorg_json_JSONObject_;
		}

		static void n_RegisterSuperPropertiesOnce_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterSuperPropertiesOnce (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerSuperPropertiesOnce_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='registerSuperPropertiesOnce' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("registerSuperPropertiesOnce", "(Lorg/json/JSONObject;)V", "GetRegisterSuperPropertiesOnce_Lorg_json_JSONObject_Handler")]
		public virtual void RegisterSuperPropertiesOnce (global::Org.Json.JSONObject p0)
		{
			if (id_registerSuperPropertiesOnce_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_registerSuperPropertiesOnce_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "registerSuperPropertiesOnce", "(Lorg/json/JSONObject;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_registerSuperPropertiesOnce_Lorg_json_JSONObject_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerSuperPropertiesOnce", "(Lorg/json/JSONObject;)V"), new JValue (p0));
		}

		static IntPtr id_setFlushInterval_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='setFlushInterval' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setFlushInterval", "(Landroid/content/Context;J)V", "")]
		public static void SetFlushInterval (global::Android.Content.Context p0, long p1)
		{
			if (id_setFlushInterval_Landroid_content_Context_J == IntPtr.Zero)
				id_setFlushInterval_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "setFlushInterval", "(Landroid/content/Context;J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setFlushInterval_Landroid_content_Context_J, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_track_Ljava_lang_String_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetTrack_Ljava_lang_String_Lorg_json_JSONObject_Handler ()
		{
			if (cb_track_Ljava_lang_String_Lorg_json_JSONObject_ == null)
				cb_track_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Track_Ljava_lang_String_Lorg_json_JSONObject_);
			return cb_track_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		static void n_Track_Ljava_lang_String_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Track (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_track_Ljava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='track' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("track", "(Ljava/lang/String;Lorg/json/JSONObject;)V", "GetTrack_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		public virtual void Track (string p0, global::Org.Json.JSONObject p1)
		{
			if (id_track_Ljava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_track_Ljava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "track", "(Ljava/lang/String;Lorg/json/JSONObject;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_track_Ljava_lang_String_Lorg_json_JSONObject_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "track", "(Ljava/lang/String;Lorg/json/JSONObject;)V"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_unregisterSuperProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnregisterSuperProperty_Ljava_lang_String_Handler ()
		{
			if (cb_unregisterSuperProperty_Ljava_lang_String_ == null)
				cb_unregisterSuperProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterSuperProperty_Ljava_lang_String_);
			return cb_unregisterSuperProperty_Ljava_lang_String_;
		}

		static void n_UnregisterSuperProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.MixpanelAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterSuperProperty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterSuperProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/class[@name='MixpanelAPI']/method[@name='unregisterSuperProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterSuperProperty", "(Ljava/lang/String;)V", "GetUnregisterSuperProperty_Ljava_lang_String_Handler")]
		public virtual void UnregisterSuperProperty (string p0)
		{
			if (id_unregisterSuperProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterSuperProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unregisterSuperProperty", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unregisterSuperProperty_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterSuperProperty", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
