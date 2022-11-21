int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int max=a;
int min=b;
if(a<b){
    max=b;
    min=a;
}
else{
    max=a;
    min=b;
}
Console.WriteLine($"Min = '{min}'");
Console.WriteLine($"Max = '{max}'");