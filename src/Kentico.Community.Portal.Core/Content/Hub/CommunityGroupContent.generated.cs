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
	public partial class CommunityGroupContent : IContentItemFieldsSource
	{
		/// <summary>
		/// Code name of the content type.
		/// </summary>
		public const string CONTENT_TYPE_NAME = "KenticoCommunity.CommunityGroupContent";


		/// <summary>
		/// Represents system properties for a content item.
		/// </summary>
		public ContentItemFields SystemFields { get; set; }


		/// <summary>
		/// CommunityGroupContentTitle.
		/// </summary>
		public string CommunityGroupContentTitle { get; set; }


		/// <summary>
		/// CommunityGroupContentPrimaryImageMediaAssets.
		/// </summary>
		public IEnumerable<MediaAssetContent> CommunityGroupContentPrimaryImageMediaAssets { get; set; }


		/// <summary>
		/// CommunityGroupContentWebsiteURL.
		/// </summary>
		public string CommunityGroupContentWebsiteURL { get; set; }


		/// <summary>
		/// CommunityGroupContentShortDescription.
		/// </summary>
		public string CommunityGroupContentShortDescription { get; set; }


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
	}
}