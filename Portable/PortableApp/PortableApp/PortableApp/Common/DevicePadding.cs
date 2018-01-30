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
  }
}
