namespace StackService.Library;
public class CustomStack
{
    private object[] items;
    private int currentIndex;

    public CustomStack(int capacity)
    {
        this.items = new object[capacity];
        this.currentIndex = 0;
    }

    public void push(object item)
    {
        if (item == null)
            throw new Exception("item can not be null !");

        if(currentIndex >= items.Length)
            throw new Exception("stack maximum size exceeded !");

        items[currentIndex] = item;
        currentIndex++;

    }

    public object pop()
    {
        if (currentIndex == 0)
            return null;
        object item = items[currentIndex - 1];
        currentIndex--;
        return item;
    }

}
