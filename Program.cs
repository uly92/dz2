/*

int CutNumber(int num);
{
    int ed = num % 10;
    int sot = num / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random(). Next(100, 1000);
int newNum = CutNumber(randNum);

Console.WriteLine($"New version of number {randNum} is {newNum}");
 */

 // задача 1

/*
Console.WriteLine("Input a three digit number: ");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
*/

// задача 


Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number);
{   
	int result = 0;
    int des;
	if(number > 99)
		des = number % 10;
	 	return result;
}
int thirdDigit = ThirdDigit(number);
Console.WriteLine($"Third Digit of {number} is {thirdDigit}");


// задача 2

/*
Console.Write("Input a number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("third digit -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> no third digit");
}
*/

// 3
/*
Console.Write("Input the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(this day is the day off) -> yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("it's not a day of the week");
  }
  else Console.WriteLine("(it is not a holiday) -> no");
}

CheckingTheDayOfTheWeek(dayNumber);
*/



