# DongFeng Express

#### Overview

DongFeng Express is a tiny framework which can be used to deploy .Net desktop application without a need of complicated installer or updater when running with Windows Sandbox, it downloads DLLs and resource files on demand, thus the application can be launched with a minimum set of files (as less as two files). It is suitable for enterprise internal applications。

#### Framework Components

DongFeng Express is consist of three components: 

1.  Base: An simple Web API server based on Simple HTTP，you can download files of the application from it.
2.  Launcher ：A Laucher.exe which you can download from Base via a browser，once it is executed, it starts to download the minimum files for the application to start (starter files).
3.  Jellyfish.DLL: Provids an handler for resolving missing assemblies from Base, i.e., it downloads a DLL from Base if the DLL is missing from your application's folder


#### How to run the demo

Recommend Windows 10/11 as it needs Windows Sandbox (it doesn't mean DongFeng Express is only supported by Windows 10/11)

1.  Complie and run DongFeng.Base, it runs on port 8888 by default，it can be changed in formMain.cs line 45 (at the time this document is written)。Please note that the name of the machine running Base will be referred as "machine name" in following settings（I use “BOOK3” as the example）。(You may need to setup port 8888 with Windows Firewall to allowed other machine to access Base)
2.  Open Program.cs in DongFeng.Launcher project, modify the machine name and port, get it compiled
3.  Open Program.cs in demo WindowsFormsApp project，modify the machine name and port, get it compiled
4.  Back to Base application，press "Browse ..." button for “App Base Folder”, make it pointing to WindowsFormsApp root folder, for example, C:\Dev\dongfeng-express\Src\Demos\WindowsFormsApp\bin\Debug， press "Browse ..." button for “Laucher Path”, make it pointing to DongFeng.Launcher.exe，for example, C:\Dev\dongfeng-express\Src\DongFeng.Launcher\bin\Debug\DongFeng.Launcher.exe
5.  Open a Windows Sandbox, within it, use a browser to visit http://BOOk3:8888/dongfeng-express, follow the link to download Launcher.exe and runt it，it will start to download WindowsFormsApp's starter files and launche WindowsFormsApp, the Newtonsoft.Json.DLL, a DLL which is not need in the beginning will be download after "button2" is clicked.
6.  Close Windows Sandbox, everything's gone. You can repeat 5 again and again, if the application is updated, it will automatically download and run the latest version.

#### How to use

1.  According to your application's need, modify machine name and port to build corresponding Base and Launcher
2.  Add Jellyfish.DLL to your application，at the most start point of your application（don't forget to modify "BOOK3:8888" to the same settings as above 1）：
        new AppAssemblyResolveEventHandler("BOOK3:8888/DongFeng-Express").Init();
3.  Create a text file DongFengBaoGuo.txt，put application's name at first line, followed by its setting file and put Jellyfish.DLL as third line, save this file in the root folder of your application。Below is the example file from WindowsFormsApp:

        WindowsFormsApp.exe
        WindowsFormsApp.exe.config
        Jellyfish.dll

4.  Run DongFeng.Base.exe，set up “App Base Folder” and “Launcher Path”
5.  Open an browser to visit "{machine name of Base}/DongFeng-Express and follow the link。
