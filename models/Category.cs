namespace PokemonReviewApp.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}