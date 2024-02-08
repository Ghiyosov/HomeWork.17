



using Task._1;

var carModels = new Cache<string>();
carModels.Add("CLS");
carModels.Add("GLS");
carModels.Add("ML");
carModels.Add("SLS");
foreach (var item in carModels.Get())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("------------------------------");
carModels.Remove("ML");
foreach (var item in carModels.Get())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("********************************");
var id = new Cache<int>();
id.Add(1);
id.Add(4);
id.Add(3);
id.Add(7);
foreach (var item in id.Get())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("--------------------------");
id.Remove(3);
id.Remove(1);
foreach (var item in id.Get())
{
    System.Console.WriteLine(item);
}