namespace WebNet.Domain
{
    public class Entity
    {
        public Entity() 
        { 
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditBy { get; set; }
        public DateTime EditOn { get; set; }
    }
}
