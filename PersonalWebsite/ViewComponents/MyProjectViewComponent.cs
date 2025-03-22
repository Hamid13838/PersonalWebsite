using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.ViewComponentModels;
using System.Collections.Generic;

namespace PersonalWebsite.ViewComponents
{
    public class MyProjectViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<ProjectModel> articles = new List<ProjectModel>();
            articles.Add(new ProjectModel { Id = 1, Title = "آموزش برنامه نویسی", Description = "آموزش برنامه نویسی در سال 2024 ....." });
            articles.Add(new ProjectModel { Id = 2, Title = "مقایسه تاکسی آنلاین ", Description = "مقایسه کامل برنامه های اسنپ و تپسی ....." });
            articles.Add(new ProjectModel { Id = 3, Title = "حذف درگاه شارژ در آیفون های جدید", Description = "برداشته شدن محدودیت درگاه شارژ توسط اتحادیه اروپا ....." });
            articles.Add(new ProjectModel { Id = 4, Title = "نسخه جدید دات نت منتشر شد", Description = "در روز های اخیر سال میلادی ماکروسافت نسخه جدید دات نت را معرفی کرد ....." });
            return View("ExamProject", articles);
        }
    }
}