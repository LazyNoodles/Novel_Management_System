using System;
using System.Collections.Generic;
using System.Linq;

namespace NovelManagementSystem
{
    public static class NovelManage
    {
        public static void AddNovel(List<Novel> novels)
        {
            Console.Write("Enter novel ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter publisher: ");
            string publisher = Console.ReadLine();
            Console.WriteLine("Choose type: 1. Fantasy 2. Historical 3. Thriller");
            string type = Console.ReadLine();

            Novel novel;
            switch (type)
            {
                case "1":
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter number of pages: ");
                    int pages = int.Parse(Console.ReadLine());
                    novel = new Fantasy(id, publisher, author, pages);
                    break;
                case "2":
                    Console.Write("Enter type: ");
                    string historicalType = Console.ReadLine();
                    Console.Write("Enter year: ");
                    int year = int.Parse(Console.ReadLine());
                    novel = new Historical(id, publisher, historicalType, year);
                    break;
                case "3":
                    Console.Write("Enter number of volumes: ");
                    int volumes = int.Parse(Console.ReadLine());
                    novel = new Thriller(id, publisher, volumes);
                    break;
                default:
                    Console.WriteLine("Invalid type. Novel not added.");
                    return;
            }

            novels.Add(novel);
            Console.WriteLine("Novel added successfully.");
        }

        public static void ShowAllNovels(List<Novel> novels)
        {
            foreach (var novel in novels)
            {
                Console.WriteLine(novel);
            }
        }

        public static void ShowAllFantasyNovels(List<Novel> novels)
        {
            var fantasyNovels = novels.OfType<Fantasy>();
            foreach (var novel in fantasyNovels)
            {
                Console.WriteLine(novel);
            }
        }

        public static void FindNovelByID(List<Novel> novels)
        {
            Console.Write("Enter novel ID: ");
            int id = int.Parse(Console.ReadLine());
            var novel = novels.FirstOrDefault(n => n.ID == id);
            if (novel != null)
            {
                Console.WriteLine(novel);
            }
            else
            {
                Console.WriteLine("Novel not found.");
            }
        }

        public static void DeleteNovelByID(List<Novel> novels)
        {
            Console.Write("Enter novel ID: ");
            int id = int.Parse(Console.ReadLine());
            var novel = novels.FirstOrDefault(n => n.ID == id);
            if (novel != null)
            {
                novels.Remove(novel);
                Console.WriteLine("Novel deleted successfully.");
            }
            else
            {
                Console.WriteLine("Novel not found.");
            }
        }

        public static void UpdateNovelByID(List<Novel> novels)
        {
            Console.Write("Enter novel ID: ");
            int id = int.Parse(Console.ReadLine());
            var novel = novels.FirstOrDefault(n => n.ID == id);
            if (novel != null)
            {
                Console.Write("Enter new publisher: ");
                novel.Publisher = Console.ReadLine();
                if (novel is Fantasy fantasy)
                {
                    Console.Write("Enter new author: ");
                    fantasy.Author = Console.ReadLine();
                    Console.Write("Enter new number of pages: ");
                    fantasy.Pages = int.Parse(Console.ReadLine());
                }
                else if (novel is Historical historical)
                {
                    Console.Write("Enter new type: ");
                    historical.Type = Console.ReadLine();
                    Console.Write("Enter new year: ");
                    historical.Year = int.Parse(Console.ReadLine());
                }
                else if (novel is Thriller thriller)
                {
                    Console.Write("Enter new number of volumes: ");
                    thriller.Volumes = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Novel updated successfully.");
            }
            else
            {
                Console.WriteLine("Novel not found.");
            }
        }
    }
}
