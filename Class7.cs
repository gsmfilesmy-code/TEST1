using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

internal sealed class Class7
{
	internal class Class8
	{
		internal static string string_0;

		internal static bool qAlUitUcmu;

		internal static bool bool_0;

		internal static bool bool_1;

		internal static bool bool_2;

		private static string string_1;

		private static string string_2;

		private static ArrayList oooUjMcoEF;

		private static ArrayList arrayList_0;

		private static bool bool_3;

		internal static string smethod_0()
		{
			return "{nohid-22222-10001-00000}";
		}

		internal static string smethod_1(bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			string string_ = Class7.smethod_5(bool_4, bool_5, bool_6, bool_7);
			byte[] array = Class7.smethod_1(string_);
			Class16.lejMwloOne();
			byte[] array2 = Class16.smethod_5(string_);
			string_ = "";
			for (int i = 0; i < array2.Length; i++)
			{
				string_ += array2[i].ToString("X2");
			}
			for (int j = 0; j < array.Length; j++)
			{
				string_ += array[j].ToString("X2");
			}
			string_ = string_.Substring(0, 20);
			return string_.Substring(0, 4) + "-" + string_.Substring(4, 4) + "-" + string_.Substring(8, 4) + "-" + string_.Substring(12, 4) + "-" + string_.Substring(16, 4);
		}

		internal static string smethod_2(bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			string string_ = Class7.smethod_6(bool_4, bool_5, bool_6, bool_7);
			byte[] array = Class7.smethod_1(string_);
			Class16.lejMwloOne();
			byte[] array2 = Class16.smethod_5(string_);
			string_ = "";
			for (int i = 0; i < array2.Length; i++)
			{
				string_ += array2[i].ToString("X2");
			}
			for (int j = 0; j < array.Length; j++)
			{
				string_ += array[j].ToString("X2");
			}
			string_ = string_.Substring(0, 20);
			return string_.Substring(0, 4) + "-" + string_.Substring(4, 4) + "-" + string_.Substring(8, 4) + "-" + string_.Substring(12, 4) + "-" + string_.Substring(16, 4);
		}

		internal static string smethod_3(bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			string string_ = Class7.smethod_7(bool_4, bool_5, bool_6, bool_7);
			byte[] array = Class7.smethod_1(string_);
			Class16.lejMwloOne();
			byte[] array2 = Class16.smethod_5(string_);
			string_ = "";
			for (int i = 0; i < array2.Length; i++)
			{
				string_ += array2[i].ToString("X2");
			}
			for (int j = 0; j < array.Length; j++)
			{
				string_ += array[j].ToString("X2");
			}
			string_ = string_.Substring(0, 20);
			return string_.Substring(0, 4) + "-" + string_.Substring(4, 4) + "-" + string_.Substring(8, 4) + "-" + string_.Substring(12, 4) + "-" + string_.Substring(16, 4);
		}

		internal static string smethod_4(bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			return Class7.smethod_9(bool_4, bool_5, bool_6, bool_7);
		}

		internal static string smethod_5(bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			return Class7.smethod_10(bool_4, bool_5, bool_6, bool_7);
		}

		internal static string smethod_6(bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			return Class7.smethod_11(bool_4, bool_5, bool_6, bool_7);
		}

		private Class8()
		{
		}

		public static string smethod_7(Color color_0)
		{
			return color_0.R.ToString("D3") + color_0.G.ToString("D3") + color_0.B.ToString("D3");
		}

		public static Color smethod_8(string string_3)
		{
			return Color.FromArgb(Convert.ToByte(string_3.Substring(0, 3)), Convert.ToByte(string_3.Substring(3, 3)), Convert.ToByte(string_3.Substring(6, 3)));
		}

		public static void smethod_9(Icon icon_0, Graphics graphics_0)
		{
			graphics_0.DrawIcon(icon_0, 0, 0);
		}

		internal static bool smethod_10(string string_3, bool bool_4, bool bool_5, bool bool_6, bool bool_7)
		{
			if (string_3 == null)
			{
				return false;
			}
			string text = string_3.ToUpper().Replace("-", "").Trim();
			if (text.Length < 16)
			{
				return false;
			}
			smethod_11();
			if (bool_4 && text.Substring(0, 4) != string_1)
			{
				return false;
			}
			if (bool_5 && !oooUjMcoEF.Contains(text.Substring(4, 4)))
			{
				return false;
			}
			if (bool_6 && text.Substring(8, 4) != string_2)
			{
				return false;
			}
			if (bool_7 && !arrayList_0.Contains(text.Substring(12, 4)))
			{
				return false;
			}
			return true;
		}

