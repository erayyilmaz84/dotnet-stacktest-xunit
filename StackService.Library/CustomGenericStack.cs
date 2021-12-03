using System.Collections.Generic;

namespace StackService.Library;

public class CustomGenericStack<T>
{
    private List<T> items = new List<T>();

    public CustomGenericStack<T> push(T item)
    {
        items.Add(item);
        return this;
    }

    public T pop()
    {
        if (items.Count == 0)
            return default(T);

        var item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

}
