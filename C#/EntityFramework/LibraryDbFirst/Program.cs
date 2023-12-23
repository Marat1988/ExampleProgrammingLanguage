using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author author = new Author{FirstName = "Issac", LastName = "Azimov"};
            //AddAuthor(author);
            //GetAllAuthors();
           // Init();
            GetAllBooks();
            Console.ReadLine();
        }

        static void AddPublisher(Publisher publisher)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                Publisher a = db.Publisher.Where((x) => x.PublisherName == publisher.PublisherName).FirstOrDefault();
                if (a == null)
                {
                    db.Publisher.Add(publisher);
                    db.SaveChanges();
                    Console.WriteLine("New publisher added:" + publisher.PublisherName);
                }
            }
        }

        static void AddBook(Book book)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                Book a = db.Book.Where((x) => x.Title == book.Title).FirstOrDefault();
                if (a == null)
                {
                    db.Book.Add(book);
                    db.SaveChanges();
                    Console.WriteLine("New book added:" + book.Title);
                }
            }
        }

        static void Init()
        {
            Author author = new Author
            {
                FirstName = "Ray",
                LastName = "Bradbury"
            };
            AddAuthor(author);
            author = new Author
            {
                FirstName = "Harry",
                LastName = "Harrison"
            };
            AddAuthor(author);
            author = new Author
            {
                FirstName = "Clifford",
                LastName = "Simak"
            };
            AddAuthor(author);

            Publisher publisher = new Publisher
            {
                PublisherName = "Rainbow",
                Address = "Kyiv"
            };
            AddPublisher(publisher);
            publisher = new Publisher
            {
                PublisherName = "Exlibris",
                Address = "Kyiv"
            };
            AddPublisher(publisher);
            Book book = new Book
            {
                Title = "Way Station",
                IdPublisher = 1,
                IdAuthor = 4,
                Pages = 350,
                Price = 85
            };
            AddBook(book);
            book = new Book
            {
                Title = "Ring Around the Sun",
                IdPublisher = 1,
                IdAuthor = 4,
                Pages = 420,
                Price = 99
            };
            AddBook(book);
            book = new Book
            {
                Title = "The Martian Chronicles",
                IdPublisher = 2,
                IdAuthor = 2,
                Pages = 410,
                Price = 105
            };
            AddBook(book);
            book = new Book
            {
                Title = "I, Robot",
                IdPublisher = 3,
                IdAuthor = 1,
                Pages = 378,
                Price = 100
            };
            AddBook(book);
        }

        static void GetAllBooks()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var au = db.Book.OrderBy((x) => x.Title).ToList();
                foreach (var a in au)
                {
                    Console.WriteLine("Book: " + a.Title + " price: " + a.Price + " author: " + a.Author.FirstName + "    " + a.Author.LastName);
                }
            }
        }


        static void AddAuthor(Author author)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                db.Author.Add(author);
                db.SaveChanges();

                Console.WriteLine("New author added:" + author.LastName);
            }
        }

        static void GetAllAuthors()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var au = db.Author.ToList();
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName+" "+a.LastName);
                }
            }
        }

        static Author GetAuthorByName(string fname)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var author = (from s in db.Author
                              where s.FirstName == fname
                              select s).FirstOrDefault<Author>();
                return author;
            }
        }

        static Author GetAuthorByName1(string fname)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var author = db.Author.Where((x) => x.FirstName == fname).FirstOrDefault();
                return author;
            }
        }

        static Author GetAuthorById(int id)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var author = (from s in db.Author
                              where s.Id == id
                              select s).Single();
                return author;
            }
        }

        static Author GetAuthorById1(int id)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var author = db.Author.Where((x) => x.Id == id).SingleOrDefault();
                return author;
            }
        }

        static void GetAllAuthors2()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var au = db.Author.Where((x) => x.LastName.StartsWith("A")).ToList();
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName + " " + a.LastName);
                }
            }
        }

        static void GetAllAuthors1()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var au = (from a in db.Author
                          where a.LastName.StartsWith("A")
                          select a).ToList();
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName + " " + a.LastName);
                }
            }
        }

        static void GetAllAuthors3()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var au = (from a in db.Author
                          orderby a.LastName ascending
                          select a).ToList();
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName + " " + a.LastName);
                }
            }
        }

        static void GetAllAuthor4()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var au = db.Author.OrderBy((x) => x.LastName).ToList();
                foreach (var a in au)
                {
                    Console.WriteLine(a.FirstName + " " + a.LastName);
                }
            }
        }

        static Author GetAuthorById5(int id)
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var au = db.Author.Find(id);
                Console.WriteLine(au.FirstName + " " + au.LastName);
                return au;
            }
        }

  
    }
}
