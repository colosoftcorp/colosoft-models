﻿namespace Colosoft.Models
{
    public record IdNameDescription
    {
        public IdNameDescription()
        {
        }

        public IdNameDescription(int? id, string? name, string? description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
