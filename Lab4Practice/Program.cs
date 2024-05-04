using Lab4Practice;

List<Drive> drives = new List<Drive>();

drives.Add(new Drive { NumberOfCar = "A123BCD", CostOfDrive = 100 });
drives.Add(new Drive { NumberOfCar = "A123DAD", CostOfDrive = 200 });
drives.Add(new Drive { NumberOfCar = "A123FEG", CostOfDrive = 300 });
drives.Add(new Drive { NumberOfCar = "A123GCD", CostOfDrive = 400 });
drives.Add(new Drive { NumberOfCar = "A123FSD", CostOfDrive = 500 });
drives.Add(new Drive { NumberOfCar = "A123USD", CostOfDrive = 600 });

var totalSum = drives.Sum(x => x.CostOfDrive);
Console.WriteLine(totalSum);

// make total sum by using LINQ

var totalSumByLinq = (from drive in drives
    select drive.CostOfDrive).Sum();

Console.WriteLine(totalSumByLinq);