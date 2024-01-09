namespace Colosoft.Models
{
    public record IdCode
    {
        public IdCode()
        {
        }

        public IdCode(int? id, string? code)
        {
            this.Id = id;
            this.Code = code;
        }

        public int? Id { get; set; }

        public string? Code { get; set; }
    }
}
