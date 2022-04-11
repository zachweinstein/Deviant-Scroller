using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

// Thanks to https://curl.olsh.me/ for the help with curl conversions

namespace DeviantScroller
{
    internal class DeviantCaller
    {
		private string access_token;
		private string client_id;
		private string client_secret;

		private static HttpClient client = new HttpClient();
		
		public DeviantCaller(string client_id, string client_secret)
        {
			this.client_id = client_id;
			this.client_secret = client_secret;
			InitAccess();
        }

		// This runs so that the access token can be assigned at the time of creation
		private async void InitAccess()
		{
			string data = await GrabNewAccessToken(client_id, client_secret);
            access_token = (string)JObject.Parse(data)["access_token"];

		}

		// Grab an access token. They last an hour.
		private async static Task<string> GrabNewAccessToken(string client_id, string client_secret)
        {
			using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://www.deviantart.com/oauth2/token?client_id=" + client_id + "&client_secret=" + client_secret + "&grant_type=client_credentials"))
			{
				var response = await client.SendAsync(request);
				Debug.WriteLine(await response.Content.ReadAsStringAsync());
				return await response.Content.ReadAsStringAsync();
			}
		}

		public async Task<string> CollectionsFolders(string username)
        {
			using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://www.deviantart.com/api/v1/oauth2/collections/folders?access_token=" + access_token + "&username=" + username + "&calculate_size=true"))
			{
				var response = await client.SendAsync(request);
				return await response.Content.ReadAsStringAsync();
			}
		}

		public async Task<string> CollectionsFolderID(string folderid, string username, int gallerySize, int offset)
        {
			int pages = gallerySize / 10;
			using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://www.deviantart.com/api/v1/oauth2/collections/" + folderid + "?offset=" + offset + "&limit=1&mature_content=true&access_token=" + access_token + "&username=" + username))
            {
				var response = await client.SendAsync(request);
				
				return await response.Content.ReadAsStringAsync();
            }
        }

		public string GetAccessToken() { return access_token; }
		public void SetAccessToken(string access_token) { this.access_token = access_token; }

	}
}