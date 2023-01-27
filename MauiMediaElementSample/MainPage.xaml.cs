using CommunityToolkit.Maui.Views;

namespace MauiMediaElementSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if (mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
			mediaElement.Pause();
		else if (mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
			mediaElement.Play();
    }
}

