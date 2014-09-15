using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='ActivityImageUtils']"
	[global::Android.Runtime.Register ("com/mixpanel/android/util/ActivityImageUtils", DoNotGenerateAcw=true)]
	public partial class ActivityImageUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/util/ActivityImageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActivityImageUtils); }
		}

		protected ActivityImageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='ActivityImageUtils']/constructor[@name='ActivityImageUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ActivityImageUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ActivityImageUtils)) {
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

		static IntPtr id_getHighlightColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='ActivityImageUtils']/method[@name='getHighlightColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHighlightColor", "(I)I", "")]
		public static int GetHighlightColor (int p0)
		{
			if (id_getHighlightColor_I == IntPtr.Zero)
				id_getHighlightColor_I = JNIEnv.GetStaticMethodID (class_ref, "getHighlightColor", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_getHighlightColor_I, new JValue (p0));
		}

		static IntPtr id_getHighlightColorFromBackground_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='ActivityImageUtils']/method[@name='getHighlightColorFromBackground' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getHighlightColorFromBackground", "(Landroid/app/Activity;)I", "")]
		public static int GetHighlightColorFromBackground (global::Android.App.Activity p0)
		{
			if (id_getHighlightColorFromBackground_Landroid_app_Activity_ == IntPtr.Zero)
				id_getHighlightColorFromBackground_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "getHighlightColorFromBackground", "(Landroid/app/Activity;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getHighlightColorFromBackground_Landroid_app_Activity_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getHighlightColorFromBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='ActivityImageUtils']/method[@name='getHighlightColorFromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getHighlightColorFromBitmap", "(Landroid/graphics/Bitmap;)I", "")]
		public static int GetHighlightColorFromBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_getHighlightColorFromBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getHighlightColorFromBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "getHighlightColorFromBitmap", "(Landroid/graphics/Bitmap;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getHighlightColorFromBitmap_Landroid_graphics_Bitmap_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_getScaledScreenshot_Landroid_app_Activity_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='ActivityImageUtils']/method[@name='getScaledScreenshot' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("getScaledScreenshot", "(Landroid/app/Activity;IIZ)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap GetScaledScreenshot (global::Android.App.Activity p0, int p1, int p2, bool p3)
		{
			if (id_getScaledScreenshot_Landroid_app_Activity_IIZ == IntPtr.Zero)
				id_getScaledScreenshot_Landroid_app_Activity_IIZ = JNIEnv.GetStaticMethodID (class_ref, "getScaledScreenshot", "(Landroid/app/Activity;IIZ)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScaledScreenshot_Landroid_app_Activity_IIZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
