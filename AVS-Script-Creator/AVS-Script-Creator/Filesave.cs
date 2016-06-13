using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS_Script_Creator
{
    class Filesave
    {
       
        public string videoInput { get; set; }
        public int number { get; set; }
        public string trim { get; set; }
        public string resize { get; set; }
        public string fade { get; set; }

        private string outputPathAVS = Properties.Settings.Default.AVSOutput.ToString();
        private static char separator = '"';
        private string credits = "#Created with AVS-Script-Creator by Steffen Köhler";
        private string pluginTransAll = "LoadPlugin(" + separator + "E:\\Software\\AviSynth 2.5\\plugins\\TransAll.dll" + separator + ")";
        private string pluginSplineResize = "LoadPlugin(" + separator + "E:\\Software\\SagaraS Scriptmaker\\Plugins\\SplineResize.dll" + separator + ")";


        public void save()
        {
            string savePath = videoInput;

            savePath = savePath.Replace(".avi", "");
            string[] tokens = savePath.Split(new[] { ":\\" }, StringSplitOptions.None);
            savePath = tokens[1];

            string output = Properties.Settings.Default.AVSOutput.ToString() + "\\";
            string path = @output + savePath + " #" + number + ".avs";


            if(fade != "No")
            {
                fade = "clip." + fade + "(30, fps = 30)";
            } else
            {
                fade = "#no fade added";
            }


            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(credits);
                    sw.WriteLine(pluginTransAll);
                    sw.WriteLine(pluginSplineResize);
                    sw.WriteLine("clip = AVISource(" + separator + videoInput + separator + ", audio = false).AssumeFPS(30, 1).ConvertToYV12()");
                    sw.WriteLine("clip = AudioDub(clip, WAVSource(" + separator + videoInput.Replace(".avi", ".wav" ) + separator + "))");
                    sw.WriteLine("clip = Trim(clip, 0, 50167)");
                    sw.WriteLine("clip.Spline100Resize(2080, 1170)");
                    sw.WriteLine(fade);
                    sw.WriteLine("clip");

                }
            }
        }

    }







   
                   
                  
}
