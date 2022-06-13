
using System.Text;
public static class GenericSaveAndReadFromFile
{

    public static void SaveDataToFile<T>(string stringPath, List<T> data) where T : class, new()
    {

        StringBuilder header = new StringBuilder();

        T newT = new T();
        var properties = newT.GetType().GetProperties();

        foreach (var p in properties)
        {
            header.Append(p.Name);
            header.Append(",");
        }
        header.Remove(header.Length - 1, 1);

        List<string> dataToAdd = new List<string>();
        dataToAdd.Add(header.ToString());

        foreach (var d in data)
        {
            StringBuilder line = new StringBuilder();
            foreach (var p in properties)
            {
                line.Append(d.GetType().GetProperty(p.Name).GetValue(d));
                line.Append(",");
            }
            line.Remove(line.Length - 1, 1);
            dataToAdd.Add(line.ToString());
        }

        File.WriteAllLines(stringPath, dataToAdd);


    }

    public static void ReadDataFromFile<T>(string stringPath) where T : class, new()
    {

        T newT = new T();
        var properties = newT.GetType().GetProperties();
        var data = File.ReadAllLines(stringPath).ToList();

        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }


}


//     foreach (var item in data)
//     {
//         var arrayOfItem = item.Split(",");
// var counter = 0;
//         foreach (var item2 in properties)
//         {
//             Console.WriteLine(item2.Name + "=" + arrayOfItem[counter]);
//             counter += 1;
//         }
//     }
// StringBuilder header = new StringBuilder();

// T newT = new T();
// var properties = newT.GetType().GetProperties();

// foreach (var p in properties)
// {
//     header.Append(p.Name);
//     header.Append(",");
// }
// header.Remove(header.Length - 1, 1);

// List<string> dataToAdd = new List<string>();
// dataToAdd.Add(header.ToString());

// foreach (var d in data)
// {
//     StringBuilder line = new StringBuilder();
//     foreach (var p in properties)
//     {
//         line.Append(d.GetType().GetProperty(p.Name).GetValue(d));
//         line.Append(",");
//     }
//     line.Remove(line.Length - 1, 1);
//     dataToAdd.Add(line.ToString());
// }

// File.WriteAllLines(stringPath, dataToAdd);










