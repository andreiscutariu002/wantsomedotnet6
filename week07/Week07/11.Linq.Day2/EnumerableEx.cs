namespace _11.Linq.Day2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class EnumerableEx
    {
        public void Run(List<User> users)
        {
            // selectie
            // return type este un IEnumerable
            IEnumerable<int> idsEnumerable = users.Select(user =>
            {
                Console.WriteLine($"### Enumeram useri, suntem la: {user.Id}");
                return user.Id;
            });

            // ids (IEnumerable) user ids nu exista [query-ul nu a fost materializat]
            // ids nu ocupa spatiu inca
            // ids ocupa spatiu doar pentru [users.Select(user => user.Id)]
            // ids nu are inca date 

            // IEnumerable se materializeaza [option 1]
                // - IEnumerable se materializeaza cand este iterat (se face foreach)

                // se intampla o iteratie

            var first = idsEnumerable.First();

            //var firstAndSecond = idsEnumerable.Take(2).ToList();
            
            var _3_4 = idsEnumerable.Skip(4).Take(2).ToList();
                
            foreach (var id in idsEnumerable)
            {
                Console.WriteLine($"--- Printam useri, suntem la: {id}");
            }

            // IEnumerable se materializeaza [option 2]
                // transfromam din IEnumerable catre o lista
                // idsList ocupa memorie pentru ids
            
            List<int> idsList = idsEnumerable.ToList();


            // IEnumerable se materializeaza [option 3]
                // facem un count, un max, un min

            var count = idsEnumerable.Count();
        }

        public void RunV2(List<User> users)
        {
            // return type este un IEnumerable
            IEnumerable<int> idsEnumerable = users.Select(user =>
            {
                Console.WriteLine($"### Enumeram useri, suntem la: {user.Id}");
                return user.Id;
            });

            if (DateTime.Now.Day == 1)
            {
                idsEnumerable = idsEnumerable.Where(i => i > 5);
            }

            // materialized o data
            var idList = idsEnumerable.ToList();

            foreach (var id in idList)
            {
                Console.WriteLine($"--- Printam useri, suntem la: {id}");
            }

            List<int> idsList = idList.ToList();

            var count = idList.Count; // count() - materializez // count - o prop deja materializata
        }
    }
}
