using System.IO;
using System;

public static class GameScan{
    public static string[] ScanVersions(){
        Console.WriteLine(Language.Text.ChangeVersion.ScanningVersions);
        Console.WriteLine(Language.Text.ChangeVersion.WARN_Scan_Only_Minecraft_folder);
        if(!Directory.Exists(".minecraft/versions")){
            string[] return_list = {Language.Text.ChangeVersion.NotAnyExistsVersion};
            return return_list;
        }
        DirectoryInfo dcinfo = new DirectoryInfo(".minecraft/versions");
        DirectoryInfo[] dcs = dcinfo.GetDirectories();
        string[] return_list_ = {""};
        for (int i=0;i<dcs.Length;i++){
            return_list_[i] = dcs[i].ToString();
        }
        return return_list_;
    }
}