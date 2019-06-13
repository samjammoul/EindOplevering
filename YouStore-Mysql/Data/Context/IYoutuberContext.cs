using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public interface IYoutuberContext
    {
        List<Youtuber> GetAllYouTubers();

        List<Product> GetYoutubersProducts(int YoutuberId);

        void DeletYoutuber(int Youtuberid);

        void AddYoutuber(string YoutuberName, string YoutuberImage);

        void YoutuberEdit(int YoutberId, string YouTuberName, string YoutuberImage);
    }
}
