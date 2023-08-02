namespace EfCore.Models.Entities
{
    public class Category:BaseEntity
    {
        public string categoryName
        {
            get; set;
        }
public string Description { get; set; }
        //Relational Properties

        public virtual List<Product> Products { get; set; }
}
}
