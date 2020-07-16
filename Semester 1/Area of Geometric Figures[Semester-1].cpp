#include <iostream>
using namespace std;
class Triangle
{
private:
    float base;
	float height;
public:
 	Triangle()
	{
	    cout<<"Enter Base and Height of Triangle : ";
		cin>>base>>height;
		cout<<"Area of Trangle is "<<area(base,height)<<endl;
	}
	float area(float base, float height)
	{
		float area = 0.5*base*height;
		return area;
	}
	~Triangle(){	}
};
class Square
{
private:
    int a;
public:
 	Square()
	{
	    cout<<"Enter Side of Square : ";
		int a;
		cin>>a;
		cout<<"Area of Square is "<<area(a)<<endl;
	}
	int area(int a)
	{
		int area = a*a;
		return area;
	}
	~Square(){	}
};
class Rectangle
{
private:
    int a;
	int b;
public:
 	Rectangle()
	{
	    cout<<"Enter Sides of Rectangle : ";
		cin>>a>>b;
		cout<<"Area of Square is "<<area(a,b)<<endl;
	}
	int area(int a,int b)
	{
		int area = a*b;
		return area;
	}
	~Rectangle(){	}
};
class Circle
{
private:
    int r;
	const float pi = 3.1416;
public:
 	Circle()
	{
	    cout<<"Enter Sides of Circle : ";
		cin>>r;
		cout<<"Area of Square is "<<area(r)<<endl;
	}
	float area(float r)
	{
		float area = pi*r*r;
		return area;
	}
	~Circle(){	}
};
int main()
{
	int option;
    cout<<"Enter geometric figure\t1.Circle\t2.Rectangle\t3.Square\t4.Triangle"<<endl;
	cin>>option;
    switch (option)
    {
    case 1:
        {Circle obj1;
        break;}
    case 2:
		    {Rectangle obj2;
			break;}
	case 3:
	    {Square obj3;
		break;}
	case 4:
	    {Triangle obj4;
		break;}
    default:
        {cout<<"Invalid input";}
    }
    return 0;
}