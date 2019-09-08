using System.ComponentModel;
using System.Reflection;

namespace QD.Components.Semantic
{
	internal static class Extensions
	{
		internal static string GetDescription(this object @object)
		{
			FieldInfo fieldInfo = @object.GetType().GetField(@object.ToString());
			if (fieldInfo == null) return null;
			DescriptionAttribute description = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
			return description?.Description ?? "no-tengo";
		}
	}
}
