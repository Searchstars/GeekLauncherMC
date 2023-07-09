using System.IO;
using System;

public static class ConfigBuilder{

    public static string[] ConfigFilesList = {
        "configs/reset",
        "configs/language",
        "configs/uuid",
        "configs/javaXmx",
        "configs/javaXms",
        "configs/now_select_version",
        "configs/jarname",
        "configs/width",
        "configs/height",
        "configs/launch_script_custom"
    };

    public static bool ConfigCheck(){
        if(!Directory.Exists("configs")){
            return false;
        }
        else if(!File.Exists("configs/reset")){
            return false;
        }
        else{
            for(int i=0;i<ConfigFilesList.Length;i++){
                if(!File.Exists(ConfigFilesList[i])){
                    return false;
                }
            }
            return true;
        }
    }

    public static void BuildConfig(){
        if(!Directory.Exists("configs")){
            Directory.CreateDirectory("configs");
        }
        for(int i=0;i<ConfigFilesList.Length;i++){
            if(!File.Exists(ConfigFilesList[i])){
                File.Create(ConfigFilesList[i]).Close();
            }
        }
        while(true){
            Console.WriteLine("Select your language:\nchs cht en\n");
            string lang_select_result = Console.ReadLine();
            if(lang_select_result == "chs"){
                File.WriteAllText("configs/language","chs");
                break;
            }
            else if(lang_select_result == "en"){
                File.WriteAllText("configs/language","en");
                break;
            }
            else if(lang_select_result == "cht"){
                File.WriteAllText("configs/language","cht");
                break;
            }
            else{
                Console.WriteLine("Bad input: The language does not exist or is not currently supported.");
            }
        }
        File.WriteAllText("configs/uuid","--uuid 123abc");
        File.WriteAllText("configs/javaXmx","-Xmx2048M");
        File.WriteAllText("configs/javaXms","-Xms128M");
        File.WriteAllText("configs/width","854");
        File.WriteAllText("configs/height","480");
        File.WriteAllText("configs/launch_script_custom","jvav -Xmx114514T -Xmn19810P");
    }
}
