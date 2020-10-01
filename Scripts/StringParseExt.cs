using System;

namespace Kogane
{
	/// <summary>
	/// string 型の Parse 系の拡張メソッドを管理するクラス
	/// </summary>
	public static class StringParseExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// sbyte 型に変換します
		/// </summary>
		public static sbyte ToSByte( this string s )
		{
			return sbyte.Parse( s );
		}

		/// <summary>
		/// sbyte 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static sbyte? ToSByteOrNull( this string s )
		{
			if ( sbyte.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// sbyte 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static sbyte ToSByteOrDefault( this string s )
		{
			return ToSByteOrDefault( s, default );
		}

		/// <summary>
		/// sbyte 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static sbyte ToSByteOrDefault( this string s, sbyte defaultValue )
		{
			return sbyte.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// sbyte 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsSByte( this string s )
		{
			return sbyte.TryParse( s, out _ );
		}

		/// <summary>
		/// byte 型に変換します
		/// </summary>
		public static byte ToByte( this string s )
		{
			return byte.Parse( s );
		}

		/// <summary>
		/// byte 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static byte? ToByteOrNull( this string s )
		{
			if ( byte.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// byte 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static byte ToByteOrDefault( this string s )
		{
			return ToByteOrDefault( s, default );
		}

		/// <summary>
		/// byte 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static byte ToByteOrDefault( this string s, byte defaultValue )
		{
			return byte.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// byte 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsByte( this string s )
		{
			return byte.TryParse( s, out _ );
		}

		/// <summary>
		/// char 型に変換します
		/// </summary>
		public static char ToChar( this string s )
		{
			return char.Parse( s );
		}

		/// <summary>
		/// char 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static char? ToCharOrNull( this string s )
		{
			if ( char.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// char 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static char ToCharOrDefault( this string s )
		{
			return ToCharOrDefault( s, default );
		}

		/// <summary>
		/// char 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static char ToCharOrDefault( this string s, char defaultValue )
		{
			return char.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// char 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsChar( this string s )
		{
			return char.TryParse( s, out _ );
		}

		/// <summary>
		/// short 型に変換します
		/// </summary>
		public static short ToShort( this string s )
		{
			return short.Parse( s );
		}

		/// <summary>
		/// short 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static short? ToShortOrNull( this string s )
		{
			if ( short.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// short 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static short ToShortOrDefault( this string s )
		{
			return ToShortOrDefault( s, default );
		}

		/// <summary>
		/// short 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static short ToShortOrDefault( this string s, short defaultValue )
		{
			return short.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// short 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsShort( this string s )
		{
			return short.TryParse( s, out _ );
		}

		/// <summary>
		/// ushort 型に変換します
		/// </summary>
		public static ushort ToUShort( this string s )
		{
			return ushort.Parse( s );
		}

		/// <summary>
		/// ushort 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static ushort? ToUShortOrNull( this string s )
		{
			if ( ushort.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// ushort 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static ushort ToUShortOrDefault( this string s )
		{
			return ToUShortOrDefault( s, default );
		}

		/// <summary>
		/// ushort 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static ushort ToUShortOrDefault( this string s, ushort defaultValue )
		{
			return ushort.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// ushort 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsUShort( this string s )
		{
			return ushort.TryParse( s, out _ );
		}

		/// <summary>
		/// int 型に変換します
		/// </summary>
		public static int ToInt( this string s )
		{
			return int.Parse( s );
		}

		/// <summary>
		/// int 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static int? ToIntOrNull( this string s )
		{
			if ( int.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// int 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static int ToIntOrDefault( this string s )
		{
			return ToIntOrDefault( s, default );
		}

		/// <summary>
		/// int 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static int ToIntOrDefault( this string s, int defaultValue )
		{
			return int.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// int 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsInt( this string s )
		{
			return int.TryParse( s, out _ );
		}

		/// <summary>
		/// uint 型に変換します
		/// </summary>
		public static uint ToUInt( this string s )
		{
			return uint.Parse( s );
		}

		/// <summary>
		/// uint 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static uint? ToUIntOrNull( this string s )
		{
			if ( uint.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// uint 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static uint ToUIntOrDefault( this string s )
		{
			return ToUIntOrDefault( s, default );
		}

		/// <summary>
		/// uint 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static uint ToUIntOrDefault( this string s, uint defaultValue )
		{
			return uint.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// uint 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsUInt( this string s )
		{
			return uint.TryParse( s, out _ );
		}

		/// <summary>
		/// long 型に変換します
		/// </summary>
		public static long ToLong( this string s )
		{
			return long.Parse( s );
		}

		/// <summary>
		/// long 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static long? ToLongOrNull( this string s )
		{
			if ( long.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// long 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static long ToLongOrDefault( this string s )
		{
			return ToLongOrDefault( s, default );
		}

		/// <summary>
		/// long 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static long ToLongOrDefault( this string s, long defaultValue )
		{
			return long.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// long 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsLong( this string s )
		{
			return long.TryParse( s, out _ );
		}

		/// <summary>
		/// ulong 型に変換します
		/// </summary>
		public static ulong ToULong( this string s )
		{
			return ulong.Parse( s );
		}

		/// <summary>
		/// ulong 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static ulong? ToULongOrNull( this string s )
		{
			if ( ulong.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// ulong 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static ulong ToULongOrDefault( this string s )
		{
			return ToULongOrDefault( s, default );
		}

		/// <summary>
		/// ulong 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static ulong ToULongOrDefault( this string s, ulong defaultValue )
		{
			return ulong.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// ulong 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsULong( this string s )
		{
			return ulong.TryParse( s, out _ );
		}

		/// <summary>
		/// float 型に変換します
		/// </summary>
		public static float ToFloat( this string s )
		{
			return float.Parse( s );
		}

		/// <summary>
		/// float 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static float? ToFloatOrNull( this string s )
		{
			if ( float.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// float 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static float ToFloatOrDefault( this string s )
		{
			return ToFloatOrDefault( s, default );
		}

		/// <summary>
		/// float 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static float ToFloatOrDefault( this string s, float defaultValue )
		{
			return float.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// float 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsFloat( this string s )
		{
			return float.TryParse( s, out _ );
		}

		/// <summary>
		/// double 型に変換します
		/// </summary>
		public static double ToDouble( this string s )
		{
			return double.Parse( s );
		}

		/// <summary>
		/// double 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static double? ToDoubleOrNull( this string s )
		{
			if ( double.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// double 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static double ToDoubleOrDefault( this string s )
		{
			return ToDoubleOrDefault( s, default );
		}

		/// <summary>
		/// double 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static double ToDoubleOrDefault( this string s, double defaultValue )
		{
			return double.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// double 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsDouble( this string s )
		{
			return double.TryParse( s, out _ );
		}

		/// <summary>
		/// decimal 型に変換します
		/// </summary>
		public static decimal ToDecimal( this string s )
		{
			return decimal.Parse( s );
		}

		/// <summary>
		/// decimal 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static decimal? ToDecimalOrNull( this string s )
		{
			if ( decimal.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// decimal 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static decimal ToDecimalOrDefault( this string s )
		{
			return ToDecimalOrDefault( s, default );
		}

		/// <summary>
		/// decimal 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static decimal ToDecimalOrDefault( this string s, decimal defaultValue )
		{
			return decimal.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// decimal 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsDecimal( this string s )
		{
			return decimal.TryParse( s, out _ );
		}

		/// <summary>
		/// DateTime 型に変換します
		/// </summary>
		public static DateTime ToDateTime( this string s )
		{
			return DateTime.Parse( s );
		}

		/// <summary>
		/// DateTime 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static DateTime? ToDateTimeOrNull( this string s )
		{
			if ( DateTime.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// DateTime 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static DateTime ToDateTimeOrDefault( this string s )
		{
			return ToDateTimeOrDefault( s, default );
		}

		/// <summary>
		/// DateTime 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static DateTime ToDateTimeOrDefault( this string s, DateTime defaultValue )
		{
			return DateTime.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// DateTime 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsDateTime( this string s )
		{
			return DateTime.TryParse( s, out _ );
		}

		/// <summary>
		/// bool 型に変換します
		/// </summary>
		public static bool ToBoolean( this string s )
		{
			return bool.Parse( s );
		}

		/// <summary>
		/// bool 型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static bool? ToBooleanOrNull( this string s )
		{
			if ( bool.TryParse( s, out var result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// bool 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static bool ToBooleanOrDefault( this string s )
		{
			return ToBooleanOrDefault( s, default );
		}

		/// <summary>
		/// bool 型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static bool ToBooleanOrDefault( this string s, bool defaultValue )
		{
			return bool.TryParse( s, out var result ) ? result : defaultValue;
		}

		/// <summary>
		/// bool 型に変換可能かどうかを返します
		/// </summary>
		public static bool IsBoolean( this string s )
		{
			return bool.TryParse( s, out _ );
		}

		/// <summary>
		/// 指定された列挙型に変換します
		/// </summary>
		public static T ToEnum<T>( this string s ) where T : struct
		{
			return ( T ) Enum.Parse( typeof( T ), s );
		}

		/// <summary>
		/// 指定された列挙型に変換します
		/// 変換に失敗した場合は null を返します
		/// </summary>
		public static T? ToEnumOrNull<T>( this string s ) where T : struct
		{
			if ( Enum.TryParse( s, out T result ) )
			{
				return result;
			}

			return null;
		}

		/// <summary>
		/// 指定された列挙型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static T ToEnumOrDefault<T>( this string s ) where T : struct
		{
			return ToEnumOrDefault<T>( s, default );
		}

		/// <summary>
		/// 指定された列挙型に変換します
		/// 変換に失敗した場合は defaultValue を返します
		/// </summary>
		public static T ToEnumOrDefault<T>( this string s, T defaultValue ) where T : struct
		{
			return Enum.TryParse( s, out T result ) ? result : defaultValue;
		}

		/// <summary>
		/// 指定された列挙型に変換可能かどうかを返します
		/// </summary>
		public static bool IsEnum<T>( this string value ) where T : struct
		{
			return Enum.TryParse( value, out T _ );
		}
	}
}
