using System.Collections.Generic;

namespace Pronia.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string FooterLogo { get; set; }
        public string Search { get; set; }
        public string AccoundIcon { get; set; }
        public string WishListIcon { get; set; }
        public string BasketIcon { get; set; }
        public string Phone { get; set; }
        public string AdvertisementImage { get; set; }
        public List<SocialMedia> SocialMedia { get; set; }
    }
}
