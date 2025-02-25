

#include <iostream>
using namespace std;

enum enPrimNotPrim{prim =1,NotPrim =2};

int ReadPositveNumber(string Massge)
{
    int Number = 0;
    do
    {
        cout << Massge << endl;
        cin >> Number;
    } while (Number <= 0);
    return Number;
}

enPrimNotPrim CheckPrime(int Number)
{
    int M = round(Number / 2);
    for (int counter = 2; counter <= M; counter++)
    {
        if (Number % counter == 0) 
        
            return enPrimNotPrim::NotPrim;
       
    }
    return enPrimNotPrim::prim;
}

void PrintPrimNumberFrom1ToN(int Number)
{
    cout << "\n";
    cout << "prim numbers from  " << 1 << " to " << Number;
    cout << " are :" << endl;

    for (int i = 1; i <= Number; i++)
    {
        if (CheckPrime(i) == enPrimNotPrim::prim)
            cout << i << endl;
    }

}

int main()
{
    PrintPrimNumberFrom1ToN(ReadPositveNumber("Enter a positve number "));
}

