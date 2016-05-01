using CLMTB.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public CategoryTypeEnum Type { get; set; }
    }

    public enum CategoryTypeEnum
    {
        [Description("Idade")]
        Age = 0,

        [Description("Livre")]
        Independent = 1,

        [Description("Citadino")]
        Townsman = 2
    }
}