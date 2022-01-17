using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAppLauncher.Models.xml.AppList
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
    public class feed
    {

        private string idField;

        private object titleField;

        private System.DateTime updatedField;

        private feedEntry[] entryField;

        private string baseField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public System.DateTime updated
        {
            get
            {
                return this.updatedField;
            }
            set
            {
                this.updatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public feedEntry[] entry
        {
            get
            {
                return this.entryField;
            }
            set
            {
                this.entryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string @base
        {
            get
            {
                return this.baseField;
            }
            set
            {
                this.baseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    public partial class feedEntry
    {

        private string idField;

        private feedEntryCategory categoryField;

        private feedEntryLink[] linkField;

        private object titleField;

        private System.DateTime updatedField;

        private feedEntryAuthor authorField;

        private feedEntryContent contentField;

        private string etagField;

        /// <remarks/>
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public feedEntryCategory category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link")]
        public feedEntryLink[] link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        public object title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public System.DateTime updated
        {
            get
            {
                return this.updatedField;
            }
            set
            {
                this.updatedField = value;
            }
        }

        /// <remarks/>
        public feedEntryAuthor author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public feedEntryContent content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string etag
        {
            get
            {
                return this.etagField;
            }
            set
            {
                this.etagField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    public partial class feedEntryCategory
    {

        private string termField;

        private string schemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scheme
        {
            get
            {
                return this.schemeField;
            }
            set
            {
                this.schemeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    public partial class feedEntryLink
    {

        private string relField;

        private string hrefField;

        private string typeField;

        private string titleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    public partial class feedEntryAuthor
    {

        private object nameField;

        /// <remarks/>
        public object name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    public partial class feedEntryContent
    {

        private properties propertiesField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public properties properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", IsNullable = false)]
    public partial class properties
    {

        private FileSystemObjectType fileSystemObjectTypeField;

        private Id idField;

        private string contentTypeIdField;

        private Title titleField;

        private OData__ModerationComments oData__ModerationCommentsField;

        private AppUID appUIDField;

        private AppVersion appVersionField;

        private string appTypeField;

        private string appGroupField;

        private DevelopBy developByField;

        private DevelopDate developDateField;

        private UploadedBy uploadedByField;

        private UploadedDate uploadedDateField;

        private AppLogoUrl appLogoUrlField;

        private AppDetail appDetailField;

        private OData__ModerationStatus oData__ModerationStatusField;

        private AverageRating averageRatingField;

        private RatingCount ratingCountField;

        private LikesCount likesCountField;

        private string installerTypeField;

        private AppSupport appSupportField;

        private AuthorId authorIdField;

        private EditorId editorIdField;

        private Modified modifiedField;

        private Created createdField;

        private SortOrder sortOrderField;

        private AppCategoryId appCategoryIdField;

        private AppSubCategoryId appSubCategoryIdField;

        private AppOwnerId appOwnerIdField;

        private Selected selectedField;

        private AppsAppr appsApprField;

        private WorkflowInfo workflowInfoField;

        private PluginApp pluginAppField;

        private string activeField;

        private ShortDescription shortDescriptionField;

        private WhatsNew whatsNewField;

        private ID idField1;

        private decimal oData__UIVersionStringField;

        private Attachments attachmentsField;

        private GUID gUIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public FileSystemObjectType FileSystemObjectType
        {
            get
            {
                return this.fileSystemObjectTypeField;
            }
            set
            {
                this.fileSystemObjectTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Id Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string ContentTypeId
        {
            get
            {
                return this.contentTypeIdField;
            }
            set
            {
                this.contentTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Title Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public OData__ModerationComments OData__ModerationComments
        {
            get
            {
                return this.oData__ModerationCommentsField;
            }
            set
            {
                this.oData__ModerationCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppUID AppUID
        {
            get
            {
                return this.appUIDField;
            }
            set
            {
                this.appUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppVersion AppVersion
        {
            get
            {
                return this.appVersionField;
            }
            set
            {
                this.appVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string AppType
        {
            get
            {
                return this.appTypeField;
            }
            set
            {
                this.appTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string AppGroup
        {
            get
            {
                return this.appGroupField;
            }
            set
            {
                this.appGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public DevelopBy DevelopBy
        {
            get
            {
                return this.developByField;
            }
            set
            {
                this.developByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public DevelopDate DevelopDate
        {
            get
            {
                return this.developDateField;
            }
            set
            {
                this.developDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public UploadedBy UploadedBy
        {
            get
            {
                return this.uploadedByField;
            }
            set
            {
                this.uploadedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public UploadedDate UploadedDate
        {
            get
            {
                return this.uploadedDateField;
            }
            set
            {
                this.uploadedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppLogoUrl AppLogoUrl
        {
            get
            {
                return this.appLogoUrlField;
            }
            set
            {
                this.appLogoUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppDetail AppDetail
        {
            get
            {
                return this.appDetailField;
            }
            set
            {
                this.appDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public OData__ModerationStatus OData__ModerationStatus
        {
            get
            {
                return this.oData__ModerationStatusField;
            }
            set
            {
                this.oData__ModerationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AverageRating AverageRating
        {
            get
            {
                return this.averageRatingField;
            }
            set
            {
                this.averageRatingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public RatingCount RatingCount
        {
            get
            {
                return this.ratingCountField;
            }
            set
            {
                this.ratingCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public LikesCount LikesCount
        {
            get
            {
                return this.likesCountField;
            }
            set
            {
                this.likesCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string InstallerType
        {
            get
            {
                return this.installerTypeField;
            }
            set
            {
                this.installerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppSupport AppSupport
        {
            get
            {
                return this.appSupportField;
            }
            set
            {
                this.appSupportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AuthorId AuthorId
        {
            get
            {
                return this.authorIdField;
            }
            set
            {
                this.authorIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public EditorId EditorId
        {
            get
            {
                return this.editorIdField;
            }
            set
            {
                this.editorIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Modified Modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Created Created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public SortOrder SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppCategoryId AppCategoryId
        {
            get
            {
                return this.appCategoryIdField;
            }
            set
            {
                this.appCategoryIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppSubCategoryId AppSubCategoryId
        {
            get
            {
                return this.appSubCategoryIdField;
            }
            set
            {
                this.appSubCategoryIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppOwnerId AppOwnerId
        {
            get
            {
                return this.appOwnerIdField;
            }
            set
            {
                this.appOwnerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Selected Selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public AppsAppr AppsAppr
        {
            get
            {
                return this.appsApprField;
            }
            set
            {
                this.appsApprField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public WorkflowInfo WorkflowInfo
        {
            get
            {
                return this.workflowInfoField;
            }
            set
            {
                this.workflowInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public PluginApp PluginApp
        {
            get
            {
                return this.pluginAppField;
            }
            set
            {
                this.pluginAppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string Active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public ShortDescription ShortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public WhatsNew WhatsNew
        {
            get
            {
                return this.whatsNewField;
            }
            set
            {
                this.whatsNewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public ID ID
        {
            get
            {
                return this.idField1;
            }
            set
            {
                this.idField1 = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public decimal OData__UIVersionString
        {
            get
            {
                return this.oData__UIVersionStringField;
            }
            set
            {
                this.oData__UIVersionStringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Attachments Attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public GUID GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class FileSystemObjectType
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class Id
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class Title
    {

        private string spaceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class OData__ModerationComments
    {

        private bool nullField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppUID
    {

        private string spaceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppVersion
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class DevelopBy
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string spaceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class DevelopDate
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class UploadedBy
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class UploadedDate
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppLogoUrl
    {

        private string descriptionField;

        private string url;

        private string typeField;

        private bool nullField;

        private bool nullFieldSpecified;

        /// <remarks/>
        public string DescriptionField
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppDetail
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class OData__ModerationStatus
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AverageRating
    {

        private string typeField;

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class RatingCount
    {

        private string typeField;

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class LikesCount
    {

        private bool nullField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppSupport
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AuthorId
    {

        private string typeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class EditorId
    {

        private string typeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class Modified
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class Created
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class SortOrder
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppCategoryId
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppSubCategoryId
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppOwnerId
    {

        private ushort[] elementField;

        private bool nullField;

        private bool nullFieldSpecified;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("element")]
        public ushort[] element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class Selected
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class AppsAppr
    {

        private string typeField;

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class WorkflowInfo
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string spaceField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class PluginApp
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class ShortDescription
    {

        private string spaceField;

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class WhatsNew
    {

        private bool nullField;

        private bool nullFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public bool @null
        {
            get
            {
                return this.nullField;
            }
            set
            {
                this.nullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nullSpecified
        {
            get
            {
                return this.nullFieldSpecified;
            }
            set
            {
                this.nullFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class ID
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class Attachments
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices", IsNullable = false)]
    public partial class GUID
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
