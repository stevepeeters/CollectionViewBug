namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPopOutContent1Clicked(object sender, EventArgs e)
	{
		PopOutContent(Content1);
	}

	private void OnPopOutContent2Clicked(object sender, EventArgs e)
	{
        PopOutContent(Content2);
    }

	private void PopOutContent(Border parent)
	{
		View content = parent.Content;
		parent.Content = null;

        ContentPage page = new() { Content = content };
        Window window = new() { Page = page };
        
		Application.Current.OpenWindow(window);
    }
}

