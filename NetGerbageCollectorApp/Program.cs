Console.WriteLine(GC.MaxGeneration);
/*
List<User> users = new List<User>();

for(int i = 0; i < 10; i++)
    users.Add(new User());

Console.WriteLine(GC.GetGeneration(users));

GC.Collect();

Console.WriteLine(GC.GetGeneration(users));

GC.Collect();

Console.WriteLine(GC.GetGeneration(users));
*/
//for(int i = 0; i < users.Count; i++)
//    users[i].Dispose();


using (User user = new User())
{
    Console.WriteLine($"{user.Name}");
}


class User :IDisposable
{
    public string Name { get; set; } = "Anonim";
    public int Age { get; set; } = 0;

    int[] array = new int[10000];

    public void Dispose()
    {
        Console.WriteLine("User dispose");
    }
}