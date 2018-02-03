using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PortableApp.Common
{
  class DevicePadding
  {
    public static double Top(double value = 0)
    {
      return Device.RuntimePlatform == Device.iOS ? value + 20 : value;
    }

    public static double ByOS(double Android = 0, double iOS = 0)
    {
      double result = 0;

      if (Device.RuntimePlatform == Device.Android) result = Android;

      else if (Device.RuntimePlatform == Device.iOS) result = iOS;

      return result;
    }
  }
}
