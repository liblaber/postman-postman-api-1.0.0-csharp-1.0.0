// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record AscDescDefaultDesc : ValueEnum<string>
{
    internal AscDescDefaultDesc(string value)
        : base(value) { }

    public AscDescDefaultDesc()
        : base("asc") { }

    public static AscDescDefaultDesc Asc = new("asc");
    public static AscDescDefaultDesc Desc = new("desc");
}
