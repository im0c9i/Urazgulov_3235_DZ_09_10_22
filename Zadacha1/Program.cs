/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2) 
*/

void GetCoordinat(double ferstX, double ferstY, double ferstZ, double secondX, double secondY, double secondZ)
{
    double result = 0;
    double tempX = Math.Pow(ferstX-secondX,2);
    double tempy = Math.Pow(ferstY-secondY,2);
    double tempZ = Math.Pow(ferstZ-secondZ,2);
    result = Math.Sqrt(tempX+tempy+tempZ);
    Console.WriteLine($"Расстояние между тремя точками {result}");

}
GetCoordinat(3,6,8,2,1,-7);