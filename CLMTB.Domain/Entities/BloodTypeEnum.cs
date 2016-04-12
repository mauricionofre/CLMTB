using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Domain.Entities
{
    public enum BloodTypeEnum
    {
        [Description("O-")]
        ONeg,

        [Description("O+")]
        OPos,

        [Description("A-")]
        ANeg,

        [Description("A+")]
        APos,

        [Description("B-")]
        BNeg,

        [Description("B+")]
        BPos,

        [Description("AB-")]
        ABNeg,

        [Description("AB+")]
        ABPos
    }
}