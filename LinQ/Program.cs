using Ejercicios;
List<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 1, StudentName = "John", Age = 13},
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 21 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
    };


/*var filteredResult = from s in studentList
                    where s.Age > 12 && s.Age < 20
                    select s;


foreach(Student objStudent in filteredResult)
{
    Console.WriteLine(objStudent.StudentName);
}*/

var filteredResult = studentList.Where((s, i) => { 
            if(i % 2 ==  0) // if it is even element
                return true;
                
        return false;
});

foreach (var std in filteredResult)
        Console.WriteLine(std.StudentName);
Console.WriteLine("*************************");
var orderByDescendingResult = from s in studentList
                   orderby s.Age, s.StudentName descending
                   select s;
var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

foreach(var std in orderByDescendingResult){
    Console.WriteLine(std.StudentName+" "+std.Age);
}
Console.WriteLine("*************************");


var groupedResult = from s in studentList
                    group s by s.Age;


foreach(var ageGroup in groupedResult){
    Console.WriteLine("Grupo edad {0}",ageGroup.Key);

    foreach(var student in ageGroup){
        Console.WriteLine("Estudiante:{0}\tEdad:{1}",student.StudentName, student.Age);
    }
}




