namespace Colosoft.Models
{
    public record CodeName
    {
        public CodeName()
        {
        }

        public CodeName(string? code, string? name)
        {
            this.Code = code;
            this.Name = name;
        }

        public string? Code { get; set; }

        public string? Name { get; set; }
    }
}
