//A practice program to find the hypotenuse of a triangle...
Console.WriteLine("Enter one side of the triangle: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter another side of triangle: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a * a) + (b * b));

Console.WriteLine($"The hypotenuse is : {c}");
