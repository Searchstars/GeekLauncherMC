using System.IO;
using System;

public static class GameSettings{
    public static void EnterGameSettings(){
        while(true){

            Console.WriteLine(Language.Text.GameSettings.FeatureSelectionMessage_0);
            Console.WriteLine(Language.Text.GameSettings.FeatureSelectionMessage_1);
            Console.WriteLine(Language.Text.Tips.EditorTips);
            Console.WriteLine(Language.Text.Main.PleaseTypeMessage);
            switch(Console.ReadLine()){
                case "1":
                    while(true){
                        Console.WriteLine(Language.Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_0);
                        Console.WriteLine(Language.Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_1);
                        Console.WriteLine(Language.Text.Main.PleaseTypeMessage);
                        switch(Console.ReadLine()){
                            case "1":
                                while(true){
                                    Console.WriteLine(Language.Text.GameSettings.MemoryAllocation.XmxTips);
                                    Console.WriteLine(Language.Text.Main.PleaseTypeMessage);
                                    string xmxresult = Console.ReadLine();
                                    if(xmxresult.Contains("-Xmx") && !xmxresult.Contains(" ")){
                                        File.WriteAllText("configs/javaXmx",xmxresult);
                                        Console.WriteLine(Language.Text.GameSettings.MemoryAllocation.FinishTips);
                                        goto while_game_settings_mem;
                                    }
                                    else{
                                        Console.WriteLine(Language.Text.Main.BadInput);
                                    }
                                }
                                continue;
                            case "2":
                                while(true){
                                    Console.WriteLine(Language.Text.GameSettings.MemoryAllocation.XmnTips);
                                    Console.WriteLine(Language.Text.Main.PleaseTypeMessage);
                                    string xmnresult = Console.ReadLine();
                                    if(xmnresult.Contains("-Xms") && !xmnresult.Contains(" ")){
                                        File.WriteAllText("configs/javaXms",xmnresult);
                                        Console.WriteLine(Language.Text.GameSettings.MemoryAllocation.FinishTips);
                                        goto while_game_settings_mem;
                                    }
                                    else{
                                        Console.WriteLine(Language.Text.Main.BadInput);
                                    }
                                }
                                continue;
                            case "3":
                                goto while_game_settings;
                            default:
                                Console.WriteLine(Language.Text.Main.BadInput);
                                continue;
                        }
                        while_game_settings_mem:;
                    }
                    break;
                case "2":
                    Console.WriteLine(Language.Text.GameSettings.ResSet.width_tips);
                    File.WriteAllText("configs/width",Console.ReadLine());
                    Console.WriteLine(Language.Text.GameSettings.ResSet.height_tips);
                    File.WriteAllText("configs/height",Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine(Language.Text.GameSettings.CustomLaunchScriptTips);
                    break;
                case "4":
                    goto over_while;
                default:
                    Console.WriteLine(Language.Text.Main.BadInput);
                    break;
            }
            while_game_settings:;
        }
        over_while:;
    }
}
