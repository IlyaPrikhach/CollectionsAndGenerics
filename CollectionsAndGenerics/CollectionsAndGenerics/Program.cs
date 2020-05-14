using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndGenerics
{
    class Program
    {
        static void Main()
        {

            firstMethod(out CollectionType<Dictionary<int, int>> collectionType, out List<Dictionary<int, int>> allCollections);
            Console.ReadLine();
        }

        static void firstMethod(out CollectionType<Dictionary<int, int>> collectionType, out List<Dictionary<int, int>> allCollections)
        {
            Dictionary<int, int> numbers1 = new Dictionary<int, int>();
            Dictionary<int, int> numbers2 = new Dictionary<int, int>();
            Dictionary<int, int> numbers3 = new Dictionary<int, int>();
            Dictionary<int, int> numbers4 = new Dictionary<int, int>();
            NumColl num1 = new NumColl(numbers1);
            NumColl num2 = new NumColl(numbers2);
            NumColl num3 = new NumColl(numbers3);
            NumColl num4 = new NumColl(numbers4);


            allCollections = new List<Dictionary<int, int>>() { numbers1, numbers2, numbers3, numbers4 };

            collectionType = new CollectionType<Dictionary<int, int>>(allCollections);

            collectionType.CollectionEntry(allCollections[0], 1);
            collectionType.CollectionEntry(allCollections[1], 2);
            collectionType.CollectionEntry(allCollections[2], 3);
            collectionType.CollectionEntry(allCollections[3], 4);

            Chois(collectionType, allCollections);
        }
        static void Chois(CollectionType<Dictionary<int, int>> collectionType, List<Dictionary<int, int>> allCollections)
        {
            Console.WriteLine("Выберите операцию\n1) Ввод данных в коллекцию\n2) Удаление данных из коллекции\n" +
           "3) Просмотр данных коллекции\n4) Запись данных коллекции в файл\n5) Сортировка коллекции\n" +
           "6) Найти максимальную и минимальную коллекцию в массиве, содержащую данный элемент\n7) Найти коллекции с отрицательными элементами\n8) Закончить\n" +
           "------------------------------------------------------------------------------------------------------------------------");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                collForEntry(collectionType, allCollections);
            }
            else if (ch == "2")
            {
                collForRemove(collectionType, allCollections);
            }
            else if (ch == "3")
            {
                collForView(collectionType, allCollections);

            }
            else if (ch == "4")
            {

            }
            else if (ch == "5")
            {

            }
            else if (ch == "6")
            {

            }
            else if (ch == "7")
            {

            }
            else if (ch == "8")
            {
                finish();
            }
            else
            {
                Console.WriteLine("Возможно вы ввели неверный пункт, попробуйте снова");
                Console.Clear();
                Chois(collectionType, allCollections);
            }

        }

        static int finish()
        {
            Console.Clear();
            return 0;
        }


        static void collForEntry(CollectionType<Dictionary<int, int>> collectionType, List<Dictionary<int, int>> allCollections)
        {
            Console.WriteLine("В какую коллекцию вы хотите произвести дозапись?(1/2/3/4)");
            string entryCh = Console.ReadLine();
            if (entryCh == "1")
            {
                collectionType.CollectionEntry(allCollections[0], 1);

            }
            else if (entryCh == "2")
            {
                collectionType.CollectionEntry(allCollections[1], 2);

            }
            else if (entryCh == "3")
            {
                collectionType.CollectionEntry(allCollections[2], 3);
            }
            else if (entryCh == "4")
            {
                collectionType.CollectionEntry(allCollections[3], 4);
            }
            else
            {
                Console.WriteLine("Такой коллекции не существует, попробуйте снова");
                collForEntry(collectionType, allCollections);
            }

            Chois(collectionType, allCollections);
        }

        static void collForRemove(CollectionType<Dictionary<int, int>> collectionType, List<Dictionary<int, int>> allCollections)
        {
            Console.WriteLine("Элемены из какой коллекции вы хотите удалить?(1/2/3/4)");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                collectionType.CollectionRemove(allCollections[0], 1);
            }
            else if (ch == "2")
            {
                collectionType.CollectionRemove(allCollections[0], 1);

            }
            else if (ch == "3")
            {
                collectionType.CollectionRemove(allCollections[0], 1);

            }
            else if (ch == "4")
            {
                collectionType.CollectionRemove(allCollections[0], 1);

            }
            else
            {
                Console.WriteLine("Такой коллекции не существует, попробуйте снова");
                collForRemove(collectionType, allCollections);
            }
            Chois(collectionType, allCollections);
        }

        static void collForView(CollectionType<Dictionary<int, int>> collectionType, List<Dictionary<int, int>> allCollections)
        {
            Console.WriteLine("Элемены из какой коллекции вы хотите просмотреть?(1/2/3/4)");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                collectionType.CollectionView(allCollections[0], 1);
            }
            else if (ch == "2")
            {
                collectionType.CollectionView(allCollections[0], 1);

            }
            else if (ch == "3")
            {
                collectionType.CollectionView(allCollections[0], 1);

            }
            else if (ch == "4")
            {
                collectionType.CollectionView(allCollections[0], 1);

            }
            else
            {
                Console.WriteLine("Такой коллекции не существует, попробуйте снова");
                collForView(collectionType, allCollections);
            }
            Chois(collectionType, allCollections);
        }

    }




    class CollectionType<T>
    {
        public T Id { get; set; }
        List<Dictionary<int, int>> collections;
        public CollectionType(List<Dictionary<int, int>> collections)
        {
            this.collections = collections;
        }
        int n1 = 1;
        int n2 = 1;
        int n3 = 1;
        int n4 = 1;
        public void CollectionEntry(Dictionary<int, int> forEntry, int n)
        {
            try
            {
                Console.WriteLine($"Добавте элементы в {n} коллекцию. Для окончания введите end");
                int i = 0;
                if (n == 1)
                {
                    i = n1;
                }
                else if (n == 2)
                {
                    i = n2;
                }
                else if (n == 3)
                {
                    i = n3;
                }
                else if (n == 4)
                {
                    i = n4;
                }
                for (; ; i++)
                {
                    string numb1 = Console.ReadLine();
                    if (numb1 == "end")
                    {
                        break;
                    }
                    else
                    {
                        forEntry.Add(i, Convert.ToInt32(numb1));
                    }

                }
                if (n == 1)
                {
                    n1 = i;
                }
                else if (n == 2)
                {
                    n2 = i;
                }
                else if (n == 3)
                {
                    n3 = i;
                }
                else if (n == 4)
                {
                    n4 = i;
                }

                foreach (KeyValuePair<int, int> keyValue in forEntry)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
                do
                {
                    Console.WriteLine("Для продолжения нажмите пробел");
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Возможно вы ввели неверное значение, попробуйте снова");
                CollectionEntry(forEntry, n);
            }
        }

        public void CollectionRemove(Dictionary<int, int> forRemove, int n)
        {
            try
            {
                Console.WriteLine($"Какой элемент {n} коллекции вы хотите удалить?(по ключу)");
                int elForRemove = Convert.ToInt32(Console.ReadLine());
                forRemove.Remove(elForRemove);
                foreach (KeyValuePair<int, int> keyValue in forRemove)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
                do
                {
                    Console.WriteLine("Для продолжения нажмите пробел");
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Возможно вы ввели неверное значение, попробуйте снова");
                CollectionRemove(forRemove, n);
            }
        }

        public void CollectionView(Dictionary<int, int> forView, int n)
        {
            foreach (KeyValuePair<int, int> keyValue in forView)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            do
            {
                Console.WriteLine("Для продолжения нажмите пробел");
            }
            while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            Console.Clear();
        }

    }

    class NumColl : IComparable<object>
    {
        public NumColl(Dictionary<int, int> numbers)
        {

        }
        public int CompareTo(object o)
        {
            return 0;
        }
    }


}
