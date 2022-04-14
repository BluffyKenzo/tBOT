using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram_BOT
{
    class Program
    {
        private static string BotToken = "5289331216:AAGz-Hf1uMN9SrNM7F8vvGdHfDzzf2dcWlM";
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

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @Xenoz.", replyMarkup: GetButtonsOplata());
                        break;

                    case "JayKar":
                        var sticJAYKAR = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/bcd/de3/bcdde3d4-a147-48b8-8985-27d0f5de430f/192/18.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @JayKar.", replyMarkup: GetButtonsOplata());
                        break;

                    case "Frog (6ft3)":
                        var sticFROG = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/4dd/300/4dd300fd-0a89-3f3d-ac53-8ec93976495e/192/115.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @Frog.", replyMarkup: GetButtonsOplata());
                        break;

                    case "Retuurn":
                        var sticRETUURN = await client.SendStickerAsync(
                            chatId: msg.Chat.Id,
                            sticker: "https://tlgrm.ru/_/stickers/4dd/300/4dd300fd-0a89-3f3d-ac53-8ec93976495e/192/117.webp",
                            replyMarkup: GetButtons());

                        await client.SendTextMessageAsync(msg.Chat.Id, "Отлично! Ваша заявка внесена в систему, пожалуйста, ожидайте сообщение в личные сообщения от пользователя @Retuurn.", replyMarkup: GetButtonsOplata());
                        break;

                        // ВЫБОР СПОСОБА ОПЛАТЫ //

                    case "Mastercard":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Сумма вашего заказа - .", replyMarkup: GetButtons());
                        break;

                    case "Visa":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Сумма вашего заказа - .", replyMarkup: GetButtons());
                        break;

                    case "Qiwi":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Сумма вашего заказа - .", replyMarkup: GetButtons());
                        break;

                    case "PayPal":
                        await client.SendTextMessageAsync(msg.Chat.Id, "Сумма вашего заказа - .", replyMarkup: GetButtons());
                        break;

                        // ПОКУПКА ПРОЕКТОВ //

                    case "Проекты":
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
    }
}
