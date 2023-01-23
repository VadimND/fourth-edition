// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

float MyFloatValue = 10;
int myIntValue = (int)MyFloatValue;
//Console.WriteLine("myIntValue is " + myIntValue);

int myInt = 10;
byte myByte = (byte)myInt;
double myDouble = (double)myByte;
string myString = myInt.ToString();
string myByteVar = Convert.ToString(myInt, 2);
bool myBool = true;
myString = myByte.ToString();
short myShort = (short)myInt;
char myChar = 'x';
myString = myChar.ToString(); 
long myLong = (long)myInt;
decimal myDecimal = (decimal)myLong;
myString = myString + myByte + myDouble + myChar;

//Console.WriteLine("myInt: " + myInt);
//Console.WriteLine("myString " + myString);
//Console.WriteLine("myByte " + myByte);
//Console.WriteLine("myChar " + myChar);

int MyMethod(bool add3) {
    int value = 12;

    if (add3)
    {
        value += 3;
    }
    else
    {
        value -= 2;
    }

    return value;
}
Console.WriteLine(MyMethod(false));