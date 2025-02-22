// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record TagUpdateTags(
    /// <value>A list of the associated tags as slugs.</value>
    [property: JsonPropertyName("tags")]
        List<TagUpdateTags.TagUpdateTagsTags> Tags
)
{
    /// <summary>Information about the tag.</summary>
    public record TagUpdateTagsTags(
        /// <value>The tag's ID within a team or individual (non-team) user scope.</value>
        [property: JsonPropertyName("slug")]
            string Slug
    );
}
