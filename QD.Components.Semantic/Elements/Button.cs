using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using QD.Components.Semantic.Enums;
using QD.Components.Semantic.Enums.Button;
using QD.Components.Semantic.Enums.Label;
using Color = QD.Components.Semantic.Enums.Button.Color;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// A Button indicates a possible user action.
	/// </summary>
	public class Button : ComponentBase
	{
		/// <summary>
		/// A button can animate to show hidden content.
		/// </summary>
		[Parameter]
		public Animation Animated { get; set; }

		/// <summary>
		/// A button can be attached to other content.
		/// </summary>
		[Parameter]
		public Side Attached { get; set; }

		/// <summary>
		/// A basic button is less pronounced.
		/// </summary>
		[Parameter]
		public bool Basic { get; set; }

		/// <summary>
		/// A button can be circular.
		/// </summary>
		[Parameter]
		public bool Circular { get; set; }

		/// <summary>
		/// A button can have different colors
		/// </summary>
		[Parameter]
		public Color Color { get; set; }

		/// <summary>
		/// A button can reduce its padding to fit into tighter spaces.
		/// </summary>
		[Parameter]
		public bool Compact { get; set; }

		/// <summary>
		/// A button can show it is currently unable to be interacted with.
		/// </summary>
		[Parameter]
		public bool Disabled { get; set; }

		/// <summary>
		/// A button can be aligned to the left or right of its container.
		/// </summary>
		[Parameter]
		public Position Floated { get; set; }

		/// <summary>
		/// A button can take the width of its container.
		/// </summary>
		[Parameter]
		public bool Fluid { get; set; }

		/// <summary>
		/// Add an Icon.
		/// </summary>
		[Parameter]
		public bool Icon { get; set; }

		/// <summary>
		/// A button can be formatted to appear on dark backgrounds.
		/// </summary>
		[Parameter]
		public bool Inverted { get; set; }

		/// <summary>
		/// Add a Label.
		/// </summary>
		[Parameter]
		public Label Label { get; set; }

		/// <summary>
		/// A labeled button can format a Label or Icon to appear on the left or right.
		/// </summary>
		[Parameter]
		public Position LabelPosition { get; set; }

		/// <summary>
		/// A button can show a loading indicator.
		/// </summary>
		[Parameter]
		public bool Loading { get; set; }

		/// <summary>
		/// A button can hint towards a negative consequence.
		/// </summary>
		[Parameter]
		public bool Negative { get; set; }

		/// <summary>
		/// Called after user's click.
		/// </summary>
		[Parameter]
		public EventCallback<MouseEventArgs> OnClick { get; set; }

		/// <summary>
		/// A button can hint towards a positive consequence.
		/// </summary>
		[Parameter]
		public bool Positive { get; set; }

		/// <summary>
		/// A button can be formatted to show different levels of emphasis.
		/// </summary>
		[Parameter]
		public bool Primary { get; set; }

		/// <summary>
		/// The role of the HTML element.
		/// </summary>
		[Parameter]
		public string Role { get; set; }

		/// <summary>
		/// A button can be formatted to show different levels of emphasis.
		/// </summary>
		[Parameter]
		public bool Secondary { get; set; }

		/// <summary>
		/// A button can have different sizes.
		/// </summary>
		[Parameter]
		public Size Size { get; set; }

		/// <summary>
		/// A button can receive focus.
		/// </summary>
		[Parameter]
		public int TabIndex { get; set; }

		/// <summary>
		/// A button can be formatted to toggle on and off.
		/// </summary>
		[Parameter]
		public bool Toggle { get; set; }

		/// <inheritdoc />
		protected override void ConfigureComponent()
		{
			ElementTag = "button";
			ElementClass = "ui";

			if (Animated != Animation.None)
			{
				if (Animated != Animation.Horizontal)
				{
					ElementClass = $"{ElementClass} {Animated.ToString().ToLowerInvariant()}";
				}

				ElementClass = $"{ElementClass} animated";
			}

			if (LabelPosition != Position.None)
			{
				ElementClass = $"{ElementClass} {LabelPosition.GetDescription()} labeled";
			}

			if (Color != Color.None)
			{
				ElementClass = $"{ElementClass} {Color.GetDescription()}";
			}

			if (Primary)
			{
				ElementClass = $"{ElementClass} primary";
			}
			else if (Secondary)
			{
				ElementClass = $"{ElementClass} secondary";
			}

			if (Icon)
			{
				ElementClass = $"{ElementClass} icon";
			}

			if (Basic)
			{
				ElementClass = $"{ElementClass} basic";
			}

			if (Inverted)
			{
				ElementClass = $"{ElementClass} inverted";
			}

			ElementClass = $"{ElementClass} button";

			ElementAttributes.Add("onclick", OnClick);
		}
	}
}
