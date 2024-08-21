using System;
using System.Collections.Generic;

namespace NovelManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Novel> novels = new List<Novel>();
            while (true)
            {
                Console.WriteLine("1. Add a new novel");
                Console.WriteLine("2. Show all novels");
                Console.WriteLine("3. Show all Fantasy novels");
                Console.WriteLine("4. Find a novel by ID");
                Console.WriteLine("5. Delete a novel by ID");
                Console.WriteLine("6. Update a novel by ID");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        NovelManage.AddNovel(novels);
                        break;
                    case "2":
                        NovelManage.ShowAllNovels(novels);
                        break;
                    case "3":
                        NovelManage.ShowAllFantasyNovels(novels);
                        break;
                    case "4":
                        NovelManage.FindNovelByID(novels);
                        break;
                    case "5":
                        NovelManage.DeleteNovelByID(novels);
                        break;
                    case "6":
                        NovelManage.UpdateNovelByID(novels);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
