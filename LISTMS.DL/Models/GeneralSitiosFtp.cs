using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GeneralSitiosFtp
{
    public int IdFtp { get; set; }

    public int IdEmpresa { get; set; }

    public string FtpNombre { get; set; } = null!;

    public string FtpRuta { get; set; } = null!;

    public string FtpUser { get; set; } = null!;

    public string FtpPass { get; set; } = null!;

    public string FtpServer { get; set; } = null!;

    public string FtpPuerto { get; set; } = null!;
}
