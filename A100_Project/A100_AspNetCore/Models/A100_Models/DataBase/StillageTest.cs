using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class StillageTest
    {
        public int StillageTestId { get; set; }
        public int ResoultId { get; set; }
        public int SpecificationsId { get; set; }
        public int MapId { get; set; }
        public int StoikaElementId { get; set; }
        public int LoadElementId { get; set; }
        public int FrameElementId { get; set; }
        public string Row { get; set; }
        public string Frame { get; set; }
        public byte? LevelCount { get; set; }
        public DateTime? StillageTestDate { get; set; }
        public byte ProtokolNumber { get; set; }
        public bool IsLoaded { get; set; }
        public int? MaxPassportLoad { get; set; }
        public int? UsualLoad { get; set; }
        public int? TestLoad { get; set; }
        public double? FuprFact { get; set; }
        public double? FostFast { get; set; }
        public double? DevLoadFact { get; set; }
        public double? F1fact { get; set; }
        public double? FkFact { get; set; }
        public int EmployeeId { get; set; }
        public int? TransformRow { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual SpecificationsElement FrameElement { get; set; }
        public virtual SpecificationsElement LoadElement { get; set; }
        public virtual Map Map { get; set; }
        public virtual Resoult Resoult { get; set; }
        public virtual Specifications Specifications { get; set; }
        public virtual SpecificationsElement StoikaElement { get; set; }
    }
}
