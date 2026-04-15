using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


using System.Net;
using System.IO;

namespace Seed_Storage
{
    class Picture
    {




        public  void TakePicture(Guid Ticket_Weight_UID,int Ticket, bool Inbound )
        {

            string Camera;

            string Password;
            byte[] NoImage;

            using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter System_SetupTableAdapter = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
            {
                using (Seed_Storage_Dataset.System_SetupDataTable System_Setup = new Seed_Storage_Dataset.System_SetupDataTable())
                {
                    System_SetupTableAdapter.Fill(System_Setup);
                    Seed_Storage_Dataset.System_SetupRow row = System_Setup[0];
                     NoImage = row.No_Picture_Image;

                    if (Inbound)
                    {
                        Camera = row.Inbound_Camera_IP_Address;
                        Password = row.Inbound_Camera_Admin_Pass;
                    }
                    else
                    {
                        Camera = row.Outbound_Camera_IP_Address;
                        Password = row.Outbound_Camera_Admin_Pass;
                    }

                }
            }
            string Source = "http://" + Camera + "/Streaming/channels/1/picture";


            string sourceURL = Source;

            byte[] buffer = new byte[100000];
            // create HTTP request
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceURL);
            req.Timeout = 5000;
            // set login and password
            req.Credentials = new NetworkCredential("admin", Password);
            // get response
            try
            {
                WebResponse resp = req.GetResponse();
                // get response stream
                Stream stream = resp.GetResponseStream();
                // get bitmap
                using (MemoryStream ms = new MemoryStream())
                {
                    //string Path = System.Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                    string Path = "C:\\Pics";
                    string Dir = Path + "\\Images";

                    if (!System.IO.Directory.Exists(Dir)) System.IO.Directory.CreateDirectory(Dir);
                    string FileName = Dir+"\\"+Ticket.ToString();
                    if (Inbound)
                    {
                        FileName = FileName + "-inbound.png";
                    }
                    else
                    {
                        FileName = FileName + ".png";

                    }

                     
                    stream.CopyTo(ms);
                    Bitmap bmp = (Bitmap)Bitmap.FromStream(ms);
                    //Removed Resizing by Commenting Line Below
                    //bmp = (Bitmap)resizeImage(bmp, new Size(405, 720));
                    bmp.Save(FileName , System.Drawing.Imaging.ImageFormat.Png);
                    using (Seed_Storage.Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage.Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                    {
                        Image img= (Image)bmp;
                        byte[] bImage= ConvertImageToByteArray(img,ImageFormat.Bmp);
                        Q.StorePicture(Ticket_Weight_UID, FileName  , Inbound);
                    }

                 
                    //new MemoryStream(buffer, 0, total));
                    //string Path ="C:\\Junk\\";// Server.MapPath("~/image/");
                    
                    //bmp.Save(Path + Ticket, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    using (Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter SystemSetupTableAdapter = new Seed_Storage_DatasetTableAdapters.System_SetupTableAdapter())
                    {
                        using (Seed_Storage_Dataset.System_SetupDataTable SystemSetupTable = new Seed_Storage_Dataset.System_SetupDataTable())
                        {
                            SystemSetupTableAdapter.Fill(SystemSetupTable);
                            {

                                using (Seed_Storage.Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage.Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                                {
                                    //byte[] bImage = SystemSetupTable[0].No_Picture_Image; 
                                    //Q.StorePicture(Ticket_Weight_UID, bImage, Inbound);
                                }

                            }

                        }

                    }

                }
                catch
                {

                }

                    Alert.Show("Could Not Save Picture " + ex.Message);
            }
        }



        public  void SaveNoPicture(string IMagePath)
        {
            try
            {

                // get response stream

                // get bitmap


                using (FileStream fs = File.OpenRead(IMagePath))
                {
                    

                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        Bitmap bmp = (Bitmap)Bitmap.FromStream(ms);
                        //Removed Resizing by Commenting Line Below
                        //bmp = (Bitmap)resizeImage(bmp, new Size(405, 720));
                        using (Seed_Storage.Seed_Storage_DatasetTableAdapters.QueriesTableAdapter Q = new Seed_Storage.Seed_Storage_DatasetTableAdapters.QueriesTableAdapter())
                        {
                            Image img = (Image)bmp;
                            byte[] bImage = ConvertImageToByteArray(img, ImageFormat.Bmp);
                            Q.UpdateNoPictureImage(bImage);
                           
                        }


        
                    }
                }
            }
            catch (Exception ex)
            {
                Alert.Show("Could Not Save No Picture Image " + ex.Message);
            }

        }


        private static byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert,ImageFormat formatOfImage)
        {
            byte[] Ret;

            try
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }

            return Ret;
        } 


        private Image resizeImage(Image imgToResize, Size size)
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
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        private void saveJpeg(string path, Bitmap img, long quality)
        {
            // Encoder parameter for image quality
            EncoderParameter qualityParam =
                new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

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

    }
}