		public static void smethod_11()
		{
			if (bool_3)
			{
				return;
			}
			bool_3 = true;
			byte[] array = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_17()));
			string_1 = array[3].ToString("X2");
			string_1 += array[11].ToString("X2");
			string_1 = string_1.ToUpper();
			byte[] array2 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_22()));
			string_2 = array2[3].ToString("X2");
			string_2 += array2[11].ToString("X2");
			string_2 = string_2.ToUpper();
			try
			{
				string text = Class13.smethod_0();
				if (text != null && text.Length == 12 && text != "000000000000")
				{
					byte[] array3 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
					string text2 = array3[3].ToString("X2");
					text2 += array3[11].ToString("X2");
					text2 = text2.ToUpper();
					if (!oooUjMcoEF.Contains(text2))
					{
						oooUjMcoEF.Add(text2);
					}
				}
			}
			catch
			{
			}
			try
			{
				ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					try
					{
						if (item["MacAddress"] == null)
						{
							continue;
						}
						string text3 = item["MacAddress"].ToString().ToUpper().Replace(":", "");
						if (text3.Length == 12 && text3 != "000000000000")
						{
							byte[] array4 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text3));
							string text4 = array4[3].ToString("X2");
							text4 += array4[11].ToString("X2");
							text4 = text4.ToUpper();
							if (!oooUjMcoEF.Contains(text4))
							{
								oooUjMcoEF.Add(text4);
							}
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
			try
			{
				byte[] array5 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_16()));
				string text5 = array5[3].ToString("X2");
				text5 += array5[11].ToString("X2");
				text5 = text5.ToUpper();
				if (!arrayList_0.Contains(text5))
				{
					arrayList_0.Add(text5);
				}
				byte[] array6 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_13()));
				string text6 = array6[3].ToString("X2");
				text6 += array6[11].ToString("X2");
				text6 = text6.ToUpper();
				if (!arrayList_0.Contains(text6))
				{
					arrayList_0.Add(text6);
				}
				byte[] array7 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_14()));
				string text7 = array7[3].ToString("X2");
				text7 += array7[11].ToString("X2");
				text7 = text7.ToUpper();
				if (!arrayList_0.Contains(text7))
				{
					arrayList_0.Add(text7);
				}
				try
				{
					ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
					foreach (ManagementObject item2 in managementObjectSearcher.Get())
					{
						if (item2["DeviceID"] == null || item2["InterfaceType"] == null || !(item2["InterfaceType"].ToString() != "USB") || !(item2["InterfaceType"].ToString() != "1394"))
						{
							continue;
						}
						bool flag = true;
						if (item2["MediaType"] != null && item2["MediaType"].ToString() == "Removable Media")
						{
							flag = false;
						}
						if (!flag || item2["SerialNumber"] == null)
						{
							continue;
						}
						object obj4 = item2["SerialNumber"];
						if (obj4 == null || obj4.ToString().Trim() == string.Empty || obj4.ToString()[0] == Convert.ToChar(31))
						{
							continue;
						}
						string text8 = obj4.ToString().Trim();
						if (text8.Length > 0)
						{
							byte[] array8 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text8));
							text8 = array8[3].ToString("X2");
							text8 += array8[11].ToString("X2");
							text8 = text8.ToUpper();
							if (!arrayList_0.Contains(text8))
							{
								arrayList_0.Add(text8);
							}
						}
					}
					managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
					ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
					foreach (ManagementObject item3 in managementObjectCollection)
					{
						if (item3["SerialNumber"] == null)
						{
							continue;
						}
						object obj5 = item3["SerialNumber"];
						if (obj5 == null || obj5.ToString() == string.Empty || obj5.ToString()[0] == Convert.ToChar(31))
						{
							continue;
						}
						string text9 = obj5.ToString().Trim().Replace(" ", "");
						if (text9.Length > 0)
						{
							byte[] array9 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text9));
							text9 = array9[3].ToString("X2");
							text9 += array9[11].ToString("X2");
							text9 = text9.ToUpper();
							if (!arrayList_0.Contains(text9))
							{
								arrayList_0.Add(text9);
							}
						}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}

		public static string smethod_12()
		{
			if (string_0.Length > 0)
			{
				return string_0;
			}
			try
			{
				string string_ = Class7.smethod_5(bool_13: true, bool_14: true, bool_15: true, bool_16: false);
				byte[] array = Class7.smethod_1(string_);
				Class16.lejMwloOne();
				byte[] array2 = Class16.smethod_5(string_);
				string_ = "";
				for (int i = 0; i < array2.Length; i++)
				{
					string_ += array2[i].ToString("X2");
				}
				for (int j = 0; j < array.Length; j++)
				{
					string_ += array[j].ToString("X2");
				}
				string_ = string_.Substring(0, 20);
				string_ = string_.Substring(0, 4) + "-" + string_.Substring(4, 4) + "-" + string_.Substring(8, 4) + "-" + string_.Substring(12, 4) + "-" + string_.Substring(16, 4);
				string_0 = string_;
			}
			catch
			{
				string_0 = "3B3F-96F2-C310-5438-AC1F";
			}
			return string_0;
		}

		static Class8()
		{
			string_0 = "";
			qAlUitUcmu = true;
			bool_0 = true;
			bool_1 = true;
			bool_2 = false;
			string_1 = "";
			string_2 = "";
			oooUjMcoEF = new ArrayList();
			arrayList_0 = new ArrayList();
			bool_3 = false;
		}
	}

	internal class Class9 : RSA
	{
		private static byte[] byte_0;

		private int int_0;

		private Class10 class10_0;

		private Class10 class10_1;

		private Class10 class10_2;

		private Class10 class10_3;

		private Class10 class10_4;

		private Class10 class10_5;

		private Class10 class10_6;

		private Class10 class10_7;

		public override string KeyExchangeAlgorithm => "RSA-PKCS1-KeyEx";

		public override string SignatureAlgorithm => "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

		public override int KeySize
		{
			get
			{
				return int_0 * 8;
			}
			set
			{
				throw new ArgumentException();
			}
		}

		public Class9()
		{
			int_0 = 128;
		}

		public Class9(int int_1)
		{
			int_0 = int_1 / 8;
		}

		public override void FromXmlString(string xmlString)
		{
			StringReader input = new StringReader(xmlString);
			XmlTextReader xmlTextReader = new XmlTextReader(input);
			class10_0 = (class10_1 = (class10_2 = (class10_3 = (class10_4 = (class10_5 = (class10_6 = (class10_7 = null)))))));
			while (true)
			{
				switch (xmlTextReader.MoveToContent())
				{
				case XmlNodeType.Element:
				{
					string name = xmlTextReader.Name;
					if (!method_6(xmlTextReader, name, "Modulus", ref class10_0) && !method_6(xmlTextReader, name, "Exponent", ref class10_1) && !method_6(xmlTextReader, name, "P", ref class10_2) && !method_6(xmlTextReader, name, "Q", ref class10_3) && !method_6(xmlTextReader, name, "DP", ref class10_4) && !method_6(xmlTextReader, name, "DQ", ref class10_5) && !method_6(xmlTextReader, name, "InverseQ", ref class10_6) && !method_6(xmlTextReader, name, "D", ref class10_7))
					{
						xmlTextReader.ReadString();
					}
					break;
				}
				case XmlNodeType.EndElement:
					xmlTextReader.ReadEndElement();
					break;
				default:
					throw new ArgumentException();
				case XmlNodeType.None:
					return;
				}
			}
		}

		public override void ImportParameters(RSAParameters parameters)
		{
			class10_0 = new Class10(parameters.Modulus);
			class10_1 = new Class10(parameters.Exponent);
			class10_2 = ((!object.ReferenceEquals(parameters.P, null)) ? new Class10(parameters.P) : null);
			class10_3 = ((!object.ReferenceEquals(parameters.Q, null)) ? new Class10(parameters.Q) : null);
			class10_4 = ((!object.ReferenceEquals(parameters.DP, null)) ? new Class10(parameters.DP) : null);
			class10_5 = ((!object.ReferenceEquals(parameters.DQ, null)) ? new Class10(parameters.DQ) : null);
			class10_6 = ((!object.ReferenceEquals(parameters.InverseQ, null)) ? new Class10(parameters.InverseQ) : null);
			class10_7 = ((!object.ReferenceEquals(parameters.D, null)) ? new Class10(parameters.D) : null);
		}

		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			RSAParameters result = new RSAParameters
			{
				Modulus = class10_0.method_2(),
				Exponent = class10_1.method_2()
			};
			if (includePrivateParameters)
			{
				result.P = class10_2.method_2();
				result.Q = class10_3.method_2();
				result.DP = class10_4.method_2();
				result.DQ = class10_5.method_2();
				result.InverseQ = class10_6.method_2();
				result.D = class10_7.method_2();
			}
			return result;
		}

		public byte[] method_0(byte[] byte_1)
		{
			if (byte_1.Length != int_0)
			{
				throw new ArgumentException("input.Length does not match keylen");
			}
			if (object.ReferenceEquals(class10_0, null))
			{
				throw new ArgumentException("no key set!");
			}
			Class10 @class = new Class10(byte_1);
			if (@class >= class10_0)
			{
				throw new ArgumentException("input exceeds modulus");
			}
			@class = @class.method_7(class10_1, class10_0);
			byte[] byte_2 = @class.method_2();
			return method_5(byte_2, int_0);
		}

		public byte[] method_1(byte[] byte_1)
		{
			if (byte_1.Length != int_0)
			{
				throw new ArgumentException("input.Length does not match keylen");
			}
			if (object.ReferenceEquals(class10_7, null))
			{
				throw new ArgumentException("no private key set!");
			}
			Class10 @class = new Class10(byte_1);
			if (@class >= class10_0)
			{
				throw new ArgumentException("input exceeds modulus");
			}
			@class = @class.method_7(class10_7, class10_0);
			byte[] byte_2 = @class.method_2();
			return method_5(byte_2, int_0);
		}

		public bool method_2(byte[] byte_1, byte[] byte_2)
		{
			int num = byte_2.Length;
			if (num != int_0)
			{
				return false;
			}
			byte[] array = method_0(byte_2);
			if (array[0] == 0 && array[1] == 1)
			{
				int num2 = array.Length;
				for (int i = 2; i < num2 - 1; i++)
				{
					switch (array[i])
					{
					case byte.MaxValue:
						continue;
					case 0:
					{
						i++;
						int num3 = num2 - i;
						if (num3 == 34)
						{
							if (array[i + 13] != 5)
							{
								return false;
							}
							array[i + 13] = 0;
							if (!method_4(array, i, byte_0, 0, 18))
							{
								return false;
							}
							return method_4(array, i + 18, byte_1, 0, 16);
						}
						return false;
					}
					}
					break;
				}
				return false;
			}
			return false;
		}

		public bool method_3(byte[] byte_1, byte[] byte_2)
		{
			byte[] byte_3 = Class2.BjkXsyRir(byte_1);
			return method_2(byte_3, byte_2);
		}

		public override byte[] EncryptValue(byte[] rgb)
		{
			return method_0(rgb);
		}

		public override byte[] DecryptValue(byte[] rgb)
		{
			return method_1(rgb);
		}

		protected override void Dispose(bool disposing)
		{
			class10_0 = (class10_1 = (class10_2 = (class10_3 = (class10_4 = (class10_5 = (class10_6 = (class10_7 = null)))))));
		}

		private bool method_4(byte[] byte_1, int int_1, byte[] byte_2, int int_2, int int_3)
		{
			int num = 0;
			while (true)
			{
				if (num < int_3)
				{
					if (byte_1[num + int_1] != byte_2[num + int_2])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}

		private byte[] method_5(byte[] byte_1, int int_1)
		{
			int num = byte_1.Length;
			if (num >= int_1)
			{
				return byte_1;
			}
			byte[] array = new byte[int_1];
			int num2 = int_1 - num;
			for (int i = 0; i < num2; i++)
			{
				array[i] = 0;
			}
			Array.Copy(byte_1, 0, array, num2, num);
			return array;
		}

		private bool method_6(XmlReader xmlReader_0, string string_0, string string_1, ref Class10 class10_8)
		{
			if (string.Compare(string_0, string_1, ignoreCase: true) != 0)
			{
				return false;
			}
			string s = xmlReader_0.ReadString();
			byte[] array = Convert.FromBase64String(s);
			Class10 @class = new Class10(array);
			class10_8 = @class;
			return true;
		}

		static Class9()
		{
			byte_0 = new byte[18]
			{
				48, 32, 48, 12, 6, 8, 42, 134, 72, 134,
				247, 13, 2, 0, 5, 0, 4, 16
			};
		}
	}

	internal enum Enum1
	{

	}

	internal class Class10
	{
		internal uint uint_0 = 1u;

		internal uint[] uint_1;

		public Class10(Enum1 enum1_0, uint uint_2)
		{
			uint_1 = new uint[uint_2];
			uint_0 = uint_2;
		}

		public Class10(Class10 class10_0)
		{
			uint_1 = (uint[])class10_0.uint_1.Clone();
			uint_0 = class10_0.uint_0;
		}

		public Class10(Class10 class10_0, uint uint_2)
		{
			uint_1 = new uint[uint_2];
			for (uint num = 0u; num < class10_0.uint_0; num++)
			{
				uint_1[num] = class10_0.uint_1[num];
			}
			uint_0 = class10_0.uint_0;
		}

		public Class10(byte[] byte_0)
		{
			uint_0 = (uint)byte_0.Length >> 2;
			int num = byte_0.Length & 3;
			if (num != 0)
			{
				uint_0++;
			}
			uint_1 = new uint[uint_0];
			int num2 = byte_0.Length - 1;
			int num3 = 0;
			while (num2 >= 3)
			{
				uint_1[num3] = (uint)((byte_0[num2 - 3] << 24) | (byte_0[num2 - 2] << 16) | (byte_0[num2 - 1] << 8) | byte_0[num2]);
				num2 -= 4;
				num3++;
			}
			switch (num)
			{
			case 1:
				uint_1[uint_0 - 1] = byte_0[0];
				break;
			case 2:
				uint_1[uint_0 - 1] = (uint)((byte_0[0] << 8) | byte_0[1]);
				break;
			case 3:
				uint_1[uint_0 - 1] = (uint)((byte_0[0] << 16) | (byte_0[1] << 8) | byte_0[2]);
				break;
			}
			method_5();
		}

		public Class10(uint uint_2)
		{
			uint_1 = new uint[1] { uint_2 };
		}

		public Class10(ulong ulong_0)
		{
			uint_1 = new uint[2]
			{
				(uint)ulong_0,
				(uint)(ulong_0 >> 32)
			};
			uint_0 = 2u;
			method_5();
		}

		public static implicit operator Class10(uint uint_2)
		{
			return new Class10(uint_2);
		}

		public static implicit operator Class10(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			return new Class10((uint)int_0);
		}

		public static implicit operator Class10(ulong ulong_0)
		{
			return new Class10(ulong_0);
		}

		public static Class10 operator +(Class10 class10_0, Class10 class10_1)
		{
			if (class10_0 == 0u)
			{
				return new Class10(class10_1);
			}
			if (class10_1 == 0u)
			{
				return new Class10(class10_0);
			}
			return Class12.smethod_0(class10_0, class10_1);
		}

		public static Class10 operator -(Class10 class10_0, Class10 class10_1)
		{
			if (class10_1 == 0u)
			{
				return new Class10(class10_0);
			}
			if (class10_0 == 0u)
			{
				throw new ArithmeticException();
			}
			return Class12.smethod_4(class10_0, class10_1) switch
			{
				(Enum1)(-1) => throw new ArithmeticException(), 
				(Enum1)0 => 0, 
				(Enum1)1 => Class12.smethod_1(class10_0, class10_1), 
				_ => throw new Exception(), 
			};
		}

		public static int operator %(Class10 class10_0, int int_0)
		{
			if (int_0 > 0)
			{
				return (int)Class12.smethod_6(class10_0, (uint)int_0);
			}
			return (int)(0 - Class12.smethod_6(class10_0, (uint)(-int_0)));
		}

		public static uint operator %(Class10 class10_0, uint uint_2)
		{
			return Class12.smethod_6(class10_0, uint_2);
		}

		public static Class10 operator %(Class10 class10_0, Class10 class10_1)
		{
			return Class12.smethod_9(class10_0, class10_1)[1];
		}

		public static Class10 operator /(Class10 class10_0, int int_0)
		{
			if (int_0 <= 0)
			{
				throw new ArithmeticException();
			}
			return Class12.smethod_7(class10_0, (uint)int_0);
		}

		public static Class10 operator /(Class10 class10_0, Class10 class10_1)
		{
			return Class12.smethod_9(class10_0, class10_1)[0];
		}

		public static Class10 operator *(Class10 class10_0, Class10 class10_1)
		{
			if (!(class10_0 == 0u) && !(class10_1 == 0u))
			{
				if (class10_0.uint_1.Length < class10_0.uint_0)
				{
					throw new IndexOutOfRangeException("bi1 out of range");
				}
				if (class10_1.uint_1.Length < class10_1.uint_0)
				{
					throw new IndexOutOfRangeException("bi2 out of range");
				}
				Class10 @class = new Class10((Enum1)1, class10_0.uint_0 + class10_1.uint_0);
				Class12.smethod_13(class10_0.uint_1, 0u, class10_0.uint_0, class10_1.uint_1, 0u, class10_1.uint_0, @class.uint_1, 0u);
				@class.method_5();
				return @class;
			}
			return 0;
		}

		public static Class10 operator *(Class10 class10_0, int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArithmeticException();
			}
			return int_0 switch
			{
				0 => 0, 
				1 => new Class10(class10_0), 
				_ => Class12.smethod_12(class10_0, (uint)int_0), 
			};
		}

		public static Class10 operator <<(Class10 class10_0, int int_0)
		{
			return Class12.smethod_10(class10_0, int_0);
		}

		public static Class10 operator >>(Class10 class10_0, int int_0)
		{
			return Class12.smethod_11(class10_0, int_0);
		}

		public int method_0()
		{
			method_5();
			uint num = uint_1[uint_0 - 1];
			uint num2 = 2147483648u;
			uint num3 = 32u;
			while (num3 != 0 && (num & num2) == 0)
			{
				num3--;
				num2 >>= 1;
			}
			return (int)(num3 + (uint_0 - 1 << 5));
		}

		public bool method_1(int int_0)
		{
			if (int_0 < 0)
			{
				throw new IndexOutOfRangeException("bitNum out of range");
			}
			uint num = (uint)int_0 >> 5;
			byte b = (byte)(int_0 & 0x1F);
			uint num2 = (uint)(1 << (int)b);
			return (uint_1[num] | num2) == uint_1[num];
		}

		public byte[] method_2()
		{
			return method_3();
		}

		public byte[] method_3()
		{
			if (this == 0u)
			{
				return new byte[1];
			}
			int num = method_0();
			int num2 = num >> 3;
			if ((num & 7) != 0)
			{
				num2++;
			}
			byte[] array = new byte[num2];
			int num3 = num2 & 3;
			if (num3 == 0)
			{
				num3 = 4;
			}
			int num4 = 0;
			for (int num5 = (int)(uint_0 - 1); num5 >= 0; num5--)
			{
				uint num6 = uint_1[num5];
				for (int num7 = num3 - 1; num7 >= 0; num7--)
				{
					array[num4 + num7] = (byte)(num6 & 0xFF);
					num6 >>= 8;
				}
				num4 += num3;
				num3 = 4;
			}
			return array;
		}

		public static bool operator ==(Class10 class10_0, uint uint_2)
		{
			if (class10_0.uint_0 != 1)
			{
				class10_0.method_5();
			}
			if (class10_0.uint_0 == 1)
			{
				return class10_0.uint_1[0] == uint_2;
			}
			return false;
		}

		public static bool operator !=(Class10 class10_0, uint uint_2)
		{
			if (class10_0.uint_0 != 1)
			{
				class10_0.method_5();
			}
			if (class10_0.uint_0 == 1)
			{
				return class10_0.uint_1[0] != uint_2;
			}
			return true;
		}

		public static bool operator ==(Class10 class10_0, Class10 class10_1)
		{
			if ((object)class10_0 == class10_1)
			{
				return true;
			}
			if (!(null == class10_0) && !(null == class10_1))
			{
				return Class12.smethod_4(class10_0, class10_1) == (Enum1)0;
			}
			return false;
		}

		public static bool operator !=(Class10 class10_0, Class10 class10_1)
		{
			if ((object)class10_0 == class10_1)
			{
				return false;
			}
			if (!(null == class10_0) && !(null == class10_1))
			{
				return Class12.smethod_4(class10_0, class10_1) != (Enum1)0;
			}
			return true;
		}

		public static bool operator >(Class10 class10_0, Class10 class10_1)
		{
			return Class12.smethod_4(class10_0, class10_1) > (Enum1)0;
		}

		public static bool operator <(Class10 class10_0, Class10 class10_1)
		{
			return Class12.smethod_4(class10_0, class10_1) < (Enum1)0;
		}

		public static bool operator >=(Class10 class10_0, Class10 class10_1)
		{
			return Class12.smethod_4(class10_0, class10_1) >= (Enum1)0;
		}

		public static bool operator <=(Class10 class10_0, Class10 class10_1)
		{
			return Class12.smethod_4(class10_0, class10_1) <= (Enum1)0;
		}

		public Enum1 method_4(Class10 class10_0)
		{
			return Class12.smethod_4(this, class10_0);
		}

		internal void method_5()
		{
			while (uint_0 != 0 && uint_1[uint_0 - 1] == 0)
			{
				uint_0--;
			}
			if (uint_0 == 0)
			{
				uint_0++;
			}
		}

		public override int GetHashCode()
		{
			uint num = 0u;
			for (uint num2 = 0u; num2 < uint_0; num2++)
			{
				num ^= uint_1[num2];
			}
			return (int)num;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj is int)
			{
				if ((int)obj >= 0)
				{
					return this == (uint)obj;
				}
				return false;
			}
			Class10 @class = obj as Class10;
			if (@class == null)
			{
				return false;
			}
			return Class12.smethod_4(this, @class) == (Enum1)0;
		}

		public Class10 method_6(Class10 class10_0)
		{
			return Class12.smethod_16(this, class10_0);
		}

		public Class10 method_7(Class10 class10_0, Class10 class10_1)
		{
			Class11 @class = new Class11(class10_1);
			return @class.method_3(this, class10_0);
		}
	}

	internal sealed class Class11
	{
		private Class10 class10_0;

		private Class10 class10_1;

		public Class11(Class10 class10_2)
		{
			class10_0 = class10_2;
			uint num = class10_0.uint_0 << 1;
			class10_1 = new Class10((Enum1)1, num + 1);
			class10_1.uint_1[num] = 1u;
			class10_1 /= class10_0;
		}

		public void method_0(Class10 class10_2)
		{
			Class10 @class = class10_0;
			uint uint_ = @class.uint_0;
			uint num = uint_ + 1;
			uint num2 = uint_ - 1;
			if (class10_2.uint_0 >= uint_)
			{
				if (class10_2.uint_1.Length < class10_2.uint_0)
				{
					throw new IndexOutOfRangeException("x out of range");
				}
				Class10 class2 = new Class10((Enum1)1, class10_2.uint_0 - num2 + class10_1.uint_0);
				Class12.smethod_13(class10_2.uint_1, num2, class10_2.uint_0 - num2, class10_1.uint_1, 0u, class10_1.uint_0, class2.uint_1, 0u);
				uint uint_2 = ((class10_2.uint_0 > num) ? num : class10_2.uint_0);
				class10_2.uint_0 = uint_2;
				class10_2.method_5();
				Class10 class3 = new Class10((Enum1)1, num);
				Class12.smethod_14(class2.uint_1, (int)num, (int)(class2.uint_0 - num), @class.uint_1, 0, (int)@class.uint_0, class3.uint_1, 0, (int)num);
				class3.method_5();
				if (class3 <= class10_2)
				{
					Class12.smethod_2(class10_2, class3);
				}
				else
				{
					Class10 class4 = new Class10((Enum1)1, num + 1);
					class4.uint_1[num] = 1u;
					Class12.smethod_2(class4, class3);
					Class12.smethod_3(class10_2, class4);
				}
				while (class10_2 >= @class)
				{
					Class12.smethod_2(class10_2, @class);
				}
			}
		}

		public Class10 method_1(Class10 class10_2, Class10 class10_3)
		{
			if (!(class10_2 == 0u) && !(class10_3 == 0u))
			{
				if (class10_2 > class10_0)
				{
					class10_2 %= class10_0;
				}
				if (class10_3 > class10_0)
				{
					class10_3 %= class10_0;
				}
				Class10 @class = class10_2 * class10_3;
				method_0(@class);
				return @class;
			}
			return 0;
		}

		public Class10 method_2(Class10 class10_2, Class10 class10_3)
		{
			Enum1 @enum = Class12.smethod_4(class10_2, class10_3);
			Class10 @class;
			switch (@enum)
			{
			default:
				throw new Exception();
			case (Enum1)(-1):
				@class = class10_3 - class10_2;
				break;
			case (Enum1)0:
				return 0;
			case (Enum1)1:
				@class = class10_2 - class10_3;
				break;
			}
			if (@class >= class10_0)
			{
				if (@class.uint_0 >= class10_0.uint_0 << 1)
				{
					@class %= class10_0;
				}
				else
				{
					method_0(@class);
				}
			}
			if (@enum == (Enum1)(-1))
			{
				@class = class10_0 - @class;
			}
			return @class;
		}

		public Class10 method_3(Class10 class10_2, Class10 class10_3)
		{
			Class10 @class = new Class10(1u);
			if (class10_3 == 0u)
			{
				return @class;
			}
			Class10 class2 = class10_2;
			if (class10_3.method_1(0))
			{
				@class = class10_2;
			}
			for (int i = 1; i < class10_3.method_0(); i++)
			{
				class2 = method_1(class2, class2);
				if (class10_3.method_1(i))
				{
					@class = method_1(class2, @class);
				}
			}
			return @class;
		}

		public Class10 method_4(uint uint_0, Class10 class10_2)
		{
			return method_3(new Class10(uint_0), class10_2);
		}
	}

	private sealed class Class12
	{
		public static Class10 smethod_0(Class10 class10_0, Class10 class10_1)
		{
			uint num = 0u;
			uint[] uint_;
			uint uint_2;
			uint[] uint_3;
			uint uint_4;
			if (class10_0.uint_0 < class10_1.uint_0)
			{
				uint_ = class10_1.uint_1;
				uint_2 = class10_1.uint_0;
				uint_3 = class10_0.uint_1;
				uint_4 = class10_0.uint_0;
			}
			else
			{
				uint_ = class10_0.uint_1;
				uint_2 = class10_0.uint_0;
				uint_3 = class10_1.uint_1;
				uint_4 = class10_1.uint_0;
			}
			Class10 @class = new Class10((Enum1)1, uint_2 + 1);
			uint[] uint_5 = @class.uint_1;
			ulong num2 = 0uL;
			do
			{
				num2 = (ulong)((long)uint_[num] + (long)uint_3[num]) + num2;
				uint_5[num] = (uint)num2;
				num2 >>= 32;
			}
			while (++num < uint_4);
			bool flag;
			if (flag = num2 != 0L)
			{
				if (num < uint_2)
				{
					do
					{
						flag = (uint_5[num] = uint_[num] + 1) == 0;
					}
					while (++num < uint_2 && flag);
				}
				if (flag)
				{
					uint_5[num] = 1u;
					num = (@class.uint_0 = num + 1);
					return @class;
				}
			}
			if (num < uint_2)
			{
				do
				{
					uint_5[num] = uint_[num];
				}
				while (++num < uint_2);
			}
			@class.method_5();
			return @class;
		}

		public static Class10 smethod_1(Class10 class10_0, Class10 class10_1)
		{
			Class10 @class = new Class10((Enum1)1, class10_0.uint_0);
			uint[] uint_ = @class.uint_1;
			uint[] uint_2 = class10_0.uint_1;
			uint[] uint_3 = class10_1.uint_1;
			uint num = 0u;
			uint num2 = 0u;
			do
			{
				uint num3 = uint_3[num];
				num2 = ((((num3 += num2) < num2) | ((uint_[num] = uint_2[num] - num3) > ~num3)) ? 1u : 0u);
			}
			while (++num < class10_1.uint_0);
			if (num != class10_0.uint_0)
			{
				if (num2 == 1)
				{
					do
					{
						uint_[num] = uint_2[num] - 1;
					}
					while (uint_2[num++] == 0 && num < class10_0.uint_0);
					if (num == class10_0.uint_0)
					{
						goto IL_00c8;
					}
				}
				do
				{
					uint_[num] = uint_2[num];
				}
				while (++num < class10_0.uint_0);
			}
			goto IL_00c8;
			IL_00c8:
			@class.method_5();
			return @class;
		}

		public static void smethod_2(Class10 class10_0, Class10 class10_1)
		{
			uint[] uint_ = class10_0.uint_1;
			uint[] uint_2 = class10_1.uint_1;
			uint num = 0u;
			uint num2 = 0u;
			do
			{
				uint num3 = uint_2[num];
				num2 = ((((num3 += num2) < num2) | ((uint_[num] -= num3) > ~num3)) ? 1u : 0u);
			}
			while (++num < class10_1.uint_0);
			if (num != class10_0.uint_0 && num2 == 1)
			{
				do
				{
					uint_[num]--;
				}
				while (uint_[num++] == 0 && num < class10_0.uint_0);
			}
			while (class10_0.uint_0 != 0 && class10_0.uint_1[class10_0.uint_0 - 1] == 0)
			{
				class10_0.uint_0--;
			}
			if (class10_0.uint_0 == 0)
			{
				class10_0.uint_0++;
			}
		}

		public static void smethod_3(Class10 class10_0, Class10 class10_1)
		{
			uint num = 0u;
			bool flag = false;
			uint[] uint_;
			uint uint_2;
			uint[] uint_3;
			uint uint_4;
			if (class10_0.uint_0 < class10_1.uint_0)
			{
				flag = true;
				uint_ = class10_1.uint_1;
				uint_2 = class10_1.uint_0;
				uint_3 = class10_0.uint_1;
				uint_4 = class10_0.uint_0;
			}
			else
			{
				uint_ = class10_0.uint_1;
				uint_2 = class10_0.uint_0;
				uint_3 = class10_1.uint_1;
				uint_4 = class10_1.uint_0;
			}
			uint[] uint_5 = class10_0.uint_1;
			ulong num2 = 0uL;
			do
			{
				num2 += (ulong)((long)uint_[num] + (long)uint_3[num]);
				uint_5[num] = (uint)num2;
				num2 >>= 32;
			}
			while (++num < uint_4);
			bool flag2;
			if (flag2 = num2 != 0L)
			{
				if (num < uint_2)
				{
					do
					{
						flag2 = (uint_5[num] = uint_[num] + 1) == 0;
					}
					while (++num < uint_2 && flag2);
				}
				if (flag2)
				{
					uint_5[num] = 1u;
					num = (class10_0.uint_0 = num + 1);
					return;
				}
			}
			if (flag && num < uint_2 - 1)
			{
				do
				{
					uint_5[num] = uint_[num];
				}
				while (++num < uint_2);
			}
			class10_0.uint_0 = uint_2 + 1;
			class10_0.method_5();
		}

		public static Enum1 smethod_4(Class10 class10_0, Class10 class10_1)
		{
			uint num = class10_0.uint_0;
			uint num2 = class10_1.uint_0;
			while (num != 0 && class10_0.uint_1[num - 1] == 0)
			{
				num--;
			}
			while (num2 != 0 && class10_1.uint_1[num2 - 1] == 0)
			{
				num2--;
			}
			if (num == 0 && num2 == 0)
			{
				return (Enum1)0;
			}
			if (num < num2)
			{
				return (Enum1)(-1);
			}
			if (num > num2)
			{
				return (Enum1)1;
			}
			uint num3 = num - 1;
			while (num3 != 0 && class10_0.uint_1[num3] == class10_1.uint_1[num3])
			{
				num3--;
			}
			if (class10_0.uint_1[num3] < class10_1.uint_1[num3])
			{
				return (Enum1)(-1);
			}
			if (class10_0.uint_1[num3] > class10_1.uint_1[num3])
			{
				return (Enum1)1;
			}
			return (Enum1)0;
		}

		public static uint smethod_5(Class10 class10_0, uint uint_0)
		{
			ulong num = 0uL;
			uint uint_1 = class10_0.uint_0;
			while (uint_1-- != 0)
			{
				num <<= 32;
				num |= class10_0.uint_1[uint_1];
				class10_0.uint_1[uint_1] = (uint)(num / uint_0);
				num %= uint_0;
			}
			class10_0.method_5();
			return (uint)num;
		}

		public static uint smethod_6(Class10 class10_0, uint uint_0)
		{
			ulong num = 0uL;
			uint uint_1 = class10_0.uint_0;
			while (uint_1-- != 0)
			{
				num <<= 32;
				num |= class10_0.uint_1[uint_1];
				num %= uint_0;
			}
			return (uint)num;
		}

		public static Class10 smethod_7(Class10 class10_0, uint uint_0)
		{
			Class10 @class = new Class10((Enum1)1, class10_0.uint_0);
			ulong num = 0uL;
			uint uint_1 = class10_0.uint_0;
			while (uint_1-- != 0)
			{
				num <<= 32;
				num |= class10_0.uint_1[uint_1];
				@class.uint_1[uint_1] = (uint)(num / uint_0);
				num %= uint_0;
			}
			@class.method_5();
			return @class;
		}

		public static Class10[] smethod_8(Class10 class10_0, uint uint_0)
		{
			Class10 @class = new Class10((Enum1)1, class10_0.uint_0);
			ulong num = 0uL;
			uint uint_1 = class10_0.uint_0;
			while (uint_1-- != 0)
			{
				num <<= 32;
				num |= class10_0.uint_1[uint_1];
				@class.uint_1[uint_1] = (uint)(num / uint_0);
				num %= uint_0;
			}
			@class.method_5();
			Class10 class2 = (uint)num;
			return new Class10[2] { @class, class2 };
		}

		public static Class10[] smethod_9(Class10 class10_0, Class10 class10_1)
		{
			if (smethod_4(class10_0, class10_1) == (Enum1)(-1))
			{
				return new Class10[2]
				{
					0,
					new Class10(class10_0)
				};
			}
			class10_0.method_5();
			class10_1.method_5();
			if (class10_1.uint_0 == 1)
			{
				return smethod_8(class10_0, class10_1.uint_1[0]);
			}
			uint num = class10_0.uint_0 + 1;
			int num2 = (int)(class10_1.uint_0 + 1);
			uint num3 = 2147483648u;
			uint num4 = class10_1.uint_1[class10_1.uint_0 - 1];
			int num5 = 0;
			int num6 = (int)(class10_0.uint_0 - class10_1.uint_0);
			while (num3 != 0 && (num4 & num3) == 0)
			{
				num5++;
				num3 >>= 1;
			}
			Class10 @class = new Class10((Enum1)1, class10_0.uint_0 - class10_1.uint_0 + 1);
			Class10 class2 = class10_0 << num5;
			uint[] uint_ = class2.uint_1;
			class10_1 <<= num5;
			int num7 = (int)(num - class10_1.uint_0);
			int num8 = (int)(num - 1);
			uint num9 = class10_1.uint_1[class10_1.uint_0 - 1];
			ulong num10 = class10_1.uint_1[class10_1.uint_0 - 2];
			while (num7 > 0)
			{
				ulong num11 = ((ulong)uint_[num8] << 32) + uint_[num8 - 1];
				ulong num12 = num11 / num9;
				ulong num13 = num11 % num9;
				while (num12 == 4294967296L || num12 * num10 > (num13 << 32) + uint_[num8 - 2])
				{
					num12--;
					num13 += num9;
					if (num13 >= 4294967296L)
					{
						break;
					}
				}
				uint num14 = 0u;
				int num15 = num8 - num2 + 1;
				ulong num16 = 0uL;
				uint num17 = (uint)num12;
				do
				{
					num16 += (ulong)((long)class10_1.uint_1[num14] * (long)num17);
					uint num18 = uint_[num15];
					uint_[num15] -= (uint)(int)num16;
					num16 >>= 32;
					if (uint_[num15] > num18)
					{
						num16++;
					}
					num14++;
					num15++;
				}
				while (num14 < num2);
				num15 = num8 - num2 + 1;
				num14 = 0u;
				if (num16 != 0L)
				{
					num17--;
					ulong num19 = 0uL;
					do
					{
						num19 = (ulong)((long)uint_[num15] + (long)class10_1.uint_1[num14]) + num19;
						uint_[num15] = (uint)num19;
						num19 >>= 32;
						num14++;
						num15++;
					}
					while (num14 < num2);
				}
				@class.uint_1[num6--] = num17;
				num8--;
				num7--;
			}
			@class.method_5();
			class2.method_5();
			Class10[] array = new Class10[2] { @class, class2 };
			if (num5 != 0)
			{
				Class10[] array2;
				(array2 = array)[1] = array2[1] >> num5;
			}
			return array;
		}

		public static Class10 smethod_10(Class10 class10_0, int int_0)
		{
			if (int_0 == 0)
			{
				return new Class10(class10_0, class10_0.uint_0 + 1);
			}
			int num = int_0 >> 5;
			int_0 &= 0x1F;
			Class10 @class = new Class10((Enum1)1, class10_0.uint_0 + 1 + (uint)num);
			uint num2 = 0u;
			uint uint_ = class10_0.uint_0;
			if (int_0 != 0)
			{
				uint num3 = 0u;
				for (; num2 < uint_; num2++)
				{
					uint num4 = class10_0.uint_1[num2];
					@class.uint_1[num2 + num] = (num4 << int_0) | num3;
					num3 = num4 >> 32 - int_0;
				}
				@class.uint_1[num2 + num] = num3;
			}
			else
			{
				for (; num2 < uint_; num2++)
				{
					@class.uint_1[num2 + num] = class10_0.uint_1[num2];
				}
			}
			@class.method_5();
			return @class;
		}

		public static Class10 smethod_11(Class10 class10_0, int int_0)
		{
			if (int_0 == 0)
			{
				return new Class10(class10_0);
			}
			int num = int_0 >> 5;
			int num2 = int_0 & 0x1F;
			Class10 @class = new Class10((Enum1)1, (uint)((int)class10_0.uint_0 - num + 1));
			uint num3 = (uint)(@class.uint_1.Length - 1);
			if (num2 != 0)
			{
				uint num4 = 0u;
				while (num3-- != 0)
				{
					uint num5 = class10_0.uint_1[num3 + num];
					@class.uint_1[num3] = (num5 >> int_0) | num4;
					num4 = num5 << 32 - int_0;
				}
			}
			else
			{
				while (num3-- != 0)
				{
					@class.uint_1[num3] = class10_0.uint_1[num3 + num];
				}
			}
			@class.method_5();
			return @class;
		}

		public static Class10 smethod_12(Class10 class10_0, uint uint_0)
		{
			Class10 @class = new Class10((Enum1)1, class10_0.uint_0 + 1);
			uint num = 0u;
			ulong num2 = 0uL;
			do
			{
				num2 += (ulong)((long)class10_0.uint_1[num] * (long)uint_0);
				@class.uint_1[num] = (uint)num2;
				num2 >>= 32;
			}
			while (++num < class10_0.uint_0);
			@class.uint_1[num] = (uint)num2;
			@class.method_5();
			return @class;
		}

		public unsafe static void smethod_13(uint[] uint_0, uint uint_1, uint uint_2, uint[] uint_3, uint uint_4, uint uint_5, uint[] uint_6, uint uint_7)
		{
			fixed (uint* ptr = uint_0)
			{
				fixed (uint* ptr2 = uint_3)
				{
					fixed (uint* ptr3 = uint_6)
					{
						uint* ptr4 = ptr + uint_1;
						uint* ptr5 = ptr4 + uint_2;
						uint* ptr6 = ptr2 + uint_4;
						uint* ptr7 = ptr6 + uint_5;
						uint* ptr8 = ptr3 + uint_7;
						while (ptr4 < ptr5)
						{
							if (*ptr4 != 0)
							{
								ulong num = 0uL;
								uint* ptr9 = ptr8;
								uint* ptr10 = ptr6;
								while (ptr10 < ptr7)
								{
									num += (ulong)((long)(*ptr4) * (long)(*ptr10) + *ptr9);
									*ptr9 = (uint)num;
									num >>= 32;
									ptr10++;
									ptr9++;
								}
								if (num != 0L)
								{
									*ptr9 = (uint)num;
								}
							}
							ptr4++;
							ptr8++;
						}
					}
				}
			}
		}

		public unsafe static void smethod_14(uint[] uint_0, int int_0, int int_1, uint[] uint_1, int int_2, int int_3, uint[] uint_2, int int_4, int int_5)
		{
			fixed (uint* ptr = uint_0)
			{
				fixed (uint* ptr2 = uint_1)
				{
					fixed (uint* ptr3 = uint_2)
					{
						uint* ptr4 = ptr + int_0;
						uint* ptr5 = ptr4 + int_1;
						uint* ptr6 = ptr2 + int_2;
						uint* ptr7 = ptr6 + int_3;
						uint* ptr8 = ptr3 + int_4;
						uint* ptr9 = ptr8 + int_5;
						while (ptr4 < ptr5)
						{
							if (*ptr4 != 0)
							{
								ulong num = 0uL;
								uint* ptr10 = ptr8;
								uint* ptr11 = ptr6;
								while (ptr11 < ptr7 && ptr10 < ptr9)
								{
									num += (ulong)((long)(*ptr4) * (long)(*ptr11) + *ptr10);
									*ptr10 = (uint)num;
									num >>= 32;
									ptr11++;
									ptr10++;
								}
								if (num != 0L && ptr10 < ptr9)
								{
									*ptr10 = (uint)num;
								}
							}
							ptr4++;
							ptr8++;
						}
					}
				}
			}
		}

		public unsafe static void smethod_15(Class10 class10_0, ref uint[] uint_0)
		{
			uint[] array = uint_0;
			uint_0 = class10_0.uint_1;
			uint[] uint_1 = class10_0.uint_1;
			uint uint_2 = class10_0.uint_0;
			class10_0.uint_1 = array;
			fixed (uint* ptr = uint_1)
			{
				fixed (uint* ptr2 = array)
				{
					uint* ptr3 = ptr2 + array.Length;
					for (uint* ptr4 = ptr2; ptr4 < ptr3; ptr4++)
					{
						*ptr4 = 0u;
					}
					uint* ptr5 = ptr;
					uint* ptr6 = ptr2;
					uint num = 0u;
					while (num < uint_2)
					{
						if (*ptr5 != 0)
						{
							ulong num2 = 0uL;
							uint num3 = *ptr5;
							uint* ptr7 = ptr5 + 1;
							uint* ptr8 = ptr6 + 2 * num + 1;
							uint num4 = num + 1;
							while (num4 < uint_2)
							{
								num2 += (ulong)((long)num3 * (long)(*ptr7) + *ptr8);
								*ptr8 = (uint)num2;
								num2 >>= 32;
								num4++;
								ptr8++;
								ptr7++;
							}
							if (num2 != 0L)
							{
								*ptr8 = (uint)num2;
							}
						}
						num++;
						ptr5++;
					}
					ptr6 = ptr2;
					uint num5 = 0u;
					for (; ptr6 < ptr3; ptr6++)
					{
						uint num6 = *ptr6;
						*ptr6 = (num6 << 1) | num5;
						num5 = num6 >> 31;
					}
					if (num5 != 0)
					{
						*ptr6 = num5;
					}
					ptr5 = ptr;
					ptr6 = ptr2;
					uint* ptr9 = ptr5 + uint_2;
					while (ptr5 < ptr9)
					{
						ulong num7 = (ulong)((long)(*ptr5) * (long)(*ptr5) + *ptr6);
						*ptr6 = (uint)num7;
						num7 >>= 32;
						*(++ptr6) += (uint)(int)num7;
						if (*ptr6 < (uint)num7)
						{
							uint* ptr10 = ptr6;
							(*(++ptr10))++;
							while (*(ptr10++) == 0)
							{
								(*ptr10)++;
							}
						}
						ptr5++;
						ptr6++;
					}
					class10_0.uint_0 <<= 1;
					while (ptr2[class10_0.uint_0 - 1] == 0 && class10_0.uint_0 > 1)
					{
						class10_0.uint_0--;
					}
				}
			}
		}

		public static Class10 smethod_16(Class10 class10_0, Class10 class10_1)
		{
			Class10 @class = class10_0;
			Class10 class2 = class10_1;
			Class10 class3 = class2;
			while (@class.uint_0 > 1)
			{
				class3 = @class;
				@class = class2 % @class;
				class2 = class3;
			}
			if (@class == 0u)
			{
				return class3;
			}
			uint num = @class.uint_1[0];
			uint num2 = class2 % num;
			int num3 = 0;
			while (((num2 | num) & 1) == 0)
			{
				num2 >>= 1;
				num >>= 1;
				num3++;
			}
			while (num2 != 0)
			{
				while ((num2 & 1) == 0)
				{
					num2 >>= 1;
				}
				while ((num & 1) == 0)
				{
					num >>= 1;
				}
				if (num2 >= num)
				{
					num2 = num2 - num >> 1;
				}
				else
				{
					num = num - num2 >> 1;
				}
			}
			return num << num3;
		}

		public static uint smethod_17(Class10 class10_0, uint uint_0)
		{
			uint num = uint_0;
			uint num2 = class10_0 % uint_0;
			uint num3 = 0u;
			uint num4 = 1u;
			while (true)
			{
				switch (num2)
				{
				default:
					num3 += num / num2 * num4;
					num %= num2;
					switch (num)
					{
					default:
						goto IL_002b;
					case 1u:
						return uint_0 - num3;
					case 0u:
						break;
					}
					break;
				case 1u:
					return num4;
				case 0u:
					break;
				}
				break;
				IL_002b:
				num4 += num2 / num * num3;
				num2 %= num;
			}
			return 0u;
		}

		public static Class10 smethod_18(Class10 class10_0, Class10 class10_1)
		{
			if (class10_1.uint_0 == 1)
			{
				return smethod_17(class10_0, class10_1.uint_1[0]);
			}
			Class10[] array = new Class10[2] { 0, 1 };
			Class10[] array2 = new Class10[2];
			Class10[] array3 = new Class10[2] { 0, 0 };
			int num = 0;
			Class10 class10_2 = class10_1;
			Class10 @class = class10_0;
			Class11 class2 = new Class11(class10_1);
			while (@class != 0u)
			{
				if (num > 1)
				{
					Class10 class3 = class2.method_2(array[0], array[1] * array2[0]);
					array[0] = array[1];
					array[1] = class3;
				}
				Class10[] array4 = smethod_9(class10_2, @class);
				array2[0] = array2[1];
				array2[1] = array4[0];
				array3[0] = array3[1];
				array3[1] = array4[1];
				class10_2 = @class;
				@class = array4[1];
				num++;
			}
			if (array3[0] != 1u)
			{
				throw new ArithmeticException("No inverse!");
			}
			return class2.method_2(array[0], array[1] * array2[0]);
		}
	}

	internal struct Struct20
	{
		public IntPtr intptr_0;

		public int int_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string string_1;

		public uint mHlejvpkxD;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_0;

		public int int_1;

		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_1;

		public Struct21 struct21_0;

		public Struct21 struct21_1;

		public Struct21 struct21_2;

		public bool bool_0;

		public Struct21 struct21_3;

		public Struct21 struct21_4;

		public int int_2;

		public int int_3;
	}

	internal struct Struct21
	{
		public IntPtr intptr_0;

		public Struct22 struct22_0;

		public Struct22 struct22_1;

		public int int_0;
	}

	internal struct Struct22
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
		public string string_0;
	}

	internal class Class13
	{
		[DllImport("iphlpapi.dll", CharSet = CharSet.Ansi)]
		public static extern int GetAdaptersInfo(IntPtr intptr_0, ref long long_0);

		internal static string smethod_0()
		{
			string text = string.Empty;
			try
			{
				long long_ = Marshal.SizeOf(typeof(Struct20));
				IntPtr intPtr = Marshal.AllocHGlobal(new IntPtr(long_));
				int adaptersInfo = GetAdaptersInfo(intPtr, ref long_);
				if (adaptersInfo == 111)
				{
					intPtr = Marshal.ReAllocHGlobal(intPtr, new IntPtr(long_));
					adaptersInfo = GetAdaptersInfo(intPtr, ref long_);
				}
				if (adaptersInfo == 0)
				{
					IntPtr ptr = intPtr;
					Struct20 @struct = (Struct20)Marshal.PtrToStructure(ptr, typeof(Struct20));
					for (int i = 0; i < @struct.mHlejvpkxD; i++)
					{
						text += @struct.byte_0[i].ToString("X2");
					}
					Marshal.FreeHGlobal(intPtr);
				}
				else
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			catch
			{
			}
			if (text == string.Empty)
			{
				text = "";
			}
			return text;
		}

		internal static string[] smethod_1()
		{
			List<string> list = new List<string>();
			string empty = string.Empty;
			try
			{
				long long_ = Marshal.SizeOf(typeof(Struct20));
				IntPtr intPtr = Marshal.AllocHGlobal(new IntPtr(long_));
				int adaptersInfo = GetAdaptersInfo(intPtr, ref long_);
				if (adaptersInfo == 111)
				{
					intPtr = Marshal.ReAllocHGlobal(intPtr, new IntPtr(long_));
					adaptersInfo = GetAdaptersInfo(intPtr, ref long_);
				}
				if (adaptersInfo == 0)
				{
					IntPtr intPtr2 = intPtr;
					do
					{
						empty = string.Empty;
						Struct20 @struct = (Struct20)Marshal.PtrToStructure(intPtr2, typeof(Struct20));
						for (int i = 0; i < @struct.mHlejvpkxD; i++)
						{
							empty += @struct.byte_0[i].ToString("X2");
						}
						list.Add(empty);
						intPtr2 = @struct.intptr_0;
					}
					while (intPtr2 != IntPtr.Zero);
					Marshal.FreeHGlobal(intPtr);
				}
				else
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			catch
			{
			}
			return list.ToArray();
		}
	}

	private struct Struct23
	{
		public uint uint_0;

		public uint uint_1;

		public char char_0;

		public char char_1;

		public byte byte_0;

		public byte byte_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public Enum4 enum4_0;

		public uint uint_6;

		public IntPtr intptr_0;
	}

	private struct Struct24
	{
		public Enum2 enum2_0;

		public Enum3 enum3_0;

		public IntPtr intptr_0;
	}

	private enum Enum2
	{

	}

	private enum Enum3
	{

	}

	private enum Enum4
	{

	}

	internal class Class14
	{
		internal static string smethod_0()
		{
			try
			{
				int num = 0;
				int num2 = 16;
				for (num = 0; num < num2; num++)
				{
					string string_ = "\\\\.\\PHYSICALDRIVE" + num;
					IntPtr intPtr = ((Environment.OSVersion.Platform != PlatformID.Win32NT) ? CreateFile("\\\\.\\Smartvsd", 0u, 0, IntPtr.Zero, 1, 0, IntPtr.Zero) : CreateFile(string_, 0u, 3, IntPtr.Zero, 3, 0, IntPtr.Zero));
					if ((int)intPtr != -1)
					{
						Struct24 @struct = new Struct24
						{
							enum2_0 = (Enum2)0,
							enum3_0 = (Enum3)0
						};
						uint num3 = (uint)Marshal.SizeOf(typeof(Struct24));
						IntPtr intPtr2 = Marshal.AllocHGlobal((int)num3);
						Marshal.StructureToPtr((object)@struct, intPtr2, fDeleteOld: true);
						IntPtr intPtr3 = Marshal.AllocHGlobal(1024);
						uint uint_ = 0u;
						if (DeviceIoControl(intPtr, 2954240u, intPtr2, num3, intPtr3, 1024u, ref uint_, IntPtr.Zero))
						{
							Struct23 struct2 = (Struct23)Marshal.PtrToStructure(intPtr3, typeof(Struct23));
							long num4 = intPtr3.ToInt64();
							string text = string.Empty;
							if (struct2.uint_5 != 0)
							{
								text = Marshal.PtrToStringAnsi((IntPtr)(num4 + struct2.uint_5));
							}
							if (text != null && text.Length > 0)
							{
								Marshal.FreeHGlobal(intPtr3);
								Marshal.FreeHGlobal(intPtr2);
								CloseHandle(intPtr);
								return text;
							}
						}
						Marshal.FreeHGlobal(intPtr3);
						Marshal.FreeHGlobal(intPtr2);
					}
					CloseHandle(intPtr);
				}
			}
			catch
			{
			}
			return "failure";
		}

		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateFile(string string_0, uint uint_0, int int_0, IntPtr intptr_0, int int_1, int int_2, IntPtr intptr_1);

		[DllImport("kernel32.dll")]
		private static extern bool CloseHandle(IntPtr intptr_0);

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool DeviceIoControl(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1, [Out] IntPtr intptr_2, uint uint_2, ref uint uint_3, IntPtr intptr_3);
	}

	internal sealed class Class15
	{
		private Class9 class9_0;

		private byte[] byte_0 = new byte[0];

		private string string_0 = "";

		private bool bool_0;

		public Class15()
		{
			try
			{
				RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
				byte_0 = new byte[32];
				rNGCryptoServiceProvider.GetBytes(byte_0);
				class9_0 = new Class9();
				bool_0 = false;
			}
			catch
			{
			}
		}

		internal void method_0(string string_1)
		{
			try
			{
				Stream stream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
				BinaryReader binaryReader = new BinaryReader(stream);
				bool flag = false;
				if (binaryReader.BaseStream.Length == 32L)
				{
					method_5(new byte[binaryReader.BaseStream.Length]);
					method_5(binaryReader.ReadBytes((int)binaryReader.BaseStream.Length));
					flag = true;
					bool_0 = true;
				}
				binaryReader.Close();
				stream.Close();
				if (flag)
				{
					return;
				}
				bool_0 = false;
				using StreamReader streamReader = new StreamReader(string_1);
				string text = streamReader.ReadLine();
				string[] array = text.Split('|');
				byte_0 = Convert.FromBase64String(array[0]);
				string_0 = array[1];
				class9_0 = new Class9();
				method_8().FromXmlString(string_0);
				if (string_0.Length != method_8().ToXmlString(includePrivateParameters: false).Length)
				{
					string_0 = method_8().ToXmlString(includePrivateParameters: true);
				}
			}
			catch
			{
			}
		}

		internal void method_1(string string_1)
		{
			try
			{
				string_1 = string_1.Trim();
				try
				{
					if (!(string_1 == string.Empty) && string_1.Length != 0)
					{
						if (string_1.Length == 32)
						{
							byte_0 = new byte[32];
							for (int i = 0; i < 32; i++)
							{
								byte_0[i] = (byte)string_1.ToCharArray()[i];
							}
							return;
						}
						if (string_1.Length == 96)
						{
							byte_0 = new byte[32];
							for (int j = 0; j < 32; j++)
							{
								byte_0[j] = Convert.ToByte(string_1.Substring(j * 3, 3));
							}
							bool_0 = true;
							return;
						}
						bool_0 = false;
						string text = string_1;
						string[] array = text.Split('|');
						byte_0 = Convert.FromBase64String(array[0]);
						string_0 = array[1];
						class9_0 = new Class9();
						method_8().FromXmlString(string_0);
						if (string_0.Length != method_8().ToXmlString(includePrivateParameters: false).Length)
						{
							string_0 = method_8().ToXmlString(includePrivateParameters: true);
						}
					}
					else
					{
						RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
						byte_0 = new byte[32];
						rNGCryptoServiceProvider.GetBytes(byte_0);
						class9_0 = new Class9();
						bool_0 = false;
					}
				}
				catch
				{
					RNGCryptoServiceProvider rNGCryptoServiceProvider2 = new RNGCryptoServiceProvider();
					byte_0 = new byte[32];
					rNGCryptoServiceProvider2.GetBytes(byte_0);
					class9_0 = new Class9();
					method_8().FromXmlString(string_0);
					bool_0 = false;
				}
			}
			catch
			{
			}
		}

		internal void method_2(string string_1)
		{
			try
			{
				using StreamWriter streamWriter = new StreamWriter(string_1);
				streamWriter.Write(Convert.ToBase64String(byte_0) + "|" + string_0);
			}
			catch
			{
			}
		}

		public override string ToString()
		{
			return Convert.ToBase64String(byte_0) + "|" + string_0;
		}

		public string method_3()
		{
			try
			{
				return Convert.ToBase64String(byte_0) + "|" + method_8().ToXmlString(includePrivateParameters: false);
			}
			catch
			{
				return Convert.ToBase64String(byte_0);
			}
		}

		[SpecialName]
		public byte[] method_4()
		{
			return byte_0;
		}

		[SpecialName]
		public void method_5(byte[] byte_1)
		{
			byte_0 = byte_1;
		}

		[SpecialName]
		public bool method_6()
		{
			return bool_0;
		}

		[SpecialName]
		public void method_7(bool bool_1)
		{
			bool_0 = bool_1;
		}

		private static byte[] smethod_0(string string_1)
		{
			try
			{
				byte[] array = null;
				FileStream fileStream = File.Open(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
				try
				{
					array = new byte[fileStream.Length];
					fileStream.Read(array, 0, array.Length);
				}
				finally
				{
					fileStream.Close();
				}
				return array;
			}
			catch
			{
				return new byte[0];
			}
		}

		public Class15(Class9 class9_1)
		{
			try
			{
				if (class9_1 == null)
				{
					throw new ArgumentNullException("rsa");
				}
				method_9(class9_1);
				bool_0 = false;
			}
			catch
			{
			}
		}

		[SpecialName]
		public Class9 method_8()
		{
			try
			{
				if (class9_0 == null)
				{
					class9_0 = new Class9();
				}
			}
			catch
			{
			}
			return class9_0;
		}

		[SpecialName]
		public void method_9(Class9 class9_1)
		{
			class9_0 = class9_1;
		}

		internal static bool smethod_1(Class9 class9_1, byte[] byte_1, byte[] byte_2)
		{
			try
			{
				return class9_1.method_3(byte_1, byte_2);
			}
			catch
			{
				return false;
			}
		}
	}

	internal sealed class Class16
	{
		private static uint[] uint_0;

		private static uint uint_1;

		private static bool bool_0;

		[CLSCompliant(false)]
		public static uint OkfMxDSIMe => uint_1;

		private Class16()
		{
		}

		static Class16()
		{
			uint_0 = new uint[256];
			uint_1 = 3988292384u;
		}

		[SpecialName]
		public static bool smethod_0()
		{
			return bool_0;
		}

		[CLSCompliant(false)]
		public static void smethod_1(uint uint_2)
		{
			if (bool_0)
			{
				return;
			}
			uint_1 = uint_2;
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			for (num = 0u; num < 256; num++)
			{
				num3 = num;
				for (num2 = 8u; num2 != 0; num2--)
				{
					num3 = (((num3 & 1) == 0) ? (num3 >> 1) : ((num3 >> 1) ^ uint_1));
				}
				uint_0[num] = num3;
			}
			bool_0 = true;
		}

		public static void smethod_2(int int_0)
		{
			byte[] bytes = BitConverter.GetBytes(int_0);
			uint uint_ = BitConverter.ToUInt32(bytes, 0);
			smethod_1(uint_);
		}

		public static void smethod_3(long long_0)
		{
			uint uint_ = (uint)(long_0 & 0xFFFFFFFFL);
			smethod_1(uint_);
		}

		public static void lejMwloOne()
		{
			smethod_1(3988292384u);
		}

		public static byte[] smethod_4(byte[] byte_0)
		{
			if (!bool_0)
			{
				throw new InvalidOperationException("You must initialize the CRC table before attempting to calculate the check on data.");
			}
			uint num = 0u;
			uint num2 = (uint)byte_0.Length;
			uint num3 = 0u;
			uint num4 = uint.MaxValue;
			for (num3 = 0u; num3 < num2; num3++)
			{
				num4 = (num4 >> 8) ^ uint_0[byte_0[num3] ^ (num4 & 0xFF)];
			}
			num = num4 ^ 0xFFFFFFFFu;
			return BitConverter.GetBytes(num);
		}

		public static byte[] smethod_5(string string_0)
		{
			return smethod_7(string_0, Encoding.ASCII);
		}

		public static string smethod_6(string string_0)
		{
			string text = "";
			byte[] array = smethod_7(string_0, Encoding.ASCII);
			for (int i = 0; i < array.Length; i++)
			{
				text += array[i].ToString("X2");
			}
			return text;
		}

		public static byte[] smethod_7(string string_0, Encoding encoding_0)
		{
			byte[] bytes = encoding_0.GetBytes(string_0);
			return smethod_4(bytes);
		}
	}

	[DefaultMember("Item")]
	internal sealed class Class17
	{
		private Hashtable hashtable_0;

		public Class17(string[] string_0)
		{
			hashtable_0 = new Hashtable();
			Regex regex = new Regex("^-{1,2}|^/|=|:", RegexOptions.Compiled);
			Regex regex2 = new Regex("^['\"]?(.*?)['\"]?$", RegexOptions.Compiled);
			string text = null;
			foreach (string input in string_0)
			{
				string[] array = regex.Split(input, 3);
				switch (array.Length)
				{
				case 1:
					if (text != null)
					{
						if (!hashtable_0.Contains(text))
						{
							array[0] = regex2.Replace(array[0], "$1");
							hashtable_0.Add(text, array[0]);
						}
						text = null;
					}
					break;
				case 2:
					if (text != null && !hashtable_0.Contains(text))
					{
						hashtable_0.Add(text, "true");
					}
					text = array[1];
					break;
				case 3:
					if (text != null && !hashtable_0.Contains(text))
					{
						hashtable_0.Add(text, "true");
					}
					text = array[1];
					if (!hashtable_0.Contains(text))
					{
						array[2] = regex2.Replace(array[2], "$1");
						hashtable_0.Add(text, array[2]);
					}
					text = null;
					break;
				}
			}
			if (text != null && !hashtable_0.Contains(text))
			{
				hashtable_0.Add(text, "true");
			}
		}

		[SpecialName]
		public string method_0(string string_0)
		{
			return (string)hashtable_0[string_0];
		}
	}

	internal enum Enum5
	{

	}

	internal sealed class Class18
	{
		private Class22 class22_0 = new Class22();

		private ArrayList arrayList_0 = new ArrayList();

		public Class18(string string_0)
			: this(new StreamReader(string_0))
		{
		}

		public Class18(string string_0, Enum5 enum5_0)
			: this(new StreamReader(string_0), enum5_0)
		{
		}

		public Class18(TextReader textReader_0)
			: this(textReader_0, (Enum5)0)
		{
		}

		public Class18(TextReader textReader_0, Enum5 enum5_0)
		{
			method_3(method_4(textReader_0, enum5_0));
		}

		public Class18(Stream stream_0)
			: this(new StreamReader(stream_0))
		{
		}

		public Class18(Stream stream_0, Enum5 enum5_0)
			: this(new StreamReader(stream_0), enum5_0)
		{
		}

		public Class18(Class20 class20_0)
		{
			method_3(class20_0);
		}

		public Class18()
		{
		}

		[SpecialName]
		public Class22 method_0()
		{
			return class22_0;
		}

		public void method_1(TextWriter textWriter_0)
		{
			Class23 @class = new Class23(textWriter_0);
			Class19 class2 = null;
			Class21 class3 = null;
			foreach (string item in arrayList_0)
			{
				@class.method_16(item);
			}
			for (int i = 0; i < class22_0.Count; i++)
			{
				class3 = class22_0.method_0(i);
				@class.method_12(class3.Name, class3.method_0());
				for (int j = 0; j < class3.Nlgacufklg(); j++)
				{
					class2 = class3.yaoaFohYuj(j);
					switch (class2.method_0())
					{
					case (Enum7)1:
						@class.method_14(class2.Name, class2.method_2(), class2.method_4());
						break;
					case (Enum7)2:
						@class.method_16(class2.method_4());
						break;
					}
				}
			}
			@class.method_9();
		}

		public void method_2(string string_0)
		{
			StreamWriter streamWriter = new StreamWriter(string_0);
			method_1(streamWriter);
			streamWriter.Close();
		}

		private void method_3(Class20 class20_0)
		{
			class20_0.method_6(bool_5: false);
			bool flag = false;
			Class21 @class = null;
			while (class20_0.method_12())
			{
				switch (class20_0.method_1())
				{
				case (Enum7)0:
					flag = true;
					if (class22_0.method_1(class20_0.Name) != null)
					{
						class22_0.method_3(class20_0.Name);
					}
					@class = new Class21(class20_0.Name, class20_0.method_2());
					class22_0.method_2(@class);
					break;
				case (Enum7)1:
					@class.method_4(class20_0.Name, class20_0.method_0(), class20_0.method_2());
					break;
				case (Enum7)2:
					if (!flag)
					{
						arrayList_0.Add(class20_0.method_2());
					}
					else
					{
						@class.method_6(class20_0.method_2());
					}
					break;
				}
			}
			class20_0.method_15();
		}

		private Class20 method_4(TextReader textReader_0, Enum5 enum5_0)
		{
			Class20 @class = new Class20(textReader_0);
			switch (enum5_0)
			{
			case (Enum5)1:
				@class.method_11(bool_5: false);
				@class.method_19(new char[1] { ':' });
				break;
			case (Enum5)2:
				@class.method_11(bool_5: false);
				@class.method_9(bool_5: true);
				break;
			}
			return @class;
		}
	}

	[Serializable]
	internal sealed class Exception0 : SystemException
	{
		private Class20 class20_0;

		private string string_0 = "";

		public override string Message
		{
			get
			{
				if (class20_0 == null)
				{
					return base.Message;
				}
				return string.Format(CultureInfo.InvariantCulture, "{0} - Line: {1}, Position: {2}.", new object[3]
				{
					base.Message,
					method_1(),
					method_0()
				});
			}
		}

		[SpecialName]
		public int method_0()
		{
			if (class20_0 != null)
			{
				return class20_0.method_4();
			}
			return 0;
		}

		[SpecialName]
		public int method_1()
		{
			if (class20_0 != null)
			{
				return class20_0.method_3();
			}
			return 0;
		}

		public Exception0()
		{
			string_0 = "An error has occurred";
		}

		public Exception0(string string_1, Exception exception_0)
			: base(string_1, exception_0)
		{
		}

		public Exception0(string string_1)
			: base(string_1)
		{
			string_0 = string_1;
		}

		internal Exception0(Class20 class20_1, string string_1)
			: this(string_1)
		{
			class20_0 = class20_1;
			string_0 = string_1;
		}

		protected Exception0(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
			: base(serializationInfo_0, streamingContext_0)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (class20_0 != null)
			{
				info.AddValue("lineNumber", class20_0.method_3());
				info.AddValue("linePosition", class20_0.method_4());
			}
		}
	}

	internal class Attribute1 : Attribute
	{
		public Attribute1(ulong ulong_0)
		{
		}
	}

	[Attribute1(9223372036854775908uL)]
	internal class Class19
	{
		private Enum7 enum7_0 = (Enum7)2;

		private string string_0 = "";

		private string string_1 = "";

		private string string_2;

		public string Name => string_0;

		[SpecialName]
		public Enum7 method_0()
		{
			return enum7_0;
		}

		[SpecialName]
		public void method_1(Enum7 enum7_1)
		{
			enum7_0 = enum7_1;
		}

		[SpecialName]
		public string method_2()
		{
			return string_1;
		}

		[SpecialName]
		public void method_3(string string_3)
		{
			string_1 = string_3;
		}

		[SpecialName]
		public string method_4()
		{
			return string_2;
		}

		[SpecialName]
		public void method_5(string string_3)
		{
			string_2 = string_3;
		}

		protected internal Class19(string string_3, string string_4, Enum7 enum7_1, string string_5)
		{
			string_0 = string_3;
			string_1 = string_4;
			enum7_0 = enum7_1;
			string_2 = string_5;
		}
	}

	internal enum Enum6
	{

	}

	internal enum Enum7
	{

	}

	internal class Class20 : IDisposable
	{
		private int int_0 = 1;

		private int int_1 = 1;

		private Enum7 enum7_0 = (Enum7)2;

		private TextReader textReader_0;

		private bool bool_0;

		private StringBuilder stringBuilder_0 = new StringBuilder();

		private StringBuilder stringBuilder_1 = new StringBuilder();

		private StringBuilder stringBuilder_2 = new StringBuilder();

		private Enum6 enum6_0 = (Enum6)3;

		private bool bool_1;

		private bool bool_2;

		private bool bool_3;

		private bool bool_4 = true;

		private char[] char_0 = new char[1] { ';' };

		private char[] char_1 = new char[1] { '=' };

		public string Name => stringBuilder_0.ToString();

		[SpecialName]
		public string method_0()
		{
			return stringBuilder_1.ToString();
		}

		[SpecialName]
		public Enum7 method_1()
		{
			return enum7_0;
		}

		[SpecialName]
		public string method_2()
		{
			if (!bool_1)
			{
				return null;
			}
			return stringBuilder_2.ToString();
		}

		[SpecialName]
		public int method_3()
		{
			return int_0;
		}

		[SpecialName]
		public int method_4()
		{
			return int_1;
		}

		[SpecialName]
		public bool method_5()
		{
			return bool_0;
		}

		[SpecialName]
		public void method_6(bool bool_5)
		{
			bool_0 = bool_5;
		}

		[SpecialName]
		public Enum6 method_7()
		{
			return enum6_0;
		}

		[SpecialName]
		public bool method_8()
		{
			return bool_3;
		}

		[SpecialName]
		public void method_9(bool bool_5)
		{
			bool_3 = bool_5;
		}

		[SpecialName]
		public bool method_10()
		{
			return bool_4;
		}

		[SpecialName]
		public void method_11(bool bool_5)
		{
			bool_4 = bool_5;
		}

		public Class20(string string_0)
		{
			textReader_0 = new StreamReader(string_0);
		}

		public Class20(TextReader textReader_1)
		{
			textReader_0 = textReader_1;
		}

		public Class20(Stream stream_0)
			: this(new StreamReader(stream_0))
		{
		}

		public bool method_12()
		{
			bool result = false;
			if (enum6_0 != (Enum6)1 || enum6_0 != 0)
			{
				enum6_0 = (Enum6)4;
				result = method_21();
			}
			return result;
		}

		public bool method_13()
		{
			bool flag = false;
			do
			{
				flag = method_12();
			}
			while (enum7_0 != 0 && flag);
			return flag;
		}

		public bool method_14()
		{
			bool flag = false;
			do
			{
				flag = method_12();
				if (enum7_0 == (Enum7)0)
				{
					flag = false;
					break;
				}
			}
			while (enum7_0 != (Enum7)1 && flag);
			return flag;
		}

		public void method_15()
		{
			method_20();
			enum6_0 = (Enum6)0;
			if (textReader_0 != null)
			{
				textReader_0.Close();
			}
		}

		public void Dispose()
		{
			Dispose(bool_5: true);
		}

		public char[] method_16()
		{
			return new char[0];
		}

		public void method_17(char[] char_2)
		{
		}

		public char[] method_18()
		{
			char[] array = new char[char_1.Length];
			Array.Copy(char_1, 0, array, 0, char_1.Length);
			return array;
		}

		public void method_19(char[] char_2)
		{
			if (char_2.Length < 1)
			{
				throw new ArgumentException("Must supply at least one delimiter");
			}
			char_1 = char_2;
		}

		protected   void Dispose(bool bool_5)
		{
			if (!bool_2)
			{
				textReader_0.Close();
				bool_2 = true;
				if (bool_5)
				{
					GC.SuppressFinalize(this);
				}
			}
		}

		~Class20()
		{
			Dispose(bool_5: false);
		}

		private void method_20()
		{
			stringBuilder_0.Remove(0, stringBuilder_0.Length);
			stringBuilder_1.Remove(0, stringBuilder_1.Length);
			stringBuilder_2.Remove(0, stringBuilder_2.Length);
			enum7_0 = (Enum7)2;
			bool_1 = false;
		}

		private bool method_21()
		{
			bool result = true;
			int num = method_30();
			method_20();
			if (method_31(num))
			{
				enum7_0 = (Enum7)2;
				method_29();
				method_22();
				return result;
			}
			switch (num)
			{
			case 10:
				method_29();
				break;
			case -1:
				enum6_0 = (Enum6)1;
				result = false;
				break;
			default:
				method_24();
				break;
			case 91:
				method_26();
				break;
			case 9:
			case 13:
			case 32:
				method_34();
				method_21();
				break;
			}
			return result;
		}

		private void method_22()
		{
			int num = -1;
			method_34();
			bool_1 = true;
			do
			{
				num = method_29();
				stringBuilder_2.Append((char)num);
			}
			while (!method_35(num));
			method_23(stringBuilder_2);
		}

		private void method_23(StringBuilder stringBuilder_3)
		{
			string text = stringBuilder_3.ToString();
			stringBuilder_3.Remove(0, stringBuilder_3.Length);
			stringBuilder_3.Append(text.TrimEnd(null));
		}

		private void method_24()
		{
			int num = -1;
			enum7_0 = (Enum7)1;
			while (true)
			{
				num = method_30();
				if (method_32(num))
				{
					break;
				}
				if (!method_35(num))
				{
					stringBuilder_0.Append((char)method_29());
					continue;
				}
				throw new Exception0(this, $"Expected assignment operator ({char_1[0]})");
			}
			method_29();
			method_25();
			method_27();
			method_23(stringBuilder_0);
		}

		private void method_25()
		{
			int num = -1;
			bool flag = false;
			int num2 = 0;
			method_34();
			while (true)
			{
				num = method_30();
				if (!poxIpWptoD(num))
				{
					num2++;
				}
				if (num == 34)
				{
					method_29();
					if (flag || num2 != 1)
					{
						break;
					}
					flag = true;
					continue;
				}
				if (!flag || !method_35(num))
				{
					if (bool_3 && num == 92)
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append((char)method_29());
						while (method_30() != 10 && poxIpWptoD(method_30()))
						{
							if (method_30() != 13)
							{
								stringBuilder.Append((char)method_29());
							}
							else
							{
								method_29();
							}
						}
						if (method_30() == 10)
						{
							method_29();
							continue;
						}
						stringBuilder_1.Append(stringBuilder.ToString());
					}
					if ((bool_4 && method_31(num)) || method_35(num))
					{
						break;
					}
					stringBuilder_1.Append((char)method_29());
					continue;
				}
				throw new Exception0(this, "Expected closing quote (\")");
			}
			if (!flag)
			{
				method_23(stringBuilder_1);
			}
		}

		private void method_26()
		{
			int num = -1;
			enum7_0 = (Enum7)0;
			num = method_29();
			while (true)
			{
				num = method_30();
				if (num == 93)
				{
					break;
				}
				if (!method_35(num))
				{
					stringBuilder_0.Append((char)method_29());
					continue;
				}
				throw new Exception0(this, "Expected section end (])");
			}
			method_28();
			method_23(stringBuilder_0);
		}

		private void method_27()
		{
			int int_ = method_29();
			while (true)
			{
				if (!method_35(int_))
				{
					if (method_31(int_))
					{
						break;
					}
					int_ = method_29();
					continue;
				}
				return;
			}
			if (bool_0)
			{
				method_28();
			}
			else
			{
				method_22();
			}
		}

		private void method_28()
		{
			int num = -1;
			do
			{
				num = method_29();
			}
			while (!method_35(num));
		}

		private int method_29()
		{
			int num = textReader_0.Read();
			if (num == 10)
			{
				int_0++;
				int_1 = 1;
			}
			else
			{
				int_1++;
			}
			return num;
		}

		private int method_30()
		{
			return textReader_0.Peek();
		}

		private bool method_31(int int_2)
		{
			return method_33(char_0, int_2);
		}

		private bool method_32(int int_2)
		{
			return method_33(char_1, int_2);
		}

		private bool method_33(char[] char_2, int int_2)
		{
			bool result = false;
			for (int i = 0; i < char_2.Length; i++)
			{
				if (int_2 == char_2[i])
				{
					result = true;
					break;
				}
			}
			return result;
		}

		private bool poxIpWptoD(int int_2)
		{
			if (int_2 != 32 && int_2 != 9 && int_2 != 13)
			{
				return int_2 == 10;
			}
			return true;
		}

		private void method_34()
		{
			while (poxIpWptoD(method_30()) && !method_35(method_30()))
			{
				method_29();
			}
		}

		private bool method_35(int int_2)
		{
			if (int_2 != 10)
			{
				return int_2 == -1;
			}
			return true;
		}
	}

	internal sealed class Class21
	{
		private Class24 class24_0 = new Class24();

		private string string_0 = "";

		private string string_1;

		private int int_0;

		public string Name => string_0;

		public Class21(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}

		public Class21(string string_2)
			: this(string_2, null)
		{
		}

		[SpecialName]
		public string method_0()
		{
			return string_1;
		}

		[SpecialName]
		public int Nlgacufklg()
		{
			return class24_0.Count;
		}

		public string method_1(string string_2)
		{
			string result = null;
			if (method_3(string_2))
			{
				Class19 @class = (Class19)class24_0[string_2];
				result = @class.method_2();
			}
			return result;
		}

		public Class19 yaoaFohYuj(int int_1)
		{
			return (Class19)class24_0.method_0(int_1);
		}

		public string[] method_2()
		{
			ArrayList arrayList = new ArrayList();
			Class19 @class = null;
			for (int i = 0; i < class24_0.Count; i++)
			{
				@class = (Class19)class24_0.method_0(i);
				if (@class.method_0() == (Enum7)1)
				{
					arrayList.Add(@class.Name);
				}
			}
			string[] array = new string[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}

		public bool method_3(string string_2)
		{
			return class24_0[string_2] != null;
		}

		public void method_4(string string_2, string string_3, string string_4)
		{
			Class19 @class = null;
			if (method_3(string_2))
			{
				@class = (Class19)class24_0[string_2];
				@class.method_3(string_3);
				@class.method_5(string_4);
			}
			else
			{
				@class = new Class19(string_2, string_3, (Enum7)1, string_4);
				class24_0.Add(string_2, @class);
			}
		}

		public void method_5(string string_2, string string_3)
		{
			Class19 @class = null;
			if (method_3(string_2))
			{
				@class = (Class19)class24_0[string_2];
				@class.method_3(string_3);
				@class.method_5(string_1);
			}
			else
			{
				@class = new Class19(string_2, string_3, (Enum7)1, null);
				class24_0.Add(string_2, @class);
			}
		}

		public void method_6(string string_2)
		{
			string text = "#comment" + int_0;
			Class19 value = new Class19(text, null, (Enum7)2, string_2);
			class24_0.Add(text, value);
			int_0++;
		}

		public void method_7()
		{
			method_6(null);
		}

		public void method_8(string string_2)
		{
			if (method_3(string_2))
			{
				class24_0.Remove(string_2);
			}
		}
	}

	[DefaultMember("Item")]
	internal class Class22 : ICollection, IEnumerable
	{
		private Class24 class24_0 = new Class24();

		public int Count => class24_0.Count;

		public object SyncRoot => class24_0.SyncRoot;

		public bool IsSynchronized => class24_0.IsSynchronized;

		[SpecialName]
		public Class21 method_0(int int_0)
		{
			return (Class21)class24_0.method_0(int_0);
		}

		[SpecialName]
		public Class21 method_1(string string_0)
		{
			return (Class21)class24_0[string_0];
		}

		public void method_2(Class21 class21_0)
		{
			if (class24_0.Contains(class21_0))
			{
				throw new ArgumentException("IniSection already exists");
			}
			class24_0.Add(class21_0.Name, class21_0);
		}

		public void method_3(string string_0)
		{
			class24_0.Remove(string_0);
		}

		public void CopyTo(Array array, int index)
		{
			class24_0.CopyTo(array, index);
		}

		public void method_4(Class21[] class21_0, int int_0)
		{
			((ICollection)class24_0).CopyTo((Array)class21_0, int_0);
		}

		public IEnumerator GetEnumerator()
		{
			return class24_0.method_4();
		}
	}

	internal enum Enum8
	{

	}

	internal class Class23 : IDisposable
	{
		private int int_0;

		private bool bool_0;

		private Enum8 enum8_0;

		private char char_0 = ';';

		private char char_1 = '=';

		private TextWriter textWriter_0;

		private string string_0 = "\r\n";

		private StringBuilder stringBuilder_0 = new StringBuilder();

		private Stream stream_0;

		private bool bool_1;

		[SpecialName]
		public int XaVlMnsirB()
		{
			return int_0;
		}

		[SpecialName]
		public void method_0(int int_1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentException("Negative values are illegal");
			}
			int_0 = int_1;
			stringBuilder_0.Remove(0, stringBuilder_0.Length);
			for (int i = 0; i < int_1; i++)
			{
				stringBuilder_0.Append(' ');
			}
		}

		[SpecialName]
		public bool method_1()
		{
			return bool_0;
		}

		[SpecialName]
		public void method_2(bool bool_2)
		{
			bool_0 = bool_2;
		}

		[SpecialName]
		public Enum8 method_3()
		{
			return enum8_0;
		}

		[SpecialName]
		public char method_4()
		{
			return char_0;
		}

		[SpecialName]
		public void method_5(char char_2)
		{
			char_0 = char_2;
		}

		[SpecialName]
		public char method_6()
		{
			return char_1;
		}

		[SpecialName]
		public void method_7(char char_2)
		{
			char_1 = char_2;
		}

		[SpecialName]
		public Stream method_8()
		{
			return stream_0;
		}

		public Class23(string string_1)
			: this(new FileStream(string_1, FileMode.Create, FileAccess.Write, FileShare.None))
		{
		}

		public Class23(TextWriter textWriter_1)
		{
			textWriter_0 = textWriter_1;
			if (textWriter_1 is StreamWriter streamWriter)
			{
				stream_0 = streamWriter.BaseStream;
			}
		}

		public Class23(Stream stream_1)
			: this(new StreamWriter(stream_1))
		{
		}

		public void method_9()
		{
			textWriter_0.Close();
			enum8_0 = (Enum8)3;
		}

		public void method_10()
		{
			textWriter_0.Flush();
		}

		public override string ToString()
		{
			return textWriter_0.ToString();
		}

		public void method_11(string string_1)
		{
			method_18();
			enum8_0 = (Enum8)2;
			method_21("[" + string_1 + "]");
		}

		public void method_12(string string_1, string string_2)
		{
			method_18();
			enum8_0 = (Enum8)2;
			method_21("[" + string_1 + "]" + method_19(string_2));
		}

		public void method_13(string string_1, string string_2)
		{
			method_17();
			method_21(string_1 + " " + char_1 + " " + lNnakdWeYp(string_2));
		}

		public void method_14(string string_1, string string_2, string string_3)
		{
			method_17();
			method_21(string_1 + " " + char_1 + " " + lNnakdWeYp(string_2) + method_19(string_3));
		}

		public void method_15()
		{
			method_18();
			if (enum8_0 == (Enum8)0)
			{
				enum8_0 = (Enum8)1;
			}
			method_21("");
		}

		public void method_16(string string_1)
		{
			method_18();
			if (enum8_0 == (Enum8)0)
			{
				enum8_0 = (Enum8)1;
			}
			if (string_1 == null)
			{
				method_21("");
			}
			else
			{
				method_21(char_0 + " " + string_1);
			}
		}

		public void Dispose()
		{
			Dispose(bool_2: true);
		}

		protected   void Dispose(bool bool_2)
		{
			if (!bool_1)
			{
				textWriter_0.Close();
				stream_0.Close();
				bool_1 = true;
				if (bool_2)
				{
					GC.SuppressFinalize(this);
				}
			}
		}

		~Class23()
		{
			Dispose(bool_2: false);
		}

		private string lNnakdWeYp(string string_1)
		{
			if (bool_0)
			{
				return uCylejwmcg('"' + string_1 + '"');
			}
			return uCylejwmcg(string_1);
		}

		private void method_17()
		{
			method_18();
			switch (enum8_0)
			{
			case (Enum8)0:
			case (Enum8)1:
				throw new InvalidOperationException("The WriteState is not Section");
			case (Enum8)3:
				throw new InvalidOperationException("The writer is closed");
			case (Enum8)2:
				break;
			}
		}

		private void method_18()
		{
			if (enum8_0 == (Enum8)3)
			{
				throw new InvalidOperationException("The writer is closed");
			}
		}

		private string method_19(string string_1)
		{
			if (string_1 != null)
			{
				return " " + char_0 + " " + string_1;
			}
			return "";
		}

		private void method_20(string string_1)
		{
			textWriter_0.Write(stringBuilder_0.ToString() + string_1);
		}

		private void method_21(string string_1)
		{
			method_20(string_1 + string_0);
		}

		private string uCylejwmcg(string string_1)
		{
			return string_1.Replace("\n", "");
		}
	}

	internal sealed class Class24 : IDictionary, ICollection, IEnumerable
	{
		private Hashtable hashtable_0 = new Hashtable();

		private ArrayList arrayList_0 = new ArrayList();

		public int Count => arrayList_0.Count;

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public bool IsSynchronized => false;

		public object this[object key]
		{
			get
			{
				return hashtable_0[key];
			}
			set
			{
				if (hashtable_0.Contains(key))
				{
					hashtable_0[key] = value;
					hashtable_0[method_5(key)] = new DictionaryEntry(key, value);
				}
				else
				{
					Add(key, value);
				}
			}
		}

		public ICollection Keys
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < arrayList_0.Count; i++)
				{
					arrayList.Add(((DictionaryEntry)arrayList_0[i]).Key);
				}
				return arrayList;
			}
		}

		public ICollection Values
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < arrayList_0.Count; i++)
				{
					arrayList.Add(((DictionaryEntry)arrayList_0[i]).Value);
				}
				return arrayList;
			}
		}

		public object SyncRoot => this;

		[SpecialName]
		public object method_0(int int_0)
		{
			return ((DictionaryEntry)arrayList_0[int_0]).Value;
		}

		[SpecialName]
		public void OvulrppFue(int int_0, object object_0)
		{
			if (int_0 < 0 || int_0 >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			object key = ((DictionaryEntry)arrayList_0[int_0]).Key;
			arrayList_0[int_0] = new DictionaryEntry(key, object_0);
			hashtable_0[key] = object_0;
		}

		public void Add(object key, object value)
		{
			hashtable_0.Add(key, value);
			arrayList_0.Add(new DictionaryEntry(key, value));
		}

		public void Clear()
		{
			hashtable_0.Clear();
			arrayList_0.Clear();
		}

		public bool Contains(object key)
		{
			return hashtable_0.Contains(key);
		}

		public void CopyTo(Array array, int index)
		{
			hashtable_0.CopyTo(array, index);
		}

		public void method_1(DictionaryEntry[] dictionaryEntry_0, int int_0)
		{
			hashtable_0.CopyTo(dictionaryEntry_0, int_0);
		}

		public void method_2(int int_0, object object_0, object object_1)
		{
			if (int_0 > Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			hashtable_0.Add(object_0, object_1);
			arrayList_0.Insert(int_0, new DictionaryEntry(object_0, object_1));
		}

		public void Remove(object key)
		{
			hashtable_0.Remove(key);
			arrayList_0.RemoveAt(method_5(key));
		}

		public void method_3(int int_0)
		{
			if (int_0 >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			hashtable_0.Remove(((DictionaryEntry)arrayList_0[int_0]).Key);
			arrayList_0.RemoveAt(int_0);
		}

		public IEnumerator method_4()
		{
			return new Class25(arrayList_0);
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Class25(arrayList_0);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Class25(arrayList_0);
		}

		private int method_5(object object_0)
		{
			int num = 0;
			while (true)
			{
				if (num < arrayList_0.Count)
				{
					if (((DictionaryEntry)arrayList_0[num]).Key.Equals(object_0))
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return num;
		}
	}

	internal sealed class Class25 : IDictionaryEnumerator, IEnumerator
	{
		private int int_0 = -1;

		private ArrayList arrayList_0;

		object IEnumerator.Current
		{
			get
			{
				if (int_0 < 0 || int_0 >= arrayList_0.Count)
				{
					throw new InvalidOperationException();
				}
				return arrayList_0[int_0];
			}
		}

		public DictionaryEntry Entry => method_0();

		public object Key => Entry.Key;

		public object Value => Entry.Value;

		internal Class25(ArrayList arrayList_1)
		{
			arrayList_0 = arrayList_1;
		}

		[SpecialName]
		public DictionaryEntry method_0()
		{
			if (int_0 < 0 || int_0 >= arrayList_0.Count)
			{
				throw new InvalidOperationException();
			}
			return (DictionaryEntry)arrayList_0[int_0];
		}

		public bool MoveNext()
		{
			int_0++;
			if (int_0 >= arrayList_0.Count)
			{
				return false;
			}
			return true;
		}

		public void Reset()
		{
			int_0 = -1;
		}
	}

	internal sealed class Class26
	{
		public bool bool_0;

		public bool bool_1 = true;

		public bool bool_2;

		public bool bool_3 = true;

		public bool bool_4;

		public string string_0 = "";

		public string string_1 = "";

		public string string_2 = "";

		public string string_3 = "";

		public bool bool_5 = true;

		public string string_4 = "";

		public bool wxihsNeeOp;

		public bool bool_6;

		public bool bool_7;

		public bool bool_8 = true;

		public bool bool_9;

		public bool bool_10 = true;

		public bool bool_11;

		public bool bool_12 = true;

		public bool bool_13;

		public bool bool_14;

		public bool bool_15;

		public bool bool_16;

		public bool bool_17;

		public bool bool_18;

		public bool bool_19;

		public bool bool_20 = true;

		public bool bool_21 = true;

		public bool bool_22;

		public bool bool_23;

		public bool bool_24;

		public bool bool_25;

		public bool bool_26;

		public bool bool_27 = true;

		public bool bool_28;

		public int int_0 = 9;

		public bool bool_29;

		public bool bool_30 = true;

		public string string_5 = "";

		public string string_6 = "";

		public string string_7 = "<AssemblyLocation>\\<AssemblyName>_Secure\\<AssemblyFileName>";

		public bool EefhdpdQkZ;

		public bool bool_31;

		public bool bool_32;

		public bool bool_33;

		public bool bool_34;

		public bool bool_35 = true;

		public bool bool_36 = true;

		public bool bool_37 = true;

		internal Class15 class15_0 = new Class15();

		public string string_8 = "";

		public string string_9 = "";

		public string string_10 = "";

		public string string_11 = "";

		public string string_12 = "";

		public string string_13 = "";

		public string string_14 = "http://timestamp.verisign.com/scripts/timstamp.dll";

		public string string_15 = "http://timestamp.geotrust.com/tsa";

		public bool bool_38 = true;

		public bool bool_39 = true;

		public bool bool_40;

		public bool bool_41 = true;

		public bool bool_42 = true;

		public bool bool_43 = true;

		public bool bool_44;

		public DateTime dateTime_0 = DateTime.Now;

		public string string_16 = "";

		public bool bool_45;

		public bool bool_46;

		public bool bool_47 = true;

		public bool bool_48 = true;

		public bool bool_49 = true;

		public bool bool_50;

		public bool bool_51;

		public int int_1 = 5;

		public int int_2 = -1;

		public bool bool_52;

		public Enum9 enum9_0;

		public int int_3 = 14;

		public int int_4 = 10;

		public int int_5 = 10;

		public int int_6 = 5;

		public bool bool_53 = true;

		public string string_17 = "Lock System";

		public string string_18 = "";

		public bool bool_54 = true;

		public bool bool_55 = true;

		public bool bool_56 = true;

		public string string_19 = "Your expiration date is reached! You need to purchase a license file to run this software.";

		public string string_20 = "Nag Screen! This message will disappear when a valid license file is installed. You are on day [current_minutes_days] of your [max_minutes_days] day evaluation period. You have [minutes_days_left] days left. You have used this software [current_uses] times out of a maximum of [max_uses]. You have [uses_left] uses left.";

		public string string_21 = "This software won't run without a valid license file. Either a valid license file could not be found or your license file is expired.";

		public string string_22 = "You are on day [current_minutes_days] of your [max_minutes_days] day evaluation period. Your trial period is expired! You need to purchase a license to run this software.";

		public string string_23 = "You have used this software [current_uses] times out of a maximum of [max_uses]. You have [uses_left] uses left. Your trial period is expired! You need to purchase a license to run this software.";

		public string string_24 = "You can only run maximal [max_processes] instances of this software at the same time.";

		public Color color_0 = Color.White;

		public Color color_1 = Color.FromArgb(157, 211, 252);

		public bool bool_57;

		public bool bool_58 = true;

		public byte[] byte_0 = new byte[0];

		public bool bool_59;

		public bool KfyOgavDjY;

		public Class18 class18_0 = new Class18();

		public string string_25 = "####-####-####-####-####";

		public bool bool_60;

		public DateTime dateTime_1 = DateTime.Now;

		public bool bool_61;

		public Enum9 enum9_1;

		public int int_7 = 1;

		public Hashtable hashtable_0 = new Hashtable();

		public bool bool_62;

		internal byte[] byte_1 = new byte[0];

		internal void method_0()
		{
			if (class15_0 != null && class15_0.method_8() != null)
			{
				class15_0.method_8().Clear();
			}
		}

		public Class18 method_1(bool bool_63, bool bool_64)
		{
			Class18 @class = new Class18();
			Class21 class2 = new Class21("General_Settings");
			class2.method_4("General_Loading_Screen_Enable", bool_0.ToString(), "");
			class2.method_4("General_Exception_Catching", bool_1.ToString(), "");
			class2.method_4("General_Internalization", bool_2.ToString(), "");
			class2.method_4("General_V3Mode", bool_3.ToString(), "");
			class2.method_4("General_VistaAdmin", bool_4.ToString(), "");
			class2.method_4("General_App_Icon", string_0.ToString(), "");
			class2.method_4("SPC_File", string_1.ToString(), "");
			class2.method_4("PVK_File", string_2.ToString(), "");
			class2.method_4("PVK_Password", string_3.ToString(), "");
			class2.method_4("General_App_Satellite_Assemblies", "", "");
			class2.method_4("General_App_Satellite_Assemblies_Sizes", "", "");
			class2.method_4("General_App_Console", EefhdpdQkZ.ToString(), "");
			class2.method_4("General_RequestHID", bool_31.ToString(), "");
			class2.method_4("General_Lib_Necrobit", wxihsNeeOp.ToString(), "");
			class2.method_4("General_Mono_Mode", bool_6.ToString(), "");
			class2.method_4("General_AdditionalFilesOwnDirectory", bool_7.ToString(), "");
			class2.method_4("General_Lib_Obfuscation", bool_8.ToString(), "");
			class2.method_4("General_Lib_Merge", bool_9.ToString(), "");
			class2.method_4("General_Lib_MergeAttr", bool_10.ToString(), "");
			class2.method_4("General_Lib_Pack", bool_11.ToString(), "");
			class2.method_4("General_NAT_Merge", bool_12.ToString(), "");
			class2.method_4("General_NATCOMP_Merge", bool_13.ToString(), "");
			class2.method_4("General_STRONGPRO", bool_14.ToString(), "");
			class2.method_4("General_PatchPRO", bool_15.ToString(), "");
			class2.method_4("General_ResourcePRO", bool_16.ToString(), "");
			class2.method_4("General_NativeApp", bool_17.ToString(), "");
			class2.method_4("General_NativeAppPDB", bool_18.ToString(), "");
			class2.method_4("General_Prejit", bool_19.ToString(), "");
			class2.method_4("SuppressILDASM", bool_20.ToString(), "");
			class2.method_4("General_Obfuscate_Serializable_Types", bool_21.ToString(), "");
			class2.method_4("General_IgnoreInternalsVisible", bool_32.ToString(), "");
			class2.method_4("General_Lib_MappingFile", bool_22.ToString(), "");
			class2.method_4("General_Obfuscate_Public_Items", bool_23.ToString(), "");
			class2.method_4("General_Obfuscate_ShortStrings", bool_24.ToString(), "");
			class2.method_4("General_Obfuscate_SingleNamespace", bool_25.ToString(), "");
			class2.method_4("General_Obfuscate_AllParams", bool_26.ToString(), "");
			class2.method_4("General_AntiILDASM_MD", bool_27.ToString(), "");
			class2.method_4("General_Control_Flow_Obfuscation", bool_28.ToString(), "");
			class2.method_4("General_Control_Flow_Obfuscation_Level", int_0.ToString(), "");
			class2.method_4("General_Lib_Obfuscation_Unprintable_Characters", bool_29.ToString(), "");
			class2.method_4("General_SetCompatibleTextRenderingDefault", bool_34.ToString(), "");
			class2.method_4("General_RenderingDefault", bool_35.ToString(), "");
			class2.method_4("General_App_VisualStyles", bool_5.ToString(), "");
			class2.method_4("General_Lib_String_Encryption", bool_30.ToString(), "");
			class2.method_4("General_Lib_DesignTimeLicense", "False", "");
			class2.method_4("General_Lib_AntiDecompiler", "True", "");
			class2.method_4("General_Lib_Native_Protection_License_System", bool_36.ToString(), "");
			class2.method_4("General_Lib_Native_Satellite_Name", string_4.ToString(), "");
			class2.method_4("General_License_File_Name", string_9.ToString(), "");
			class2.method_4("General_PID", string_10.ToString(), "");
			class2.method_4("Assembly_File_Name", string_11.ToString(), "");
			class2.method_4("Assembly_Full_Name", string_12.ToString(), "");
			class2.method_4("General_Lib_Strong_Name_Key_Pair", string_5.ToString(), "");
			class2.method_4("General_Target_FileName", string_7.ToString(), "");
			class2.method_4("General_Obfuscate_ConstantNamespace", string_6.ToString(), "");
			class2.method_4("General_Lib_Remove_Resources", bool_33.ToString(), "");
			class2.method_4("General_Compressor", bool_37.ToString(), "");
			if (bool_63)
			{
				string text = "";
				for (int i = 0; i < class15_0.method_4().Length; i++)
				{
					text += class15_0.method_4()[i].ToString("D3");
				}
				class2.method_4("MasterKey", text.ToString(), "");
			}
			else if (bool_64)
			{
				class2.method_4("MasterKey", class15_0.method_3(), "");
			}
			else
			{
				class2.method_4("MasterKey", class15_0.ToString(), "");
			}
			class2.method_4("ImageRuntimeVersion", string_8.ToString(), "");
			class2.method_4("PFX_Password", string_13.ToString(), "");
			class2.method_4("Sha1StampServer", string_14.ToString(), "");
			class2.method_4("Sha256StampServer", string_15.ToString(), "");
			string text2 = "";
			IDictionaryEnumerator enumerator = hashtable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				text2 = text2 + enumerator.Key.ToString().Replace(";", "ez&#01").Replace("|", "ez&#02") + "|" + enumerator.Value.ToString().Replace(";", "ez&#01").Replace("|", "ez&#02") + "|";
			}
			text2 = text2.Replace("\"", "'");
			class2.method_4("AdditonalLicenseInformation", text2, "");
			class2.method_4("General_Protection_Type_Enable", bool_62.ToString(), "");
			@class.method_0().method_2(class2);
			class2 = new Class21("Lock_Settings");
			class2.method_4("Lock_Snag_Screen_Enable", bool_40.ToString(), "");
			class2.method_4("Not_Found_Screen_Enable", bool_41.ToString(), "");
			class2.method_4("Run_Without_License_File", bool_38.ToString(), "");
			class2.method_4("Expiration_Behaviour_ALL", bool_39.ToString(), "");
			class2.method_4("Lock_Expiration_Screen_Enable", bool_42.ToString(), "");
			class2.method_4("Dialogs_Trial_Period_End_Enabled", bool_54.ToString(), "");
			class2.method_4("Dialogs_Number_Of_Uses_Enabled", bool_55.ToString(), "");
			class2.method_4("Dialogs_Expiration_Date_Enabled", bool_56.ToString(), "");
			class2.method_4("Lock_Max_Processes_Exceeded_Screen_Enable", bool_43.ToString(), "");
			class2.method_4("Lock_Expiration_Date_Enable", bool_44.ToString(), "");
			class2.method_4("Lock_Hardware_Enable", false.ToString(), "");
			class2.method_4("Lock_Hardware_HDD", bool_46.ToString(), "");
			class2.method_4("Lock_Hardware_MAC", bool_47.ToString(), "");
			class2.method_4("Lock_Hardware_BOARD", bool_48.ToString(), "");
			class2.method_4("Lock_Hardware_CPU", bool_49.ToString(), "");
			class2.method_4("Lock_License_Enable", bool_44.ToString(), "");
			class2.method_4("Lock_License_Expiration_Date", dateTime_0.Year.ToString("D4") + dateTime_0.Month.ToString("D2") + dateTime_0.Day.ToString("D2"), "");
			class2.method_4("Lock_Evaluation_Enable", bool_52.ToString(), "");
			class2.method_4("Lock_Number_Of_Uses_Enable", bool_50.ToString(), "");
			class2.method_4("Lock_Max_Number_Of_Processes_Enable", bool_51.ToString(), "");
			class2.method_4("Lock_Evaluation_Type", enum9_0.ToString(), "");
			class2.method_4("Lock_Evaluation_Time", int_3.ToString(), "");
			class2.method_4("Lock_Number_Of_Uses", int_4.ToString(), "");
			class2.method_4("Lock_Number_Of_Processes", int_1.ToString(), "");
			class2.method_4("Lock_Nag_XDays_Before_Expiration", int_2.ToString(), "");
			class2.method_4("License_Number_Of_Uses", int_5.ToString(), "");
			class2.method_4("License_Number_Of_Processes", int_6.ToString(), "");
			class2.method_4("Lock_Expiration_Date", dateTime_0.Year.ToString("D4") + dateTime_0.Month.ToString("D2") + dateTime_0.Day.ToString("D2"), "");
			class2.method_4("Lock_Close_Process_After_Expiration", bool_53.ToString(), "");
			class2.method_4("Lock_Run_Another_Process_After_Expiration", string_16.ToString(), "");
			class2.method_4("License_Number_Of_Uses_Enable", bool_57.ToString(), "");
			class2.method_4("License_Global_Licensing_Behaviour", bool_58.ToString(), "");
			class2.method_4("License_Max_Number_Of_Processes_Enable", bool_59.ToString(), "");
			class2.method_4("License_Hardware_Enable", KfyOgavDjY.ToString(), "");
			class2.method_4("License_Evaluation_Enable", bool_61.ToString(), "");
			class2.method_4("License_Evaluation_Type", enum9_1.ToString(), "");
			class2.method_4("License_Evaluation_Time", int_7.ToString(), "");
			class2.method_4("License_Expiration_Date_Enable", bool_60.ToString(), "");
			class2.method_4("License_Expiration_Date", dateTime_1.Year.ToString("D4") + dateTime_1.Month.ToString("D2") + dateTime_1.Day.ToString("D2"), "");
			@class.method_0().method_2(class2);
			class2 = new Class21("Dialogs");
			class2.method_4("Dialogs_Caption", string_17.ToString(), "");
			class2.method_4("CustomizeMessageBox", string_18.ToString(), "");
			class2.method_4("Dialogs_License_Expired", string_19.ToString(), "");
			class2.method_4("Dialogs_SnagScreen", string_20.ToString(), "");
			class2.method_4("Dialogs_Invalid_License", string_21.ToString(), "");
			class2.method_4("Dialogs_License_Examination_Failed", "", "");
			class2.method_4("Dialogs_Trial_Period_End", string_22.ToString(), "");
			class2.method_4("Dialogs_Number_Of_Uses", string_23.ToString(), "");
			class2.method_4("Dialogs_Max_Processes_Exceeded", string_24.ToString(), "");
			class2.method_4("Dialogs_Gradient_Color_Begin", Class8.smethod_7(color_0), "");
			class2.method_4("Dialogs_Gradient_Color_End", Class8.smethod_7(color_1), "");
			class2.method_4("License_HardwareID_2", string_25.ToString(), "");
			@class.method_0().method_2(class2);
			return @class;
		}

		public Class18 method_2()
		{
			Class18 @class = new Class18();
			Class21 class2 = new Class21("License_Settings");
			string text = "";
			for (int i = 0; i < class15_0.method_4().Length; i++)
			{
				text += class15_0.method_4()[i].ToString("D3");
			}
			class2.method_4("MasterKey", text, "");
			class2.method_4("Lock_License_Enable", bool_60.ToString(), "");
			class2.method_4("Lock_License_Expiration_Date", dateTime_1.Year.ToString("D4") + dateTime_1.Month.ToString("D2") + dateTime_1.Day.ToString("D2"), "");
			class2.method_4("License_Hardware_Enable", KfyOgavDjY.ToString(), "");
			class2.method_4("Lock_Hardware_HDD", bool_46.ToString(), "");
			class2.method_4("Lock_Hardware_MAC", bool_47.ToString(), "");
			class2.method_4("Lock_Hardware_BOARD", bool_48.ToString(), "");
			class2.method_4("Lock_Hardware_CPU", bool_49.ToString(), "");
			class2.method_4("License_Evaluation_Enable", bool_61.ToString(), "");
			class2.method_4("License_Evaluation_Type", enum9_1.ToString(), "");
			class2.method_4("License_Evaluation_Time", int_7.ToString(), "");
			class2.method_4("License_Number_Of_Uses_Enable", bool_57.ToString(), "");
			byte_0 = new Class15().method_4();
			class2.method_4("License_Individual_Key", Convert.ToBase64String(byte_0), "");
			class2.method_4("License_Global_Licensing_Behaviour", bool_58.ToString(), "");
			class2.method_4("License_Max_Number_Of_Processes_Enable", bool_59.ToString(), "");
			class2.method_4("License_Number_Of_Uses", int_5.ToString(), "");
			class2.method_4("License_Number_Of_Processes", int_6.ToString(), "");
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(memoryStream);
			class18_0.method_1(streamWriter);
			byte[] array = memoryStream.ToArray();
			string text2 = "";
			for (int j = 0; j < array.Length; j++)
			{
				text2 += array[j].ToString("D3");
			}
			streamWriter.Close();
			memoryStream.Close();
			class2.method_4("License_HardwareID", text2, "");
			class2.method_4("License_HardwareID_2", string_25, "");
			string text3 = "";
			IDictionaryEnumerator enumerator = hashtable_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				text3 = text3 + enumerator.Key.ToString().Replace(";", "ez&#01").Replace("|", "ez&#02") + "|" + enumerator.Value.ToString().Replace(";", "ez&#01").Replace("|", "ez&#02") + "|";
			}
			text3 = text3.Replace("\"", "'");
			class2.method_4("AdditonalLicenseInformation", text3, "");
			@class.method_0().method_2(class2);
			return @class;
		}

		public byte[] method_3()
		{
			Class18 @class = method_1(bool_63: false, bool_64: false);
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter textWriter_ = new StreamWriter(memoryStream);
			@class.method_1(textWriter_);
			Class7 class2 = new Class7();
			return class2.method_5(memoryStream, bool_13: true);
		}

		public byte[] method_4()
		{
			Class18 @class = method_1(bool_63: true, bool_64: false);
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter textWriter_ = new StreamWriter(memoryStream);
			@class.method_1(textWriter_);
			Class7 class2 = new Class7();
			return class2.method_5(memoryStream, bool_13: true);
		}

		public byte[] method_5()
		{
			Class18 @class = method_1(bool_63: false, bool_64: true);
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter textWriter_ = new StreamWriter(memoryStream);
			@class.method_1(textWriter_);
			Class7 class2 = new Class7();
			return class2.method_5(memoryStream, bool_13: true);
		}

		public byte[] method_6()
		{
			Class18 @class = method_2();
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter textWriter_ = new StreamWriter(memoryStream);
			@class.method_1(textWriter_);
			Class7 class2 = new Class7();
			return class2.method_5(memoryStream, bool_13: true);
		}

		public static byte[] smethod_0(Class18 class18_1)
		{
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter textWriter_ = new StreamWriter(memoryStream);
			class18_1.method_1(textWriter_);
			Class7 @class = new Class7();
			return @class.method_5(memoryStream, bool_13: true);
		}

		public void method_7(string string_26)
		{
			byte[] byte_ = method_6();
			byte_ = method_8(byte_);
			FileStream fileStream = new FileStream(string_26, FileMode.Create, FileAccess.ReadWrite);
			fileStream.Write(byte_, 0, byte_.Length);
			fileStream.Close();
		}

		public byte[] method_8(byte[] byte_2)
		{
			Class18 @class = new Class18();
			Class21 class2 = new Class21("sdtwe4dbutueteretdg4er");
			class2.method_4("ujh45mngsdrt3", Convert.ToBase64String(byte_2), "");
			class2.method_4("kjrwejhjsnbbhherw", Convert.ToBase64String(byte_1), "");
			@class.method_0().method_2(class2);
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter textWriter_ = new StreamWriter(memoryStream);
			@class.method_1(textWriter_);
			Class7 class3 = new Class7();
			return class3.method_5(memoryStream, bool_13: false);
		}

		public void method_9(string string_26)
		{
			byte[] array = method_3();
			FileStream fileStream = new FileStream(string_26, FileMode.Create, FileAccess.ReadWrite);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
		}

		public string method_10(string string_26, string string_27)
		{
			try
			{
				if ((Path.GetDirectoryName(string_27.Replace("<", "").Replace(">", "")).ToUpper() + "\\").IndexOf((Path.GetDirectoryName(string_26) + "\\").ToUpper()) >= 0)
				{
					return string_27.Substring(Path.GetDirectoryName(string_26).Length).Trim('\\');
				}
				return string_27;
			}
			catch
			{
				return string_27;
			}
		}

		public string method_11(string string_26, string string_27)
		{
			try
			{
				if (string_27 != null && string_27.Length > 0 && string_27[0] == '<')
				{
					return string_27;
				}
				if (!Path.IsPathRooted(string_27.Replace("<", "").Replace(">", "")))
				{
					return Path.GetDirectoryName(string_26) + '\\' + string_27;
				}
				return string_27;
			}
			catch
			{
				return string_27;
			}
		}

		public void method_12(string string_26, bool bool_63)
		{
			string text = string_11;
			string text2 = string_0;
			string text3 = string_1;
			string text4 = string_2;
			string text5 = string_5;
			string_7 = string_7.Trim();
			string text6 = string_7;
			if (string_11.Length > 0)
			{
				string_11 = method_10(string_26, string_11);
			}
			if (string_0.Length > 0)
			{
				string_0 = method_10(string_26, string_0);
			}
			if (string_1.Length > 0)
			{
				string_1 = method_10(string_26, string_1);
			}
			if (string_2.Length > 0)
			{
				string_2 = method_10(string_26, string_2);
			}
			if (string_7.Length > 0)
			{
				string_7 = method_10(string_26, string_7);
			}
			if (string_5.Length > 0)
			{
				string_5 = method_10(string_26, string_5);
			}
			if (!bool_63)
			{
				method_1(bool_63: false, bool_64: false).method_2(string_26);
			}
			else
			{
				byte[] array = method_3();
				FileStream fileStream = new FileStream(string_26, FileMode.Create, FileAccess.ReadWrite);
				fileStream.Write(array, 0, array.Length);
				fileStream.Close();
			}
			string_11 = text;
			string_0 = text2;
			string_5 = text5;
			string_7 = text6;
			string_1 = text3;
			string_2 = text4;
		}

		public void method_13(Class18 class18_1)
		{
			Class21 @class = class18_1.method_0().method_1("General_Settings");
			bool_0 = bool.Parse(@class.method_1("General_Loading_Screen_Enable"));
			try
			{
				if (@class.method_1("General_V3Mode") != null)
				{
					bool_3 = bool.Parse(@class.method_1("General_V3Mode"));
				}
				else
				{
					bool_3 = false;
				}
			}
			catch
			{
				bool_3 = false;
			}
			try
			{
				if (@class.method_1("General_VistaAdmin") != null)
				{
					bool_4 = bool.Parse(@class.method_1("General_VistaAdmin"));
				}
				else
				{
					bool_4 = false;
				}
			}
			catch
			{
				bool_4 = false;
			}
			try
			{
				if (@class.method_1("General_Exception_Catching") != null)
				{
					bool_1 = bool.Parse(@class.method_1("General_Exception_Catching"));
				}
				else
				{
					bool_1 = true;
				}
			}
			catch
			{
				bool_1 = true;
			}
			try
			{
				if (@class.method_1("General_Internalization") != null)
				{
					bool_2 = bool.Parse(@class.method_1("General_Internalization"));
				}
				else
				{
					bool_2 = false;
				}
			}
			catch
			{
				bool_2 = false;
			}
			string_0 = "";
			try
			{
				if (@class.method_1("SPC_File") != null)
				{
					string_1 = @class.method_1("SPC_File");
				}
				else
				{
					string_1 = "";
				}
			}
			catch
			{
				string_1 = "";
			}
			try
			{
				if (@class.method_1("PVK_File") != null)
				{
					string_2 = @class.method_1("PVK_File");
				}
				else
				{
					string_2 = "";
				}
			}
			catch
			{
				string_2 = "";
			}
			try
			{
				if (@class.method_1("PVK_Password") != null)
				{
					string_3 = @class.method_1("PVK_Password");
				}
				else
				{
					string_3 = "";
				}
			}
			catch
			{
				string_3 = "";
			}
			if (@class.method_1("General_App_Console") != null)
			{
				EefhdpdQkZ = bool.Parse(@class.method_1("General_App_Console"));
			}
			else
			{
				EefhdpdQkZ = false;
			}
			if (@class.method_1("General_RequestHID") != null)
			{
				bool_31 = bool.Parse(@class.method_1("General_RequestHID"));
			}
			else
			{
				bool_31 = false;
			}
			try
			{
				if (@class.method_1("General_Lib_Necrobit") != null)
				{
					wxihsNeeOp = bool.Parse(@class.method_1("General_Lib_Necrobit"));
				}
				else
				{
					wxihsNeeOp = true;
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("General_Mono_Mode") != null)
				{
					bool_6 = bool.Parse(@class.method_1("General_Mono_Mode"));
				}
				else
				{
					bool_6 = false;
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("General_AdditionalFilesOwnDirectory") != null)
				{
					bool_7 = bool.Parse(@class.method_1("General_AdditionalFilesOwnDirectory"));
				}
				else
				{
					bool_7 = false;
				}
			}
			catch
			{
				bool_7 = false;
			}
			try
			{
				if (@class.method_1("General_Lib_Obfuscation") != null)
				{
					bool_8 = bool.Parse(@class.method_1("General_Lib_Obfuscation"));
				}
				else
				{
					bool_8 = true;
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("General_Lib_Merge") != null)
				{
					bool_9 = bool.Parse(@class.method_1("General_Lib_Merge"));
				}
				else
				{
					bool_9 = false;
				}
			}
			catch
			{
				bool_9 = false;
			}
			try
			{
				if (@class.method_1("General_Lib_MergeAttr") != null)
				{
					bool_10 = bool.Parse(@class.method_1("General_Lib_MergeAttr"));
				}
				else
				{
					bool_10 = true;
				}
			}
			catch
			{
				bool_10 = true;
			}
			try
			{
				if (@class.method_1("General_Lib_Pack") != null)
				{
					bool_11 = bool.Parse(@class.method_1("General_Lib_Pack"));
				}
				else
				{
					bool_11 = false;
				}
			}
			catch
			{
				bool_11 = false;
			}
			try
			{
				if (@class.method_1("General_NAT_Merge") != null)
				{
					bool_12 = bool.Parse(@class.method_1("General_NAT_Merge"));
				}
				else
				{
					bool_12 = false;
				}
			}
			catch
			{
				bool_12 = false;
			}
			try
			{
				if (@class.method_1("General_NATCOMP_Merge") != null)
				{
					bool_13 = bool.Parse(@class.method_1("General_NATCOMP_Merge"));
				}
				else
				{
					bool_13 = false;
				}
			}
			catch
			{
				bool_13 = false;
			}
			try
			{
				if (@class.method_1("General_STRONGPRO") != null)
				{
					bool_14 = bool.Parse(@class.method_1("General_STRONGPRO"));
				}
				else
				{
					bool_14 = false;
				}
			}
			catch
			{
				bool_14 = false;
			}
			try
			{
				if (@class.method_1("General_PatchPRO") != null)
				{
					bool_15 = bool.Parse(@class.method_1("General_PatchPRO"));
				}
				else
				{
					bool_15 = false;
				}
			}
			catch
			{
				bool_15 = false;
			}
			try
			{
				if (@class.method_1("General_ResourcePRO") != null)
				{
					bool_16 = bool.Parse(@class.method_1("General_ResourcePRO"));
				}
				else
				{
					bool_16 = false;
				}
			}
			catch
			{
				bool_16 = false;
			}
			try
			{
				if (@class.method_1("General_NativeApp") != null)
				{
					bool_17 = bool.Parse(@class.method_1("General_NativeApp"));
				}
				else
				{
					bool_17 = false;
				}
			}
			catch
			{
				bool_17 = false;
			}
			try
			{
				if (@class.method_1("General_NativeAppPDB") != null)
				{
					bool_18 = bool.Parse(@class.method_1("General_NativeAppPDB"));
				}
				else
				{
					bool_18 = false;
				}
			}
			catch
			{
				bool_18 = false;
			}
			try
			{
				if (@class.method_1("General_Prejit") != null)
				{
					bool_19 = bool.Parse(@class.method_1("General_Prejit"));
				}
				else
				{
					bool_19 = false;
				}
			}
			catch
			{
				bool_19 = false;
			}
			try
			{
				if (@class.method_1("SuppressILDASM") != null)
				{
					bool_20 = bool.Parse(@class.method_1("SuppressILDASM"));
				}
				else
				{
					bool_20 = true;
				}
			}
			catch
			{
				bool_20 = true;
			}
			try
			{
				if (@class.method_1("General_Obfuscate_Serializable_Types") != null)
				{
					bool_21 = bool.Parse(@class.method_1("General_Obfuscate_Serializable_Types"));
				}
				else
				{
					bool_21 = true;
				}
			}
			catch
			{
				bool_21 = true;
			}
			try
			{
				if (@class.method_1("General_IgnoreInternalsVisible") != null)
				{
					bool_32 = bool.Parse(@class.method_1("General_IgnoreInternalsVisible"));
				}
				else
				{
					bool_32 = false;
				}
			}
			catch
			{
				bool_32 = false;
			}
			try
			{
				if (@class.method_1("General_Lib_MappingFile") != null)
				{
					bool_22 = bool.Parse(@class.method_1("General_Lib_MappingFile"));
				}
				else
				{
					bool_22 = false;
				}
			}
			catch
			{
				bool_22 = false;
			}
			try
			{
				if (@class.method_1("General_Obfuscate_Public_Items") != null)
				{
					bool_23 = bool.Parse(@class.method_1("General_Obfuscate_Public_Items"));
				}
				else
				{
					bool_23 = false;
				}
			}
			catch
			{
				bool_23 = false;
			}
			try
			{
				if (@class.method_1("General_Obfuscate_ShortStrings") != null)
				{
					bool_24 = bool.Parse(@class.method_1("General_Obfuscate_ShortStrings"));
				}
				else
				{
					bool_24 = false;
				}
			}
			catch
			{
				bool_24 = false;
			}
			try
			{
				if (@class.method_1("General_Obfuscate_SingleNamespace") != null)
				{
					bool_25 = bool.Parse(@class.method_1("General_Obfuscate_SingleNamespace"));
				}
				else
				{
					bool_25 = false;
				}
			}
			catch
			{
				bool_25 = false;
			}
			try
			{
				if (@class.method_1("General_Obfuscate_AllParams") != null)
				{
					bool_26 = bool.Parse(@class.method_1("General_Obfuscate_AllParams"));
				}
				else
				{
					bool_26 = false;
				}
			}
			catch
			{
				bool_26 = false;
			}
			try
			{
				if (@class.method_1("General_AntiILDASM_MD") != null)
				{
					bool_27 = bool.Parse(@class.method_1("General_AntiILDASM_MD"));
				}
				else
				{
					bool_27 = true;
				}
			}
			catch
			{
				bool_27 = true;
			}
			try
			{
				if (@class.method_1("General_Control_Flow_Obfuscation") != null)
				{
					bool_28 = bool.Parse(@class.method_1("General_Control_Flow_Obfuscation"));
				}
				else
				{
					bool_28 = false;
				}
			}
			catch
			{
				bool_28 = false;
			}
			try
			{
				if (@class.method_1("General_Control_Flow_Obfuscation_Level") != null)
				{
					int_0 = Convert.ToInt32(@class.method_1("General_Control_Flow_Obfuscation_Level"));
				}
				else
				{
					int_0 = 9;
				}
			}
			catch
			{
				int_0 = 9;
			}
			try
			{
				if (@class.method_1("General_Lib_Obfuscation_Unprintable_Characters") != null)
				{
					bool_29 = bool.Parse(@class.method_1("General_Lib_Obfuscation_Unprintable_Characters"));
				}
				else
				{
					bool_29 = false;
				}
			}
			catch
			{
				bool_29 = false;
			}
			try
			{
				if (@class.method_1("General_SetCompatibleTextRenderingDefault") != null)
				{
					bool_34 = bool.Parse(@class.method_1("General_SetCompatibleTextRenderingDefault"));
				}
				else
				{
					bool_34 = false;
				}
			}
			catch
			{
				bool_34 = false;
			}
			try
			{
				if (@class.method_1("General_RenderingDefault") != null)
				{
					bool_35 = bool.Parse(@class.method_1("General_RenderingDefault"));
				}
				else
				{
					bool_35 = true;
				}
			}
			catch
			{
				bool_35 = true;
			}
			try
			{
				if (@class.method_1("General_App_VisualStyles") != null)
				{
					bool_5 = bool.Parse(@class.method_1("General_App_VisualStyles"));
				}
				else
				{
					bool_5 = true;
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("General_Lib_String_Encryption") != null)
				{
					bool_30 = bool.Parse(@class.method_1("General_Lib_String_Encryption"));
				}
				else
				{
					bool_30 = true;
				}
			}
			catch
			{
			}
			if (@class.method_1("General_Lib_Native_Protection_License_System") != null)
			{
				bool_36 = bool.Parse(@class.method_1("General_Lib_Native_Protection_License_System"));
			}
			else
			{
				bool_36 = true;
			}
			string_4 = @class.method_1("General_Lib_Native_Satellite_Name");
			string_9 = @class.method_1("General_License_File_Name").Replace("[computername]", Environment.MachineName);
			string_11 = @class.method_1("Assembly_File_Name");
			try
			{
				if (@class.method_1("Assembly_Full_Name") != null)
				{
					string_12 = @class.method_1("Assembly_Full_Name");
				}
				else
				{
					string_12 = "";
				}
			}
			catch
			{
				string_12 = "";
			}
			try
			{
				string_10 = @class.method_1("General_PID");
				if (string_10 == null)
				{
					string_10 = "";
				}
			}
			catch
			{
				string_10 = "";
			}
			try
			{
				if (@class.method_1("PFX_Password") != null)
				{
					string_13 = @class.method_1("PFX_Password");
				}
				else
				{
					string_13 = "";
				}
			}
			catch
			{
				string_13 = "";
			}
			try
			{
				if (@class.method_1("Sha1StampServer") != null)
				{
					string_14 = @class.method_1("Sha1StampServer");
				}
				else
				{
					string_14 = "http://timestamp.verisign.com/scripts/timstamp.dll";
				}
			}
			catch
			{
				string_14 = "http://timestamp.verisign.com/scripts/timstamp.dll";
			}
			try
			{
				if (@class.method_1("Sha256StampServer") != null)
				{
					string_15 = @class.method_1("Sha256StampServer");
				}
				else
				{
					string_15 = "http://timestamp.geotrust.com/tsa";
				}
			}
			catch
			{
				string_15 = "http://timestamp.geotrust.com/tsa";
			}
			string_5 = @class.method_1("General_Lib_Strong_Name_Key_Pair");
			try
			{
				string_7 = @class.method_1("General_Target_FileName");
				if (string_7 == null)
				{
					string_7 = "";
				}
			}
			catch
			{
				string_7 = "";
			}
			try
			{
				string_6 = @class.method_1("General_Obfuscate_ConstantNamespace");
				if (string_6 == null)
				{
					string_6 = "";
				}
			}
			catch
			{
				string_6 = "";
			}
			bool_33 = bool.Parse(@class.method_1("General_Lib_Remove_Resources"));
			if (@class.method_1("General_Compressor") != null && @class.method_1("General_Compressor").Length > 0)
			{
				bool_37 = bool.Parse(@class.method_1("General_Compressor"));
			}
			class15_0.method_1(@class.method_1("MasterKey"));
			string_8 = @class.method_1("ImageRuntimeVersion");
			string text = @class.method_1("AdditonalLicenseInformation");
			string[] array = text.Split('|');
			for (int i = 0; i < array.Length / 2; i++)
			{
				hashtable_0.Add(array[i * 2].Replace("ez&#01", ";").Replace("ez&#02", "|"), array[i * 2 + 1].Replace("ez&#01", ";").Replace("ez&#02", "|"));
			}
			bool_62 = bool.Parse(@class.method_1("General_Protection_Type_Enable"));
			@class = class18_1.method_0().method_1("Lock_Settings");
			try
			{
				if (@class.method_1("Lock_Close_Process_After_Expiration") != null)
				{
					bool_53 = bool.Parse(@class.method_1("Lock_Close_Process_After_Expiration"));
				}
				else
				{
					bool_53 = true;
				}
			}
			catch
			{
				bool_53 = true;
			}
			try
			{
				if (@class.method_1("Lock_Run_Another_Process_After_Expiration") != null)
				{
					string_16 = @class.method_1("Lock_Run_Another_Process_After_Expiration");
				}
			}
			catch
			{
				string_16 = "";
			}
			bool_40 = bool.Parse(@class.method_1("Lock_Snag_Screen_Enable"));
			bool_42 = bool.Parse(@class.method_1("Lock_Expiration_Screen_Enable"));
			bool_55 = bool_42;
			bool_56 = bool_42;
			bool_54 = bool_42;
			try
			{
				if (@class.method_1("Dialogs_Number_Of_Uses_Enabled") != null)
				{
					bool_55 = bool.Parse(@class.method_1("Dialogs_Number_Of_Uses_Enabled"));
				}
				else
				{
					bool_55 = bool_42;
				}
			}
			catch
			{
				bool_55 = bool_42;
			}
			try
			{
				if (@class.method_1("Not_Found_Screen_Enable") != null)
				{
					bool_41 = bool.Parse(@class.method_1("Not_Found_Screen_Enable"));
				}
				else
				{
					bool_41 = true;
				}
			}
			catch
			{
				bool_41 = true;
			}
			try
			{
				if (@class.method_1("Dialogs_Expiration_Date_Enabled") != null)
				{
					bool_56 = bool.Parse(@class.method_1("Dialogs_Expiration_Date_Enabled"));
				}
				else
				{
					bool_56 = bool_42;
				}
			}
			catch
			{
				bool_56 = bool_42;
			}
			try
			{
				if (@class.method_1("Dialogs_Trial_Period_End_Enabled") != null)
				{
					bool_54 = bool.Parse(@class.method_1("Dialogs_Trial_Period_End_Enabled"));
				}
				else
				{
					bool_54 = bool_42;
				}
			}
			catch
			{
				bool_54 = bool_42;
			}
			try
			{
				if (@class.method_1("Lock_Max_Processes_Exceeded_Screen_Enable") != null)
				{
					bool_43 = bool.Parse(@class.method_1("Lock_Max_Processes_Exceeded_Screen_Enable"));
				}
				else
				{
					bool_43 = true;
				}
			}
			catch
			{
				bool_43 = true;
			}
			if (@class.method_1("Run_Without_License_File") != null)
			{
				bool_38 = bool.Parse(@class.method_1("Run_Without_License_File"));
			}
			else
			{
				bool_38 = true;
			}
			try
			{
				if (@class.method_1("Expiration_Behaviour_ALL") != null)
				{
					bool_39 = bool.Parse(@class.method_1("Expiration_Behaviour_ALL"));
				}
				else
				{
					bool_39 = true;
				}
			}
			catch
			{
				bool_39 = true;
			}
			if (@class.method_1("Lock_License_Enable") != null)
			{
				bool_44 = bool.Parse(@class.method_1("Lock_License_Enable"));
			}
			else
			{
				bool_44 = false;
			}
			if (@class.method_1("Lock_Expiration_Date_Enable") != null)
			{
				bool_44 = bool.Parse(@class.method_1("Lock_Expiration_Date_Enable"));
			}
			else
			{
				bool_44 = false;
			}
			bool_45 = false;
			if (@class.method_1("License_Hardware_Enable") != null)
			{
				KfyOgavDjY = bool.Parse(@class.method_1("License_Hardware_Enable"));
			}
			else
			{
				KfyOgavDjY = false;
			}
			if (@class.method_1("License_Expiration_Date_Enable") != null)
			{
				bool_60 = bool.Parse(@class.method_1("License_Expiration_Date_Enable"));
			}
			else
			{
				bool_60 = false;
			}
			if (@class.method_1("License_Evaluation_Enable") != null)
			{
				bool_61 = bool.Parse(@class.method_1("License_Evaluation_Enable"));
			}
			else
			{
				bool_61 = false;
			}
			try
			{
				if (@class.method_1("License_Evaluation_Type") != null)
				{
					enum9_1 = (Enum9)Enum.Parse(typeof(Enum9), @class.method_1("License_Evaluation_Type"));
				}
			}
			catch
			{
			}
			bool_52 = bool.Parse(@class.method_1("Lock_Evaluation_Enable"));
			try
			{
				if (@class.method_1("Lock_Hardware_HDD") != null)
				{
					bool_46 = bool.Parse(@class.method_1("Lock_Hardware_HDD"));
				}
				else
				{
					bool_46 = false;
				}
			}
			catch
			{
				bool_46 = false;
			}
			try
			{
				if (@class.method_1("Lock_Hardware_MAC") != null)
				{
					bool_47 = bool.Parse(@class.method_1("Lock_Hardware_MAC"));
				}
				else
				{
					bool_47 = true;
				}
			}
			catch
			{
				bool_47 = true;
			}
			try
			{
				if (@class.method_1("Lock_Hardware_BOARD") != null)
				{
					bool_48 = bool.Parse(@class.method_1("Lock_Hardware_BOARD"));
				}
				else
				{
					bool_48 = true;
				}
			}
			catch
			{
				bool_48 = true;
			}
			try
			{
				if (@class.method_1("Lock_Hardware_CPU") != null)
				{
					bool_49 = bool.Parse(@class.method_1("Lock_Hardware_CPU"));
				}
				else
				{
					bool_49 = true;
				}
			}
			catch
			{
				bool_49 = true;
			}
			try
			{
				if (@class.method_1("Lock_Number_Of_Uses_Enable") != null)
				{
					bool_50 = bool.Parse(@class.method_1("Lock_Number_Of_Uses_Enable"));
				}
				else
				{
					bool_50 = false;
				}
			}
			catch
			{
				bool_50 = false;
			}
			try
			{
				if (@class.method_1("Lock_Max_Number_Of_Processes_Enable") != null)
				{
					bool_51 = bool.Parse(@class.method_1("Lock_Max_Number_Of_Processes_Enable"));
				}
				else
				{
					bool_51 = false;
				}
			}
			catch
			{
				bool_51 = false;
			}
			try
			{
				if (@class.method_1("License_Number_Of_Uses_Enable") != null)
				{
					bool_57 = bool.Parse(@class.method_1("License_Number_Of_Uses_Enable"));
				}
				else
				{
					bool_57 = false;
				}
			}
			catch
			{
				bool_57 = false;
			}
			try
			{
				if (@class.method_1("License_Global_Licensing_Behaviour") != null)
				{
					bool_58 = bool.Parse(@class.method_1("License_Global_Licensing_Behaviour"));
				}
				else
				{
					bool_58 = true;
				}
			}
			catch
			{
				bool_58 = true;
			}
			try
			{
				if (@class.method_1("License_Max_Number_Of_Processes_Enable") != null)
				{
					bool_59 = bool.Parse(@class.method_1("License_Max_Number_Of_Processes_Enable"));
				}
				else
				{
					bool_59 = false;
				}
			}
			catch
			{
				bool_59 = false;
			}
			if (@class.method_1("Lock_Evaluation_Type") == "Trial_Days")
			{
				enum9_0 = Enum9.Trial_Days;
			}
			else
			{
				enum9_0 = Enum9.Runtime_Minutes;
			}
			int_3 = Convert.ToInt32(@class.method_1("Lock_Evaluation_Time"));
			try
			{
				if (@class.method_1("License_Evaluation_Time") != null)
				{
					int_7 = Convert.ToInt32(@class.method_1("License_Evaluation_Time"));
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("Lock_Number_Of_Uses") != null)
				{
					int_4 = Convert.ToInt32(@class.method_1("Lock_Number_Of_Uses"));
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("Lock_Number_Of_Processes") != null)
				{
					int_1 = Convert.ToInt32(@class.method_1("Lock_Number_Of_Processes"));
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("Lock_Nag_XDays_Before_Expiration") != null)
				{
					int_2 = Convert.ToInt32(@class.method_1("Lock_Nag_XDays_Before_Expiration"));
				}
				else
				{
					int_2 = -1;
				}
			}
			catch
			{
				int_2 = -1;
			}
			try
			{
				if (@class.method_1("License_Number_Of_Uses") != null)
				{
					int_5 = Convert.ToInt32(@class.method_1("License_Number_Of_Uses"));
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("License_Number_Of_Processes") != null)
				{
					int_6 = Convert.ToInt32(@class.method_1("License_Number_Of_Processes"));
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("Lock_Expiration_Date") != null)
				{
					string value = @class.method_1("Lock_Expiration_Date").Substring(0, 4);
					string value2 = @class.method_1("Lock_Expiration_Date").Substring(4, 2);
					string value3 = @class.method_1("Lock_Expiration_Date").Substring(6, 2);
					dateTime_0 = new DateTime(Convert.ToInt32(value), Convert.ToInt32(value2), Convert.ToInt32(value3));
				}
			}
			catch
			{
			}
			try
			{
				if (@class.method_1("License_Expiration_Date") != null)
				{
					string value4 = @class.method_1("License_Expiration_Date").Substring(0, 4);
					string value5 = @class.method_1("License_Expiration_Date").Substring(4, 2);
					string value6 = @class.method_1("License_Expiration_Date").Substring(6, 2);
					dateTime_1 = new DateTime(Convert.ToInt32(value4), Convert.ToInt32(value5), Convert.ToInt32(value6));
				}
			}
			catch
			{
			}
			@class = class18_1.method_0().method_1("Dialogs");
			string_17 = @class.method_1("Dialogs_Caption");
			try
			{
				string_25 = @class.method_1("License_HardwareID_2");
				if (string_25 == null)
				{
					string_25 = "####-####-####-####-####";
				}
			}
			catch
			{
				string_25 = "####-####-####-####-####";
			}
			try
			{
				string_18 = @class.method_1("CustomizeMessageBox");
				if (string_18 == null)
				{
					string_18 = "";
				}
			}
			catch
			{
				string_18 = "";
			}
			string_19 = @class.method_1("Dialogs_License_Expired");
			string_20 = @class.method_1("Dialogs_SnagScreen");
			try
			{
				if (@class.method_1("Dialogs_Invalid_License").ToString().Length > 0)
				{
					string_21 = @class.method_1("Dialogs_Invalid_License");
				}
			}
			catch
			{
			}
			string_22 = @class.method_1("Dialogs_Trial_Period_End");
			try
			{
				if (@class.method_1("Dialogs_Number_Of_Uses").ToString().Length > 0)
				{
					string_23 = @class.method_1("Dialogs_Number_Of_Uses");
				}
			}
			catch
			{
				string_23 = string_22;
			}
			try
			{
				if (@class.method_1("Dialogs_Max_Processes_Exceeded").ToString().Length > 0)
				{
					string_24 = @class.method_1("Dialogs_Max_Processes_Exceeded");
				}
			}
			catch
			{
			}
			color_0 = Class8.smethod_8(@class.method_1("Dialogs_Gradient_Color_Begin"));
			color_1 = Class8.smethod_8(@class.method_1("Dialogs_Gradient_Color_End"));
		}

		public void method_14(Class18 class18_1)
		{
			Class21 @class = class18_1.method_0().method_1("License_Settings");
			try
			{
				if (@class.method_1("Lock_License_Enable") != null && @class.method_1("Lock_License_Enable").Length > 0)
				{
					bool_60 = bool.Parse(@class.method_1("Lock_License_Enable"));
				}
			}
			catch
			{
				bool_60 = false;
			}
			try
			{
				if (@class.method_1("Lock_License_Expiration_Date") != null)
				{
					string value = @class.method_1("Lock_License_Expiration_Date").Substring(0, 4);
					string value2 = @class.method_1("Lock_License_Expiration_Date").Substring(4, 2);
					string value3 = @class.method_1("Lock_License_Expiration_Date").Substring(6, 2);
					dateTime_1 = new DateTime(Convert.ToInt32(value), Convert.ToInt32(value2), Convert.ToInt32(value3));
				}
			}
			catch
			{
			}
			class15_0.method_1(@class.method_1("MasterKey"));
			try
			{
				if (@class.method_1("License_Hardware_Enable") != null)
				{
					KfyOgavDjY = bool.Parse(@class.method_1("License_Hardware_Enable"));
				}
				else
				{
					KfyOgavDjY = false;
				}
			}
			catch
			{
				KfyOgavDjY = false;
			}
			try
			{
				if (@class.method_1("Lock_Hardware_HDD") != null)
				{
					bool_46 = bool.Parse(@class.method_1("Lock_Hardware_HDD"));
				}
				else
				{
					bool_46 = false;
				}
			}
			catch
			{
				bool_46 = false;
			}
			try
			{
				if (@class.method_1("Lock_Hardware_MAC") != null)
				{
					bool_47 = bool.Parse(@class.method_1("Lock_Hardware_MAC"));
				}
				else
				{
					bool_47 = true;
				}
			}
			catch
			{
				bool_47 = true;
			}
			try
			{
				if (@class.method_1("Lock_Hardware_BOARD") != null)
				{
					bool_48 = bool.Parse(@class.method_1("Lock_Hardware_BOARD"));
				}
				else
				{
					bool_48 = true;
				}
			}
			catch
			{
				bool_48 = true;
			}
			try
			{
				if (@class.method_1("Lock_Hardware_CPU") != null)
				{
					bool_49 = bool.Parse(@class.method_1("Lock_Hardware_CPU"));
				}
				else
				{
					bool_49 = true;
				}
			}
			catch
			{
				bool_49 = true;
			}
			try
			{
				if (@class.method_1("License_Evaluation_Enable") != null)
				{
					bool_61 = bool.Parse(@class.method_1("License_Evaluation_Enable"));
				}
				else
				{
					bool_61 = false;
				}
			}
			catch
			{
				bool_61 = false;
			}
			try
			{
				if (@class.method_1("License_Evaluation_Type") != null)
				{
					enum9_1 = (Enum9)Enum.Parse(typeof(Enum9), @class.method_1("License_Evaluation_Type"));
				}
				else
				{
					enum9_1 = Enum9.Trial_Days;
				}
			}
			catch
			{
				enum9_1 = Enum9.Trial_Days;
			}
			try
			{
				if (@class.method_1("License_Evaluation_Time") != null)
				{
					int_7 = Convert.ToInt32(@class.method_1("License_Evaluation_Time"));
				}
				else
				{
					int_7 = 1;
				}
			}
			catch
			{
				int_7 = 1;
			}
			try
			{
				if (@class.method_1("License_Number_Of_Uses_Enable") != null)
				{
					bool_57 = bool.Parse(@class.method_1("License_Number_Of_Uses_Enable"));
				}
				else
				{
					bool_57 = false;
				}
			}
			catch
			{
				bool_57 = false;
			}
			try
			{
				if (@class.method_1("License_Global_Licensing_Behaviour") != null)
				{
					bool_58 = bool.Parse(@class.method_1("License_Global_Licensing_Behaviour"));
				}
				else
				{
					bool_58 = true;
				}
			}
			catch
			{
				bool_58 = true;
			}
			if (!bool_58)
			{
				byte_0 = Convert.FromBase64String(@class.method_1("License_Individual_Key"));
			}
			else
			{
				byte_0 = new Class15().method_4();
			}
			try
			{
				if (@class.method_1("License_Max_Number_Of_Processes_Enable") != null)
				{
					bool_59 = bool.Parse(@class.method_1("License_Max_Number_Of_Processes_Enable"));
				}
				else
				{
					bool_59 = false;
				}
			}
			catch
			{
				bool_59 = false;
			}
			try
			{
				if (@class.method_1("License_Number_Of_Uses") != null)
				{
					int_5 = Convert.ToInt32(@class.method_1("License_Number_Of_Uses"));
				}
				else
				{
					int_5 = 1;
				}
			}
			catch
			{
				int_5 = 1;
			}
			try
			{
				if (@class.method_1("License_Number_Of_Processes") != null)
				{
					int_6 = Convert.ToInt32(@class.method_1("License_Number_Of_Processes"));
				}
				else
				{
					int_6 = 5;
				}
			}
			catch
			{
				int_6 = 5;
			}
			try
			{
				string_25 = @class.method_1("License_HardwareID_2");
			}
			catch
			{
				string_25 = "";
			}
			try
			{
				class18_0 = null;
				if (@class.method_1("License_HardwareID") != null)
				{
					string text = @class.method_1("License_HardwareID");
					byte[] array = new byte[text.Length / 3];
					for (int i = 0; i < array.Length; i++)
					{
						string value4 = text.Substring(i * 3, 3);
						array[i] = Convert.ToByte(value4);
					}
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(array, 0, array.Length);
					memoryStream.Position = 0L;
					class18_0 = new Class18(memoryStream);
				}
			}
			catch
			{
			}
			try
			{
				hashtable_0.Clear();
				string text2 = @class.method_1("AdditonalLicenseInformation");
				string[] array2 = text2.Split('|');
				for (int j = 0; j < array2.Length / 2; j++)
				{
					hashtable_0.Add(array2[j * 2].Replace("ez&#01", ";").Replace("ez&#02", "|"), array2[j * 2 + 1].Replace("ez&#01", ";").Replace("ez&#02", "|"));
				}
			}
			catch
			{
			}
		}

		public void method_15(byte[] byte_2)
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_2, 0, byte_2.Length);
			Class7 @class = new Class7();
			byte[] array = @class.method_10(memoryStream, bool_13: true);
			MemoryStream memoryStream2 = new MemoryStream(array.Length);
			memoryStream2.Position = 0L;
			memoryStream2.Write(array, 0, array.Length);
			memoryStream2.Position = 0L;
			Class18 class18_ = new Class18(memoryStream2);
			memoryStream2.Close();
			method_13(class18_);
		}

		public void method_16(string string_26)
		{
			FileStream fileStream = new FileStream(string_26, FileMode.Open, FileAccess.Read);
			fileStream.Position = 0L;
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			byte[] array2 = array;
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(array2, 0, array2.Length);
			Class7 @class = new Class7();
			byte[] array3 = @class.method_10(memoryStream, bool_13: true);
			MemoryStream memoryStream2 = new MemoryStream(array3.Length);
			memoryStream2.Position = 0L;
			memoryStream2.Write(array3, 0, array3.Length);
			memoryStream2.Position = 0L;
			Class18 class18_ = new Class18(memoryStream2);
			memoryStream2.Close();
			method_13(class18_);
			if (string_11.Length > 0)
			{
				string_11 = method_11(string_26, string_11);
			}
			if (string_0.Length > 0)
			{
				string_0 = method_11(string_26, string_0);
			}
			if (string_1.Length > 0)
			{
				string_1 = method_11(string_26, string_1);
			}
			if (string_2.Length > 0)
			{
				string_2 = method_11(string_26, string_2);
			}
			if (string_5.Length > 0)
			{
				string_5 = method_11(string_26, string_5);
			}
			if (string_7.Length > 0)
			{
				string_7 = method_11(string_26, string_7);
			}
		}

		public void method_17(byte[] byte_2)
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_2, 0, byte_2.Length);
			Class7 @class = new Class7();
			byte[] array = @class.method_10(memoryStream, bool_13: true);
			MemoryStream memoryStream2 = new MemoryStream(array.Length);
			memoryStream2.Position = 0L;
			memoryStream2.Write(array, 0, array.Length);
			memoryStream2.Position = 0L;
			Class18 class18_ = new Class18(memoryStream2);
			memoryStream2.Close();
			method_13(class18_);
		}

		public void method_18(byte[] byte_2, bool bool_63, Class26 class26_0)
		{
			if (bool_63)
			{
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(byte_2, 0, byte_2.Length);
				Class7 @class = new Class7();
				byte[] array = @class.method_10(memoryStream, bool_13: true);
				MemoryStream memoryStream2 = new MemoryStream(array.Length);
				memoryStream2.Position = 0L;
				memoryStream2.Write(array, 0, array.Length);
				memoryStream2.Position = 0L;
				Class18 class2 = new Class18(memoryStream2);
				memoryStream2.Close();
				Class21 class3 = class2.method_0().method_1("sdtwe4dbutueteretdg4er");
				byte[] byte_3 = Convert.FromBase64String(class3.method_1("ujh45mngsdrt3"));
				byte[] byte_4 = Convert.FromBase64String(class3.method_1("kjrwejhjsnbbhherw"));
				if (Class15.smethod_1(class26_0.class15_0.method_8(), byte_3, byte_4))
				{
					method_18(byte_3, bool_63: false, class26_0);
				}
				else
				{
					if (class15_0 != null && class15_0.method_8() != null)
					{
						class15_0.method_8().Clear();
					}
					class15_0 = new Class15();
				}
				bool_3 = bool_63;
			}
			else
			{
				MemoryStream memoryStream3 = new MemoryStream();
				memoryStream3.Write(byte_2, 0, byte_2.Length);
				Class7 class4 = new Class7();
				byte[] array2 = class4.method_10(memoryStream3, bool_13: true);
				MemoryStream memoryStream4 = new MemoryStream(array2.Length);
				memoryStream4.Position = 0L;
				memoryStream4.Write(array2, 0, array2.Length);
				memoryStream4.Position = 0L;
				Class18 class18_ = new Class18(memoryStream4);
				memoryStream4.Close();
				method_14(class18_);
				bool_3 = bool_63;
			}
		}

		public Class18 method_19(byte[] byte_2)
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_2, 0, byte_2.Length);
			Class7 @class = new Class7();
			byte[] array = @class.method_10(memoryStream, bool_13: true);
			MemoryStream memoryStream2 = new MemoryStream(array.Length);
			memoryStream2.Position = 0L;
			memoryStream2.Write(array, 0, array.Length);
			memoryStream2.Position = 0L;
			return new Class18(memoryStream2);
		}

		public void method_20(string string_26, bool bool_63, Class26 class26_0)
		{
			try
			{
				FileStream fileStream = new FileStream(string_26, FileMode.Open, FileAccess.Read);
				fileStream.Position = 0L;
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Close();
				method_18(array, bool_63, class26_0);
			}
			catch
			{
				if (class15_0 != null && class15_0.method_8() != null)
				{
					class15_0.method_8().Clear();
				}
				class15_0 = new Class15();
			}
		}

		public void method_21(byte[] byte_2, bool bool_63, Class26 class26_0)
		{
			try
			{
				method_18(byte_2, bool_63, class26_0);
			}
			catch
			{
				if (class15_0 != null && class15_0.method_8() != null)
				{
					class15_0.method_8().Clear();
				}
				class15_0 = new Class15();
			}
		}

		public Class18 method_22(string string_26)
		{
			FileStream fileStream = new FileStream(string_26, FileMode.Open, FileAccess.Read);
			fileStream.Position = 0L;
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			return method_19(array);
		}

		public void method_23(string string_26)
		{
			method_13(new Class18(string_26));
			if (string_11.Length > 0)
			{
				string_11 = method_11(string_26, string_11);
			}
			if (string_0.Length > 0)
			{
				string_0 = method_11(string_26, string_0);
			}
			if (string_1.Length > 0)
			{
				string_1 = method_11(string_26, string_1);
			}
			if (string_2.Length > 0)
			{
				string_2 = method_11(string_26, string_2);
			}
			if (string_5.Length > 0)
			{
				string_5 = method_11(string_26, string_5);
			}
			if (string_7.Length > 0)
			{
				string_7 = method_11(string_26, string_7);
			}
		}
	}

	private string string_0 = "";

	private string string_1 = "";

	private string string_2 = "";

	private string string_3 = "";

	private static string string_4;

	private static bool bool_0;

	private static string string_5;

	private static bool bool_1;

	private static string string_6;

	private static bool qpAoxUaaMo;

	private static string string_7;

	private static bool bool_2;

	private static string string_8;

	private static bool bool_3;

	private static string string_9;

	private static bool bool_4;

	private static string string_10;

	private static bool bool_5;

	private static string string_11;

	private static bool bool_6;

	private static string string_12;

	private static bool bool_7;

	private static string string_13;

	private static bool bool_8;

	private static string string_14;

	private static bool bool_9;

	private static string string_15;

	private static bool bool_10;

	private static string string_16;

	private static bool bool_11;

	private static string string_17;

	private static bool bool_12;

	internal void method_0()
	{
		string text = "{12211-22232-40001-0123}";
		if (text.Length == 12)
		{
			text += "c";
		}
	}

	public Class7()
	{
		string_0 = "kl§$%7ghJ/()3w45ZZHW$5$%&gwSADF2";
		string_2 = "sd§5$§&g457!23nm";
		string_1 = "($)(/)()=fg55jm,§98*jgt65=§C33$t";
		string_3 = "g&5§$§7!s3nm42d5";
	}

	public byte[] method_1(string string_18, bool bool_13)
	{
		FileStream fileStream = new FileStream(string_18, FileMode.Open, FileAccess.Read, FileShare.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		fileStream.Close();
		return method_5(memoryStream, bool_13);
	}

	public void method_2(string string_18, string string_19)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_18);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(bytes, 0, bytes.Length);
		byte[] array = method_5(memoryStream, bool_13: true);
		Directory.CreateDirectory(Path.GetDirectoryName(string_19));
		FileStream fileStream = new FileStream(string_19, FileMode.Create, FileAccess.ReadWrite);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
	}

	public string method_3(string string_18)
	{
		FileStream fileStream = new FileStream(string_18, FileMode.Open, FileAccess.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		byte[] array2 = method_10(memoryStream, bool_13: true);
		return Encoding.Unicode.GetString(array2, 0, array2.Length);
	}

	public byte[] method_4(string string_18, byte[] byte_0)
	{
		FileStream fileStream = new FileStream(string_18, FileMode.Open, FileAccess.Read, FileShare.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		return method_12(array, byte_0);
	}

	public byte[] method_5(MemoryStream memoryStream_0, bool bool_13)
	{
		int num = 0;
		try
		{
			string text = string_0;
			string text2 = string_2;
			if (bool_13)
			{
				text = string_1;
				text2 = string_3;
			}
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			byte[] array2 = new byte[text2.Length];
			for (int j = 0; j < text2.Length; j++)
			{
				array2[j] = Convert.ToByte(text2[j]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(array, array2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] array3 = memoryStream_0.ToArray();
			cryptoStream.Write(array3, 0, array3.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch (Exception ex)
		{
			try
			{
				MessageBox.Show("Encryption Error " + num + " " + ex.ToString());
			}
			catch
			{
			}
		}
		return new byte[1];
	}

	public byte[] method_6(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		int num = 0;
		try
		{
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(byte_2, byte_1);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch (Exception ex)
		{
			try
			{
				MessageBox.Show("Encryption Error " + num + " " + ex.ToString());
			}
			catch
			{
			}
		}
		return new byte[1];
	}

	public byte[] method_7(byte[] byte_0, bool bool_13)
	{
		int num = 0;
		try
		{
			string text = string_0;
			string text2 = string_2;
			if (bool_13)
			{
				text = string_1;
				text2 = string_3;
			}
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			byte[] array2 = new byte[text2.Length];
			for (int j = 0; j < text2.Length; j++)
			{
				array2[j] = Convert.ToByte(text2[j]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(array, array2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch (Exception ex)
		{
			try
			{
				MessageBox.Show("Encryption Error " + num + " " + ex.ToString());
			}
			catch
			{
			}
		}
		return new byte[1];
	}

	public byte[] method_8(MemoryStream memoryStream_0, byte[] byte_0, bool bool_13)
	{
		int num = 0;
		try
		{
			string text = string_2;
			if (bool_13)
			{
				text = string_3;
			}
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(byte_0, array);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] array2 = memoryStream_0.ToArray();
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch (Exception ex)
		{
			try
			{
				MessageBox.Show("Encryption Error " + num + " " + ex.ToString());
			}
			catch
			{
			}
		}
		return new byte[1];
	}

	public byte[] method_9(string string_18, bool bool_13)
	{
		FileStream fileStream = new FileStream(string_18, FileMode.Open, FileAccess.Read, FileShare.Read);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		fileStream.Close();
		return method_10(memoryStream, bool_13);
	}

	public byte[] method_10(MemoryStream memoryStream_0, bool bool_13)
	{
		try
		{
			string text = string_0;
			string text2 = string_2;
			if (bool_13)
			{
				text = string_1;
				text2 = string_3;
			}
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			byte[] array2 = new byte[text2.Length];
			for (int j = 0; j < text2.Length; j++)
			{
				array2[j] = Convert.ToByte(text2[j]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array, array2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] array3 = memoryStream_0.ToArray();
			cryptoStream.Write(array3, 0, array3.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch
		{
		}
		return new byte[1];
	}

	public byte[] method_11(MemoryStream memoryStream_0, byte[] byte_0, bool bool_13)
	{
		try
		{
			string text = string_2;
			if (bool_13)
			{
				text = string_3;
			}
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(byte_0, array);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] array2 = memoryStream_0.ToArray();
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch
		{
		}
		return new byte[1];
	}

	public byte[] method_12(byte[] byte_0, byte[] byte_1)
	{
		try
		{
			string text = string_2;
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor(byte_1, array);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch
		{
		}
		return new byte[1];
	}

	public byte[] method_13(MemoryStream memoryStream_0, byte[] byte_0)
	{
		try
		{
			string text = string_2;
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(byte_0, array);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] array2 = memoryStream_0.ToArray();
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return result;
		}
		catch
		{
		}
		return new byte[1];
	}

	public MemoryStream method_14(MemoryStream memoryStream_0, bool bool_13)
	{
		try
		{
			string text = string_0;
			string text2 = string_2;
			if (bool_13)
			{
				text = string_1;
				text2 = string_3;
			}
			byte[] array = new byte[text.Length];
			for (int i = 0; i < text.Length; i++)
			{
				array[i] = Convert.ToByte(text[i]);
			}
			byte[] array2 = new byte[text2.Length];
			for (int j = 0; j < text2.Length; j++)
			{
				array2[j] = Convert.ToByte(text2[j]);
			}
			SymmetricAlgorithm symmetricAlgorithm = Class2.SuhhReBcy();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array, array2);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] array3 = memoryStream_0.ToArray();
			cryptoStream.Write(array3, 0, array3.Length);
			cryptoStream.FlushFinalBlock();
			memoryStream.Close();
			cryptoStream.Close();
			return memoryStream;
		}
		catch
		{
		}
		return null;
	}

	public byte[] method_15()
	{
		Class18 @class = new Class18();
		ManagementClass managementClass = new ManagementClass("Win32_BIOS");
		ManagementObjectCollection instances = managementClass.GetInstances();
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
		{
			if (managementObjectEnumerator.MoveNext())
			{
				ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
				Class21 class2 = new Class21("BIOS");
				if (managementObject.Properties["Manufacturer"].Value != null)
				{
					class2.method_4("Manufacturer", managementObject.Properties["Manufacturer"].Value.ToString(), "");
				}
				else
				{
					class2.method_4("Manufacturer", "", "");
				}
				if (managementObject.Properties["Version"].Value != null)
				{
					class2.method_4("Version", managementObject.Properties["Version"].Value.ToString(), "");
				}
				else
				{
					class2.method_4("Version", "", "");
				}
				if (managementObject.Properties["SMBIOSBIOSVersion"].Value != null)
				{
					class2.method_4("SMBIOSBIOSVersion", managementObject.Properties["SMBIOSBIOSVersion"].Value.ToString(), "");
				}
				else
				{
					class2.method_4("SMBIOSBIOSVersion", "", "");
				}
				@class.method_0().method_2(class2);
			}
		}
		managementClass = new ManagementClass("Win32_BaseBoard");
		instances = managementClass.GetInstances();
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator2 = instances.GetEnumerator())
		{
			if (managementObjectEnumerator2.MoveNext())
			{
				ManagementObject managementObject2 = (ManagementObject)managementObjectEnumerator2.Current;
				Class21 class3 = new Class21("BOARD");
				if (managementObject2.Properties["Manufacturer"].Value != null)
				{
					class3.method_4("Manufacturer", managementObject2.Properties["Manufacturer"].Value.ToString(), "");
				}
				else
				{
					class3.method_4("Manufacturer", "", "");
				}
				@class.method_0().method_2(class3);
			}
		}
		managementClass = new ManagementClass("Win32_Processor");
		instances = managementClass.GetInstances();
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator3 = instances.GetEnumerator())
		{
			if (managementObjectEnumerator3.MoveNext())
			{
				ManagementObject managementObject3 = (ManagementObject)managementObjectEnumerator3.Current;
				Class21 class4 = new Class21("PROCESSOR");
				if (managementObject3.Properties["Manufacturer"].Value != null)
				{
					class4.method_4("Manufacturer", managementObject3.Properties["Manufacturer"].Value.ToString(), "");
				}
				else
				{
					class4.method_4("Manufacturer", "", "");
				}
				if (managementObject3.Properties["Name"].Value != null)
				{
					class4.method_4("Name", managementObject3.Properties["Name"].Value.ToString(), "");
				}
				else
				{
					class4.method_4("Name", "", "");
				}
				if (managementObject3.Properties["ProcessorId"].Value != null)
				{
					class4.method_4("ProcessorId", managementObject3.Properties["ProcessorId"].Value.ToString(), "");
				}
				else
				{
					class4.method_4("ProcessorId", "", "");
				}
				@class.method_0().method_2(class4);
			}
		}
		MemoryStream memoryStream = new MemoryStream();
		StreamWriter textWriter_ = new StreamWriter(memoryStream);
		@class.method_1(textWriter_);
		return memoryStream.ToArray();
	}

	public static string smethod_0(string string_18)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_18);
		HashAlgorithm hashAlgorithm = null;
		try
		{
			hashAlgorithm = new SHA256CryptoServiceProvider();
		}
		catch
		{
			hashAlgorithm = SHA256.Create();
		}
		byte[] byte_ = hashAlgorithm.ComputeHash(bytes);
		return smethod_32(byte_);
	}

	public static byte[] smethod_1(string string_18)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_18);
		HashAlgorithm hashAlgorithm = null;
		try
		{
			hashAlgorithm = new SHA256CryptoServiceProvider();
		}
		catch
		{
			hashAlgorithm = SHA256.Create();
		}
		return hashAlgorithm.ComputeHash(bytes);
	}

	public static byte[] smethod_2(string string_18)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_18);
		Array.Reverse(bytes);
		HashAlgorithm hashAlgorithm = null;
		try
		{
			hashAlgorithm = new SHA256CryptoServiceProvider();
		}
		catch
		{
			hashAlgorithm = SHA256.Create();
		}
		return hashAlgorithm.ComputeHash(bytes);
	}

	public static string smethod_3(string string_18)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_18);
		HashAlgorithm hashAlgorithm = null;
		try
		{
			hashAlgorithm = new SHA256CryptoServiceProvider();
		}
		catch
		{
			hashAlgorithm = SHA256.Create();
		}
		byte[] inArray = hashAlgorithm.ComputeHash(bytes);
		return Convert.ToBase64String(inArray);
	}

	public static void smethod_4(string string_18)
	{
		Class18 class18_ = smethod_29();
		byte[] array = Class26.smethod_0(class18_);
		FileStream fileStream = new FileStream(string_18, FileMode.Create, FileAccess.ReadWrite);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
	}

	internal static string smethod_5(bool bool_13, bool bool_14, bool bool_15, bool bool_16)
	{
		string text = "";
		if (bool_13)
		{
			text = smethod_17();
		}
		if (bool_14)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_19();
		}
		if (bool_15)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_21();
		}
		if (bool_16)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_18();
		}
		return text;
	}

	internal static string smethod_6(bool bool_13, bool bool_14, bool bool_15, bool bool_16)
	{
		string text = "";
		if (bool_13)
		{
			text = smethod_15();
		}
		if (bool_14)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_19();
		}
		if (bool_15)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_21();
		}
		if (bool_16)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_18();
		}
		return text;
	}

	internal static string smethod_7(bool bool_13, bool bool_14, bool bool_15, bool bool_16)
	{
		string text = "";
		if (bool_13)
		{
			text = smethod_17();
		}
		if (bool_14)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_20();
		}
		if (bool_15)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_22();
		}
		if (bool_16)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_15();
		}
		return text;
	}

	internal static string smethod_8(bool bool_13, bool bool_14, bool bool_15, bool bool_16)
	{
		string text = "";
		if (bool_13)
		{
			text = smethod_17();
		}
		if (bool_14)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_20();
		}
		if (bool_15)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_22();
		}
		if (bool_16)
		{
			if (text.Length > 0)
			{
				text += "-";
			}
			text += smethod_12();
		}
		return text;
	}

	internal static string smethod_9(bool bool_13, bool bool_14, bool bool_15, bool bool_16)
	{
		string text = "";
		RSACryptoServiceProvider.UseMachineKeyStore = true;
		if (bool_13)
		{
			byte[] array = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_17()));
			text += array[3].ToString("X2");
			text = text + array[11].ToString("X2") + "-";
		}
		else
		{
			text = "85C1-";
		}
		if (bool_14)
		{
			byte[] array2 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_20()));
			text += array2[3].ToString("X2");
			text = text + array2[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array3 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array3[15].ToString("X2");
			text = text + array3[7].ToString("X2") + "-";
		}
		if (bool_15)
		{
			byte[] array4 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_22()));
			text += array4[3].ToString("X2");
			text = text + array4[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array5 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array5[2].ToString("X2");
			text = text + array5[14].ToString("X2") + "-";
		}
		if (bool_16)
		{
			byte[] array6 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_13()));
			text += array6[3].ToString("X2");
			text = text + array6[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array7 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array7[1].ToString("X2");
			text = text + array7[9].ToString("X2") + "-";
		}
		byte[] array8 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
		text += array8[1].ToString("X2");
		return text + array8[9].ToString("X2");
	}

	internal static string smethod_10(bool bool_13, bool bool_14, bool bool_15, bool bool_16)
	{
		string text = "";
		RSACryptoServiceProvider.UseMachineKeyStore = true;
		if (bool_13)
		{
			byte[] array = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_17()));
			text += array[3].ToString("X2");
			text = text + array[11].ToString("X2") + "-";
		}
		else
		{
			text = "85C1-";
		}
		if (bool_14)
		{
			byte[] array2 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_20()));
			text += array2[3].ToString("X2");
			text = text + array2[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array3 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array3[15].ToString("X2");
			text = text + array3[7].ToString("X2") + "-";
		}
		if (bool_15)
		{
			byte[] array4 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_22()));
			text += array4[3].ToString("X2");
			text = text + array4[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array5 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array5[2].ToString("X2");
			text = text + array5[14].ToString("X2") + "-";
		}
		if (bool_16)
		{
			byte[] array6 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_16()));
			text += array6[3].ToString("X2");
			text = text + array6[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array7 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array7[1].ToString("X2");
			text = text + array7[9].ToString("X2") + "-";
		}
		byte[] array8 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
		text += array8[1].ToString("X2");
		return text + array8[9].ToString("X2");
	}

	internal static string smethod_11(bool bool_13, bool bool_14, bool bool_15, bool bool_16)
	{
		string text = "";
		RSACryptoServiceProvider.UseMachineKeyStore = true;
		if (bool_13)
		{
			byte[] array = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_17()));
			text += array[3].ToString("X2");
			text = text + array[11].ToString("X2") + "-";
		}
		else
		{
			text = "85C1-";
		}
		if (bool_14)
		{
			byte[] array2 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_20()));
			text += array2[3].ToString("X2");
			text = text + array2[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array3 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array3[15].ToString("X2");
			text = text + array3[7].ToString("X2") + "-";
		}
		if (bool_15)
		{
			byte[] array4 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_22()));
			text += array4[3].ToString("X2");
			text = text + array4[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array5 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array5[2].ToString("X2");
			text = text + array5[14].ToString("X2") + "-";
		}
		if (bool_16)
		{
			byte[] array6 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(smethod_14()));
			text += array6[3].ToString("X2");
			text = text + array6[11].ToString("X2") + "-";
		}
		else
		{
			byte[] array7 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
			text += array7[1].ToString("X2");
			text = text + array7[9].ToString("X2") + "-";
		}
		byte[] array8 = Class2.BjkXsyRir(Encoding.Unicode.GetBytes(text));
		text += array8[1].ToString("X2");
		return text + array8[9].ToString("X2");
	}

	private static string smethod_12()
	{
		if (!bool_0)
		{
			bool_0 = true;
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("Win32_DiskDrive");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					try
					{
						if (!(text == string.Empty) || item.Properties["PnPDeviceID"] == null || item.Properties["PnPDeviceID"].Value == null)
						{
							continue;
						}
						text = item.Properties["PnPDeviceID"].Value.ToString();
						if (text.Length > 0 && text.IndexOf("USBSTOR") >= 0)
						{
							text = "";
						}
						if (item.Properties["MediaType"] != null && item.Properties["MediaType"].Value != null && item.Properties["MediaType"].Value.ToString().ToUpper().IndexOf("REMOVABLE") >= 0)
						{
							text = "";
						}
						if (item.Properties["InterfaceType"] != null && item.Properties["InterfaceType"].Value != null)
						{
							if (item.Properties["InterfaceType"].Value.ToString() == "USB")
							{
								text = "";
							}
							if (item.Properties["InterfaceType"].Value.ToString() == "1394")
							{
								text = "";
							}
						}
						if (text.Length == 0)
						{
							text = string.Empty;
							continue;
						}
						break;
					}
					catch
					{
					}
				}
				if (text == string.Empty)
				{
					text = "";
				}
				string_4 = text;
				if (string_4.Length > 0)
				{
					string[] array = string_4.Split('\\');
					string_4 = array[array.Length - 1];
				}
			}
			catch
			{
				string_4 = "";
			}
		}
		return string_4;
	}

	private static string smethod_13()
	{
		if (!bool_1)
		{
			bool_1 = true;
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("Win32_DiskDrive");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					try
					{
						if (!(text == string.Empty) || item.Properties["PnPDeviceID"] == null || item.Properties["PnPDeviceID"].Value == null)
						{
							continue;
						}
						text = item.Properties["PnPDeviceID"].Value.ToString();
						if (text.Length > 0 && text.IndexOf("USBSTOR") >= 0)
						{
							text = "";
						}
						if (item.Properties["InterfaceType"] != null && item.Properties["InterfaceType"].Value != null)
						{
							if (item.Properties["InterfaceType"].Value.ToString() == "USB")
							{
								text = "";
							}
							if (item.Properties["InterfaceType"].Value.ToString() == "1394")
							{
								text = "";
							}
						}
						if (text.Length == 0)
						{
							text = string.Empty;
							continue;
						}
						break;
					}
					catch
					{
					}
				}
				if (text == string.Empty)
				{
					text = "";
				}
				string_5 = text;
				if (string_5.Length > 0)
				{
					string[] array = string_5.Split('\\');
					string_5 = array[array.Length - 1];
				}
			}
			catch
			{
				string_5 = "";
			}
		}
		return string_5;
	}

	private static string smethod_14()
	{
		if (qpAoxUaaMo)
		{
			return string_6;
		}
		qpAoxUaaMo = true;
		try
		{
			ArrayList arrayList = new ArrayList();
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				if (item["DeviceID"] == null || item["InterfaceType"] == null || !(item["InterfaceType"].ToString() != "USB") || !(item["InterfaceType"].ToString() != "1394"))
				{
					continue;
				}
				bool flag = true;
				if (item["MediaType"] != null && item["MediaType"].ToString() == "Removable Media")
				{
					flag = false;
				}
				if (!flag)
				{
					continue;
				}
				if (item["SerialNumber"] != null)
				{
					object obj = item["SerialNumber"];
					if (obj != null && !(obj.ToString().Trim() == string.Empty) && obj.ToString()[0] != Convert.ToChar(31))
					{
						string_6 = obj.ToString().Trim();
						return string_6;
					}
				}
				arrayList.Add(item["DeviceID"].ToString());
			}
			managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (string item2 in arrayList)
			{
				foreach (ManagementObject item3 in managementObjectCollection)
				{
					if (item3["Tag"] == null)
					{
						continue;
					}
					string text2 = item3["Tag"].ToString();
					if (text2 == item2 && item3["SerialNumber"] != null)
					{
						object obj2 = item3["SerialNumber"];
						if (obj2 != null && !(obj2.ToString() == string.Empty) && obj2.ToString()[0] != Convert.ToChar(31))
						{
							string_6 = obj2.ToString().Trim().Replace(" ", "");
							return string_6;
						}
						break;
					}
				}
			}
		}
		catch
		{
			string_6 = "";
		}
		return "";
	}

	private static string smethod_15()
	{
		if (!bool_2)
		{
			bool_2 = true;
			try
			{
				string_7 = Class14.smethod_0();
			}
			catch
			{
				string_7 = "failure-failure";
			}
		}
		return string_7;
	}

	private static string smethod_16()
	{
		if (bool_3)
		{
			return string_8;
		}
		bool_3 = true;
		try
		{
			ArrayList arrayList = new ArrayList();
			foreach (ManagementObject item in new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
			{
				if (item["DeviceID"] != null && item["InterfaceType"] != null && item["InterfaceType"].ToString() != "USB" && item["InterfaceType"].ToString() != "1394")
				{
					arrayList.Add(item["DeviceID"].ToString());
				}
			}
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia").Get();
			foreach (string item2 in arrayList)
			{
				foreach (ManagementObject item3 in managementObjectCollection)
				{
					if (item3["Tag"] != null && item3["Tag"].ToString() == item2 && item3["SerialNumber"] != null)
					{
						object obj = item3["SerialNumber"];
						if (obj != null && !(obj.ToString() == string.Empty) && obj.ToString()[0] != Convert.ToChar(31))
						{
							string_8 = obj.ToString().Trim();
							return string_8;
						}
						break;
					}
				}
			}
		}
		catch
		{
			string_8 = "";
		}
		return "";
	}

	private static string smethod_17()
	{
		if (!bool_4)
		{
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("Win32_Processor");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					if (!(text == string.Empty))
					{
						continue;
					}
					try
					{
						text = item.Properties["ProcessorId"].Value.ToString();
						if (text.Length == 0)
						{
							text = string.Empty;
							continue;
						}
					}
					catch
					{
						continue;
					}
					break;
				}
				string_9 = text;
			}
			catch
			{
			}
			bool_4 = true;
		}
		if (string_9 == string.Empty)
		{
			string_9 = "";
		}
		return string_9;
	}

	private static string smethod_18()
	{
		if (!bool_5)
		{
			string text = string.Empty;
			try
			{
				if (text == string.Empty)
				{
					ManagementClass managementClass = new ManagementClass("Win32_PhysicalMedia");
					ManagementObjectCollection instances = managementClass.GetInstances();
					foreach (ManagementObject item in instances)
					{
						if (!(text == string.Empty))
						{
							continue;
						}
						try
						{
							string text2 = item.Properties["SerialNumber"].Value.ToString();
							text = text2;
							if (text.Length == 0)
							{
								text = string.Empty;
								continue;
							}
						}
						catch
						{
							continue;
						}
						break;
					}
				}
			}
			catch
			{
			}
			string_10 = text;
			bool_5 = true;
		}
		if (string_10 == string.Empty)
		{
			string_10 = "";
		}
		return string_10;
	}

	private static string smethod_19()
	{
		if (!bool_6)
		{
			try
			{
				string text = string.Empty;
				ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
				ManagementObjectCollection instances = managementClass.GetInstances();
				foreach (ManagementObject item in instances)
				{
					if (!(text == string.Empty))
					{
						break;
					}
					try
					{
						if (item["IPEnabled"] != null && (bool)item["IPEnabled"] && item["MacAddress"] != null)
						{
							text = item["MacAddress"].ToString();
							text = text.Replace(":", "");
						}
					}
					catch
					{
					}
				}
				string_11 = text;
			}
			catch
			{
			}
			bool_6 = true;
		}
		if (string_11 == string.Empty)
		{
			string_11 = "";
		}
		return string_11;
	}

	private static string smethod_20()
	{
		if (!bool_7)
		{
			try
			{
				string text = Class13.smethod_0();
				if (text.Length == 0)
				{
					text = string.Empty;
					ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
					ManagementObjectCollection instances = managementClass.GetInstances();
					foreach (ManagementObject item in instances)
					{
						if (!(text == string.Empty))
						{
							break;
						}
						try
						{
							if (item["IPEnabled"] != null && (bool)item["IPEnabled"] && item["MacAddress"] != null && item["MacAddress"].ToString().Length > 0)
							{
								text = item["MacAddress"].ToString().ToUpper();
								text = text.Replace(":", "");
							}
						}
						catch
						{
						}
					}
				}
				string_12 = text;
			}
			catch
			{
			}
			bool_7 = true;
		}
		if (string_12 == string.Empty)
		{
			string_12 = "";
		}
		return string_12;
	}

	private static string smethod_21()
	{
		if (!bool_8)
		{
			try
			{
				string_13 = smethod_23() + "-" + smethod_25();
			}
			catch
			{
			}
			bool_8 = true;
		}
		if (string_13 == string.Empty)
		{
			string_13 = "";
		}
		return string_13;
	}

	private static string smethod_22()
	{
		if (!bool_9)
		{
			try
			{
				string_14 = smethod_23() + "-" + smethod_25() + "-" + smethod_27();
			}
			catch
			{
			}
			bool_9 = true;
		}
		if (string_14 == string.Empty)
		{
			string_14 = "";
		}
		return string_14;
	}

	private static string smethod_23()
	{
		if (!bool_10)
		{
			string_15 = smethod_24();
			bool_10 = true;
		}
		return string_15;
	}

	private static string smethod_24()
	{
		try
		{
			string text = string.Empty;
			ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementObject item in instances)
			{
				try
				{
					if (item.Properties["Product"] != null && item.Properties["Product"].Value != null && text == string.Empty)
					{
						text = item.Properties["Product"].Value.ToString();
						if (text.Length != 0)
						{
							break;
						}
						text = string.Empty;
					}
				}
				catch
				{
				}
			}
			if (text == string.Empty)
			{
				text = "";
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private static string smethod_25()
	{
		if (!bool_11)
		{
			string_16 = smethod_26();
			bool_11 = true;
		}
		return string_16;
	}

	private static string smethod_26()
	{
		try
		{
			string text = string.Empty;
			ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementObject item in instances)
			{
				try
				{
					if (text == string.Empty && item.Properties["Manufacturer"] != null && item.Properties["Manufacturer"].Value != null)
					{
						text = item.Properties["Manufacturer"].Value.ToString();
						if (text.Length != 0)
						{
							break;
						}
						text = string.Empty;
					}
				}
				catch
				{
				}
			}
			if (text == string.Empty)
			{
				text = "";
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	private static string smethod_27()
	{
		if (!bool_12)
		{
			string_17 = smethod_28();
			bool_12 = true;
		}
		return string_17;
	}

	private static string smethod_28()
	{
		try
		{
			string text = string.Empty;
			ManagementClass managementClass = new ManagementClass("Win32_BaseBoard");
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementObject item in instances)
			{
				try
				{
					if (text == string.Empty && item.Properties["SerialNumber"] != null && item.Properties["SerialNumber"].Value != null)
					{
						text = item.Properties["SerialNumber"].Value.ToString();
						if (text.Length != 0)
						{
							break;
						}
						text = string.Empty;
					}
				}
				catch
				{
				}
			}
			if (text == string.Empty)
			{
				text = "";
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	internal static Class18 smethod_29()
	{
		Class18 @class = new Class18();
		ManagementObjectCollection managementObjectCollection = null;
		ManagementClass managementClass = null;
		try
		{
			managementClass = new ManagementClass("Win32_BIOS");
			managementObjectCollection = managementClass.GetInstances();
			using ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectCollection.GetEnumerator();
			if (managementObjectEnumerator.MoveNext())
			{
				ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
				Class21 class2 = new Class21("BIOS");
				if (managementObject.Properties["Manufacturer"].Value != null)
				{
					class2.method_4("Manufacturer", managementObject.Properties["Manufacturer"].Value.ToString(), "");
				}
				else
				{
					class2.method_4("Manufacturer", "", "");
				}
				if (managementObject.Properties["Version"].Value != null)
				{
					class2.method_4("Version", managementObject.Properties["Version"].Value.ToString(), "");
				}
				else
				{
					class2.method_4("Version", "", "");
				}
				if (managementObject.Properties["SMBIOSBIOSVersion"].Value != null)
				{
					class2.method_4("SMBIOSBIOSVersion", managementObject.Properties["SMBIOSBIOSVersion"].Value.ToString(), "");
				}
				else
				{
					class2.method_4("SMBIOSBIOSVersion", "", "");
				}
				@class.method_0().method_2(class2);
			}
		}
		catch
		{
		}
		try
		{
			managementClass = new ManagementClass("Win32_BaseBoard");
			managementObjectCollection = managementClass.GetInstances();
			using ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator2 = managementObjectCollection.GetEnumerator();
			if (managementObjectEnumerator2.MoveNext())
			{
				ManagementObject managementObject2 = (ManagementObject)managementObjectEnumerator2.Current;
				Class21 class3 = new Class21("BOARD");
				if (managementObject2.Properties["Manufacturer"].Value != null)
				{
					class3.method_4("Manufacturer", managementObject2.Properties["Manufacturer"].Value.ToString(), "");
				}
				else
				{
					class3.method_4("Manufacturer", "", "");
				}
				@class.method_0().method_2(class3);
			}
		}
		catch
		{
		}
		try
		{
			managementClass = new ManagementClass("Win32_Processor");
			managementObjectCollection = managementClass.GetInstances();
			using ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator3 = managementObjectCollection.GetEnumerator();
			if (managementObjectEnumerator3.MoveNext())
			{
				ManagementObject managementObject3 = (ManagementObject)managementObjectEnumerator3.Current;
				Class21 class4 = new Class21("PROCESSOR");
				if (managementObject3.Properties["Manufacturer"].Value != null)
				{
					class4.method_4("Manufacturer", managementObject3.Properties["Manufacturer"].Value.ToString(), "");
				}
				else
				{
					class4.method_4("Manufacturer", "", "");
				}
				if (managementObject3.Properties["Name"].Value != null)
				{
					class4.method_4("Name", managementObject3.Properties["Name"].Value.ToString(), "");
				}
				else
				{
					class4.method_4("Name", "", "");
				}
				if (managementObject3.Properties["ProcessorId"].Value != null)
				{
					class4.method_4("ProcessorId", managementObject3.Properties["ProcessorId"].Value.ToString(), "");
				}
				else
				{
					class4.method_4("ProcessorId", "", "");
				}
				@class.method_0().method_2(class4);
			}
		}
		catch
		{
		}
		return @class;
	}

	public string method_16()
	{
		byte[] array = method_15();
		string text = "";
		for (int i = 0; i < array.Length; i++)
		{
			text += array[i].ToString("D3");
		}
		return text;
	}

	public static string smethod_30(DateTime dateTime_0)
	{
		return smethod_32(new byte[4]
		{
			Convert.ToByte(dateTime_0.Year.ToString("D4").Substring(0, 2)),
			Convert.ToByte(dateTime_0.Year.ToString("D4").Substring(2, 2)),
			Convert.ToByte(dateTime_0.Month),
			Convert.ToByte(dateTime_0.Day)
		});
	}

	public static DateTime smethod_31(string string_18)
	{
		byte[] array = new byte[string_18.Length / 3];
		for (int i = 0; i < string_18.Length / 3; i++)
		{
			array[i] = Convert.ToByte(string_18.Substring(i * 3, 3));
		}
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		memoryStream.Position = 0L;
		Class7 @class = new Class7();
		array = @class.method_10(memoryStream, bool_13: true);
		return new DateTime(Convert.ToInt32(array[0].ToString("D2") + array[1].ToString("D2")), array[2], array[3]);
	}

	public static string xJloReQpSk(byte[] byte_0)
	{
		string text = "";
		for (int i = 0; i < byte_0.Length; i++)
		{
			text += byte_0[i].ToString("D3");
		}
		return text;
	}

	public static string smethod_32(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Position = 0L;
		Class7 @class = new Class7();
		return xJloReQpSk(@class.method_5(memoryStream, bool_13: true));
	}

	public static string smethod_33(string string_18, byte[] byte_0)
	{
		byte[] array = new byte[string_18.Length];
		for (int i = 0; i < string_18.Length; i++)
		{
			array[i] = Convert.ToByte(string_18[i]);
		}
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		memoryStream.Position = 0L;
		Class7 @class = new Class7();
		byte[] inArray = @class.method_8(memoryStream, byte_0, bool_13: true);
		return smethod_3(Convert.ToBase64String(inArray));
	}

	public static string smethod_34(string string_18, byte[] byte_0)
	{
		byte[] array = new byte[string_18.Length];
		for (int i = 0; i < string_18.Length; i++)
		{
			array[i] = Convert.ToByte(string_18[i]);
		}
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		memoryStream.Position = 0L;
		Class7 @class = new Class7();
		byte[] inArray = @class.method_8(memoryStream, byte_0, bool_13: true);
		return Convert.ToBase64String(inArray);
	}

	public static string smethod_35(string string_18, byte[] byte_0)
	{
		byte[] array = Convert.FromBase64String(string_18);
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		memoryStream.Position = 0L;
		Class7 @class = new Class7();
		byte[] array2 = @class.method_11(memoryStream, byte_0, bool_13: true);
		string text = "";
		for (int i = 0; i < array2.Length; i++)
		{
			text += (char)array2[i];
		}
		return text;
	}

	public static string nKroQvIwGh(string string_18)
	{
		byte[] array = new byte[string_18.Length];
		for (int i = 0; i < string_18.Length; i++)
		{
			array[i] = Convert.ToByte(string_18[i]);
		}
		return smethod_32(array);
	}

	public static string smethod_36(string string_18)
	{
		byte[] array = new byte[string_18.Length / 3];
		for (int i = 0; i < string_18.Length / 3; i++)
		{
			array[i] = Convert.ToByte(string_18.Substring(i * 3, 3));
		}
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(array, 0, array.Length);
		memoryStream.Position = 0L;
		Class7 @class = new Class7();
		array = @class.method_10(memoryStream, bool_13: true);
		string text = "";
		for (int j = 0; j < array.Length; j++)
		{
			text += Convert.ToChar(array[j]);
		}
		return text;
	}

	static Class7()
	{
		string_4 = "";
		bool_0 = false;
		string_5 = "";
		bool_1 = false;
		string_6 = "";
		qpAoxUaaMo = false;
		string_7 = "";
		bool_2 = false;
		string_8 = "";
		bool_3 = false;
		string_9 = "";
		bool_4 = false;
		string_10 = "";
		bool_5 = false;
		string_11 = "";
		bool_6 = false;
		string_12 = "";
		bool_7 = false;
		string_13 = "";
		bool_8 = false;
		string_14 = "";
		bool_9 = false;
		string_15 = "";
		bool_10 = false;
		string_16 = "";
		bool_11 = false;
		string_17 = "";
		bool_12 = false;
	}
}
