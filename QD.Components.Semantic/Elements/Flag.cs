using Microsoft.AspNetCore.Components;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// A flag is is used to represent a political state.
	/// </summary>
	public class Flag : ComponentBase
	{
		/// <summary>
		/// Flag name, can use the two digit country code, the full name, or a common alias.
		/// </summary>
		[Parameter]
		public Enums.Elements.Flag Name { get; set; }

		/// <inheritdoc />
		protected override void ConfigureComponent()
		{
			ElementTag = "i";
			ElementClass = $"{Name.GetDescription()} flag";
		}
	}
}
