public static class CreateList
{


    public static List<T> Make<T>() where T : class, new()
    {

        List<T> list = new List<T>();

        for (int i = 0; i < 10; i++)
        {

            T newobj = new T();

            list.Add(newobj);
        }

        return list;

    }

}