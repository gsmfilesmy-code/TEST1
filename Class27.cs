using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns0;

internal class Class27 : LicenseProvider
{
	internal sealed class Class28
	{
		private uint uint_0;

		private uint uint_1;

		private uint uint_2;

		private uint uint_3;

		private uint uint_4;

		private int int_0 = 32;

		public Class28()
		{
			method_0(Environment.TickCount);
		}

		public Class28(int int_1)
		{
			method_0(int_1);
		}

		public void method_0(int int_1)
		{
			uint_0 = (uint)int_1;
			uint_1 = 842502087u;
			uint_2 = 3579807591u;
			uint_3 = 273326509u;
		}

		public uint method_1()
		{
			uint num = uint_0 ^ (uint_0 << 11);
			uint_0 = uint_1;
			uint_1 = uint_2;
			uint_2 = uint_3;
			return uint_3 = uint_3 ^ (uint_3 >> 19) ^ (num ^ (num >> 8));
		}

		public int method_2()
		{
			uint num = uint_0 ^ (uint_0 << 11);
			uint_0 = uint_1;
			uint_1 = uint_2;
			uint_2 = uint_3;
			return (int)(0x7FFFFFFF & (uint_3 = uint_3 ^ (uint_3 >> 19) ^ (num ^ (num >> 8))));
		}

		public int method_3(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentOutOfRangeException("upperBound", int_1, "upperBound must be >=0");
			}
			uint num = uint_0 ^ (uint_0 << 11);
			uint_0 = uint_1;
			uint_1 = uint_2;
			uint_2 = uint_3;
			return (int)(4.656612873077393E-10 * (double)(int)(0x7FFFFFFF & (uint_3 = uint_3 ^ (uint_3 >> 19) ^ (num ^ (num >> 8)))) * (double)int_1);
		}

		public int method_4(int int_1, int int_2)
		{
			if (int_1 > int_2)
			{
				throw new ArgumentOutOfRangeException("upperBound", int_2, "upperBound must be >=lowerBound");
			}
			uint num = uint_0 ^ (uint_0 << 11);
			uint_0 = uint_1;
			uint_1 = uint_2;
			uint_2 = uint_3;
			int num2 = int_2 - int_1;
			if (num2 < 0)
			{
				return int_1 + (int)(2.3283064365386963E-10 * (double)(uint_3 = uint_3 ^ (uint_3 >> 19) ^ (num ^ (num >> 8))) * (double)((long)int_2 - (long)int_1));
			}
			return int_1 + (int)(4.656612873077393E-10 * (double)(int)(0x7FFFFFFF & (uint_3 = uint_3 ^ (uint_3 >> 19) ^ (num ^ (num >> 8)))) * (double)num2);
		}

		public double method_5()
		{
			uint num = uint_0 ^ (uint_0 << 11);
			uint_0 = uint_1;
			uint_1 = uint_2;
			uint_2 = uint_3;
			return 4.656612873077393E-10 * (double)(int)(0x7FFFFFFF & (uint_3 = uint_3 ^ (uint_3 >> 19) ^ (num ^ (num >> 8))));
		}

		public void method_6(byte[] byte_0)
		{
			uint num = uint_0;
			uint num2 = uint_1;
			uint num3 = uint_2;
			uint num4 = uint_3;
			int num5 = 0;
			while (num5 < byte_0.Length - 3)
			{
				uint num6 = num ^ (num << 11);
				num = num2;
				num2 = num3;
				num3 = num4;
				num4 = num4 ^ (num4 >> 19) ^ (num6 ^ (num6 >> 8));
				byte_0[num5++] = (byte)(num4 & 0xFF);
				byte_0[num5++] = (byte)((num4 & 0xFF00) >> 8);
				byte_0[num5++] = (byte)((num4 & 0xFF0000) >> 16);
				byte_0[num5++] = (byte)((num4 & 0xFF000000u) >> 24);
			}
			if (num5 < byte_0.Length)
			{
				uint num6 = num ^ (num << 11);
				num = num2;
				num2 = num3;
				num3 = num4;
				num4 = num4 ^ (num4 >> 19) ^ (num6 ^ (num6 >> 8));
				byte_0[num5++] = (byte)(num4 & 0xFF);
				if (num5 < byte_0.Length)
				{
					byte_0[num5++] = (byte)((num4 & 0xFF00) >> 8);
					if (num5 < byte_0.Length)
					{
						byte_0[num5++] = (byte)((num4 & 0xFF0000) >> 16);
						if (num5 < byte_0.Length)
						{
							byte_0[num5] = (byte)((num4 & 0xFF000000u) >> 24);
						}
					}
				}
			}
			uint_0 = num;
			uint_1 = num2;
			uint_2 = num3;
			uint_3 = num4;
		}

