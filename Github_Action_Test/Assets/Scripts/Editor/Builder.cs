using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;
using System.IO;

public class Builder : MonoBehaviour
{
    [MenuItem("Build/Haha")]
    public static void BuildStart()
    {
        if (Application.HasProLicense())
        {
            PlayerSettings.SplashScreen.show = false;
            PlayerSettings.SplashScreen.showUnityLogo = false;
        }

    
        BuildPlayerOptions bpo = new BuildPlayerOptions();
        bpo.target = BuildTarget.Android;

        bpo.locationPathName = Path.Combine(Directory.GetCurrentDirectory(), "ff.apk");
    
        BuildReport report = BuildPipeline.BuildPlayer(bpo);
        BuildSummary summary = report.summary;

        if (summary.result == BuildResult.Succeeded)
        {
        }
        else if (summary.result == BuildResult.Failed)
        {
        }
    }
}