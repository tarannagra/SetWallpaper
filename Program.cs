/* 
    SetWallpaper in C#
    ---
    I have made this because the PowerShell variant is slow as fuck.

    Author:
        - Taran Nagra

    Could not have done this without the original in PowerShell!!
    Source: https://techexpert.tips/powershell/powershell-configure-wallpaper/
*/


using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;

namespace SetWallpaper {
    
    public class Wallpaper {

        // privates
        private static string path = "C:\\Users\\Taran\\Documents\\Customisation\\Backgrounds";
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int action, int uParam, string filename, int winIni);

        private static void SearchDirectory() {
            DirectoryInfo directoryInfo = new(path);
            if (!directoryInfo.Exists) {
                Console.WriteLine("Directory does not exist!");
                Environment.Exit(1);
            }
            Random random = new Random();
            var filename = directoryInfo.GetFiles()
                .OrderBy(f => random.Next())
                .FirstOrDefault();
            if (filename != null) {
                // Console.WriteLine("Changing wallpaper...");
                SystemParametersInfo(20, 0, filename.FullName, 3);
                // Console.WriteLine("Changed wallpaper!");         
            } else {
                Console.WriteLine("Directory is empty, please change the path!");
                Environment.Exit(1);
            }
        }

        public static void Main(string[] args) {
            SearchDirectory();
        }
    }
}
