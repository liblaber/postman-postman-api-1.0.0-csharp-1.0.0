// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record GetAllElementsAndFoldersType : ValueEnum<string>
{
    internal GetAllElementsAndFoldersType(string value)
        : base(value) { }

    public GetAllElementsAndFoldersType()
        : base("api") { }

    public static GetAllElementsAndFoldersType Api = new("api");
    public static GetAllElementsAndFoldersType Folder = new("folder");
    public static GetAllElementsAndFoldersType Collection = new("collection");
    public static GetAllElementsAndFoldersType Workspace = new("workspace");
}
