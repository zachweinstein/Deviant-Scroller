namespace DeviantScroller
{
    internal class DeviantGallery
    {
        private string name;
        private string folderID;
        private int size;
        public DeviantGallery(string name, string folderID, int size)
        {
            this.name = name;
            this.folderID = folderID;
            this.size = size;
        }



        public override string ToString() { return name + " (" + size + ")"; }

        public string GetName() { return name; }
        public string GetFolderID() { return folderID; }
        public int GetSize() { return size; }
    }

}