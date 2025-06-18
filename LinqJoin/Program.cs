using LinqJoin;

var authors = new List<Author>
{
    new Author{AuthorId = 1, Name = "Emil Michel Cioran" },
    new Author{AuthorId = 2, Name = "Haruki Murakami"},
    new Author{AuthorId = 3, Name = "Oğuz Atay"},
    new Author{AuthorId =4, Name = "Doğu Yücel"},
    new Author{AuthorId =5, Name = "Italo Calvino"},
    new Author{AuthorId =6, Name = "Fernando Pessoa"},
    new Author{AuthorId = 7, Name = "Ayfer Tunç"}

};

var books = new List<Book>
{
    new Book{BookId = 1, Title = "Gözyaşları ve Azizler", AuthorId = 1 },
    new Book{BookId = 2, Title = "Doğmuş Olmanın Sakıncası Üzerine", AuthorId = 1 },
    new Book{BookId = 3, Title = "Sahilde Kafka", AuthorId = 2 },
    new Book{BookId = 4, Title = "Koşmasaydım Yazamazdım", AuthorId = 2 },
    new Book{BookId = 5, Title = "Tutunamayanlar", AuthorId = 3 },
    new Book{BookId = 6, Title = "Tehlikeli Oyunlar", AuthorId = 3 },
    new Book{BookId = 7, Title = "Varolmayanlar", AuthorId = 4 },
    new Book{BookId = 8, Title = "Görünmez Kentler", AuthorId = 5 },
    new Book{BookId = 9, Title = "Huzursuzluğun Kitabı", AuthorId = 6 },
    new Book{BookId = 10, Title = "Bir Deliler Evinin Yalan Yanlış Anlatılan Kısa Tarihi", AuthorId = 7 }
};

var library = from book in books
              join author in authors
              on book.AuthorId equals author.AuthorId
              select new
              {
                  BookTitle = book.Title,
                  AuthorName = author.Name,
              };

foreach (var book in library)
{
    Console.WriteLine($"Kitap: {book.BookTitle} --- Yazar: {book.AuthorName}");
}