		public bool method_7()
		{
			if (int_0 == 32)
			{
				uint num = uint_0 ^ (uint_0 << 11);
				uint_0 = uint_1;
				uint_1 = uint_2;
				uint_2 = uint_3;
				uint_4 = (uint_3 = uint_3 ^ (uint_3 >> 19) ^ (num ^ (num >> 8)));
				int_0 = 1;
				return (uint_4 & 1) == 1;
			}
			int_0++;
			return ((uint_4 >>= 1) & 1) == 1;
		}
	}

	[LicenseProvider(typeof(Class27))]
	private class Class29
	{
		private void method_0()
		{
			LicenseManager.Validate(typeof(Class27));
		}
	}

	private class Class30 : License
	{
		private object object_0;

		private string string_0;

		public override string LicenseKey => string_0;

		public Class30(object object_1, string string_1)
		{
			object_0 = object_1;
			string_0 = string_1;
		}

		public override void Dispose()
		{
		}
	}

	private class Class31
	{
		internal static System.Threading.Timer agaXvOxhNT;

		public Class31()
		{
			agaXvOxhNT = new System.Threading.Timer(method_0, null, 90000, 30000);
		}

		internal void method_0(object object_0)
		{
			agaXvOxhNT.Dispose();
			try
			{
				TerminateProcess(GetCurrentProcess(), 1);
			}
			catch
			{
			}
		}
	}

	internal static Class7.Class26 class26_0;

	private System.Threading.Timer timer_0;

	private System.Threading.Timer timer_1;

	private Type type_0;

	private Class7.Class26 class26_1 = new Class7.Class26();

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	private static string string_0;

	private static string string_1;

	private static string OatXsojhyP;

	private static string string_2;

	private static string string_3;

	private static string string_4;

	private static string string_5;

	private static string string_6;

	private static int int_4;

	private static int int_5;

	private static string string_7;

	private static DateTime dateTime_0;

	private static DateTime dateTime_1;

	private static bool bool_0;

	private static bool bool_1;

	private static bool bool_2;

	private static Class31 class31_0;

	private static byte[] byte_0;

	private bool method_0(RegistryKey registryKey_0, string string_8)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_8);
		method_1(registryKey_0, registryKey);
		registryKey.Close();
		return true;
	}

	private void method_1(RegistryKey registryKey_0, RegistryKey registryKey_1)
	{
		string[] valueNames = registryKey_0.GetValueNames();
		foreach (string name in valueNames)
		{
			object value = registryKey_0.GetValue(name);
			registryKey_1.SetValue(name, value);
		}
		string[] subKeyNames = registryKey_0.GetSubKeyNames();
		foreach (string text in subKeyNames)
		{
			RegistryKey registryKey_2 = registryKey_0.OpenSubKey(text, writable: false);
			RegistryKey registryKey_3 = registryKey_1.CreateSubKey(text);
			method_1(registryKey_2, registryKey_3);
		}
	}

	private void method_2(RegistryKey registryKey_0, string string_8)
	{
		string text = "";
		string[] valueNames = registryKey_0.GetValueNames();
		foreach (string text2 in valueNames)
		{
			string text3 = registryKey_0.GetValue(text2).ToString();
			if (text.Length > 0)
			{
				text += "|";
			}
			text = text + text2 + "|" + text3;
		}
		Class7 @class = new Class7();
		@class.method_2(text, string_8);
	}

	private void method_3(string string_8, string string_9)
	{
		Class7 @class = new Class7();
		string text = @class.method_3(string_8);
		string[] array = text.Split('|');
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_9);
		for (int i = 0; i < array.Length / 2; i++)
		{
			registryKey.SetValue(array[i * 2], array[i * 2 + 1]);
		}
		registryKey.Close();
	}

	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
	{
		return method_4(new byte[0]);
	}

	internal License method_4(byte[] byte_1)
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
		bool flag = false;
		if (byte_1.Length > 0)
		{
			flag = true;
		}
		if (!flag && bool_0)
		{
			return new Class30(this, "");
		}
		bool flag2 = false;
		if (flag && bool_0)
		{
			flag2 = Class32.smethod_14();
			Class32.smethod_0();
		}
		bool_0 = true;
		lSfgApatkdxsVcGcrktoFd lSfgApatkdxsVcGcrktoFd = null;
		try
		{
			lSfgApatkdxsVcGcrktoFd = new lSfgApatkdxsVcGcrktoFd();
		}
		catch
		{
		}
		Class7.Class26 @class = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		bool flag3 = false;
		try
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
			type_0 = typeof(rFohpatkdxsVcxLfJKhM7);
			string executablePath = Application.ExecutablePath;
			if (Class27.string_7.Length > 0)
			{
				executablePath = Class27.string_7;
			}
			Class27.string_7 = executablePath;
			new Class7();
			@class = new Class7.Class26();
			BinaryReader binaryReader = new BinaryReader(typeof(Class2).Assembly.GetManifestResourceStream("VgFGZmyZqhJCcDS3Yj.ksWKLiZt4MR1M67FQv"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = new byte[0];
			byte[] array2 = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array3 = new byte[32];
			array3[0] = 148;
			array3[0] = 137;
			array3[0] = 89;
			array3[0] = 79;
			array3[0] = 88;
			array3[0] = 204;
			array3[1] = 137;
			array3[1] = 159;
			array3[1] = 100;
			array3[1] = 228;
			array3[2] = 175;
			array3[2] = 88;
			array3[2] = 160;
			array3[2] = 132;
			array3[2] = 128;
			array3[2] = 82;
			array3[3] = 149;
			array3[3] = 78;
			array3[3] = 13;
			array3[4] = 148;
			array3[4] = 88;
			array3[4] = 124;
			array3[4] = 196;
			array3[5] = 96;
			array3[5] = 142;
			array3[5] = 106;
			array3[5] = 230;
			array3[5] = 75;
			array3[6] = 108;
			array3[6] = 155;
			array3[6] = 59;
			array3[7] = 157;
			array3[7] = 163;
			array3[7] = 139;
			array3[7] = 147;
			array3[7] = 156;
			array3[7] = 143;
			array3[8] = 144;
			array3[8] = 120;
			array3[8] = 161;
			array3[9] = 123;
			array3[9] = 13;
			array3[9] = 46;
			array3[9] = 180;
			array3[10] = 88;
			array3[10] = 163;
			array3[10] = 87;
			array3[10] = 136;
			array3[10] = 56;
			array3[10] = 208;
			array3[11] = 154;
			array3[11] = 217;
			array3[11] = 116;
			array3[11] = 110;
			array3[11] = 123;
			array3[11] = 235;
			array3[12] = 80;
			array3[12] = 85;
			array3[12] = 129;
			array3[13] = 150;
			array3[13] = 158;
			array3[13] = 111;
			array3[14] = 151;
			array3[14] = 111;
			array3[14] = 96;
			array3[14] = 98;
			array3[14] = 100;
			array3[14] = 72;
			array3[15] = 114;
			array3[15] = 170;
			array3[15] = 121;
			array3[15] = 28;
			array3[16] = 142;
			array3[16] = 63;
			array3[16] = 140;
			array3[16] = 166;
			array3[17] = 144;
			array3[17] = 125;
			array3[17] = 161;
			array3[17] = 80;
			array3[18] = 231;
			array3[18] = 152;
			array3[18] = 139;
			array3[18] = 124;
			array3[18] = 132;
			array3[19] = 86;
			array3[19] = 53;
			array3[19] = 254;
			array3[20] = 155;
			array3[20] = 174;
			array3[20] = 132;
			array3[20] = 225;
			array3[21] = 174;
			array3[21] = 122;
			array3[21] = 103;
			array3[21] = 114;
			array3[21] = 120;
			array3[22] = 130;
			array3[22] = 131;
			array3[22] = 121;
			array3[23] = 122;
			array3[23] = 183;
			array3[23] = 43;
			array3[24] = 159;
			array3[24] = 162;
			array3[24] = 151;
			array3[24] = 91;
			array3[25] = 115;
			array3[25] = 91;
			array3[25] = 132;
			array3[25] = 123;
			array3[25] = 66;
			array3[26] = 160;
			array3[26] = 128;
			array3[26] = 136;
			array3[26] = 120;
			array3[26] = 115;
			array3[26] = 47;
			array3[27] = 148;
			array3[27] = 93;
			array3[27] = 81;
			array3[28] = 166;
			array3[28] = 151;
			array3[28] = 100;
			array3[28] = 221;
			array3[28] = 50;
			array3[29] = 159;
			array3[29] = 21;
			array3[29] = 105;
			array3[29] = 58;
			array3[29] = 159;
			array3[29] = 63;
			array3[30] = 126;
			array3[30] = 184;
			array3[30] = 101;
			array3[30] = 148;
			array3[31] = 64;
			array3[31] = 94;
			array3[31] = 69;
			byte[] rgbKey = array3;
			byte[] array4 = new byte[16];
			array4[0] = 117;
			array4[0] = 92;
			array4[0] = 104;
			array4[0] = 123;
			array4[0] = 150;
			array4[0] = 18;
			array4[1] = 87;
			array4[1] = 188;
			array4[1] = 200;
			array4[1] = 128;
			array4[1] = 161;
			array4[1] = 27;
			array4[2] = 169;
			array4[2] = 168;
			array4[2] = 50;
			array4[2] = 16;
			array4[3] = 148;
			array4[3] = 160;
			array4[3] = 122;
			array4[3] = 113;
			array4[3] = 109;
			array4[4] = 151;
			array4[4] = 158;
			array4[4] = 52;
			array4[4] = 99;
			array4[4] = 178;
			array4[5] = 103;
			array4[5] = 131;
			array4[5] = 108;
			array4[5] = 208;
			array4[6] = 144;
			array4[6] = 147;
			array4[6] = 136;
			array4[6] = 88;
			array4[6] = 138;
			array4[7] = 154;
			array4[7] = 115;
			array4[7] = 118;
			array4[7] = 225;
			array4[8] = 208;
			array4[8] = 97;
			array4[8] = 34;
			array4[8] = 136;
			array4[8] = 223;
			array4[9] = 73;
			array4[9] = 152;
			array4[9] = 88;
			array4[9] = 169;
			array4[9] = 161;
			array4[10] = 91;
			array4[10] = 106;
			array4[10] = 93;
			array4[10] = 183;
			array4[10] = 74;
			array4[11] = 110;
			array4[11] = 165;
			array4[11] = 178;
			array4[12] = 148;
			array4[12] = 132;
			array4[12] = 204;
			array4[13] = 179;
			array4[13] = 82;
			array4[13] = 222;
			array4[14] = 113;
			array4[14] = 104;
			array4[14] = 43;
			array4[15] = 144;
			array4[15] = 141;
			array4[15] = 64;
			array4[15] = 136;
			array4[15] = 120;
			array4[15] = 161;
			byte[] rgbIV = array4;
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, rgbIV);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			array = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
			@class.method_15(array);
			try
			{
				if (@class.string_18.Length > 0)
				{
					type_0 = GetType().Assembly.GetType(@class.string_18, throwOnError: false);
					if (type_0 == null)
					{
						type_0 = typeof(rFohpatkdxsVcxLfJKhM7);
					}
				}
				else
				{
					type_0 = typeof(rFohpatkdxsVcxLfJKhM7);
				}
			}
			catch
			{
			}
			if (class26_0 != null && class26_0.class15_0 != null && class26_0.class15_0.method_8() != null)
			{
				class26_0.class15_0.method_8().Clear();
			}
			class26_0 = @class;
			int_0 = @class.int_3;
			int_1 = @class.int_4;
			int_2 = @class.int_1;
			if (class26_0.bool_5)
			{
				try
				{
					if (!flag)
					{
						Application.EnableVisualStyles();
						Application.DoEvents();
					}
				}
				catch
				{
				}
			}
			if (@class.bool_0)
			{
				try
				{
					if (!flag)
					{
						lSfgApatkdxsVcGcrktoFd.Show();
						lSfgApatkdxsVcGcrktoFd.Invalidate();
						lSfgApatkdxsVcGcrktoFd.progressBar1.Invalidate();
						Application.DoEvents();
					}
				}
				catch
				{
				}
			}
			try
			{
				if (!flag && File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\lkasedfjsedfuwemnbsfdcgwaeiu"))
				{
					MessageBox.Show(Encoding.Unicode.GetString(Convert.FromBase64String(@class.string_10)));
				}
			}
			catch
			{
			}
			if (!@class.bool_62 && !flag)
			{
				try
				{
					if (@class.bool_0)
					{
						try
						{
							if (!flag)
							{
								lSfgApatkdxsVcGcrktoFd.Hide();
							}
						}
						catch
						{
						}
					}
					rFohpatkdxsVcxLfJKhM7 rFohpatkdxsVcxLfJKhM = new rFohpatkdxsVcxLfJKhM7();
					rFohpatkdxsVcxLfJKhM.ShowDialog();
					if (@class.bool_0)
					{
						try
						{
							if (!flag)
							{
								lSfgApatkdxsVcGcrktoFd.Show();
								lSfgApatkdxsVcGcrktoFd.Invalidate();
								lSfgApatkdxsVcGcrktoFd.progressBar1.Invalidate();
								Application.DoEvents();
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			bool flag4 = false;
			flag3 = false;
			if (!@class.bool_52 && !@class.bool_44 && !@class.bool_50 && @class.bool_38 && !@class.bool_36)
			{
				flag3 = true;
			}
			else
			{
				flag4 = true;
			}
			if (flag4)
			{
				try
				{
					if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage"))
					{
						Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage");
					}
				}
				catch
				{
				}
				if (!flag || (flag && byte_1.Length == 1))
				{
					try
					{
						flag3 = method_9(@class);
					}
					catch
					{
					}
					ArrayList arrayList = new ArrayList();
					try
					{
						if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory))
						{
							arrayList.Add(AppDomain.CurrentDomain.BaseDirectory);
						}
					}
					catch
					{
					}
					try
					{
						if (Directory.Exists(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath))
						{
							arrayList.Add(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath);
						}
					}
					catch
					{
					}
					try
					{
						if (AppDomain.CurrentDomain.GetData("DataDirectory") != null)
						{
							string text = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
							if (Directory.Exists(text))
							{
								arrayList.Add(text + "\\");
							}
						}
					}
					catch
					{
					}
					try
					{
						if (AppDomain.CurrentDomain.GetData("PRIVATE_BINPATH") != null)
						{
							string text2 = AppDomain.CurrentDomain.GetData("PRIVATE_BINPATH").ToString();
							if (Directory.Exists(text2))
							{
								arrayList.Add(text2 + "\\");
							}
						}
					}
					catch
					{
					}
					for (int i = 0; i < arrayList.Count; i++)
					{
						try
						{
							if (!flag3)
							{
								flag3 = method_8(@class, (string)arrayList[i]);
							}
						}
						catch
						{
						}
					}
					try
					{
						if (!flag3)
						{
							flag3 = method_8(@class, Path.GetDirectoryName(executablePath));
						}
					}
					catch
					{
					}
					try
					{
						if (!flag3)
						{
							flag3 = method_8(@class, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
						}
					}
					catch
					{
					}
					try
					{
						if (!flag3 && typeof(Class27).Assembly.Location.Length > 0)
						{
							flag3 = method_8(@class, Path.GetDirectoryName(typeof(Class27).Assembly.Location));
						}
					}
					catch
					{
					}
					try
					{
						if (!flag3)
						{
							flag3 = method_8(@class, Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.System)));
						}
					}
					catch
					{
					}
					try
					{
						if (!flag3)
						{
							flag3 = method_8(@class, Environment.GetFolderPath(Environment.SpecialFolder.System));
						}
					}
					catch
					{
					}
				}
			}
			if (flag && byte_1.Length > 1)
			{
				flag4 = true;
				flag3 = false;
				if (!(flag3 = method_7(@class, byte_1)))
				{
					return new Class30(this, "");
				}
				if (timer_0 != null)
				{
					try
					{
						timer_0.Dispose();
					}
					catch
					{
					}
					timer_0 = null;
				}
				if (timer_1 != null)
				{
					try
					{
						timer_1.Dispose();
					}
					catch
					{
					}
					timer_1 = null;
				}
			}
			Class7.Class16.lejMwloOne();
			if (flag4 && flag3)
			{
				try
				{
					string text3 = "Software\\CLASSES\\CLSID\\";
					string text4 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
					RegistryKey localMachine = Registry.LocalMachine;
					RegistryKey registryKey = localMachine.OpenSubKey(text3 + text4 + Class7.smethod_32(@class.class15_0.method_4()), writable: false);
					if (registryKey != null)
					{
						flag3 = false;
					}
				}
				catch
				{
				}
				try
				{
					if (flag3)
					{
						string text5 = "Software\\CLASSES\\CLSID\\";
						string text6 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
						RegistryKey currentUser = Registry.CurrentUser;
						RegistryKey registryKey2 = currentUser.OpenSubKey(text5 + text6 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
						if (registryKey2 != null)
						{
							flag3 = false;
						}
					}
				}
				catch
				{
				}
				try
				{
					if (flag3)
					{
						string text7 = "Software\\CLASSES\\CID\\";
						string text8 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
						RegistryKey currentUser2 = Registry.CurrentUser;
						RegistryKey registryKey3 = currentUser2.OpenSubKey(text7 + text8 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
						if (registryKey3 != null)
						{
							flag3 = false;
						}
					}
				}
				catch
				{
				}
			}
			bool flag5 = true;
			bool flag6 = true;
			bool flag7 = true;
			num5 = 0;
			num = 0;
			num2 = 0;
			bool flag8 = false;
			bool flag9 = false;
			if (flag4 && flag3)
			{
				int_4 = int.MaxValue;
				string s = Convert.ToBase64String(@class.class15_0.method_4());
				if (!class26_1.bool_58)
				{
					@class.class15_0.method_5(class26_1.byte_0);
				}
				if (class26_1.bool_61)
				{
					num5 = class26_1.int_7;
					if (class26_1.enum9_1 == Enum9.Trial_Days)
					{
						try
						{
							string text9 = "Software\\CLASSES\\CID\\";
							string text10 = "Software\\CLASSES\\CLSID\\";
							RegistryKey currentUser3 = Registry.CurrentUser;
							RegistryKey registryKey4 = null;
							try
							{
								registryKey4 = currentUser3.OpenSubKey(text9, writable: false);
							}
							catch
							{
								registryKey4 = null;
							}
							Class28 class2 = new Class28();
							int num6 = class2.method_3(24);
							string[] array5 = new string[0];
							int num7 = 0;
							if (registryKey4 != null)
							{
								array5 = registryKey4.GetSubKeyNames();
								num7 = array5.Length;
							}
							int num8 = 25;
							if (registryKey4 == null)
							{
								num6 = 0;
								num8 = 1;
							}
							if (num7 < 3)
							{
								num6 = 0;
								num8 = 1;
							}
							for (int j = 0; j < num8; j++)
							{
								if (j == num6)
								{
									if (string_0.Length == 0)
									{
										string_0 = Class7.Class8.smethod_12();
									}
									string text11 = "{B1159E65-821C3-21C5-CE21-34A484D54444}\\";
									RegistryKey currentUser4 = Registry.CurrentUser;
									RegistryKey registryKey5 = currentUser4.OpenSubKey(text9 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
									if (registryKey5 == null)
									{
										RegistryKey registryKey6 = currentUser4.OpenSubKey(text10 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
										if (registryKey6 != null)
										{
											method_0(registryKey6, text9 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											registryKey5 = currentUser4.OpenSubKey(text9 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
										}
									}
									if (registryKey5 == null)
									{
										if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text11)))
										{
											method_3(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text11), text9 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										}
										else
										{
											try
											{
												currentUser4 = Registry.LocalMachine;
												registryKey5 = currentUser4.OpenSubKey(text9 + text11 + Class7.smethod_32(@class.class15_0.method_4()), writable: false);
												if (registryKey5 != null)
												{
													method_0(registryKey5, text9 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
												}
												else
												{
													text11 = "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\";
													currentUser4 = Registry.CurrentUser;
													registryKey5 = currentUser4.OpenSubKey(text9 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
													if (registryKey5 != null)
													{
														method_0(registryKey5, text9 + "{B1159E65-821C3-21C5-CE21-34A484D54444}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
													}
												}
											}
											catch
											{
												text11 = "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\";
												currentUser4 = Registry.CurrentUser;
												registryKey5 = currentUser4.OpenSubKey(text9 + text11 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
												if (registryKey5 != null)
												{
													method_0(registryKey5, text9 + "{B1159E65-821C3-21C5-CE21-34A484D54444}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
												}
											}
										}
									}
									string text12 = "{B1159E65-821C3-21C5-CE21-34A484D54444}\\";
									RegistryKey currentUser5 = Registry.CurrentUser;
									RegistryKey registryKey7 = currentUser5.OpenSubKey(text9 + text12 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
									if (registryKey7 == null)
									{
										RegistryKey registryKey8 = currentUser5.OpenSubKey(text10 + text12 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
										if (registryKey8 != null)
										{
											method_0(registryKey8, text9 + text12 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											registryKey7 = currentUser5.OpenSubKey(text9 + text12 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
										}
									}
									if (registryKey7 != null)
									{
										try
										{
											if (registryKey7.GetValue("3") == null)
											{
												registryKey7.SetValue("3", Class7.nKroQvIwGh("10000000"));
											}
											else if (registryKey7.GetValue("3").ToString().Length == 0)
											{
												registryKey7.SetValue("3", Class7.nKroQvIwGh("10000000"));
											}
										}
										catch
										{
										}
										string string_ = (string)registryKey7.GetValue("1");
										DateTime value = Class7.smethod_31(string_);
										int num9 = Convert.ToInt32(Class7.smethod_36((string)registryKey7.GetValue("3"))) - 10000000;
										decimal num10 = Math.Abs(dateTime.Subtract(value).Days);
										num = (int)num10 + num9;
										if (num10 > 0m)
										{
											Class7.smethod_30(dateTime);
											Class7.nKroQvIwGh((10000000 + num).ToString());
											registryKey7.SetValue("1", Class7.smethod_30(dateTime));
											registryKey7.SetValue("3", Class7.nKroQvIwGh((10000000 + num).ToString()));
											value = dateTime;
										}
										num2 = num5 - num;
										num++;
										if (num > num5)
										{
											flag5 = false;
											num2 = 0;
										}
										int_4 = num2;
										method_0(registryKey7, text9 + "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										method_2(registryKey7, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text12));
									}
									else
									{
										currentUser5 = Registry.CurrentUser;
										registryKey7 = currentUser5.CreateSubKey(text9 + text12 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										Class7.smethod_30(dateTime);
										registryKey7.SetValue("0", Class7.smethod_30(dateTime));
										registryKey7.SetValue("1", Class7.smethod_30(dateTime));
										registryKey7.SetValue("3", Class7.nKroQvIwGh("10000000"));
										num = 1;
										num2 = (int_4 = num5);
										method_0(registryKey7, text9 + "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										method_2(registryKey7, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text12));
									}
									continue;
								}
								try
								{
									int num11 = class2.method_3(num7 - 1);
									RegistryKey registryKey9 = registryKey4.OpenSubKey(array5[num11]);
									if (registryKey9.ValueCount > 0)
									{
										string[] valueNames = registryKey9.GetValueNames();
										if (valueNames.Length > 1)
										{
											registryKey9.GetValue(valueNames[0]);
										}
									}
									registryKey9.Close();
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
					}
				}
				if (class26_1.bool_60)
				{
					try
					{
						string text13 = "Software\\CLASSES\\CID\\";
						string text14 = "Software\\CLASSES\\CLSID\\";
						RegistryKey currentUser6 = Registry.CurrentUser;
						RegistryKey registryKey10 = null;
						try
						{
							registryKey10 = currentUser6.OpenSubKey(text13, writable: false);
						}
						catch
						{
							registryKey10 = null;
						}
						Class28 class3 = new Class28();
						int num12 = class3.method_3(24);
						string[] array6 = new string[0];
						int num13 = 0;
						if (registryKey10 != null)
						{
							array6 = registryKey10.GetSubKeyNames();
							num13 = array6.Length;
						}
						int num14 = 25;
						if (registryKey10 == null)
						{
							num12 = 0;
							num14 = 1;
						}
						if (num13 < 3)
						{
							num12 = 0;
							num14 = 1;
						}
						for (int k = 0; k < num14; k++)
						{
							if (k == num12)
							{
								string text15 = "{A3358E75-826A3-31A5-2C1E-14A484D53571}\\";
								RegistryKey currentUser7 = Registry.CurrentUser;
								RegistryKey registryKey11 = currentUser7.OpenSubKey(text13 + text15 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
								if (registryKey11 == null)
								{
									RegistryKey registryKey12 = currentUser7.OpenSubKey(text14 + text15 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
									if (registryKey12 != null)
									{
										method_0(registryKey12, text13 + text15 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										registryKey11 = currentUser7.OpenSubKey(text13 + text15 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
									}
								}
								if (registryKey11 == null)
								{
									if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text15)))
									{
										method_3(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text15), text13 + text15 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
									}
									else
									{
										try
										{
											currentUser7 = Registry.LocalMachine;
											registryKey11 = currentUser7.OpenSubKey(text13 + text15 + Class7.smethod_32(@class.class15_0.method_4()), writable: false);
											if (registryKey11 != null)
											{
												method_0(registryKey11, text13 + text15 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											}
										}
										catch
										{
										}
									}
								}
								string text16 = "{A3358E75-826A3-31A5-2C1E-14A484D53571}\\";
								RegistryKey currentUser8 = Registry.CurrentUser;
								RegistryKey registryKey13 = currentUser8.OpenSubKey(text13 + text16 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
								if (registryKey13 == null)
								{
									RegistryKey registryKey14 = currentUser8.OpenSubKey(text14 + text16 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
									if (registryKey14 != null)
									{
										method_0(registryKey14, text13 + text16 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										registryKey13 = currentUser8.OpenSubKey(text13 + text16 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
									}
								}
								if (registryKey13 == null)
								{
									currentUser8 = Registry.CurrentUser;
									registryKey13 = currentUser8.CreateSubKey(text13 + text16 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
									registryKey13.SetValue("2", Class7.smethod_30(dateTime));
									DateTime now = DateTime.Now;
									if (DateTime.Compare(now, class26_1.dateTime_1) >= 0)
									{
										flag6 = false;
										num3 = 0;
										if (int_4 == int.MaxValue)
										{
											int_4 = 0;
										}
										else if (!@class.bool_39)
										{
											int_4 = 0;
										}
									}
									else
									{
										TimeSpan timeSpan = class26_1.dateTime_1.Subtract(DateTime.Now);
										num3 = timeSpan.Days;
										if (int_4 == int.MaxValue)
										{
											int_4 = timeSpan.Days;
										}
										else if (@class.bool_39)
										{
											if (timeSpan.Days > int_4)
											{
												int_4 = timeSpan.Days;
											}
										}
										else if (timeSpan.Days < int_4)
										{
											int_4 = timeSpan.Days;
										}
									}
									method_2(registryKey13, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text16));
									continue;
								}
								string string_2 = (string)registryKey13.GetValue("2");
								DateTime dateTime2 = Class7.smethod_31(string_2);
								if (DateTime.Compare(dateTime, dateTime2) >= 0)
								{
									registryKey13.SetValue("2", Class7.smethod_30(dateTime));
									dateTime2 = dateTime;
								}
								if (DateTime.Compare(dateTime2, class26_1.dateTime_1) >= 0)
								{
									flag6 = false;
									num3 = 0;
									if (int_4 == int.MaxValue)
									{
										int_4 = 0;
									}
									else if (!@class.bool_39)
									{
										int_4 = 0;
									}
								}
								else
								{
									TimeSpan timeSpan2 = class26_1.dateTime_1.Subtract(DateTime.Now);
									num3 = timeSpan2.Days;
									if (int_4 == int.MaxValue)
									{
										int_4 = timeSpan2.Days;
									}
									else if (@class.bool_39)
									{
										if (timeSpan2.Days > int_4)
										{
											int_4 = timeSpan2.Days;
										}
									}
									else if (timeSpan2.Days < int_4)
									{
										int_4 = timeSpan2.Days;
									}
								}
								method_2(registryKey13, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text16));
								continue;
							}
							try
							{
								int num15 = class3.method_3(num13 - 1);
								RegistryKey registryKey15 = registryKey10.OpenSubKey(array6[num15]);
								if (registryKey15.ValueCount > 0)
								{
									string[] valueNames2 = registryKey15.GetValueNames();
									if (valueNames2.Length > 1)
									{
										registryKey15.GetValue(valueNames2[0]);
									}
								}
								registryKey15.Close();
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
					if ((!flag || (flag && !flag2)) && class26_1.enum9_1 == Enum9.Trial_Days)
					{
						try
						{
							timer_1.Dispose();
						}
						catch
						{
						}
						try
						{
							dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
							dateTime_1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
							timer_1 = new System.Threading.Timer(method_6, null, 60000, 60000);
						}
						catch
						{
						}
					}
				}
				if (class26_1.bool_57)
				{
					try
					{
						string text17 = "Software\\CLASSES\\CID\\";
						string text18 = "Software\\CLASSES\\CLSID\\";
						RegistryKey currentUser9 = Registry.CurrentUser;
						RegistryKey registryKey16 = null;
						try
						{
							registryKey16 = currentUser9.OpenSubKey(text17, writable: false);
						}
						catch
						{
							registryKey16 = null;
						}
						Class28 class4 = new Class28();
						int num16 = class4.method_3(24);
						string[] array7 = new string[0];
						int num17 = 0;
						if (registryKey16 != null)
						{
							array7 = registryKey16.GetSubKeyNames();
							num17 = array7.Length;
						}
						int num18 = 25;
						if (registryKey16 == null)
						{
							num16 = 0;
							num18 = 1;
						}
						if (num17 < 3)
						{
							num16 = 0;
							num18 = 1;
						}
						for (int l = 0; l < num18; l++)
						{
							if (l == num16)
							{
								string text19 = "{D3558E25-821F3-72C3-8A52-54A482A54739}\\";
								RegistryKey currentUser10 = Registry.CurrentUser;
								RegistryKey registryKey17 = currentUser10.OpenSubKey(text17 + text19 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
								if (registryKey17 == null)
								{
									if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text19)))
									{
										method_3(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text19), text17 + text19 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
									}
									else
									{
										try
										{
											currentUser10 = Registry.LocalMachine;
											registryKey17 = currentUser10.OpenSubKey(text17 + text19 + Class7.smethod_32(@class.class15_0.method_4()), writable: false);
											if (registryKey17 != null)
											{
												method_0(registryKey17, text17 + text19 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											}
										}
										catch
										{
										}
									}
								}
								string text20 = "{D3558E25-821F3-72C3-8A52-54A482A54739}\\";
								RegistryKey currentUser11 = Registry.CurrentUser;
								RegistryKey registryKey18 = currentUser11.OpenSubKey(text17 + text20 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
								bool flag10 = false;
								if (registryKey18 == null)
								{
									flag10 = true;
									registryKey18 = currentUser11.OpenSubKey(text18 + text20 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
								}
								if (registryKey18 == null)
								{
									currentUser11 = Registry.CurrentUser;
									registryKey18 = currentUser11.CreateSubKey(text17 + text20 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
									registryKey18.SetValue("2", Class7.nKroQvIwGh(int_3.ToString()));
									if (class26_1.bool_58)
									{
										flag8 = true;
									}
									if (int_3 > class26_1.int_5)
									{
										flag7 = false;
										int_3 = class26_1.int_5 + 1;
										num4 = 0;
									}
									else
									{
										num4 = class26_1.int_5 - int_3;
									}
									method_2(registryKey18, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text20));
									continue;
								}
								string string_3 = (string)registryKey18.GetValue("2");
								int_3 = Convert.ToInt32(Class7.smethod_36(string_3));
								if (flag10)
								{
									currentUser11 = Registry.CurrentUser;
									registryKey18 = currentUser11.CreateSubKey(text17 + text20 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
									registryKey18.SetValue("2", Class7.nKroQvIwGh(int_3.ToString()));
								}
								if (class26_1.bool_58)
								{
									flag8 = true;
								}
								int_3++;
								registryKey18.SetValue("2", Class7.nKroQvIwGh(int_3.ToString()));
								if (int_3 > class26_1.int_5)
								{
									flag7 = false;
									int_3 = class26_1.int_5 + 1;
									num4 = 0;
								}
								else
								{
									num4 = class26_1.int_5 - int_3;
								}
								method_2(registryKey18, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text20));
								continue;
							}
							try
							{
								int num19 = class4.method_3(num17 - 1);
								RegistryKey registryKey19 = registryKey16.OpenSubKey(array7[num19]);
								if (registryKey19.ValueCount > 0)
								{
									string[] valueNames3 = registryKey19.GetValueNames();
									if (valueNames3.Length > 1)
									{
										registryKey19.GetValue(valueNames3[0]);
									}
								}
								registryKey19.Close();
							}
							catch
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (class26_0.bool_39)
				{
					bool flag11 = true;
					if (class26_1.bool_61)
					{
						flag11 = false;
					}
					if (class26_1.bool_60)
					{
						flag11 = false;
					}
					if (class26_1.bool_57)
					{
						flag11 = false;
					}
					if (class26_1.bool_61 && flag5)
					{
						flag11 = true;
					}
					if (class26_1.bool_60 && flag6)
					{
						flag11 = true;
					}
					if (class26_1.bool_57 && flag7)
					{
						flag11 = true;
					}
					if (!flag11)
					{
						flag3 = false;
						flag9 = true;
					}
				}
				else
				{
					bool flag12 = true;
					if (class26_1.bool_61 && !flag5)
					{
						flag12 = false;
					}
					if (class26_1.bool_60 && !flag6)
					{
						flag12 = false;
					}
					if (class26_1.bool_57 && !flag7)
					{
						flag12 = false;
					}
					if (!flag12)
					{
						flag3 = false;
						flag9 = true;
					}
				}
				@class.class15_0.method_5(Convert.FromBase64String(s));
				if (flag3 && class26_1.bool_61 && (!flag || (flag && !flag2)))
				{
					if (class26_1.enum9_1 == Enum9.Runtime_Minutes)
					{
						try
						{
							timer_0.Dispose();
						}
						catch
						{
						}
						timer_0 = new System.Threading.Timer(method_5, null, num5 * 60000, num5 * 60000);
					}
					if (class26_1.enum9_1 == Enum9.Trial_Days)
					{
						try
						{
							timer_1.Dispose();
						}
						catch
						{
						}
						try
						{
							dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
							dateTime_1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
							timer_1 = new System.Threading.Timer(method_6, null, 60000, 60000);
						}
						catch
						{
						}
					}
				}
			}
			bool flag13 = true;
			if (flag4)
			{
				if ((flag3 || (flag9 && !@class.bool_38)) && class26_1 != null)
				{
					@class.bool_49 = class26_1.bool_49;
					@class.bool_46 = class26_1.bool_46;
					@class.bool_47 = class26_1.bool_47;
					@class.bool_48 = class26_1.bool_48;
					@class.bool_45 = class26_1.KfyOgavDjY;
					@class.KfyOgavDjY = class26_1.KfyOgavDjY;
					@class.string_25 = class26_1.string_25;
					@class.int_3 = class26_1.int_7;
					@class.int_7 = class26_1.int_7;
					num5 = class26_1.int_7;
					int_0 = class26_1.int_7;
					@class.bool_52 = class26_1.bool_61;
					@class.bool_61 = class26_1.bool_61;
					@class.enum9_0 = class26_1.enum9_1;
					@class.enum9_1 = class26_1.enum9_1;
					@class.bool_44 = class26_1.bool_60;
					@class.bool_60 = class26_1.bool_60;
					@class.dateTime_0 = class26_1.dateTime_1;
					@class.dateTime_1 = class26_1.dateTime_1;
					@class.bool_50 = class26_1.bool_57;
					@class.bool_57 = class26_1.bool_57;
					@class.int_5 = class26_1.int_5;
					@class.int_4 = class26_1.int_5;
					int_1 = class26_1.int_5;
					@class.bool_51 = class26_1.bool_59;
					@class.bool_59 = class26_1.bool_59;
					@class.int_6 = class26_1.int_6;
					@class.int_1 = class26_1.int_6;
					int_2 = class26_1.int_6;
				}
				if (!flag3 && (!flag9 || @class.bool_38))
				{
					flag5 = true;
					flag6 = true;
					flag7 = true;
					num5 = 0;
					num = 0;
					num2 = 0;
					int_3 = 1;
					int_4 = int.MaxValue;
					Convert.ToBase64String(@class.class15_0.method_4());
					if (@class.bool_52)
					{
						num5 = @class.int_3;
						if (@class.enum9_0 == Enum9.Trial_Days)
						{
							try
							{
								string text21 = "Software\\CLASSES\\CID\\";
								string text22 = "Software\\CLASSES\\CLSID\\";
								RegistryKey currentUser12 = Registry.CurrentUser;
								RegistryKey registryKey20 = null;
								try
								{
									registryKey20 = currentUser12.OpenSubKey(text21, writable: false);
								}
								catch
								{
									registryKey20 = null;
								}
								Class28 class5 = new Class28();
								int num20 = class5.method_3(24);
								string[] array8 = new string[0];
								int num21 = 0;
								if (registryKey20 != null)
								{
									array8 = registryKey20.GetSubKeyNames();
									num21 = array8.Length;
								}
								int num22 = 25;
								if (registryKey20 == null)
								{
									num20 = 0;
									num22 = 1;
								}
								if (num21 < 3)
								{
									num20 = 0;
									num22 = 1;
								}
								for (int m = 0; m < num22; m++)
								{
									if (m == num20)
									{
										if (string_0.Length == 0)
										{
											string_0 = Class7.Class8.smethod_12();
										}
										string text23 = "{B1159E65-821C3-21C5-CE21-34A484D54444}\\";
										RegistryKey currentUser13 = Registry.CurrentUser;
										RegistryKey registryKey21 = currentUser13.OpenSubKey(text21 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
										if (registryKey21 == null)
										{
											RegistryKey registryKey22 = currentUser13.OpenSubKey(text22 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
											if (registryKey22 != null)
											{
												method_0(registryKey22, text21 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
												registryKey21 = currentUser13.OpenSubKey(text21 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
											}
										}
										if (registryKey21 == null)
										{
											if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text23)))
											{
												method_3(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text23), text21 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											}
											else
											{
												try
												{
													currentUser13 = Registry.LocalMachine;
													registryKey21 = currentUser13.OpenSubKey(text21 + text23 + Class7.smethod_32(@class.class15_0.method_4()), writable: false);
													if (registryKey21 != null)
													{
														method_0(registryKey21, text21 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
													}
													else
													{
														text23 = "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\";
														currentUser13 = Registry.CurrentUser;
														registryKey21 = currentUser13.OpenSubKey(text21 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
														if (registryKey21 != null)
														{
															method_0(registryKey21, text21 + "{B1159E65-821C3-21C5-CE21-34A484D54444}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
														}
													}
												}
												catch
												{
													text23 = "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\";
													currentUser13 = Registry.CurrentUser;
													registryKey21 = currentUser13.OpenSubKey(text21 + text23 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
													if (registryKey21 != null)
													{
														method_0(registryKey21, text21 + "{B1159E65-821C3-21C5-CE21-34A484D54444}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
													}
												}
											}
										}
										string text24 = "{B1159E65-821C3-21C5-CE21-34A484D54444}\\";
										RegistryKey currentUser14 = Registry.CurrentUser;
										RegistryKey registryKey23 = currentUser14.OpenSubKey(text21 + text24 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
										if (registryKey23 == null)
										{
											RegistryKey registryKey24 = currentUser14.OpenSubKey(text22 + text24 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
											if (registryKey24 != null)
											{
												method_0(registryKey24, text21 + text24 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
												registryKey23 = currentUser14.OpenSubKey(text21 + text24 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
											}
										}
										if (registryKey23 != null)
										{
											try
											{
												if (registryKey23.GetValue("3") == null)
												{
													registryKey23.SetValue("3", Class7.nKroQvIwGh("10000000"));
												}
												else if (registryKey23.GetValue("3").ToString().Length == 0)
												{
													registryKey23.SetValue("3", Class7.nKroQvIwGh("10000000"));
												}
											}
											catch
											{
											}
											string string_4 = (string)registryKey23.GetValue("1");
											DateTime value2 = Class7.smethod_31(string_4);
											int num23 = Convert.ToInt32(Class7.smethod_36((string)registryKey23.GetValue("3"))) - 10000000;
											decimal num24 = Math.Abs(dateTime.Subtract(value2).Days);
											num = (int)num24 + num23;
											if (num24 > 0m)
											{
												Class7.smethod_30(dateTime);
												Class7.nKroQvIwGh((10000000 + num).ToString());
												registryKey23.SetValue("1", Class7.smethod_30(dateTime));
												registryKey23.SetValue("3", Class7.nKroQvIwGh((10000000 + num).ToString()));
												value2 = dateTime;
											}
											num2 = num5 - num;
											num++;
											if (num > num5)
											{
												flag5 = false;
												num2 = 0;
											}
											int_4 = num2;
											method_0(registryKey23, text21 + "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											method_2(registryKey23, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text24));
										}
										else
										{
											currentUser14 = Registry.CurrentUser;
											registryKey23 = currentUser14.CreateSubKey(text21 + text24 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											Class7.smethod_30(dateTime);
											registryKey23.SetValue("0", Class7.smethod_30(dateTime));
											registryKey23.SetValue("1", Class7.smethod_30(dateTime));
											registryKey23.SetValue("3", Class7.nKroQvIwGh("10000000"));
											num = 1;
											num2 = (int_4 = num5);
											method_0(registryKey23, text21 + "{" + Class7.Class16.smethod_6(Class7.smethod_0(string_0)) + "}\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											method_2(registryKey23, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text24));
										}
										continue;
									}
									try
									{
										int num25 = class5.method_3(num21 - 1);
										RegistryKey registryKey25 = registryKey20.OpenSubKey(array8[num25]);
										if (registryKey25.ValueCount > 0)
										{
											string[] valueNames4 = registryKey25.GetValueNames();
											if (valueNames4.Length > 1)
											{
												registryKey25.GetValue(valueNames4[0]);
											}
										}
										registryKey25.Close();
									}
									catch
									{
									}
								}
							}
							catch
							{
							}
						}
					}
					if (@class.bool_44)
					{
						try
						{
							string text25 = "Software\\CLASSES\\CID\\";
							string text26 = "Software\\CLASSES\\CLSID\\";
							RegistryKey currentUser15 = Registry.CurrentUser;
							RegistryKey registryKey26 = null;
							try
							{
								registryKey26 = currentUser15.OpenSubKey(text25, writable: false);
							}
							catch
							{
								registryKey26 = null;
							}
							Class28 class6 = new Class28();
							int num26 = class6.method_3(24);
							string[] array9 = new string[0];
							int num27 = 0;
							if (registryKey26 != null)
							{
								array9 = registryKey26.GetSubKeyNames();
								num27 = array9.Length;
							}
							int num28 = 25;
							if (registryKey26 == null)
							{
								num26 = 0;
								num28 = 1;
							}
							if (num27 < 3)
							{
								num26 = 0;
								num28 = 1;
							}
							for (int n = 0; n < num28; n++)
							{
								if (n == num26)
								{
									string text27 = "{A3358E75-826A3-31A5-2C1E-14A484D53571}\\";
									RegistryKey currentUser16 = Registry.CurrentUser;
									RegistryKey registryKey27 = currentUser16.OpenSubKey(text25 + text27 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
									if (registryKey27 == null)
									{
										if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text27)))
										{
											method_3(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text27), text25 + text27 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										}
										else
										{
											try
											{
												currentUser16 = Registry.LocalMachine;
												registryKey27 = currentUser16.OpenSubKey(text25 + text27 + Class7.smethod_32(@class.class15_0.method_4()), writable: false);
												if (registryKey27 != null)
												{
													method_0(registryKey27, text25 + text27 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
												}
											}
											catch
											{
											}
										}
									}
									string text28 = "{A3358E75-826A3-31A5-2C1E-14A484D53571}\\";
									RegistryKey currentUser17 = Registry.CurrentUser;
									RegistryKey registryKey28 = currentUser17.OpenSubKey(text25 + text28 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
									bool flag14 = false;
									if (registryKey28 == null)
									{
										flag14 = true;
										registryKey28 = currentUser17.OpenSubKey(text26 + text28 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
									}
									if (registryKey28 == null)
									{
										currentUser17 = Registry.CurrentUser;
										registryKey28 = currentUser17.CreateSubKey(text25 + text28 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										registryKey28.SetValue("2", Class7.smethod_30(dateTime));
										DateTime now2 = DateTime.Now;
										if (DateTime.Compare(now2, @class.dateTime_0) >= 0)
										{
											flag6 = false;
											num3 = 0;
											if (int_4 == int.MaxValue)
											{
												int_4 = 0;
											}
											else if (!@class.bool_39)
											{
												int_4 = 0;
											}
										}
										else
										{
											TimeSpan timeSpan3 = @class.dateTime_0.Subtract(DateTime.Now);
											num3 = timeSpan3.Days;
											if (int_4 == int.MaxValue)
											{
												int_4 = timeSpan3.Days;
											}
											else if (@class.bool_39)
											{
												if (timeSpan3.Days > int_4)
												{
													int_4 = timeSpan3.Days;
												}
											}
											else if (timeSpan3.Days < int_4)
											{
												int_4 = timeSpan3.Days;
											}
										}
										method_2(registryKey28, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text28));
										continue;
									}
									string string_5 = (string)registryKey28.GetValue("2");
									DateTime dateTime3 = Class7.smethod_31(string_5);
									if (flag14)
									{
										currentUser17 = Registry.CurrentUser;
										registryKey28 = currentUser17.CreateSubKey(text25 + text28 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
										registryKey28.SetValue("2", Class7.smethod_30(dateTime3));
									}
									if (DateTime.Compare(dateTime, dateTime3) >= 0)
									{
										registryKey28.SetValue("2", Class7.smethod_30(dateTime));
										dateTime3 = dateTime;
									}
									if (DateTime.Compare(dateTime3, @class.dateTime_0) >= 0)
									{
										flag6 = false;
										num3 = 0;
										if (int_4 == int.MaxValue)
										{
											int_4 = 0;
										}
										else if (!@class.bool_39)
										{
											int_4 = 0;
										}
									}
									else
									{
										TimeSpan timeSpan4 = @class.dateTime_0.Subtract(DateTime.Now);
										num3 = timeSpan4.Days;
										if (int_4 == int.MaxValue)
										{
											int_4 = timeSpan4.Days;
										}
										else if (@class.bool_39)
										{
											if (timeSpan4.Days > int_4)
											{
												int_4 = timeSpan4.Days;
											}
										}
										else if (timeSpan4.Days < int_4)
										{
											int_4 = timeSpan4.Days;
										}
									}
									method_2(registryKey28, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text28));
									continue;
								}
								try
								{
									int num29 = class6.method_3(num27 - 1);
									RegistryKey registryKey29 = registryKey26.OpenSubKey(array9[num29]);
									if (registryKey29.ValueCount > 0)
									{
										string[] valueNames5 = registryKey29.GetValueNames();
										if (valueNames5.Length > 1)
										{
											registryKey29.GetValue(valueNames5[0]);
										}
									}
									registryKey29.Close();
								}
								catch
								{
								}
							}
						}
						catch (Exception)
						{
						}
						if ((!flag || (flag && !flag2)) && class26_1.enum9_1 == Enum9.Trial_Days)
						{
							try
							{
								timer_1.Dispose();
							}
							catch
							{
							}
							try
							{
								dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
								dateTime_1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
								timer_1 = new System.Threading.Timer(method_6, null, 60000, 60000);
							}
							catch
							{
							}
						}
					}
					if (@class.bool_50)
					{
						if (!bool_1)
						{
							bool_1 = true;
							try
							{
								string text29 = "Software\\CLASSES\\CID\\";
								string text30 = "Software\\CLASSES\\CLSID\\";
								RegistryKey currentUser18 = Registry.CurrentUser;
								RegistryKey registryKey30 = null;
								try
								{
									registryKey30 = currentUser18.OpenSubKey(text29, writable: false);
								}
								catch
								{
									registryKey30 = null;
								}
								Class28 class7 = new Class28();
								int num30 = class7.method_3(24);
								string[] array10 = new string[0];
								int num31 = 0;
								if (registryKey30 != null)
								{
									array10 = registryKey30.GetSubKeyNames();
									num31 = array10.Length;
								}
								int num32 = 25;
								if (registryKey30 == null)
								{
									num30 = 0;
									num32 = 1;
								}
								if (num31 < 3)
								{
									num30 = 0;
									num32 = 1;
								}
								for (int num33 = 0; num33 < num32; num33++)
								{
									if (num33 == num30)
									{
										string text31 = "{D3558E25-821F3-72C3-8A52-54A482A54739}\\";
										RegistryKey currentUser19 = Registry.CurrentUser;
										RegistryKey registryKey31 = currentUser19.OpenSubKey(text29 + text31 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
										if (registryKey31 == null)
										{
											if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text31)))
											{
												method_3(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text31), text29 + text31 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											}
											else
											{
												try
												{
													currentUser19 = Registry.LocalMachine;
													registryKey31 = currentUser19.OpenSubKey(text29 + text31 + Class7.smethod_32(@class.class15_0.method_4()), writable: false);
													if (registryKey31 != null)
													{
														method_0(registryKey31, text29 + text31 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
													}
												}
												catch
												{
												}
											}
										}
										string text32 = "{D3558E25-821F3-72C3-8A52-54A482A54739}\\";
										RegistryKey currentUser20 = Registry.CurrentUser;
										RegistryKey registryKey32 = currentUser20.OpenSubKey(text29 + text32 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: true);
										bool flag15 = false;
										if (registryKey32 == null)
										{
											flag15 = true;
											registryKey32 = currentUser20.OpenSubKey(text30 + text32 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
										}
										if (registryKey32 == null)
										{
											currentUser20 = Registry.CurrentUser;
											registryKey32 = currentUser20.CreateSubKey(text29 + text32 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											registryKey32.SetValue("2", Class7.nKroQvIwGh(int_3.ToString()));
											if (int_3 > @class.int_4)
											{
												flag7 = false;
												int_3 = @class.int_4 + 1;
												num4 = 0;
											}
											else
											{
												num4 = @class.int_4 - int_3;
											}
											method_2(registryKey32, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text32));
											continue;
										}
										string string_6 = (string)registryKey32.GetValue("2");
										int_3 = Convert.ToInt32(Class7.smethod_36(string_6));
										if (flag15)
										{
											currentUser20 = Registry.CurrentUser;
											registryKey32 = currentUser20.CreateSubKey(text29 + text32 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())));
											registryKey32.SetValue("2", Class7.nKroQvIwGh(int_3.ToString()));
										}
										if (!flag8)
										{
											int_3++;
											registryKey32.SetValue("2", Class7.nKroQvIwGh(int_3.ToString()));
										}
										if (int_3 > @class.int_4)
										{
											flag7 = false;
											int_3 = @class.int_4 + 1;
											num4 = 0;
										}
										else
										{
											num4 = @class.int_4 - int_3;
										}
										method_2(registryKey32, Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())) + "\\" + Class7.Class16.smethod_6(text32));
										continue;
									}
									try
									{
										int num34 = class7.method_3(num31 - 1);
										RegistryKey registryKey33 = registryKey30.OpenSubKey(array10[num34], writable: false);
										if (registryKey33.ValueCount > 0)
										{
											string[] valueNames6 = registryKey33.GetValueNames();
											if (valueNames6.Length > 1)
											{
												registryKey33.GetValue(valueNames6[0]);
											}
										}
										registryKey33.Close();
									}
									catch
									{
									}
								}
							}
							catch
							{
							}
						}
						else
						{
							try
							{
								string text33 = "Software\\CLASSES\\CID\\";
								string text34 = "Software\\CLASSES\\CLSID\\";
								string text35 = "{D3558E25-821F3-72C3-8A52-54A482A54739}\\";
								RegistryKey currentUser21 = Registry.CurrentUser;
								RegistryKey registryKey34 = currentUser21.OpenSubKey(text33 + text35 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
								if (registryKey34 == null)
								{
									registryKey34 = currentUser21.OpenSubKey(text34 + text35 + Class7.Class16.smethod_6(Class7.smethod_32(@class.class15_0.method_4())), writable: false);
								}
								if (registryKey34 != null)
								{
									string string_7 = (string)registryKey34.GetValue("2");
									int_3 = Convert.ToInt32(Class7.smethod_36(string_7));
									if (int_3 <= @class.int_4)
									{
										num4 = @class.int_4 - int_3;
									}
									else
									{
										flag7 = false;
										int_3 = @class.int_4 + 1;
										num4 = 0;
									}
								}
							}
							catch
							{
							}
						}
					}
					if (class26_0.bool_39)
					{
						if (@class.bool_52)
						{
							flag13 = false;
						}
						if (@class.bool_44)
						{
							flag13 = false;
						}
						if (@class.bool_50)
						{
							flag13 = false;
						}
						if (@class.bool_52 && flag5)
						{
							flag13 = true;
						}
						if (@class.bool_44 && flag6)
						{
							flag13 = true;
						}
						if (@class.bool_50 && flag7)
						{
							flag13 = true;
						}
					}
					else
					{
						if (@class.bool_52 && !flag5)
						{
							flag13 = false;
						}
						if (@class.bool_44 && !flag6)
						{
							flag13 = false;
						}
						if (@class.bool_50 && !flag7)
						{
							flag13 = false;
						}
					}
				}
				if (flag9 && !@class.bool_38)
				{
					flag13 = false;
				}
			}
			if (@class.bool_51)
			{
				string processName = Process.GetCurrentProcess().ProcessName;
				Process[] processesByName = Process.GetProcessesByName(processName);
				if (processesByName.Length > @class.int_1)
				{
					try
					{
						if (@class.bool_43)
						{
							if (@class.bool_0)
							{
								try
								{
									if (!flag)
									{
										lSfgApatkdxsVcGcrktoFd.Close();
									}
								}
								catch
								{
								}
							}
							ConstructorInfo constructor = type_0.GetConstructor(new Type[0]);
							object target = constructor.Invoke(new object[0]);
							type_0.InvokeMember("MessageBoxCaption", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { @class.string_17 });
							type_0.InvokeMember("MessageBoxGradientBegin", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { @class.color_0 });
							type_0.InvokeMember("MessageBoxGradientEnd", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { @class.color_1 });
							string string_8 = @class.string_24;
							string_8 = string_8.Replace("[current_minutes_days]", num.ToString());
							string_8 = string_8.Replace("[expdate_days_left]", num3.ToString());
							string_8 = string_8.Replace("[minutes_days_left]", num2.ToString());
							string_8 = string_8.Replace("[uses_left]", num4.ToString());
							string_8 = string_8.Replace("[max_minutes_days]", num5.ToString());
							string_8 = string_8.Replace("[max_uses]", int_1.ToString());
							string_8 = string_8.Replace("[max_processes]", int_2.ToString());
							string_8 = string_8.Replace("[current_uses]", int_3.ToString());
							type_0.InvokeMember("MessageBoxText", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { string_8 });
							try
							{
								type_0.InvokeMember("ShowDialog", BindingFlags.InvokeMethod, null, target, new object[0]);
							}
							catch
							{
							}
						}
						TerminateProcess(GetCurrentProcess(), 1);
						return new Class30(this, "");
					}
					catch
					{
					}
				}
			}
			if (@class.bool_0)
			{
				try
				{
					if (!flag)
					{
						lSfgApatkdxsVcGcrktoFd.Close();
					}
				}
				catch
				{
				}
			}
			Class32.smethod_15(flag3);
			if (@class.bool_31)
			{
				Class7.Class8.smethod_12();
				Class32.smethod_17(Class7.Class8.smethod_6(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46));
			}
			try
			{
				Class32.License_HardwareID = @class.string_25;
			}
			catch
			{
			}
			if (class26_1 != null)
			{
				Class32.smethod_43().Clear();
				IDictionaryEnumerator enumerator = class26_1.hashtable_0.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Class32.smethod_43().Add(enumerator.Key.ToString(), enumerator.Value.ToString());
				}
			}
			Class32.smethod_19(@class.bool_52);
			Class32.smethod_28(@class.int_3);
			if (@class.enum9_0 == Enum9.Trial_Days)
			{
				Class32.smethod_38(Enum9.Trial_Days);
				Class32.smethod_30(num);
			}
			else
			{
				Class32.smethod_38(Enum9.Runtime_Minutes);
				Class32.smethod_30(0);
			}
			try
			{
				Class32.smethod_26(@class.bool_45);
				Class32.smethod_20(@class.bool_44);
				Class32.smethod_42(@class.dateTime_0);
			}
			catch
			{
			}
			try
			{
				Class32.smethod_22(@class.bool_50);
				Class32.smethod_34(@class.int_4);
				Class32.smethod_32(int_3);
			}
			catch
			{
			}
			try
			{
				Class32.smethod_24(@class.bool_51);
				Class32.smethod_36(@class.int_1);
			}
			catch
			{
			}
			try
			{
				Class32.smethod_40(byte_0);
			}
			catch
			{
			}
			bool flag16 = false;
			if (!flag3 && !flag9 && !@class.bool_38)
			{
				try
				{
					if (class26_0.bool_41)
					{
						if (class26_0.bool_53 && byte_1.Length == 1 && class31_0 == null)
						{
							class31_0 = new Class31();
						}
						flag16 = true;
						ConstructorInfo constructor2 = type_0.GetConstructor(new Type[0]);
						object target2 = constructor2.Invoke(new object[0]);
						type_0.InvokeMember("MessageBoxCaption", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target2, new object[1] { @class.string_17 });
						type_0.InvokeMember("MessageBoxGradientBegin", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target2, new object[1] { @class.color_0 });
						type_0.InvokeMember("MessageBoxGradientEnd", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target2, new object[1] { @class.color_1 });
						string string_9 = @class.string_21;
						string_9 = string_9.Replace("[current_minutes_days]", num.ToString());
						string_9 = string_9.Replace("[minutes_days_left]", num2.ToString());
						string_9 = string_9.Replace("[expdate_days_left]", num3.ToString());
						string_9 = string_9.Replace("[uses_left]", num4.ToString());
						string_9 = string_9.Replace("[max_minutes_days]", num5.ToString());
						string_9 = string_9.Replace("[max_uses]", int_1.ToString());
						string_9 = string_9.Replace("[max_processes]", int_2.ToString());
						string_9 = string_9.Replace("[current_uses]", int_3.ToString());
						type_0.InvokeMember("MessageBoxText", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target2, new object[1] { string_9 });
						try
						{
							type_0.InvokeMember("ShowDialog", BindingFlags.InvokeMethod, null, target2, new object[0]);
						}
						catch
						{
						}
					}
					if (@class.string_16.Length > 0)
					{
						string text36 = @class.string_16.Trim();
						string text37 = "";
						try
						{
							int num35 = text36.ToUpper().IndexOf(".EXE ");
							if (num35 > 0)
							{
								text37 = text36.Substring(num35 + 5).Trim();
								text36 = text36.Substring(0, num35 + 5).Trim();
							}
						}
						catch
						{
						}
						try
						{
							if (File.Exists(Path.GetFullPath(text36)))
							{
								text36 = Path.GetFullPath(text36);
							}
							else if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Path.GetFileName(text36)))
							{
								text36 = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Path.GetFileName(text36);
							}
						}
						catch
						{
						}
						try
						{
							if (text37.Length == 0)
							{
								Process.Start(text36);
							}
							else
							{
								Process.Start(text36, text37);
							}
						}
						catch
						{
						}
					}
					TerminateProcess(GetCurrentProcess(), 1);
					return new Class30(this, "");
				}
				catch
				{
				}
			}
			if (@class.bool_44 && !flag13 && !flag6)
			{
				try
				{
					if (class26_0.bool_56 && !flag16)
					{
						flag16 = true;
						ConstructorInfo constructor3 = type_0.GetConstructor(new Type[0]);
						object target3 = constructor3.Invoke(new object[0]);
						type_0.InvokeMember("MessageBoxCaption", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target3, new object[1] { @class.string_17 });
						type_0.InvokeMember("MessageBoxGradientBegin", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target3, new object[1] { @class.color_0 });
						type_0.InvokeMember("MessageBoxGradientEnd", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target3, new object[1] { @class.color_1 });
						string string_10 = @class.string_19;
						string_10 = string_10.Replace("[current_minutes_days]", num.ToString());
						string_10 = string_10.Replace("[minutes_days_left]", num2.ToString());
						string_10 = string_10.Replace("[expdate_days_left]", num3.ToString());
						string_10 = string_10.Replace("[uses_left]", num4.ToString());
						string_10 = string_10.Replace("[max_minutes_days]", num5.ToString());
						string_10 = string_10.Replace("[max_uses]", int_1.ToString());
						string_10 = string_10.Replace("[max_processes]", int_2.ToString());
						string_10 = string_10.Replace("[current_uses]", int_3.ToString());
						type_0.InvokeMember("MessageBoxText", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target3, new object[1] { string_10 });
						try
						{
							type_0.InvokeMember("ShowDialog", BindingFlags.InvokeMethod, null, target3, new object[0]);
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			if (@class.bool_52 && !flag13 && !flag5)
			{
				if (@class.bool_52 && @class.enum9_0 == Enum9.Runtime_Minutes)
				{
					flag13 = true;
				}
				else
				{
					try
					{
						if (class26_0.bool_54 && !flag16)
						{
							flag16 = true;
							ConstructorInfo constructor4 = type_0.GetConstructor(new Type[0]);
							object target4 = constructor4.Invoke(new object[0]);
							type_0.InvokeMember("MessageBoxCaption", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target4, new object[1] { @class.string_17 });
							type_0.InvokeMember("MessageBoxGradientBegin", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target4, new object[1] { @class.color_0 });
							type_0.InvokeMember("MessageBoxGradientEnd", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target4, new object[1] { @class.color_1 });
							string string_11 = @class.string_22;
							string_11 = string_11.Replace("[current_minutes_days]", num.ToString());
							string_11 = string_11.Replace("[minutes_days_left]", num2.ToString());
							string_11 = string_11.Replace("[expdate_days_left]", num3.ToString());
							string_11 = string_11.Replace("[uses_left]", num4.ToString());
							string_11 = string_11.Replace("[max_minutes_days]", num5.ToString());
							string_11 = string_11.Replace("[max_uses]", int_1.ToString());
							string_11 = string_11.Replace("[max_processes]", int_2.ToString());
							string_11 = string_11.Replace("[current_uses]", int_3.ToString());
							type_0.InvokeMember("MessageBoxText", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target4, new object[1] { string_11 });
							try
							{
								type_0.InvokeMember("ShowDialog", BindingFlags.InvokeMethod, null, target4, new object[0]);
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
			}
			if (@class.bool_55 && !flag13 && !flag7)
			{
				try
				{
					if (class26_0.bool_55 && !flag16)
					{
						flag16 = true;
						if (!bool_2)
						{
							bool_2 = true;
							ConstructorInfo constructor5 = type_0.GetConstructor(new Type[0]);
							object target5 = constructor5.Invoke(new object[0]);
							type_0.InvokeMember("MessageBoxCaption", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target5, new object[1] { @class.string_17 });
							type_0.InvokeMember("MessageBoxGradientBegin", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target5, new object[1] { @class.color_0 });
							type_0.InvokeMember("MessageBoxGradientEnd", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target5, new object[1] { @class.color_1 });
							string string_12 = @class.string_23;
							string_12 = string_12.Replace("[current_minutes_days]", num.ToString());
							string_12 = string_12.Replace("[minutes_days_left]", num2.ToString());
							string_12 = string_12.Replace("[expdate_days_left]", num3.ToString());
							string_12 = string_12.Replace("[uses_left]", num4.ToString());
							string_12 = string_12.Replace("[max_minutes_days]", num5.ToString());
							string_12 = string_12.Replace("[max_uses]", int_1.ToString());
							string_12 = string_12.Replace("[max_processes]", int_2.ToString());
							string_12 = string_12.Replace("[current_uses]", int_3.ToString());
							type_0.InvokeMember("MessageBoxText", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target5, new object[1] { string_12 });
							try
							{
								type_0.InvokeMember("ShowDialog", BindingFlags.InvokeMethod, null, target5, new object[0]);
							}
							catch
							{
							}
						}
					}
				}
				catch
				{
				}
			}
			if (!flag3 && @class.bool_40 && (@class.bool_44 || @class.bool_52 || @class.bool_50 || @class.bool_45 || !@class.bool_38))
			{
				try
				{
					bool flag17 = true;
					if (class26_0.int_2 != -1 && int_4 > class26_0.int_2)
					{
						flag17 = false;
					}
					if (flag17 && !flag16)
					{
						flag16 = true;
						if (!flag)
						{
							ConstructorInfo constructor6 = type_0.GetConstructor(new Type[0]);
							object target6 = constructor6.Invoke(new object[0]);
							type_0.InvokeMember("MessageBoxCaption", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target6, new object[1] { @class.string_17 });
							type_0.InvokeMember("MessageBoxGradientBegin", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target6, new object[1] { @class.color_0 });
							type_0.InvokeMember("MessageBoxGradientEnd", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target6, new object[1] { @class.color_1 });
							string string_13 = @class.string_20;
							string_13 = string_13.Replace("[current_minutes_days]", num.ToString());
							string_13 = string_13.Replace("[minutes_days_left]", num2.ToString());
							string_13 = string_13.Replace("[expdate_days_left]", num3.ToString());
							string_13 = string_13.Replace("[uses_left]", num4.ToString());
							string_13 = string_13.Replace("[max_minutes_days]", num5.ToString());
							string_13 = string_13.Replace("[max_uses]", int_1.ToString());
							string_13 = string_13.Replace("[max_processes]", int_2.ToString());
							string_13 = string_13.Replace("[current_uses]", int_3.ToString());
							type_0.InvokeMember("MessageBoxText", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target6, new object[1] { string_13 });
							try
							{
								type_0.InvokeMember("ShowDialog", BindingFlags.InvokeMethod, null, target6, new object[0]);
							}
							catch
							{
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
			if (!flag3 && @class.bool_52 && (!flag || (flag && !flag2)))
			{
				if (@class.enum9_0 == Enum9.Runtime_Minutes)
				{
					try
					{
						timer_0.Dispose();
					}
					catch
					{
					}
					timer_0 = new System.Threading.Timer(method_5, null, num5 * 60000, num5 * 60000);
				}
				if (class26_1.enum9_1 == Enum9.Trial_Days)
				{
					try
					{
						timer_1.Dispose();
					}
					catch
					{
					}
					try
					{
						dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
						dateTime_1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
						timer_1 = new System.Threading.Timer(method_6, null, 60000, 60000);
					}
					catch
					{
					}
				}
			}
			if (!flag13)
			{
				if (@class.string_16.Length > 0)
				{
					string text38 = @class.string_16.Trim();
					string text39 = "";
					try
					{
						int num36 = text38.ToUpper().IndexOf(".EXE ");
						if (num36 > 0)
						{
							text39 = text38.Substring(num36 + 5).Trim();
							text38 = text38.Substring(0, num36 + 5).Trim();
						}
					}
					catch
					{
					}
					try
					{
						if (File.Exists(Path.GetFullPath(text38)))
						{
							text38 = Path.GetFullPath(text38);
						}
						else if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Path.GetFileName(text38)))
						{
							text38 = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Path.GetFileName(text38);
						}
					}
					catch
					{
					}
					try
					{
						if (text39.Length == 0)
						{
							Process.Start(text38);
						}
						else
						{
							Process.Start(text38, text39);
						}
					}
					catch
					{
					}
				}
				if (@class.bool_53)
				{
					TerminateProcess(GetCurrentProcess(), 1);
					return new Class30(this, "");
				}
			}
		}
		catch (Exception ex4)
		{
			if (@class != null && @class.class15_0 != null && @class.class15_0.method_8() != null)
			{
				@class.class15_0.method_8().Clear();
			}
			throw ex4;
		}
		return new Class30(this, "");
	}

	private void method_5(object object_0)
	{
		try
		{
			timer_0.Dispose();
		}
		catch
		{
		}
		if (class26_0.bool_53 && class31_0 == null)
		{
			class31_0 = new Class31();
		}
		try
		{
			if (class26_0.bool_54)
			{
				ConstructorInfo constructor = type_0.GetConstructor(new Type[0]);
				object target = constructor.Invoke(new object[0]);
				type_0.InvokeMember("MessageBoxCaption", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { class26_0.string_17 });
				type_0.InvokeMember("MessageBoxGradientBegin", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { class26_0.color_0 });
				type_0.InvokeMember("MessageBoxGradientEnd", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { class26_0.color_1 });
				string string_ = class26_0.string_22;
				string_ = string_.Replace("[current_minutes_days]", int_0.ToString());
				string_ = string_.Replace("[max_minutes_days]", int_0.ToString());
				string_ = string_.Replace("[max_uses]", int_1.ToString());
				string_ = string_.Replace("[max_processes]", int_2.ToString());
				string_ = string_.Replace("[current_uses]", int_3.ToString());
				type_0.InvokeMember("MessageBoxText", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty, null, target, new object[1] { string_ });
				try
				{
					type_0.InvokeMember("ShowDialog", BindingFlags.InvokeMethod, null, target, new object[0]);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		if (class26_0.string_16.Length > 0)
		{
			string text = class26_0.string_16.Trim();
			string text2 = "";
			try
			{
				int num = text.ToUpper().IndexOf(".EXE ");
				if (num > 0)
				{
					text2 = text.Substring(num + 5).Trim();
					text = text.Substring(0, num + 5).Trim();
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(Path.GetFullPath(text)))
				{
					text = Path.GetFullPath(text);
				}
				else if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Path.GetFileName(text)))
				{
					text = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Path.GetFileName(text);
				}
			}
			catch
			{
			}
			try
			{
				if (text2.Length == 0)
				{
					Process.Start(text);
				}
				else
				{
					Process.Start(text, text2);
				}
			}
			catch
			{
			}
		}
		if (class26_0.bool_53)
		{
			TerminateProcess(GetCurrentProcess(), 1);
		}
	}

	private void method_6(object object_0)
	{
		if (dateTime_1 != new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))
		{
			dateTime_1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
			new Class27().method_4(new byte[1] { 1 });
		}
	}

	internal static bool ZrRNvHlikiwq(string string_8, string string_9)
	{
		if (Class7.smethod_33(string_8, class26_0.class15_0.method_4()).ToString() == string_9.ToString())
		{
			return true;
		}
		return false;
	}

	internal static bool goi348hf283zrnAR(string string_8)
	{
		Class7.Class16.lejMwloOne();
		try
		{
			string text = Class7.Class8.smethod_12();
			string text2 = Class7.Class8.smethod_1(class26_0.bool_49, class26_0.bool_47, class26_0.bool_48, class26_0.bool_46);
			string text3 = Class7.Class8.smethod_2(class26_0.bool_49, class26_0.bool_47, class26_0.bool_48, class26_0.bool_46);
			string text4 = Class7.Class8.smethod_3(class26_0.bool_49, class26_0.bool_47, class26_0.bool_48, class26_0.bool_46);
			string text5 = Class7.Class8.smethod_4(class26_0.bool_49, class26_0.bool_47, class26_0.bool_48, class26_0.bool_46);
			string text6 = Class7.Class8.smethod_6(class26_0.bool_49, class26_0.bool_47, class26_0.bool_48, class26_0.bool_46);
			string text7 = Class7.Class8.smethod_5(class26_0.bool_49, class26_0.bool_47, class26_0.bool_48, class26_0.bool_46);
			string text8 = Class7.Class8.smethod_0();
			if (text8 == "{nohid-22222-10001-00000}")
			{
				text8 = text6;
			}
			string[] array = Class7.smethod_35(string_8, class26_0.class15_0.method_4()).Split('|');
			string text9 = array[1];
			string text10 = array[0] + array[2] + array[0] + array[2];
			bool flag = false;
			if (!(text9 == text) && !(text9 == text2) && !(text9 == text3) && !(text9 == text4) && !(text9 == text5) && !(text9 == text6) && !(text9 == text7) && !(text9 == text8))
			{
				return false;
			}
			try
			{
				string text11 = "Software\\CLASSES\\CLSID\\";
				RegistryKey localMachine = Registry.LocalMachine;
				RegistryKey registryKey = localMachine.OpenSubKey(text11 + "{" + text10 + "-826F8-31C4-2C1E-14A4" + Class7.Class16.smethod_6(text9) + "}\\", writable: false);
				if (registryKey != null)
				{
					flag = true;
				}
			}
			catch
			{
			}
			try
			{
				string text12 = "Software\\CLASSES\\CLSID\\";
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey2 = currentUser.OpenSubKey(text12 + "{" + text10 + "-826F8-31C4-2C1E-14A4" + Class7.Class16.smethod_6(text9) + "}\\", writable: false);
				if (registryKey2 != null)
				{
					flag = true;
				}
			}
			catch
			{
			}
			try
			{
				string text13 = "Software\\CLASSES\\CID\\";
				RegistryKey currentUser2 = Registry.CurrentUser;
				RegistryKey registryKey3 = currentUser2.OpenSubKey(text13 + "{" + text10 + "-826F8-31C4-2C1E-14A4" + Class7.Class16.smethod_6(text9) + "}\\", writable: false);
				if (registryKey3 != null)
				{
					flag = true;
				}
			}
			catch
			{
			}
			try
			{
				string text14 = Class7.Class16.smethod_6(Class7.smethod_0("{O33BAC75-826F8-31C4-2C1E-14A484D53587}" + Class7.smethod_32(class26_0.class15_0.method_4()) + text9 + text10));
				if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + text14))
				{
					flag = true;
				}
			}
			catch
			{
			}
			if (flag)
			{
				return false;
			}
			try
			{
				string text15 = "Software\\CLASSES\\CLSID\\";
				RegistryKey localMachine2 = Registry.LocalMachine;
				localMachine2.CreateSubKey(text15 + "{" + text10 + "-826F8-31C4-2C1E-14A4" + Class7.Class16.smethod_6(text9) + "}\\");
				localMachine2.Close();
			}
			catch
			{
			}
			try
			{
				string text16 = "Software\\CLASSES\\CLSID\\";
				RegistryKey currentUser3 = Registry.CurrentUser;
				currentUser3.CreateSubKey(text16 + "{" + text10 + "-826F8-31C4-2C1E-14A4" + Class7.Class16.smethod_6(text9) + "}\\");
				currentUser3.Close();
			}
			catch
			{
			}
			try
			{
				string text17 = "Software\\CLASSES\\CID\\";
				RegistryKey currentUser4 = Registry.CurrentUser;
				currentUser4.CreateSubKey(text17 + "{" + text10 + "-826F8-31C4-2C1E-14A4" + Class7.Class16.smethod_6(text9) + "}\\");
				currentUser4.Close();
			}
			catch
			{
			}
			try
			{
				string text18 = Class7.Class16.smethod_6(Class7.smethod_0("{O33BAC75-826F8-31C4-2C1E-14A484D53587}" + Class7.smethod_32(class26_0.class15_0.method_4()) + text9 + text10));
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + text18);
			}
			catch
			{
			}
			try
			{
				string text19 = "Software\\CLASSES\\CLSID\\";
				string text20 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
				RegistryKey localMachine3 = Registry.LocalMachine;
				localMachine3.DeleteSubKey(text19 + text20 + Class7.smethod_32(class26_0.class15_0.method_4()), throwOnMissingSubKey: false);
			}
			catch
			{
			}
			try
			{
				string text21 = "Software\\CLASSES\\CLSID\\";
				string text22 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
				RegistryKey currentUser5 = Registry.CurrentUser;
				currentUser5.DeleteSubKey(text21 + text22 + Class7.Class16.smethod_6(Class7.smethod_32(class26_0.class15_0.method_4())), throwOnMissingSubKey: false);
			}
			catch
			{
			}
			try
			{
				string text23 = "Software\\CLASSES\\CID\\";
				string text24 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
				RegistryKey currentUser6 = Registry.CurrentUser;
				currentUser6.DeleteSubKey(text23 + text24 + Class7.Class16.smethod_6(Class7.smethod_32(class26_0.class15_0.method_4())), throwOnMissingSubKey: false);
			}
			catch
			{
			}
			try
			{
				string text25 = Class7.Class16.smethod_6(Class7.smethod_0("{Y3358E75-826A3-31A5-2C1E-14A484D53571}" + Class7.smethod_32(class26_0.class15_0.method_4())));
				Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + text25);
			}
			catch
			{
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	internal static void ghjkwzuxlbh(byte[] byte_1)
	{
		string_7.ToString();
		new Class27().method_4(byte_1);
	}

	internal static string mnXVjhLkuzfP()
	{
		string result = "";
		Class7.Class16.lejMwloOne();
		try
		{
			try
			{
				string text = "Software\\CLASSES\\CLSID\\";
				string text2 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
				RegistryKey localMachine = Registry.LocalMachine;
				localMachine.CreateSubKey(text + text2 + Class7.smethod_32(class26_0.class15_0.method_4()));
			}
			catch
			{
			}
			try
			{
				string text3 = "Software\\CLASSES\\CID\\";
				string text4 = "{Y3358E75-826A3-31A5-2C1E-14A484D53571}\\";
				RegistryKey currentUser = Registry.CurrentUser;
				currentUser.CreateSubKey(text3 + text4 + Class7.Class16.smethod_6(Class7.smethod_32(class26_0.class15_0.method_4())));
			}
			catch
			{
			}
			try
			{
				string text5 = Class7.Class16.smethod_6(Class7.smethod_0("{Y3358E75-826A3-31A5-2C1E-14A484D53571}" + Class7.smethod_32(class26_0.class15_0.method_4())));
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Isolated Storage\\" + text5);
			}
			catch
			{
			}
			try
			{
				string string_ = Class7.Class8.smethod_6(class26_0.bool_49, class26_0.bool_47, class26_0.bool_48, class26_0.bool_46);
				result = Class7.smethod_33(string_, class26_0.class15_0.method_4());
			}
			catch
			{
			}
		}
		catch
		{
		}
		return result;
	}

	private bool method_7(Class7.Class26 class26_2, byte[] byte_1)
	{
		try
		{
			Class7.Class26 @class = new Class7.Class26();
			@class.method_21(byte_1, class26_2.bool_3, class26_2);
			bool flag = true;
			for (int i = 0; i < @class.class15_0.method_4().Length; i++)
			{
				if (@class.class15_0.method_4()[i] != class26_2.class15_0.method_4()[i])
				{
					flag = false;
				}
			}
			if (@class.class15_0.method_4().Length < 32)
			{
				flag = false;
			}
			if (!flag)
			{
				@class.method_0();
				return false;
			}
			if (@class.KfyOgavDjY)
			{
				string_0 = Class7.Class8.smethod_12();
				string_1 = Class7.Class8.smethod_1(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
				OatXsojhyP = Class7.Class8.smethod_2(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
				string_2 = Class7.Class8.smethod_3(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
				string_3 = Class7.Class8.smethod_4(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
				string_4 = Class7.Class8.smethod_6(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
				string_5 = Class7.Class8.smethod_5(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
				string_6 = Class7.Class8.smethod_0();
				if (string_6 == "{nohid-22222-10001-00000}")
				{
					string_6 = string_4;
				}
				if (@class.class18_0 == null)
				{
					if (@class.string_25.Length > 0)
					{
						if (!Class7.Class8.smethod_10(@class.string_25, @class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46) && !(string_0.ToString() == @class.string_25.ToString()) && !(string_1.ToString() == @class.string_25.ToString()) && !(OatXsojhyP.ToString() == @class.string_25.ToString()) && !(string_2.ToString() == @class.string_25.ToString()) && !(string_3.ToString() == @class.string_25.ToString()) && !(string_4.ToString() == @class.string_25.ToString()) && !(string_5.ToString() == @class.string_25.ToString()) && !(string_6.ToString() == @class.string_25.ToString()))
						{
							@class.method_0();
							return false;
						}
						if (class26_1 != null)
						{
							class26_1.method_0();
						}
						class26_1 = @class;
						try
						{
							byte_0 = byte_1;
						}
						catch
						{
						}
						return true;
					}
					@class.method_0();
					return false;
				}
				if (@class.string_25.Length > 0)
				{
					if (!Class7.Class8.smethod_10(@class.string_25, @class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46) && !(string_0.ToString() == @class.string_25.ToString()) && !(string_1.ToString() == @class.string_25.ToString()) && !(OatXsojhyP.ToString() == @class.string_25.ToString()) && !(string_2.ToString() == @class.string_25.ToString()) && !(string_3.ToString() == @class.string_25.ToString()) && !(string_4.ToString() == @class.string_25.ToString()) && !(string_5.ToString() == @class.string_25.ToString()) && !(string_6.ToString() == @class.string_25.ToString()))
					{
						@class.method_0();
						return false;
					}
					if (class26_1 != null)
					{
						class26_1.method_0();
					}
					class26_1 = @class;
					try
					{
						byte_0 = byte_1;
					}
					catch
					{
					}
					return true;
				}
				Class7.Class18 class2 = Class7.smethod_29();
				if (class2.method_0().Count != @class.class18_0.method_0().Count)
				{
					@class.method_0();
					return false;
				}
				for (int j = 0; j < class2.method_0().Count; j++)
				{
					Class7.Class21 class3 = class2.method_0().method_0(j);
					Class7.Class21 class4 = @class.class18_0.method_0().method_0(j);
					if (class3.Nlgacufklg() == class4.Nlgacufklg())
					{
						if (!(class3.Name.Trim().ToString() != class4.Name.Trim().ToString()))
						{
							for (int k = 0; k < class3.Nlgacufklg(); k++)
							{
								if (class3.yaoaFohYuj(k).method_2() != null && class4.yaoaFohYuj(k).method_2() != null && class3.yaoaFohYuj(k).method_2().Trim()
									.ToString() != class4.yaoaFohYuj(k).method_2().Trim()
									.ToString())
								{
									@class.method_0();
									return false;
								}
							}
							continue;
						}
						@class.method_0();
						return false;
					}
					@class.method_0();
					return false;
				}
			}
			if (class26_1 != null)
			{
				class26_1.method_0();
			}
			class26_1 = @class;
			try
			{
				byte_0 = byte_1;
			}
			catch
			{
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private bool method_8(Class7.Class26 class26_2, string string_8)
	{
		if (class26_2.string_9.Length > 0 && class26_2.string_9.IndexOf("*") < 0)
		{
			if (File.Exists(string_8 + "\\" + class26_2.string_9))
			{
				try
				{
					Class7.Class26 @class = new Class7.Class26();
					@class.method_20(string_8 + "\\" + class26_2.string_9, class26_2.bool_3, class26_2);
					bool flag = true;
					for (int i = 0; i < @class.class15_0.method_4().Length; i++)
					{
						if (@class.class15_0.method_4()[i] != class26_2.class15_0.method_4()[i])
						{
							flag = false;
						}
					}
					if (@class.class15_0.method_4().Length < 32)
					{
						flag = false;
					}
					if (!flag)
					{
						@class.method_0();
						return false;
					}
					if (@class.KfyOgavDjY)
					{
						string_0 = Class7.Class8.smethod_12();
						string_1 = Class7.Class8.smethod_1(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						OatXsojhyP = Class7.Class8.smethod_2(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_2 = Class7.Class8.smethod_3(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_3 = Class7.Class8.smethod_4(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_4 = Class7.Class8.smethod_6(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_5 = Class7.Class8.smethod_5(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_6 = Class7.Class8.smethod_0();
						if (string_6 == "{nohid-22222-10001-00000}")
						{
							string_6 = string_4;
						}
						if (@class.class18_0 == null)
						{
							if (@class.string_25.Length > 0)
							{
								if (!Class7.Class8.smethod_10(@class.string_25, @class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46) && !(string_0.ToString() == @class.string_25.ToString()) && !(string_1.ToString() == @class.string_25.ToString()) && !(OatXsojhyP.ToString() == @class.string_25.ToString()) && !(string_2.ToString() == @class.string_25.ToString()) && !(string_3.ToString() == @class.string_25.ToString()) && !(string_4.ToString() == @class.string_25.ToString()) && !(string_5.ToString() == @class.string_25.ToString()) && !(string_6.ToString() == @class.string_25.ToString()))
								{
									@class.method_0();
									return false;
								}
								if (class26_1 != null)
								{
									class26_1.method_0();
								}
								class26_1 = @class;
								try
								{
									byte_0 = method_10(string_8 + "\\" + class26_2.string_9);
								}
								catch
								{
								}
								return true;
							}
							@class.method_0();
							return false;
						}
						if (@class.string_25.Length > 0)
						{
							if (!Class7.Class8.smethod_10(@class.string_25, @class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46) && !(string_0.ToString() == @class.string_25.ToString()) && !(string_1.ToString() == @class.string_25.ToString()) && !(OatXsojhyP.ToString() == @class.string_25.ToString()) && !(string_2.ToString() == @class.string_25.ToString()) && !(string_3.ToString() == @class.string_25.ToString()) && !(string_4.ToString() == @class.string_25.ToString()) && !(string_5.ToString() == @class.string_25.ToString()) && !(string_6.ToString() == @class.string_25.ToString()))
							{
								@class.method_0();
								return false;
							}
							if (class26_1 != null)
							{
								class26_1.method_0();
							}
							class26_1 = @class;
							try
							{
								byte_0 = method_10(string_8 + "\\" + class26_2.string_9);
							}
							catch
							{
							}
							return true;
						}
						Class7.Class18 class2 = Class7.smethod_29();
						if (class2.method_0().Count != @class.class18_0.method_0().Count)
						{
							@class.method_0();
							return false;
						}
						for (int j = 0; j < class2.method_0().Count; j++)
						{
							Class7.Class21 class3 = class2.method_0().method_0(j);
							Class7.Class21 class4 = @class.class18_0.method_0().method_0(j);
							if (class3.Nlgacufklg() != class4.Nlgacufklg())
							{
								@class.method_0();
								return false;
							}
							if (class3.Name.Trim().ToString() != class4.Name.Trim().ToString())
							{
								@class.method_0();
								return false;
							}
							for (int k = 0; k < class3.Nlgacufklg(); k++)
							{
								if (class3.yaoaFohYuj(k).method_2() != null && class4.yaoaFohYuj(k).method_2() != null && class3.yaoaFohYuj(k).method_2().Trim()
									.ToString() != class4.yaoaFohYuj(k).method_2().Trim()
									.ToString())
								{
									@class.method_0();
									return false;
								}
							}
						}
					}
					if (class26_1 != null)
					{
						class26_1.method_0();
					}
					class26_1 = @class;
					try
					{
						byte_0 = method_10(string_8 + "\\" + class26_2.string_9);
					}
					catch
					{
					}
					return true;
				}
				catch
				{
					return false;
				}
			}
			return false;
		}
		string searchPattern = "*.license";
		if (class26_2.string_9.Length > 0)
		{
			searchPattern = class26_2.string_9;
		}
		string[] files = Directory.GetFiles(string_8, searchPattern);
		for (int l = 0; l < files.Length; l++)
		{
			try
			{
				Class7.Class26 class5 = new Class7.Class26();
				class5.method_20(files[l], class26_2.bool_3, class26_2);
				bool flag2 = true;
				for (int m = 0; m < class5.class15_0.method_4().Length; m++)
				{
					if (class26_2.class15_0.method_4()[m] != class5.class15_0.method_4()[m])
					{
						flag2 = false;
					}
				}
				if (class5.class15_0.method_4().Length < 32)
				{
					flag2 = false;
				}
				if (!flag2)
				{
					class5.method_0();
					continue;
				}
				if (class5.KfyOgavDjY)
				{
					string_0 = Class7.Class8.smethod_12();
					string_1 = Class7.Class8.smethod_1(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					OatXsojhyP = Class7.Class8.smethod_2(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_2 = Class7.Class8.smethod_3(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_3 = Class7.Class8.smethod_4(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_4 = Class7.Class8.smethod_6(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_5 = Class7.Class8.smethod_5(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_6 = Class7.Class8.smethod_0();
					if (string_6 == "{nohid-22222-10001-00000}")
					{
						string_6 = string_4;
					}
					if (class5.class18_0 == null)
					{
						if (class5.string_25.Length > 0)
						{
							if (!Class7.Class8.smethod_10(class5.string_25, class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46) && !(string_0.ToString() == class5.string_25.ToString()) && !(string_1.ToString() == class5.string_25.ToString()) && !(OatXsojhyP.ToString() == class5.string_25.ToString()) && !(string_2.ToString() == class5.string_25.ToString()) && !(string_3.ToString() == class5.string_25.ToString()) && !(string_4.ToString() == class5.string_25.ToString()) && !(string_5.ToString() == class5.string_25.ToString()) && !(string_6.ToString() == class5.string_25.ToString()))
							{
								class5.method_0();
								return false;
							}
							if (class26_1 != null)
							{
								class26_1.method_0();
							}
							class26_1 = class5;
							try
							{
								byte_0 = method_10(files[l]);
							}
							catch
							{
							}
							return true;
						}
						class5.method_0();
						return false;
					}
					if (class5.string_25.Length > 0)
					{
						if (!Class7.Class8.smethod_10(class5.string_25, class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46) && !(string_0.ToString() == class5.string_25.ToString()) && !(string_1.ToString() == class5.string_25.ToString()) && !(OatXsojhyP.ToString() == class5.string_25.ToString()) && !(string_2.ToString() == class5.string_25.ToString()) && !(string_3.ToString() == class5.string_25.ToString()) && !(string_4.ToString() == class5.string_25.ToString()) && !(string_5.ToString() == class5.string_25.ToString()) && !(string_6.ToString() == class5.string_25.ToString()))
						{
							class5.method_0();
							return false;
						}
						if (class26_1 != null)
						{
							class26_1.method_0();
						}
						class26_1 = class5;
						try
						{
							byte_0 = method_10(files[l]);
						}
						catch
						{
						}
						return true;
					}
					Class7.Class18 class6 = Class7.smethod_29();
					if (class6.method_0().Count != class5.class18_0.method_0().Count)
					{
						class5.method_0();
						return false;
					}
					for (int n = 0; n < class6.method_0().Count; n++)
					{
						Class7.Class21 class7 = class6.method_0().method_0(n);
						Class7.Class21 class8 = class5.class18_0.method_0().method_0(n);
						if (class7.Nlgacufklg() == class8.Nlgacufklg())
						{
							if (!(class7.Name.Trim().ToString() != class8.Name.Trim().ToString()))
							{
								for (int num = 0; num < class7.Nlgacufklg(); num++)
								{
									if (class7.yaoaFohYuj(num).method_2() != null && class8.yaoaFohYuj(num).method_2() != null && class7.yaoaFohYuj(num).method_2().Trim()
										.ToString() != class8.yaoaFohYuj(num).method_2().Trim()
										.ToString())
									{
										class5.method_0();
										return false;
									}
								}
								continue;
							}
							class5.method_0();
							return false;
						}
						class5.method_0();
						return false;
					}
				}
				if (class26_1 != null)
				{
					class26_1.method_0();
				}
				class26_1 = class5;
				try
				{
					byte_0 = method_10(files[l]);
				}
				catch
				{
				}
				return true;
			}
			catch
			{
			}
		}
		return false;
	}

	private bool method_9(Class7.Class26 class26_2)
	{
		if (class26_2.string_9.Length > 0 && class26_2.string_9.IndexOf("*") < 0)
		{
			if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + class26_2.string_9))
			{
				try
				{
					Class7.Class26 @class = new Class7.Class26();
					@class.method_20(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + class26_2.string_9, class26_2.bool_3, class26_2);
					bool flag = true;
					for (int i = 0; i < @class.class15_0.method_4().Length; i++)
					{
						if (class26_2.class15_0.method_4()[i] != @class.class15_0.method_4()[i])
						{
							flag = false;
						}
					}
					if (@class.class15_0.method_4().Length < 32)
					{
						flag = false;
					}
					if (!flag)
					{
						@class.method_0();
						return false;
					}
					if (@class.KfyOgavDjY)
					{
						string_0 = Class7.Class8.smethod_12();
						string_1 = Class7.Class8.smethod_1(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						OatXsojhyP = Class7.Class8.smethod_2(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_2 = Class7.Class8.smethod_3(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_3 = Class7.Class8.smethod_4(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_4 = Class7.Class8.smethod_6(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_5 = Class7.Class8.smethod_5(@class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46);
						string_6 = Class7.Class8.smethod_0();
						if (string_6 == "{nohid-22222-10001-00000}")
						{
							string_6 = string_4;
						}
						if (@class.class18_0 == null)
						{
							if (@class.string_25.Length > 0)
							{
								if (!Class7.Class8.smethod_10(@class.string_25, @class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46) && !(string_0.ToString() == @class.string_25.ToString()) && !(string_1.ToString() == @class.string_25.ToString()) && !(OatXsojhyP.ToString() == @class.string_25.ToString()) && !(string_2.ToString() == @class.string_25.ToString()) && !(string_3.ToString() == @class.string_25.ToString()) && !(string_4.ToString() == @class.string_25.ToString()) && !(string_5.ToString() == @class.string_25.ToString()) && !(string_6.ToString() == @class.string_25.ToString()))
								{
									@class.method_0();
									return false;
								}
								if (class26_1 != null)
								{
									class26_1.method_0();
								}
								class26_1 = @class;
								try
								{
									byte_0 = method_10(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + class26_2.string_9);
								}
								catch
								{
								}
								return true;
							}
							@class.method_0();
							return false;
						}
						if (@class.string_25.Length > 0)
						{
							if (!Class7.Class8.smethod_10(@class.string_25, @class.bool_49, @class.bool_47, @class.bool_48, @class.bool_46) && !(string_0.ToString() == @class.string_25.ToString()) && !(string_1.ToString() == @class.string_25.ToString()) && !(OatXsojhyP.ToString() == @class.string_25.ToString()) && !(string_2.ToString() == @class.string_25.ToString()) && !(string_3.ToString() == @class.string_25.ToString()) && !(string_4.ToString() == @class.string_25.ToString()) && !(string_5.ToString() == @class.string_25.ToString()) && !(string_6.ToString() == @class.string_25.ToString()))
							{
								@class.method_0();
								return false;
							}
							if (class26_1 != null)
							{
								class26_1.method_0();
							}
							class26_1 = @class;
							try
							{
								byte_0 = method_10(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + class26_2.string_9);
							}
							catch
							{
							}
							return true;
						}
						Class7.Class18 class2 = Class7.smethod_29();
						if (class2.method_0().Count != @class.class18_0.method_0().Count)
						{
							@class.method_0();
							return false;
						}
						for (int j = 0; j < class2.method_0().Count; j++)
						{
							Class7.Class21 class3 = class2.method_0().method_0(j);
							Class7.Class21 class4 = @class.class18_0.method_0().method_0(j);
							if (class3.Nlgacufklg() != class4.Nlgacufklg())
							{
								@class.method_0();
								return false;
							}
							if (class3.Name.Trim().ToString() != class4.Name.Trim().ToString())
							{
								@class.method_0();
								return false;
							}
							for (int k = 0; k < class3.Nlgacufklg(); k++)
							{
								if (class3.yaoaFohYuj(k).method_2() != null && class4.yaoaFohYuj(k).method_2() != null && class3.yaoaFohYuj(k).method_2().Trim()
									.ToString() != class4.yaoaFohYuj(k).method_2().Trim()
									.ToString())
								{
									@class.method_0();
									return false;
								}
							}
						}
					}
					if (class26_1 != null)
					{
						class26_1.method_0();
					}
					class26_1 = @class;
					try
					{
						byte_0 = method_10(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + class26_2.string_9);
					}
					catch
					{
					}
					return true;
				}
				catch
				{
					return false;
				}
			}
			return false;
		}
		string searchPattern = "*.license";
		if (class26_2.string_9.Length > 0)
		{
			searchPattern = class26_2.string_9;
		}
		string[] files = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath), searchPattern);
		for (int l = 0; l < files.Length; l++)
		{
			try
			{
				Class7.Class26 class5 = new Class7.Class26();
				class5.method_20(files[l], class26_2.bool_3, class26_2);
				bool flag2 = true;
				for (int m = 0; m < class5.class15_0.method_4().Length; m++)
				{
					if (class26_2.class15_0.method_4()[m] != class5.class15_0.method_4()[m])
					{
						flag2 = false;
					}
				}
				if (class5.class15_0.method_4().Length < 32)
				{
					flag2 = false;
				}
				if (!flag2)
				{
					class5.method_0();
					continue;
				}
				if (class5.KfyOgavDjY)
				{
					string_0 = Class7.Class8.smethod_12();
					string_1 = Class7.Class8.smethod_1(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					OatXsojhyP = Class7.Class8.smethod_2(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_2 = Class7.Class8.smethod_3(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_3 = Class7.Class8.smethod_4(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_4 = Class7.Class8.smethod_6(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_5 = Class7.Class8.smethod_5(class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46);
					string_6 = Class7.Class8.smethod_0();
					if (string_6 == "{nohid-22222-10001-00000}")
					{
						string_6 = string_4;
					}
					if (class5.class18_0 == null)
					{
						if (class5.string_25.Length > 0)
						{
							if (!Class7.Class8.smethod_10(class5.string_25, class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46) && !(string_0.ToString() == class5.string_25.ToString()) && !(string_1.ToString() == class5.string_25.ToString()) && !(OatXsojhyP.ToString() == class5.string_25.ToString()) && !(string_2.ToString() == class5.string_25.ToString()) && !(string_3.ToString() == class5.string_25.ToString()) && !(string_4.ToString() == class5.string_25.ToString()) && !(string_5.ToString() == class5.string_25.ToString()) && !(string_6.ToString() == class5.string_25.ToString()))
							{
								class5.method_0();
								return false;
							}
							if (class26_1 != null)
							{
								class26_1.method_0();
							}
							class26_1 = class5;
							try
							{
								byte_0 = method_10(files[l]);
							}
							catch
							{
							}
							return true;
						}
						class5.method_0();
						return false;
					}
					if (class5.string_25.Length > 0)
					{
						if (!Class7.Class8.smethod_10(class5.string_25, class5.bool_49, class5.bool_47, class5.bool_48, class5.bool_46) && !(string_0.ToString() == class5.string_25.ToString()) && !(string_1.ToString() == class5.string_25.ToString()) && !(OatXsojhyP.ToString() == class5.string_25.ToString()) && !(string_2.ToString() == class5.string_25.ToString()) && !(string_3.ToString() == class5.string_25.ToString()) && !(string_4.ToString() == class5.string_25.ToString()) && !(string_5.ToString() == class5.string_25.ToString()) && !(string_6.ToString() == class5.string_25.ToString()))
						{
							class5.method_0();
							return false;
						}
						if (class26_1 != null)
						{
							class26_1.method_0();
						}
						class26_1 = class5;
						try
						{
							byte_0 = method_10(files[l]);
						}
						catch
						{
						}
						return true;
					}
					Class7.Class18 class6 = Class7.smethod_29();
					if (class6.method_0().Count != class5.class18_0.method_0().Count)
					{
						class5.method_0();
						return false;
					}
					for (int n = 0; n < class6.method_0().Count; n++)
					{
						Class7.Class21 class7 = class6.method_0().method_0(n);
						Class7.Class21 class8 = class5.class18_0.method_0().method_0(n);
						if (class7.Nlgacufklg() == class8.Nlgacufklg())
						{
							if (!(class7.Name.Trim().ToString() != class8.Name.Trim().ToString()))
							{
								for (int num = 0; num < class7.Nlgacufklg(); num++)
								{
									if (class7.yaoaFohYuj(num).method_2() != null && class8.yaoaFohYuj(num).method_2() != null && class7.yaoaFohYuj(num).method_2().Trim()
										.ToString() != class8.yaoaFohYuj(num).method_2().Trim()
										.ToString())
									{
										class5.method_0();
										return false;
									}
								}
								continue;
							}
							class5.method_0();
							return false;
						}
						class5.method_0();
						return false;
					}
				}
				if (class26_1 != null)
				{
					class26_1.method_0();
				}
				class26_1 = class5;
				try
				{
					byte_0 = method_10(files[l]);
				}
				catch
				{
				}
				return true;
			}
			catch
			{
			}
		}
		return false;
	}

	private byte[] method_10(string string_8)
	{
		FileStream fileStream = new FileStream(string_8, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		return array;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool TerminateProcess(IntPtr intptr_0, int int_6);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	internal static extern IntPtr GetCurrentProcess();

	static Class27()
	{
		class26_0 = null;
		int_0 = 0;
		int_1 = 1;
		int_2 = 1;
		int_3 = 1;
		string_0 = "";
		string_1 = "";
		OatXsojhyP = "";
		string_2 = "";
		string_3 = "";
		string_4 = "";
		string_5 = "";
		string_6 = "";
		int_4 = int.MaxValue;
		int_5 = 0;
		string_7 = "";
		dateTime_0 = DateTime.Now;
		dateTime_1 = DateTime.Now;
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		class31_0 = null;
		byte_0 = new byte[0];
	}
}
