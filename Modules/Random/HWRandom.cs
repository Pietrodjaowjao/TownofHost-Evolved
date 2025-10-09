using System.Security.Cryptography;

namespace TOHE;

public class HWRandom : IRandom
{
    public int Next(int minValue, int maxValue) => RandomNumberGenerator.GetInt32(minValue, maxValue);
    public int Next(int maxValue) => RandomNumberGenerator.GetInt32(maxValue);
    public int Next() => RandomNumberGenerator.GetInt32(int.MaxValue);
}
