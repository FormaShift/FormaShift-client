
using System.Collections.Immutable;

namespace FormaShift.UI.Components;

public interface IDrawFolder
{
    int TotalPairs { get; }
    int OnlinePairs { get; }
    IImmutableList<DrawUserPair> DrawPairs { get; }
    void Draw();
}
