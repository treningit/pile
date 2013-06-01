using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductGroup
{
    static class LogicDoIt
    {
        static List<Danger> d;
        static List<Perishable> p;
        static List<License> l;
        static List<Fragile> f;
        static decimal reckoning;
        static List<ContractingParties> cp;
       
        static LogicDoIt ()
	    {
            d.Add(new Danger());
            p.Add(new Perishable());
            l.Add(new License());
            f.Add(new Fragile());
            reckoning = 0;
	    }
        
        static void Menu ()
        {
            Console.WriteLine("Приход (1)");//+
            Console.WriteLine("Продано (2)");//-
            Console.WriteLine("Реализация (3)");//-
            Console.WriteLine("Инвентаризация (4)");//проверки 
            Console.WriteLine("Списание брака (5)");//
            
        
        }



        static void Print()
        {
            Console.Clear();
            foreach (Danger i in d)
            {
                i.ToString();
            }
            Console.WriteLine();
            foreach (Perishable i in p)
            {
                i.ToString();
            }
            Console.WriteLine();
            foreach (License i in l)
            {
                i.ToString();
            }
            Console.WriteLine();
            foreach (Fragile i in f)
            {
                i.ToString();
            }
            Console.WriteLine();
        }

        static void Add()
        {
            Console.WriteLine("Добавление товара\n");
            Console.WriteLine("Опасный (1)");
            Console.WriteLine("Скоропортящийся (2)");
            Console.WriteLine("Лицензионый(3)");
            Console.WriteLine("Хрупкий (4)");
            Console.WriteLine("Главное меню (0)");

            string x = Console.ReadLine();
            string[] s = new string[5];

            switch(x)
            {
                case "1":
                {
                    Console.Clear();
                    
                    Console.WriteLine("Название ");
                    s[0] = Console.ReadLine();
                    Console.WriteLine("Цена ");
                    s[1] = Console.ReadLine();
                    Console.WriteLine("Кол-во");
                    s[2] = Console.ReadLine();
                    Console.WriteLine("Категория опасности");
                    s[3] = Console.ReadLine();
                    
                    d.Add(new Danger(s));
                    break;
                }
                case "2":
                {
                    Console.Clear();

                    Console.WriteLine("Название ");
                    s[0] = Console.ReadLine();
                    Console.WriteLine("Цена ");
                    s[1] = Console.ReadLine();
                    Console.WriteLine("Кол-во");
                    s[2] = Console.ReadLine();
                    Console.WriteLine("Конечный срок годности");
                    s[3] = Console.ReadLine();
                    Console.WriteLine("Дата изготовления");
                    s[4] = Console.ReadLine();

                    p.Add(new Perishable(s));
                    break;
                }
                case "3":
                {
                    Console.Clear();

                    Console.WriteLine("Название ");
                    s[0] = Console.ReadLine();
                    Console.WriteLine("Цена ");
                    s[1] = Console.ReadLine();
                    Console.WriteLine("Кол-во");
                    s[2] = Console.ReadLine();
                    Console.WriteLine("Номер лицензии");
                    s[3] = Console.ReadLine();

                    l.Add(new License(s));
                    break;
                }
                case "4":
                {
                    Console.Clear();

                    Console.WriteLine("Название ");
                    s[0] = Console.ReadLine();
                    Console.WriteLine("Цена ");
                    s[1] = Console.ReadLine();
                    Console.WriteLine("Кол-во");
                    s[2] = Console.ReadLine();
                    Console.WriteLine("Категория опасности");
                    s[3] = Console.ReadLine();

                    f.Add(new Fragile(s));
                    break;
                }
                case "0":
                {
                    Console.Clear();
                    Menu();
                    break;
                }
                default:
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод данных, введите заново");
                    Add();
                    break;
                }
            }
        }
                
        static void Sale()
        {

            Console.WriteLine("Продажи товара\n");
            Console.WriteLine("Опасный (1)");
            Console.WriteLine("Скоропортящийся (2)");
            Console.WriteLine("Лицензионый(3)");
            Console.WriteLine("Хрупкий (4)");
            Console.WriteLine("Главное меню (0)");

            string x = Console.ReadLine();
            int s0;
            int s1;

            switch (x)
            {
                case "1":
                    {
                        Console.Clear();
                        foreach (Danger i in d)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine())-1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if(s1 < d[s0].Count)
                        { 
                            reckoning+= s1 * d[s0].Price;
                            //--------------------проверка на брак
                            d[s0].Count -= s1;
                        }
                        
                        if (s1 > d[s0].Count)
                        {
                            reckoning += d[s0].Count * d[s0].Price;
                            //--------------------проверка на брак
                            d[s0].Count = 0;
                        }
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        foreach (Perishable i in p)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 < p[s0].Count)
                        {
                            reckoning += s1 * p[s0].Price;
                            //--------------------проверка на брак
                            p[s0].Count -= s1;
                        }

                        if (s1 > l[s0].Count)
                        {
                            reckoning += l[s0].Count * p[s0].Price;
                            //--------------------проверка на брак
                            p[s0].Count = 0;
                        }
                        
                        
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        foreach (License i in l)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 < l[s0].Count)
                        {
                            reckoning += s1 * l[s0].Price;
                            //--------------------проверка на брак
                            l[s0].Count -= s1;
                        }

                        if (s1 > l[s0].Count)
                        {
                            reckoning += l[s0].Count * l[s0].Price;
                            //--------------------проверка на брак
                            l[s0].Count = 0;
                        }
                        
                       
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        foreach (Fragile i in f)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 < f[s0].Count)
                        {
                            reckoning += s1 * f[s0].Price;
                            //--------------------проверка на брак
                            l[s0].Count -= s1;
                        }

                        if (s1 > f[s0].Count)
                        {
                            reckoning += f[s0].Count * f[s0].Price;
                            //--------------------проверка на брак
                            f[s0].Count = 0;
                        }
                        
                        break;
                    }
                case "0":
                    {
                        Console.Clear();
                        Menu();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод данных, введите заново");
                        Sale();
                        break;
                    }
            }
        
        
        }

        static void Realese()
        {

            Console.WriteLine("Реализация товара\n");
            Console.WriteLine("Опасный (1)");
            Console.WriteLine("Скоропортящийся (2)");
            Console.WriteLine("Лицензионый(3)");
            Console.WriteLine("Хрупкий (4)");
            Console.WriteLine("Главное меню (0)");

            string x = Console.ReadLine();
            int s0;
            int s1;
            string [] s = new string [3];
            switch (x)
            {
                case "1":
                    {
                        Console.Clear();
                        foreach (Danger i in d)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 < d[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(s1*d[s0].Price);

                            cp.Add(new ContractingParties (s));
                            //--------------------проверка на брак
                            d[s0].Count -= s1;
                        }

                        if (s1 > d[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(d[s0].Count * d[s0].Price);

                            cp.Add(new ContractingParties(s));
                            //--------------------проверка на брак
                            d[s0].Count = 0;
                        }
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        foreach (Perishable i in p)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 < p[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(s1 * p[s0].Price);

                            cp.Add(new ContractingParties(s));
                            //--------------------проверка на брак
                            p[s0].Count -= s1;
                        }

                        if (s1 > p[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(p[s0].Count * p[s0].Price);

                            cp.Add(new ContractingParties(s));
                            //--------------------проверка на брак
                            p[s0].Count = 0;
                        }
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        foreach (License i in l)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 < l[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(s1 * l[s0].Price);

                            cp.Add(new ContractingParties(s));
                            //--------------------проверка на брак
                            l[s0].Count -= s1;
                        }

                        if (s1 > l[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(l[s0].Count * l[s0].Price);

                            cp.Add(new ContractingParties(s));
                            //--------------------проверка на брак
                            l[s0].Count = 0;
                        }
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        foreach (Fragile i in f)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 < f[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(s1 * f[s0].Price);

                            cp.Add(new ContractingParties(s));
                            //--------------------проверка на брак
                            f[s0].Count -= s1;
                        }

                        if (s1 > f[s0].Count)
                        {
                            Console.WriteLine("Введите данные контрагента\n");
                            Console.WriteLine("Имя ");
                            s[0] = Console.ReadLine();
                            Console.WriteLine("Телефон");
                            s[1] = Console.ReadLine();
                            s[2] = Convert.ToString(f[s0].Count * f[s0].Price);

                            cp.Add(new ContractingParties(s));
                            //--------------------проверка на брак
                            f[s0].Count = 0;
                        }
                        break;
                    }
                case "0":
                    {
                        Console.Clear();
                        Menu();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод данных, введите заново");
                        Realese();
                        break;
                    }
            }


        }

        static void Inventarization()
        {
            Console.WriteLine("Инвентаризация товара\n");
            Console.WriteLine("Опасный (1)");//+
            Console.WriteLine("Скоропортящийся (2)");//+
            Console.WriteLine("Лицензионый(3)");//isNull Empity
            Console.WriteLine("Хрупкий (4)");//1
            Console.WriteLine("Главное меню (0)");

            string x = Console.ReadLine();
            int s;

            switch (x)
            {
                case "1":
                    {
                        Console.Clear();
                        foreach (Danger i in d)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s = Convert.ToInt32(Console.ReadLine()) - 1;
                        d[s].Defect = true;                       
                       break;
                    }
                case "2":
                    {
                        Console.Clear();
                        for (int i = 0; i < p.Count; i++)
			            {
                            if (p[i].End == p[i].Start)
                            {
                              p[i].Defect = true;
                            }
			            }
                        break;
                    }
                case "3":
                    {
                        /*string q;
                        Console.Clear();
                        for (int i = 0; i < l.Count; i++)
                        {
                            q.
                            if (Convert.ToString(l[i].Number).)
                            {
                                p[i].Defect = true;
                            }
                        }
                        break;*/
                    }
                case "4":
                    {
                        Console.Clear();
                        foreach (Danger i in d)
                        {
                            i.ToString();
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s = Convert.ToInt32(Console.ReadLine()) - 1;
                        d[s].Defect = true;  
                        break;
                    }
                case "0":
                    {
                        Console.Clear();
                        Menu();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод данных, введите заново");
                        Inventarization();
                        break;
                    }
            }
        
        }

        static void Del()
        {
            Console.WriteLine("Списание брака:\n");
            Console.WriteLine("Опасный (1)");
            Console.WriteLine("Скоропортящийся (2)");
            Console.WriteLine("Лицензионый(3)");
            Console.WriteLine("Хрупкий (4)");
            Console.WriteLine("Главное меню (0)");

            string x = Console.ReadLine();
            string[] s = new string[5];

            switch (x)
            {
                case "1":
                    {
                        Console.Clear();
                        for (int i = 0; i < d.Count; i++)
                        {
                            if (d[i].Defect)
                            {
                                d.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("Брак по категории 'Опасный' списан. Оставшийся товар:\n");
                        d.Print();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        for (int i = 0; i < p.Count; i++)
                        {
                            if (p[i].Defect)
                            {
                                p.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("Брак по категории 'Скоропортящиеся' списан. Оставшийся товар:\n");
                        p.Print();
                        break;
                    }
                case "3":
                    {
                        Console.Clear();

                        for (int i = 0; i < l.Count; i++)
                        {
                            if (l[i].Defect)
                            {
                                l.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("Брак по категории 'Лицензионный' списан. Оставшийся товар:\n");
                        l.Print();
                        break;
                    }
                case "4":
                    {
                        Console.Clear();

                        for (int i = 0; i < f.Count; i++)
                        {
                            if (f[i].Defect)
                            {
                                f.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("Брак по категории 'Хрупкий' списан. Оставшийся товар:\n");
                        f.Print();
                        break;
                    }
                case "0":
                    {
                        Console.Clear();
                        Menu();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод данных, введите заново");
                        Del();
                        break;
                    }
            }
        }
        /*  try
            {
                if (Длина массива ==0)
                    throw new ENone();
            }
            catch (ENone ex) { Console.WriteLine(ex.Message); }*/
    }
}

