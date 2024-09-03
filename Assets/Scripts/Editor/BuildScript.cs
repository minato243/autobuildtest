
using UnityEditor;

public class BuildScript
{
    static void BuildWindows()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity"};

        BuildPipeline.BuildPlayer(scenes,"../WindowsBuild/PerfoceExample.exe", 
            BuildTarget.StandaloneWindows, BuildOptions.None);
    }
	
	static void BuildAndroid()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity"};

        BuildPipeline.BuildPlayer(scenes,"../Android/Test.apk", 
            BuildTarget.Android, BuildOptions.None);
    }

}
