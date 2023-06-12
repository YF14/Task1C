//Q1
/*
Console.Write("Enter first number ");
double firstNumber=Convert.ToDouble( Console.ReadLine());
Console.Write("Enter sec number ");

double secNumber = Convert.ToDouble(Console.ReadLine());
double resulte = firstNumber + secNumber;
if (firstNumber == secNumber)
    resulte = resulte * 3;

    Console.WriteLine("your result is :" + resulte);
*/
//-------------------------------------------------------------
//Q2
/*
Console.Write("Enter  number ");
double number = Convert.ToDouble(Console.ReadLine());
if (number > 51)
    Console.WriteLine("your result is :" + (number - 51) * 3);
else
Console.WriteLine("your result is :" + (51-number));
*/
//--------------------------------------------------------------
//Q3

/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber==30||secNumber==30||firstNumber + secNumber==30)
Console.WriteLine("True");
else Console.WriteLine("False");
*/
//---------------------------------------------------------------
//Q4
/*
 Console.Write("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number - 100) <= 10 || Math.Abs(number - 200) <= 10)
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//---------------------------------------------------------------
//Q5
/*
Console.Write("Enter string ");
string anything =Console.ReadLine();
if (anything.IndexOf("if") != 0)
    anything = "if " + anything;
 Console.WriteLine(anything);
*/
//-----------------------------------------------------------------
//Q6
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
Console.Write("Enter index:");
int indexx =Convert.ToInt32( Console.ReadLine());
if (anything.Length >= indexx)
    Console.WriteLine(anything.Remove(indexx,1)); 
*/
//------------------------------------------------------------------
//Q7
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
if(anything.Length>1)
Console.WriteLine(anything.Substring(anything.Length-1)+ anything.Substring(1, anything.Length-2)+anything.Substring(0,1));
else Console.WriteLine(anything);
*/
//----------------------------------------------------------------
//Q8
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
if (anything.Length > 2)
    Console.WriteLine( anything.Substring(0, 2)+ anything.Substring(0, 2)+ anything.Substring(0, 2)+ anything.Substring(0, 2));
else Console.WriteLine(anything);
*/
//-----------------------------------------------------------------
//Q9
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
if (anything.Length > 1)
    Console.WriteLine(anything.Substring(anything.Length - 1) + anything + anything.Substring(anything.Length - 1));
else Console.WriteLine(anything);
*/
//-----------------------------------------------------------------
//Q10
/*
Console.Write("Enter first number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%3==0||number%7==0)
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//---------------------------------------------------------------------
//Q11
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
if (anything.Length > 3)
    Console.WriteLine(anything.Substring(0, 3) + anything + anything.Substring(0,3));
else Console.WriteLine(anything+anything+anything);
*/
//-----------------------------------------------------------------------
//Q12
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
if (anything.IndexOf("C#") == 0)
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//------------------------------------------------------------------------
//Q13
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if ((firstNumber > 100 && secNumber <0) || (secNumber > 100 && firstNumber < 0))
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//--------------------------------------------------------------------------
//Q14
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if ((firstNumber >=100 && firstNumber < 200) || (secNumber >= 100 && secNumber < 200))
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//---------------------------------------------------------------------------
//Q15
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");
int secNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number ");

int thirdNumber = Convert.ToInt32(Console.ReadLine());
if ((firstNumber >= 20 && firstNumber <=50) || (secNumber >= 20 && secNumber <= 50) || (thirdNumber >= 20 && thirdNumber <= 50))
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//----------------------------------------------------------------------------
//Q16
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if (((firstNumber >= 20 && firstNumber < 50) || (secNumber >= 20 && secNumber < 50))&&!((firstNumber >= 20 && firstNumber < 50) && (secNumber >= 20 && secNumber < 50)))
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//-----------------------------------------------------------------------------
//Q17
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
if (anything.IndexOf("yt") == 1)
    Console.WriteLine(anything.Remove(1,2));
else Console.WriteLine(anything);
*/
//-----------------------------------------------------------------------------
//Q18
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");
int secNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number ");

int thirdNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Max( Math.Max(firstNumber,secNumber),thirdNumber));
*/
//-----------------------------------------------------------------------------
//Q19
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber==secNumber)
    Console.WriteLine(0);
else if (Math.Abs(100-firstNumber ) < Math.Abs(100-secNumber ))
    Console.WriteLine(firstNumber);
else Console.WriteLine(secNumber);
*/
//---------------------------------------------------------------------------
//Q20
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if (((firstNumber >= 40 && firstNumber <= 50) && (secNumber >= 40 && secNumber <= 50)) ||((firstNumber >= 50 && firstNumber <= 60) && (secNumber >= 50 && secNumber <= 60)))
    Console.WriteLine("True");
else Console.WriteLine("False");
*/
//----------------------------------------------------------------------------
//Q21
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if (((firstNumber >= 20 && firstNumber <= 30) && (secNumber >= 20 && secNumber <= 30)))
    Console.WriteLine(Math.Max(firstNumber,secNumber));
