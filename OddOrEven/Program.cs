Console.WriteLine("Enter a number:");

int userNum = Convert.ToInt32(Console.ReadLine());
int result = userNum % 2;

//% modulus is not 0
if (result != 0)
{
    Console.WriteLine("User number is odd.");
}
//% modulus = 0
else
{
    Console.WriteLine("User number is even.");
}
