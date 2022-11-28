Console.WriteLine("Insert a three digit number");
int a = Convert.ToInt32(Console.ReadLine());
if ((1000 > a) && (a > 99)){
    Console.WriteLine("Last digit is " + a%10);
}
else
{
    Console.WriteLine("Error. Please insert a three digit number!");
}