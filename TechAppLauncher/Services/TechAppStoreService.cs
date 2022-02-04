using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TechAppLauncher.Helpers;
using TechAppLauncher.Models;

namespace TechAppLauncher.Services
{
    public class TechAppStoreService : ITechAppStoreNetworkRequestService
    {
        static HttpClient s_httpClient;
        static HttpClientHandler _handler;
        static LauncherConfig LauncherConfig;

        const string apiBaseUrl = @"http://10.14.161.44/TechAppLauncherAPI/api/TechAppLauncher/";


        public TechAppStoreService()
        {
            var LauncherConfig = GetLauncherConfiguration();

            _handler = new HttpClientHandler()
            {
                Credentials = new NetworkCredential(LauncherConfig.AppStoreServerUser, LauncherConfig.AppStoreServerPwd, LauncherConfig.AppStoreServerDomain)
            };

            _handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            _handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };
        }

        public async Task<IList<Models.App>> GetAllAsync()
        {
            string url = @"https://techupstream.petronas.com/tastore/_api/lists/getbytitle('AppList')/items?$orderby=AppGroup,Title asc";
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);
            //var content = await response.Content.ReadFromJsonAsync(typeof(Models.AppDetail));
            var content = await response.Content.ReadAsStringAsync();

            Serializer serializer = new Serializer();
            //var feeds = serializer.DeserializeFeed(content);
            var feeds = serializer.Deserialize<Models.xml.AppList.feed>(content);


            var results = feeds.entry.Select(s => new Models.App()
            {
                AppUID = s.content.properties.AppUID != null ? s.content.properties.AppUID.Value : "",
                AppType = s.content.properties.AppType != null ? s.content.properties.AppType : "",
                PluginApp = s.content.properties.PluginApp != null ? s.content.properties.PluginApp.Value : "",
                ID = s.content.properties.ID != null ? s.content.properties.ID.Value : 0,
                Title = s.content.properties.Title != null ? s.content.properties.Title.Value : "",
                ShortDescription = s.content.properties.ShortDescription != null ? s.content.properties.ShortDescription.Value : "",
                AppLogoUrl = new Models.AppLogoUrl()
                {
                    Url = s.content.properties.AppLogoUrl != null && s.content.properties.AppLogoUrl.Url != null ? s.content.properties.AppLogoUrl.Url : null,
                }
            }).ToList();

