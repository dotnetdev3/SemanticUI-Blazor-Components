using Microsoft.AspNetCore.Components;

namespace QD.Components.Semantic.Elements
{
	/// <summary>
	/// Button groups can contain conditionals.
	/// </summary>
	public class ButtonOr : ComponentBase
	{
		/// <summary>
		/// Or buttons can have their text localized, or adjusted by using the text prop.
		/// </summary>
		[Parameter]
		public string Text { get; set; }

		private const string DataTextKey = "data-text";

		/// <inheritdoc />
		protected override void ConfigureComponent()
		{
			ElementClass = "or";

			if (string.IsNullOrEmpty(Text)) return;

			if (!ElementAttributes.ContainsKey(DataTextKey))
			{
				ElementAttributes.Add(DataTextKey, Text);
			}
			ElementAttributes[DataTextKey] = Text;
		}
	}
}
