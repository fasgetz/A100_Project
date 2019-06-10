using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Vik
    {
        public int VikId { get; set; }
        public int Frame { get; set; }
        public int? StructuralMemberId { get; set; }
        public int? DefectId { get; set; }
        public int? RiskLevelId { get; set; }
        public int? States { get; set; }
        public string CComment { get; set; }
        public decimal? MX { get; set; }
        public decimal? MY { get; set; }
        public decimal? MRotation { get; set; }
        public int? SpecificationsElementId { get; set; }
        public int? TransformRow { get; set; }
        public string ElementOrientation { get; set; }
        public byte[] DamagePhoto { get; set; }
        public int? MScale { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Row { get; set; }
        public string NLevel { get; set; }
        public string FrameRange { get; set; }
        public int? PartialToid { get; set; }
        public byte? ShowMode { get; set; }
        public int? OriginalVikId { get; set; }
        public int? UniqueId { get; set; }
        public byte? Otkmark { get; set; }

        public virtual DefectType Defect { get; set; }
        public virtual PartialTo PartialTo { get; set; }
        public virtual RiskLevel RiskLevel { get; set; }
        public virtual SpecificationsElement SpecificationsElement { get; set; }
        public virtual VikElement StructuralMember { get; set; }
    }
}
