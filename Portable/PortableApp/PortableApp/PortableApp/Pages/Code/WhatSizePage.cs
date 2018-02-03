using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class WhatSizePage : ContentPage
	{
    private Label label = null;

		public WhatSizePage ()
		{
      label = new Label
      {
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
      };

      Content = label;

      SizeChanged += OnPageSizeChanged;
		}

    private void OnPageSizeChanged(object sender, EventArgs e)
    {
      label.Text = String.Format("{0} \u00D7 {1}", Width, Height);
    }
  }
}