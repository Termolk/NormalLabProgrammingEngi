// See https://aka.ms/new-console-template for more information

using Lab4Example;

Console.WriteLine("Hello, World!");


List<Exam> exams = new List<Exam>();

exams.Add(new Exam { FioStudent = "Иванов И.И.", Discipline = "Математика", Mark = 5 });
exams.Add(new Exam { FioStudent = "Смирнов С.С.", Discipline = "Физика", Mark = 4 });
exams.Add(new Exam { FioStudent = "Петров П.П.", Discipline = "Русский язык", Mark = 4 });
exams.Add(new Exam { FioStudent = "Сидоров С.С.", Discipline = "Математика", Mark = 3 });

var result1Linq = from var in exams
    where var.Discipline.Equals("Математика")
    orderby var.FioStudent
    select var;

// foreach (var item in result1Linq)
// {
//     Console.WriteLine(item.FioStudent);
// }
//
// var result1Ex = exams
//     .Where(x => x.Discipline.Equals("Математика"))
//     .OrderBy(x => x.FioStudent);
//
// foreach (var item in result1Ex)
// {
//     Console.WriteLine(item.FioStudent);
// }

var result2Linq = from var in exams
                    group var by var.Discipline
                    into groupedExam
                    select new
                    {
                        Discipline = groupedExam.Key,
                        Average = groupedExam.Average(x => x.Mark),
                        StudentsNumber = groupedExam.Count()
                    };


foreach (var item in result2Linq)
{
    Console.WriteLine(item.Discipline);
    Console.WriteLine(item.Average);
    Console.WriteLine();
}

var result2Ex = exams.GroupBy(x=>x.Discipline)
    .Select(x => new
    {
        Discipline = x.Key,
        Average = x.Average(x => x.Mark),
        StudentsNumber = x.Count()
    });

