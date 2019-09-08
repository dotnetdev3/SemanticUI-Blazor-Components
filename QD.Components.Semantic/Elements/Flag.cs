using Microsoft.AspNetCore.Components;

namespace QD.Components.Semantic.Elements
{
	public class Flag : ComponentBase
	{
		[Parameter]
		public Enums.Flag Name { get; set; }

		protected override void ConfigureComponent()
		{
			ElementTag = "i";
			ElementClass = $"{Name.GetDescription()} flag";
		}
	}
}
