using Microsoft.AspNetCore.Components;
using QD.Components.Semantic.Enums.Container;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// A container limits content to a maximum width.
	/// </summary>
	public class Container : ComponentBase
	{
		/// <summary>
		/// Container has no maximum width.
		/// </summary>
		[Parameter]
		public bool Fluid { get; set; }

		/// <summary>
		/// Reduce maximum width to more naturally accommodate text.
		/// </summary>
		[Parameter]
		public bool Text { get; set; }

		/// <summary>
		/// Align container text.
		/// </summary>
		[Parameter]
		public TextAlign TextAlign { get; set; }

		/// <inheritdoc />
		protected override void ConfigureComponent()
		{
			ElementClass = "ui";

			if (Fluid)
			{
				ElementClass = $"{ElementClass} fluid";
			}

			if (Text)
			{
				ElementClass = $"{ElementClass} text";
			}

			if (TextAlign != TextAlign.None)
			{
				ElementClass = $"{ElementClass} {TextAlign.GetDescription()} aligned";
			}

			ElementClass = $"{ElementClass} container";
		}
	}
}
