using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Models;


namespace Data
{
    public class YoutuberRepository
    {
        private IYoutuberContext context;

        public YoutuberRepository(IYoutuberContext context)
        {
            this.context = context;
        }

        public List<Youtuber> GetAllYouTubers() => context.GetAllYouTubers();
        public List<Product> GetYoutubersProducts(int YoutuberId) => context.GetYoutubersProducts(YoutuberId);

        public void DeletYoutuber(int Youtuberid) => context.DeletYoutuber( Youtuberid);

        public void AddYoutuber(string YoutuberName, string YoutuberImage) => context.AddYoutuber(YoutuberName, YoutuberImage);

        public void YoutuberEdit(int YoutberId, string YouTuberName, string YoutuberImage) => context.YoutuberEdit(YoutberId, YouTuberName, YoutuberImage);
    }
}
