using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Profiling
{
    public short Spid { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }
}
