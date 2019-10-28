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

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "74780e0813c72790")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.11")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Employee</summary>
	[PublishedContentModel("employee")]
	public partial class Employee : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "employee";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Employee(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Employee, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// EmployeeAdress
		///</summary>
		[ImplementPropertyType("employeeAdress")]
		public string EmployeeAdress
		{
			get { return this.GetPropertyValue<string>("employeeAdress"); }
		}

		///<summary>
		/// EmployeeName
		///</summary>
		[ImplementPropertyType("employeeName")]
		public string EmployeeName
		{
			get { return this.GetPropertyValue<string>("employeeName"); }
		}

		///<summary>
		/// EmployeePhone
		///</summary>
		[ImplementPropertyType("employeePhone")]
		public string EmployeePhone
		{
			get { return this.GetPropertyValue<string>("employeePhone"); }
		}
	}

	// Mixin content Type 1062 with alias "companyDetails"
	/// <summary>CompanyDetails</summary>
	public partial interface ICompanyDetails : IPublishedContent
	{
		/// <summary>CompanyAddress</summary>
		string CompanyAddress { get; }

		/// <summary>CompanyName</summary>
		string CompanyName { get; }

		/// <summary>CompanyPhone</summary>
		string CompanyPhone { get; }
	}

	/// <summary>CompanyDetails</summary>
	[PublishedContentModel("companyDetails")]
	public partial class CompanyDetails : PublishedContentModel, ICompanyDetails
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "companyDetails";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CompanyDetails(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CompanyDetails, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// CompanyAddress
		///</summary>
		[ImplementPropertyType("companyAddress")]
		public string CompanyAddress
		{
			get { return GetCompanyAddress(this); }
		}

		/// <summary>Static getter for CompanyAddress</summary>
		public static string GetCompanyAddress(ICompanyDetails that) { return that.GetPropertyValue<string>("companyAddress"); }

		///<summary>
		/// CompanyName
		///</summary>
		[ImplementPropertyType("companyName")]
		public string CompanyName
		{
			get { return GetCompanyName(this); }
		}

		/// <summary>Static getter for CompanyName</summary>
		public static string GetCompanyName(ICompanyDetails that) { return that.GetPropertyValue<string>("companyName"); }

		///<summary>
		/// CompanyPhone
		///</summary>
		[ImplementPropertyType("companyPhone")]
		public string CompanyPhone
		{
			get { return GetCompanyPhone(this); }
		}

		/// <summary>Static getter for CompanyPhone</summary>
		public static string GetCompanyPhone(ICompanyDetails that) { return that.GetPropertyValue<string>("companyPhone"); }
	}

	/// <summary>CorporateHeadquarters</summary>
	[PublishedContentModel("corporateHeadquarters")]
	public partial class CorporateHeadquarters : PublishedContentModel, ICompanyDetails
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "corporateHeadquarters";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CorporateHeadquarters(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CorporateHeadquarters, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// CompanyAddress
		///</summary>
		[ImplementPropertyType("companyAddress")]
		public string CompanyAddress
		{
			get { return Umbraco.Web.PublishedContentModels.CompanyDetails.GetCompanyAddress(this); }
		}

		///<summary>
		/// CompanyName
		///</summary>
		[ImplementPropertyType("companyName")]
		public string CompanyName
		{
			get { return Umbraco.Web.PublishedContentModels.CompanyDetails.GetCompanyName(this); }
		}

		///<summary>
		/// CompanyPhone
		///</summary>
		[ImplementPropertyType("companyPhone")]
		public string CompanyPhone
		{
			get { return Umbraco.Web.PublishedContentModels.CompanyDetails.GetCompanyPhone(this); }
		}
	}

	/// <summary>Company</summary>
	[PublishedContentModel("company")]
	public partial class Company : PublishedContentModel, ICompanyDetails
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "company";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Company(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Company, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// CompanyLocation
		///</summary>
		[ImplementPropertyType("companyLocation")]
		public string CompanyLocation
		{
			get { return this.GetPropertyValue<string>("companyLocation"); }
		}

		///<summary>
		/// CompanyAddress
		///</summary>
		[ImplementPropertyType("companyAddress")]
		public string CompanyAddress
		{
			get { return Umbraco.Web.PublishedContentModels.CompanyDetails.GetCompanyAddress(this); }
		}

		///<summary>
		/// CompanyName
		///</summary>
		[ImplementPropertyType("companyName")]
		public string CompanyName
		{
			get { return Umbraco.Web.PublishedContentModels.CompanyDetails.GetCompanyName(this); }
		}

		///<summary>
		/// CompanyPhone
		///</summary>
		[ImplementPropertyType("companyPhone")]
		public string CompanyPhone
		{
			get { return Umbraco.Web.PublishedContentModels.CompanyDetails.GetCompanyPhone(this); }
		}
	}

	/// <summary>CompanyLand</summary>
	[PublishedContentModel("companyLand")]
	public partial class CompanyLand : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "companyLand";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CompanyLand(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CompanyLand, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Adress
		///</summary>
		[ImplementPropertyType("adress")]
		public string Adress
		{
			get { return this.GetPropertyValue<string>("adress"); }
		}

		///<summary>
		/// LandName
		///</summary>
		[ImplementPropertyType("landName")]
		public string LandName
		{
			get { return this.GetPropertyValue<string>("landName"); }
		}

		///<summary>
		/// Location
		///</summary>
		[ImplementPropertyType("location")]
		public string Location
		{
			get { return this.GetPropertyValue<string>("location"); }
		}

		///<summary>
		/// Phone
		///</summary>
		[ImplementPropertyType("phone")]
		public string Phone
		{
			get { return this.GetPropertyValue<string>("phone"); }
		}
	}

	/// <summary>Department</summary>
	[PublishedContentModel("department")]
	public partial class Department : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "department";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Department(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Department, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Person
		///</summary>
		[ImplementPropertyType("employeeList")]
		public IEnumerable<IPublishedContent> EmployeeList
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("employeeList"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
