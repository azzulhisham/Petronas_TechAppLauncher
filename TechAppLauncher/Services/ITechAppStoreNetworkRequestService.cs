using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TechAppLauncher.Models;

namespace TechAppLauncher.Services
{
    public interface ITechAppStoreNetworkRequestService
    {
        Task<LauncherVersion> GetLauncherVersion();
        Task DownloadFileAsync(RefFileInfo refFileInfo, string targetPath);
        Task<IList<Models.App>> GetAllAsync();
        Task<IList<RefFileDetail>> GetAllRefFilesAsync();
        Task<List<string>?> GetAppDetailGalleries(string appUID);
        Task<RefFileInfo> GetFileAsync(string fileRefUrl);
        Task<Stream> LoadCoverBitmapAsync(string imgUrl);
        Task<IList<UserDownloadSession>> GetUserDownloadSessionByUser(string userName);
        Task<UserDownloadSession> AddUserDownloadSession(UserDownloadSession userDownloadSession);
        Task<AppDistRefDet> GetAppDistributionReferenceDetailByAppUID(string appUID);
    }
}