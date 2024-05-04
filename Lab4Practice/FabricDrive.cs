namespace Lab4Practice;
using Lab4Practice;

public class FabricDrive
{
    //make fabric for make Drive object
    //make Drive object
    private Drive MakeDrive(string numberOfCar, double costOfDrive)
    {
        return new Drive
        {
            NumberOfCar = numberOfCar ?? new string("A123BCD"),
            CostOfDrive = costOfDrive
        };
    }
    
    public Drive MakeRandomDrive()
    {
        var random = new Random();
        var numberOfCar = new string((char)random.Next(65, 90), 1) + random.Next(0, 2) + random.Next(0, 2) +
                          new string((char)random.Next(65, 90), 3);
        
        var costOfDrive = random.Next(100, 1000);
        Drive drive = MakeDrive(numberOfCar, costOfDrive);
        
        return drive;
    }
    
    
}