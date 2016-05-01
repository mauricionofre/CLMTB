using CLMTB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.ApplicationLayer.DTO
{
    public class CategoryDTO
    {
        public CategoryDTO()
        {
        }

        public CategoryDTO(Category category)
        {
            Id = category.Id;
            Name = category.Name;
            Description = category.Description;
            Type = category.Type;
        }

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Tipo")]
        public CategoryTypeEnum Type { get; set; }
    }
}