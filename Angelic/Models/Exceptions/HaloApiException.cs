using System.CodeDom.Compiler;

namespace Angelic.Models.Exceptions;

[GeneratedCode("NSwag", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class HaloApiException(
    string message,
    int statusCode,
    string? response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    Exception? innerException)
    : Exception(
        $"{message}\n\nStatus: {statusCode}\nResponse: \n{((response == null)
            ? "(null)"
            : response[..(response.Length >= 512 ? 512 : response.Length)])}", innerException)
{
    public int StatusCode { get; private set; } = statusCode;

    public string? Response { get; } = response;

    public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; } = headers;

    public override string ToString()
    {
        return $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
    }
}

[GeneratedCode("NSwag", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class HaloApiException<TResult>(
    string message,
    int statusCode,
    string? response,
    IReadOnlyDictionary<string, IEnumerable<string>> headers,
    TResult result,
    Exception? innerException)
    : HaloApiException(message, statusCode, response, headers, innerException)
{
    public TResult Result { get; private set; } = result;
}