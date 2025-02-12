#include<iostream>
using namespace std;

int main(){
    int x = 25;
    int *ptr;
    ptr = &x;
    cout<<"The value in X is "<<x<<endl;
    cout<<"Thr addree of X is "<< ptr<<endl;
    return 0;
}