using System;
using System.Collections.Generic;
using System.Text;
using Smugmug;
using WindowsLive.Writer.Api;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace SmugMug4writer
{
    public enum ImageSize
    {
        Tiny,
        Thumbnail,
        Small,
        Medium,
        Large,
        Original
    }

    public enum InsertOptions
    {
        Image,
        Gallery
    }

    class Utils
    {
        internal static void GotoUrl(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                WindowsLive.Writer.Api.PluginDiagnostics.DisplayUnexpectedException(ex);
            }
        }

        internal static SmugmugFacade GetSmugMugApi()
        {

            return new SmugmugFacade();
        }

        internal static System.Drawing.Image GetImageFromUrl(string url)
        {
            System.Drawing.Image theImage;

            WindowsLive.Writer.Api.PluginHttpRequest http = new WindowsLive.Writer.Api.PluginHttpRequest(url);
            http.AllowAutoRedirect = true;
            http.CacheLevel = WindowsLive.Writer.Api.HttpRequestCacheLevel.BypassCache;

            using (System.IO.Stream imageStream = http.GetResponse())
            {
                theImage = System.Drawing.Image.FromStream(imageStream);
            }

            return theImage;
        }

        internal static string GenerateContentHtml(Smugmug.Image selectedPhoto, string imageUrl, string cssClass, string border, string vSpace, string hSpace, string alignment, bool hyperlink)
        {
            StringBuilder imageTag = new StringBuilder();
            string imageHtml = string.Empty;

            imageTag.Append("<img "); // begin tag
            imageTag.Append(string.Format("src=\"{0}\" ", HtmlServices.HtmlEncode(imageUrl)));
            imageTag.Append(string.Format("alt=\"{0}\" ", HtmlServices.HtmlEncode(selectedPhoto.Caption))); // alt required for XHTML
            imageTag.Append(string.Format("border=\"{0}\" ", HtmlServices.HtmlEncode(border)));

            if (cssClass.Trim().Length > 0)
            {
                imageTag.Append(string.Format("class=\"{0}\" ", cssClass));
            }

            if (hSpace.Trim().Length > 0 && hSpace != "0")
            {
                imageTag.Append(string.Format("hspace=\"{0}\" ", hSpace));
            }

            if (vSpace.Trim().Length > 0 && vSpace != "0")
            {
                imageTag.Append(string.Format("vspace=\"{0}\" ", vSpace));
            }

            if (alignment.Trim().Length > 0 && alignment.ToLower() != "none")
            {
                imageTag.Append(string.Format("align=\"{0}\" ", alignment.ToLower()));
            }

            imageTag.Append("/>"); // end tag XHTML

            imageHtml = imageTag.ToString();

            if (hyperlink)
            {
                imageHtml = string.Format("<a href=\"{0}\" title=\"{2}\">{1}</a>", HtmlServices.HtmlEncode(selectedPhoto.AlbumUrl), imageHtml, HtmlServices.HtmlEncode(selectedPhoto.Caption));
               
            }
            
            return imageHtml;
        }

        internal static string GenerateGalleryHtml(Smugmug.Album album, Smugmug.Image[] images, bool includeCss, bool useLightBox)
        {
            StringBuilder galleryHtml = new StringBuilder();
            galleryHtml.Append(SmugMug4writer.Properties.Settings.Default.GalleryCSS);
            galleryHtml.Append("<div class=\"smugcontainer\"><div class=\"smugimg\">\n<ul>\n");
            foreach (Smugmug.Image image in images)
            {
                galleryHtml.Append(ImageToli(album, image, useLightBox));  
            }
            galleryHtml.Append("</ul>\n</div></div>\n");

            return galleryHtml.ToString();
        }

        internal static string ImageToli(Smugmug.Album album, Smugmug.Image image, bool useLightBox)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<li>\n<div>");
            
            if (useLightBox)
            {
                builder.Append(string.Format("<a href=\"{0}\" title=\"{1}\" rel=\"lightbox[{2}]\">", image.LargeUrl, Utils.CaptionToHtml(image.Caption), album.Key));
            }
            else
            {
                builder.Append(string.Format("<a href=\"{0}\" title=\"{1}\">", image.LargeUrl, Utils.CaptionToHtml(image.Caption)));
               
                
            }
            builder.Append(string.Format("<img src=\"{0}\" alt=\"{1}\">", image.ThumbUrl, Utils.CaptionToHtml(image.Caption)));
            builder.Append("<br>");
            if (image.Caption != "")
            {
                builder.Append(string.Format("{0}", Utils.CaptionToHtml(image.Caption)));
            }
            else
            {
                builder.Append(string.Format("{0}", "&nbsp;"));
            }
            builder.Append("</a></div>\n</li>");
            return builder.ToString();
        }

        internal static string CaptionToHtml(string value)
        {
            return value.Replace("\r\n", "<br>");
        }

        internal static System.Drawing.Image ScaleToFixedSize(System.Drawing.Image imgPhoto, int width, int height, int offset, Color backgroundColor)
        {
            int num1 = imgPhoto.Width;
            int num2 = imgPhoto.Height;
            int num3 = 0;
            int num4 = 0;
            int num5 = offset;
            int num6 = offset;
            float single1 = 0f;
            float single2 = 0f;
            float single3 = 0f;
            single2 = ((float)width) / ((float)num1);
            single3 = ((float)height) / ((float)num2);
            if (single3 < single2)
            {
                single1 = single3;
                num5 = (int)((width - (num1 * single1)) / 2f);
            }
            else
            {
                single1 = single2;
                num6 = (int)((height - (num2 * single1)) / 2f);
            }
            int num7 = (int)(num1 * single1);
            int num8 = (int)(num2 * single1);
            Bitmap bitmap1 = new Bitmap(width, height);
            bitmap1.MakeTransparent(backgroundColor);
            bitmap1.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics graphics1 = Graphics.FromImage(bitmap1);
            graphics1.Clear(backgroundColor);
            graphics1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics1.DrawImage(imgPhoto, new Rectangle(num5, num6, num7 - offset, num8 - offset), new Rectangle(num3, num4, num1, num2), GraphicsUnit.Pixel);
            graphics1.Dispose();
            return bitmap1;
        }
    }
}
