# GeekLauncherMC
### GeekLauncherMC - 一款主打简约、极客风格的Minecraft命令行启动器

Language: CHS | [EN](README_EN.md)

## 简单介绍
GeekLauncherMC是一款简约、极客的Minecraft命令行启动器，整个启动其除去Minecraft游戏体积后大小仅100KB左右，抛去繁杂，拥抱简洁，满足普通玩家的日常需求，并提供完整的Linux MacOS支持

## 制作进度

[x] 启动游戏

[x] 切换版本

[  ] 下载游戏

[x] 游戏设置

[  ] 离线帐号设置

[  ] 微软登录

## 兼容性
由于GeekLauncherMC使用兼容性强大的.NET 6编写，且由于是控制台应用，所以GeekLauncherMC可以兼容任何主流操作系统以及桌面环境，例如Linux下的DWM KDE XFCE都能完美兼容（甚至可以在tty中运行

## 下载

对于不想手动编译的懒人们来说，可以从Actions中下载到可执行文件：

[Actions](https://github.com/Searchstars/GeekLauncherMC/actions)


## 编译
先clone此仓库：

`git clone https://github.com/SearchstarsGeekLauncherMC`

然后直接执行：

`dotnet run --project GeekLauncherMC/GeekLauncherMC.csproj`

即可完成编译并运行，届时可在`GeekLauncherMC/bin/Debug/net6.0`中找到编译完成的可执行文件 理论上来说只要你的电脑安装好了.NET开发环境以及Java即可完美编译运行使用