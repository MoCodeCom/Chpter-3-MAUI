

namespace Chapter_3;

public partial class MainPage : ContentPage
{
	int count = 0;
	
	public MainPage()
	{
		InitializeComponent();
		//Feedback.Text = (string)Resources["PlaceHolder"]; ;
	}

	

    private void HandleFeedback(object sender, FocusEventArgs e)
    {
		/*
		var text = Feedback.Text;
        var PlaceholderText = (string)Resources["PlaceHolder"];

        if (text == PlaceholderText)
		{
			text = String.Empty;
			Feedback.TextColor = (Color)Resources["SelectedColor"];
			//Resources["SelectedColor"] = Resources["CancelActiveColor"];
            return;
        }

		if (text == String.Empty)
		{
			text = PlaceholderText;
			Feedback.TextColor = (Color)Resources["UnSelectedColor"];
			//Resources["UnSelectedColor"] = Resources["SubmitActiveColor"];
            return;
		}*/

    }

    private void Button_Clicked_Submit(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MyPage1());
    }

    private void Button_Clicked_Css(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MyPageCss());
    }
}

