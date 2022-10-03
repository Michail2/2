int quarter(int arg1)
{
int b = arg1;
int c = 0;
while(Convert.ToBoolean(b)) 
{
    
   int r = b % 10;   
   c = c * 10 + r;
   b = b / 10;  
}
if (arg1 == c)
{
    Console.WriteLine("Число является пaлиндромом");
   
}
else 
{
  Console.WriteLine("Число не является пaлиндромом");  
} 
return 0; 
}

int a = Convert.ToInt32(Console.ReadLine());
quarter(a);
