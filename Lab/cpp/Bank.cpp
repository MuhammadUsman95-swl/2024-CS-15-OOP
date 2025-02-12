#include <iostream>
#include <conio.h>
#include <windows.h>
using namespace std;

void menu();
float withdraw(float ,float);
float deposit(float,float);
float deductZakat(float &);
float getLoan(float,int);

main(){
    float totalBalance=100000.00, withdrawAmount = 0.00, depositAmount = 0.00, loan = 0.00,zakat = 0.00,returnAmount = 0.00;
    int option = 0,year = 0;
    while (option != 6)
    {
        system("cls");
        menu();
        cout<<"Enter valid option.... ";
        cin>>option;
        if(option==1){
            cout<<"Enter amount to withdraw.... ";
            cin>> withdrawAmount;
            if(withdrawAmount <= totalBalance){
            totalBalance = withdraw(withdrawAmount,totalBalance);
            cout<<"You have successfully withdraw "<<withdrawAmount<<" rupees. Your current balance is..."<<totalBalance<<endl;
            Sleep(5000);
            }
            else{
                cout<<"You can not withdraw more than "<<totalBalance<<"..."<<endl;
                Sleep(3000);
                }
        }
        else if(option==2){
            cout<<"Enter amount to deposit.... ";
            cin>> depositAmount;
            totalBalance = deposit(depositAmount,totalBalance);
            cout<<"Your current balance is... "<<totalBalance<<endl; 
            Sleep(3000); 
        }
        else if(option==3){
            zakat = deductZakat(totalBalance);
            cout<<"Your Zakat "<<zakat<<" has been deducted from your balance."<<endl;
            cout<<"Current balance.... "<<totalBalance<<endl;
            Sleep(5000);
        }
        else if(option==4){
            cout<<"Enter the amount of loan you want to get..";
            cin>> loan;
            cout<<"Enter time (year)...... ";
            cin>> year;
            returnAmount = getLoan(loan,year);
            cout<<"You have get loan at 10 percent interest for "<<year <<" & have to pay "<<returnAmount<<" after "<<year <<" years."<<endl;
            Sleep(5000); 
        }
        else if(option == 5){
            cout<<"Your curret balance is... "<<totalBalance<<endl;
            cout<<"You have get loan of "<<loan<<" and have to retrn "<<returnAmount<<" within "<<year<<endl;
            Sleep(3000);
        }
        else if(option != 6){
            cout<<"Invalid option.... "<<endl;
            Sleep(3000);
        }
    }
    
}

void menu(){
    cout << "\e[0;30m";
    cout<<"^^^^^^^^^^^^^^^^^^^^^^^^"<<endl;
    cout << "\e[0;30m";
    cout << "\e[0;32m";
    cout<<" AN Bank Privat limited "<<endl;
    cout << "\e[0;32m";
    cout << "\e[0;30m";
    cout<<"------------------------"<<endl;
    cout << "\e[0;30m";
    cout << "\e[0;34m";
    cout<<"1. WithDraw Amount      "<<endl;
    cout<<"2. Deposit Amount       "<<endl;
    cout<<"3. Deduct Zakat         "<<endl;
    cout<<"4. Get loan             "<<endl;
    cout<<"5. View Current Account "<<endl;
    cout<<"6. Exit                 "<<endl;
    cout << "\e[0;34m";
    cout << "\e[0;30m";
    cout<<"________________________"<<endl;
    cout << "\e[0;30m";
    cout<<endl;
}

float withdraw(float withdrawAmount,float totalBalance){
    totalBalance = totalBalance - withdrawAmount;
    return totalBalance;
}

float deposit(float depositAmount,float totalBalance){
    totalBalance = totalBalance + depositAmount;
    return totalBalance;
}

float deductZakat(float &totalBalance){
    float zakat;
    zakat = 0.025*totalBalance;
    totalBalance = 0.975*totalBalance;
    return zakat;
}

float getLoan(float loan,int year){
    int amountToReturn;
    amountToReturn = ((loan*10*year)/100)+loan;
    return amountToReturn;
}