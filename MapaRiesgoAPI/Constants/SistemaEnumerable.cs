using Microsoft.EntityFrameworkCore;

namespace ElectronicDataInterchange.API.Constants
{
    public static class SistemaEnumerable
    {
        public static string JwtSecret = "mantenimientojwtsecret";

        public enum Sistema {
            LISTMS = 1,
            ZAM = 2,
            TALLER = 3,
        }

    }
}
