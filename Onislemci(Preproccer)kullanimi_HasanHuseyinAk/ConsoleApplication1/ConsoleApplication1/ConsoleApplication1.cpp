#include <iostream>
#include <assert.h>
//Dosya i�in standart k�t�phaneyi tarar

using namespace std;

#define PI 3.14159 
#define DAIRE_ALANI( x ) ( PI * ( x ) * ( x ) )
//Sembolik sabitler ve makrolar olu�turmak i�in �ni�lemci komutu

#define FISBIRLESTIR( x, y ) x ## y
//iki fi�i birle�tirir

#line 100 "dosya.c"
//Bir sonraki kaynak kod dosyas�n�n ba��ndan itibaren 100 den ba�layarak sat�rlar numaraland�r�l�r



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