using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {

                #region CreateDB
                //List<Group> groups = new List<Group>()
                //{
                //    new Group(){ Name = "Rammstein", Year = 1994},
                //    new Group(){ Name = "Linkin Park", Year = 1996}
                //};

                //context.Groups.AddRange(groups);
                //context.SaveChanges();

                //List<Song> songs = new List<Song>()
                //{
                //    new Song(){ Name = "In the end", GroupID = 2},
                //    new Song(){ Name = "Numb", GroupID = 2}
                //};

                //context.Songs.AddRange(songs);
                //context.SaveChanges();

                //foreach (var group in groups)
                //{
                //    Console.WriteLine($"id = {group.ID} Name = {group.Name} Year = {group.Year}");
                //}

                //foreach (var song in songs)
                //{
                //    Console.WriteLine($"id = {song.ID} Name = {song.Name} Group = {song.Group?.Name}");
                //} 
                #endregion

                var groups  = context.Groups.Where(item => item.ID == 3);

                foreach (var item in groups)
                {
                    Console.WriteLine(item);
                }

                var seconElem = context.Groups.First();

                Console.WriteLine(seconElem);

                //Console.WriteLine(group);

                //foreach (var group in context.Groups)
                //{
                //    Console.WriteLine(group.Name);
                //}

                //foreach (var group in context.Groups)
                //{
                //    if (group.ID == 2)
                //        context.Groups.Remove(group);
                //}

                context.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
