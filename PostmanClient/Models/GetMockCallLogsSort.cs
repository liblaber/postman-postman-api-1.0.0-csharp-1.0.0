// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record GetMockCallLogsSort : ValueEnum<string>
{
    internal GetMockCallLogsSort(string value)
        : base(value) { }

    public GetMockCallLogsSort()
        : base("servedAt") { }

    public static GetMockCallLogsSort ServedAt = new("servedAt");
}
