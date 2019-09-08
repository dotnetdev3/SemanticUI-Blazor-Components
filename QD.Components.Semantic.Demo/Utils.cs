using System;
using System.ComponentModel;
using System.Reflection;

namespace QD.Components.Semantic.Demo
{
	public static class Utils
	{
		public static T GetEnum<T>(string description)
		{
			Type type = typeof(T);
			if (!type.IsEnum) throw new InvalidOperationException();
			foreach (FieldInfo field in type.GetFields())
			{
				if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
				{
					if (attribute.Description == description)
						return (T)field.GetValue(null);
				}
				else
				{
					if (field.Name == description)
						return (T)field.GetValue(null);
				}
			}
			throw new ArgumentException("Not found.", nameof(description));
		}
	}
}
