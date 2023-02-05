//modulus, symbol: %

int a = 24;
int b = 8;
int c = b % a; //8. 8 cant be divided into 24 parts. All is kept as it is.
Console.WriteLine(c);

int d = a % b; //0. 24 can be divided with 8. No modulus left.
Console.WriteLine(d);

a = 23;
int e = a % b; //7. 8 * 2 = 16; 23 - 16 = 7
Console.WriteLine(e);

