using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Models.Artist {Name = "Al Di Meola"});
            context.Genres.Add(new Models.Genre {Name = "Jazz"});
            context.Albums.Add(new Models.Album
            {
                Artist = new Models.Artist { Name = "Rush" },
                Genre = new Models.Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
            base.Seed(context);
        }
    }
}