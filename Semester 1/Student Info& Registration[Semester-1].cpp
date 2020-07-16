#include <iostream> 
using namespace std; 
class StudentInfo { 
private:
    string name,id,phone,department;
public: 
StudentInfo()
{
    getinfo();
    showinfo();
}
    void getinfo()
    {
        cout<<"Enter name : ";
        cin>>name;
        cout<<"Enter ID : ";
        cin>>id;
        cout<<"Enter Phone Number : ";
        cin>>phone;
        cout<<"Enter Department : ";
        cin>>department;
    }
    void showinfo()
    {
        cout<<"Name : "<<name<<endl;
        cout<<"ID : "<<id<<endl;
        cout<<"Phone : "<<phone<<endl;
        cout<<"Department : "<<department<<endl;
    }   
}; 
class Student : public StudentInfo
{
private:
    bool Taken = false;
    bool course[5]={0};
public:
    Student()
    {
        menu();
    }
    void menu()
    {
        cout<<"*****MENU*****\n";
        cout<<"1.Show Courses"<<endl;
        cout<<"2.Show Taken Courses"<<endl;
        cout<<"3.Show Remaining Courses"<<endl;
        cout<<"4.Add"<<endl;
        cout<<"5.Drop"<<endl;
        cout<<"Select an option - ";
        string option;
        cin>>option;
        if(option=="1"){showcourses();}
        else if(option=="2"){showtakencourses();}
        else if(option=="3"){showremainingcourses();}
        else if(option=="4"){add();}
        else if(option=="5"){drop();}
        else if(option=="Done") {return;}
        else {cout<<"Invalid Option"<<endl;menu();}

    }
    void showcourses()
    {
        cout<<"1.DISCRETE MATHEMATICS"<<endl;
        cout<<"2.ENGLISH WRITING SKILLS & COMMUNICATIONS"<<endl;
        cout<<"3.INTEGRAL CALCULUS & ORD. DIFF EQUATION"<<endl;
        cout<<"4.INTRODUCTION TO ELECTRICAL CIRCUITS"<<endl;
        cout<<"5.OBJECT ORIENTED PROGRAMMING 1 (JAVA)"<<endl;
        cout<<"6.PHYSICS 2"<<endl;
        menu();
    }
    void taken()
    {
        cout<<"You have taken these courses - "<<endl;
        for(int i=0;i<5;i++)
            if(i==0 && course[i]==1) {cout<<"1.DISCRETE MATHEMATICS"<<endl; Taken = true;}
            else if(i==1 && course[i]==1){cout<<"2.ENGLISH WRITING SKILLS & COMMUNICATIONS"<<endl;Taken = true;}
            else if(i==2 && course[i]==1){cout<<"3.INTEGRAL CALCULUS & ORD. DIFF EQUATION"<<endl;Taken = true;}
            else if(i==3 && course[i]==1){cout<<"4.INTRODUCTION TO ELECTRICAL CIRCUITS"<<endl;Taken = true;}
            else if(i==4 && course[i]==1){cout<<"5.OBJECT ORIENTED PROGRAMMING 1 (JAVA)"<<endl;Taken = true;}
            else if(i==5 && course[i]==1){cout<<"6.PHYSICS 2"<<endl;Taken = true;}

            if(Taken == false) cout<<"You have not taken any course."<<endl;
    }
    void showtakencourses()
    {
        taken();
        menu();
    }
    void remaining()
    {
        bool alltaken=true;
        for(int i=0;i<5;i++) if(course[i]==0) {alltaken=false;break;}
        
        if(alltaken==true) {cout<<"You have taken all the courses."<<endl;}
        else{        
            for(int i=0;i<5;i++)
                if(i==0 && course[i]==0) {cout<<"1.DISCRETE MATHEMATICS"<<endl;}
                else if(i==1 && course[i]==0){cout<<"2.ENGLISH WRITING SKILLS & COMMUNICATIONS"<<endl;}
                else if(i==2 && course[i]==0){cout<<"3.INTEGRAL CALCULUS & ORD. DIFF EQUATION"<<endl;}
                else if(i==3 && course[i]==0){cout<<"4.INTRODUCTION TO ELECTRICAL CIRCUITS"<<endl;}
                else if(i==4 && course[i]==0){cout<<"5.OBJECT ORIENTED PROGRAMMING 1 (JAVA)"<<endl;}
                else if(i==5 && course[i]==0){cout<<"6.PHYSICS 2"<<endl;}
        }
    }
    void showremainingcourses()
    {
        remaining();
        menu();
    }
    void add()
    {
        remaining();   
        cout<<"Enter courses you want to add : ";
        
        string a;
        while(a!="confirm" || a!="Confirm" || a!="CONFIRM"){
            cin>>a;
            if(a=="1"){course[0]=1;}
            else if(a=="2"){course[1]=1;}
            else if(a=="3"){course[2]=1;}
            else if(a=="4"){course[3]=1;}
            else if(a=="5"){course[4]=1;}
            else if(a=="6"){course[5]=1;}
            else if(a=="confirm" || a=="Confirm" || a=="CONFIRM") break;
        }
        showtakencourses();
    }
    void drop()
    {
        taken();
        cout<<"Enter courses you want to drop : ";
        
        string a;
        while(a!="confirm" || a!="Confirm" || a!="CONFIRM"){
            cin>>a;
            if(a=="1"){course[0]=0;}
            else if(a=="2"){course[1]=0;}
            else if(a=="3"){course[2]=0;}
            else if(a=="4"){course[3]=0;}
            else if(a=="5"){course[4]=0;}
            else if(a=="6"){course[5]=0;}
            else if(a=="confirm" || a=="Confirm" || a=="CONFIRM") break;
        }
        
        showtakencourses();
    }
};
  
int main() 
{ 
    Student student1;
    Student student2;
    return 0;
} 