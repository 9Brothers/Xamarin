using PortableApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

      //MainPage = new PortableApp.MainPage();

      //MainPage = new ContentPage
      //{
      //  Content = new StackLayout
      //  {
      //    VerticalOptions = LayoutOptions.Center,
      //    Children =
      //    {
      //      new Label
      //      {
      //        HorizontalTextAlignment = TextAlignment.Center,
      //        Text = "Heber, welcome to Xamarin Forms!"
      //      }
      //    }
      //  }
      //};

      //MainPage = new GreetingsPage();

      //MainPage = new BaskervillesPage();      

      //MainPage = new VariableFormattedTextPage();

      //MainPage = new VariableFormattedParagraphPage();

      //MainPage = new NamedFontSizesPage();

      //MainPage = new ColorLoopPage();

      //MainPage = new ReflectedColorsPage();

      //MainPage = new VerticalOptionsDemoPage();

      //MainPage = new FramedTextPage();

      //MainPage = new SizedBoxViewPage();

      //MainPage = new ColorBlocksPage();

      MainPage = new BlackCatPage();
    }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
