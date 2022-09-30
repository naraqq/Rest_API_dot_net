namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int id { get; set; }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonOwner> PokemonCategories { get; set; }
    }
}