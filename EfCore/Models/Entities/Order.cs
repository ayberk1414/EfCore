namespace EfCore.Models.Entities
{
    public class Order : BaseEntity
    {
        public string ShippedAddress { get; set; }
        public int? AppUserID { get; set; }//Relational Properties

        public virtual AppUserProfile AppUser { get; set; }
    }
}
