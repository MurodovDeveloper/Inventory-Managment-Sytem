using Mvc.Application.Models;

namespace Mvc.Application.Services;

public interface ITelegramService
{
    public ValueTask SendMessage(TelegramMessageModel message);
}
