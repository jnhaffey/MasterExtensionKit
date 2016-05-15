namespace MasterExtensionKit.Core.Objects.Validations
{
	/// <summary>
	///     Object Extension Method
	/// </summary>
	public static class IsNullExtension
	{
		/// <summary>
		///     Evaluates if object is null
		/// </summary>
		/// <param name="source">The object source</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsNull(this object source)
		{
			return source == null;
		}

		/// <summary>
		///     Evaluates if object is null
		/// </summary>
		/// <typeparam name="T">Source Type</typeparam>
		/// <param name="source">Generic Nullable source</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsNull<T>(this T? source) where T : struct
		{
			return !source.HasValue;
		}

		// TODO: Future IsNull Check for SQL
		/*
		public static bool IsNull<T>(this T source)
		 System.Data.SqlType Nullable Checks
		{
			if (source is INullable && (source as INullable).IsNull) return true;
			var type = typeof(T);
			if (type.IsValueType)
			{
				if (!ReferenceEquals(Nullable.GetUnderlyingType(type), null) && source.GetHashCode() == 0) return true;
			}
			else
			{
				if (ReferenceEquals(source, null)) return true;
				if (Convert.IsDBNull(source)) return true;
			}
			return false;
		}
		*/
	}
}