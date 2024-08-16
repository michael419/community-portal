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

namespace Kentico.Community.Portal.Core.Content
{
	/// <summary>
	/// Represents a content item of type <see cref="CommunityGroupContent"/>.
	/// </summary>
	[RegisterContentTypeMapping(CONTENT_TYPE_NAME)]
	public partial class CommunityGroupContent : IContentItemFieldsSource, IListableItem
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.CommunityGroupContent";


		/// <summary>
		/// Represents system properties for a content item.
		/// </summary>
		[SystemField]
		public ContentItemFields SystemFields { get; set; }


		/// <summary>
		/// CommunityGroupContentWebsiteURL.
		/// </summary>
		public string CommunityGroupContentWebsiteURL { get; set; }


		/// <summary>
		/// CommunityGroupContentDescription.
		/// </summary>
		public string CommunityGroupContentDescription { get; set; }


		/// <summary>
		/// CommunityGroupContentAddressCity.
		/// </summary>
		public string CommunityGroupContentAddressCity { get; set; }


		/// <summary>
		/// CommunityGroupContentAddressStateOrProvince.
		/// </summary>
		public string CommunityGroupContentAddressStateOrProvince { get; set; }


		/// <summary>
		/// CommunityGroupContentAddressCountry.
		/// </summary>
		public string CommunityGroupContentAddressCountry { get; set; }


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