else Console.WriteLine(0);
*/
//-------------------------------------------------------------------------------
//Q22
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
string temp;
if (anything.Length >= 4)
{
    temp = anything.Substring(1, 3);
    if (temp.Contains("z"))
        Console.WriteLine("true");
    else Console.WriteLine("false");
}
else Console.WriteLine("please more than 3 char");
*/
//-----------------------------------------------------------------------------
//Q23
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");

int secNumber = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(firstNumber % 10) == Math.Abs(secNumber % 10))
    Console.WriteLine("true");
else Console.WriteLine("false");
*/
//--------------------------------------------------------------------------------
//Q24
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
    if (anything.Length<=3)
        Console.WriteLine(anything.ToUpper());
    else Console.WriteLine(anything.Remove(anything.Length-3)+anything.Substring(anything.Length-3).ToUpper());
*/
//--------------------------------------------------------------------------------
//Q25
/*
Console.Write("Enter string ");
string anything = Console.ReadLine();
Console.Write("Enter number  ");
int number =Convert.ToInt32( Console.ReadLine());
for  (int i = 0; i < number; i++)
{
    Console.Write(anything);
}
Console.WriteLine("");
*/
//-----------------------------------------------------------------------------------
//Q1 P2
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");
string x= "not equal";
int secNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secNumber)
    x = "equal";
    Console.WriteLine(firstNumber+" and "+secNumber+" are "+x);
*/
//-----------------------------------------------------------------------------------
//Q2 P2
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
string x = "odd";
if (number%2==0)
    x = "even";
Console.WriteLine(number + " is " + x + " Int");
*/
//-----------------------------------------------------------------------------------
//Q3 P2
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
string x = "negative";
if (number >= 0)
    x = "positive ";
Console.WriteLine(number + " is a " + x + " number");
*/
//-----------------------------------------------------------------------------------
//Q4 P2
/*
 Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 400) == 0)
    Console.WriteLine("{0} is a leap year.\n", number);
else if ((number % 100) == 0)
    Console.WriteLine("{0} is not a leap year.\n", number);
else if ((number % 4) == 0)
    Console.WriteLine("{0} is a leap year.\n", number);
else
    Console.WriteLine("{0} is not a leap year.\n", number);
*/
//------------------------------------------------------------------------------------
//Q5 P2
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 18)
{
    Console.Write("Sorry, you are underage.\n");
    Console.Write("come after {0} year.\n\n", 18 - number);
}
else
    Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
*/
//------------------------------------------------------------------------------------
//Q6 P2
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
    Console.WriteLine("The value of n = 1");
else if (number < 0) Console.WriteLine("The value of n = -1");
else Console.WriteLine("The value of n = -0");
*/
//------------------------------------------------------------------------------------
//Q7 P2
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 150.0)
    Console.Write("The person is Dwarf. \n\n");
else if ((number >= 150.0) && (number <= 165.0))
    Console.Write("average heighted. \n\n");
else if ((number >= 165.0) && (number <= 200.0))
    Console.Write("tall. \n\n");
else
    Console.Write("Abnormal height.\n\n");
*/
//------------------------------------------------------------------------------------
//Q8 P2
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");
int secNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number ");

int thirdNumber = Convert.ToInt32(Console.ReadLine());
int temp;
temp = Math.Max(Math.Max(firstNumber, secNumber), thirdNumber);

    if( firstNumber==temp)
        Console.WriteLine("The 1st Number is the greatest among three");
    else if( secNumber==temp)
        Console.WriteLine("The 2nd Number is the greatest among three");
    else  if(thirdNumber==temp)
        Console.WriteLine("The 3rd Number is the greatest among three");
*/
//------------------------------------------------------------------------
//Q9 P2 
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");
int secNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber>0 && secNumber>0)
    Console.WriteLine("The coordinate point {0} , {1} lies in the First quadrant.",firstNumber ,secNumber);
else if (firstNumber > 0 && secNumber < 0)
    Console.WriteLine("The coordinate point {0} , {1} lies in the Second  quadrant.", firstNumber, secNumber);
else if (firstNumber < 0 && secNumber < 0)
    Console.WriteLine("The coordinate point {0} , {1} lies in the Third  quadrant.", firstNumber, secNumber);
else if (firstNumber < 0 && secNumber > 0)
    Console.WriteLine("The coordinate point {0} , {1} lies in the Fourth  quadrant.", firstNumber, secNumber);
*/
//--------------------------------------------------------------------------

