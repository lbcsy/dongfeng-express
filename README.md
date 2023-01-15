# 东风快递

#### 介绍

东风快递 是一款专门为.Net 打造的用于桌面应用发布的框架，简单易用，无需安装程序，无需更新程序，即开即用，短小精悍，特别适合企业内部应用程序的分发。

#### 软件架构
本框架有三部分组成 

1.  基地 （Base）: 一个简单的 Web API 服务器，提供文件下载服务
2.  Launcher ：可以通过浏览器下载该Laucher.exe，一旦执行它，它将负责下载应用程序的起始部分，并启动它
3.  水母 （Jellyfish)库：应用程序集成该库，但应用程序即将调用缺失的DLL时，它将自动下载缺失的DLL


#### 如何演示

需要Windows 10/11

1.  编译 DongFeng.Base 工程并运行, 注意基地运行在口8888，你可以在formMain.cs 第45行改。基地所在的机器的名字将是下面要用到的机器名（为方便描述，假设机器名是“BOOK3”）。
2.  打开 DongFeng.Launcher 工程的Program.cs,根据你的情况，更改baseUrl中的机器名和口地址，机器名指向基地，编译好待用
3.  打开 WindowsFormsApp 工程的Program.cs，更改第15行参数中的机器名和口地址，机器名指向基地，编译好待用
4.  回到运行中的基地，将 “App Base Folder” 指向WindowsFormsApp的编译输出目录，比如 C:\Dev\dongfeng-express\Src\Demos\WindowsFormsApp\bin\Debug， 将“Laucher Path” 指向 DongFeng.Launcher的编译结果，比如C:\Dev\dongfeng-express\Src\DongFeng.Launcher\bin\Debug\DongFeng.Launcher.exe
5.  打开一个 Windows Sandbox, 在其中打开一个浏览器，在地址中输入 http://book3:8888/dongfeng-express 并回车，点击链接下载Launcher.exe并执行，你可以看到它开始下载WindowsFormsApp的起始文件并在WindowsFormsApp运行过程中继续下载所需库文件（DLL）

#### 使用说明

1.  根据你的运行环境，修改机器名和口地址，编译出对应的基地和Launcher
2.  在你的应用程序中加入Jellyfish库，在其最开始处加入下面的初始化代码（请相应调整BOOK3:8888）：
        new AppAssemblyResolveEventHandler("BOOK3:8888/DongFeng-Express").Init();
3.  编写一个DongFengBaoGuo.txt文件，第一行为应用程序文件名，第二行为其配置文件名（如果有的话），第三行为Jellyfish.DLL, 将该文件放在应用程序的根目录下。
4.  启动基地程序，设置好“App Base Folder” 和“Launcher Path”
5.  从任何能访问基地的地方用浏览器打开/DongFeng-Express就可以发布运行你的应用了。

#### 参与贡献

1.  Fork 本仓库
2.  新建 Feat_xxx 分支
3.  提交代码
4.  新建 Pull Request


#### 特点

1.  使用 Windows Sandbox 可以避免程序更新
