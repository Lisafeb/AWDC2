//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Project Overview</summary>
	[PublishedContentModel("projectOverview")]
	public partial class ProjectOverview : PublishedContentModel, IMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projectOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProjectOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProjectOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Projects Body Text
		///</summary>
		[ImplementPropertyType("projectsBodyText")]
		public IHtmlString ProjectsBodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("projectsBodyText"); }
		}

		///<summary>
		/// Projects Title
		///</summary>
		[ImplementPropertyType("projectsTitle")]
		public string ProjectsTitle
		{
			get { return this.GetPropertyValue<string>("projectsTitle"); }
		}

		///<summary>
		/// Meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta Keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetMetaKeywords(this); }
		}

		///<summary>
		/// UmbracoNaviHide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Master.GetUmbracoNaviHide(this); }
		}
	}
}