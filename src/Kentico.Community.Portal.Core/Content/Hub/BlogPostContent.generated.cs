//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS.ContentEngine;
using CMS.MediaLibrary;

namespace Kentico.Community.Portal.Core.Content
{
	/// <summary>
	/// Represents a content item of type <see cref="BlogPostContent"/>.
	/// </summary>
	[RegisterContentTypeMapping(CONTENT_TYPE_NAME)]
	public partial class BlogPostContent : IContentItemFieldsSource, IListableItem
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.BlogPostContent";


		/// <summary>
		/// Represents system properties for a content item.
		/// </summary>
		[SystemField]
		public ContentItemFields SystemFields { get; set; }


		/// <summary>
		/// BlogPostContentTitle.
		/// </summary>
		public string BlogPostContentTitle { get; set; }


		/// <summary>
		/// BlogPostContentAuthor.
		/// </summary>
		public IEnumerable<AuthorContent> BlogPostContentAuthor { get; set; }


		/// <summary>
		/// BlogPostContentTeaserMediaFileImage.
		/// </summary>
		public IEnumerable<AssetRelatedItem> BlogPostContentTeaserMediaFileImage { get; set; }


		/// <summary>
		/// BlogPostContentShortDescription.
		/// </summary>
		public string BlogPostContentShortDescription { get; set; }


		/// <summary>
		/// BlogPostContentBlogType.
		/// </summary>
		public IEnumerable<TagReference> BlogPostContentBlogType { get; set; }


		/// <summary>
		/// BlogPostContentDXTopics.
		/// </summary>
		public IEnumerable<TagReference> BlogPostContentDXTopics { get; set; }


		/// <summary>
		/// BlogPostContentPublishedDate.
		/// </summary>
		public DateTime BlogPostContentPublishedDate { get; set; }


		/// <summary>
		/// BlogPostContentSourceType.
		/// </summary>
		public string BlogPostContentSourceType { get; set; }


		/// <summary>
		/// BlogPostContentContentMarkdown.
		/// </summary>
		public string BlogPostContentContentMarkdown { get; set; }


		/// <summary>
		/// BlogPostContentContentHTML.
		/// </summary>
		public string BlogPostContentContentHTML { get; set; }


		/// <summary>
		/// ListableItemTitle.
		/// </summary>
		public string ListableItemTitle { get; set; }


		/// <summary>
		/// ListableItemShortDescription.
		/// </summary>
		public string ListableItemShortDescription { get; set; }


		/// <summary>
		/// ListableItemFeaturedImage.
		/// </summary>
		public IEnumerable<MediaAssetContent> ListableItemFeaturedImage { get; set; }
	}
}