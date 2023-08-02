namespace EfCore.Models.Entities
{
    public class OrderDetails:BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        //Relational Properties

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
