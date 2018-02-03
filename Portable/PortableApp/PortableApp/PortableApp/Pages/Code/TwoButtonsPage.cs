using PortableApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class TwoButtonsPage : ContentPage
	{
    Button addButton, removeButton;
    StackLayout loggerLayout = new StackLayout();

		public TwoButtonsPage ()
		{
      addButton = new Button
      {
        Text = "Add",
        HorizontalOptions = LayoutOptions.CenterAndExpand
      };
      addButton.Clicked += OnButtonClicked;

      removeButton = new Button
      {
        Text = "Remove",
        HorizontalOptions = LayoutOptions.CenterAndExpand,
        IsEnabled = false
      };
      removeButton.Clicked += OnButtonClicked;

      Padding = new Thickness(5, DevicePadding.Top(5), 5, 0);

      Content = new StackLayout
      {
        Children =
        {
          new StackLayout
          {
            Orientation = StackOrientation.Horizontal,

            Children =
            {
              addButton,
              removeButton
            }
          },
          new ScrollView
          {
            VerticalOptions = LayoutOptions.FillAndExpand,
            Content = loggerLayout
          }
        }
      };
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
      Button button = (Button)sender;

      if (button == addButton)
      {
        loggerLayout.Children.Add(new Label
        {
          Text = "Button clicked at " + DateTime.Now.ToString("T")
        });
      }
      else
      {
        loggerLayout.Children.RemoveAt(0);
      }

      removeButton.IsEnabled = loggerLayout.Children.Count > 0;
    }
  }
}