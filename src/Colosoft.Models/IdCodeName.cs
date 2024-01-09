namespace Colosoft.Models
{
    public record IdCodeName
    {
        public IdCodeName()
        {
        }

        public IdCodeName(int? id, string? code, string? name)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
        }

        public int? Id { get; set; }

        public string? Code { get; set; }

        public string? Name { get; set; }
    }
}
