using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Map
    {
        public Map()
        {
            StillageTest = new HashSet<StillageTest>();
        }

        public int MapId { get; set; }
        public int? CIndex { get; set; }
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public int? Frame { get; set; }
        public int? Rotation { get; set; }
        public int? Iteration { get; set; }
        public string MapUnit { get; set; }
        public int SpecificationsId { get; set; }
        public string СLevel { get; set; }
        public int? TransformRow { get; set; }
        public int? EmployeeId { get; set; }
        public string Row { get; set; }
        public string FrameString { get; set; }
        public byte? ShowMode { get; set; }

        public virtual Specifications Specifications { get; set; }
        public virtual ICollection<StillageTest> StillageTest { get; set; }
    }
}
