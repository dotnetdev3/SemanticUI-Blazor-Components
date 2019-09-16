using System.ComponentModel;

namespace QD.Components.Semantic.Enums.Container
{
	/// <summary>
	/// Text align
	/// </summary>
	public enum TextAlign
	{
		/// <summary>
		/// None
		/// </summary>
		[Description("none")]
		None,
		/// <summary>
		/// Text align left
		/// </summary>
		[Description("left")]
		Left,
		/// <summary>
		/// Text align right
		/// </summary>
		[Description("right")]
		Right,
		/// <summary>
		/// Text align center
		/// </summary>
		[Description("center")]
		Center,
		/// <summary>
		/// Text align justified
		/// </summary>
		[Description("justified")]
		Justified
	}
}
