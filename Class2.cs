using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class2
{
	internal class Attribute0 : Attribute
	{
		internal class Class3<T>
		{
		}

		[Attribute0(typeof(Class3<object>[]))]
		public Attribute0(object object_0)
		{
		}
	}

	internal class Class4
	{
		[Attribute0(typeof(Attribute0.Class3<object>[]))]
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = BjkXsyRir(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = SuhhReBcy();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate1(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate2();

	internal struct Struct19
	{
		internal bool bool_0;

		internal byte[] byte_0;
	}

	[Flags]
	private enum Enum0
	{

	}

	private static Assembly assembly_0;

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static byte[] byte_2;

	private static int[] int_0;

	private static int int_1;

	private static SortedList sortedList_0;

	private static int int_2;

	private static int int_3;

	private static bool bool_0;

	private static long long_0;

	private static string[] string_0;

	private static bool bool_1;

	internal static Hashtable hashtable_0;

	private static uint[] uint_0;

	private static IntPtr intptr_0;

	private static int int_4;

	[Attribute0(typeof(Attribute0.Class3<object>[]))]
	private static bool firstrundone;

	private static bool bool_2;

	private static IntPtr intptr_1;

	internal static Delegate1 delegate1_0;

	private static bool bool_3;

	private static long long_1;

	private static bool bool_4;

	internal static Delegate1 delegate1_1;

	private static IntPtr intptr_2;

	private static byte[] byte_3;

	private static bool bool_5;

	static Class2()
	{
		bool_2 = false;
		assembly_0 = typeof(Class2).Assembly;
		uint_0 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		bool_3 = false;
		bool_1 = false;
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		byte_2 = new byte[0];
		byte_3 = new byte[0];
		intptr_0 = IntPtr.Zero;
		intptr_2 = IntPtr.Zero;
		string_0 = new string[0];
		int_0 = new int[0];
		int_1 = 1;
		bool_4 = false;
		sortedList_0 = new SortedList();
		int_2 = 0;
		long_0 = 0L;
		delegate1_0 = null;
		delegate1_1 = null;
		long_1 = 0L;
		int_4 = 0;
		bool_5 = false;
		bool_0 = false;
		int_3 = 0;
		intptr_1 = IntPtr.Zero;
		firstrundone = false;
		hashtable_0 = new Hashtable();
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void i5LbZBeV1hisF()
	{
	}

	internal static byte[] creoiNvd7(byte[] byte_4)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_4.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(byte_4.Length + num2 / 8 + 8L);
		ulong num4 = (ulong)(byte_4.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_4.Length; i++)
		{
			array2[i] = byte_4[i];
		}
		array2[byte_4.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFFL);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num7 = 0u; num7 < num6 / 16; num7++)
		{
			uint num8 = num7 << 6;
			for (uint num9 = 0u; num9 < 61; num9 += 4)
			{
				array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
			}
			uint num10 = uint_;
			uint num11 = uint_2;
			uint num12 = uint_3;
			uint num13 = uint_4;
			smethod_0(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			smethod_0(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			smethod_0(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			smethod_0(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			smethod_0(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			smethod_0(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			smethod_0(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			smethod_0(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			smethod_0(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			smethod_0(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			smethod_0(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			smethod_0(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			smethod_0(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			smethod_0(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			smethod_0(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			smethod_0(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void smethod_0(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_4(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_4(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_4(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_4(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static uint smethod_4(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> 32 - ushort_0) | (uint_1 << (int)ushort_0);
	}

	internal static bool smethod_5()
	{
		if (!bool_3)
		{
			smethod_6();
			bool_3 = true;
		}
		return bool_1;
	}

	internal static SymmetricAlgorithm SuhhReBcy()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (smethod_5())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	internal static void smethod_6()
	{
		try
		{
			bool_1 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] BjkXsyRir(byte[] byte_4)
	{
		if (!smethod_5())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_4);
		}
		return creoiNvd7(byte_4);
	}

	private static uint smethod_7(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	[Attribute0(typeof(Attribute0.Class3<object>[]))]
	internal static string smethod_8(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int smethod_9()
	{
		return 5;
	}

	private static void smethod_10()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate smethod_11(IntPtr intptr_3, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { intptr_3, type_0 });
	}

	internal static object smethod_12(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(assembly_1.Location))
			{
				return assembly_1.Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return assembly_1.GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
				.ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[Attribute0(typeof(Attribute0.Class3<object>[]))]
	private static byte[] smethod_13(string string_1)
	{
		using FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[Attribute0(typeof(Attribute0.Class3<object>[]))]
	private static byte[] smethod_14(byte[] byte_4)
	{
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = SuhhReBcy();
		symmetricAlgorithm.Key = new byte[32]
		{
			116, 174, 240, 192, 25, 107, 150, 52, 154, 73,
			92, 72, 188, 113, 54, 156, 250, 139, 193, 214,
			68, 75, 226, 14, 247, 212, 31, 153, 117, 180,
			91, 149
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			184, 164, 246, 125, 72, 30, 197, 189, 74, 196,
			210, 65, 207, 93, 240, 121
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_4, 0, byte_4.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private byte[] method_0()
	{
		return null;
	}

	private byte[] method_1()
	{
		return null;
	}

	private byte[] method_2()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_3()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_4()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_5()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_6()
	{
		return null;
	}

	internal byte[] method_7()
	{
		return null;
	}

	internal byte[] method_8()
	{
		return null;
	}

	internal byte[] udfDaXdkp()
	{
		return null;
	}
}
