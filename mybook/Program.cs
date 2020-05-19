using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Book {
        public string name;
        public string date;
        public string writer;
        public string unfolder;
        public string unfolded;
        public string director;
        public string plan;
        public string editor;
        public string design;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.name = "PHP 프로그래밍 입문";
            book.date = "2013년5월20일";
            book.writer = "황재호";
            book.unfolder = "김태현";
            book.unfolded = "한빛아카데미(주)";
            book.director = "김현용";
            book.plan = "김이화";
            book.editor = "김이화";
            book.design = "여동일";
        }
    }
}
