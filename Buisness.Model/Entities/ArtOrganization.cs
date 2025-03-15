
namespace Buisness.Model.Entities
{
    public class ArtOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }

        public virtual ICollection<User>? Users { get; set; }
    }
}
