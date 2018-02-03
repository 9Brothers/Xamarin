using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class ButtonLambdasPage : ContentPage
	{
		public ButtonLambdasPage ()
		{
      double number = 1;

      var label = new Label
      {
        Text = number.ToString(),
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.CenterAndExpand
      };

      var timesButton = new Button
      {
        Text = "Double",
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
        HorizontalOptions = LayoutOptions.CenterAndExpand
      };
      timesButton.Clicked += (sender, args) =>
      {
        number *= 2;
        label.Text = number.ToString();
      };

      Button divideButton = new Button
      {
        Text = "Half",
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
        HorizontalOptions = LayoutOptions.CenterAndExpand
      };
      divideButton.Clicked += (sender, args) =>
      {
        number /= 2;
        label.Text = number.ToString();
      };

      Content = new StackLayout
      {
        Children =
        {
          label,
          new StackLayout
          {
            Orientation = StackOrientation.Horizontal,
            VerticalOptions = LayoutOptions.CenterAndExpand,
            Children =
            {
              timesButton,
              divideButton
            }
          }
        }
      };
		}
	}
}