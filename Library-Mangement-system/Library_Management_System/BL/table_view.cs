using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.BL
{
    class table_view
    {
        public class book
            {
            public int Id { get; set; }
            public string Name { get; set; }
            public string author{ get; set; }
            public string categorie{ get; set; }
            public string language{ get; set; }
            public string publisher{ get; set; }
            public Nullable<int> Pages{ get; set; }         
            public Nullable<int> Rate { get; set; }
            //public Nullable<int> Volume { get; set; }
            public Nullable<System.DateTime> Publication_Year{ get; set; }
            //public string Map_Plates{ get; set; }
            public string Notes{ get; set; }
            public Nullable<double> Price { get; set; }
            public Nullable<System.DateTime> Entry_Date { get; set; }
            public Nullable<int> Parts { get; set; }
            public static book Convert_to_book_view(DATA_AL.book obj)
            {
                book book = new book();
                book.Id = obj.bk_id;
                book.Name = obj.bk_name;
                book.author = obj.author.ah_name;
                book.categorie = obj.categorie.ct_name;
                book.language = obj.language;
                book.publisher = BL.table_opration.Many_book_publisher.get_book_publishers(obj.bk_id)[0].pp_name;
                book.Pages = obj.bk_pages;
                book.Rate = obj.bk_rate;
                //book.Volume = obj.bk_volume;
                book.Publication_Year = obj.publication_year;
                //book.Map_Plates = obj.map_plates;
                book.Notes = obj.bk_notes;
                book.Price= obj.price;
                book.Entry_Date= obj.bk_entry_date;
                book.Parts= obj.bk_parts;
                return book;
            }
            public static List<book> Convert_to_books_views(List<DATA_AL.book> list)
            {
                List<book> list_view = new List<book>();
                foreach (DATA_AL.book item in list)
                {
                    list_view.Add(Convert_to_book_view(item));
                }
                return list_view;
            }


            }
        public class author
        {
            public int Id{ get; set; }
            public string Name{ get; set; }
            public int Books {get;set;}
            public static author Convert_to_author_view(DATA_AL.author obj)
            {
                author author = new author();
                author.Id = obj.ah_id;
                author.Name = obj.ah_name;
                author.Books = BL.table_opration.author.get_number_author_books(obj.ah_id);
                return author;
            }
            public static List<author> Convert_to_authors_views(List<DATA_AL.author> list)
            {
                List<author> list_view = new List<author>();
                foreach (DATA_AL.author item in list)
                {
                    list_view.Add(Convert_to_author_view(item));
                }
                return list_view;
            }
        }
            public class publisher
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public int Books { get; set; }
            public static publisher Convert_to_publisher_view(DATA_AL.publisher obj)
            {
                publisher publisher = new publisher();
                publisher.Id = obj.pp_id;
                publisher.Name = obj.pp_name;
                publisher.Address = obj.pp_address;
                publisher.Books = BL.table_opration.Many_book_publisher.get_publisher_books(obj.pp_id).Count;
                return publisher;
            }
            public static List<publisher> Convert_to_publishers_views(List<DATA_AL.publisher> list)
            {
                List<publisher> list_view = new List<publisher>();
                foreach (DATA_AL.publisher item in list)
                {
                    list_view.Add(Convert_to_publisher_view(item));
                }
                return list_view;
            }
        }
        public class category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Books { get; set; }
            public static category Convert_to_category_view(DATA_AL.categorie obj)
            {
                category category = new category();
                category.Id = obj.ct_id;
                category.Name = obj.ct_name;
                category.Books = BL.table_opration.categorie.get_number_categorie_book(obj.ct_id);
                return category;
            }
            public static List<category> Convert_to_categorys_views(List<DATA_AL.categorie> list)
            {
                List<category> list_view = new List<category>();
                foreach (DATA_AL.categorie item in list)
                {
                    list_view.Add(Convert_to_category_view(item));
                }
                return list_view;
            }
        }
        public class borrower
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Code { get; set; }
            public string Phone { get; set; }
            public string Rank { get; set; }
            public static borrower Convert_to_borrower_view(DATA_AL.borrower obj)
            {
                borrower borrower = new borrower();
                borrower.Id = obj.bwr_id;
                borrower.Name = obj.bwr_name;
                borrower.Address = obj.bwr_address;
                borrower.Code = obj.bwr_code;
                borrower.Phone = obj.bwr_phone;
                borrower.Rank = obj.bwr_rank;
                return borrower;
            }
            public static List<borrower> Convert_to_borrowers_views(List<DATA_AL.borrower> list)
            {
                List<borrower> list_view = new List<borrower>();
                foreach (DATA_AL.borrower item in list)
                {
                    list_view.Add(Convert_to_borrower_view(item));
                }
                return list_view;
            }
        }
        public class borrow
        {
            public int Id_Process { get; set; }
            public string Borrower { get; set; }
            public string Borrower_Code { get; set; }
            public string Book { get; set; }
            public int Book_Id { get; set; }
            public Nullable<System.DateTime> DateOut { get; set; }
            public Nullable<System.DateTime> DateIn { get; set; }
            public string returned { get; set; }

            public static borrow Convert_to_borrow_view(DATA_AL.borrow obj)
            {
                //error_ null 
                borrow borrow = new borrow();
                    borrow.Id_Process = obj.br_id;
                    borrow.Borrower = obj.borrower.bwr_name;
                    borrow.Borrower_Code = obj.borrower.bwr_code;
                    DATA_AL.book book = BL.table_opration.Many_book_borrow.get_boo_by_id(obj.br_id)[0];
                    borrow.Book = book.bk_name;
                    borrow.Book_Id = book.bk_id;
                    borrow.returned = return_yes_no(obj.returned);
                    borrow.DateIn = obj.br_dateIn;
                    borrow.DateOut = obj.br_dateOut;
               
                return borrow;
            }
            public static List<borrow> Convert_to_borrows_views(List<DATA_AL.borrow> list)
            {
                List<borrow> list_view = new List<borrow>();
                foreach (DATA_AL.borrow item in list)
                {
                    list_view.Add(Convert_to_borrow_view(item));
                }
                return list_view;
            }
            public static string return_yes_no(bool? input)
            {
                
                return (bool)input? "Yes" : "No";
            }
        }
    }
}
