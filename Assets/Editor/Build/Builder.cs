using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Builder
{
    private static readonly string[] Scenes = FindEnabledEditorScenes();

    private const string AppName = "Quest";
    private static readonly string BuildDir = System.IO.Directory.GetCurrentDirectory() + "/Build";

    private static string[] FindEnabledEditorScenes()
    {
        var editorScenes = new List<string>();
        
        foreach (var scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            editorScenes.Add(scene.path);
        }

        return editorScenes.ToArray();
    }

    private static void GenericBuild(string[] scenes, string targetPath, BuildTargetGroup buildTargetGroup, BuildTarget buildTarget, BuildOptions buildOptions)
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(buildTargetGroup, buildTarget);
        BuildPipeline.BuildPlayer(scenes, targetPath, buildTarget, buildOptions);
    }
    
    [MenuItem("Custom/CI/Build Windows")]
    public static void BuildWindows()
    {
        Debug.Log("Start BuildWindows");
        var targetPath = BuildDir + "/" + AppName + ".exe";
        GenericBuild(Scenes, targetPath, BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows64, BuildOptions.None);
        Debug.Log("End BuildWindows");
    }
}
