using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursovaya
{
   public static class MessageConstants
    {
        public const string HELLO                     = "Здравствуйте ,как к вам обращаться?";
        public const string WELCOME                   = "Добро пожаловать, {0} ";
        public const string OPTIONS                   = "доступныые опции для вас:\n";
        public const string FREE_NUMBERS              = "1.Cписок доступных номеров\n";
        public const string ALL_NUMBERS               = "2.Cписок всех номеров\n";
        public const string EXIT                      = "3.Выход";
        public const string MISSING_OPTION            = "Такого варианта нет,пожалуйста выберете команду из доступных";
        public const string SHOW_PRICE_OF_FREE_NUMBER = "номер {0} cвободен по цене: {1}$ за сутки";
        public const string BACK_TO_OPTIONS           = "чтобы вернуться к опциям,нажмите 1";
        public const string ORDER_NUMBER              = "чтобы забронировать номер,нажмите 2";
        public const string SHOW_PRICE_AND_STATUS     = "цена на номер {0} = {1}$ в сутки. На данный момент:{2}";
        public const string ENTER_DATE_OF_SETTLEMENT  = "Введите вашу дату заселения: ";
        public const string ERROR_OF_DATE             = "неверно,введите дату в формате: 21.01.2022";
        public const string PERSONAL_DATA             = "Чтобы заказать один из номеров ,потребуются ваши персональные данные";
        public const string FNAME_AND_LNAME           = "Пожалуйста,напомните свое полное Имя и Фамилию:";
        public const string ENTER_PHONE_NUMBER        = "введите свой номер телефона ";
        public const string ENTER_CONT_OF_DAY         = "Введите количество дней проживания:";
        public const string CONGRATULATIONS           = "Поздравляем, данный номер забронирован за вами.\n";
        public const string GOOD_CHILL                = "Хорошего отдыха!";
        public const string SELECT_HOTEL_NUMBER       = "Выберите номер комнаты для проживания из свободных на данный момент";
        public const string TOTAL_PRICE               = "стоимсть этого номера будет {0}$";
        public const string ENTER_LIKE_ADMIN          = "1.Войти как администратор\n";
        public const string ENTER_LIKE_GUEST          = "2.Войти как гость";
        public const string ERROR_OF_VARIANTS         = "Такого варианта нету ,выбирете из предоставленных:";
        public const string GREETINGS_ADMIN           = "Вы вошли как администратор.Добро пожаловать!";
        public const string INFORMATION_ABOUT_CLIENTS = "Информация о клиентах:";
        public const string INFORMATION_ABOUT_ORDERS  = "{0} {1} забронировал комнату {2} на {3} дней\nсрок бронирования {4} - {5}";
        public const string SAD_INFORMATION           = "На данный момент клиентов нет";
        public const string FREE                      = "Свободен";
        public const string BUSY                      = "Занят";
        public const string EXITE_ADMIN               = "3";
        public const string END_OF_BOOKING            = "Время бронирования истекло,пожалуйста покиньте номер!";


    }
}
