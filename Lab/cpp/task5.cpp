#include <iostream>
using namespace std;
int main()
{
  const int size=8;
  int set[size]={5,10,15,20,25,30,35,40};
  int *numptr;
  int count;
  numptr=set;
  for(count=0;count<size;count++)
  {
    cout<<*numptr<<" ";
    numptr++;
  }
  cout<<endl;
cout<<"REVERSE"<<endl;
    for(count=0;count<size;count++)
  {
     numptr--;
    cout<<*numptr<<" ";
  }
  return 0;
}