//Q10 P2
//Console.Write("Input the marks obtained in Physics: ");
//int physicsMarks = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input the marks obtained in Chemistry: ");
//int chemistryMarks = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input the marks obtained in Mathematics: ");
//int mathMarks = Convert.ToInt32(Console.ReadLine());
//int totalMarks = physicsMarks + chemistryMarks + mathMarks;
//if (mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)
//{
//    Console.WriteLine("The candidate is eligible for admission.");
//}
//else if (totalMarks >= 140)
//{
//    Console.WriteLine("The candidate is eligible for admission.");
//}
//else
//{
//    Console.WriteLine("The candidate is not eligible for admission.");
//}
//Q11 P2
//Console.Write("Input the value of a: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Input the value of b: ");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Input the value of c: ");
//double c = double.Parse(Console.ReadLine());
//double discriminant = b * b - 4 * a * c;
//if (discriminant > 0)
//{
//    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
//    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
//    Console.WriteLine("the root is : " + root1 + "," + root2);
//}
//else
//{
//    Console.WriteLine("Roots are imaginary; No Solution.");
//}
//Q12 P2
//int rollNo;
//string name;
//int physicsMarks, chemistryMarks, computerMarks;
//double totalMarks, percentage;
//string division;
//Console.Write("Input the Roll Number of the student: ");
//rollNo = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input the Name of the Student: ");
//name = Console.ReadLine();
//Console.Write("Input the marks of Physics, Chemistry, and Computer Application: ");
//string[] marks = Console.ReadLine().Split(' ');
//physicsMarks = Convert.ToInt32(marks[0]);
//chemistryMarks = Convert.ToInt32(marks[1]);
//computerMarks = Convert.ToInt32(marks[2]);
//totalMarks = physicsMarks + chemistryMarks + computerMarks;
//percentage = (totalMarks / 300) * 100;
//if (percentage >= 60)
//{
//    division = "First";
//}
//else if (percentage >= 50)
//{
//    division = "Second";
//}
//else if (percentage >= 40)
//{
//    division = "Third";
//}
//else
//{
//    division = "Fail";
//}
//Console.WriteLine("Roll No : " + rollNo);
//Console.WriteLine("Name of Student : " + name);
//Console.WriteLine("Marks in Physics : " + physicsMarks);
//Console.WriteLine("Marks in Chemistry : " + chemistryMarks);
//Console.WriteLine("Marks in Computer Application : " + computerMarks);
//Console.WriteLine("Total Marks = " + totalMarks);
//Console.WriteLine("Percentage = " + percentage.ToString("0.00"));
//Console.WriteLine("Division = " + division);
//Q13 P2
//Console.Write("Enter the temperature in centigrade: ");
//int temperature = int.Parse(Console.ReadLine());
//string message = "";
//if (temperature < 0)
//{
//    message = "Freezing weather";
//}
//else if (temperature >= 0 && temperature <= 10)
//{
//    message = "Very Cold weather";
//}
//else if (temperature > 10 && temperature <= 20)
//{
//    message = "Cold weather";
//}
//else if (temperature > 20 && temperature <= 30)
//{
//    message = "Normal in Temp";
//}
//else if (temperature > 30 && temperature <= 40)
//{
//    message = "Its Hot";
//}
//else if (temperature >= 40)
//{
//    message = "Its Very Hot";
//}
//Console.WriteLine(message);
//Q14 P2
//Console.WriteLine("Enter the lengths of the sides of the triangle: ");
//int side1 = int.Parse(Console.ReadLine());
//int side2 = int.Parse(Console.ReadLine());
//int side3 = int.Parse(Console.ReadLine());
//if (side1 == side2 && side2 == side3)
//{
//    Console.WriteLine("This is an equilateral triangle.");
//}
//else if (side1 == side2 || side2 == side3 || side1 == side3)
//{
//    Console.WriteLine("This is an isosceles triangle.");
//}
//else
//{
//    Console.WriteLine("This is a scalene triangle.");
//}
//Q15 P2
//Console.WriteLine("Enter the three angles of the triangle: ");
//int angle1 = int.Parse(Console.ReadLine());
//int angle2 = int.Parse(Console.ReadLine());
//int angle3 = int.Parse(Console.ReadLine());
//if (angle1 + angle2 + angle3 == 180)
//{
//    Console.WriteLine("The triangle is valid.");
//}
//else
//{
//    Console.WriteLine("The triangle is not valid.");
//}
//Q16 P2 
/*
    Console.Write("Enter char ");
char anything = Convert.ToChar(Console.ReadLine());
if (anything == 'a' || anything == 'e' || anything == 'i' || anything == 'o' || anything == 'u')
    Console.WriteLine("vowel ");
else Console.WriteLine("consonant");
*/
//Q17 P2
/*
Console.Write("Enter first number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter sec number ");
int secNumber = Convert.ToInt32(Console.ReadLine());
int x = secNumber-firstNumber ;
if (x > 0)
    Console.WriteLine("You can book your profit amount :" + x);
else if (x == 0) Console.WriteLine("you didnt make of loss anything");
else Console.WriteLine(" your loss amount : " + x);
*/
//Q18 P2
/*
int id, consumed;
string name;
double tax;
double fullTax;
double per=0;
double total;
Console.Write("Input Customer ID :");
id = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the name of the customer :");
name = Console.ReadLine();
Console.Write("Input the unit consumed by the customer : ");
consumed = Convert.ToInt32(Console.ReadLine());
if (consumed < 200)
    tax = 1.20;
else if (consumed >= 200 && consumed < 400)
    tax = 1.50;
else if (consumed >= 400 && consumed < 600)
    tax = 1.80;
else
    tax = 2.00;
fullTax = consumed * tax;
if (fullTax > 400   )
    per = fullTax * 15 / 100.0;
total = fullTax + per;
if (total < 100)
    total = 100;
Console.Write("\nElectricity Bill\n");
Console.Write("Customer IDNO                       :{0}\n", id);
Console.Write("Customer Name                       :{0}\n", name);
Console.Write("unit Consumed                       :{0}\n", consumed);
Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", tax, fullTax);
Console.Write("Surchage Amount                     :{0}\n", per);
Console.Write("Net Amount Paid By the Customer     :{0}\n", total);
*/
//Q19 P2
/*
Console.Write("Input char :");
char x = Convert.ToChar(Console.ReadLine());
switch(x)
{
    case 'E':
        Console.WriteLine("You have chosen: Excellent"); break;
    case 'V':
        Console.WriteLine("You have chosen: Very Good"); break;
    case 'G':
        Console.WriteLine("You have chosen: Good"); break;
    case 'A':
        Console.WriteLine("You have chosen: Average"); break;
    case 'F':
        Console.WriteLine("You have chosen: Fail"); break;
}
*/
//Q20 P2
/*
Console.Write("Input day  :");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 7:
        Console.WriteLine("You have chosen: sunday"); break;
    case 1:
        Console.WriteLine("You have chosen: monday"); break;
    case 2:
        Console.WriteLine("You have chosen: thusday"); break;
    case 3:
        Console.WriteLine("You have chosen: wednesday"); break;
    case 4:
        Console.WriteLine("You have chosen: Thursday"); break;
    case 5:
        Console.WriteLine("You have chosen: friday"); break;
    case 6:
        Console.WriteLine("You have chosen: satuday"); break;
}
*/
//Q21 P2
/*
Console.Write("Input digit  :");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 0:
        Console.Write("Zero\n");
        break;

    case 1:
        Console.Write("one\n");
        break;
    case 2:
        Console.Write("Two\n");
        break;
    case 3:
        Console.Write("Three\n");
        break;
    case 4:
        Console.Write("Four\n");
        break;
    case 5:
        Console.Write("Five\n");
        break;
    case 6:
        Console.Write("Six\n");
        break;
    case 7:
        Console.Write("Seven\n");
        break;
    case 8:
        Console.Write("Eight\n");
        break;
    case 9:
        Console.Write("Nine\n");
        break;
    default:
        Console.Write("invalid digit. \nPlease try again ....\n");
        break;
}
*/
//Q22 P2

