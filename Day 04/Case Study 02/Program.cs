using System;

namespace LibraryManagement
{
    public interface IMembership
    {
        void GetBenefits();
    }

    public class StudentMembership : IMembership
    {
        public void GetBenefits()
        {
            Console.WriteLine("Student membership benefits.");
        }
    }

    public class FacultyMembership : IMembership
    {
        public void GetBenefits()
        {
            Console.WriteLine("Faculty membership benefits.");
        }
    }

    public interface IAlert
    {
        void SendAlert();
    }

    public class EmailAlert : IAlert
    {
        public void SendAlert()
        {
            Console.WriteLine("Email alert sent.");
        }
    }

    public class SmsAlert : IAlert
    {
        public void SendAlert()
        {
            Console.WriteLine("SMS alert sent.");
        }
    }

    public interface IReader
    {
        void SearchBook();
        void BorrowBook();
    }

    public interface ILibrarian
    {
        void AddBook();
        void RemoveBook();
    }

    public class Reader : IReader
    {
        public void SearchBook()
        {
            Console.WriteLine("Searching for a book.");
        }

        public void BorrowBook()
        {
            Console.WriteLine("Borrowing a book.");
        }
    }

    public class Librarian : ILibrarian
    {
        public void AddBook()
        {
            Console.WriteLine("Book added to library.");
        }

        public void RemoveBook()
        {
            Console.WriteLine("Book removed from library.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Library Management System");

            IMembership membership = new FacultyMembership();
            membership.GetBenefits();

            IAlert email = new EmailAlert();
            IAlert sms = new SmsAlert();

            email.SendAlert();
            sms.SendAlert();

            IReader reader = new Reader();
            ILibrarian librarian = new Librarian();

            reader.SearchBook();
            reader.BorrowBook();

            librarian.AddBook();
            librarian.RemoveBook();
        }
    }
}