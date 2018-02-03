using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
  public class VariableFormattedTextPage : ContentPage
  {
    public VariableFormattedTextPage()
    {
      //var formattedString = new FormattedString();

      //formattedString.Spans.Add(new Span
      //{
      //  Text = "I "
      //});

      //formattedString.Spans.Add(new Span
      //{
      //  Text = "love",
      //  FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
      //  FontAttributes = FontAttributes.Bold
      //});

      //formattedString.Spans.Add(new Span
      //{
      //  Text = " Xamarin.Forms!",
      //});

      Content = new Label
      {
        FormattedText = new FormattedString
        {
          Spans =
          {
            new Span
            {
              Text = "I "
            },
            new Span
            {
              Text = "love",
              FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
              FontAttributes = FontAttributes.Bold
            },
            new Span
            {
              Text = " Xamarin.Forms!",
            }
          }
        },
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
      };
    }
  }
}