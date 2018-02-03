using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class ButtonLoggerPage : ContentPage
	{
    StackLayout loggerLayout = new StackLayout();

		public ButtonLoggerPage ()
		{
      var button = new Button
      {
        Text = "Log the Clock Time"
      };

      button.Clicked += OnButtonClicked;

      Content = new StackLayout
      {
        Children =
        {
          button,
          new ScrollView
          {
            VerticalOptions = LayoutOptions.FillAndExpand,
            Content = loggerLayout,
            Padding = new Thickness(5, 0)
          }
        }
      };
		}

    private void OnButtonClicked(object sender, EventArgs e)
    {
      loggerLayout.Children.Add(new Label
      {
        Text = "Button clicked at " + DateTime.Now.ToString("T")
      });
    }
  }
}