using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVS_Script_Creator
{
    class Filesave
    {
       
        public string videoInput { get; set; }
        public Boolean isTrimChecked { get; set; }
        public Array trim { get; set; }
        public Boolean isResizeChecked { get; set; }
        public string resize { get; set; }
        public Boolean isFadeChecked { get; set; }
        public string fade { get; set; }

        private string outputPathAVS = Properties.Settings.Default.AVSOutput.ToString();
        private string credits = "#Created with AVS-Script-Creator by Steffen Köhler";
        private string pluginTransAll = "LoadPlugin('E:\\Software\\AviSynth 2.5\\plugins\\TransAll.dll')";
        private string pluginSplineResize = "LoadPlugin('E:\\Software\\SagaraS Scriptmaker\\Plugins\\SplineResize.dll')";

    }







   
                   
                  
}
