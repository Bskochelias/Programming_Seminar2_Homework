// Дано число обозначающее день недели. Выяснить является номер дня недели выходным?
// По двум заданным числам проверять является ли одно квадратом другого
// Задать номер четверти, показать диапазоны для возможных координат
// Найти расстояние между точками в пространстве 2D/3D

int Proverca_chisla()
{ 
  int num;
  while (true)
    {var input = Console.ReadLine();

    if (int.TryParse(input, out num))
        break;                                                   // обработка при успехе и выход из цикла
    else                                                         // обработка при ошибке
    {
        Console.WriteLine("[ERROR]: Не коректные данные по пробуйте еще раз!");
        Console.Write("Введите число: ");
    }
    }
  return num;
}

int otvet = 1;
string? otvet2 = " ";
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine(" ");
    Console.WriteLine("Добрый день прошу выбрать цифру из списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным?");
    Console.WriteLine("2. По двум заданным числам проверять является ли одно квадратом другого");
    Console.WriteLine("3. Задать номер четверти, показать диапазоны для возможных координат");
    Console.WriteLine("4. Найти расстояние между точками в пространстве 2D");
    Console.WriteLine("5. Найти расстояние между точками в пространстве 3D");
    Console.WriteLine("__________");
    Console.WriteLine(" ");

    otvet = Proverca_chisla();

    if (otvet > 5 ^ otvet < 1)
    {
      Console.WriteLine("Такой задачи тут нету!");
      Console.Write("Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}      
    }

  } while (otvet > 5 ^ otvet < 1);

  Console.Clear();

//Начало тела задач
  //1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным?
  if (otvet == 1)
    {
      int a1;
      Console.Write("Введите число обозначающее день недели: ");
      a1 = Proverca_chisla();
            
      switch(a1)
        {
          case 1 : Console.WriteLine("Это день недели Понедельник!"); break;
          case 2 : Console.WriteLine("Это день недели Вторник!"); break;
          case 3 : Console.WriteLine("Это день недели Среда!"); break;
          case 4 : Console.WriteLine("Это день недели Четверг!"); break;
          case 5 : Console.WriteLine("Это день недели Пятница!"); break;
          case 6 : Console.WriteLine("Это день недели Суббота!"); break;
          case 7 : Console.WriteLine("Это день недели Воскресенье!"); break;
        }

      if (a1 < 1 ^ a1 > 7) 
        {
          Console.WriteLine("Такого дня недели нету!");
        }
      else
        {
          if (a1 == 6 ^ a1 == 7) 
            {Console.WriteLine("Это выходной день!");}
          else
            {Console.WriteLine("Это не выходной день!");}
        }

    }

  //2. По двум заданным числам проверять является ли одно квадратом другого
  if (otvet == 2)
    {
      int a2, b2;
      Console.Write("Введите первое число для проверки является ли одно квадратом другого: ");
      a2 = Proverca_chisla();
      Console.Write("Введите второе число: ");
      b2 = Proverca_chisla();

      if (Math.Sqrt(a2) == b2)
        {
          Console.WriteLine("Первое число является квадратом второго!");
        }
        else
        {
          if (Math.Sqrt(b2) == a2)
          {
            Console.WriteLine("Второе число является квадратов первого!");
          }
          else
          {
            Console.WriteLine("Ни одно из чисел не является квадратом другого числа.");
          }
        }
    }

  //3. Задать номер четверти, показать диапазоны для возможных координат
  if (otvet == 3)
    {
      int a3, x=0, y=0;
      while (x < 40)
        {
          if(x!=20)
          { Console.SetCursorPosition(x, 5);
            Console.WriteLine("*");
          }
          x++;
        }

      while (y < 11)
        { Console.SetCursorPosition(20, y);
          Console.WriteLine("*");
          y++;
        }
      
      Console.SetCursorPosition(30, 2);
      Console.WriteLine("1");

            Console.SetCursorPosition(10, 2);
      Console.WriteLine("2");

      Console.SetCursorPosition(10, 8);
      Console.WriteLine("3");

      Console.SetCursorPosition(30, 8);
      Console.WriteLine("4");

      Console.SetCursorPosition(1, 12);
      Console.Write("Введите номер четверти: ");
      a3 = Proverca_chisla();
      
      Console.Clear();
      switch(a3)
      {
        case 1: {Console.WriteLine("Возможные кардинаты по x от +1 до +∞, по y от +1 до +∞ "); break;}
        case 2: {Console.WriteLine("Возможные кардинаты по x от -1 до -∞, по y от +1 до +∞ "); break;}
        case 3: {Console.WriteLine("Возможные кардинаты по x от -1 до -∞, по y от -1 до -∞ "); break;}
        case 4: {Console.WriteLine("Возможные кардинаты по x от +1 до +∞, по y от -1 до -∞ "); break;}
        default: {Console.WriteLine("Такой четверти нет!"); break;}
      }
    }

  //4. Найти расстояние между точками в пространстве 2D
  // AB = √(xb - xa)2 + (yb - ya)2 - формула

  if (otvet == 4)
    {
      int xa4, ya4,
          xb4, yb4;
      double  rast;

      Console.Write("Введите X кординаты первой точки: ");
      xa4 = Proverca_chisla();

      Console.Write("Введите Y кординаты первой точки: ");
      ya4 = Proverca_chisla();

      Console.Write("Введите X кординаты второй точки: ");
      xb4 = Proverca_chisla();

      Console.Write("Введите Y кординаты второй точки: ");
      yb4 = Proverca_chisla();
      
      rast = Math.Sqrt((xb4-xa4)*(xb4-xa4)+(yb4-ya4)*(yb4-ya4));

      Console.WriteLine($"Растояние между двумя точками {rast}");

    }

//Конец тела задач    
  Console.Write("Нажмите <Enter> для продолжения... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  do
  {
    Console.Clear();
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

    if (otvet2 != "No" && otvet2 != "no" && otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y")
    {
    Console.WriteLine("Некоректный ответ");
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
Console.Write("Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();
