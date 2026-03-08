//Console.WriteLine("Hello world");
//Console.WriteLine("my name is Munirudeen");

//Variable Declearation(int , double , string,  bool)

int age = 50;

string name = "Munirudeen";

double height = 34.5;

bool isPresent =  false;


////////////////////////////////////////

//Console.WriteLine(name + " " + height); // string concatination

//Console.WriteLine($"{name} {height}"); // string interpolation

// for string interpolation
//Console.WriteLine($"my name is {name}, i am {age} years old. My heigh is {height}. are u a christain:{isPresent}");

// for Concatination
//Console.WriteLine("my name is " + name + ", i am " + age + " years old. my height is " + height + ".are u a christain:" + isPresent);

//March 7th 2026

decimal money = 1000746.60836836m;

float temprature = 30.5f;


/*
char firstletter = 'f';
char secondetter = 'a';
char thirdletter = 't';
char fourthletter = 'e';
long pop = 214748364888888868;*/

//Console.WriteLine($"welcome {firstletter}{secondetter}{thirdletter}{fourthletter}");

/*string score = "F";
 name = "Fatimah";*/


// int , memory = 4byte , whole number , e.g: 10,20,30
//float, memory = 4byte , decimal number(less precision), e.g :10.5f, 20.5f
//double, memory = 8byte, decimal numbers,e.g : 10.6786, 67.967, 10.5
//long , memory = 8byte , very large numbers , e.g: 9000000, 80000000,9000000
//decimal, memory = 16byte , very precise value(money), e.g bank acct balance.


//max and min for -2,147,483,648 and max 2,147,484,647

//Subject: Operators

// we have four operators : +, - , * , / , %

// int a = 45;
 //int b = 40;
 //int addedResult = a + b;
// int subtractionResults = a - b;
 
//double divisionResults = (double)a / b;

//Console.WriteLine($"Adding a and b values = {addedResult}"); // string interpolation
//Console.WriteLine($"Subtraction a and b values = {subtractionResults}"); // string interpolation
//Console.WriteLine($"Division Values  = {divisionResults}");

// there is something we call precision loss  and no precision losss

int pop1 = 200000;
long pop2 = 9000000000;

long popresult = pop1 + pop2;
//Console.WriteLine($"Population Total =  {popresult}"); // no precision loss


int jumahbalance = 100;
double sweetprice = 5.75;

double jumahamountleft = jumahbalance + sweetprice;
//Console.WriteLine($"Jumah Total =  {jumahamountleft}"); // no precision loss
/////////////////



float value1 = 5.234534635634f;
decimal value2 = 2.5m;

//decimal valueResult = (decimal)value1 + value2; // precision loss
float valueResult = value1 + (float)value2; // no precision loss


//Console.WriteLine($"Lekan said the total values added = {valueResult}");// 


///

double acctbalance = 10.3475;
decimal acctbalance2 = 5.20m;

double acctresult = acctbalance + (double)acctbalance2;

//Console.WriteLine($"Mariam said the total values added = {acctresult}");// 15.5457


// Easy Rules 
// int + long => safe 
// int + double => safe 
//float + double => some precision loss
//double + decimal => coversion need for any variable type we want
//float + descimal => coversion need for any variable type we want
// decimal => best for money



// Example 

int ab = 10;
int bc = 5;

int remainder = ab % bc;

//Console.WriteLine($"Remainder values = {remainder}");

int balance = 5000;
int amounttransfered = 3000;

//int newbalance = balance - amounttransfered; // conventional way 
balance -= amounttransfered; // prefered way 

//Console.WriteLine($"New balance  = {balance}");

int cd = 2;
int de = 5;

int jk = cd * de;// conventional way
 cd *= de;
//Console.WriteLine($"New balance  = {cd}");

// march 8 2026

//Camparison Operators
// == , equal to.
// != , not equal to.
// > , greater than.
// < , less than.
// >= . greater than or qual.
// <= , less than or equal.

// Examples 
int a = 5;
int b = 5;

