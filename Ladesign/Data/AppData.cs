using Ladesign.Models;

namespace Ladesign.Data;

public static class AppData
{
    public static Components.Burger Burger { get; set; }
    public static Components.Header Header { get; set; }

    public static RoomSpecificsModel RoomSpecifics { get; set; } = new RoomSpecificsModel()
    {
        Title = "Дизайн 1-комнатной квартиры в стиле loft",
        ForWhom = "молодой мужчина",
        TotalArea = 60,
        Location = "Краснодар",
        WorkPeriod = "1 месяц",
        Description = "В этой квартире для молодого человека много бетона, кирпича и натурального дерева. Это лофт в классическом понимании и с очень интересными деталями.В интерьере использовано довольно много различных материалов и текстур. Однако благодаря тому, что каждый материал применяется не единожды и находит себе продолжение в других помещениях, квартира смотрится цельным объёмом, где все текстуры дополняют друг друга и сочетаются между собой."
    };

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
        new ImageModel { Source = "images/portfolio/11.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/12.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/13.jpg", Alt = "Дом"},
        new ImageModel { Source = "images/portfolio/14.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/15.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/16.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/17.jpg", Alt = "Дом"},
        new ImageModel { Source = "images/portfolio/18.jpg", Alt = "Квартира"},
        new ImageModel { Source = "images/portfolio/19.jpg", Alt = "Помещение"},
        new ImageModel { Source = "images/portfolio/20.jpg", Alt = "Помещение"}
    };

    public static List<LinkModel> FooterSocials = new()
    {
        new LinkModel { Title="houzz", Url = "https://www.houzz.ru/"},
        new LinkModel { Title="instagram", Url = "https://www.instagram.com/"}
    };

    public static List<ImageModel> WorkCarouselImages = new()
    {
        new ImageModel { Source = "images/portfolio/work/work_1.jpg", Alt = "Пример работы"},
        new ImageModel { Source = "images/portfolio/work/work_2.jpg", Alt = "Пример работы"},
        new ImageModel { Source = "images/portfolio/work/work_3.jpg", Alt = "Пример работы"},
        new ImageModel { Source = "images/portfolio/work/work_4.jpg", Alt = "Пример работы"},
        new ImageModel { Source = "images/portfolio/work/work_5.jpg", Alt = "Пример работы"}
    };

    public static List<ServiceModel> Services = new()
    {
        new ServiceModel { Title = "Чтобы ничего не упустить", Description = "Качественный дизайн-проект поможет избежать ошибок и переделок, которые приводят к лишним тратам и затягивают сроки ремонта"},
        new ServiceModel { Title = "Получить нужный результат", Description = "С помощью профессионалов вы сможете донести до строителей свое видение будущего дизайна интерьера"},
        new ServiceModel { Title = "Создать комфорт", Description = "Грамотная планировка и продуманная расстановка мебели сделает пространство эргономичным и функциональным"},
        new ServiceModel { Title = "Сэкономить деньги", Description = "Дизайнер подберет и рассчитает нужное количество материалов с учетом площади помещения, что поможет избежать перерасхода"},
        new ServiceModel { Title = "Потратить время на что-то более приятное", Description = "Вам не придется ездить по магазинам, месяцами подбирать и продумывать подходящие дизайнерские решения в интернете. Не нужно постоянно ездить на объект и созваниваться с рабочими, пытаться самостоятельно узаконить новые планировочные решения. Студия дизайна интерьера LА Design сделает все это за вас!"}
    };

    public static List<PriceModel> Prices = new()
    {
        new PriceModel { Name = "basic", Price = 2500m, Options = new() { "Обмерочный план", "План расстановки мебели", "План демонтажный", "План монтажный", "План полов с материалами", "-", "-", "-" } },
        new PriceModel { Name = "pro", Price = 3500, Options = new(){ "Обмерочный план", "План расстановки мебели", "План демонтажный", "План монтажный", "План полов с материалами", "План экспликации", "-", "-" } },
        new PriceModel { Name = "exclusive", Price = 5000, Options = new() { "Обмерочный план", "План расстановки мебели", "План демонтажный", "План монтажный", "План экспликации", "Чертежи сложных элементов и мебели (если заказывать отдельно - расчет индивидуальный)", "Спецификация осветительного оборудования", "Декорирование" } }
    };

}
