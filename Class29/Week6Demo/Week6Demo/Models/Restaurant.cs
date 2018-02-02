using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static System.Environment;

namespace Week6Demo.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string MenuItems { get; set; }

        public int StarRating { get; set; }
        public string ImageUrl { get; set; }
        public byte[] Image { get; set; }
        public string ImageContentType { get; set; }


        public IEnumerable<string> MenuItemList
        {
            get { return (MenuItems ?? String.Empty).Split(NewLine); }
        }

        public string GetInlineImageSrc()
        {
            if (Image == null || ImageContentType == null)
                return null;

            var base64Image = System.Convert.ToBase64String(Image);
            return $"data:{ImageContentType};base64,{base64Image}";
        }

        public void SetImage(Microsoft.AspNetCore.Http.IFormFile file)
        {
            if (file == null)
                return;

            ImageContentType = file.ContentType;

            using (var stream = new System.IO.MemoryStream())
            {
                file.CopyTo(stream);
                Image = stream.ToArray();
            }
        }
    }
}
