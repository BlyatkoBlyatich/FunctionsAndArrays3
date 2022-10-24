bool PalindCheck(int number)
{
int n = number;
int res = 0;

while(n>0)
{
    int r = n % 10;
    res = res * 10 + r;
    n = n / 10;
}
if(number == res)
{
return true;  
}
else
{
    return false;
}

}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

if(PalindCheck(num))
    {
        Console.WriteLine("Its palindrome");
    }
else
    {
        Console.WriteLine("Isn't palindrome");
    }

