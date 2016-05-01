using CLMTB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.ApplicationLayer.DTO
{
    public class StageDTO
    {
        public StageDTO()
        {
        }

        public StageDTO(Stage stage)
        {
            Id = stage.Id;
            Name = stage.Name;
            Sequential = stage.Sequential;
            InitialDate = stage.InitialDate;
            FinalDate = stage.FinalDate;
            GpxFile = stage.GpxFile;
            StageType = stage.StageType;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Sequential { get; set; }

        public DateTime InitialDate { get; set; }

        public byte[] GpxFile { get; set; }

        public DateTime FinalDate { get; set; }

        public StageTypeEnum StageType { get; set; }
    }
}