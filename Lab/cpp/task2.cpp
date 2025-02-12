#include <iostream>
using namespace std;

int main()
{
  int x=25;
  int *ptr;
  ptr =&x;
  cout<<x<<endl;
  cout<<*ptr<<endl;
  *ptr=100;
  cout<<x<<endl;
  cout<<*ptr<<endl;
  return 0;
}