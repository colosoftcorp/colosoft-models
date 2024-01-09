namespace Colosoft.Models
{
    public record class IdName
    {
        public IdName()
        {
        }

        public IdName(int? id, string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int? Id { get; set; }

        public string? Name { get; set; }
    }
}
