using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using QD.Components.Semantic.Enums.Button;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// A Button indicates a possible user action.
	/// </summary>
	public class Button : ComponentBase
	{
		/// <summary>
		/// A button can be formatted to show different levels of emphasis.
		/// </summary>
		[Parameter]
		public bool Primary { get; set; }

		/// <summary>
		/// A button can be formatted to show different levels of emphasis.
		/// </summary>
		[Parameter]
		public bool Secondary { get; set; }

		/// <summary>
		/// A button can animate to show hidden content.
		/// </summary>
		[Parameter]
		public Animation Animated { get; set; }

		/// <summary>
		/// Called after user's click.
		/// </summary>
		[Parameter]
		public EventCallback<MouseEventArgs> OnClick { get; set; }

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
			if (Primary)
			{
				ElementClass = $"{ElementClass} primary";
			}
			else if (Secondary)
			{
				ElementClass = $"{ElementClass} secondary";
			}
			ElementClass = $"{ElementClass} button";

			ElementAttributes.Add("onclick", OnClick);
		}
	}
}
