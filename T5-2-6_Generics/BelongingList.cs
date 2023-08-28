using System;
using T5_2_5_Interfaces;

namespace T5_2_6_Generics;

/// <summary>
/// A list of items of type <see cref="IBelonging"/>.
/// </summary>
/// <typeparam name="T"></typeparam>
public class BelongingList<T> : List<T>
    where T : IBelonging
{
    public BelongingList()
    {
    }


    /// <summary>
    /// Returns the number of indoor items.
    /// </summary>
    /// <returns></returns>
    public int IndoorItemCount()
    {
        return IndoorItems().Count();
    }


    /// <summary>
    /// Returns the number of indoor items.
    /// </summary>
    /// <returns></returns>
    public IEnumerable<IIndoorItem> IndoorItems()
    {
        return this.Where(x => x is IIndoorItem).Cast<IIndoorItem>();
    }
}

