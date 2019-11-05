using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QD.Components.Semantic
{
	/// <summary>
	/// Component base for semantic components
	/// </summary>
	public abstract class ComponentBase : Microsoft.AspNetCore.Components.ComponentBase
	{
		/// <summary>
		/// An element type to render as.
		/// </summary>
		[Parameter]
		public string As { get; set; }

		/// <summary>
		/// An element component to render as.
		/// </summary>
		[Parameter]
		public Type AsComponent { get; set; }

		/// <summary>
		/// Child content
		/// </summary>
		[Parameter]
		public RenderFragment ChildContent { get; set; }

		/// <summary>
		/// Other input attributes
		/// </summary>
		[Parameter(CaptureUnmatchedValues = true)]
		public IDictionary<string, object> InputAttributes { get; set; }

		/// <summary>
		/// Html Tag
		/// </summary>
		protected string ElementTag { get; set; }

		/// <summary>
		/// CSS classes
		/// </summary>
		protected string ElementClass { get; set; }

		/// <summary>
		/// All component attributes
		/// </summary>
		protected IDictionary<string, object> ElementAttributes { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		protected ComponentBase()
		{
			ElementTag = "div";
			ElementClass = "";
			ElementAttributes = new Dictionary<string, object>();
		}

		/// <inheritdoc />
		protected override void OnInitialized()
		{
			if (!ElementAttributes.ContainsKey("Class"))
			{
				ElementAttributes.Add("Class", "");
			}
			BuildComponent();
		}

		/// <inheritdoc />
		protected override void OnParametersSet()
		{
			base.OnParametersSet();
			if (AsComponent == null && InputAttributes != null)
			{
				foreach (KeyValuePair<string, object> attribute in InputAttributes)
				{
					//TODO Remove
					Console.WriteLine(attribute.Key);
				}
				foreach (KeyValuePair<string, object> attribute in InputAttributes)
				{
					ThrowForUnknownIncomingParameterName(attribute.Key);
				}
			}
			BuildComponent();
		}

		///// <inheritdoc />
		//public override async Task SetParametersAsync(ParameterView parameters)
		//{
		//	await base.SetParametersAsync(parameters);
		//}

		/// <inheritdoc />
		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			if (AsComponent != null)
			{
				builder.OpenComponent(0, AsComponent);
				builder.AddMultipleAttributes(1, ElementAttributes);
				builder.AddMultipleAttributes(2, InputAttributes);
				builder.CloseComponent();
			}
			else
			{
				builder.OpenElement(0, string.IsNullOrWhiteSpace(As) ? ElementTag : As);
				builder.AddMultipleAttributes(1, ElementAttributes);
				builder.AddContent(2, ChildContent);
				builder.CloseElement();
			}
		}

		private void ThrowForUnknownIncomingParameterName(string parameterName)
		{
			Type componentType = GetType();
			PropertyInfo property = componentType.GetProperty(parameterName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
			if (property != null)
			{
				if (!property.IsDefined(typeof(ParameterAttribute)) && !property.IsDefined(typeof(CascadingParameterAttribute)))
					throw new InvalidOperationException("Object of type '" + componentType.FullName + "' has a property matching the name '" + parameterName + "', but it does not have [ParameterAttribute] or [CascadingParameterAttribute] applied.");
				throw new InvalidOperationException("No writer was cached for the property '" + property.Name + "' on type '" + componentType.FullName + "'.");
			}
			throw new InvalidOperationException("Object of type '" + componentType.FullName + "' does not have a property matching the name '" + parameterName + "'.");
		}

		/// <summary>
		/// Configure the semantic component to be rendered
		/// </summary>
		protected abstract void ConfigureComponent();

		private void BuildComponent()
		{
			ConfigureComponent();
			if (InputAttributes != null && InputAttributes.ContainsKey("Class"))
			{
				ElementClass = $"{ElementClass} {InputAttributes["Class"]}";
				InputAttributes.Remove("Class");
			}

			if (AsComponent != null && !ElementAttributes.ContainsKey(nameof(ChildContent)))
			{
				ElementAttributes.Add(nameof(ChildContent), ChildContent);
			}

			ElementAttributes["Class"] = ElementClass;
		}
	}
}
