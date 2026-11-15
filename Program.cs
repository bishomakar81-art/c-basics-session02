using System.ComponentModel.Design;
using System.Reflection;
# region Q1,Q2

Book b01 = new Book();

 b01.Title = "c# basics";
 b01.pages = 50;
Console.WriteLine(b01.Title + "  " + b01.pages);

Book b02 = new Book();
b02.Title = "c# basics";
b02 .pages = 50;
  Console.WriteLine(b02.pages.ToString());
  Console.WriteLine(b01.Title.Equals(b02.Title));
  Console.WriteLine(b02.pages.GetHashCode());
  Console.WriteLine(b01.pages.GetType());
class Book
{
    public string Title;
    public int pages;
}
#endregion

#region Q3
string pagesText = "464";   //compilation-time error

int pages = Convert.ToInt32(pagesText);
Console.WriteLine (pages);
#endregion

#region Q4
try

{
    int division =0;
    int result = 10 / division;


}
catch (DivideByZeroException)
{
    Console.WriteLine("cannot divided by zero");

}
finally
{
    Console.WriteLine("done");
}
#endregion

#region Q5
int pages02 = 300;
double numbers = pages; // implicit conversion
 
Console.WriteLine(pages);
#endregion

#region Q6
double price = 49.99;
int newPrice = (int)price;
Console.WriteLine(newPrice); //explict conversion
#endregion


#region Q7

string yearText = "2023";
int newYearText = int.Parse(yearText);

string BadText = "abc ";
if (int.TryParse(BadText, out int number)) 
{
    Console.WriteLine (number);

}
else
{
    Console.WriteLine("invalid number ");
}
#endregion
#region Q8
int pages03 = 464;
Console.WriteLine(pages02.ToString());
Console.WriteLine(pages02.GetType());
#endregion

#region Q9
int copies = 100;

object obj = copies; //boxing 

int newcopies = (int)obj;// unboxing

Console.WriteLine(copies);
Console.WriteLine(newcopies);
#endregion 
