using Mvc.Application.Models;
using Mvc.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Mvc.Infrastructure.Services
{

    public class TelegramService : ITelegramService
    {
        private readonly ITelegramBotClient _telegramService;
        public TelegramService()
        {
            _telegramService = new TelegramBotClient("6078270636:AAHJ_MXa8460TRiWE-LDxN90s2AFdrrlFHs");
        }
        public async ValueTask SendMessage(TelegramMessageModel message)
        {
            ChatId chatId = new ChatId(591208356);
            await _telegramService.SendTextMessageAsync(chatId, message.ToString());
        }
    }
}
