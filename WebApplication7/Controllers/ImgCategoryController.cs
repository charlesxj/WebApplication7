﻿using System;
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
        public object Get()
        {
            return Json(new { status = 0, message = Imgs.GetImgs().Distinct(new ImgsComparer())});
        }

        // GET: api/ImgCategory/5
        public object Get(int id)
        {
            if (id==0)
            {
                return Json(new { status = 0, message = Imgs.GetImgs().OrderBy(a=>a.id)});
            }
            else
            {
                return Json(new { status = 0, message = Imgs.GetImgs().Where(a => a.id == id) });
            }
           
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

    public class ImgsComparer : IEqualityComparer<Imgs>
    {
        public bool Equals(Imgs x, Imgs y)
        {
            if (x.id==y.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Imgs obj)
        {
            return obj.id.GetHashCode();
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

        public int subid { get; set; }

        public static List<Imgs> GetImgs()
        {            
            return new List<Imgs>()
            {
                new Imgs(){id=1,subid=1, img_url="http://fuss10.elemecdn.com/b/18/0678e57cb1b226c04888e7f244c20jpeg.jpeg", add_time=DateTime.Now,click=12, title="美食介绍", zhaiyao="美食，顾名思义就是美味的食物，贵的有山珍海味，便宜的有街边小吃。其实美食是不分贵贱的，只要是自己喜欢的，都可以称之为美食。中国素有“烹饪王国”这个美誉。在中国这个大家庭里，我们有五十六个小家庭，每个家庭都有自己的特色美食。美食吃前有期待、吃后有回味，已不仅仅是简单的味觉感受，更是一种精神享受。享受美食也要看场合，场合好美食吃起来才有味道。世界各地美食文化博大精深，营养物质各不相同，品味更多美食，享受更多健康，也让人吃的更加开心。美食不仅仅是餐桌上的食物。还包括休闲零食、各种饼干、糕点、糖类，蜜饯、干果、肉制食品、茶饮冲泡等制品，各有各的风味，都可称之为美食。" },
                new Imgs(){id=1,subid=2, img_url="http://fuss10.elemecdn.com/3/1e/42634e29812e6594c98a89e922c60jpeg.jpeg", add_time=DateTime.Now.AddDays(-1),click=12,title="士大夫", zhaiyao="111" },
                new Imgs(){id=1,subid=3, img_url="http://fuss10.elemecdn.com/1/c5/95c37272d3e554317dcec1e17a9f5jpeg.jpeg", add_time=DateTime.Now.AddDays(-2),click=12,title="啊手动阀", zhaiyao="123" },
                new Imgs(){id=1,subid=4, img_url="http://fuss10.elemecdn.com/7/85/e478e4b26af74f4539c79f31fde80jpeg.jpeg", add_time=DateTime.Now.AddDays(-3),click=12,title="啊手动阀", zhaiyao="123" },
                new Imgs(){id=1, img_url="http://fuss10.elemecdn.com/b/df/b630636b444346e38cef6c59f6457jpeg.jpeg", add_time=DateTime.Now.AddDays(-4),click=12,title="阿道夫", zhaiyao="312" },
                new Imgs(){id=1,subid=5, img_url="http://fuss10.elemecdn.com/7/a5/596ab03934612236f807b92906fd8jpeg.jpeg", add_time=DateTime.Now.AddDays(-5),click=12,title="啊手动阀", zhaiyao="123" },
                new Imgs(){id=1,subid=6, img_url="https://ss1.bdstatic.com/70cFvXSh_Q1YnxGkpoWK1HF6hhy/it/u=3207781657,3460758070&fm=26&gp=0.jpg", add_time=DateTime.Now.AddDays(-6),click=12,title="爱的色放撒旦", zhaiyao="12321" },
                new Imgs(){id=1,subid=7, img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770027&di=bf94f5254006955a220806fd24ec270a&imgtype=0&src=http%3A%2F%2Fimg.bimg.126.net%2Fphoto%2FWgjcTIco7s4BN2OcRNAe_A%3D%3D%2F884675851802636535.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="阿斯蒂芬撒", zhaiyao="1231" },
                new Imgs(){id=1,subid=8, img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770027&di=a86f5450c47faac25e3f79a6e039033c&imgtype=0&src=http%3A%2F%2Fpic2.52pk.com%2Ffiles%2Fallimg%2F090626%2F1553504U2-2.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="阿3额 ", zhaiyao="123" },
                new Imgs(){id=1,subid=9,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770026&di=5475c3713ad5a2df0556fbbda6e0aff2&imgtype=0&src=http%3A%2F%2Fimg01.cztv.com%2F201611%2F20%2F84eae5bf1e03cc04222d40aaa2389e99.gif", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="123" },
                new Imgs(){id=1,subid=10,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770026&di=e0fa9d0094dcb199a3d9d9c06d083856&imgtype=0&src=http%3A%2F%2Fimgs.abduzeedo.com%2Ffiles%2Ftutorials%2Fnine_making_of%2F2.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="Asher", zhaiyao="1231" },
                new Imgs(){id=1,subid=11,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="就让人讨厌", zhaiyao="13" },
                new Imgs(){id=2,subid=12,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="靠靠靠就", zhaiyao="123" },
                new Imgs(){id=2,subid=13,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="第三方的", zhaiyao="123" },
                new Imgs(){id=2,subid=14,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问", zhaiyao="123" },
                new Imgs(){id=2,subid=15,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="水电站", zhaiyao="123" },
                new Imgs(){id=2,subid=16,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊", zhaiyao="13" },
                new Imgs(){id=3,subid=17,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="撒啊啊", zhaiyao="111" },
                new Imgs(){id=3,subid=18,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问A", zhaiyao="123" },
                new Imgs(){id=3,subid=19,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="1123AAA", zhaiyao="123" },
                new Imgs(){id=4,subid=20,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="ADSA", zhaiyao="AAA" },
                new Imgs(){id=5,subid=21,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="afas", zhaiyao="AF" },
                new Imgs(){id=6,subid=22,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="ASD" },
                new Imgs(){id=7,subid=23,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="就觉得但是", zhaiyao="A" },
                new Imgs(){id=8,subid=24,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title=" 人哇", zhaiyao="AF" },
                new Imgs(){id=9,subid=25,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊的风格", zhaiyao="ASD" },
                new Imgs(){id=10,subid=26,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="哈", zhaiyao="AF" },
                new Imgs(){id=11,subid=27,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊啊啊", zhaiyao="AF" },
                new Imgs(){id=12,subid=28,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="案说法", zhaiyao="AF" },
                new Imgs(){id=12,subid=29,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="按时地方烦烦烦", zhaiyao="AF" }
            };

        }
    }
}
