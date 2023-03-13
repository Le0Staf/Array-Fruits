
Console.WriteLine("Fruit Choices:");
Console.WriteLine("1. Orange");
Console.WriteLine("2. Strawberry");
Console.WriteLine("3. Pear");
Console.WriteLine("4. Apple");

PickingFruit();
static void PickingFruit()
{
    Console.WriteLine("Chose a fruit: ");

    double fruit = Convert.ToDouble(Console.ReadLine());
    string PickFruit;

    if (fruit == 1)
    {
        Console.WriteLine("You chose Orange \n");
        Console.WriteLine("Want to chose another fruit?");
        PickFruit = Console.ReadLine();
        if (PickFruit == "yes")  
        {
            PickingFruit();
        }
        if (PickFruit == "no")
        {
            Environment.Exit(0);
        }
    }
    else if (fruit == 2)
    {
        Console.WriteLine("You chose Strawberry \n");
        Console.WriteLine("Want to chose another fruit?");
        PickFruit = Console.ReadLine();
        if (PickFruit == "yes")
        {
            PickingFruit();
        }
        if (PickFruit == "no")
        {
            Environment.Exit(0);
        }
    }
    else if (fruit == 3)
    {
        Console.WriteLine("You chose Pear \n");
        Console.WriteLine("Want to chose another fruit?");
        PickFruit = Console.ReadLine();
        if (PickFruit == "yes")
        {
            PickingFruit();
        }
        if (PickFruit == "no")
        {
            Environment.Exit(0);
        }
    }
    else if (fruit == 4)
    {
        Console.WriteLine("You chose Apple \n");
        Console.WriteLine("Want to chose another fruit?");
        PickFruit = Console.ReadLine();
        if (PickFruit == "yes")
        {
            PickingFruit();
        }
        if (PickFruit == "no")
        {
            Environment.Exit(0);
        }
    }
    else
    {
        Console.WriteLine(fruit + " is not an option \n");
        Console.WriteLine("Want to chose another fruit?");
        PickFruit = Console.ReadLine();
        if (PickFruit == "yes")
        {
            PickingFruit();
        }
        if (PickFruit == "no")
        {
            Environment.Exit(0);
        }
    }
}