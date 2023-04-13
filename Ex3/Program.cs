Console.WriteLine("Bagel Prices");
Console.WriteLine("Bagel            | Price ");
Console.WriteLine("---------------------");
Console.WriteLine("Plain (P)        | 7.50  ");
Console.WriteLine("Whole Wheat (W)  | 9.25 ");
Console.WriteLine("Raisin (R)       | 10.50 ");
Console.WriteLine();

// Output the filling prices
Console.WriteLine("Filling Additional cost ");
Console.WriteLine("Filling          | Price ");
Console.WriteLine("--------------------------");
Console.WriteLine("Cream cheese (C) | 1.50  ");
Console.WriteLine("Salad (S)        | 3.25  ");
Bagel bagel = new Bagel();
Filling filling = new Filling();

// Prompt the user to enter their order
Console.WriteLine("Welcome to the Bagel Deli!");
Console.WriteLine("Please enter what Bagel you want to order' (P, W or R):");
string order = Console.ReadLine().ToUpper();

// Parse the user's order
char bagelType = order[0];


// Calculate the subtotal and VAT
double subtotal = 0.0;

if (bagelType == 'P')
{
    subtotal += bagel.PLAIN_BAGEL_PRICE;
    Extras();
}
if (bagelType == 'W')
{
    subtotal += bagel.WHOLE_WHEAT_BAGEL_PRICE;
    Extras();
}
if (bagelType == 'R')
{
    subtotal += bagel.RAISIN_BAGEL_PRICE;
    Extras();
}
else
{
    Console.WriteLine("Invalid bagel type.");
  
}
//switch (bagelType)
//{
//    case 'P':
//        subtotal += bagel.PLAIN_BAGEL_PRICE;
//        Extras();
//        break;
//    case 'W':
//        subtotal += bagel.WHOLE_WHEAT_BAGEL_PRICE;
//        Extras();
//        break;
//    case 'R':
//        subtotal += bagel.RAISIN_BAGEL_PRICE;
//        Extras();
//        break;
//    default:
//        Console.WriteLine("Invalid bagel type.");
//        return;
//}
void Extras()
{
    Console.WriteLine("Would you like to add cream cheese? (Y/N)");
    string hasCreamCheese = Console.ReadLine().ToUpper();
    if (hasCreamCheese == "Y")
    {
        subtotal += filling.CREAM_CHEESE_PRICE;
    }

    Console.WriteLine("Would you like to add salad? (Y/N)");
    string hasSalad = Console.ReadLine().ToUpper();
    if (hasSalad == "Y")
    {
        subtotal += filling.SALAD_PRICE;
    }
}

double vat = subtotal * filling.VAT_RATE;
double total = subtotal + vat;

// Display the total amount due
Console.WriteLine("Subtotal: {0:C}", subtotal);
Console.WriteLine("VAT ({0:P}): {1:C}", filling.VAT_RATE, vat);
Console.WriteLine("Total: {0:C}", total);
  
    class Bagel
{
    public double PLAIN_BAGEL_PRICE = 7.50;
    public double WHOLE_WHEAT_BAGEL_PRICE = 9.25;
    public double RAISIN_BAGEL_PRICE = 10.50;
}

class Filling
{
    public double CREAM_CHEESE_PRICE = 1.50;
    public double SALAD_PRICE = 3.25;
    public double VAT_RATE = 0.14;
}