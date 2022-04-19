/**       
 *--------------------------------------------------------------------
 * 	   File name: ShowCharacter.cs
 * 	Project name: Lab 6
 *--------------------------------------------------------------------
 * Author’s name and email:	 Callie Wright Wrightcj1@etsu.edu			
 *          Course-Section: 001
 *           Creation Date:	04/19/2022
 * -------------------------------------------------------------------
 */
ShowCharacter("New York",8);

for(int i = 80; i <= 100; i++)
{
System.Console.WriteLine(Celsius(i));
}

System.Console.WriteLine(CalculateRetail());


Console.WriteLine("Accept number:");
var number = Convert.ToInt32(Console.ReadLine());

if (IsPrime(number))
{
    Console.WriteLine("It is prime");
}
else
{
    Console.WriteLine("It is not prime");
}     

static void ShowCharacter(string word, int place)
{
    if(place > word.Length)
    {
        System.Console.WriteLine("The place you are looking for does not exist!");
    }
    else if(place <= 0)
    {
        System.Console.WriteLine("That does not make senese");
    }
    else
    {
        System.Console.WriteLine(word[place -1]);
    }
}

static double CalculateRetail()
{
Console.Write("Enter the wholesale cost: ");
double cost = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the markup percentage: ");
double mp = Convert.ToDouble(Console.ReadLine())/100.0;

return(cost + (cost * mp));

}

static double Celsius(int f)
{
  return ((5.0/9.0) * (f - 32.0));
}
  
static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));
          
    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;
    
    return true;        
}