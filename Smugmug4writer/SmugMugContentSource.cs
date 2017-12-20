using System;
using System.Collections.Generic;
using System.Text;
using WindowsLive.Writer.Api;


namespace SmugMug4writer
{
    [InsertableContentSource("SmugMug Image"), 
    WriterPlugin("f0b2528b-8a0b-42cb-b222-4f5de3fb3816", "SmugMug Image Reference", ImagePath = "Images.smugMug_16x16.bmp",
        PublisherUrl = "http://www.codeplex.com/smugmug4writer", Description = "Plugin for retrieving SmugMug images")]
    public class SmugMugContentSource : ContentSource
    {
        public string GetImageUrl(Smugmug.Image image, ImageSize imgsize)
        {
            string url = null;

            switch (imgsize)
            {
                case ImageSize.Tiny:
                    url = image.TinyUrl;
                    break;
                case ImageSize.Thumbnail:
                    url = image.ThumbUrl;
                    break;

                case ImageSize.Small:
                    url = image.SmallUrl;
                    break;

                case ImageSize.Medium:
                    url = image.MediumUrl;
                    break;

                case ImageSize.Large:
                    url = image.LargeUrl;
                    break;

                case ImageSize.Original:
                    url = image.OriginalUrl;
                    break;
            }

            return url;
        }

        public override System.Windows.Forms.DialogResult CreateContent(System.Windows.Forms.IWin32Window dialogOwner, ref string content)
        {
            using (InsertSmugMugImageForm smugMug = new InsertSmugMugImageForm())
            {
                System.Windows.Forms.DialogResult formResult = smugMug.ShowDialog(dialogOwner);

                if (formResult == System.Windows.Forms.DialogResult.OK)
                {
                    if (smugMug.InsertOption == InsertOptions.Image)
                    {
                        ImageSize imgsize = smugMug.SelectedImageSize;

                        foreach (Smugmug.Image image in smugMug.SelectedPhotos)
                        {
                            content += Utils.GenerateContentHtml(image, GetImageUrl(image, imgsize), smugMug.CssClass, smugMug.BorderThickness, smugMug.VerticalPadding, smugMug.HorizontalPadding, smugMug.Alignment, smugMug.EnableHyperLink);
                        }
                    }
                    else if(smugMug.InsertOption == InsertOptions.Gallery)
                    {
                        bool includeCss = smugMug.IncludeCss;
                        bool useLightBox = smugMug.UseLightBox;
                        content += Utils.GenerateGalleryHtml(smugMug.SelectedAlbum, smugMug.SelectedPhotos, includeCss, useLightBox);
                    }
                }
                return formResult;
            }
        }

        public override void Initialize(IProperties pluginOptions)
        {
            base.Initialize(pluginOptions);
        }
    }
}
