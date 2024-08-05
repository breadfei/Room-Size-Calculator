Console.WriteLine("Welcome to the room size calculator.");

//getting length, width, and height
Console.WriteLine("Please enter the length of the room: ");
double roomLength = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the width of the room: ");
double roomWidth = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the height of the room: ");
double roomHeight = double.Parse(Console.ReadLine());

//calculating area, perimeter, volume, surface area
double roomArea = roomLength * roomWidth;
double roomPerimeter = (roomLength * 2) + (roomWidth * 2);
double roomVolume = roomLength * roomWidth * roomHeight;
double roomSurfaceArea = 2 * ((roomWidth * roomLength) + (roomHeight * roomLength) + (roomHeight * roomWidth));

//displaying values
Console.WriteLine($"The area of the room is {roomArea}.");
Console.WriteLine($"The perimeter of the room is {roomPerimeter}.");
Console.WriteLine($"The volume of the room is {roomVolume}.");
Console.WriteLine($"The surface area of the room is {roomSurfaceArea}.");

//classifying room size
if (roomArea < 0 || roomArea > 999999)
{
    Console.WriteLine("This room cannot be classified.");
}
else if (roomArea <= 250)
{
    Console.WriteLine("This room is small.");
}
else if (roomArea > 250 && roomArea < 650)
{
    Console.WriteLine("This room is medium-sized.");
}
else
{
    Console.WriteLine("This room is large.");
}
Console.WriteLine("Thank you for using the room size calculator.");