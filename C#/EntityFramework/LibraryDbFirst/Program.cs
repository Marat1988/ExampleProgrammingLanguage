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
            //GetAllBooks();
            //GetAuthors();
            AddAuthor_2(new Author
            {
                FirstName = "Maxim",
                LastName = "Ponomarev",

            });
            Console.ReadLine();
        }

        static void Test1()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                Author author = new Author { FirstName = "Ray", LastName = "Bradbury" };
                var authorEntry = db.Entry<Author>(author); //получаем объект DbEntityEntry для созданной сущности author, чтобы посмотреть на состояние author
                Console.WriteLine(authorEntry.State);
                //EntityState.Detached
            }
        }

        static void Test2()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                Author author = db.Author.Find(1); //Находим автора с Id=1
                db.Author.Remove(author); //помечаем на удаление автора c Id=1
                db.SaveChanges(); //удаляем автора с Id=1 и выставляем его состояние в Detached
            }
        }

        static void Test3()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                Author author = db.Author.Find(1); //находим автора с Id=1
                db.Entry(author).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges(); //удадаем автора с Id=1 и выставляем его стостояние в Detached
            }
        }

        static void Test4()
        {
            //Создаем сущность, соответствующую существующей записи в БД
            Author author = new Author { Id = 4, FirstName = "Ray", LastName = "Bradbury" };
            using(LibraryEntities db = new LibraryEntities())
            {
                db.Author.Attach(author); //Присоединяем сущность к контексту БД, ее состояние есть Detached
                db.SaveChanges(); //В БД изменения не происходят, а состояние сущности выставляется Unchanged
            }
        }

        static void Test5()
        {
            Author author = new Author
            {
                Id = 4,
                FirstName = "Ray",
                LastName = "Bradbury"
            };
            using(LibraryEntities db = new LibraryEntities())
            {
                db.Entry(author).State = System.Data.Entity.EntityState.Unchanged;
                db.SaveChanges();
            }
        }

        static void Test6()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                Author author = new Author { FirstName = "Ray", LastName = "Bradbury" };
                db.Author.Add(author); //сущности присоединятся к контексту, а ее состояние есть Added
                db.SaveChanges(); //сущность добавлена в БД, а ее состояние изменяется на Unchanged
            }
        }

        static void Test7()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                Author author = new Author
                {
                    FirstName = "Ray",
                    LastName = "Bradbury"
                };
                db.Entry(author).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }

        static void AddAuthor_2(Author author)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Database.Log = MyLogger.EFLog;
                Author a = db.Author.Where((x) => x.FirstName == author.FirstName && x.LastName == author.LastName).FirstOrDefault();
                if (a == null)
                {
                    db.Author.Add(author);
                    db.SaveChanges();
                    Console.WriteLine("New author added: " + author.LastName);
                }
            }
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

        static void GetAllBooks_Old()
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

        //eager loading
        static void GetAllBooks_Old2()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var books = db.Book.Include("Author").ToList<Book>();
                foreach (var a in books)
                {
                    Console.WriteLine("Книга: " + a.Title + " цена: " + a.Price + " автор: " + a.Author.FirstName + "    " + a.Author.LastName);
                }
            }
        }

        static void GetAllBooks()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                var author = (from b in db.Author
                              where (b.LastName.StartsWith("si"))
                              select b).FirstOrDefault<Author>();
                db.Entry(author).Collection("Book").Load();
                foreach (Book book in author.Book)
                {
                    Console.WriteLine("Книга: " + book.Title + " цена: " + book.Price + " автор: " + book.Author.FirstName + "    " + book.Author.LastName);
                }
            }
        }

        //eager loading
        static void GetAllBooks2()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                var books = (from s in db.Book.Include("Author")
                             select s).ToList<Book>();
                foreach (var a in books)
                {
                    Console.WriteLine("Книга: " + a.Title + " цена: " + a.Price + " автор: " + a.Author.FirstName + "    " + a.Author.LastName);
                }
            }
        }

        static void GetAuthors()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                var book = (from b in db.Book
                            where (b.Title.StartsWith("w"))
                            select b).FirstOrDefault<Book>();
                db.Entry(book).Reference(a => a.Author).Load();
                Console.WriteLine("Книга: " + book.Title + " цена: " + book.Price + " автор: " + book.Author.FirstName + "    " + book.Author.LastName);
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

    public class MyLogger
    {
        public static void EFLog(string message)
        {
            Console.WriteLine($"Action performed: {0} ", message);
        }
    }
}
