using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortableApp.Pages.Xaml
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MonkeyTapPage : ContentPage
	{
    const int sequenceTime = 750;
    protected const int flashDuration = 250;

    const double offLuminosity = 0.4;
    const double onLuminosity = 0.75;

    BoxView[] boxViews;
    Color[] colors = { Color.Red, Color.Blue, Color.Yellow, Color.Green };
    List<int> sequence = new List<int>();
    int sequenceIndex;
    bool awaintTaps;
    bool gameEnded;
    Random random = new Random();

		public MonkeyTapPage ()
		{
			InitializeComponent ();

      boxViews = new BoxView[] { boxView0, boxView1, boxView2, boxView3 };

      InitializeBoxViewColor();
		}

    void InitializeBoxViewColor()
    {
      for (int index = 0; index < 4; index++)
      {
        boxViews[index].Color = colors[index].WithLuminosity(offLuminosity);
      }
    }

    void OnStartGameButtonClicked(object sender, EventArgs args)
    {
      gameEnded = false;
      startGameButton.IsVisible = false;

      InitializeBoxViewColor();

      sequence.Clear();

      StartSequence();
    }

    void StartSequence()
    {
      sequence.Add(random.Next(4));

      sequenceIndex = 0;

      Device.StartTimer(TimeSpan.FromMilliseconds(sequenceTime), OnTimerTick);
    }

    bool OnTimerTick()
    {
      if (gameEnded)
      {
        return false;
      }

      FlashBoxView(sequence[sequenceIndex]);

      sequenceIndex++;

      awaintTaps = sequenceIndex == sequence.Count;

      sequenceIndex = awaintTaps ? 0 : sequenceIndex;

      return !awaintTaps;
    }

    protected virtual void FlashBoxView(int index)
    {
      boxViews[index].Color = colors[index].WithLuminosity(onLuminosity);

      Device.StartTimer(TimeSpan.FromMilliseconds(flashDuration), () =>
      {
        if (gameEnded) return false;

        boxViews[index].Color = colors[index].WithLuminosity(offLuminosity);

        return false;
      });
    }

    protected void OnBoxViewTapped(object sender, EventArgs args)
    {
      if (gameEnded)
      {
        return;
      }

      if (!awaintTaps)
      {
        EndGame();
        return;
      }

      BoxView tappedBoxView = (BoxView)sender;

      int index = Array.IndexOf(boxViews, tappedBoxView);

      if (index != sequence[sequenceIndex])
      {
        EndGame();
        return;
      }

      FlashBoxView(index);

      sequenceIndex++;
      awaintTaps = sequenceIndex < sequence.Count;

      if (!awaintTaps) StartSequence();
    }

    private void EndGame()
    {
      gameEnded = true;

      for (int index = 0; index < 4; index++)
      {
        boxViews[index].Color = Color.Gray;
      }

      startGameButton.Text = "Try again?";
      startGameButton.IsVisible = true;
    }
  }
}