/*
Console.Write("Input month number  :");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1:
        Console.Write("january\n");
        break;
    case 2:
        Console.Write("february\n");
        break;
    case 3:
        Console.Write("march\n");
        break;
    case 4:
        Console.Write("april\n");
        break;
    case 5:
        Console.Write("may\n");
        break;
    case 6:
        Console.Write("june\n");
        break;
    case 7:
        Console.Write("july\n");
        break;
    case 8:
        Console.Write("august\n");
        break;
    case 9:
        Console.Write("september\n");
        break;
    case 10:
        Console.Write("octobor\n");
        break;
    case 11:
        Console.Write("november\n");
        break;
    case 12:
        Console.Write("december\n");
        break;
    default:
        Console.Write("invalid digit. \nPlease try again ....\n");
        break;
}
*/
//Q23 P2
/*
    Console.Write("Input month number  :");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1:
        Console.Write("Month have 31 days\n");
        break;
    case 2:
        Console.Write("Month have 28 days\n");
        break;
    case 3:
        Console.Write("Month have 31 days\n");
        break;
    case 4:
        Console.Write("Month have 30 days\n");
        break;
    case 5:
        Console.Write("Month have 31 days\n");
        break;
    case 6:
        Console.Write("Month have 30 days\n");
        break;
    case 7:
        Console.Write("Month have 31 days\n");
        break;
    case 8:
        Console.Write("Month have 31 days\n");
        break;
    case 9:
        Console.Write("Month have 30 days\n");
        break;
    case 10:
        Console.Write("Month have 31 days\n");
        break;
    case 11:
        Console.Write("Month have 30 days\n");
        break;
    case 12:
        Console.Write("Month have 31 days\n");
        break;
    default:
        Console.Write("invalid digit. \nPlease try again ....\n");
        break;
}
*/
//Q24 P2
//    Console.WriteLine("Choose a shape:");
//    Console.WriteLine("1. Circle");
//    Console.WriteLine("2. Rectangle");
//    Console.WriteLine("3. Triangle");
//    Console.Write("Enter your choice: ");
//    int choice = Convert.ToInt32(Console.ReadLine());
//    switch (choice)
//    {
//        case 1:
//            CalculateCircleArea();
//            break;
//        case 2:
//            CalculateRectangleArea();
//            break;
//        case 3:
//            CalculateTriangleArea();
//            break;
//        default:
//            Console.WriteLine("Invalid choice.");
//            break;
//    }
//}
//static void CalculateCircleArea()
//{
//    Console.Write("Enter the radius of the circle: ");
//    double radius = Convert.ToDouble(Console.ReadLine());
//    double area = Math.PI * radius * radius;
//    Console.WriteLine("The area is: " + area.ToString("F"));
//}
//static void CalculateRectangleArea()
//{
//    Console.Write("Enter the length of the rectangle: ");
//    double length = Convert.ToDouble(Console.ReadLine());
//    Console.Write("Enter the width of the rectangle: ");
//    double width = Convert.ToDouble(Console.ReadLine());
//    double area = length * width;
//    Console.WriteLine("The area is: " + area.ToString("F"));
//}
//static void CalculateTriangleArea()
//{
//    Console.Write("Enter the base of the triangle: ");
//    double bas = Convert.ToDouble(Console.ReadLine());
//    Console.Write("Enter the height of the triangle: ");
//    double height = Convert.ToDouble(Console.ReadLine());
//    double area = 0.5 * bas * height;
//    Console.WriteLine("The area is: " + area.ToString("F"));
//}
//Q1 P3
/*
Console.Write("Input string  :");
string x = Console.ReadLine();
Console.WriteLine("The string you entered is :"+x);
*/
//Q2 P3
/*
bool flag = true;
int i = 0;
Console.Write("Input string  :");
string x = Console.ReadLine();
while (flag)
{
    try
    {
        if (x[i] == '0')
        {
            flag = false;

        }
    }
    catch {
        Console.WriteLine(i);
        break;

    }
    i++;

}
*/
//Q3 P3
/*
Console.Write("Input string  :");
string x = Console.ReadLine();
for (int i = 0;i<x.Length;i++)
    Console.Write(x[i]+" ");
*/

