using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class FreeTier
{
    public int IdApiKey { get; set; }

    public int Gem25Pro { get; set; }

    public int Gem25Flash { get; set; }

    public int Gem25FlashLite { get; set; }

    public int Gem20Flash { get; set; }

    public int Gem20FlashLite { get; set; }

    public virtual ApiKeyIum IdApiKeyNavigation { get; set; } = null!;
}
