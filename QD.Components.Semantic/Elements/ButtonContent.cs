using Microsoft.AspNetCore.Components;

namespace QD.Components.Semantic.Elements
{
	public class ButtonContent : ComponentBase
	{
		[Parameter]
		public bool Visible { get; set; }

		[Parameter]
		public bool Hidden { get; set; }

		protected override void ConfigureComponent()
		{
			if (Visible)
			{
				ElementClass = "visible content";
			}
			else if (Hidden)
			{
				ElementClass = "hidden content";
			}
		}
	}
}
