namespace Cyber.Mods.UI;

public partial class MainPage : ContentPage
{
	private readonly IFolderSelect _folderSelect;

	public MainPage(IFolderSelect folderSelect)
	{
		InitializeComponent();
		_folderSelect = folderSelect;
	}

	private async void OnPickFolderClicked(object sender, EventArgs e)
	{
		var selectedFolder = await _folderSelect.PickFolder();
		SelectedGameFolder.Text = selectedFolder;
		SemanticScreenReader.Announce(SelectedGameFolder.Text);
	}
}
