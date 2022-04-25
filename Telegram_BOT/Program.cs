using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram_BOT
{
    class Program
    {
        private static string BotToken {get; set;} = "5289331216:AAGz-Hf1uMN9SrNM7F8vvGdHfDzzf2dcWlM";
        private static TelegramBotClient client;

        static void Main(string[] args)
        {
            client = new TelegramBotClient(BotToken);
            client.StartReceiving();

            client.OnMessage += OnMessageHandler;

            Console.ReadLine();
            client.StopReceiving();
        }

        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            int a = 2500, b = 1500, c = 15000;

            var msg = e.Message;

            if (msg.Text != null)
            {

                switch (msg.Text)
                {
                    // ПОКУПКА УСЛУГ //

                    case "Услуги":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Сообщество BlueStars предоставляет следующие услуги: \n \n1)Провести полный курс по монтажу Ваших видео (начинать будем с полного 0). " +
                            "\n2)Сделать эдит для Вас (тема не важна). " +
                            "\n3)Сделать полное оформление с вашей тематикой и ником (Discord, YouTube, Twitch, payship). \n " +
                            "\nЕсли вам хочется, чтобы вашу работу выполнял определенный эдитор, то после выбора услуги у вас будет такая возможность.", replyMarkup: GetButtonsVB());
                        break;

                    case "1":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Теперь вы можете выбрать эдитора, который будет выполнять вашу работу, для полного курса монтажа советую - Xenoz, Retuurn." + $"\n \n Стоимость услуги = {c} рублей.",  replyMarkup: GetButtonsED());
                        break;

                    case "2":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Теперь вы можете выбрать эдитора, который будет выполнять вашу работу, я могу посоветовать вам - JayKar, Retuurn." + $"\n \n Стоимость услуги = {a} рублей.", replyMarkup: GetButtonsED());
                        break;

                    case "3":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Теперь вы можете выбрать эдитора, который будет выполнять вашу работу, лучше всех с эти справится - Frog (6ft3)." + $"\n \n Стоимость услуги = {b} рублей.", replyMarkup: GetButtonsED());
                        break;

                        // ВЫБОР ЭДИТОРА //

                    case "Xenoz":
                        var sticXENOZ = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://cdn.tlgrm.app/stickers/113/b2a/113b2af8-922d-464d-a487-07884e142a15/192/1.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @Xenoz.", replyMarkup: GetButtons());
                        break;

                    case "JayKar":
                        var sticJAYKAR = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/bcd/de3/bcdde3d4-a147-48b8-8985-27d0f5de430f/192/18.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @JayKar.", replyMarkup: GetButtons());
                        break;

                    case "Frog (6ft3)":
                        var sticFROG = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/4dd/300/4dd300fd-0a89-3f3d-ac53-8ec93976495e/192/115.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @Frog.", replyMarkup: GetButtons());
                        break;

                    case "Retuurn":
                        var sticRETUURN = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/4dd/300/4dd300fd-0a89-3f3d-ac53-8ec93976495e/192/117.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @Retuurn.", replyMarkup: GetButtons());
                        break;

                        // ПОКУПКА ПРОЕКТОВ //

                    case "Проекты":
                        var sticJPROJ = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/4dd/300/4dd300fd-0a89-3f3d-ac53-8ec93976495e/192/31.webp",
                            replyMarkup: GetButtonsPJ());

                        await client.SendTextMessageAsync(msg.Chat.Id, "В нашем магазине Вы можете купить проекты эдитов, который представлены ниже: ", replyMarkup: GetButtonsPJ());
                        break;

                    case "After Dark - by Xenoz":
                        await client.SendTextMessageAsync(msg.Chat.Id, "При покупке данного проекта Вы получаете: " +
                            "\n \n1)Файл проекта в After Effects (.aep) \n2)Материалы из эдита (музыка, видио фрагменты, звуковые эффекты) " +
                            "\n \nТак же в файле будет прикреплена ссылка на гайд, как загрузить этот проекты в After Effects. " +
                            "\n \nЦена проекта - 2000 рублей." +
                            "\n \nВы поддтверждаете покупку?", replyMarkup: GetButtonsPOD());
                        break;

                    case "Levi Sad Edit - by JayKar":
                        await client.SendTextMessageAsync(msg.Chat.Id, "При покупке данного проекта Вы получаете: " +
                            "\n \n1)Файл проекта в After Effects (.aep) \n2)Материалы из эдита (музыка, видио фрагменты, звуковые эффекты) " +
                            "\n \nТак же в файле будет прикреплена ссылка на гайд, как загрузить этот проекты в After Effects. " +
                            "\n \nЦена проекта - 1800 рублей." +
                            "\n \nВы поддтверждаете покупку?", replyMarkup: GetButtonsPOD());
                        break;

                    case "La La La - by Frog (6ft3)":
                        await client.SendTextMessageAsync(msg.Chat.Id, "При покупке данного проекта Вы получаете: " +
                            "\n \n1)Файл проекта в After Effects (.aep) \n2)Материалы из эдита (музыка, видио фрагменты, звуковые эффекты) " +
                            "\n \nТак же в файле будет прикреплена ссылка на гайд, как загрузить этот проекты в After Effects. " +
                            "\n \nЦена проекта - 1500 рублей." +
                            "\n \nВы поддтверждаете покупку?", replyMarkup: GetButtonsPOD());
                        break;

                    case "High - by Frog (6ft3)":
                        await client.SendTextMessageAsync(msg.Chat.Id, "При покупке данного проекта Вы получаете: " +
                            "\n \n1)Файл проекта в After Effects (.aep) \n2)Материалы из эдита (музыка, видио фрагменты, звуковые эффекты) " +
                            "\n \nТак же в файле будет прикреплена ссылка на гайд, как загрузить этот проекты в After Effects. " +
                            "\n \nЦена проекта - 1000 рублей." +
                            "\n \nВы поддтверждаете покупку?", replyMarkup: GetButtonsPOD());
                        break;

                    case "Fairytale - by Retuurn":
                        await client.SendTextMessageAsync(msg.Chat.Id, "При покупке данного проекта Вы получаете: " +
                            "\n \n1)Файл проекта в After Effects (.aep) \n2)Материалы из эдита (музыка, видио фрагменты, звуковые эффекты) " +
                            "\n \nТак же в файле будет прикреплена ссылка на гайд, как загрузить этот проекты в After Effects. " +
                            "\n \nЦена проекта - 1300 рублей." +
                            "\n \nВы поддтверждаете покупку?", replyMarkup: GetButtonsPOD());
                        break;

                    case "Test project":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Этот бесплатный проект мы предоставляем для возможности изучений структуры самого простого эдита. \n\nССылка на скачивание - https://disk.yandex.ru/i/oz5mVyLdr76uQ", replyMarkup: GetButtonsPJ());
                        break;

                    // Подтвержение покупки //

                    case "Да":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично, сейчас вам будет предоставлена ссылка на оплату, после оплаты вас перебросит на яндекс диск, где вы сможете скачать данный проект.", replyMarkup: GetButtonsPJ());
                        break;

                    case "Нет":
                        var sticJNO = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/4dd/300/4dd300fd-0a89-3f3d-ac53-8ec93976495e/192/20.webp",
                            replyMarkup: GetButtonsPJ());

                        break;

                    // ИНФОРМАЦИЯ О СООБЩЕСТВЕ //

                    case "Сообщество BlueStars":
                        var sticLOGO = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://cdn.tlgrm.app/stickers/ccd/a8d/ccda8d5d-d492-4393-8bb7-e33f77c24907/192/1.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Привет, Мы очерь рады, что Вы заинтересовались нашим сообществом! BlueStars - большое сообщество эдиторов, которая была основана аниме эдитором Xenoz. " +
                            "Вы можете посетить наш Discord сервер (https://discord.gg/uhZuHXb6), на нем Вам всегда готовы помочь. Будем ждать вас в наших рядах!", replyMarkup: GetButtons());
                        break;

                        // ПОМОЩЬ //

                    case "Помощь":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Нам жаль, что вы столкнулись с какой-то проблемой! Подскажите, что у вас случилось и мы постараемся как можно быстрее решить вашу проблему.", replyMarkup: GetButtons2());
                        break;

                    case "Проблема с оплатой":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Если у вас возникли проблемы по оплате, пожалуйста, ознакомтесьс со следующими пунктами: \n \n1) Проверьте правильность введеных данных. " +
                            "\n2) Проверьте наличие денежных средств на карте. \n3)Если способы 1, 2 не сработали, скорее всего на платежной системе ведутся тех.работы, пожалуйста, попробуйте позже.", replyMarkup: GetButtons());
                        break;

                    case "Проблема тех.характера":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Если вы обнаружили проблемы технического характера, пожалуйста, напишите нам на эл. почту - BlueStarsTelBOT@mail.ru c подробным описание проблемы, спасибо!", replyMarkup: GetButtons());
                        break;

                    default:
                        await client.SendTextMessageAsync(msg.Chat.Id, "Привет, пожалуйста, выберите 1 из команд!", replyMarkup: GetButtons());

                        var sticSTART = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/ccd/a8d/ccda8d5d-d492-4393-8bb7-e33f77c24907/192/18.webp",
                            replyMarkup: GetButtons());
                        break;
                }
            }
        }   

        private static IReplyMarkup GetButtons()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> {new KeyboardButton {Text = "Услуги" },new KeyboardButton {Text = "Проекты" } },
                    new List<KeyboardButton> {new KeyboardButton {Text = "Сообщество BlueStars" }, new KeyboardButton {Text = "Помощь" } }
                }
            };
        }

        private static IReplyMarkup GetButtons2()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> {new KeyboardButton {Text = "Проблема с оплатой"},new KeyboardButton {Text = "Проблема тех.характера" } },
                }
            };
        }

        private static IReplyMarkup GetButtonsVB()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> {new KeyboardButton {Text = "1"}, new KeyboardButton {Text = "2"}, new KeyboardButton {Text = "3"}},
                }
            };
        }

        private static IReplyMarkup GetButtonsED()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> {new KeyboardButton {Text = "Xenoz"}, new KeyboardButton {Text = "JayKar"}},
                    new List<KeyboardButton> {new KeyboardButton {Text = "Frog (6ft3)"}, new KeyboardButton {Text = "Retuurn"}}
                }
            };
        }

        private static IReplyMarkup GetButtonsOplata()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> {new KeyboardButton {Text = "Mastercard" }, new KeyboardButton {Text = "Visa"}},
                    new List<KeyboardButton> {new KeyboardButton {Text = "PayPal"}, new KeyboardButton {Text = "Qiwi"}}
                }
            };
        }

        private static IReplyMarkup GetButtonsPJ()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> {new KeyboardButton {Text = "After Dark - by Xenoz" }, new KeyboardButton {Text = "Levi Sad Edit - by JayKar" }},
                    new List<KeyboardButton> {new KeyboardButton {Text = "La La La - by Frog (6ft3)" }, new KeyboardButton {Text = "High - by Frog (6ft3)" }},
                    new List<KeyboardButton> {new KeyboardButton {Text = "Fairytale - by Retuurn" }, new KeyboardButton {Text = "Test project" }}
                }
            };
        }

        private static IReplyMarkup GetButtonsPOD()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> {new KeyboardButton {Text = "Да" }, new KeyboardButton {Text = "Нет" }}
                }
            };
        }
    }
}
