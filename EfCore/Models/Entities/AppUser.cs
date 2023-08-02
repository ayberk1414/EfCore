namespace EfCore.Models.Entities
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual AppUserProfile Profile { get; set; }
    }
}
