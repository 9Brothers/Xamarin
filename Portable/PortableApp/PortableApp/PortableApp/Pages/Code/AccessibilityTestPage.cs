using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class AccessibilityTestPage : ContentPage
	{
		public AccessibilityTestPage ()
		{
      var testLabel = new Label
      {
        Text = "FontSize of 20" + Environment.NewLine + "20 characters across",
        FontSize = 20,
        HorizontalTextAlignment = TextAlignment.Center,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.CenterAndExpand
      };

      var displayLabel = new Label
      {
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.CenterAndExpand
      };

      testLabel.SizeChanged += (sender, args) =>
      {
        displayLabel.Text = String.Format("{0:F0} \u00D7 {1:F0}", testLabel.Width, testLabel.Height);
      };

      Content = new StackLayout
      {
        Children =
        {
          testLabel,
          displayLabel
        }
      };
		}
	}
}