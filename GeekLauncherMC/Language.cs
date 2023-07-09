using System.IO;

public static class Language{
    public static class Text{
        public static class Main{
            public static string WelcomeMessage = "";
            public static string FeatureSelectionMessage_0 = "";
            public static string FeatureSelectionMessage_1 = "";
            public static string PleaseTypeMessage = "";
            public static string NowLoginAccountMessage = "";
            public static string MicrosoftLogin = "";
            public static string OfflineLogin = "";
            public static string NowSelectVersion = "";
            public static string BadInput = "";
        }
        public static class FunnyTips{
            public static string BuyGenuinePls = "";
            public static string CrashTips = "";
            public static string ROAR_OF_THE_BEAST = "";
            public static string Get_Grand_Theft_Auto_V_Free = "";
        }
        public static class Tips{
            public static string FeatureNotOpen = "";
            public static string CtrlCExit = "";
            public static string EditorTips = "";
        }
        public static class ChangeVersion{
            public static string ScanningVersions = "";
            public static string SelectTIps = "";
            public static string NotAnyExistsVersion = "";
            public static string Finish = "";
            public static string WARN_Scan_Only_Minecraft_folder = "";
            public static string TypeJarName = "";
        }
        public static class LaunchGame{
            public static string NotSelectVersion = "";
            public static string GameProcessStop = "";
        }
        public static class GameSettings{
            public static string FeatureSelectionMessage_0 = "";
            public static string FeatureSelectionMessage_1 = "";
            public static string CustomLaunchScriptTips = "";
            public static class MemoryAllocation{
                public static string FeatureSelectionMessage_0 = "";
                public static string FeatureSelectionMessage_1 = "";
                public static string XmxTips = "";
                public static string XmnTips = "";
                public static string FinishTips = "";
            }
            public static class ResSet{
                public static string width_tips = "";
                public static string height_tips = "";
            }
        }
    }
    public static void InitLanguage(){
        switch(File.ReadAllText("configs/language")){
            case "chs":
                Text.Main.WelcomeMessage = "欢迎来到GeekLauncherMC！";
                Text.Main.FeatureSelectionMessage_0 = "请输入数字以选择功能：";
                Text.Main.FeatureSelectionMessage_1 = "(1). 启动游戏   (2). 切换版本   (3). 游戏设置   (4).下载游戏   (5).帐号设置   (6). GeekLauncherMC Settings   (7). 退出GeekLauncherMC";
                Text.Main.PleaseTypeMessage = "请输入：";
                Text.Main.NowLoginAccountMessage = "当前登录的帐号为：";
                Text.Main.MicrosoftLogin = "微软登录";
                Text.Main.OfflineLogin = "离线登录";
                Text.FunnyTips.BuyGenuinePls = "亲这边建议您尽快入正哦（笑";
                Text.Main.NowSelectVersion = "当前选择启动的版本是：";
                Text.FunnyTips.CrashTips = "哎呀呀，崩溃了啊，爽不爽啊";
                Text.Tips.FeatureNotOpen = "该功能暂未开放，唔...咕咕咕咕咕咕";
                Text.ChangeVersion.ScanningVersions = "正在扫描可用版本...";
                Text.ChangeVersion.SelectTIps = "你看你要选哪个啊（输入样例：.minecraft/versions/1.19  最后不要加/）：";
                Text.ChangeVersion.NotAnyExistsVersion = "没有任何可用的版本...先下一个吧？";
                Text.ChangeVersion.Finish = "成功切换版本～";
                Text.FunnyTips.ROAR_OF_THE_BEAST = "哼哼，啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊，啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊，哼啊，啊啊啊啊啊，啊，啊";
                Text.FunnyTips.Get_Grand_Theft_Auto_V_Free = "https://www.bilibili.com/video/BV1uT4y1P7CX";
                Text.Main.BadInput = "呃呃呃...你输入的东西我看不懂啊，你确定你有按照要求输入东西吗？";
                Text.Tips.CtrlCExit = "其实用Ctrl+C可以更快捷的退出GeekLauncherMC...你学会了吗？";
                Text.ChangeVersion.WARN_Scan_Only_Minecraft_folder = "警告：游戏扫描虽然输出是绝对路径，但其只会扫描到GeekLauncher运行目录（也就是执行GeekLauncher时的shell目录）下的.minecraft文件夹中。在选择版本时，请最好输入程序扫描后输出的绝对路径，当然相对路径也不是不行，但要根据自己shell的目录来判断可行性";
                Text.LaunchGame.NotSelectVersion = "你还没有选择版本，先去选择个版本再来启动吧！";
                Text.ChangeVersion.TypeJarName = "输入游戏jar名称（若游戏未经任何修改，jar名称一般为1.19.jar 1.18.jar 这样）：";
                Text.LaunchGame.GameProcessStop = "游戏进程已停止";
                Text.GameSettings.FeatureSelectionMessage_0 = "------ 游戏设置 ------";
                Text.GameSettings.FeatureSelectionMessage_1 = "(1). 内存分配   (2). 游戏窗口分辨率   (3). 自定义启动命令   (4).返回主菜单";
                Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_0 = "------ 游戏设置 > 内存分配 ------";
                Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_1 = "(1). Xmx（最大内存）   (2).Xms（最小内存）   (3). 返回上一级";
                Text.GameSettings.MemoryAllocation.XmxTips = "输入游戏可占用的最大内存，例如我想让游戏最大占用4096M的内存，那么我该输入：-Xmx4096M";
                Text.GameSettings.MemoryAllocation.XmnTips = "输入游戏可占用的最小内存，例如我想让游戏最少占用128M的内存，那么我该输入：-Xms128M";
                Text.GameSettings.MemoryAllocation.FinishTips = "操作成功完成！";
                Text.GameSettings.CustomLaunchScriptTips = "若要自定义启动参数，请使用其它文本编辑器编辑configs/launch_script_custom文件，覆盖掉其中原内容即可";
                Text.GameSettings.ResSet.width_tips = "输入窗口长度：";
                Text.GameSettings.ResSet.height_tips = "输入窗口宽度：";
                Text.Tips.EditorTips = "其实相对于在GeekLauncherMC内进行游戏设置，我们更乐意让您使用自己的编辑器手动编辑configs文件夹下的文件，体验可能会更好一些～";
                break;
            case "en":
                Text.Main.WelcomeMessage = "Welcome to GeekLauncherMC!";
                Text.Main.FeatureSelectionMessage_0 = "Please enter a number to select a function:";
                Text.Main.FeatureSelectionMessage_1 = "(1). Launch Game   (2). Switch Versions   (3). Game Settings   (4). Download Game   (5). Account Settings   (6). GeekLauncherMC Settings   (7). Exit GeekLauncherMC";
                Text.Main.PleaseTypeMessage = "Please enter:";
                Text.Main.NowLoginAccountMessage = "The currently logged in account is:";
                Text.Main.MicrosoftLogin = "Microsoft Login";
                Text.Main.OfflineLogin = "Offline Login";
                Text.FunnyTips.BuyGenuinePls = "Please buy the genuine game as soon as possible lol";
                Text.Main.NowSelectVersion = "The version currently selected to launch is:";
                Text.FunnyTips.CrashTips = "Oops, it's crashed...how cool!";
                Text.Tips.FeatureNotOpen = "This function is not open yet";
                Text.ChangeVersion.ScanningVersions = "Scanning for available versions...";
                Text.ChangeVersion.SelectTIps = "You see which one you want to choose (input example: .minecraft/versions/1.19   do not add / at the end):";
                Text.ChangeVersion.NotAnyExistsVersion = "There aren't any versions available... download one first?";
                Text.ChangeVersion.Finish = "Successfully switched versions~";
                Text.FunnyTips.ROAR_OF_THE_BEAST = "hum, ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah ah";
                Text.FunnyTips.Get_Grand_Theft_Auto_V_Free = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                Text.Main.BadInput = "Uh uh... Program don't understand what you entered, are you sure you entered as required?";
                Text.Tips.CtrlCExit = "In fact, you can use Ctrl+C to exit GeekLauncherMC more quickly... Have you learned it?";
                Text.ChangeVersion.WARN_Scan_Only_Minecraft_folder = "Warning: Although the output of the game scan is an absolute path, it will only scan the .minecraft folder under the running directory of GeekLauncher (that is, the shell directory when GeekLauncher is executed). When choosing a version, it is best to enter the absolute path output by the program after scanning. Of course, the relative path available either, but the feasibility should be judged according to the directory of your own shell.";
                Text.LaunchGame.NotSelectVersion = "You haven't selected a version, go to select a version pls";
                Text.ChangeVersion.TypeJarName = "Enter the game jar name (if the game has not been modified, the jar name is generally 1.19.jar 1.18.jar):";
                Text.LaunchGame.GameProcessStop = "Game process has stopped";
                Text.GameSettings.FeatureSelectionMessage_0 = "------ Game Settings ------";
                Text.GameSettings.FeatureSelectionMessage_1 = "(1). Memory allocation (2). Game window resolution (3). Custom launch command (4). Return to main menu";
                Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_0 = "------ Game Settings > Memory Allocation ------";
                Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_1 = "(1). Xmx (maximum memory) (2). Xms (minimum memory) (3). Return to the previous level";
                Text.GameSettings.MemoryAllocation.XmxTips = "Enter the maximum memory that the game can occupy. For example, if I want the game to occupy a maximum memory of 4096M, then I should input: -Xmx4096M";
                Text.GameSettings.MemoryAllocation.XmxTips = "Enter the minimum memory that the game can occupy. For example, if I want the game to occupy at least 128M of memory, then I should enter: -Xms128M";
                Text.GameSettings.MemoryAllocation.FinishTips = "Operation completed successfully!";
                Text.GameSettings.CustomLaunchScriptTips = "To customize the launch parameters, please use another text editor to edit the configs/launch_script_custom file and overwrite the original content";
                Text.GameSettings.ResSet.width_tips = "Input window length:";
                Text.GameSettings.ResSet.height_tips = "Input window width:";
                Text.Tips.EditorTips = "In fact, rather than setting the game in GeekLauncherMC, we are more than happy to let you use your own editor to manually edit the files in the configs folder, the experience may be better~";
                break;
            case "cht":
                Text.Main.WelcomeMessage = "歡迎來到GeekLauncherMC！";
                Text.Main.FeatureSelectionMessage_0 = "請輸入數字以選擇功能：";
                Text.Main.FeatureSelectionMessage_1 = "(1). 啟動遊戲   (2). 切換版本   (3). 遊戲設置   (4).下載遊戲   (5).帳號設置   (6). GeekLauncherMC Settings   (7). 退出GeekLauncherMC";
                Text.Main.PleaseTypeMessage = "請輸入：";
                Text.Main.NowLoginAccountMessage = "當前登錄的帳號為：";
                Text.Main.MicrosoftLogin = "微軟登錄";
                Text.Main.OfflineLogin = "離線登錄";
                Text.FunnyTips.BuyGenuinePls = "親這邊建議您盡快入正哦（笑";
                Text.Main.NowSelectVersion = "當前選擇啟動的版本是：";
                Text.FunnyTips.CrashTips = "哎呀呀，崩潰了啊，爽不爽啊";
                Text.Tips.FeatureNotOpen = "該功能暫未開放，唔...咕咕咕咕咕咕";
                Text.ChangeVersion.ScanningVersions = "正在掃描可用版本...";
                Text.ChangeVersion.SelectTIps = "你看你要選哪個啊（輸入樣例：.minecraft/versions/1.19  最後不要加/）：";
                Text.ChangeVersion.NotAnyExistsVersion = "沒有任何可用的版本...先下一個吧？";
                Text.ChangeVersion.Finish = "成功切換版本～";
                Text.FunnyTips.ROAR_OF_THE_BEAST = "哼哼，啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊，啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊啊，哼啊，啊啊啊啊啊，啊，啊";
                Text.FunnyTips.Get_Grand_Theft_Auto_V_Free = "https://www.bilibili.com/video/BV1uT4y1P7CX";
                Text.Main.BadInput = "呃呃呃...你輸入的東西我看不懂啊，你確定你有按照要求輸入東西嗎？";
                Text.Tips.CtrlCExit = "其實用Ctrl+C可以更快捷的退出GeekLauncherMC...你學會了嗎？";
                Text.ChangeVersion.WARN_Scan_Only_Minecraft_folder = "警告：遊戲掃描雖然輸出是絕對路徑，但其只會掃描到GeekLauncher運行目錄（也就是執行GeekLauncher時的shell目錄）下的.minecraft文件夾中。在選擇版本時，請最好輸入程序掃描後輸出的絕對路徑，當然相對路徑也不是不行，但要根據自己shell的目錄來判斷可行性";
                Text.LaunchGame.NotSelectVersion = "你還沒有選擇版本，先去選擇個版本再來啟動吧！";
                Text.ChangeVersion.TypeJarName = "輸入遊戲jar名稱（若遊戲未經任何修改，jar名稱一般為1.19.jar 1.18.jar 這樣）：";
                Text.LaunchGame.GameProcessStop = "遊戲進程已停止";
                Text.GameSettings.FeatureSelectionMessage_0 = "------ 遊戲設置 ------";
                Text.GameSettings.FeatureSelectionMessage_1 = "(1). 內存分配   (2). 遊戲窗口分辨率   (3). 自定義啟動命令   (4).返回主菜單";
                Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_0 = "------ 遊戲設置 > 內存分配 ------";
                Text.GameSettings.MemoryAllocation.FeatureSelectionMessage_1 = "(1). Xmx（最大內存）   (2).Xms（最小內存）   (3). 返回上一級";
                Text.GameSettings.MemoryAllocation.XmxTips = "輸入遊戲可佔用的最大內存，例如我想讓遊戲最大佔用4096M的內存，那麼我該輸入：-Xmx4096M";
                Text.GameSettings.MemoryAllocation.XmxTips = "輸入遊戲可佔用的最小內存，例如我想讓遊戲最少佔用128M的內存，那麼我該輸入：-Xms128M";
                Text.GameSettings.MemoryAllocation.FinishTips = "操作成功完成！";
                Text.GameSettings.CustomLaunchScriptTips = "若要自定義啟動參數，請使用其它文本編輯器編輯configs/launch_script_custom文件，覆蓋掉其中原內容即可";
                Text.GameSettings.ResSet.width_tips = "輸入窗口長度：";
                Text.GameSettings.ResSet.height_tips = "輸入窗口寬度：";
                Text.Tips.EditorTips = "其實相對於在GeekLauncherMC內進行遊戲設置，我們更樂意讓您使用自己的編輯器手動編輯configs文件夾下的文件，體驗可能會更好一些～";
                break;
        }
    }
}
