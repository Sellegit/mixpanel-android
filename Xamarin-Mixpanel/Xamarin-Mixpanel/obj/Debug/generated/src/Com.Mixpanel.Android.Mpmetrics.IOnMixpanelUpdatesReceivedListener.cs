using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Mpmetrics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='OnMixpanelUpdatesReceivedListener']"
	[Register ("com/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener", "", "Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerInvoker")]
	public partial interface IOnMixpanelUpdatesReceivedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.mpmetrics']/interface[@name='OnMixpanelUpdatesReceivedListener']/method[@name='onMixpanelUpdatesReceived' and count(parameter)=0]"
		[Register ("onMixpanelUpdatesReceived", "()V", "GetOnMixpanelUpdatesReceivedHandler:Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListenerInvoker, Xamarin-Mixpanel")]
		void OnMixpanelUpdatesReceived ();

	}

	[global::Android.Runtime.Register ("com/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener", DoNotGenerateAcw=true)]
	internal class IOnMixpanelUpdatesReceivedListenerInvoker : global::Java.Lang.Object, IOnMixpanelUpdatesReceivedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListener");
		IntPtr class_ref;

		public static IOnMixpanelUpdatesReceivedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnMixpanelUpdatesReceivedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mixpanel.android.mpmetrics.OnMixpanelUpdatesReceivedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnMixpanelUpdatesReceivedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnMixpanelUpdatesReceivedListenerInvoker); }
		}

		static Delegate cb_onMixpanelUpdatesReceived;
#pragma warning disable 0169
		static Delegate GetOnMixpanelUpdatesReceivedHandler ()
		{
			if (cb_onMixpanelUpdatesReceived == null)
				cb_onMixpanelUpdatesReceived = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMixpanelUpdatesReceived);
			return cb_onMixpanelUpdatesReceived;
		}

		static void n_OnMixpanelUpdatesReceived (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mixpanel.Android.Mpmetrics.IOnMixpanelUpdatesReceivedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMixpanelUpdatesReceived ();
		}
#pragma warning restore 0169

		IntPtr id_onMixpanelUpdatesReceived;
		public void OnMixpanelUpdatesReceived ()
		{
			if (id_onMixpanelUpdatesReceived == IntPtr.Zero)
				id_onMixpanelUpdatesReceived = JNIEnv.GetMethodID (class_ref, "onMixpanelUpdatesReceived", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onMixpanelUpdatesReceived);
		}

	}

	[global::Android.Runtime.Register ("mono/com/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListenerImplementor")]
	internal sealed class IOnMixpanelUpdatesReceivedListenerImplementor : global::Java.Lang.Object, IOnMixpanelUpdatesReceivedListener {

		object sender;

		public IOnMixpanelUpdatesReceivedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mixpanel/android/mpmetrics/OnMixpanelUpdatesReceivedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnMixpanelUpdatesReceived ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnMixpanelUpdatesReceivedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
