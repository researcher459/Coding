using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using GdPicture14;

namespace MICR
{
    class DetectMICR
    {

      private readonly GdPictureImaging _gdPictureImaging = new GdPictureImaging();

        private int _imageId;

        //private int _initialImageId;
        StringBuilder sb = new StringBuilder();         

      
      

        public string DetectMICRLine(string ImageFile)
        {
           // CloseNativeImage();
            _imageId = _gdPictureImaging.CreateGdPictureImageFromFile(ImageFile);
            _gdPictureImaging.AutoDeskew(_imageId);
           // System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
           // sw.Start();
            int Length = 48;
            StringBuilder result = new StringBuilder(_gdPictureImaging.MICRDoMICR(_imageId, MICRFont.MICRFontE13B, 
                MICRContext.MICRContextLineFinding, "0123456789ABCD", Length));

            result = result.Replace(System.Convert.ToString('\0'), "?");
           // sw.Stop();
            GdPictureStatus status = _gdPictureImaging.GetStat();

            if (status == GdPictureStatus.OK)
            {

                result.ToString();

        
              
           }

            return result.ToString();
  
        }
    }
}

    