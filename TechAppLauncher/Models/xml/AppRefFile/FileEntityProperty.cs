using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAppLauncher.Models.xml.AppRefFile
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", IsNullable = false)]
    public class fileproperties
    {

        private object checkInCommentField;

        private CheckOutType checkOutTypeField;

        private string contentTagField;

        private CustomizedPageStatus customizedPageStatusField;

        private string eTagField;

        private Exists existsField;

        private Length lengthField;

        private Level levelField;

        private MajorVersion majorVersionField;

        private MinorVersion minorVersionField;

        private string nameField;

        private string serverRelativeUrlField;

        private TimeCreated timeCreatedField;

        private TimeLastModified timeLastModifiedField;

        private string titleField;

        private UIVersion uIVersionField;

        private decimal uIVersionLabelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public object CheckInComment
        {
            get
            {
                return this.checkInCommentField;
            }
            set
            {
                this.checkInCommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public CheckOutType CheckOutType
        {
            get
            {
                return this.checkOutTypeField;
            }
            set
            {
                this.checkOutTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string ContentTag
        {
            get
            {
                return this.contentTagField;
            }
            set
            {
                this.contentTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public CustomizedPageStatus CustomizedPageStatus
        {
            get
            {
                return this.customizedPageStatusField;
            }
            set
            {
                this.customizedPageStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string ETag
        {
            get
            {
                return this.eTagField;
            }
            set
            {
                this.eTagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Exists Exists
        {
            get
            {
                return this.existsField;
            }
            set
            {
                this.existsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Length Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public Level Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public MajorVersion MajorVersion
        {
            get
            {
                return this.majorVersionField;
            }
            set
            {
                this.majorVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public MinorVersion MinorVersion
        {
            get
            {
                return this.minorVersionField;
            }
            set
            {
                this.minorVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string Name
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string ServerRelativeUrl
        {
            get
            {
                return this.serverRelativeUrlField;
            }
            set
            {
                this.serverRelativeUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public TimeCreated TimeCreated
        {
            get
            {
                return this.timeCreatedField;
            }
            set
            {
                this.timeCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public TimeLastModified TimeLastModified
        {
            get
            {
                return this.timeLastModifiedField;
            }
            set
            {
                this.timeLastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public string Title
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
        public UIVersion UIVersion
        {
            get
            {
                return this.uIVersionField;
            }
            set
            {
                this.uIVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
        public decimal UIVersionLabel
        {
            get
            {
                return this.uIVersionLabelField;
            }
            set
            {
                this.uIVersionLabelField = value;
            }
        }
    }
}
