using System;
using System.Collections.Generic;
using CromulentBisgetti.ContainerPacking.Entities;

namespace CromulentBisgetti.ContainerPacking.Helpers;

public class ContainerDimensionEqualityComparer : IEqualityComparer<Container>
{
    public bool Equals(Container x, Container y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null || y is null) return false;

        return x.Length == y.Length && x.Width == y.Width && x.Height == y.Height;
    }

    public int GetHashCode(Container obj)
    {
        return HashCode.Combine(obj.Length, obj.Width, obj.Height);
    }
}
