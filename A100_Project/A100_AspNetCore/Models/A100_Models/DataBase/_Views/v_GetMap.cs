using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A100_AspNetCore.Models.A100_Models.DataBase._Views
{
    public partial class v_GetMap
    {
        public int MapID { get; set; }

        public int? cIndex { get; set; }

        public decimal? X { get; set; }

        public decimal? Y { get; set; }

        public decimal? Width { get; set; }

        public decimal? Height { get; set; }

        public string Row { get; set; }

        public int? Frame { get; set; }

        public int? Rotation { get; set; }

        public int? Iteration { get; set; }

        public string MapUnit { get; set; }

        public int SpecificationsID { get; set; }

        public int? WarhouseID { get; set; }

        public string сLevel { get; set; }

        public int? TransformRow { get; set; }

        public int ResoultID { get; set; }

        public string FrameString { get; set; }

        public byte? ShowMode { get; set; }
    }
}
