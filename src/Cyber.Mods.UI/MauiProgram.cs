﻿namespace Cyber.Mods.UI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
#if WINDOWS
		builder.Services.AddTransient<IFolderSelect, Platforms.Windows.FolderSelect>();
#endif
		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<App>();
		return builder.Build();
	}
}
