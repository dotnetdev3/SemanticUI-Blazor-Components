using Microsoft.AspNetCore.Components;
using QD.Components.Semantic.Enums;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// Several icons can be used together as a group.
	/// </summary>
	public class IconGroup : ComponentBase
	{
		/// <summary>
		/// Size of the icon group.
		/// </summary>
		[Parameter]
		public Size Size { get; set; }

		/// <inheritdoc />
		protected override void ConfigureComponent()
		{
			ElementTag = "i";
			ElementClass = Size != Size.None ? $"{Size.GetDescription()} icons" : "icons";
		}
	}
}
