#include <iostream>
#include <assert.h>
//Dosya için standart kütüphaneyi tarar

using namespace std;

#define PI 3.14159 
#define DAIRE_ALANI( x ) ( PI * ( x ) * ( x ) )
//Sembolik sabitler ve makrolar oluþturmak için öniþlemci komutu

#define FISBIRLESTIR( x, y ) x ## y
//iki fiþi birleþtirir

#line 100 "dosya.c"
//Bir sonraki kaynak kod dosyasýnýn baþýndan itibaren 100 den baþlayarak satýrlar numaralandýrýlýr



int main()
{

    int alan = DAIRE_ALANI(4);

    cout << alan << "\n";
    cout << PI << "\n";

    #if !defined( NULL )
    #define NULL 0
    #endif 

    #if !defined(NULL)
    #error C++ compiler required.
    #endif

    #if 1
    cout << "deneme" << "\n";
    #endif


    int x = 9;
    assert(x <= 10);

}