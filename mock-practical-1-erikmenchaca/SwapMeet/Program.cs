// Business name is below
const string BUSINESS_NAME = "Disks4Cheap";

//Console.Title is below
Console.Title = BUSINESS_NAME;
const double DISK_COST = 25.75;
System.Console.Write("How many disks are in the current inventory? --> ");

if (int.TryParse(Console.ReadLine(), out int currentNumOfDisksInInventory) && currentNumOfDisksInInventory > 0)
{
    string[] menu = { "Display current inventory value", "Buy disks to from Disks4Cheap", "Sell disks to Disks4Cheap", "Exit" };

    for (int i = 0; i < menu.Length; i++)
    {
        System.Console.WriteLine($"{i + 1}. {menu[i]}");
    }
    const int DISPLAY = 1;
    const int BUY = 2;
    const int SELL = 3;
    const int EXIT = 4;
    System.Console.Write("Enter an option (1-4): ");
    int menuOption = int.Parse(Console.ReadLine());
    switch (menuOption)
    {
        case DISPLAY:
            double totalValue = currentNumOfDisksInInventory * DISK_COST;
            System.Console.WriteLine($"Your current number of disks and the total value in the inventory is: --> {currentNumOfDisksInInventory} and {totalValue:C}, respectively.");
            break;

        case BUY:
            System.Console.Write("How many disks would you like to buy? --> ");
            int disksToBuy = int.Parse(Console.ReadLine());

            if (disksToBuy < currentNumOfDisksInInventory)
            {
                int addDisksToInventory = currentNumOfDisksInInventory - disksToBuy;
                double totalCostAfterBuying = addDisksToInventory * DISK_COST;
                System.Console.WriteLine($"Inventory Count: {addDisksToInventory}\nDisks Inventory Value: {totalCostAfterBuying:C}");
            }

            break;

        case SELL:
System.Console.Write("How many disks would you like to sell? --> ");
            int disksToSell = int.Parse(Console.ReadLine());

            if (disksToSell >0)
            {
             int numOfDisksAfterSelling = currentNumOfDisksInInventory+disksToSell;
             double totalCostAfterSelling = numOfDisksAfterSelling*DISK_COST;
             System.Console.WriteLine($"Inventory Count: {numOfDisksAfterSelling}\nDisks Inventory Value: {totalCostAfterSelling:C}");
            }
            else {
                 System.Console.WriteLine("Invalid number of disks to sell.");
            }

            break;

        case EXIT:

            break;
        default:
            System.Console.WriteLine("Invalid menu option. Try again.");
            break;
    }
}
else
{
    System.Console.WriteLine("Invalid input of number of disks in the current inventory");
}


