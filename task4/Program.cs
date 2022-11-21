int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());
int max = a;
if (a<b)
{
    max=b;
}
else
{
    max=a;
}
if(max<c)
{
    max=c;
}
Console.WriteLine(max);