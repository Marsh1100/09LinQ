using System.Collections.Generic;
using OperadorJoin; 

List<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID=1} ,
        new Student() { StudentID = 1, StudentName = "John", Age = 13,StandardID=2},
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21,StandardID=2 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 21,StandardID=1} ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 21,StandardID=1} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } };

List<Standard> standarList = new List<Standard>() {
        new Standard() { StandardID = 1, StandardName = "Standar 1"},
        new Standard() { StandardID = 2, StandardName = "Standar 2"},
        new Standard() { StandardID = 3, StandardName = "Standar 3"}

};
var innerJoinResult = studentList.Join(standarList,
                                student => student.StandardID,
                                standard => standard.StandardID,
                                (student, standard) => new 
                                {
                                        StudentFullName = student.StudentName,
                                        StandarFullName = standard.StandardName
                                });

Console.WriteLine("{0,-30} {1,10}", "Nombre", "Categoria");
foreach(var obj in innerJoinResult ){
        Console.WriteLine("{0,-32} {1,7}", obj.StudentFullName, obj.StandarFullName);
}    