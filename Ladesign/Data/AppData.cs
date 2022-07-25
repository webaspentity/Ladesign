using Ladesign.Models;

namespace Ladesign.Data;

public static class AppData
{
    public static List<LinkModel> MenuLinks = new()
    {
        new LinkModel { Title = "Портфолио", Url = "/portfolio"},
        new LinkModel { Title = "Услуги и цены", Url = "/services-and-prices"},
        new LinkModel { Title = "Контакты", Url = "/contacts"}
    };

    public static List<SpoilerModel> SpoilersData = new()
    {
        new SpoilerModel { Title = "Каждый проект уникален", Content = "Дизайнеры и архитекторы студии не работают по шаблону, учитывают все пожелания и не копируют работы из чужих портфолио"},
        new SpoilerModel { Title = "Полное сопровождение", Content = "Клиент может заказать услугу по авторскому надзору и вообще не приезжать на объект. Мы будем контролировать и корректировать ход выполнения ремонтных работ согласно дизайн-проекту"},
        new SpoilerModel { Title = "Согласование перепланировки", Content = "Поможем согласовать любые планировочные решения, которые не противоречат закону. Возьмем на себя все бумажные вопросы, чтобы освободить ваше время"},
        new SpoilerModel { Title = "Техническая документация", Content = "Готовим полный пакет документов, который гарантирует ответственный подход к работе и высокое качество реализованного дизайн-проекта"},
        new SpoilerModel { Title = "Строгая политика конфиденциальности", Content = "Обеспечиваем защиту персональных данных заказчиков и не раскрываем их третьим лицам"}
    };

    public static List<ImageModel> Images = new()
    {
        new ImageModel { Source = "images/portfolio/1.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/2.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/3.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/4.jpg", Alt = "Дом"},
        new ImageModel { Source = "images/portfolio/5.jpg", Alt = "Дом"},
        new ImageModel { Source = "images/portfolio/6.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/7.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/8.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/9.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/10.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/1.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/2.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/3.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/4.jpg", Alt = "Дом"},
        new ImageModel { Source = "images/portfolio/5.jpg", Alt = "Дом"},
        new ImageModel { Source = "images/portfolio/6.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/7.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/8.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/9.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/10.jpg", Alt = "Квартира"}
    };

    public static List<LinkModel> FooterSocials = new()
    {
        new LinkModel { Title="houzz", Url = "https://www.houzz.ru/"},
        new LinkModel { Title="instagram", Url = "https://www.instagram.com/"}
    };
}
