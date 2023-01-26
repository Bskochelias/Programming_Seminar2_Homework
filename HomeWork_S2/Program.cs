// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// По двум заданным числам проверять является ли одно квадратом другого
// Задать номер четверти, показать диапазоны для возможных координат
// Найти расстояние между точками в пространстве 2D/3D




int otvet = 1;
string otvet2 = " ";
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine(" ");
    Console.WriteLine("Добрый день прошу выбрать цифру из списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным");
    Console.WriteLine("2. По двум заданным числам проверять является ли одно квадратом другого");
    Console.WriteLine("3. Задать номер четверти, показать диапазоны для возможных координат");
    Console.WriteLine("4. Найти расстояние между точками в пространстве 2D");
    Console.WriteLine("5. Найти расстояние между точками в пространстве 3D");
    Console.WriteLine("__________");
    Console.WriteLine(" ");

    otvet = Convert.ToInt32(Console.ReadLine());


  } while (otvet > 5 ^ otvet < 1);

  Console.Clear();

  //1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
  if (otvet == 1)
    {
      int a1;
      Console.Write("Введите число: ");
      a1 = Convert.ToInt32(Console.ReadLine());
    }  



  Console.Write(" Нажмите <Enter> для продолжения... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  do
  {
    Console.Clear();
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();
    if (otvet2 != "No" && otvet2 != "no" && otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y")
    {Console.WriteLine("Не коректный ответ");
    Console.Write(" Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
  }
  while (otvet2 != "No" && otvet2 != "no" & otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y");


}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO" & otvet2 !="n" & otvet2 !="N");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write(" Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();