            return results;
        }

        public async Task<List<string>?> GetAppDetailGalleries(string appUID)
        {
            //
            string url = @"https://techupstream.petronas.com/tastore/_api/Web/Lists/GetByTitle('AppImage')/items?$select=EncodedAbsUrl&$select=imageType&$filter=AppUID%20eq%20%27{appUID}%27";
            url = url.Replace("{appUID}", appUID);

            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //request.Content = new StringContent("", Encoding.UTF8, "application/json");


            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);
            //var content = await response.Content.ReadFromJsonAsync(typeof(Models.AppDetail));
            var content = await response.Content.ReadAsStringAsync();

            //content = System.IO.File.ReadAllText(@"Data\TestData.txt", Encoding.ASCII);
            //var query = JsonConvert.DeserializeObject<AppDetail>(content);

            Serializer serializer = new Serializer();
            //var feeds = serializer.DeserializeFeed(content);
            var feeds = serializer.Deserialize<Models.xml.AppDetail.feed>(content);

            return feeds.entry?.Select(n => n.content.properties.EncodedAbsUrl).ToList();
        }


        public async Task<Stream> LoadCoverBitmapAsync(string imgUrl)
        {
            s_httpClient = new HttpClient(_handler);

            var data = await s_httpClient.GetByteArrayAsync(imgUrl);
            return new MemoryStream(data);
        }

        public async Task<IList<RefFileDetail>> GetAllRefFilesAsync()
        {
            string url = @"https://techupstream.petronas.com/tastore/_api/lists/getbytitle('AppVault')/items";
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);
                var content = await response.Content.ReadAsStringAsync();

                Serializer serializer = new Serializer();
                var feeds = serializer.Deserialize<Models.xml.AppRefFile.feed>(content);


                var results = feeds.entry.Select(s => new RefFileDetail()
                {
                    AppUID = s.content.properties.AppUIDId != null ? s.content.properties.AppUIDId.Value : "",
                    Title = s.content.properties.Title != null ? s.content.properties.Title.Value : "",
                    FileID = s.content.properties.ID?.Value,
                    FileRefUrl = feeds.@base + s.id.Trim() + "/File"
                }).ToList();

                return results;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IList<UserDownloadSession>> GetUserDownloadSessionByUser(string userName)
        {
            string url = apiBaseUrl + @"GetUserDownloadSessionsByUsername/" + userName;
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<UserDownloadSession> userDownloadSessions = null;

            try
            {

                var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (content != null && !string.IsNullOrEmpty(content))
                    {
                        userDownloadSessions = JsonConvert.DeserializeObject<List<UserDownloadSession>>(content);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return userDownloadSessions;
        }

        public async Task<UserDownloadSession> AddUserDownloadSession(UserDownloadSession userDownloadSession)
        {
            string url = apiBaseUrl + @"AddUserDownloadSession/";
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Post,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Content = new StringContent(JsonConvert.SerializeObject(userDownloadSession), Encoding.UTF8, "application/json");
            UserDownloadSession userDownloadSessionFromDB = null;

            try
            {

                var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (content != null && !string.IsNullOrEmpty(content))
                    {
                        userDownloadSessionFromDB = JsonConvert.DeserializeObject<UserDownloadSession>(content);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return userDownloadSessionFromDB;
        }

        public async Task<LauncherVersion> GetLauncherVersion()
        {
            string url = apiBaseUrl + @"GetLauncherVersion/";
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };
            
            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            s_httpClient.Timeout = GetTimeOut(5);

            LauncherVersion launcherVersion = null;

            try
            {
                var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (content != null && !string.IsNullOrEmpty(content))
                    {
                        launcherVersion = JsonConvert.DeserializeObject<LauncherVersion>(content);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return launcherVersion;
        }

        public async Task<AppDistRefDet> GetAppDistributionReferenceDetailByAppUID(string appUID)
        {
            string url = apiBaseUrl + @"GetAppDistributionReferenceDetailByAppUID?appUID=" + appUID;
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            s_httpClient.Timeout = GetTimeOut(5);

            AppDistRefDet appDistRefDet = null;

            try
            {
                var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (content != null && !string.IsNullOrEmpty(content))
                    {
                        appDistRefDet = JsonConvert.DeserializeObject<AppDistRefDet>(content);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return appDistRefDet;
        }


        static LauncherConfig GetLauncherConfiguration()
        {
            string url = apiBaseUrl + @"GetlauncherAppConfig/";
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient();
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            s_httpClient.Timeout = GetTimeOut(5);

            LauncherConfig launcherConfig = null;

            try
            {
                var response = s_httpClient.Send(request, HttpCompletionOption.ResponseContentRead);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var content = response.Content.ReadAsStream();
                    byte[] buffers = new byte[content.Length];
                    content.Read(buffers, 0, buffers.Length);
                    string responseContent = Encoding.Default.GetString(buffers);

                    if (responseContent != null && !string.IsNullOrEmpty(responseContent))
                    {
                        launcherConfig = JsonConvert.DeserializeObject<LauncherConfig>(responseContent);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return launcherConfig;
        }

        public async Task<RefFileInfo> GetFileAsync(string fileRefUrl)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(fileRefUrl),
                Method = HttpMethod.Get,
            };

            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            s_httpClient = new HttpClient(_handler);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            s_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await s_httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);
            var content = await response.Content.ReadAsStringAsync();

            Serializer serializer = new Serializer();
            var fileDet = serializer.Deserialize<Models.xml.AppRefFile.entry>(content);

            return new RefFileInfo()
            {
                FileName = fileDet.content.properties.Name,
                FileSize = fileDet.content.properties.Length.Value,
                FileRelativeUrl = fileDet.content.properties.ServerRelativeUrl,
                Title = fileDet.content.properties.Title,
                IsAvailable = fileDet.content.properties.Exists.Value
            };
        }

        public async Task DownloadFileAsync(RefFileInfo refFileInfo, string targetPath)
        {
            s_httpClient = new HttpClient(_handler);
            var pp = Path.Combine(targetPath, refFileInfo.FileName);

            using (var s = await s_httpClient.GetStreamAsync(@"https://techupstream.petronas.com" + refFileInfo.FileRelativeUrl))
            {
                using (var fs = new FileStream(pp, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
            }
        }

        static TimeSpan GetTimeOut(int seconds)
        {
            DateTime now = DateTime.Now;
            return now.AddSeconds(seconds) - now;
        }
    }
}
