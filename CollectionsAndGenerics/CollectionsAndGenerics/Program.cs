using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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
                collForWrite(collectionType, allCollections);

            }
            else if (ch == "5")
            {
                collForSort(collectionType, allCollections);

            }
            else if (ch == "6")
            {
                collectionType.elemFind(allCollections);
                Chois(collectionType, allCollections);

            }
            else if (ch == "7")
            {
                collectionType.negativeFind(allCollections);
                Chois(collectionType, allCollections);
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
                collectionType.CollectionRemove(allCollections[1], 2);

            }
            else if (ch == "3")
            {
                collectionType.CollectionRemove(allCollections[2], 3);

            }
            else if (ch == "4")
            {
                collectionType.CollectionRemove(allCollections[3], 4);

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
                collectionType.CollectionView(allCollections[1], 2);

            }
            else if (ch == "3")
            {
                collectionType.CollectionView(allCollections[2], 3);

            }
            else if (ch == "4")
            {
                collectionType.CollectionView(allCollections[3], 4);

            }
            else
            {
                Console.WriteLine("Такой коллекции не существует, попробуйте снова");
                collForView(collectionType, allCollections);
            }
            Chois(collectionType, allCollections);
        }

        static void collForWrite(CollectionType<Dictionary<int, int>> collectionType, List<Dictionary<int, int>> allCollections)
        {
            Console.WriteLine("Элемены из какой коллекции вы хотите записать?(1/2/3/4)");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                collectionType.CollectionWrite(allCollections[0], 1);
            }
            else if (ch == "2")
            {
                collectionType.CollectionWrite(allCollections[1], 2);

            }
            else if (ch == "3")
            {
                collectionType.CollectionWrite(allCollections[2], 3);

            }
            else if (ch == "4")
            {
                collectionType.CollectionWrite(allCollections[3], 4);

            }
            else
            {
                Console.WriteLine("Такой коллекции не существует, попробуйте снова");
                collForWrite(collectionType, allCollections);
            }
            Chois(collectionType, allCollections);
        }

        static void collForSort(CollectionType<Dictionary<int, int>> collectionType, List<Dictionary<int, int>> allCollections)

        
        {

            {
                Console.WriteLine("Элемены из какой коллекции вы хотите записать?(1/2/3/4)");
                string ch = Console.ReadLine();
                if (ch == "1")
                {
                    collectionType.CollectionSort(allCollections[0], 1);
                }
                else if (ch == "2")
                {
                    collectionType.CollectionSort(allCollections[1], 2);

                }
                else if (ch == "3")
                {
                    collectionType.CollectionSort(allCollections[2], 3);

                }
                else if (ch == "4")
                {
                    collectionType.CollectionSort(allCollections[3], 4);

                }
                else
                {
                    Console.WriteLine("Такой коллекции не существует, попробуйте снова");
                    collForSort(collectionType, allCollections);
                }
                Chois(collectionType, allCollections);
            }
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
                        forEntry.Add( i, Convert.ToInt32(numb1));
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

        public void CollectionWrite(Dictionary<int, int> forWrite, int n)
        {
            StreamWriter writer = new StreamWriter("Outlet.out");
            writer.WriteLine($"Данные {n} коллекции");

            foreach (KeyValuePair<int, int> keyValue in forWrite)
            {
                writer.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine("Данные были записаны в файл");
            writer.Close();
            do
            {
                Console.WriteLine("Для продолжения нажмите пробел");
            }
            while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            Console.Clear();
        }

        public void CollectionSort(Dictionary<int, int> forSort, int n)
        {
            forSort = forSort.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            Console.WriteLine("Отсортированно по значению");
            foreach (var item in forSort)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            do
            {
                Console.WriteLine("Для продолжения нажмите пробел");
            }
            while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            Console.Clear();
        }

        public void elemFind(List<Dictionary<int,int>> forFind)
        {
            Dictionary<int, int> firstDic = forFind[0];
            Dictionary<int, int> secondDic = forFind[1];
            Dictionary<int, int> thirdDic = forFind[2];
            Dictionary<int, int> forthDic = forFind[3];

            Console.WriteLine("Введите число, которое нужно найти");
            int n = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> first =
                from f in firstDic.Values
                where f == n
                select f;
            IEnumerable<int> second =
                from f in secondDic.Values
                where f == n
                select f;
            IEnumerable<int> third =
                from f in thirdDic.Values
                where f == n
                select f;
            IEnumerable<int> forth =
                from f in forthDic.Values
                where f == n
                select f;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;
            Console.WriteLine("Такая величина есть\n------------------------------------------------------------------------------------------------------------------------");

            int r = 0;
            foreach (int a in first)
            {
                Console.WriteLine("В первой коллекции ");
                x1 = 1;
                r++;
            }
                
            foreach (int a in second)
            {
                Console.WriteLine("Во второй коллекции ");
                x2 = 1;
                r++;
            }
                
            foreach (int a in third)
            {
                Console.WriteLine("В третьей коллекции ");
                x3 = 1;
                r++;
            }
            foreach (int a in forth)
            {
                Console.WriteLine("В четвертой коллекции ");
                x4 = 1;
                r++;
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            int[] nums = new int[r];
            int nr = 0;
            if (x1 == 1)
            {
                x1 = firstDic.Count();
                nums[nr] = x1;
                nr++;
            }
            if (x2 == 1)
            {
                x2 = secondDic.Count();
                nums[nr] = x2;
                nr++;

            }
            if (x3 == 1)
            {

                x3 = thirdDic.Count();
                nums[nr] = x3;
                nr++;

            }
            if (x4 == 1)
            {

                x4 = forthDic.Count();
                nums[nr] = x4;
            }
            if(x1 != 1 && x2 != 1 && x3 != 1 && x4 != 1)
            {
                Console.WriteLine("Коллекций содержащих данный элемент нет");
                
            }

            if (nr != 0)
            {
                int temp;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                Console.WriteLine("Вывод отсортированного массива");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine(nums[i]);
                }
                int min = 0;
                int max = 0;
                if (firstDic.Count == nums[0])
                {
                    min = 1;
                }
                if (secondDic.Count == nums[0])
                {
                    min = 2;
                }
                if (thirdDic.Count == nums[0])
                {
                    min = 3;
                }
                if (forthDic.Count == nums[0])
                {
                    min = 4;
                }

                if (firstDic.Count == nums[nr])
                {
                    max = 1;
                }
                if (secondDic.Count == nums[nr])
                {
                    max = 2;
                }
                if (thirdDic.Count == nums[nr])
                {
                    max = 3;
                }
                if (forthDic.Count == nums[nr])
                {
                    max = 4;
                }



                Console.WriteLine("Минимальная коллекция содержащая этот элемент - " + min + " Содержит " + nums[0] + " элементов" + "\nМаксимальная коллекция содержащая этот элемент - " + max + " содержит " + nums[nr] + " элементов");

            }

            do
            {
                Console.WriteLine("Для продолжения нажмите пробел");
            }
            while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            Console.Clear();
        }

        public void negativeFind(List<Dictionary<int, int>> forFind)
        {
            Dictionary<int, int> firstDic = forFind[0];
            Dictionary<int, int> secondDic = forFind[1];
            Dictionary<int, int> thirdDic = forFind[2];
            Dictionary<int, int> forthDic = forFind[3];

            IEnumerable<int> first =
                from f in firstDic.Values
                where f < 0
                select f;
            IEnumerable<int> second =
                from f in secondDic.Values
                where f < 0
                select f;
            IEnumerable<int> third =
                from f in thirdDic.Values
                where f < 0
                select f;
            IEnumerable<int> forth =
                from f in forthDic.Values
                where f < 0
                select f;

            Console.WriteLine("Отрицательные элементы есть\n------------------------------------------------------------------------------------------------------------------------");

            foreach (int a in first)
            {
                Console.WriteLine("В первой коллекции ");
            }

            foreach (int a in second)
            {
                Console.WriteLine("Во второй коллекции ");
            }

            foreach (int a in third)
            {
                Console.WriteLine("В третьей коллекции ");
            }
            foreach (int a in forth)
            {
                Console.WriteLine("В четвертой коллекции ");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            do
            {
                Console.WriteLine("Для продолжения нажмите пробел");
            }
            while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            Console.Clear();
        }


    }

    class NumColl : IComparable<NumColl>
    {

        Dictionary<int, int> forSort;
        public NumColl(Dictionary<int, int> numbers)
        {
            this.forSort = numbers;
        }
        public int CompareTo(NumColl o)
        {
            return 0;
        }
    }


}
