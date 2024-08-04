using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;

namespace Books
{
    public class BooksDetails
    {
        private static readonly string[] ValidLotValues = { ".NET", "Java", "IMS", "V&V", "BI", "RDBMS" };

        public string BookID;
        public string BookName;
        public int ISBNNo;
        public double Price;
        public string Publisher;
        public int NumberOfPages;
        public string Language = "English";
        public string LoT = "Technical"    ;
        public string Summary;

        public void AcceptBookDetails()
        {
            Console.WriteLine("Enter Book ID");
            BookID = Console.ReadLine();
            ValidateBookID(BookID);

            Console.WriteLine("Enter BookName");
            BookName = Console.ReadLine();
            ValidateBookName(BookName);

            Console.WriteLine("Enter ISBNNo");
            ISBNNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Publisher");
            Publisher = Console.ReadLine();

            Console.WriteLine("Enter Number of Pages");
            NumberOfPages = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Language");
            string LanguageEntered = Console.ReadLine();
            if (!string.IsNullOrEmpty(LanguageEntered))
            {
                Language = LanguageEntered;
                
            }

            Console.WriteLine("Enter LoT");
            string LoTEntered = Console.ReadLine();
            if(!string.IsNullOrEmpty(LoTEntered))
            {
               
                LoT = LoTEntered;
               
            }
            ValidateLot(LoT);
            Console.WriteLine("Enter Summary");
            Summary = Console.ReadLine();


        }

        private void ValidateBookID(string bookID)
        {
            if (string.IsNullOrEmpty(bookID) || bookID.Length != 5 || !int.TryParse(bookID,out _))
                throw new ArgumentException("Book ID should be a 5-digit number.");
        }

        private void ValidateBookName(string bookName)
        {
            if (string.IsNullOrEmpty(bookName))
                throw new ArgumentException("Book Name cannot be blank.");
        }

        private void ValidateLot(string lot)
        {
            if (string.IsNullOrEmpty(lot) || Array.IndexOf(ValidLotValues, lot) == -1)
                throw new ArgumentException("LoT must be one of the following: .NET, Java, IMS, V&V, BI, RDBMS.");
        }


    }
}