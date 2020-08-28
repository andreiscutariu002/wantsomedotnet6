﻿namespace _11.Linq.Day2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    class UserWithCompany
    {
        public string UserName { get; set; }

        public string CompanyName { get; set; }
    }

    class UserPosts
    {
        public int UserId { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // o lista de utilizatori
            List<User> users = ReadUsers("users.json");

            // o lista de postari pt fiecare user
            List<Post> posts = ReadPosts("posts.json");

            // 1 - find all users having email ending with ".net".

            // where
            // https://www.tutorialsteacher.com/linq/linq-filtering-operators-where

            IEnumerable<User> studentsWithDotNet = from user in users
                                                   where user.Email.EndsWith(".net") // boolean condition
                                                   select user; // select x => o sa avem un IEnumerable de tipul lui x

            IEnumerable<User> studentsWithDotNet_2 =
                users
                    .Where(user => user.Email.EndsWith(".net"))
                    .Select(user => user);

            Console.WriteLine(studentsWithDotNet.Count());

            // 1.1 - ids of users having email ending with ".net".

            // select
            // https://www.tutorialsteacher.com/linq/linq-projection-operators

            IEnumerable<int> idsOfStudentsWithDotNet = from user in users
                                                       where user.Email.EndsWith(".net") // boolean condition
                                                       select user.Id; // select x => o sa avem un IEnumerable de tipul lui x

            IEnumerable<int> idsOfStudentsWithDotNet_2 =
                users
                    .Where(user => user.Email.EndsWith(".net"))
                    .Select(user => user.Id);

            foreach (var i in idsOfStudentsWithDotNet)
            {
                Console.WriteLine(i);
            }

            // 1.2 - emails of users having email ending with ".net".

            IEnumerable<string> emailsOfUsersWithNet = from user in users
                                                       where user.Email.EndsWith(".net")
                                                       select user.Email;

            var emailsOfUsersWithNet_2 = users.Where(user => user.Email.EndsWith(".net")).Select(x => x.Email);

            foreach (var i in emailsOfUsersWithNet)
            {
                Console.WriteLine(i);
            }

            // 1.3 - companies of users having email ending with ".net".

            IEnumerable<Company> companiesOfUsersWithNet = from user in users
                                                           where user.Email.EndsWith(".net")
                                                           select user.Company;

            foreach (var company in companiesOfUsersWithNet)
            {
                Console.WriteLine(company.Name);
            }

            // 1.4 - name of companies of users having email ending with ".net".

            IEnumerable<string> nameOfCompaniesOfUsersWithNet = from user in users
                                                                where user.Email.EndsWith(".net")
                                                                select user.Company.Name;

            foreach (var company in nameOfCompaniesOfUsersWithNet)
            {
                Console.WriteLine(company);
            }

            // 1.5 - name of user + name of company of users having email ending with ".net".
            // added a new class UserWithCompany
            // proiectia dorita [user name + company name]

            var nameOfUserAndCompany = from user in users
                                       where user.Email.EndsWith(".net")
                                       select new UserWithCompany()
                                       {
                                           UserName = user.Name,
                                           CompanyName = user.Company.Name
                                       };

            var nameOfUserAndCompany_2 = 
                users
                    .Where(user => user.Email.EndsWith(".net"))
                    .Select(user =>
                        new UserWithCompany
                        {
                            CompanyName = user.Company.Name,
                            UserName = user.Name
                        });

            // 1.6 - website + phone of  users having email ending with ".net".
            // anonymous objects
            var websiteAndPhone = from user in users
                                  where user.Email.EndsWith(".net")
                                  select new
                                  {
                                      Phone = user.Phone,
                                      Website = user.Website
                                  };

            var websiteAndPhone_2 = users
                .Where(user => user.Email.EndsWith(".net"))
                .Select(user => new {
                    Phone = user.Phone,
                    Website = user.Website
                });

            foreach (var o in websiteAndPhone)
            {
                Console.Write(o.Website);
                Console.WriteLine(o.Phone);
                Console.WriteLine();
            }

            var xxx = 0;

            // 2 - find all posts for users having email ending with ".net".

            IEnumerable<int> listOfUserIDs = from user in users
                                             where user.Email.EndsWith(".net")
                                             select user.Id;

            IEnumerable<Post> listOfPostsForIdV1 = from post in posts
                                                   where CheckPostUserIdInList(listOfUserIDs, post)  // defined function
                                                   select post;


            Func<IEnumerable<int>, Post, bool> predicate = (userIds, post) =>
            {
                foreach (var userId in userIds)
                {
                    if (userId == post.UserId)
                    {
                        return true;
                    }
                }

                return false;
            };

            IEnumerable<Post> listOfPostsForIdV2 = from post in posts
                                                   where predicate(listOfUserIDs, post) // local func
                                                   select post;

            IEnumerable<Post> listOfPostsForIdV3 = from post in posts
                                                   where listOfUserIDs.Contains(post.UserId)  //linq
                                                   select post;

            Console.WriteLine(listOfPostsForIdV3.Count());

            // 3 - print number of posts for each user.

            var listOfUsers = from user in users
                select new UserPosts()
                {
                    UserId = user.Id,
                    Posts = from post in posts
                        where user.Id.Equals(post.UserId)
                        select post
                };

            foreach (UserPosts userPosts in listOfUsers)
            {
                Console.WriteLine($"user: {userPosts.UserId}, nr posts: {userPosts.Posts.Count()}");
            }

            // 4 - find all users that have lat and long negative.


            // 5 - find the post with longest body.


            // 6 - print the name of the employee that have post with longest body.


            // 7 - select all addresses in a new List<Address>. print the list.


            // 8 - print the user with min lat


            // 9 - print the user with max long


            // 10 - create a new class: public class UserPosts { public User User {get; set}; public List<Post> Posts {get; set} }
            //    - create a new list: List<UserPosts>
            //    - insert in this list each user with his posts only

            // 11 - order users by zip code

            // 12 - order users by number of posts
        }

        private static bool CheckPostUserIdInList(IEnumerable<int> listOfUserIDs, Post post)
        {
            //option
            //return listOfUserIDs.Contains(post.UserId);

            foreach (var userId in listOfUserIDs)
            {
                if (post.UserId == userId)
                {
                    return true;
                }
            }

            return false;
        }

        private static List<Post> ReadPosts(string file)
        {
            return ReadData.ReadFrom<Post>(file);
        }

        private static List<User> ReadUsers(string file)
        {
            return ReadData.ReadFrom<User>(file);
        }
    }
}
