namespace Task._1;

public  class Cache<T>
{
    List<T> spisok = new List<T>();
    public void Add(T feild)
    {
        spisok.Add(feild);
    }
    public List<T> Get()
    {
        return spisok;
    }
    public void Remove(T feild)
    {
        spisok.Remove(feild);
    }
}
