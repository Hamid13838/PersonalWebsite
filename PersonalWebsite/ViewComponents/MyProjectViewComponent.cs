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
            articles.Add(new ProjectModel { Id = 1, Title = "دفترچه تلفن", Description = "با قابلیت حذف اضافه و ویرایش مخاطبین" , Image = "Contact.png"});
            articles.Add(new ProjectModel { Id = 2, Title = "مدیریت باشگاه", Description = "پیشرفته ترین نرم افزار موجود مدیریت باشگاه"  , Image="Gym.jpg"});
            articles.Add(new ProjectModel { Id = 3, Title = "مدیریت کتابخانه", Description = "قابلیت تمدید کتاب و جستجو کتاب در کتابخانه",Image = "Liberary.png" });
            articles.Add(new ProjectModel { Id = 4, Title = "سوپر مارکت آنلاین", Description = "دارای سبد خرید و درگاه پرداخت آنلاین" , Image = "ShopMobile.png" });
            return View("ExamProject", articles);
        }
    }
}