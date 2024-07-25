// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record UpdatePanElementOrFolderElementType : ValueEnum<string>
{
    internal UpdatePanElementOrFolderElementType(string value)
        : base(value) { }

    public UpdatePanElementOrFolderElementType()
        : base("api") { }

    public static UpdatePanElementOrFolderElementType Api = new("api");
    public static UpdatePanElementOrFolderElementType Folder = new("folder");
    public static UpdatePanElementOrFolderElementType Collection = new("collection");
    public static UpdatePanElementOrFolderElementType Workspace = new("workspace");
}
