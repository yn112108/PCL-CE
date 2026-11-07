using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using PCL.Core.App;
using PCL.Core.App.Localization;
using PCL.Core.UI.Hints;
using PCL.Core.UI.Dialogs;
using PCL.Core.Utils;
using PCL.Core.Utils.OS;

namespace PCL;

public static class UpdateManager
{
    public static bool isUpdateWaitingRestart;

    public static UpdatesWrapperModel remoteServer = new(Array.Empty<IUpdateSource>());

    public static bool IsCurrentVersionBeta => false;

    public static UpdateEnums.VersionStatus GetVersionStatus()
    {
        Common.Log("[Update] 启动器更新已禁用，跳过版本检查");
        return UpdateEnums.VersionStatus.Latest;
    }

    public static Loading.LoaderCombo<JsonObject> updateLoader;

    public static void UpdateStart(UpdateEnums.UpdateType type, string receivedKey = null, bool forceValidated = false)
    {
        Common.Log("[Update] 已禁用启动器更新检查");
    }

    public static void UpdateRestart(bool triggerRestartAndByEnd, bool triggerRestart = true)
    {
        Common.Log("[Update] 已禁用启动器更新安装");
    }

    internal static void DownloadLatestPCL(Loading.LoaderBase loaderToSyncProgress = null)
    {
        Common.Log("[System] 启动器更新已禁用，跳过下载最新 PCL");
    }

    public static Loading.LoaderTask<int, int> serverLoader =
        new(Lang.Text("Update.Service.PclCe"),
            _ => { Common.Log("[Update] 启动器更新已禁用"); },
            priority: ThreadPriority.BelowNormal);

    private static void LoadOnlineInfo()
    {
        Common.Log("[Update] 启动器更新已禁用");
    }

    private static void ScheduleBasedOnConfig()
    {
        Common.Log("[Update] 启动器更新已禁用");
    }

    public static void ShowCEAnnounce()
    {
        Common.Log("[Update] 启动器公告已禁用");
    }
}
