using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class GoodsController : ApiController
    {
        // GET: api/Goods
        public object Get()
        {

            int pageindex = int.Parse(System.Web.HttpContext.Current.Request.Params["pageindex"]);

            return Json(new { stauts = 0, message = Goods.GetGoods().Skip((pageindex - 1) * 10).Take(10) });
        }

        // GET: api/Goods/5
        public object Get(int id)
        {
            var temp = GoodDetail.GetGoodDetail().FirstOrDefault(a => a.id == id);
            if (temp==null)
            {
                return Json(new { stauts = 1, message ="未找到" });
            }
            return Json(new { stauts = 0, message =new {title=Goods.GetGoods().FirstOrDefault(a=>a.id==id).title,content=temp.content }  });
        }

        // POST: api/Goods
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Goods/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Goods/5
        public void Delete(int id)
        {
        }
    }

    public class Goods
    {
        public int id { get; set; }
        public string title { get; set; }
        public string img_url { get; set; }
        public string zhaiyao { get; set; }

        public DateTime add_time { get; set; }
        public int click { get; set; }

        public int subid { get; set; }

        public double sell_price { set; get; }

        public double market_price { get; set; }

        public int stock_quantity { get; set; }

        public static List<Goods> GetGoods()
        {
            return new List<Goods>()
            {
                new Goods(){id=1,subid=1, img_url="https://img10.360buyimg.com/n1/s450x450_jfs/t1/16130/39/12690/305219/5caac12aEbb843fa5/ce6c1dee969fb626.jpg", add_time=DateTime.Now,click=12, title="小米9 4800万超广角三摄 8GB+128GB全息幻彩蓝 骁龙855 全网通4G 双卡双待", zhaiyao="现货速发【小米官方授权店，直供货源】【下单好礼】一拖三数据线+耳机+吃鸡神器+高清膜+20元红包【骁龙855旗舰处理器，后置三摄智能游戏手机】", market_price=3299, sell_price=3177, stock_quantity=12 },
                new Goods(){id=2,subid=2, img_url="https://m.360buyimg.com/mobilecms/s750x750_jfs/t1/34035/40/4769/95681/5cb83cf9E1c52fc02/13a29cecb97cd4ab.jpg!q80.dpg.webp", add_time=DateTime.Now.AddDays(-1),click=12,title="OPPO Reno 全面屏拍照手机 6G+256G 雾海绿 全网通 移动联通电信 双卡双待手机", zhaiyao="关注Reno新品首发，享12期免息+N6蓝牙音箱+京东180天只换不修服务，隐藏式摄像头，4800万像素，闪充3.0，屏下指纹",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=3,subid=3, img_url="https://img14.360buyimg.com/imgzone/jfs/t28270/235/442258107/141730/32d3d65b/5bf3b609Nfc07ff49.jpg!q70.dpg", add_time=DateTime.Now.AddDays(-2),click=12,title="小米（MI） mix3 【白条分期0首付6期免息】 磁动力滑盖全面屏全网通手机 黑色 白条分期 8GB+128GB", zhaiyao="【京东物流.全国联保】【下单送礼：时尚音乐耳机、指环扣、保护壳】【白条分期0首付6期免息】",market_price=3699, sell_price=3599, stock_quantity=12 },
                new Goods(){id=4,subid=4, img_url="http://fuss10.elemecdn.com/7/85/e478e4b26af74f4539c79f31fde80jpeg.jpeg", add_time=DateTime.Now.AddDays(-3),click=12,title="啊手动阀", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=30,subid=30, img_url="http://fuss10.elemecdn.com/b/df/b630636b444346e38cef6c59f6457jpeg.jpeg", add_time=DateTime.Now.AddDays(-4),click=12,title="阿道夫", zhaiyao="美食，顾名思义就是美味的食物，贵的有山珍海味，便宜的有街边小吃。其实美食是不分贵贱的，只要是自己喜欢的，都可以称之为美食。中国素有“烹饪王国”这个美誉。在中国这个大家庭里，我们有五十六个小家庭，每个家庭都有自己的特色美食。美食吃前有期待、吃后有回味，已不仅仅是简单的味觉感受，更是一种精神享受。享受美食也要看场合，场合好美食吃起来才有味道。世界各地美食文化博大精深，营养物质各不相同，品味更多美食，享受更多健康，也让人吃的更加开心。美食不仅仅是餐桌上的食物。还包括休闲零食、各种饼干、糕点、糖类，蜜饯、干果、肉制食品、茶饮冲泡等制品，各有各的风味，都可称之为美食。",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=5,subid=5, img_url="http://fuss10.elemecdn.com/7/a5/596ab03934612236f807b92906fd8jpeg.jpeg", add_time=DateTime.Now.AddDays(-5),click=12,title="啊手动阀", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=6,subid=6, img_url="https://ss1.bdstatic.com/70cFvXSh_Q1YnxGkpoWK1HF6hhy/it/u=3207781657,3460758070&fm=26&gp=0.jpg", add_time=DateTime.Now.AddDays(-6),click=12,title="爱的色放撒旦", zhaiyao="12321",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=7,subid=7, img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770027&di=bf94f5254006955a220806fd24ec270a&imgtype=0&src=http%3A%2F%2Fimg.bimg.126.net%2Fphoto%2FWgjcTIco7s4BN2OcRNAe_A%3D%3D%2F884675851802636535.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="阿斯蒂芬撒", zhaiyao="1231",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=8,subid=8, img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770027&di=a86f5450c47faac25e3f79a6e039033c&imgtype=0&src=http%3A%2F%2Fpic2.52pk.com%2Ffiles%2Fallimg%2F090626%2F1553504U2-2.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="阿3额 ", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=9,subid=9,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770026&di=5475c3713ad5a2df0556fbbda6e0aff2&imgtype=0&src=http%3A%2F%2Fimg01.cztv.com%2F201611%2F20%2F84eae5bf1e03cc04222d40aaa2389e99.gif", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=10,subid=10,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770026&di=e0fa9d0094dcb199a3d9d9c06d083856&imgtype=0&src=http%3A%2F%2Fimgs.abduzeedo.com%2Ffiles%2Ftutorials%2Fnine_making_of%2F2.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="Asher", zhaiyao="1231",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=11,subid=11,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="就让人讨厌", zhaiyao="13",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=12,subid=12,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="靠靠靠就", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=13,subid=13,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="第三方的", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=14,subid=14,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=15,subid=15,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="水电站", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=16,subid=16,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊", zhaiyao="13",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=17,subid=17,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="撒啊啊", zhaiyao="111",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=18,subid=18,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="请问请问A", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=19,subid=19,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="1123AAA", zhaiyao="123",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=20,subid=20,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="ADSA", zhaiyao="AAA",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=21,subid=21,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="afas", zhaiyao="AF",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=22,subid=22,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊手动阀", zhaiyao="ASD",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=23,subid=23,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="就觉得但是", zhaiyao="A",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=24,subid=24,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title=" 人哇", zhaiyao="AF",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=25,subid=25,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊的风格", zhaiyao="ASD",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=26,subid=26,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="哈", zhaiyao="AF",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=27,subid=27,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="啊啊啊啊", zhaiyao="AF",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=28,subid=28,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="案说法", zhaiyao="AF",market_price=3000, sell_price=2900, stock_quantity=12 },
                new Goods(){id=29,subid=29,img_url="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1555588770020&di=85545d48743cd5498f5f3e442d730a01&imgtype=0&src=http%3A%2F%2Fphoto.tuchong.com%2F24632%2Ff%2F789261.jpg", add_time=DateTime.Now.AddDays(-1),click=12,title="按时地方烦烦烦", zhaiyao="AF",market_price=3000, sell_price=2900, stock_quantity=12 }
            };

        }

    }

    public class GoodDetail{
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }

        public static List<GoodDetail> GetGoodDetail()
        {
            return new List<GoodDetail>()
            {
                new GoodDetail(){id=1,content="<div id=\"description\" class=\"J_DetailSection tshop-psm tshop-psm-bdetaildes\">    <h4 class=\"hd\">商品详情</h4><div class=\"content ke-post\" style=\"height: auto;\"><p><span style = \"font-size: 24.0px;\" > 小米9新品18点前订单99 % 现货当天发！标配送街头风保护壳+运动蓝牙！</span></p> <p data-spm-anchor-id=\"a220o.1000855.0.i0.6030f19efCxUyi\"><span style = \"font-size: 24.0px;\" > 可送无线充 / 手环等好礼!<br> <img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01IydCkw1hUHf85X7Vv_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01QmP5r61hUHgU8PdSG_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01VM4YJg1hUHgOXIMdr_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><span style = \"font-size: 24.0px;\" >< img src=\"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01eZs0941hUHg6R4NSa_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01glAk361hUHgKIIIQd_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"></span><br> <img src = \"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01HwxFBL1hUHejYb91x_!!2024314280.jpg\" class=\"img-ks-lazyload\"><a href = \"https://topauth.taobao.com/container?appkey=12262395&amp;state=p-LDzSAzMBzRFzLCzSEzLDzRGzLHzRFzLIzRH\" target=\"_blank\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01Qfaidf1hUHgRs3RKb_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"></a><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01pIFudx1hUHgH6VMPi_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01wmobJ31hUHg35smvW_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01P54O591hUHfmSsPF6_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01n3sJTT1hUHgAh7J86_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01O2R8aW1hUHgIhDh4G_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/2024314280/O1CN019ggJm61hUHgGO2MGR_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01ihGJzS1hUHgHqJgrK_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01I5jSWS1hUHgLruCEF_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01CQDtRK1hUHgAh7RS7_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01bd64jP1hUHeztXBw5_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01hs4x381hUHf7Izcmw_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01UfRdjy1hUHf864i4z_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01FMyjw91hUHf7PajGx_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01X9VQDO1hUHf7IyDUx_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i3/2024314280/O1CN017wB1wn1hUHf9l96vA_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i3/2024314280/O1CN010hAkVi1hUHf9QpruJ_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01MzyHFK1hUHf883tJj_!!2024314280.jpg\" class=\"img-ks-lazyload\"><br> <img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01RvAq7S1hUHeyarOXv_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01Weo5pc1hUHdqgpqMc_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01eUD53f1hUHdkPyrHM_!!2024314280.jpg\" class=\"img-ks-lazyload\"><br> <img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN0164xyln1hUHfsB8Ydx_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01YnVOw81hUHfsB8QLe_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01YvPdAI1hUHft8z50y_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01jRjDsV1hUHfs7JdXd_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01YBHmYV1hUHfszwqBE_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01lhAcUp1hUHfrWyKUD_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN018g0jvv1hUHfuVNkj1_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN013NrNs11hUHfszwZZr_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01fFgfzO1hUHfqNMmub_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01eYLBoB1hUHfs7Lz7c_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01bQr4Ou1hUHfqNOGN9_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01BUItAf1hUHfrWzKxL_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN014dgqIt1hUHfsBBqVN_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01KLTGVQ1hUHftde04G_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/2024314280/O1CN013O5dvZ1hUHfqiX0BI_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01sOUlkm1hUHfqiYg6R_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01Pn9W6j1hUHfuDxkzh_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01Xa4A3x1hUHfszxRik_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01oXUmVm1hUHfl4zoPi_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01Bbmz8z1hUHft2R3Zg_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01t2Xa8Q1hUHfl50szP_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01Rv9dOt1hUHezmL5EI_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01YGJqzL1hUHey6b33V_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i3/2024314280/O1CN01X0fYvx1hUHezmKoe2_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i2/2024314280/O1CN01bCPPE91hUHereDDOY_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01Zspjdz1hUHey6cFuY_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01XthePd1hUHezAfg42_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img align = \"absmiddle\" src=\"https://img.alicdn.com/imgextra/i1/2024314280/O1CN01vJRXB81hUHf0GcdSM_!!2024314280.jpg\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN0187FLdw1hUHftdkF2W_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/2024314280/O1CN01Ehl2ya1hUHfN991Bl_!!2024314280.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"></span></p></div> </div>"},
                new GoodDetail(){id=2,content="<div id=\"description\" class=\"J_DetailSection tshop-psm tshop-psm-bdetaildes\">    <h4 class=\"hd\">商品详情</h4>        <div class=\"content ke-post\" style=\"height: auto;\"><p><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN019sfyWl1jPp3YZhnyk_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN01HMjTo21jPp3Y8hEmh_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN01I4Euld1jPp3Tx7wUw_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN01savQVh1jPp3coxp5l_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01vEXReu1jPp37USfS8_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN016JoDpt1jPp3IMOB4c_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01czYkRL1jPp3Mmg8ar_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/1715164541/O1CN010SLunH1jPp3ILyb88_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01hTn5AH1jPp37eB0GJ_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN01JQa7Vb1jPp3KAopXn_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01TS9Rj01jPp391U7zv_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01vMOtp31jPp3A07Goo_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN01RVBA0U1jPp3AUqmjp_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><a href = \"http://h5.m.taobao.com/cm/collocation.html?id=18300191&amp;userId=1715164541\" target=\"_blank\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01G1jAnh1jPp3WQt7Uw_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"></a><a href = \"http://h5.m.taobao.com/cm/collocation.html?id=19111234&amp;userId=1715164541\" target=\"_blank\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01o2C4r51jPp3WCZKmK_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"></a><img src = \"https://img.alicdn.com/imgextra/i3/1715164541/O1CN01ZH5r8I1jPp36mosOZ_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN015DqNtR1jPp3BOv70G_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN01x3sKHe1jPp3A047Q9_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/1715164541/O1CN010wTyf51jPp3BoFvKb_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN01XzdHiN1jPp3A5li6V_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN01FF2gNP1jPp3ZgcWK6_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN01oUjdHw1jPp3FRtclS_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/1715164541/O1CN01UWcoRv1jPp3CpEfWj_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/1715164541/O1CN01aD66uy1jPp39BM3uR_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01PLhcja1jPp39BKvFI_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN01ou2BUY1jPp39CPhqW_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i2/1715164541/O1CN01V1YE3h1jPp3A3Pt4a_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN01ABiJ2I1jPp3Ai2FGH_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i4/1715164541/O1CN0150XbBc1jPp2r5y6ND_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i1/1715164541/O1CN01zLjD5U1jPp2t5nk98_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"><img src = \"https://img.alicdn.com/imgextra/i3/1715164541/O1CN011jPp05FCd1RXv0e_!!1715164541.jpg\" align=\"absmiddle\" class=\"img-ks-lazyload\"></p></div> </div>"},
                new GoodDetail(){id=3,content=""},
                new GoodDetail(){id=4,content=""},
                new GoodDetail(){id=5,content=""},
                new GoodDetail(){id=6,content=""},
                new GoodDetail(){id=7,content=""},
                new GoodDetail(){id=8,content=""},
                new GoodDetail(){id=9,content=""},
                new GoodDetail(){id=10,content=""},
                new GoodDetail(){id=11,content=""},
                new GoodDetail(){id=12,content=""},
                new GoodDetail(){id=13,content=""},
                new GoodDetail(){id=14,content=""},
                new GoodDetail(){id=15,content=""},
                new GoodDetail(){id=16,content=""},
                new GoodDetail(){id=17,content=""},
                new GoodDetail(){id=18,content=""},
                new GoodDetail(){id=19,content=""},
                new GoodDetail(){id=20,content=""},
                new GoodDetail(){id=21,content=""},
                new GoodDetail(){id=22,content=""},
                new GoodDetail(){id=23,content=""},
                new GoodDetail(){id=24,content=""},
                new GoodDetail(){id=25,content=""},
                new GoodDetail(){id=26,content=""},
                new GoodDetail(){id=27,content=""},
                new GoodDetail(){id=28,content=""},
                new GoodDetail(){id=29,content=""},
                new GoodDetail(){id=30,content=""}
            };

        }
    }
}
