using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class PersistentKeypadPage : ContentPage
	{
    Label displayLabel;
    Button backspaceButton;

    public PersistentKeypadPage ()
		{
      StackLayout mainStack = new StackLayout
      {
        VerticalOptions = LayoutOptions.Center,
        HorizontalOptions = LayoutOptions.Center
      };

      displayLabel = new Label
      {
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        VerticalOptions = LayoutOptions.Center,
        HorizontalTextAlignment = TextAlignment.End
      };

      mainStack.Children.Add(displayLabel);

      backspaceButton = new Button
      {
        Text = "\u21E6",
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
        IsEnabled = false
      };

      backspaceButton.Clicked += OnBackspaceButtonClicked;

      mainStack.Children.Add(backspaceButton);

      StackLayout rowStack = null;

      for (int num = 1; num <= 10; num++)
      {
        if ((num - 1) % 3 == 0)
        {
          rowStack = new StackLayout
          {
            Orientation = StackOrientation.Horizontal
          };

          mainStack.Children.Add(rowStack);
        }

        Button digitButton = new Button
        {
          Text = (num % 10).ToString(),
          FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
          StyleId = (num % 10).ToString()
        };

        digitButton.Clicked += OnDigitButtonClicked;

        if (num == 10)
        {
          digitButton.HorizontalOptions = LayoutOptions.FillAndExpand;
        }

        rowStack.Children.Add(digitButton);
      }

      Content = mainStack;

      App app = Application.Current as App;

      displayLabel.Text = app.DisplayLabelText;

      backspaceButton.IsEnabled = displayLabel.Text != null && displayLabel.Text.Length > 0;
    }

    private void OnDigitButtonClicked(object sender, EventArgs e)
    {
      Button button = sender as Button;
      displayLabel.Text += button.StyleId as string;
      backspaceButton.IsEnabled = true;

      App app = Application.Current as App;
      app.DisplayLabelText = displayLabel.Text;
    }

    private void OnBackspaceButtonClicked(object sender, EventArgs e)
    {
      string text = displayLabel.Text;
      displayLabel.Text = text.Substring(0, text.Length - 1);
      backspaceButton.IsEnabled = displayLabel.Text.Length > 0;

      App app = Application.Current as App;
      app.DisplayLabelText = displayLabel.Text;
    }
  }
}