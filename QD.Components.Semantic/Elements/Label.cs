using Microsoft.AspNetCore.Components;
using QD.Components.Semantic.Enums;
using QD.Components.Semantic.Enums.Label;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// A label displays content classification.
	/// </summary>
	public class Label : ComponentBase
	{

		/// <summary>
		/// A label can be active.
		/// </summary>
		[Parameter]
		public bool Active { get; set; }

		/// <summary>
		/// A label can attach to a content segment.
		/// </summary>
		[Parameter]
		public Side Attached { get; set; }

		/// <summary>
		/// A label can reduce its complexity.
		/// </summary>
		[Parameter]
		public bool Basic { get; set; }

		/// <summary>
		/// A label can be circular.
		/// </summary>
		[Parameter]
		public bool Circular { get; set; }

		/// <summary>
		/// Color of the label.
		/// </summary>
		[Parameter]
		public Color Color { get; set; }

		/// <summary>
		/// A label can position itself in the corner of an element.
		/// </summary>
		[Parameter]
		public Corner Corner { get; set; }

		/// <summary>
		/// Formats the label as a dot.
		/// </summary>
		[Parameter]
		public bool Empty { get; set; }

		/// <summary>
		/// Float above another element in the upper right corner.
		/// </summary>
		[Parameter]
		public bool Floating { get; set; }

		/// <summary>
		/// A horizontal label is formatted to label content along-side it horizontally.
		/// </summary>
		[Parameter]
		public bool Horizontal { get; set; }

		/// <summary>
		/// A label can be formatted to emphasize an image.
		/// </summary>
		[Parameter]
		public bool Image { get; set; }

		/// <summary>
		/// A label can point to content next to it.
		/// </summary>
		[Parameter]
		public Direction Pointing { get; set; }

		/// <summary>
		/// A label can prompt for an error in your forms.
		/// </summary>
		[Parameter]
		public bool Prompt { get; set; }

		/// <summary>
		/// A label can appear as a ribbon attaching itself to an element.
		/// </summary>
		[Parameter]
		public Ribbon Ribbon { get; set; }

		/// <summary>
		/// A label can have different sizes.
		/// </summary>
		[Parameter]
		public Size Size { get; set; }

		/// <summary>
		/// A label can appear as a tag.
		/// </summary>
		[Parameter]
		public bool Tag { get; set; }

		/// <inheritdoc />
		protected override void ConfigureComponent()
		{
			ElementClass = "ui";

			if (Color != Color.None)
			{
				ElementClass = $"{ElementClass} {Color.GetDescription()}";
			}

			if (Image)
			{
				ElementClass = $"{ElementClass} image";
			}

			if (Corner != Corner.None)
			{
				ElementClass = $"{ElementClass} {Corner.GetDescription()} corner";
			}

			if (Pointing != Direction.None)
			{
				if (Pointing == Direction.Left || Pointing == Direction.Right)
				{
					ElementClass = $"{ElementClass} {Pointing.GetDescription()} pointing";
				}
				else
				{
					ElementClass = $"{ElementClass} pointing {Pointing.GetDescription()}";
				}
			}

			if (Attached != Side.None)
			{
				ElementClass = $"{ElementClass} {Attached.GetDescription()} attached";
			}

			if (Prompt)
			{
				ElementClass = $"{ElementClass} prompt";
			}

			if (Tag)
			{
				ElementClass = $"{ElementClass} tag";
			}

			if (Ribbon != Ribbon.None)
			{
				ElementClass = Ribbon == Ribbon.Left ? $"{ElementClass} ribbon" : $"{ElementClass} {Ribbon.GetDescription()} ribbon";
			}

			if (Horizontal)
			{
				ElementClass = $"{ElementClass} horizontal";
			}

			if (Floating)
			{
				ElementClass = $"{ElementClass} floating";
			}

			if (Basic)
			{
				ElementClass = $"{ElementClass} basic";
			}

			ElementClass = $"{ElementClass} label";
		}
	}
}
