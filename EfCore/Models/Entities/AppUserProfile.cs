namespace EfCore.Models.Entities
{
    public class AppUserProfile:BaseEntity
    {
        
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        //Relational Propertiesip
        public virtual AppUser AppUser { get; set; }
    }
}
