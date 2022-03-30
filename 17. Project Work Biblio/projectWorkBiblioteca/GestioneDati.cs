using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace projectWorkBiblioteca
{
    public class GestioneDati
    {
        public Dictionary<string, User> Users;
        public Dictionary<string, Libro> Books;
        public List<Prestito> Prestiti;
        public GestioneDati()
        {
            Users = new Dictionary<string, User>();
            Books = new Dictionary<string, Libro>();
            Prestiti = new List<Prestito>();
            
            ReadUsers();
            ReadBooks();
            ReadPrestiti();
        }
        void ReadUsers()
        {
            string json = File.ReadAllText("users.json");
            List<User> usersList = JsonConvert.DeserializeObject<List<User>>(json);
            UpdateUsersDictionary(usersList);
        }
        void ReadBooks()
        {
            string json = File.ReadAllText("books.json");
            List<Libro> booksList = JsonConvert.DeserializeObject<List<Libro>>(json);
            UpdateBooksDictionary(booksList);
        }
        void ReadPrestiti()
        {
            string json = File.ReadAllText("prestiti.json");
            Prestiti = JsonConvert.DeserializeObject<List<Prestito>>(json);
        }
        public void UpdateUsersDictionary(List<User> usersList)
        {
            Users.Clear();
            foreach (var user in usersList)
            {
                Users.Add(user.Code, user);
            }
        }
        public void UpdateBooksDictionary(List<Libro> booksList)
        {
            Books.Clear();
            foreach (var book in booksList)
            {
                Books.Add(book.ISBN, book);
            }
        }
        public void WriteUsers()
        {
            string json = JsonConvert.SerializeObject(Users.Values.ToList(), Formatting.Indented);
            File.WriteAllText("users.json", json);
        }
        public void WriteBooks()
        {
            string json = JsonConvert.SerializeObject(Books.Values.ToList(), Formatting.Indented);
            File.WriteAllText("books.json", json);
        }
        public void WritePrestiti()
        {
            string json = JsonConvert.SerializeObject(Prestiti, Formatting.Indented);
            File.WriteAllText("prestiti.json", json);
        }
    }
}
