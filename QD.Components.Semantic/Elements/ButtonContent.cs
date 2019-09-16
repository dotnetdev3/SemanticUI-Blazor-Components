using Microsoft.AspNetCore.Components;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// Used in some Button types, such as `animated`.
	/// </summary>
	public class ButtonContent : ComponentBase
	{
		/// <summary>
		/// Initially visible, hidden on hover.
		/// </summary>
		[Parameter]
		public bool Visible { get; set; }

		/// <summary>
		/// Initially hidden, visible on hover.
		/// </summary>
		[Parameter]
		public bool Hidden { get; set; }

		/// <inheritdoc />
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
