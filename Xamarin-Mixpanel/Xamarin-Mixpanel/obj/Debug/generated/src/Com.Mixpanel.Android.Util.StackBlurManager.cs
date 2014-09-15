using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='StackBlurManager']"
	[global::Android.Runtime.Register ("com/mixpanel/android/util/StackBlurManager", DoNotGenerateAcw=true)]
	public partial class StackBlurManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/util/StackBlurManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StackBlurManager); }
		}

		protected StackBlurManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='StackBlurManager']/constructor[@name='StackBlurManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public StackBlurManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (StackBlurManager)) {
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

		static IntPtr id_process_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='StackBlurManager']/method[@name='process' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("process", "(Landroid/graphics/Bitmap;I)V", "")]
		public static void Process (global::Android.Graphics.Bitmap p0, int p1)
		{
			if (id_process_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_process_Landroid_graphics_Bitmap_I = JNIEnv.GetStaticMethodID (class_ref, "process", "(Landroid/graphics/Bitmap;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_process_Landroid_graphics_Bitmap_I, new JValue (p0), new JValue (p1));
		}

	}
}
