using System.Data;

namespace Sharplist
{
    public interface IDatabaseConnection
    {
        IDbConnection Connect();
    }
}