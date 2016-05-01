using CLMTB.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Domain.Entities
{
    public class Stage : Entity
    {
        public int Sequential { get; set; }
        public string Name { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public StageTypeEnum StageType { get; set; }
        public byte[] GpxFile { get; set; }
    }

    public enum StageTypeEnum
    {
        Marathon = 0,
        Circuit = 1
    }
}