using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PortableApp.Common
{
  struct FontCalc
  {
    public double FontSize { private set; get; }
    public double TextHeight { private set; get; }

    public FontCalc(Label label, double fontSize, double containerWidth) : this()
    {
      FontSize = fontSize;

      label.FontSize = fontSize;

      SizeRequest sizeRequest = label.Measure(containerWidth, Double.PositiveInfinity);

      TextHeight = sizeRequest.Request.Height;
    }
  }
}
