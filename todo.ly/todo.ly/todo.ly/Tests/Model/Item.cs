namespace Todo.Ly.Tests.Model
{
    public class Item
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string ItemType { get; set; }
        public string Checked { get; set; }
        public string ProjectId { get; set; }
        public string ParentId { get; set; }

        private static Item instance;
        private Item()
        { }

        public static Item Instance => instance ??= new Item();
    }
}
