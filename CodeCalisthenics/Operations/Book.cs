using System;

namespace CodeCalisthenics.Operations
{
    public class BookSolution
    {
        private static void Execute()
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }

    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    class MyBook : Book
    {
        private readonly int price;
        public MyBook(string t, string a, int price) : base(t, a)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: "+this.title);
            Console.WriteLine("Author: "+this.author);
            Console.WriteLine("Price: "+this.price);
        }
    }

    
}
