using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

internal class Class32
{
	public delegate string Delegate3();

	public delegate bool Delegate4(string harwareID, string confirmationCode);

	public delegate void Delegate5(byte[] license);

	public delegate bool Delegate6(string code);

	private static bool bool_0;

	private static bool bool_1;

	private static bool bool_2;

	private static bool bool_3;

	private static bool bool_4;

	private static bool bool_5;

	private static int int_0;

	private static int int_1;

	private static string string_0;

	private static string string_1;

	private static int int_2;

	private static int int_3;

	private static int int_4;

	private static Enum9 enum9_0;

	private static DateTime dateTime_0;

	private static SortedList sortedList_0;

	private static byte[] byte_0;

	private static Delegate3 delegate3_0;

	private static Delegate4 delegate4_0;

	private static Delegate5 delegate5_0;

	private static Delegate6 delegate6_0;

	public static string License_HardwareID
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	internal static void smethod_0()
	{
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_5 = false;
		int_0 = 0;
		int_1 = 0;
		string_1 = "####-####-####-####-####";
		int_2 = 1;
		int_3 = 0;
		int_4 = 1;
		enum9_0 = Enum9.Trial_Days;
		_ = DateTime.Now;
		sortedList_0 = new SortedList();
		byte_0 = new byte[0];
	}

