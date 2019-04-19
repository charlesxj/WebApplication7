using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class ImagesController : ApiController
    {
        // GET: api/Images
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Images/5
        public string Get(string id)
        {
            var temp = News.GetNews().FirstOrDefault(a => a.img_url == id);
            if (temp == null)
            {
                id = "1.jpg";
            }
            string baseDir = System.AppDomain.CurrentDomain.BaseDirectory;
            var imgPath = Path.Combine(baseDir, "images", id);            
            return GetBs64BmpString(new Bitmap(imgPath));
        }

        // POST: api/Images
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Images/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Images/5
        public void Delete(int id)
        {
        }

        public static string GetBs64BmpString(Bitmap bmp)
        {
            //new Bitmap(picPath);
            byte[] arr = null;
            using (MemoryStream ms = new MemoryStream())
            {
                //bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
            }

            string strbaser64 = Convert.ToBase64String(arr);
            //// MessageBox.Show("转换成功!");
            return strbaser64;

        }
    }
}
