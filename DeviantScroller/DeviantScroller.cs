using System;
using System.Diagnostics;
using System.Security.Permissions;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DeviantScroller
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public partial class DeviantScroller : Form
    {
        private DeviantCaller deviantCaller = new DeviantCaller("CLIENT_ID", "CLIENT_SECRET"); // replace CLIENT_ID and CLIENT_SECRET
        private int gallerySize;
        private string folderID;
        private string username;

        private readonly Random _random = new Random();
        public DeviantScroller()
        {
            InitializeComponent();

        }

        private async void btnGO_Click_1(object sender, EventArgs e)
        {
            if (gallerySize == 0) return; // to prevent exceptions
            int offset = _random.Next(0, gallerySize - 1);
            Debug.WriteLine("Offset: " + offset);
            var temp = await deviantCaller.CollectionsFolderID(folderID, username, gallerySize, offset);
            JObject o = JObject.Parse(temp);

            // For whatever reason, the deviantart API sometimes doesn't return anything in the results. 
            // If this happens, try again until it finds something usable.
            while (!o["results"].HasValues)
            {
                offset = _random.Next(0, gallerySize - 1);
                temp = await deviantCaller.CollectionsFolderID(folderID, username, gallerySize, offset);
                o = JObject.Parse(temp);
            }
            string url = o["results"][0]["url"].ToString();
            string title = o["results"][0]["title"].ToString();
            string author = o["results"][0]["author"]["username"].ToString();
            try
            {
                ptbArt.ImageLocation = o["results"][0]["content"]["src"].ToString();
            }
            catch(NullReferenceException err)
            {
                // TODO give user an error
            }
            lnkDev.Text = url;
            lbl_deviation_info.Text = "Title: " + title + "\nDeviant: " + author + "\nPosition in Gallery: " + offset;
            
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
        {
            lstGalleries.Items.Clear();

            username = txtUserName.Text;
            JObject o = JObject.Parse(await deviantCaller.CollectionsFolders(username));
            foreach(var x in o["results"])
            {
                string tempName = x["name"].ToString();
                string tempID = x["folderid"].ToString();
                int tempSize = int.Parse(x["size"].ToString());
                lstGalleries.Items.Add(new DeviantGallery(tempName, tempID, tempSize));
            }
            gallerySize = int.Parse(o["results"][0]["size"].ToString());
            folderID = o["results"][0]["folderid"].ToString();
            Debug.WriteLine(folderID);
        }

        private void lstGalleries_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviantGallery temp = (DeviantGallery)lstGalleries.SelectedItem;
            gallerySize = temp.GetSize();
            folderID = temp.GetFolderID();
        }

   
    }
}