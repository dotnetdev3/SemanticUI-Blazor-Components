using Microsoft.AspNetCore.Components;
using QD.Components.Semantic.Enums;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// A label can be grouped.
	/// </summary>
	public class LabelGroup : ComponentBase
	{
		/// <summary>
		/// Labels can share shapes.
		/// </summary>
		[Parameter]
		public bool Circular { get; set; }

		/// <summary>
		/// Label group can share colors together.
		/// </summary>
		[Parameter]
		public Color Color { get; set; }

		/// <summary>
		/// Label group can share sizes together.
		/// </summary>
		[Parameter]
		public Size Size { get; set; }

		/// <summary>
		/// Label group can share tag formatting.
		/// </summary>
		[Parameter]
		public bool Tag { get; set; }

		/// <inheritdoc />
		protected override void ConfigureComponent()
		{
			ElementClass = "ui";

			if (Size != Size.None)
			{
				ElementClass = $"{ElementClass} {Size.GetDescription()}";
			}

			if (Color != Color.None)
			{
				ElementClass = $"{ElementClass} {Color.GetDescription()}";
			}

			if (Tag)
			{
				ElementClass = $"{ElementClass} tag";
			}

			if (Circular)
			{
				ElementClass = $"{ElementClass} circular";
			}

			ElementClass = $"{ElementClass} labels";
		}
	}
}
