// Postfix Increment  vs Prefix Increment

Postfix 

int a =1 ;
int b = a++;

a = 2 , b = 1 // b takes the value of a thats 1 and then increment by 1

Prefix

int a =1;
int b = ++a;

a=2 , b =2 // here a first increment by 1 and then applying to b  

using System;

namespace Operator
{
    static void Main(string[] args)
    {
        var a = 10;
        var b = 3;

        Console.WriteLine(a/b); // returns 3 instead of 3.333
        Console.WriteLine((float)a/(float)b); // returns 3.333
    }
}

// !!!!  C# react like common maths when need to resolve complicated maths problems. 
// !!!!  * and / have higher presidence than + -

