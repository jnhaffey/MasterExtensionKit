namespace MasterExtensionKit.Core.Objects.Validations
{
	public static class IsNullExtension
	{
		/// <summary>
		///     Checks if object is null
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static bool IsNull(this object source)
		{
			return source == null;
		}

		/// <summary>
		///     checks if source is null
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
		public static bool IsNull<T>(this T? source) where T : struct
		{
			return !source.HasValue;
		}

		//public static bool IsNull<T>(this T source)


		// System.Data.SqlType Nullable Checks
		//{
		//	if (source is INullable && (source as INullable).IsNull) return true;
		//	var type = typeof(T);
		//	if (type.IsValueType)
		//	{
		//		if (!ReferenceEquals(Nullable.GetUnderlyingType(type), null) && source.GetHashCode() == 0) return true;
		//	}
		//	else
		//	{
		//		if (ReferenceEquals(source, null)) return true;
		//		if (Convert.IsDBNull(source)) return true;
		//	}
		//	return false;
		//}
	}
}