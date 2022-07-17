using System.IO;
using System;

public static class LauncherScriptBuilder{
    public static string Build(){
        string LaunchScript = File.ReadAllText("configs/javaXmx")  + " " + File.ReadAllText("configs/javaXmn") + " -Djava.library.path=" + File.ReadAllText("configs/now_select_version") + "/natives" + " -Dminecraft.launcher.brand=GeekLauncherMC" + " -cp ";
        string[] files = Directory.GetFiles(".minecraft/libraries", "*", SearchOption.AllDirectories);
        for(int i=0;i<files.Length-1;i++){
            Console.WriteLine(files[i].ToString());
            LaunchScript +=  files[i] + ":";
        }
        Console.WriteLine(files[files.Length -1]);
        LaunchScript += files[files.Length -1] + ":";
        LaunchScript +=  File.ReadAllText("configs/now_select_version")  + "/" + File.ReadAllText("configs/jarname") + " ";
        LaunchScript += "net.minecraft.client.main.Main --username GeekLauncherMC_Test --version GeekLauncherMC --gameDir .minecraft --assetsDir .minecraft/assets " + File.ReadAllText("configs/uuid") + " -assetIndex 1.19 --accessToken 114514 --userProperties {} -userType mojang " + "-width " + File.ReadAllText("configs/width") + " -height " + File.ReadAllText("configs/height");
        Console.WriteLine(LaunchScript);
        return LaunchScript;
    }
}