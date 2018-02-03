using PortableApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class EmpiricalFontSizePage : ContentPage
	{
    Label label;

    public EmpiricalFontSizePage ()
		{
      label = new Label();

      Padding = new Thickness(5, DevicePadding.Top(5), 5, 5);

      var contentView = new ContentView
      {
        Content = label
      };

      contentView.SizeChanged += OnContentViewSizeChanged;

      Content = contentView;
		}

    private void OnContentViewSizeChanged(object sender, EventArgs e)
    {
      View view = (View)sender;

      if (view.Width <= 0 || view.Height <= 0) return;

      label.Text = 
        "This is a paragraph of text displayed with " + 
        "a FontSize value of ?? that is empirically " + 
        "calculated in a loop within the SizeChanged " + 
        "handler of the Label's container. This technique " + 
        "can be tricky: You don't want to get into " + 
        "an infinite loop by triggering a layout pass " + 
        "with every calculation. Does it work?";

      FontCalc lowerFontCalc = new FontCalc(label, 10, view.Width);
      FontCalc upperFontCalc = new FontCalc(label, 100, view.Width);

      while (upperFontCalc.FontSize - lowerFontCalc.FontSize > 1)
      {
        double fontSize = (lowerFontCalc.FontSize + upperFontCalc.FontSize) / 2;

        FontCalc newFontCalc = new FontCalc(label, fontSize, view.Width);

        if (newFontCalc.TextHeight > view.Height) upperFontCalc = newFontCalc;

        else lowerFontCalc = newFontCalc;
      }

      label.FontSize = lowerFontCalc.FontSize;
      label.Text = label.Text.Replace("??", label.FontSize.ToString("F0"));
    }
  }
}