using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using QD.Components.Semantic.Enums;

namespace QD.Components.Semantic.Elements
{
	public class Button : ComponentBase
	{
		/// <summary>
		/// Primary Button
		/// </summary>
		[Parameter]
		public bool Primary { get; set; }

		[Parameter]
		public bool Secondary { get; set; }

		[Parameter]
		public ButtonAnimation Animated { get; set; }

		[Parameter]
		public EventCallback<MouseEventArgs> OnClick { get; set; }

		protected override void ConfigureComponent()
		{
			ElementTag = "button";
			ElementClass = "ui";

			if (Animated != ButtonAnimation.None)
			{
				if (Animated != ButtonAnimation.Horizontal)
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
