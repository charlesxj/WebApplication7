using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class ImgCategoryController : ApiController
    {
        // GET: api/ImgCategory
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ImgCategory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ImgCategory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ImgCategory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ImgCategory/5
        public void Delete(int id)
        {
        }
    }

    public class Imgs
    {
        public int id { get; set; }
        public string title { get; set; }
        public string img_url { get; set; }
        public string zhaiyao { get; set; }

        public DateTime add_time { get; set; }
        public int click { get; set; }

        public static List<News> GetImgs()
        {            
            return new List<News>()
            {
                new News(){id=1, img_url="http://fuss10.elemecdn.com/b/18/0678e57cb1b226c04888e7f244c20jpeg.jpeg", add_time=DateTime.Now,click=12, title="标题1", zhaiyao="这是啥图片咧？" },
                new News(){id=1, img_url="http://fuss10.elemecdn.com/3/1e/42634e29812e6594c98a89e922c60jpeg.jpeg", add_time=DateTime.Now.AddDays(-1),click=12,title="士大夫", zhaiyao="111" },
                new News(){id=1, img_url="http://fuss10.elemecdn.com/1/c5/95c37272d3e554317dcec1e17a9f5jpeg.jpeg", add_time=DateTime.Now.AddDays(-2),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=1, img_url="http://fuss10.elemecdn.com/7/85/e478e4b26af74f4539c79f31fde80jpeg.jpeg", add_time=DateTime.Now.AddDays(-3),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=1, img_url="http://fuss10.elemecdn.com/b/df/b630636b444346e38cef6c59f6457jpeg.jpeg", add_time=DateTime.Now.AddDays(-4),click=12,title="阿道夫", zhaiyao="312" },
                new News(){id=1, img_url="http://fuss10.elemecdn.com/7/a5/596ab03934612236f807b92906fd8jpeg.jpeg", add_time=DateTime.Now.AddDays(-5),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=1, img_url="https://ss1.bdstatic.com/70cFvXSh_Q1YnxGkpoWK1HF6hhy/it/u=3207781657,3460758070&fm=26&gp=0.jpg", add_time=DateTime.Now.AddDays(-6),click=12,title="爱的色放撒旦", zhaiyao="12321" },
                new News(){id=1, img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770027&di=bf94f5254006955a220806fd24ec270a&imgtype=0&src=http%3A%2F%2Fimg.bimg.126.net%2Fphoto%2FWgjcTIco7s4BN2OcRNAe_A%3D%3D%2F884675851802636535.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="阿斯蒂芬撒", zhaiyao="1231" },
                new News(){id=1, img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770027&di=a86f5450c47faac25e3f79a6e039033c&imgtype=0&src=http%3A%2F%2Fpic2.52pk.com%2Ffiles%2Fallimg%2F090626%2F1553504U2-2.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="阿3额 ", zhaiyao="123" },
                new News(){id=1,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770026&di=5475c3713ad5a2df0556fbbda6e0aff2&imgtype=0&src=http%3A%2F%2Fimg01.cztv.com%2F201611%2F20%2F84eae5bf1e03cc04222d40aaa2389e99.gif", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=1,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770026&di=e0fa9d0094dcb199a3d9d9c06d083856&imgtype=0&src=http%3A%2F%2Fimgs.abduzeedo.com%2Ffiles%2Ftutorials%2Fnine_making_of%2F2.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="Asher", zhaiyao="1231" },
                new News(){id=1,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="就让人讨厌", zhaiyao="13" },
                new News(){id=2,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="靠靠靠就", zhaiyao="123" },
                new News(){id=2,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="第三方的", zhaiyao="123" },
                new News(){id=2,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问", zhaiyao="123" },
                new News(){id=2,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="水电站", zhaiyao="123" },
                new News(){id=2,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊", zhaiyao="13" },
                new News(){id=3,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="撒啊啊", zhaiyao="111" },
                new News(){id=3,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问A", zhaiyao="123" },
                new News(){id=3,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="1123AAA", zhaiyao="123" },
                new News(){id=4,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="ADSA", zhaiyao="AAA" },
                new News(){id=5,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="afas", zhaiyao="AF" },
                new News(){id=6,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="ASD" },
                new News(){id=7,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="就觉得但是", zhaiyao="A" },
                new News(){id=8,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title=" 人哇", zhaiyao="AF" },
                new News(){id=9,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊的风格", zhaiyao="ASD" },
                new News(){id=10,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="哈", zhaiyao="AF" },
                new News(){id=11,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊啊啊", zhaiyao="AF" },
                new News(){id=12,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="案说法", zhaiyao="AF" },
                new News(){id=12,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="按时地方烦烦烦", zhaiyao="AF" }
            };

        }
    }
}
