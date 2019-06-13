using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Models;
using Data.Context;

namespace Logic
{
    public class YoutuberLogic
    {

        private YoutuberRepository youtuberRepository = new YoutuberRepository(new YoutuberContext());

        public List<Youtuber> GetAllYouTubers() => youtuberRepository.GetAllYouTubers();

        public List<Product> GetYoutubersProducts(int YoutuberId) => youtuberRepository.GetYoutubersProducts(YoutuberId);

        public void DeletYoutuber(int Youtuberid) => youtuberRepository.DeletYoutuber(Youtuberid);

        public void AddYoutuber(string YoutuberName, string YoutuberImage) => youtuberRepository.AddYoutuber(YoutuberName, YoutuberImage);

        public void YoutuberEdit(int YoutberId, string YouTuberName, string YoutuberImage) => youtuberRepository.YoutuberEdit(YoutberId, YouTuberName, YoutuberImage);
    }
}
