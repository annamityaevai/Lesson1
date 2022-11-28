Console.WriteLine("Insert number");
int a = Convert.ToInt32(Console.ReadLine());

int x = 0 - a;
int y = a;
int z = 0 - a;

while(z <= y)
{
    Console.Write(z );
    z = z + 1;
}