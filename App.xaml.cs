using Plugin.MauiMTAdmob;

namespace Scalculatorplus;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        CrossMauiMTAdmob.Current.UserPersonalizedAds = true;
        CrossMauiMTAdmob.Current.ComplyWithFamilyPolicies = true;
        CrossMauiMTAdmob.Current.UseRestrictedDataProcessing = true;
        CrossMauiMTAdmob.Current.AdsId = DeviceInfo.Platform == DevicePlatform.Android ? "ca-app-pub-7783862220844446/4622474625" : "ca-app-pub-7783862220844446/4622474625";
        CrossMauiMTAdmob.Current.TestDevices = new List<string>() { };

        //MainPage = new NavigationPage(new MainPage());
        MainPage = new MainPage();
    }
}
