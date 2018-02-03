using PortableApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;
using PortableApp.Pages.Xaml;

namespace PortableApp
{
	public partial class App : Application
	{
    public string DisplayLabelText { get; set; }

    const string displayLabelText = "displayLabelText";
    



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

      //MainPage = new BlackCatPage();

      //MainPage = new WhatSizePage();

      //MainPage = new MetricalBoxViewPage();

      //MainPage = new FontSizesPage();

      //MainPage = new EstimatedFontSizePage();

      //MainPage = new FitToSizeClockPage();

      //MainPage = new AccessibilityTestPage();

      //MainPage = new EmpiricalFontSizePage();

      //MainPage = new ButtonLoggerPage();

      //MainPage = new TwoButtonsPage();

      //MainPage = new ButtonLambdasPage();

      //MainPage = new SimplestKeypadPage();

      if (Properties.ContainsKey(displayLabelText))
      {
        DisplayLabelText = Properties[displayLabelText] as string;
      }

      //MainPage = new PersistentKeypadPage();

      //MainPage = new CodePlusXamlPage();

      //MainPage = new ScaryColorListPage();

      //MainPage = new ParameteredConstructorDemoPage();

      //MainPage = new FactoryMethodDemoPage();

      //MainPage = new XamlClockPage();

      //MainPage = new PlatformSpecificLabelsPage();

      //MainPage = new ColorViewListPage();

      //MainPage = new XamlKeypadPage();

      MainPage = new MonkeyTapPage();
    }

		protected override void OnStart ()
		{
      // Handle when your app starts

      AppCenter.Start("android=a2283e27-5605-4726-8bdc-e21b0135a62b;" + "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
