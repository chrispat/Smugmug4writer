using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smugmug;

namespace SmugMug4writer
{
    
    internal class SmugmugFacade
    {
         string apiKey = SmugMug4writer.Properties.Settings.Default.ApiKey;
         string apiVersion = SmugMug4writer.Properties.Settings.Default.ApiVersion;
         Login session = null;
        SmugmugClient smugMug = null;

         internal SmugmugFacade()
         {
             smugMug = new SmugmugClient(apiVersion, new WebClient(), new RestProtocol(), new NLogLogger());

         }

         internal void Login()
         {
             session = new LoginAnonymously(apiKey).Login(smugMug);
         }


         internal IEnumerable<Album> GetAlbums(string nickName)
         {
             return smugMug.GetAlbums(session.Session.Id, "", null, false, null, nickName, false, null, true);
         }

         internal IEnumerable<Image> GetImages(int albumId, string albumKey)
         {
             return smugMug.GetImages(session.Session.Id, albumId, true, null, null, albumKey);
         }
    }
}
