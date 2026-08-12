using Microsoft.AspNetCore.SignalR;

namespace student.Models;

public class Student{
    public int id{get;set;}
    public string name{get;set;}
    public string school{get;set;}
    public int std{get;set;}

public Student(int id,string name,string school,int std)
    {
        this.id=id;
        this.name=name;
        this.school=school;
        this.std=std;
        
    }

}