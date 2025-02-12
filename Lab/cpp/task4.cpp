#include <iostream>
using namespace std;

int main()
{
  const int NUM_coins=5;
  double coins[NUM_coins]={0.05,0.1,0.25,0.5,1.0};
  double *doubleptr;
  int count;
  doubleptr=coins;
  for(count=0;count<NUM_coins;count++)
  {
    cout<<doubleptr[count]<<" "<<endl;
  }
  cout<<endl;

    for(count=0;count<NUM_coins;count++)
  {
    cout<<*(coins+count)<<" "<<endl;
  }
  cout<<endl;
  return 0;
}