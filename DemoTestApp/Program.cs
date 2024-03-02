// See https://aka.ms/new-console-template for more information
using DemoTestApp;

//Singleton Pattern 

string className = Singleton.SingletonProp.GetClassName();

//Bridge Pattern 

Bridge bridge = new Bridge(new Tata());
var isValid = bridge.IsValidDriver(34);
bridge.GetCars();

//Adapter Pattern
Adaptee adaptee = new();
ITarget adapter = new Adapter(adaptee);
adapter.Request();


//Decorator Pattern
IComponent component = new Component();
string mainOperation = component.Operation();
IComponent decorateComponentA = new Decorator_A();
string decorateA_obj = decorateComponentA.Operation();


string input = "()[]{}";
char[] inputArray = input.ToCharArray();
Dictionary<char, int> inputType = new();
inputType.Add(')', 0);
inputType.Add('}', 0);
inputType.Add(']', 0);



for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i] == '(')
    {
        inputType[')']--;
    }
    if (inputArray[i] == ')')
    {
        inputType[')']++;
    }
    if(inputArray[i] == '{')
    {
        inputType['}']--;
    }
    if(inputArray[i] == '}')
    {
        inputType['}']++;
    }
    if(inputArray[i] == '[')
    {
        inputType[']']--;
    }
    if(inputArray[i] == ']')
    {
        inputType[']']++;
    }

}

bool isClose = inputType.All(x=>x.Value==0);

string a = "Suvam Chanda";

string output = string.Empty;

for (int i = a.Length - 1 ; i >= 0; i--)
{
    output += a[i];
}
string b = String.Copy(a);
string c = "Suvam Chanda";
Console.WriteLine(a==b);
Console.WriteLine((object)a==(object)b);
Console.WriteLine((object)a == (object)c);



Console.WriteLine("Hello, World!");

int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };



int MaxProfit = 0;


int left = 0;
int right = 1; 

while(right < prices.Length)
{
    if(prices[right] > prices[left])
    {
        int profit = prices[right] - prices[left] ;
        if (profit > MaxProfit)
        {
            MaxProfit = profit ;
        }
    }
    else
    {
        left++;
    }
    right++;
}


for (int i = 0; i < prices.Length; i++)
{
    for (int j = i; j< prices.Length; j++)
    {
        if(prices[j] > prices[i])
        {
            int profit = prices[j] - prices[i]; 
            if(profit > MaxProfit)
            {
                MaxProfit = profit;
            }
        }
    }
}

Console.WriteLine(MaxProfit);
int number = 121;
int result = 0;
int rem;
bool IsPrime = true;



while (number != 0)
{
    // To find the last digit
    rem = number % 10; 
    result = result * 10 + rem;
    number /= 10;
}


for(int i = 2; i < result / 2; i++)
{
    if(result%i == 0)
    {
        Console.WriteLine(i);
        IsPrime = false;
        break;
    }
}

Console.WriteLine(result);


static void Display(int a = 10)
{
    Console.WriteLine(a);
}

static int FibNumber(int a)
{
    if (a == 1)
    {
        return 0;
    }
    if(a == 2 || a == 3)
    {
        return 1;
    }
    else
    {
        return FibNumber(a-1) + FibNumber(a-2);
    }
}
