using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WMPLib;


namespace ConsoleMusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsMediaPlayer musicplayer = new WindowsMediaPlayer();

            Console.WriteLine(" MEDIAPLAYER ");
            Console.WriteLine(" =========== ");

             Console.WriteLine($"Bestand afspelen : C:\\Users\\joao-\\mymusic\\Te-Amo.mp3");
            
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            musicplayer.URL = System.IO.Path.Combine(musicFolder, @"C:\\Users\\joao-\\mymusic\\Te-Amo.mp3");
            //Het liedje wordt gestart wanneer de console wordt opengemaakt.
            musicplayer.controls.play();
            Console.ReadLine();
            //Het liedje wordt gepauzeerd
            //musicplayer.controls.play();
            //
            musicplayer.controls.stop();

            int a = 1;
            if (a == 1)
            {
                musicplayer.controls.stop();
            }


        }
    }
}
