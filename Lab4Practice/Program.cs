using Lab4Practice;

List<Drive> drives = new List<Drive>();

FabricDrive fabricDrive = new FabricDrive();

drives.Add(fabricDrive.MakeRandomDrive());
drives.Add(fabricDrive.MakeRandomDrive());
drives.Add(fabricDrive.MakeRandomDrive());
drives.Add(fabricDrive.MakeRandomDrive());
drives.Add(fabricDrive.MakeRandomDrive());

foreach (var drive in drives)
{
    Console.WriteLine($"{drive.NumberOfCar} {drive.CostOfDrive}");
}


var totalSum = drives.Sum(x => x.CostOfDrive);
Console.WriteLine(totalSum);

var totalSumByLinq = (from drive in drives
    select drive.CostOfDrive).Sum();

Console.WriteLine(totalSumByLinq);
/* OUTPUT
   A01NNN 657
   V10HHH 369
   V00DDD 314
   O11KKK 326
   E11YYY 189
   1855
   1855
   
 * 
 */