//Q4 P3
/*
Console.Write("Input the string: ");
string inputString = Console.ReadLine();
Console.WriteLine("The characters of the string in reverse are:");
for (int i = inputString.Length - 1; i >= 0; i--)
{
    Console.Write(inputString[i] + " ");
}
Console.WriteLine();
*/

//Q5 P3
/*
Console.Write("Input the string: ");
string inputString = Console.ReadLine();
Console.WriteLine("Total number of words in the string is: " + inputString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length);
*/
//Q6 P3
/*
Console.Write("Input the 1st string: ");
string str1 = Console.ReadLine();
Console.Write("Input the 2nd string: ");
string str2 = Console.ReadLine();
if (str1.Length != str2.Length)
{
    Console.WriteLine("The length of both strings is not equal.");
}
else
{
    bool equal = true;
    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] != str2[i])
        {
            equal = false;
            break;
        }
    }

    if (equal)
    {
        Console.WriteLine("The length of both strings are equal and both strings are equal.");
    }
    else
    {
        Console.WriteLine("The length of both strings are equal, but the strings are not equal.");
    }
}
*/
//Q7 P3
/*
Console.Write("Input the 1st string: ");
string inputString = Console.ReadLine();
int alphabetCount = 0;
int digitCount = 0;
int specialCharCount = 0;
foreach (char c in inputString)
{
    if (char.IsLetter(c))
    {
        alphabetCount++;
    }
    else if (char.IsDigit(c))
    {
        digitCount++;
    }
    else
    {
        specialCharCount++;
    }
}
Console.WriteLine("Number of Alphabets in the string is: " + alphabetCount);
Console.WriteLine("Number of Digits in the string is: " + digitCount);
Console.WriteLine("Number of Special Characters in the string is: " + specialCharCount);
*/
//Q8 P3
/*
Console.Write("Input the string: ");
string inputString = Console.ReadLine();
// Create a new string and copy the input string to it
string copiedString = string.Copy(inputString);
// Output the original and copied strings
Console.WriteLine("The First string is: " + inputString);
Console.WriteLine("The Second string is: " + copiedString);
// Output the number of characters copied
int numCharactersCopied = inputString.Length;
Console.WriteLine("Number of characters copied: " + numCharactersCopied);
*/
//Q9 P3
/*
Console.WriteLine("Enter the string: ");
string input = Console.ReadLine();
int vowelCount = 0;
int consonantCount = 0;
foreach (char c in input)
{
    if (Char.IsLetter(c))
    {
        if ("aeiou".Contains(c))
            vowelCount++;
        else
            consonantCount++;
    }
}
Console.WriteLine("The total number of vowels in the string is: " + vowelCount);
Console.WriteLine("The total number of consonants in the string is: " + consonantCount);
*/
//Q10 P3
/*
Console.Write("Input the string: ");
string input = Console.ReadLine();
int[] charCount = new int[128];
int maxCount = 0;
char maxChar = '\0';
foreach (char c in input)
{
    if (char.IsLetter(c))
    {
        charCount[c]++;
        if (charCount[c] > maxCount)
        {
            maxCount = charCount[c];
            maxChar = c;
        }
    }
}
Console.WriteLine("The Highest frequency of character '" + maxChar + "'");
Console.WriteLine("appears number of times: " + maxCount);
*/
//Q11 P3
/*
 Console.Write("Input the string: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Array.Sort(words);
            Console.Write("After sorting the string appears like: ");
            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    Console.Write(c + " ");
                }
            }
            Console.WriteLine(); "
*/
//Q12 P3
/*
Console.Write("Input number of strings: ");
int numStrings = int.Parse(Console.ReadLine());
string[] strings = new string[numStrings];

Console.WriteLine("Input " + numStrings + " strings below:");
for (int i = 0; i < numStrings; i++)
    strings[i] = Console.ReadLine();
for (int i = 0; i < numStrings - 1; i++)
    for (int j = 0; j < numStrings - i - 1; j++)
        if (string.Compare(strings[j], strings[j + 1]) > 0)
        {
            string temp = strings[j];
            strings[j] = strings[j + 1];
            strings[j + 1] = temp;
        }
Console.WriteLine("After sorting, the array appears like:");
foreach (string str in strings)
    Console.WriteLine(str);
*/
//Q13 P3
//    Console.WriteLine("Input the string:");
//    string inputString = Console.ReadLine();
//    Console.WriteLine("Input the position to start extraction:");
//    int startPosition = int.Parse(Console.ReadLine());
//    Console.WriteLine("Input the length of substring:");
//    int length = int.Parse(Console.ReadLine());
//    string substring = ExtractSubstring(inputString, startPosition, length);
//    Console.WriteLine("The substring retrieved from the string is: " + substring);
//}
//static string ExtractSubstring(string inputString, int startPosition, int length)
//{
//    char[] chars = new char[length];

