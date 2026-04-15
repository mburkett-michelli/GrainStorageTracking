using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


using System.Net;
using System.IO;


public partial class _Default : Page
{

    string Outbound = "Outbound.jpg";
    string Inbound = "Inbound.jpg";

    private void GetPictures(string Source, string FileName)
    {
        
        string sourceURL = Source;

        byte[] buffer = new byte[100000];
        // create HTTP request
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceURL);
        req.Timeout = 5000;
        // set login and password
        req.Credentials = new NetworkCredential("admin", "TotalScale01");
        // get response
        try
        {
            WebResponse resp = req.GetResponse();
            // get response stream
            Stream stream = resp.GetResponseStream();
            // get bitmap
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                Bitmap bmp = (Bitmap)Bitmap.FromStream(ms);
                bmp = (Bitmap)resizeImage(bmp, new Size(405, 720));
                //new MemoryStream(buffer, 0, total));
                string Path = Server.MapPath("~/image/");

                bmp.Save(Path + FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        catch (Exception ex)
        {
            //Logging.LogMessage("Default.GetPictures", ex);
        }
    }

    

    private System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
    {
        int sourceWidth = imgToResize.Width;
        int sourceHeight = imgToResize.Height;

        float nPercent = 0;
        float nPercentW = 0;
        float nPercentH = 0;

        nPercentW = ((float)size.Width / (float)sourceWidth);
        nPercentH = ((float)size.Height / (float)sourceHeight);

        if (nPercentH < nPercentW)
            nPercent = nPercentH;
        else
            nPercent = nPercentW;

        int destWidth = (int)(sourceWidth * nPercent);
        int destHeight = (int)(sourceHeight * nPercent);

        Bitmap b = new Bitmap(destWidth, destHeight);
        Graphics g = Graphics.FromImage((System.Drawing.Image)b);
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;

        g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
        g.Dispose();

        return (System.Drawing.Image)b;
    }

    private void saveJpeg(string path, Bitmap img, long quality)
    {
        // Encoder parameter for image quality
        EncoderParameter qualityParam =
            new EncoderParameter(Encoder.Quality, quality);

        // Jpeg image codec
        ImageCodecInfo jpegCodec = getEncoderInfo("image/jpeg");

        if (jpegCodec == null)
            return;

        EncoderParameters encoderParams = new EncoderParameters(1);
        encoderParams.Param[0] = qualityParam;

        img.Save(path, jpegCodec, encoderParams);
    }

    private ImageCodecInfo getEncoderInfo(string mimeType)
    {
        // Get image codecs for all image formats
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

        // Find the correct image codec
        for (int i = 0; i < codecs.Length; i++)
            if (codecs[i].MimeType == mimeType)
                return codecs[i];
        return null;
    }



    protected void ImageOut_PreRender(object sender, EventArgs e)
    {
      

    }

    protected void ImageIn_PreRender(object sender, EventArgs e)
    {
     
    }

   
}