//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using System.Text.Json;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace OpenShopify.Admin.Builder
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class CommentControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        /// <summary>
        /// Retrieves a list of comments
        /// </summary>
        /// <param name="created_at_max">Show comments created before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Show comments created after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <param name="limit">The maximum number of results to retrieve.</param>
        /// <param name="published_at_max">Show comments published before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_min">Show comments published after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_status">Filter results by their published status.</param>
        /// <param name="since_id">Restrict results to after the specified ID.</param>
        /// <param name="status">Filter results by their status.</param>
        /// <param name="updated_at_max">Show comments last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Show comments last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <returns>Retrieves a list of comments</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("comments.json")]
        public abstract System.Threading.Tasks.Task RetrieveListOfComments([Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? limit = "50", [Microsoft.AspNetCore.Mvc.FromQuery] string? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = "any", [Microsoft.AspNetCore.Mvc.FromQuery] string? since_id = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? status = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_min = null);

        /// <summary>
        /// Creates a comment for an article
        /// </summary>
        /// <returns>Creates a comment for an article</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("comments.json")]
        public abstract System.Threading.Tasks.Task CreateCommentForArticle();

        /// <summary>
        /// Retrieves a count of comments
        /// </summary>
        /// <param name="created_at_max">Count comments created before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="created_at_min">Count comments created after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_max">Count comments published before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_at_min">Count comments published after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="published_status">Retrieve a count of comments with a given published status.</param>
        /// <param name="status">Retrieve a count of comments with a given status.</param>
        /// <param name="updated_at_max">Count comments last updated before date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <param name="updated_at_min">Count comments last updated after date (format: 2014-04-25T16:15:47-04:00).</param>
        /// <returns>Retrieves a count of comments</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("comments/count.json")]
        public abstract System.Threading.Tasks.Task RetrieveCountOfComments([Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? created_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_at_min = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? published_status = "any", [Microsoft.AspNetCore.Mvc.FromQuery] string? status = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_max = null, [Microsoft.AspNetCore.Mvc.FromQuery] string? updated_at_min = null);

        /// <summary>
        /// Retrieves a single comment by its ID
        /// </summary>
        /// <param name="fields">Show only certain fields, specified by a comma-separated list of field names.</param>
        /// <returns>Retrieves a single comment by its ID</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("comments/{comment_id}.json")]
        public abstract System.Threading.Tasks.Task RetrieveSingleCommentByItsID(string comment_id, [Microsoft.AspNetCore.Mvc.FromQuery] string? fields = null);

        /// <summary>
        /// Updates a comment of an article
        /// </summary>
        /// <returns>Updates a comment of an article</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("comments/{comment_id}.json")]
        public abstract System.Threading.Tasks.Task UpdateCommentOfArticle(string comment_id);

        /// <summary>
        /// Marks a comment as spam
        /// </summary>
        /// <returns>Marks a comment as spam</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("comments/{comment_id}/spam.json")]
        public abstract System.Threading.Tasks.Task MarkCommentAsSpam(string comment_id);

        /// <summary>
        /// Marks a comment as not spam
        /// </summary>
        /// <returns>Marks a comment as not spam</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("comments/{comment_id}/not_spam.json")]
        public abstract System.Threading.Tasks.Task MarkCommentAsNotSpam(string comment_id);

        /// <summary>
        /// Approves a comment
        /// </summary>
        /// <returns>Approves a comment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("comments/{comment_id}/approve.json")]
        public abstract System.Threading.Tasks.Task ApproveComment(string comment_id);

        /// <summary>
        /// Removes a comment
        /// </summary>
        /// <returns>Removes a comment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("comments/{comment_id}/remove.json")]
        public abstract System.Threading.Tasks.Task RemoveComment(string comment_id);

        /// <summary>
        /// Restores a previously removed comment
        /// </summary>
        /// <returns>Restores a previously removed comment</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("comments/{comment_id}/restore.json")]
        public abstract System.Threading.Tasks.Task RestorePreviouslyRemovedComment(string comment_id);

    }

    


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603