//    for (int i = 0; i < length; i++)
//    {
//        chars[i] = inputString[startPosition + i];
//    }

//    return new string(chars);
//}
//Q14 P3
//Console.WriteLine("Input the string:");
//string inputString = Console.ReadLine();
//Console.WriteLine("Input the substring to search:");
//string substring = Console.ReadLine();
//bool isSubstringPresent = inputString.Contains(substring);
//Console.WriteLine(isSubstringPresent ? "The substring exists in the string." : "The substring does not exist in the string.");
//Q15 P3
//Console.WriteLine("Input the string:");
//string inputString = Console.ReadLine();
//string convertedString = "";
//foreach (char c in inputString)
//{
//    if (char.IsLower(c))
//    {
//        convertedString += char.ToUpper(c);
//    }
//    else if (char.IsUpper(c))
//    {
//        convertedString += char.ToLower(c);
//    }
//    else
//    {
//        convertedString += c;
//    }
//}
//Console.WriteLine("After conversion, the string is: " + convertedString);
//Q16 P3
//string validUsername = "user";
//string validPassword = "pass";
//Console.WriteLine("Input a username:");
//string username = Console.ReadLine();
//Console.WriteLine("Input a password:");
//string password = Console.ReadLine();
//bool isPasswordCorrect = username == validUsername && password == validPassword;
//Console.WriteLine(isPasswordCorrect ? "Password entered successfully!" : "Invalid username or password.");
//Q17 P3
//Console.WriteLine("Input a String:");
//string inputString = Console.ReadLine();
//Console.WriteLine("Input a substring to be found in the string:");
//string substring = Console.ReadLine();
//int position = inputString.IndexOf(substring);
//if (position != -1)
//{
//    Console.WriteLine("Found '" + substring + "' in '" + inputString + "' at position " + position);
//}
//else
//{
//    Console.WriteLine("Substring '" + substring + "' not found in '" + inputString + "'");
//}
//Q18 P3
//Console.WriteLine("Input a character:");
//char ch = Console.ReadKey().KeyChar;
//if (char.IsLetter(ch))
//{
//    if (char.IsUpper(ch))
//    {
//        Console.WriteLine("\nThe character is uppercase.");
//    }
//    else if (char.IsLower(ch))
//    {
//        Console.WriteLine("\nThe character is lowercase.");
//    }
//}
//else
//{
//    Console.WriteLine("\nThe character is not an alphabet.");
//}
//Q19 P3
//Console.WriteLine("Input the original string:");
//string originalString = Console.ReadLine();
//Console.WriteLine("Input the string to be searched for:");
//string searchString = Console.ReadLine();
//int count = 0;
//int index = 0;
//while ((index = originalString.IndexOf(searchString, index)) != -1)
//{
//    count++;
//    index += searchString.Length;
//}
//Console.WriteLine("The string '" + searchString + "' occurs " + count + " times");
//Q120 P3
//Console.WriteLine("Input the original string: ");
//string originalString = Console.ReadLine();
//Console.WriteLine("Input the string to be searched for: ");
//string searchString = Console.ReadLine();
//Console.WriteLine("Input the string to be inserted: ");
//string insertedString = Console.ReadLine();
//string modifiedString = originalString.Replace(searchString, insertedString+" " + searchString);
//Console.WriteLine("The modified string is: " + modifiedString);
//Q21 P3
//Console.WriteLine("Enter the first string:");
//string str1 = Console.ReadLine();
//Console.WriteLine("Enter the second string:");
//string str2 = Console.ReadLine();
//Console.WriteLine("Enter the first substring:");
//string sub1 = Console.ReadLine();
//Console.WriteLine("Enter the second substring:");
//string sub2 = Console.ReadLine();
//int result = String.Compare(sub1, sub2);
//if (result < 0)
//{
//    Console.WriteLine("Substring '" + sub1 + "' in '" + str1 + "' is less than substring '" + sub2 + "' in '" + str2 + "'.");
//}
//else if (result > 0)
//{
//    Console.WriteLine("Substring '" + sub1 + "' in '" + str1 + "' is greater than substring '" + sub2 + "' in '" + str2 + "'.");
//}
//else
//{
//    Console.WriteLine("Substring '" + sub1 + "' in '" + str1 + "' is equal to substring '" + sub2 + "' in '" + str2 + "'.");
//}
//Q22 P3
//string str1 = "Hello World";
//string str2 = "hello world";
//bool isSameIgnoreCase = string.Compare(str1, 0, str2, 0, 5, StringComparison.OrdinalIgnoreCase) == 0;
//bool isSameCaseSensitive = string.Compare(str1, 0, str2, 0, 5, StringComparison.Ordinal) == 0;
//Console.WriteLine("Comparison ignoring case: {0}", isSameIgnoreCase ? "Substrings are the same" : "Substrings are different");
//Console.WriteLine("Comparison considering case: {0}", isSameCaseSensitive ? "Substrings are the same" : "Substrings are different");
//Q23 P3
//    string str1 = "cafÃ©";
//    string str2 = "cafe";
//    CultureInfo culture = new CultureInfo("en-US", false);
//    bool isSameIgnoreCase = string.Compare(str1, 0, str2, 0, 4, culture, CompareOptions.IgnoreCase) == 0;
//    Console.WriteLine("Comparison ignoring case using culture: {0}", isSameIgnoreCase ? "Substrings are the same" : "Substrings are different");
//Q24 P3
//Console.WriteLine("Enter the first person's last name:");
//string lastName1 = Console.ReadLine();
//Console.WriteLine("Enter the second person's last name:");
//string lastName2 = Console.ReadLine();
//int comparison = string.Compare(lastName1, lastName2, StringComparison.OrdinalIgnoreCase);
//Console.WriteLine("Sorted alphabetically by last name:");
//if (comparison <= 0)
//{
//    Console.WriteLine("First person: " + lastName1);
//    Console.WriteLine("Second person: " + lastName2);
//}
//else
//{
//    Console.WriteLine("First person: " + lastName2);
//    Console.WriteLine("Second person: " + lastName1);
//}
//Q25 P3
//string[] words = { "encyclopedia", "Encyclopedia", "ENCYCLOPEDIA" };
//bool currentCultureCaseSensitive = string.Equals(words[0], words[1], StringComparison.CurrentCulture);
//bool currentCultureIgnoreCase = string.Equals(words[0], words[1], StringComparison.CurrentCultureIgnoreCase);
//bool invariantCultureCaseSensitive = string.Equals(words[0], words[1], StringComparison.InvariantCulture);
//bool invariantCultureIgnoreCase = string.Equals(words[0], words[1], StringComparison.InvariantCultureIgnoreCase);
//bool ordinalCaseSensitive = string.Equals(words[0], words[1], StringComparison.Ordinal);
//bool ordinalIgnoreCase = string.Equals(words[0], words[1], StringComparison.OrdinalIgnoreCase);
//Console.WriteLine("case = Case (CurrentCulture): " + currentCultureCaseSensitive);
//Console.WriteLine("case = Case (CurrentCultureIgnoreCase): " + currentCultureIgnoreCase);
//Console.WriteLine("case = Case (InvariantCulture): " + invariantCultureCaseSensitive);
//Console.WriteLine("case = Case (InvariantCultureIgnoreCase): " + invariantCultureIgnoreCase);
//Console.WriteLine("case = Case (Ordinal): " + ordinalCaseSensitive);
//Console.WriteLine("case = Case (OrdinalIgnoreCase): " + ordinalIgnoreCase);
//Q1 P4
/*
for (int i = 1; i <= 10 ; i++)
    Console.Write(i+" ");
*/
//Q2 P4
/*
int sum = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");
    sum += i;
}
Console.WriteLine("\n"+sum);
*/
//Q3 P4
/*
Console.Write("enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    Console.Write(i + " ");
    sum += i;
}
Console.WriteLine("\n" + sum);
*/
//Q4 P4
/*
int sum = 0;
int number;
for (int i = 0; i < 10; i++)
{
    Console.Write("enter  number ");
    number = Convert.ToInt32(Console.ReadLine());
    sum += number;
}
Console.WriteLine("\n sum is :" + sum);
Console.WriteLine("\n avg is :" + sum/10.0);
*/
//Q5 P4
/*
Console.Write("enter  term ");
int term = Convert.ToInt32(Console.ReadLine());
int number;
for (int i = 0; i < term; i++)
{
    Console.Write("enter  number ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Number is : {0} and cube of the {0} is :{1} " ,number,(number*number*number));
}
*/
//Q6 P4
/*
Console.Write("enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
 
    Console.WriteLine("\n {0} X {1} = {2} ", number, i,i*number);
}
*/
//Q7 P4
/*
Console.Write("enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{for (int j = 1; j <= 10; j++)
 Console.Write("\n {0} X {1} = {2}  ",i , j , i * j);
    Console.WriteLine("");
}
*/
//Q8 P4
/*
 
Console.Write("enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum=0;
int count = 0;
while (number > count)
{ if (i % 2 == 1)
    {
        Console.Write(i + " ");
        sum += i;
        i += 2;
    }
    count++;
    
}
Console.Write("\n sum is :" + sum);
*/
//Q9 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numbers; i++)
{
    for (int k = 0; k <  i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/
//Q10 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < numbers; i++)
{
    for (int k = 1; k < i + 1; k++)
    {
        Console.Write(k);
    }
    Console.WriteLine();
}
*/
//Q11 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < numbers; i++)
{
    for (int k = 1; k < i + 1; k++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}
*/
//Q12 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 1; i < numbers; i++)
{
    for (int k = 1; k < i + 1; k++)
    {
        Console.Write(count+" ");
        count++;
    }
    Console.WriteLine();
}
*/
//Q13 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int count = 1;
int spec = numbers + 4 - 1;
for (int i = 1; i < numbers; i++)
{
    for (int j = spec; j >= 1; j--)
    {
        Console.Write(" ");

    }
    for (int k = 1; k < i + 1; k++)
    {

        Console.Write(count +" ");
        count++;
        
    }
    spec--;
    Console.WriteLine();
}
*/
//Q14 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int spec = numbers + 4 - 1;
for (int i = 1; i < numbers; i++)
{
    for (int j = spec; j >= 1; j--)
    {
        Console.Write(" ");

    }
    for (int k = 1; k < i + 1; k++)
    {

        Console.Write("* ");

    }
    spec--;
    Console.WriteLine();
}
*/
//Q15 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());
float Factorial(int f)
{
    if (f == 0)
        return 1;
    else
        return f * Factorial(f - 1);
}
Console.WriteLine(Factorial(numbers));
*/
//Q16 P4
/*
Console.Write("enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
int sum = 0;
int count = 0;
while (number > count)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        sum += i;
        i += 2;
    }
    count++;

}
Console.Write("\n sum is :" + sum);
*/
//Q17 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int spec = numbers + 4 - 1;
for (int i = 1; i < numbers; i++)
{
    for (int j = spec; j >= 1; j--)
    {
        Console.Write(" ");

    }
    for (int k = 1; k < i + 1; k++)
    {

        Console.Write(i +" ");

    }
    spec--;
    Console.WriteLine();
}
*/
//Q18 P4
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
float sum = 1;
int temp = 2;

float Factorial(int f)
{
    if (f == 0)
        return 1;
    else
        return f * Factorial(f - 1);
}
for (int i = 2; i < number+1; i++)
{ if (i % 2 == 0)
    { 
    sum = sum + (-1 * (Convert.ToInt32(Math.Pow(x, temp))) / (float)(Factorial(temp)));
    temp += 2; }
    else
    {
        sum = sum + ( ((Convert.ToInt32(Math.Pow(x, temp))) / (float)(Factorial(temp))));
        temp += 2;

    }
    Console.WriteLine(sum);
}
Console.WriteLine("resulte :" + sum);
*/

//Q19 P4
/*Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());
double resulte = 0;
for (int i = 1; i <= numbers; i++)
{
    Console.Write(1+"/"+i+" + ");
    resulte += 1 /(float) i;
}
Console.Write("your resulte is "+resulte);
*/
//Q20 P4
/*
 Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numbers; i++)
{
    for (int k = 0; k < 2 * i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/
//Q21 P4
/*
Console.Write("Input the number of terms: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num = 9;
for (int i = 0; i < numbers; i++)
{
    sum += num;
    Console.Write(num + " ");
    num = num * 10 + 9;
}
Console.WriteLine("\nThe sum of the series = " + sum);
*/
//Q22 P4
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if ((i + j) % 2 == 0)
            Console.Write(1);
        else Console.Write(0);

    }

    Console.WriteLine("");
}
*/
//Q23 P4
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
float sum = 1 + x;
int temp = 2;

 float Factorial(int f)
{
    if (f == 0)
        return 1;
    else
        return f * Factorial(f - 1);
}

    for (int i =0 ; i < number; i++)
{
    
    sum += (Convert.ToInt32(Math.Pow(x, temp)))/ (Factorial(temp));
    temp++;
}
Console.WriteLine("resulte :" + sum);
*/
//Q24 P4
/*
Console.Write("Enter  term ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter  number ");
int x = Convert.ToInt32(Console.ReadLine());
float sum = x;
int temp = 3;

float Factorial(int f)
{
    if (f == 0)
        return 1;
    else
        return f * Factorial(f - 1);
}
for (int i = 2; i < number + 1; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + (-1 * (Convert.ToInt32(Math.Pow(x, temp))));
        temp += 2;
    }
    else
    {
        sum = sum + (((Convert.ToInt32(Math.Pow(x, temp)))));
        temp += 2;

    }
    Console.WriteLine(sum);
}
Console.WriteLine("resulte :" + sum);
*/
//Q25 P4
/*
Console.Write("Enter  number ");
int number = Convert.ToInt32(Console.ReadLine());
int x=0;
for (int i = 1; i <= number; i++)
    x += (i * i)  ;
Console.WriteLine("resulte :" + x);
*/