//Console.WriteLine(a > b); // true 
//Console.WriteLine(a == b); // false
//Console.WriteLine(a != b); // true

// we make use of if and if-else statement for conditional operators;

/*
if (a > b)
{
 Console.WriteLine("Fatimah was right about a > b to be true");
}
else if (a < b)
{
 Console.WriteLine("Muheeb  was right");
}

else
{
 Console.WriteLine("Tutor said what fatimah said was wrong");
}
*/


// Another example 

/*int score = 100;

if (score >= 70)
{
 Console.WriteLine("Grade A");
}
else if (score >= 60)
{
 Console.WriteLine("Grade B");
}
else if (score >= 50)
{
 Console.WriteLine("Grade C");
}
else 
{
 Console.WriteLine("Fail");
}*/

// Logical operators
// && , means "AND" , this binds true and true values
// || , means "OR" , only one has to be true
// ! , means "Not"

// Examples of Logical and comparison operators

// using && 
/*int score = 30;

if (score >= 50 && score <= 100)
{
 Console.WriteLine("Passed");
}
else
{
 Console.WriteLine("failed");
}*/


/*bool paidfees = true;
bool hasIcard = true;
bool hasdonematric = false;

if (paidfees && hasIcard && hasdonematric)
{
 Console.WriteLine("You can enter the exam hall");
}
else
{
 Console.WriteLine("You cannot enter");
}*/



// using ||

/*
bool isStudent = false;
bool isSeniorCitizen = false;

if (isStudent || isSeniorCitizen)
{
 Console.WriteLine("You are qualified for discount");
}
else
{
 Console.WriteLine("You are not qualified for discount");
}
*/


// combining the && and ||

bool paidfees = true;
bool hasIcard = true;
bool hasdonematric = false;
bool hasdoneRegistartion = false;
bool isCitizen = false;



// 1
/*if ((paidfees && hasIcard) || hasdonematric)
{
 Console.WriteLine("Student can enter exam hall");
}
else
{
 Console.WriteLine("Student cannot enter exam hall");
}*/

//2
/*if ((hasdoneRegistartion && paidfees) || isCitizen)
{
 Console.WriteLine("Access Granted");
}
else
{
 Console.WriteLine("Access Denied");
}*/

// 3
/*
if (paidfees && (hasdonematric || hasdoneRegistartion))
{
 Console.WriteLine("Student is fully verified");
}
else
{
 Console.WriteLine("Student is not verified");
}
*/

//4

/*if ((paidfees && hasIcard) && (hasdonematric || hasdoneRegistartion || isCitizen))
{
 Console.WriteLine("Student cleared");
}
else
{
 Console.WriteLine("Student not cleared");
}*/

//5 

/*if ((paidfees && hasIcard) && (hasdonematric || hasdoneRegistartion) 
    || (isCitizen && hasIcard))
{
 Console.WriteLine("Student can write the final exam");
}
else
{
 Console.WriteLine("Student cannot write the final exam");
}*/

// 6

/*if (hasdonematric || paidfees && hasIcard)
{
 Console.WriteLine("Student verified");
}
else
{
 Console.WriteLine("Student not verified");
}*/

// 7

/*if (paidfees && hasIcard && hasdonematric && hasdoneRegistartion)
{
 Console.WriteLine("Student fully cleared");
}
else
{
 Console.WriteLine("Student not fully cleared");
}*/

// 8

/*if (paidfees || hasIcard && hasdonematric || hasdoneRegistartion)
{
 Console.WriteLine("Approved");
}
else
{
 Console.WriteLine("Rejected");
}*/

// 9

/*if (paidfees && hasIcard || hasdonematric || isCitizen)
{
 Console.WriteLine("Student allowed");
}
else
{
 Console.WriteLine("Student not allowed");
}*/

// 10


if (paidfees || hasIcard && hasdonematric || hasdoneRegistartion && isCitizen  )
{
 Console.WriteLine("Allowed");
}
else
{
 Console.WriteLine("Not Allowed");
}






