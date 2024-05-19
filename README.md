# SetWallpaper

**This program is intended for a Windows operating system!** 

This is a very simple C# application which allows me to change my wallpaper on the fly.

> [!WARNING]
> Make sure you change the path in the program to your backgrounds folder!

## Building & Running

Provided in the [Makefile](./Makefile), you can either run `make` or you can copy and paste the following commands:

```sh
$ dotnet build 
$ dotnet run 
```

### Exporting as a single executable

Either run `make export` or copy the following:

```sh
$ dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true /p:SelfContained=true 
```

## Configuration

When you are changing your path, make sure it is the full path and follows the escaped path format!

You can also modify the command window showing or not by editing the csproj file and changing WinExe to Exe!

## Credits

This file has been made by Taran Nagra.
Help from:
  - https://techexpert.tips/powershell/powershell-configure-wallpaper/
