using Windows.Storage.Pickers;

namespace Cyber.Mods.UI.Platforms.Windows
{
	internal class FolderSelect : IFolderSelect
	{
		public async Task<string> PickFolder()
		{
			var folderSelect = new FolderPicker();
			var windowHandler = ((MauiWinUIWindow)App.Current.Windows[0].Handler.PlatformView).WindowHandle;
			WinRT.Interop.InitializeWithWindow.Initialize(folderSelect, windowHandler);
			var result = await folderSelect.PickSingleFolderAsync();
			return result.Path;
		}
	}
}
