namespace StorageLib.Models
{
    public class Item
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
        public int Id { get; set; }
        public int NumAvailable {  get; set; }

        public string? Display
        {
            get
            {
                return ToString();
            }
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} - ${Price} - {NumAvailable} Available";
        }
    }
}
