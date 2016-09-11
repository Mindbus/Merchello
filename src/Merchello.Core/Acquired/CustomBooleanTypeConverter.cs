namespace Merchello.Core.Acquired
{
    using System;
    using System.ComponentModel;

    /// <summary>
	/// Allows for converting string representations of 0 and 1 to boolean
	/// </summary>
	/// <remarks>
	/// UMBRACO Direct port of Umbraco internal interface to get rid of hard dependency
	/// </remarks>
	internal class CustomBooleanTypeConverter : BooleanConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == typeof(string))
			{
				return true;
			}

			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
		{
			if (value is string)
			{
				var str = (string)value;
				if (str == null || str.Length == 0 || str == "0") return false;
				if (str == "1") return true;
			}

			return base.ConvertFrom(context, culture, value);
		}
	}
}