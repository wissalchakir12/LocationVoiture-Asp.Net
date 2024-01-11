namespace DAL.Entity
{
    public class Categorie
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }= string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}