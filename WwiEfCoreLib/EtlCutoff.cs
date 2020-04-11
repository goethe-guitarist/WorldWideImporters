using System;
using System.Collections.Generic;

namespace WwiEfCoreLib
{
    public partial class EtlCutoff
    {
        public string TableName { get; set; }
        public DateTime CutoffTime { get; set; }
    }
}
