namespace DeltaMaths.Benchmarks;

internal sealed class DeterministicRandom
{
    private uint state;

    public DeterministicRandom(int seed)
    {
        state = unchecked((uint)seed);
        if (state == 0)
        {
            state = 0x9E3779B9u;
        }
    }

    public int Next(int minValue, int maxValue)
    {
        if (minValue >= maxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(maxValue), "The maximum must be greater than the minimum.");
        }

        var range = (uint)(maxValue - minValue);
        return minValue + (int)(NextUInt() % range);
    }

    public float NextSingle() => (NextUInt() >> 8) * (1f / 16777216f);

    private uint NextUInt()
    {
        var value = state;
        value ^= value << 13;
        value ^= value >> 17;
        value ^= value << 5;
        state = value;
        return value;
    }
}
