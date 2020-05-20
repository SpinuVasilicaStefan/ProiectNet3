using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhotoRazor.Models;
using ServicePhotoAlbum;

namespace PhotoRazor
{
    public class PhotosModel : PageModel
    {
        FunctionsClient fc = new FunctionsClient();
        public List<PhotoDTO> Photos { get; set; }

        public PhotosModel()
        {
            Photos = new List<PhotoDTO>();
        }
        public async Task OnGetAsync()
        {
            var media = await fc.Afisare_MediaAsync();
            foreach (var item in media)
            {
                var p = new PhotoDTO();
                p.Path = item;
                Photos.Add(p);
            }
        }
    }
}