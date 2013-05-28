using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ProductGroup
{
    static class LogicDoIt
    {
        static List<Danger> d = new List<Danger>();
        static List<Perishable> p = new List<Perishable>();
        static List<License> l = new List<License> ();
        static List<Fragile> f = new List<Fragile>();
        static decimal reckoning = 0;
        static List<ContractingParties> cp = new List<ContractingParties>();

        static LogicDoIt()
	    {
            string[] s1 = new string[] { "Фреон", "15,28", "10", "12" };
            string[] s2 = new string[] { "Фреон", "15,28", "10", "2012,05,01","2013,05,01" };
            string[] s3 = new string[] { "Фреон", "15,28", "10", "1" };
            string[] s4 = new string[] { "Фреон", "15,28", "10", "15" };
            d.Add(new Danger(s1));
            d.Add(new Danger(s1));
            p.Add(new Perishable(s2));
            p.Add(new Perishable(s2));
            l.Add(new License(s3));
            l.Add(new License(s3));
            f.Add(new Fragile(s4));
            f.Add(new Fragile(s4));
	    }
        
        public static void Menu ()
        {
           // Console.Clear();
            Console.WriteLine("Приход (1)");//+
            Console.WriteLine("Продано (2)");//+
            Console.WriteLine("Реализация (3)");//+
            Console.WriteLine("Инвентаризация (4)");//проверки 
            Console.WriteLine("Списание брака (5)");//
            Console.WriteLine("Обзор (6)");//
            string x = Console.ReadLine();

            switch (x)
            { 
                case "1":
                {
                    Add();
                        break;
                }
                case "2":
                {
                    Sale();
                        break;
                }
                case "3":
                {
                    Realese();
                        break;
                }
                case "4":
                {
                    Inventarization();
                        break;
                }
                case "5":
                {
                    Del();
                        break;
                }
                case "6":
                {
                    Print();
                    break;
                }
                default:
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод данных, введите заново");
                    Menu();
                    break;
                }
            }
        }

        static void Print()
        {
            Console.Clear();
            foreach (Danger i in d)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
            foreach (Perishable i in p)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
            foreach (License i in l)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
            foreach (Fragile i in f)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine();
            Menu();
        }

        static void Add()
        {
            Console.Clear();
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
                    Console.WriteLine("Кофициент хрупкости");
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
            Menu();
        }
                
        static void Sale()
        {
            Console.Clear();
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
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine())-1;
                        try
                            {
                                if (d[s0].Count==0)
                                    throw new ENone();
                                if (d[s0].Defect)
                                    throw new EFake();
                            }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }

                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if(s1 <= d[s0].Count)
                        { 
                            reckoning+= s1 * d[s0].Price;
                            d[s0].Count -= s1;
                        }
                        
                        if (s1 > d[s0].Count)
                        {
                            reckoning += d[s0].Count * d[s0].Price;
                            d[s0].Count = 0;
                        }
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        foreach (Perishable i in p)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            if (p[s0].Count == 0)
                                throw new ENone();
                            if (p[s0].Defect)
                                throw new EFake();
                            if (p[s0].Start == p[s0].End)
                                throw new EDate();
                        }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }
                        catch (EDate ex) { Console.WriteLine(ex.Message); break; }

                        if (s1 <= p[s0].Count)
                        {
                            reckoning += s1 * p[s0].Price;
                            p[s0].Count -= s1;
                        }

                        if (s1 > p[s0].Count)
                        {
                            reckoning += l[s0].Count * p[s0].Price;
                            p[s0].Count = 0;
                        }
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        foreach (License i in l)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;

                        try
                        {
                            if (l[s0].Count == 0)
                                throw new ENone();
                            if (l[s0].Defect)
                                throw new EFake();
                        }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }

                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 <= l[s0].Count)
                        {
                            reckoning += s1 * l[s0].Price;
                            l[s0].Count -= s1;
                        }

                        if (s1 > l[s0].Count)
                        {
                            reckoning += l[s0].Count * l[s0].Price;
                            l[s0].Count = 0;
                        }
                        
                       
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        foreach (Fragile i in f)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;

                        try
                        {
                            if (f[s0].Count == 0)
                                throw new ENone();
                            if (f[s0].Defect)
                                throw new EFake();
                        }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }

                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());

                        if (s1 <= f[s0].Count)
                        {
                            reckoning += s1 * f[s0].Price;
                            f[s0].Count -= s1;
                        }

                        if (s1 > f[s0].Count)
                        {
                            reckoning += f[s0].Count * f[s0].Price;
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
            Menu();
        }

        static void Realese()
        {
            Console.Clear();
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
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        try
                        {
                            if (d[s0].Count == 0)
                                throw new ENone();
                            if (d[s0].Defect)
                                throw new EFake();
                        }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }

                        Console.WriteLine("Введите кол-во");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        if (s1 < d[s0].Count)
                            {
                                Console.WriteLine("Введите данные контрагента\n");
                                Console.WriteLine("Имя ");
                                s[0] = Console.ReadLine();
                                Console.WriteLine("Телефон");
                                s[1] = Console.ReadLine();
                                s[2] = Convert.ToString(s1 * d[s0].Price);

                                cp.Add(new ContractingParties(s));
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
                            d[s0].Count = 0;
                        }
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        foreach (Perishable i in p)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        try
                        {
                            if (p[s0].Count == 0)
                                throw new ENone();
                            if (p[s0].Defect)
                                throw new EFake();
                            if (p[s0].Start == p[s0].End)
                                throw new EDate();
                        }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }
                        catch (EDate ex) { Console.WriteLine(ex.Message); break; }


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
                            p[s0].Count = 0;
                        }
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        foreach (License i in l)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        try
                        {
                            if (l[s0].Count == 0)
                                throw new ENone();
                            if (l[s0].Defect)
                                throw new EFake();
                        }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }
                        
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
                            l[s0].Count = 0;
                        }
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        foreach (Fragile i in f)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s0 = Convert.ToInt32(Console.ReadLine()) - 1;
                        try
                        {
                            if (f[s0].Count == 0)
                                throw new ENone();
                            if (f[s0].Defect)
                                throw new EFake();
                        }
                        catch (ENone ex) { Console.WriteLine(ex.Message); break; }
                        catch (EFake ex) { Console.WriteLine(ex.Message); break; }

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
            Menu();
        }

        static void Inventarization()
        {
            Console.Clear();
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
                            Console.WriteLine(i.ToString());
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
                        Console.Clear();
                        for (int i = 0; i < l.Count; i++)
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(l[i].Number)))
                            {
                                l[i].Defect = true;
                            }
                        }
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        foreach (Fragile i in f)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("Введите индекс товара:");
                        s = Convert.ToInt32(Console.ReadLine()) - 1;
                        f[s].Defect = true;  
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
            Menu();
        }

        static void Del()
        {
            Console.Clear();
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
                        Print();
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
                        Print();
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
                        Print();
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
                        Print();
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
            Console.ReadKey();
            Menu();
        }

    }
}

