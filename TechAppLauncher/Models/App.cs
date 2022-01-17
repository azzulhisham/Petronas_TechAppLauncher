using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAppLauncher.Models
{
    public class App
    {
        public int FileSystemObjectType { get; set; }
        public int Id { get; set; }
        public string ContentTypeId { get; set; }
        public string Title { get; set; }
        public object OData__ModerationComments { get; set; }
        public string AppUID { get; set; }
        public double? AppVersion { get; set; }
        public string AppType { get; set; }
        public string AppGroup { get; set; }
        public string DevelopBy { get; set; }
        public DateTime? DevelopDate { get; set; }
        public string UploadedBy { get; set; }
        public DateTime? UploadedDate { get; set; }
        public AppLogoUrl AppLogoUrl { get; set; }
        public string AppDetail { get; set; }
        public int OData__ModerationStatus { get; set; }
        public int? AverageRating { get; set; }
        public int? RatingCount { get; set; }
        public object LikesCount { get; set; }
        public string InstallerType { get; set; }
        public string AppSupport { get; set; }
        public int AuthorId { get; set; }
        public int EditorId { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public int? SortOrder { get; set; }
        public int AppCategoryId { get; set; }
        public int AppSubCategoryId { get; set; }
        public bool Selected { get; set; }
        public int? AppsAppr { get; set; }
        public string WorkflowInfo { get; set; }
        public string PluginApp { get; set; }
        public string Active { get; set; }
        public string ShortDescription { get; set; }
        public string WhatsNew { get; set; }
        public int ID { get; set; }
        public string OData__UIVersionString { get; set; }
        public bool Attachments { get; set; }
        public string GUID { get; set; }
    }
}
