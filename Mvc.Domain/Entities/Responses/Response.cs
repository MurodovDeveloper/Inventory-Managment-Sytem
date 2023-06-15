using System.Text.Json.Serialization;

namespace Mvc.Domain.Entities.Responses;

public class Response<T>
{
    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; } = 200;
    public string Message { get; set; } = "";
    public bool IsSuccess { get; set; } = true;
    public T Result { get; set; }

}
