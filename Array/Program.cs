int[] value = { 1, 3, 5, 2, 4, 0 };
string[] abbrev = { "CPU", "RAM", "HDD", "USB", "VGA", "DVI" };
//foreach (int i in value)
//{
//    Console.WriteLine(value[i]);
//}

for (int i = 0; i < value.Length; i++)
{
    Console.WriteLine(abbrev[value[i]]);
}
Console.ReadLine();