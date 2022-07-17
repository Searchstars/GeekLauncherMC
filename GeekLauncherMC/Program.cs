using System;
using System.IO;
using System.Threading;

Console.WriteLine("------ GeekLauncherMC ------");
Console.WriteLine("Version: " + BuildConfClass.AppVersion + " " + BuildConfClass.BuildRD);
if(!ConfigBuilder.ConfigCheck()){
    ConfigBuilder.BuildConfig();
}
Language.InitLanguage();
Console.WriteLine(Language.Text.Main.WelcomeMessage);
while(true){
Console.WriteLine(Language.Text.Main.FeatureSelectionMessage_0);
    Console.WriteLine(Language.Text.Main.FeatureSelectionMessage_1);
    Console.WriteLine(Language.Text.Main.PleaseTypeMessage);
    switch(Console.ReadLine()){
        case "1":
            if(File.ReadAllText("configs/now_select_version") == ""){
                Console.WriteLine(Language.Text.LaunchGame.NotSelectVersion);
                continue;
            }
            if(File.ReadAllText("configs/launch_script_custom").Contains("jvav")){
                System.Diagnostics.Process.Start("java",LauncherScriptBuilder.Build()).WaitForExit();
                Console.WriteLine(Language.Text.LaunchGame.GameProcessStop);
            }
            else{
                System.Diagnostics.Process.Start("java",File.ReadAllText("configs/launch_script_custom")).WaitForExit();
                Console.WriteLine(Language.Text.LaunchGame.GameProcessStop);
            }
            continue;
        case "2":
            string[] result_scan = GameScan.ScanVersions();
            for(int i=0;i<result_scan.Length;i++){
                Console.WriteLine(result_scan[i]);
            }
            while(true){
                Console.WriteLine(Language.Text.ChangeVersion.SelectTIps);
                string result_select = Console.ReadLine();
                if(Directory.Exists(result_select)){
                    File.WriteAllText("configs/now_select_version",result_select);
                    while(true){
                        Console.WriteLine(Language.Text.ChangeVersion.TypeJarName);
                        string result_jar = Console.ReadLine();
                        if(File.Exists(result_select + "/" + result_jar)){
                            File.WriteAllText("configs/jarname",result_jar);
                            break;
                        }
                    }
                    Console.WriteLine(Language.Text.ChangeVersion.Finish);
                    break;
                }
            }
            continue;
        case "3":
            GameSettings.EnterGameSettings();
            break;
        case "4":
            Console.WriteLine(Language.Text.Tips.FeatureNotOpen);
            break;
        case "5":
            Console.WriteLine(Language.Text.Tips.FeatureNotOpen);
            break;
        case "6":
            Console.WriteLine(Language.Text.Tips.FeatureNotOpen);
            break;
        case "7":
            Console.WriteLine(Language.Text.Tips.CtrlCExit);
            Environment.Exit(0);
            continue;
        default:
            Console.WriteLine(Language.Text.Main.BadInput);
            Thread.Sleep(3000);
            continue;
    }
}