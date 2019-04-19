using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public Object Get()
        {
            return Json(new { status = 0, message = News.GetNews() });
        }

        // GET api/values/5
        public object Get(int id)
        {
            return Json(new { status = 0, message = News.GetNews().FirstOrDefault(a => a.id == id) });
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class ImgCategories
    {

    }

    public class Comments
    {
        public int belongId { get; set; }
        public string user_name { get; set; }
        public DateTime add_time { get; set; }
        public string content { get; set; }

        static List<Comments> dataSet= new List<Comments>()
            {
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="1你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="2你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="3你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="4你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="5你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="6你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="7你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="8你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="9你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="10你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="11你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="12你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="13你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="14你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="15你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="16你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="17你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="18你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="19你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="20你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="21你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="22你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="23你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="24你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="25你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="26你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="27你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="28你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="29你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="30你猜我是谁"},
                new Comments(){ belongId=1, add_time=DateTime.Now, content="评论啦", user_name="31你猜我是谁"}
            };
        public static void AddComments(Comments entity)
        {
            dataSet.Add(entity);
        }
        public static List<Comments> GetComments()
        {

            return dataSet;
        }

    }

    public class News
    {
        public int id { get; set; }
        public string title { get; set; }
        public string img_url { get; set; }
        public string zhaiyao { get; set; }

        public DateTime add_time { get; set; }
        public int click { get; set; }

        public static List<News> GetNews()
        {
            string tempStr = "<div class=\"text - 3zQ3cZD4\"><p class=\"detailPic\"><img src=\"https://p0.ifengimg.com/2019_16/6DADCBAFACF662768D26887954BF227BEA245B60_w1080_h810.jpg\" ></p><p>今天下午，鸿海集团董事长郭台铭在国民党中央党部接受党主席吴敦义颁发的荣誉状后，宣布参加2020年台湾地区领导人国民党党内初选。</p><p>郭台铭在仪式上亲自宣布：<strong>愿意参加初选，如果选上，代表国民党参加2020选举。</strong></p><p>此前据台湾媒体报道，台湾鸿海集团总裁郭台铭在4月17日两次参拜台湾的庙宇，称关公、妈祖会用民调告诉他是否参选台湾地区领导人。</p><p class=\"detailPic\"><img src=\"https://p3.ifengimg.com/2019_16/F4F3BCF422DB289BF09AA576E8F16C9E7FDE76A6_w640_h425.jpg\"></p><p class=\"picIntro\">▲郭台铭参拜</p><p>据报道，郭台铭在17日上午到板桥慈惠宫（妈祖庙）参拜，致词时表示，妈祖这几天前有跟他托梦，要他用妈祖精神，为受苦受难老百姓要做好事，也要给少年人希望。郭台铭称：“妈祖说和平繁荣经济自然会好，经济好大家庙可以盖更大间，他要用他的力量，帮助台湾，他今天来请示妈祖，妈祖对他说要他出来做一些事，不是为了赚钱，不是自己享受”。郭台铭还表示，妈祖说祂看着他长大，要为台湾与台湾人民做更多事，因此他表示：“我一定会照妈祖指示！”</p><p class=\"detailPic\"><img src=\"https://p0.ifengimg.com/2019_16/622EAB08DDE8BC1A90FBFBC5FE99F18C7B5F9C86_w640_h425.jpg\"></p><p class=\"picIntro\">▲郭台铭参拜后接受记者采访</p><p>中午郭台铭再转往著名关公庙淡水行天武圣宫参拜。郭台铭向关公参拜时表示，对台湾的末来、对年轻将来的希望、对平普的苍生，希望您给我智慧、勇气决心，让我有机会站出来接受您的指示，替台湾这块我生我长的土地、各行各业做一些事。当被问及是否会参选2020年台湾地区领导人的时候郭台铭称“我要等祂们告诉我”，当被问及什么时候会有答案时，郭台铭表示“关公、妈祖会用民调告诉他。”</p><p>台湾有媒体称，郭台铭如此表述等于确定参选2020年台湾地区领导人。有意思的是在郭台铭讲完会遵守妈祖托梦，要他参选的指示后，鸿海集团的股价一度飙涨至92.6元，创下自2018年3月以来的涨幅新高。</p></div>";
            return new List<News>()
            {
                new News(){id=1, img_url="/Images/1.jpg", add_time=DateTime.Now,click=12, title="标题1", zhaiyao=tempStr },
                new News(){id=2, img_url="/Images/2.png", add_time=DateTime.Now.AddDays(-1),click=12,title="士大夫", zhaiyao="111" },
                new News(){id=3, img_url="/Images/3.jpg", add_time=DateTime.Now.AddDays(-2),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=4, img_url="/Images/4.png", add_time=DateTime.Now.AddDays(-3),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=5, img_url="/Images/5.jpg", add_time=DateTime.Now.AddDays(-4),click=12,title="阿道夫", zhaiyao="312" },
                new News(){id=6, img_url="/Images/6.jpg", add_time=DateTime.Now.AddDays(-5),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=7, img_url="/Images/1.jpg", add_time=DateTime.Now.AddDays(-6),click=12,title="爱的色放撒旦", zhaiyao="12321" },
                new News(){id=8, img_url="/Images/2.png", add_time=DateTime.Now.AddDays(-1),click=12,title="阿斯蒂芬撒", zhaiyao="1231" },
                new News(){id=9, img_url="/Images/3.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="阿3额 ", zhaiyao="123" },
                new News(){id=10,img_url="/Images/4.png", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="123" },
                new News(){id=11,img_url="/Images/1.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="Asher", zhaiyao="1231" },
                new News(){id=12,img_url="/Images/2.png", add_time=DateTime.Now.AddDays(-1),click=12,title="就让人讨厌", zhaiyao="13" },
                new News(){id=13,img_url="/Images/3.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="靠靠靠就", zhaiyao="123" },
                new News(){id=14,img_url="/Images/4.png", add_time=DateTime.Now.AddDays(-1),click=12,title="第三方的", zhaiyao="123" },
                new News(){id=15,img_url="/Images/5.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问", zhaiyao="123" },
                new News(){id=16,img_url="/Images/6.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="水电站", zhaiyao="123" },
                new News(){id=17,img_url="/Images/1.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊", zhaiyao="13" },
                new News(){id=18,img_url="/Images/2.png", add_time=DateTime.Now.AddDays(-1),click=12,title="撒啊啊", zhaiyao="111" },
                new News(){id=19,img_url="/Images/3.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问A", zhaiyao="123" },
                new News(){id=20,img_url="/Images/4.png", add_time=DateTime.Now.AddDays(-1),click=12,title="1123AAA", zhaiyao="123" },
                new News(){id=21,img_url="/Images/1.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="ADSA", zhaiyao="AAA" },
                new News(){id=22,img_url="/Images/2.png", add_time=DateTime.Now.AddDays(-1),click=12,title="afas", zhaiyao="AF" },
                new News(){id=23,img_url="/Images/3.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="ASD" },
                new News(){id=24,img_url="/Images/4.png", add_time=DateTime.Now.AddDays(-1),click=12,title="就觉得但是", zhaiyao="A" },
                new News(){id=25,img_url="/Images/5.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title=" 人哇", zhaiyao="AF" },
                new News(){id=26,img_url="/Images/6.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊的风格", zhaiyao="ASD" },
                new News(){id=27,img_url="/Images/1.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="哈", zhaiyao="AF" },
                new News(){id=28,img_url="/Images/2.png", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊啊啊", zhaiyao="AF" },
                new News(){id=29,img_url="/Images/3.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="案说法", zhaiyao="AF" },
                new News(){id=30,img_url="/Images/4.png", add_time=DateTime.Now.AddDays(-1),click=12,title="按时地方烦烦烦", zhaiyao="AF" }
            };

        }
    }


}
