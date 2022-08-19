Console.WriteLine("Введите целое число А ");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую будет возводиться число А: В =  ");
int B = Convert.ToInt32(Console.ReadLine());

double Degree = 1;
for (int i = 0; i < B + 1; i++)
{
    Degree = Math.Pow(A, B);
}
Console.WriteLine($"Число А в степени B = {Degree}");