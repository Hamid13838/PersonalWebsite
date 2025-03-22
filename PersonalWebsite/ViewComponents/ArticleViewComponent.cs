using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.ViewComponentModels;
using System.Collections.Generic;

namespace PersonalWebsite.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<ArticleModel> articles = new List<ArticleModel>();
            articles.Add(new ArticleModel { Id = 1, Title = "آموزش برنامه نویسی", Description = "آموزش برنامه نویسی در سال 2024 ....." , Image = "Programmer.png" });
            articles.Add(new ArticleModel { Id = 2, Title = "مقایسه تاکسی آنلاین ", Description = "مقایسه کامل برنامه های اسنپ و تپسی ....." , Image = "taxi.jpg" });
            articles.Add(new ArticleModel { Id = 3, Title = "حذف درگاه شارژ در آیفون های جدید", Description = "برداشته شدن محدودیت درگاه شارژ  ....."  , Image = "Iphone.png" });
            articles.Add(new ArticleModel { Id = 4, Title = "نسخه جدید دات نت منتشر شد", Description = " ماکروسافت نسخه جدید دات نت را معرفی کرد ....." , Image = "Dotnet.jpg" });
            articles.Add(new ArticleModel { Id = 5, Title = "پیشرفت برنامه های سفارش غذا", Description = "همه چیز از زودفود شروع شد در سال 1391  ....."  , Image = "FoodApp.png" });
            articles.Add(new ArticleModel { Id = 6, Title = "چطور فروشگاه موفق داشته باشیم", Description = " راه اندازی سایت فروشگاهی  ....."  , Image = "Shop.jpg" });
            return View("MyArticle" , articles);
        }
    }
}
