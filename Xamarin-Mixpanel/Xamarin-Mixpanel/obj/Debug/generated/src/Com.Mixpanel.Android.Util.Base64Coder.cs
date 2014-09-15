using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mixpanel.Android.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']"
	[global::Android.Runtime.Register ("com/mixpanel/android/util/Base64Coder", DoNotGenerateAcw=true)]
	public partial class Base64Coder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mixpanel/android/util/Base64Coder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64Coder); }
		}

		protected Base64Coder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']/constructor[@name='Base64Coder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Base64Coder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Base64Coder)) {
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

		static IntPtr id_decode_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("decode", "([C)[B", "")]
		public static byte[] Decode (char[] p0)
		{
			if (id_decode_arrayC == IntPtr.Zero)
				id_decode_arrayC = JNIEnv.GetStaticMethodID (class_ref, "decode", "([C)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayC, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)[B", "")]
		public static byte[] Decode (string p0)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_decodeString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']/method[@name='decodeString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string DecodeString (string p0)
		{
			if (id_decodeString_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[C", "")]
		public static char[] Encode (byte[] p0)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encode", "([B)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (char));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encode_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encode", "([BI)[C", "")]
		public static char[] Encode (byte[] p0, int p1)
		{
			if (id_encode_arrayBI == IntPtr.Zero)
				id_encode_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BI)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (char));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mixpanel.android.util']/class[@name='Base64Coder']/method[@name='encodeString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string EncodeString (string p0)
		{
			if (id_encodeString_Ljava_lang_String_ == IntPtr.Zero)
				id_encodeString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encodeString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
