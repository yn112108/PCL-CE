using CommunityToolkit.Mvvm.ComponentModel;
using PCL.Core.App;
using PCL.Core.ViewModel;

namespace PCL;

/// <summary>View model for launcher miscellaneous settings.</summary>
public partial class PageSetupLauncherMiscViewModel : ViewModelBase
{
    [ObservableProperty] private int _activityIndex = 3;

    [ObservableProperty] private string _httpProxyPassword = Config.Network.HttpProxy.CustomPassword;

    [ObservableProperty] private string _httpProxyText = Config.Network.HttpProxy.CustomAddress;

    [ObservableProperty] private string _httpProxyUsername = Config.Network.HttpProxy.CustomUsername;

    [ObservableProperty] private bool _telemetryEnabled;

    public void Reload()
    {
        ActivityIndex = 3;
        HttpProxyText = Config.Network.HttpProxy.CustomAddress;
        HttpProxyUsername = Config.Network.HttpProxy.CustomUsername;
        HttpProxyPassword = Config.Network.HttpProxy.CustomPassword;
        TelemetryEnabled = false;
    }
}
