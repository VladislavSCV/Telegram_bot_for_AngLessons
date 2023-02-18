using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

class TgBot
{
    public static async Task Run()
    {
        var botClient = new TelegramBotClient("TOKEN for Developers!!!");

        using CancellationTokenSource cts = new();

        ReceiverOptions receiverOptions = new()
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        botClient.StartReceiving(
            updateHandler: HandleUpdateAsync,
            pollingErrorHandler: HandlePollingErrorAsync,
            receiverOptions: receiverOptions,
            cancellationToken: cts.Token
        );
        Trace.WriteLine("text");
        var me = await botClient.GetMeAsync();

        Console.WriteLine($"Bot name:{me.Username}");
        Console.ReadLine();

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is not { } message)
                return;
            if (message.Text is not { } messageText)
                return;
            var chatId = message.Chat.Id;
            DateTime dt = new DateTime();
            int dth = dt.Hour;
            int dth2 = dt.Minute;
            Console.WriteLine($"Messege text:{messageText}; Chat Id:{chatId};{DateTime.Now}");

            switch (messageText)
            {
                case "Firewall":
                    Message message10111211 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: $"WOOOW! True!",
            cancellationToken: cancellationToken);
                    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: ":-3",
        replyMarkup: new ReplyKeyboardRemove(),
        cancellationToken: cancellationToken);
                    break;
                case "FAQ":
                    Message message10211 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: $"Huh, true",
            cancellationToken: cancellationToken);
                    Message sentMessage1 = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "^_+",
        replyMarkup: new ReplyKeyboardRemove(),
        cancellationToken: cancellationToken);
                    break;
                case "Videocard":
                    Message message1021211 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: $"How did you guess? Huh",
            cancellationToken: cancellationToken);
                    Message sentMessage14 = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "O.O",
        replyMarkup: new ReplyKeyboardRemove(),
        cancellationToken: cancellationToken);
                    break;
                case "Hacker":
                    Message message102121211 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: $"Cooooool!!!",
            cancellationToken: cancellationToken);
                    Message sentMessage13 = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "(～￣▽￣)～",
        replyMarkup: new ReplyKeyboardRemove(),
        cancellationToken: cancellationToken);
                    break;
                case "Quest":
                    Message message10212111 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: $"FINISH HIM!!!",
            cancellationToken: cancellationToken);
                    Message sentMessage12 = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "^_-",
        replyMarkup: new ReplyKeyboardRemove(),
        cancellationToken: cancellationToken);
                    break;
                case "Id":
                    Message message10121211 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: $"Senior?",
            cancellationToken: cancellationToken);
                    Message sentMessage15 = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "○( ＾皿＾)っ Hehehe…",
        replyMarkup: new ReplyKeyboardRemove(),
        cancellationToken: cancellationToken);
                    break;
                case "I don't know":
                    Message message0 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Nothing, we'll learn everything",
                    cancellationToken: cancellationToken);
                    break;
                case "Best-known and perhaps, earned the reputation, leader in the fields, world’s most valuable, by providing consumers,creates a media, is the envy of any, world’s most admired":
                    Message messag21e0 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: "WOOOOOOW!!!\nCOOOL",
                    cancellationToken: cancellationToken);
                    break;
                case "Be a ascyr, not see a story about, and rwgonig, send them hate mai, was badly aeddagm, bully others in class, victim isn’t safe":
                    Message messag12e0 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Exellent!",
                    cancellationToken: cancellationToken);
                    break;
                case "Be a scary place these, not see a story about, nasty and growing, send them hate mail, at the hands of a, was badly damaged, bully others in class, victim isn't safe":
                    Message messa21ge0 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"who are you warrior?",
                    cancellationToken: cancellationToken);
                    break;
            }
            //Commands for /command...
            switch (messageText)
            {
                case "/start":
                    Message message0 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Hello! This bot will help you to learn English! Learn the rule and practice the test!",
                    cancellationToken: cancellationToken);
                    break;
                case "/command2":
                    Message message001 = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                photo: "https://wampi.ru/image/RHl0mzl",
                                caption: "<b>Help</b> <i></i> <a href=\"\"></a>",
                                parseMode: ParseMode.Html,
                                cancellationToken: cancellationToken);
                    Message message00 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Plurals! Test 1." +
                    $"\n https://wordwall.net/play/1512/897/2666",
                    cancellationToken: cancellationToken);
                    Message message01 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Plurals! Test 2. " +
                    $"\n https://wordwall.net/play/1399/804/8900",
                    cancellationToken: cancellationToken);
                    Message message02 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Plurals! Test 3. " +
                    $"\n https://wordwall.net/play/1899/001/572",
                    cancellationToken: cancellationToken);
                    break;
                case "/command1":
                    Message message10 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Placement test" +
                    $"\n https://wordwall.net/play/4066/938/466",
                    cancellationToken: cancellationToken);

                    break;
                case "/command3":
                    Message message200 = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                photo: "https://memorial-zv.ru/800/600/https/ds05.infourok.ru/uploads/ex/0b28/000798bf-e93f5b5d/img1.jpg",
                                caption: "<b>Help</b> <i></i> <a href=\"\"></a>",
                                parseMode: ParseMode.Html,
                                cancellationToken: cancellationToken);
                    Message message20 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Present|past|future|Simple" +
                    $"\n https://wordwall.net/play/1750/155/5892",
                    cancellationToken: cancellationToken);
                    break;
                case "/command4":
                    Message message30 = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                photo: "https://wampi.ru/image/RHl2mhP",
                                caption: "<b>Help</b> <i></i> <a href=\"\"></a>",
                                parseMode: ParseMode.Html,
                                cancellationToken: cancellationToken);
                    Message message31 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Past simple/past continuous" +
                    $"\n https://wordwall.net/play/10232/660/324646",
                    cancellationToken: cancellationToken);
                    break;
                case "/command5":
                    Message message40 = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                photo: "https://wampi.ru/image/RHl0j1P",
                                caption: "<b>Help</b> <i></i> <a href=\"\"></a>",
                                parseMode: ParseMode.Html,
                                cancellationToken: cancellationToken);
                    Message message41 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Passive voice" +
                    $"\n https://wordwall.net/play/731/766/39393",
                    cancellationToken: cancellationToken);
                    break;
                case "/command6":
                    Message message50 = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                photo: "https://wampi.ru/image/RHlWGCw",
                                caption: "<b>Help</b> <i></i> <a href=\"\"></a>",
                                parseMode: ParseMode.Html,
                                cancellationToken: cancellationToken);
                    Message message51 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Reported speech" +
                    $"\n https://wordwall.net/play/11034/131/272",
                    cancellationToken: cancellationToken);
                    break;
                case "/command7":
                    Message message60 = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                photo: "https://wampi.ru/image/RHlWhJ4",
                                caption: "<b>Help</b> <i></i> <a href=\"\"></a>",
                                parseMode: ParseMode.Html,
                                cancellationToken: cancellationToken);
                    Message message61 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"To be" +
                    $"\n https://wordwall.net/play/10303/757/31944",
                    cancellationToken: cancellationToken);
                    break;
                case "/command8":
                    Message message80 = await botClient.SendPhotoAsync(
                                chatId: chatId,
                                photo: "https://i.pinimg.com/originals/97/9c/04/979c04494acb498a6607a27e6c0138c0.jpg",
                                caption: "<b>Help</b> <i></i> <a href=\"\"></a>",
                                parseMode: ParseMode.Html,
                                cancellationToken: cancellationToken);
                    Message message81 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Computer" +
                    $"\n https://wordwall.net/embed/d6ef00bf52c54bf69fa4152e8265e801?themeId=45&templateId=3&fontStackId=0",
                    cancellationToken: cancellationToken);
                    break;
                case "/command9":
                    async void Listen0()
                    {
                        Message message91 = await botClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: $"Listening:" +
                        $"Please, write the words following the example)" +
                        $"\nThe Internet can ___________________ days, especially because of cyber-bullying. It’s difficult to open a newspaper these days and ___________________ this. " +
                        $"It’s a really ___________________ problem. Cyber-bullies are real cowards. " +
                        $"They hide behind their computer and scare people, ___________________ or threaten them. Even worse is when they publish pictures of their victims online. " +
                        $"I have a friend who had a really bad time ___________________ cyber-bully. He or she spread lots of gossip and lies on the Internet. My friend’s reputation ___________________. " +
                        $"A really bad thing is how young cyber-bullying starts. Many schoolchildren physically ___________________ and then continue online. Their ___________________ anywhere.",
                        cancellationToken: cancellationToken);
                        Message message92 = await botClient.SendAudioAsync(
                        chatId: chatId,
                        audio: "https://listenaminute.com/c/cyber-bullying.mp3",
                        performer: "",
                        title: "",
                        duration: 91, // in seconds
                        cancellationToken: cancellationToken);
                    }
                    async void Listen1()
                    {
                        Message message91 = await botClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: $"Listening:" +
                        "Please, write the words following the example)" +
                        "\nIt’s hard to believe ________ had computers a few years ago. I wonder how people lived. There must have been ________ paperwork. I can’t imagine writing everything by hand. " +
                        "I ________ everything worked without computers. We need computers today for everything. Hospitals, airports, the police… nothing can work without computers. " +
                        "I’m ________ ten times busier than now if I didn’t have a computer. Imagine ________ find ________ paper and an envelope and then walking down the street ________ letter! I love my computer. " +
                        "It makes everything ________ convenient. Sure, it freezes and crashes sometimes. Sure ________ data. But that’s not often. Most ________ my computer is like my best friend.",
                        cancellationToken: cancellationToken);
                        Message message92 = await botClient.SendAudioAsync(
                        chatId: chatId,
                        audio: "https://listenaminute.com/c/computers.mp3",
                        performer: "",
                        title: "",
                        duration: 91, // in seconds
                        cancellationToken: cancellationToken);
                    }
                    async void Listen2()
                    {
                        Message message91 = await botClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: $"Listening:" +
                        "Please, write the words following the example)" +
                        "\nApple Inc. is one of the world’s ___________________ favourite companies. " +
                        "It has ___________________ as being an innovative ___________________ of personal computers, software, music players, mobile phones and digital music distribution. " +
                        "The company was started by Steve Jobs and Steve Wozniak in 1976. " +
                        "In 2010, it became the ___________________ computer company. Apple has succeeded ___________________ with high quality, groundbreaking products. " +
                        "Almost everything Apple produces ___________________ frenzy. The brand loyalty the company enjoys ___________________ business." +
                        "The company’s product range is a list of stunning commercial successes, from the iMac to iTunes, the iPod, iPad and iPhone. " +
                        "‘Fortune’ magazine says Apple is the ___________________ company.",
                        cancellationToken: cancellationToken);
                        Message message92 = await botClient.SendAudioAsync(
                        chatId: chatId,
                        audio: "https://businessenglishmaterials.com/apple.mp3",
                        performer: "",
                        title: "",
                        duration: 91, // in seconds
                        cancellationToken: cancellationToken);
                    }
                    Random random = new Random();
                    int ImportRnd = random.Next(1, 4);
                    switch (ImportRnd)
                    {
                        case 1:
                            Listen0();
                            break;
                        case 2:
                            Listen1();
                            break;
                        case 3:
                            Listen2();
                            break;
                    }
                    break;
                case "/command10":
                    Message message101 = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: $"Guess the word from the text!",
                    cancellationToken: cancellationToken);
                    Random random1 = new Random();
                    var Scen = random1.Next(1, 7);
                    switch (Scen)
                    {
                        case 1:
                            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
        {
    new KeyboardButton[] { "I don't know" },
    new KeyboardButton[] { "Firewall" },
                                new KeyboardButton[] { "Spam" },
    new KeyboardButton[] { "Script" },
})
                            {
                                ResizeKeyboard = true
                            };
                            Message sentMessage = await botClient.SendTextMessageAsync(
                                chatId: chatId,
                                text: "This is a software barrier between networks that allows you to establish only authorized connections. " +
                                "It serves as a protection for the connected corporate network and prevents access to confidential information.",
                                replyMarkup: replyKeyboardMarkup,
                                cancellationToken: cancellationToken);
                            break;
                        case 2:
                            ReplyKeyboardMarkup replyKeyboardMarkup1 = new(new[]
        {
    new KeyboardButton[] { "Videocard" },
                                new KeyboardButton[] { "Ip" },
    new KeyboardButton[] { "I don't know" },
    new KeyboardButton[] { "Password" },
})
                            {
                                ResizeKeyboard = true
                            };
                            Message sentMessag21e = await botClient.SendTextMessageAsync(
                                chatId: chatId,
                                text: "A video adapter or an electronic device located on microchips and converting images of the computer's RAM into a video signal for the monitor.",
                                replyMarkup: replyKeyboardMarkup1,
                                cancellationToken: cancellationToken);
                            break;
                        case 3:
                            ReplyKeyboardMarkup replyKeyboardMarkup12 = new(new[]
        {
                                new KeyboardButton[] { "Domein" },
    new KeyboardButton[] { "I don't know" },
    new KeyboardButton[] { "DNS" },
    new KeyboardButton[] { "Hacker" },
})
                            {
                                ResizeKeyboard = true
                            };
                            Message sentMessag21e12 = await botClient.SendTextMessageAsync(
                                chatId: chatId,
                                text: "Someone who is trying to gain access to information illegally, hacking the system at the same time.",
                                replyMarkup: replyKeyboardMarkup12,
                                cancellationToken: cancellationToken);
                            break;
                        case 4:
                            ReplyKeyboardMarkup replyKeyboardMarkup123 = new(new[]
        {
                                new KeyboardButton[] { "El Primo" },
    new KeyboardButton[] { "I don't know" },
    new KeyboardButton[] { "Quest" },
    new KeyboardButton[] { "C,C++,C#" },
})
                            {
                                ResizeKeyboard = true
                            };
                            Message sentMessag21e132 = await botClient.SendTextMessageAsync(
                                chatId: chatId,
                                text: "A certain mission, for the completion of which a reward is given.",
                                replyMarkup: replyKeyboardMarkup123,
                                cancellationToken: cancellationToken);
                            break;
                        case 5:
                            ReplyKeyboardMarkup replyKeyboardMarkup1234 = new(new[]
        {
                                new KeyboardButton[] { "FAQ" },
    new KeyboardButton[] { "Wikipedia" },
    new KeyboardButton[] { "Score" },
    new KeyboardButton[] { "I don't know" },
})
                            {
                                ResizeKeyboard = true
                            };
                            Message sentMessag21e1324 = await botClient.SendTextMessageAsync(
                                chatId: chatId,
                                text: "Many websites have a section where you can find answers to the most frequently asked questions. This is a very useful option, thanks to which you can easily find answers to your questions.",
                                replyMarkup: replyKeyboardMarkup1234,
                                cancellationToken: cancellationToken);
                            break;
                        case 6:
                            ReplyKeyboardMarkup replyKeyboardMarkup12345 = new(new[]
        {
                                new KeyboardButton[] { "DeadLine" },
    new KeyboardButton[] { "Type:string" },
    new KeyboardButton[] { "Id" },
    new KeyboardButton[] { "I don't know" },
})
                            {
                                ResizeKeyboard = true
                            };
                            Message sentMessag21e13245 = await botClient.SendTextMessageAsync(
                                chatId: chatId,
                                text: "It can be a certain feature of an object that distinguishes it from others, that is, identifies it. Or it is a document certifying your identity, that is, showing your difference from others.",
                                replyMarkup: replyKeyboardMarkup12345,
                                cancellationToken: cancellationToken);
                            break;
                    }
                    break;
            }
            
        }
        Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };
            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }
    }
}