	[SpecialName]
	public static void smethod_1(Delegate3 delegate3_1)
	{
		Delegate3 @delegate = delegate3_0;
		Delegate3 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate3 value = (Delegate3)Delegate.Combine(delegate2, delegate3_1);
			@delegate = Interlocked.CompareExchange(ref delegate3_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	public static void smethod_2(Delegate3 delegate3_1)
	{
		Delegate3 @delegate = delegate3_0;
		Delegate3 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate3 value = (Delegate3)Delegate.Remove(delegate2, delegate3_1);
			@delegate = Interlocked.CompareExchange(ref delegate3_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	public static string smethod_3()
	{
		return Class27.mnXVjhLkuzfP();
	}

	[SpecialName]
	public static void smethod_4(Delegate4 delegate4_1)
	{
		Delegate4 @delegate = delegate4_0;
		Delegate4 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate4 value = (Delegate4)Delegate.Combine(delegate2, delegate4_1);
			@delegate = Interlocked.CompareExchange(ref delegate4_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	public static void smethod_5(Delegate4 delegate4_1)
	{
		Delegate4 @delegate = delegate4_0;
		Delegate4 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate4 value = (Delegate4)Delegate.Remove(delegate2, delegate4_1);
			@delegate = Interlocked.CompareExchange(ref delegate4_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	public static bool smethod_6(string string_2, string string_3)
	{
		return Class27.ZrRNvHlikiwq(string_2, string_3);
	}

	[SpecialName]
	public static void smethod_7(Delegate5 delegate5_1)
	{
		Delegate5 @delegate = delegate5_0;
		Delegate5 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate5 value = (Delegate5)Delegate.Combine(delegate2, delegate5_1);
			@delegate = Interlocked.CompareExchange(ref delegate5_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	public static void smethod_8(Delegate5 delegate5_1)
	{
		Delegate5 @delegate = delegate5_0;
		Delegate5 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate5 value = (Delegate5)Delegate.Remove(delegate2, delegate5_1);
			@delegate = Interlocked.CompareExchange(ref delegate5_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	public static void smethod_9(byte[] byte_1)
	{
		byte[] byte_2 = byte_1;
		if (byte_1 == null || byte_1.Length == 0)
		{
			byte[] array = new byte[1];
			byte_2 = array;
		}
		new Class27().method_4(byte_2);
	}

	[SpecialName]
	public static void smethod_10(Delegate6 delegate6_1)
	{
		Delegate6 @delegate = delegate6_0;
		Delegate6 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate6 value = (Delegate6)Delegate.Combine(delegate2, delegate6_1);
			@delegate = Interlocked.CompareExchange(ref delegate6_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	[SpecialName]
	public static void smethod_11(Delegate6 delegate6_1)
	{
		Delegate6 @delegate = delegate6_0;
		Delegate6 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate6 value = (Delegate6)Delegate.Remove(delegate2, delegate6_1);
			@delegate = Interlocked.CompareExchange(ref delegate6_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	public static bool smethod_12(string string_2)
	{
		return Class27.goi348hf283zrnAR(string_2);
	}

	public static void smethod_13(string string_2)
	{
		FileStream fileStream = new FileStream(string_2, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		smethod_9(array);
	}

	[SpecialName]
	public static bool smethod_14()
	{
		return bool_0;
	}

	[SpecialName]
	public static void smethod_15(bool bool_6)
	{
		bool_0 = bool_6;
	}

	[SpecialName]
	public static string smethod_16()
	{
		return string_0;
	}

	[SpecialName]
	public static void smethod_17(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	public static bool smethod_18()
	{
		return bool_1;
	}

	[SpecialName]
	public static void smethod_19(bool bool_6)
	{
		bool_1 = bool_6;
	}

	[SpecialName]
	public static bool PANRZKKSM()
	{
		return bool_2;
	}

	[SpecialName]
	public static void smethod_20(bool bool_6)
	{
		bool_2 = bool_6;
	}

	[SpecialName]
	public static bool smethod_21()
	{
		return bool_3;
	}

	[SpecialName]
	public static void smethod_22(bool bool_6)
	{
		bool_3 = bool_6;
	}

	[SpecialName]
	public static bool smethod_23()
	{
		return bool_4;
	}

	[SpecialName]
	public static void smethod_24(bool bool_6)
	{
		bool_4 = bool_6;
	}

	[SpecialName]
	public static bool smethod_25()
	{
		return bool_5;
	}

	[SpecialName]
	public static void smethod_26(bool bool_6)
	{
		bool_5 = bool_6;
	}

	[SpecialName]
	public static int smethod_27()
	{
		return int_0;
	}

	[SpecialName]
	public static void smethod_28(int int_5)
	{
		int_0 = int_5;
	}

	[SpecialName]
	public static int smethod_29()
	{
		return int_1;
	}

	[SpecialName]
	public static void smethod_30(int int_5)
	{
		int_1 = int_5;
	}

	[SpecialName]
	public static int smethod_31()
	{
		return int_4;
	}

	[SpecialName]
	public static void smethod_32(int int_5)
	{
		int_4 = int_5;
	}

	[SpecialName]
	public static int smethod_33()
	{
		return int_2;
	}

	[SpecialName]
	public static void smethod_34(int int_5)
	{
		int_2 = int_5;
	}

	[SpecialName]
	public static int smethod_35()
	{
		return int_3;
	}

	[SpecialName]
	public static void smethod_36(int int_5)
	{
		int_3 = int_5;
	}

	[SpecialName]
	public static Enum9 smethod_37()
	{
		return enum9_0;
	}

	[SpecialName]
	public static void smethod_38(Enum9 enum9_1)
	{
		enum9_0 = enum9_1;
	}

	[SpecialName]
	public static byte[] smethod_39()
	{
		return byte_0;
	}

	[SpecialName]
	public static void smethod_40(byte[] byte_1)
	{
		byte_0 = byte_1;
	}

	[SpecialName]
	public static DateTime smethod_41()
	{
		return dateTime_0;
	}

	[SpecialName]
	public static void smethod_42(DateTime dateTime_1)
	{
		dateTime_0 = dateTime_1;
	}

	[SpecialName]
	public static SortedList smethod_43()
	{
		return sortedList_0;
	}

	[SpecialName]
	public static void smethod_44(SortedList sortedList_1)
	{
		sortedList_0 = sortedList_1;
	}

	public static string smethod_45(bool bool_6, bool bool_7, bool bool_8, bool bool_9)
	{
		return Class7.smethod_11(bool_7, bool_9, bool_6, bool_8);
	}

	private Class32()
	{
	}

	static Class32()
	{
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_5 = false;
		int_0 = 0;
		int_1 = 0;
		string_0 = "####-####-####-####-####";
		string_1 = "####-####-####-####-####";
		int_2 = 1;
		int_3 = 0;
		int_4 = 1;
		enum9_0 = Enum9.Trial_Days;
		dateTime_0 = DateTime.Now;
		sortedList_0 = new SortedList();
		byte_0 = new byte[0];
	}
}
