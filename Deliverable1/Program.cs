

int totalSoda = 100;
int soldSoda = 0;
int totalChips = 40;
int soldChips = 0;
int totalCandy = 60;
int soldCandy = 0;

Console.WriteLine("Welcome to restocking tool.");
Console.WriteLine("How many sodas have been sold today?"+" "+totalSoda + " "+"are in stock" );

string? inputSoda = Console.ReadLine();        //input could be null

if (int.TryParse(inputSoda, out soldSoda) && soldSoda >=0) // Check for non negative input, and integer
{
    if (totalSoda > soldSoda)
    {
        totalSoda -= soldSoda;
        Console.WriteLine("There are " + totalSoda + " Sodas left");
    }
    else
    {
        Console.WriteLine("That value is too high.Stock not adjusted");
    }
}
else
{
    Console.WriteLine("Enter a Valid input ");
}

Console.WriteLine("How many Chips have been sold today?" + " " + totalChips +" "+ "are in stock");
string? inputChips = Console.ReadLine();
if (int.TryParse(inputChips, out soldChips) && soldChips >= 0)
{

    if (totalChips > soldChips)
    {
        totalChips -= soldChips;
        Console.WriteLine("There are " + totalChips + " Chips left");
    }
    else
    {
        Console.WriteLine("That value is too high.Stock not adjusted");
    }
}
else
{
    Console.WriteLine("Enter a Valid input ");
}
Console.WriteLine("How many Candy have been sold today?" + " " + totalCandy +" "+ "are in stock");
string? inputCandy = Console.ReadLine();
if (int.TryParse(inputCandy, out soldCandy))
{

    if (totalCandy > soldCandy)
    {
        totalCandy -= soldCandy;
        Console.WriteLine("There are " + totalCandy + " " + "candy left");
    }
    else
    {
        Console.WriteLine("That value is too high.Stock not adjusted");
    }
}
else
{
    Console.WriteLine("Enter a Valid input ");
}
Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

bool needRestocking = false;
if (totalSoda <= 40)
{
    Console.WriteLine("Soda needs to be restocked");
    needRestocking = true;

}
if (totalChips <= 20)
{
    Console.WriteLine("Chips needs to be restocked");
    needRestocking = true;
}
if (totalCandy <= 40)
{
    Console.WriteLine("Candy needs to be restocked");
    needRestocking = true;
}

if(!needRestocking)
{
    Console.WriteLine("No Need to Restock");

}
Console.WriteLine("GOOD BYE!!");