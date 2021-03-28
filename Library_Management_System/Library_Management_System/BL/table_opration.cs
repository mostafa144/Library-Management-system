using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.BL
{
    class table_opration
    {
        static DATA_AL.LibraryEntities5 db = new DATA_AL.LibraryEntities5();
            public class Many_book_publisher
            {

                static public void Add_relation(int book_id, int publisher_id)
                {
                    DATA_AL.book book = db.books.Find(book_id);
                    DATA_AL.publisher publisher = db.publishers.Find(publisher_id);
                    db.books.Attach(book);
                    db.publishers.Attach(publisher);
                   // book.publishers = new List<DATA_AL.publisher>();
                    book.publishers.Add(publisher);
                    db.SaveChanges();

                }
                static public void Delete_relation(int book_id, int publisher_id)
                {
                    DATA_AL.book book = db.books.Find(book_id);
                    DATA_AL.publisher publisher = db.publishers.Find(publisher_id);
                    book.publishers.Remove(publisher);
                    db.SaveChanges();
                }
                static public void Update_relation(int publisher_id, int book_id)
                {
                DATA_AL.publisher new_ = db.publishers.Find(publisher_id);
                Delete_relation(book_id, Many_book_publisher.get_book_publishers(book_id)[0].pp_id);
                    db.publishers.Attach(new_);
                    DATA_AL.book book = db.books.Find(book_id);
                    db.books.Attach(book);
                 //   book.publishers = new List<DATA_AL.publisher>();
                    book.publishers.Add(new_);
                    db.SaveChanges();
                }
                static public List<DATA_AL.publisher> get_book_publishers(int book_id)
                {
                    var result = db.books
                                    .Where(r => book_id == r.bk_id)
                                    .SelectMany(x => x.publishers)
                                    .Distinct();
                    return result.ToList();
                }
                static public List<DATA_AL.book> get_publisher_books(int publisher_id)
                {
                    var result = db.publishers
                                    .Where(r => publisher_id == r.pp_id)
                                    .SelectMany(x => x.books)
                                    .Distinct();
                    return result.ToList();
                }
            }
            public class Many_book_borrow
            {

                static public void Add_relation(int book_id, int borrow_id)
                {
                    DATA_AL.book book = db.books.Find(book_id);
                    DATA_AL.borrow borrow = db.borrows.Find(borrow_id);
                    db.books.Attach(book);
                    db.borrows.Attach(borrow);
                  //  book.borrows = new List<DATA_AL.borrow>();
                    book.borrows.Add(borrow);
                    db.SaveChanges();

                }
                static public void Delete_relation(int book_id, int borrow_id)
                {
                    DATA_AL.book book = db.books.Find(book_id);
                    DATA_AL.borrow borrow = db.borrows.Find(borrow_id);
                    book.borrows.Remove(borrow);
                    db.SaveChanges();
                }
                static public void Update_relation( int borrow_id ,int book_id)
                {
                DATA_AL.borrow new_=db.borrows.Find(borrow_id);
                Delete_relation(Many_book_borrow.get_borrow_books(borrow_id)[0].bk_id, borrow_id);
                    db.borrows.Attach(new_);
                    DATA_AL.book book = db.books.Find(book_id);
                    db.books.Attach(book);
              //      book.borrows = new List<DATA_AL.borrow>();
                    book.borrows.Add(new_);
                    db.SaveChanges();
                }
                static public List<DATA_AL.borrow> get_book_borrows(int book_id)
                {
                    var result = db.books
                                    .Where(r => book_id == r.bk_id)
                                    .SelectMany(x => x.borrows)
                                    .Distinct();
                    return result.ToList();
                }

            static public List<DATA_AL.book> get_borrow_books(int borrow_id)
            {
                var result = db.borrows
                                .Where(r => borrow_id == r.br_id)
                                .SelectMany(x => x.books)
                                .Distinct();
                return result.ToList();
            }
            static public List<DATA_AL.book> get_boo_by_id(int borrow)
            {
                var result = db.borrows
                                .Where(r => borrow == r.br_id)
                                .SelectMany(x => x.books)
                                .Distinct();
                return result.ToList();
            }
            static public List<DATA_AL.book> get_all_borrowed_books()
                {
                    var result = db.borrows
                                     .Where(r => r.returned == false)
                                     .SelectMany(x => x.books)
                                     .Distinct();
                    return result.ToList();
                }
                static public List<DATA_AL.book> get_all_borrowed_books(DateTime in_day)
                {
                    var result = db.borrows
                                     .Where(r => r.returned == false && r.br_dateIn == in_day)
                                     .SelectMany(x => x.books)
                                     .Distinct();
                    return result.ToList();
                }
                static public List<DATA_AL.borrower> get_book_borrowers(int book_id)
                {
                    var result = db.books
                                    .Where(r => book_id == r.bk_id)
                                    .SelectMany(x => x.borrows)
                                    .Distinct();
                    var res = from x in result
                              select x.borrower;

                    return res.ToList<DATA_AL.borrower>();
                }
            }
            public class staff
            {

                static public DATA_AL.staff add_staff(DATA_AL.staff obj)
                {
                    obj.sf_id = NextID();
                    db.staffs.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.staff add_staff(string sf_adress, string sf_pass, string sf_phone, string sf_ssn, string sf_user, string accessablity)
                {
                    DATA_AL.staff obj = new DATA_AL.staff();
                    obj.sf_id = NextID();
                    obj.sf_adress = sf_adress;
                    obj.sf_pass = sf_pass;
                    obj.sf_phone = sf_phone;
                    obj.sf_ssn = sf_ssn;
                    obj.sf_user = sf_user;
                    obj.accessablity = accessablity;
                    db.staffs.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void delete(int id)
                {
                    DATA_AL.staff obj = db.staffs.Find(id);
                    db.staffs.Remove(obj);
                    db.SaveChanges();
                }
                static public void update(DATA_AL.staff new_info)
                {
                    DATA_AL.staff old_info = db.staffs.Find(new_info.sf_id);
                    old_info.sf_adress = new_info.sf_adress;
                    old_info.sf_pass = new_info.sf_pass;
                    old_info.sf_phone = new_info.sf_phone;
                    old_info.sf_ssn = new_info.sf_ssn;
                    old_info.sf_user = new_info.sf_user;
                    old_info.accessablity = new_info.accessablity;
                    db.SaveChanges();
                }
                static public void update(int sf_id, string sf_adress, string sf_pass, string sf_phone, string sf_ssn, string sf_user, string accessablity)
                {
                    DATA_AL.staff old_info = db.staffs.Find(sf_id);
                    old_info.sf_adress = sf_adress;
                    old_info.sf_pass = sf_pass;
                    old_info.sf_phone = sf_phone;
                    old_info.sf_ssn = sf_ssn;
                    old_info.sf_user = sf_user;
                    old_info.accessablity = accessablity;
                    db.SaveChanges();
                }
                static public List<string> get_all_process_staff(int staff_id)
                {
                    return (from process in db.logs
                            where process.staff_id == staff_id
                            select process.process).ToList();
                }
                static public List<DATA_AL.staff> get_staff_process_type(string opration_kind)
                {
                    return (from process in db.logs
                            where process.opration_kind == opration_kind
                            select process.staff).ToList();

                }

                static public DATA_AL.staff search_id(int id)
                {
                DATA_AL.staff info = db.staffs.Find(id);
                return info;
                }
                static public List<DATA_AL.staff> search_accessablity(string accessablity)
                {
                    var res = from x in db.staffs
                              where x.accessablity.Contains(accessablity)
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.staff> search_ssn(string ssn)
                {
                    var res = from x in db.staffs
                              where x.sf_ssn.Contains(ssn)
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.staff> search_user(string user)
                {
                    var res = from x in db.staffs
                              where x.sf_user.Contains(user)
                              select x;
                    return res.ToList();
                }

            static public bool login_make_sure(string user, string password)
            {
                var res = from x in db.staffs
                          where x.sf_user==user && password==x.sf_pass
                          select x;
                if (res.ToList().Count >= 1)
                    return true;
                return false;
            }
            static public DATA_AL.staff login_get_staff(string user, string password)
            {
                var res = from x in db.staffs
                          where x.sf_user == user && password == x.sf_pass
                          select x;
                return res.ToList()[0];
            }
            static public List<DATA_AL.staff> return_all()
                {
                    var res = from x in db.staffs
                              select x;
                    return res.ToList();
                }

                static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.staffs
                               select x.sf_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }
            }
            public class publisher
            {

                static public DATA_AL.publisher add_publisher(DATA_AL.publisher obj)
                {
                    obj.pp_id = NextID();
                    db.publishers.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.publisher add_publisher(string pp_name, string pp_address)
                {
                    DATA_AL.publisher obj = new DATA_AL.publisher();
                    obj.pp_id = NextID();
                    obj.pp_name = pp_name;
                    obj.pp_address = pp_address;
                    db.publishers.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void delete(int id)
                {
                    DATA_AL.publisher obj = db.publishers.Find(id);
                    db.publishers.Remove(obj);
                    db.SaveChanges();
                }
                static public void update(DATA_AL.publisher new_info)
                {
                    DATA_AL.publisher old_info = db.publishers.Find(new_info.pp_id);
                    old_info.pp_name = new_info.pp_name;
                    old_info.pp_address = new_info.pp_address;
                    db.SaveChanges();
                }
                static public void update(int pp_id, string pp_name, string pp_address)
                {
                    DATA_AL.publisher old_info = db.publishers.Find(pp_id);
                    old_info.pp_name = pp_name;
                    old_info.pp_address = pp_address;
                    db.SaveChanges();
                }
                static public List<DATA_AL.publisher> search_name(string name)
                {
                    var res = from x in db.publishers
                              where x.pp_name.Contains(name)
                              select x;
                    return res.ToList();
                }
                static public DATA_AL.publisher search_id(int id)
                {
                DATA_AL.publisher info = db.publishers.Find(id);
                return info;
                }
                static public List<DATA_AL.publisher> return_all()
                {
                    var res = from x in db.publishers
                              select x;
                    return res.ToList();
                }
                static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.publishers
                               select x.pp_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }

        }
            public class log
            {

                static public DATA_AL.log add_log(DATA_AL.log obj)
                {
                    obj.lg_id = NextID();
                    db.logs.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.log add_log(DateTime lg_date, string opration_kind, string process, string table_name, int staff_id)
                {
                    DATA_AL.log obj = new DATA_AL.log();
                    obj.lg_id = NextID();
                    obj.lg_date = lg_date;
                    obj.opration_kind = opration_kind;
                    obj.process = process;
                    obj.table_name = table_name;
                    obj.staff_id = staff_id;
                    db.logs.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void delete(int lg_id)
                {
                    DATA_AL.log obj = db.logs.Find(lg_id);
                    db.logs.Remove(obj);
                    db.SaveChanges();
                }
                static public void update(DATA_AL.log new_info)
                {
                    DATA_AL.log old_info = db.logs.Find(new_info.lg_id);
                    old_info.lg_date = new_info.lg_date;
                    old_info.opration_kind = new_info.opration_kind;
                    old_info.process = new_info.process;
                    old_info.table_name = new_info.table_name;
                    old_info.staff_id = new_info.staff_id;
                    db.SaveChanges();
                }
                static public void update(int lg_id, DateTime lg_date, string opration_kind, string process, string table_name, int staff_id)
                {
                    DATA_AL.log old_info = db.logs.Find(lg_id);
                    old_info.lg_date = lg_date;
                    old_info.opration_kind = opration_kind;
                    old_info.process = process;
                    old_info.table_name = table_name;
                    old_info.staff_id = staff_id;
                    db.SaveChanges();
                }
                static public DATA_AL.log search_id(int id)
                {
                DATA_AL.log info = db.logs.Find(id);
                return info;
            }
                static public List<DATA_AL.log> search_date(DateTime date)
                {
                    var res = from x in db.logs
                              where x.lg_date == date
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.log> search_table_name(string table_name)
                {
                    var res = from x in db.logs
                              where x.table_name.Contains(table_name)
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.log> search_operation_kind(string operation_kind)
                {
                    var res = from x in db.logs
                              where x.opration_kind.Contains(operation_kind)
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.log> return_all()
                {
                    var res = from x in db.logs
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.log> get_deleted_books(DateTime date)
                {
                    var res = from b in db.logs
                              where b.lg_date == date && b.opration_kind == "delete" && b.table_name == "book"
                              select b;
                    return res.ToList();
                }
                static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.logs
                               select x.lg_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }
            }
            public class categorie
            {

                static public DATA_AL.categorie add_categorie(DATA_AL.categorie obj)
                {
                    obj.ct_id = NextID();
                    db.categories.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.categorie add_categorie(string ct_name)
                {
                    DATA_AL.categorie obj = new DATA_AL.categorie();
                    obj.ct_id = NextID();
                    obj.ct_name = ct_name;
                    db.categories.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void delete(int ct_id)
                {
                    DATA_AL.categorie obj = db.categories.Find(ct_id);
                    db.categories.Remove(obj);
                    db.SaveChanges();
                }
                static public void update(DATA_AL.categorie new_info)
                {
                    DATA_AL.categorie old_info = db.categories.Find(new_info.ct_id);
                    old_info.ct_name = new_info.ct_name;
                    db.SaveChanges();
                }
                static public void update(int ct_id, string ct_name)
                {
                    DATA_AL.categorie old_info = db.categories.Find(ct_id);
                    old_info.ct_name = ct_name;
                    db.SaveChanges();
                }

            static public bool has_relation(int categore_id)
            {
                var res = from x in db.books
                          where x.categories_id == categore_id
                          select x;
                if (res.ToList().Count > 0)
                    return true;
                return false;
            }
            static public List<DATA_AL.categorie> search(string name)
                {
                    var res = from x in db.categories
                              where x.ct_name.Contains(name)
                              select x;
                    return res.ToList();
                }
            static public DATA_AL.categorie search(int id)
            {
               return db.categories.Find(id);
            }
                static public List<DATA_AL.categorie> return_all()
                {
                    var res = from x in db.categories
                              select x;
                    return res.ToList<DATA_AL.categorie>();
                }
                static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.categories
                               select x.ct_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }
                static public List<DATA_AL.categorie> get_all_categorie()
                {
                    var res = from x in db.categories
                              select x;
                    return res.ToList();
                }
            static public int get_number_categorie_book( int cat_id)
            {
                var res = from x in db.books
                          where  x.categories_id == cat_id
                          select x;
                return res.ToList().Count;
            }

        }
            public class borrower
            {

                static public DATA_AL.borrower add_borrower(DATA_AL.borrower obj)
                {
                    obj.bwr_id = NextID();
                    db.borrowers.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.borrower add_borrower(string bwr_name, string bwr_phone, string bwr_rank, string bwr_code, string bwr_address)
                {
                    DATA_AL.borrower obj = new DATA_AL.borrower();
                    obj.bwr_id = NextID();
                    obj.bwr_name = bwr_name;
                    obj.bwr_phone = bwr_phone;
                    obj.bwr_rank = bwr_rank;
                    obj.bwr_code = bwr_code;
                    obj.bwr_address = bwr_address;
                    db.borrowers.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void delete(int id)
                {
                    DATA_AL.borrower obj = db.borrowers.Find(id);
                    db.borrowers.Remove(obj);
                    db.SaveChanges();
                }

                static public void update(DATA_AL.borrower new_info)
                {
                    DATA_AL.borrower old_info = db.borrowers.Find(new_info.bwr_id);
                    old_info.bwr_name = new_info.bwr_name;
                    old_info.bwr_phone = new_info.bwr_phone;
                    old_info.bwr_rank = new_info.bwr_rank;
                    old_info.bwr_code = new_info.bwr_code;
                    old_info.bwr_address = new_info.bwr_address;
                    db.SaveChanges();
                }
                static public void update(int id, string bwr_name, string bwr_phone, string bwr_rank, string bwr_code, string bwr_address)
                {
                    DATA_AL.borrower old_info = db.borrowers.Find(id);
                    old_info.bwr_name = bwr_name;
                    old_info.bwr_phone = bwr_phone;
                    old_info.bwr_rank = bwr_rank;
                    old_info.bwr_code = bwr_code;
                    old_info.bwr_address = bwr_address;
                    db.SaveChanges();
                }
                static public DATA_AL.borrower search(int id)
                {
                DATA_AL.borrower info = db.borrowers.Find(id);
                return info;
            }
            static public List<DATA_AL.borrow> get_borrow_log(int id)
            {
               var res= from b in db.borrows
                        where b.borrower_id == id
                        select b;
                return res.ToList();
            }
            static public List<DATA_AL.borrower> failed_to_return()
                {
                    var result = from b in db.borrows
                                 where b.returned == false
                                 select b;
                    var res = from x in result
                              select x.borrower;
                    return res.ToList();
                }
                static public List<DATA_AL.borrower> failed_to_return(DateTime in_day)
                {
                    var result = from b in db.borrows
                                 where b.returned == false && b.br_dateIn == in_day
                                 select b;
                    var res = from x in result
                              select x.borrower;
                    return res.ToList();
                }
                static public List<DATA_AL.borrower> search_name(string name)
                {
                    var res = from x in db.borrowers
                              where x.bwr_name.Contains(name)
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.borrower> search_code(string code)
                {
                    var res = from x in db.borrowers
                              where x.bwr_code.Contains(code)
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.borrower> return_all()
                {
                    var res = from x in db.borrowers
                              select x;
                    return res.ToList();
                }
                static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.borrowers
                               select x.bwr_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }
            }
            public class borrow
            {

                static public DATA_AL.borrow add_borrow(DATA_AL.borrow obj)
                {
                    obj.br_id = NextID();
                    db.borrows.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.borrow add_borrow(int borrower_id, DateTime br_dateIn, DateTime br_dateOut, bool returned)
                {
                    DATA_AL.borrow obj = new DATA_AL.borrow();
                    obj.br_id = NextID();
                    obj.borrower_id = borrower_id;
                    obj.br_dateIn = br_dateIn;
                    obj.br_dateOut = br_dateOut;
                    obj.returned = returned;
                    db.borrows.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void delete(int id)
                {
                    DATA_AL.borrow obj = db.borrows.Find(id);
                    db.borrows.Remove(obj);
                    db.SaveChanges();
                }
            static public void delete(List<DATA_AL.borrow> list)
            {
                foreach (DATA_AL.borrow b in list)
                {
                    int book_id = BL.table_opration.Many_book_borrow.get_borrow_books((b.br_id))[0].bk_id;
                    BL.table_opration.Many_book_borrow.Delete_relation(book_id,(b.br_id));
                }
                db.borrows.RemoveRange(list);
                db.SaveChanges();
            }
            static public void update(DATA_AL.borrow new_info)
                {
                    DATA_AL.borrow old_info = db.borrows.Find(new_info.br_id);
                    old_info.br_dateIn = new_info.br_dateIn;
                    old_info.br_dateOut = new_info.br_dateOut;
                    old_info.returned = new_info.returned;
                    db.SaveChanges();
                }
                static public void update(int br_id, int borrower_id, DateTime br_dateIn, DateTime br_dateOut, bool returned)
                {
                    DATA_AL.borrow old_info = db.borrows.Find(br_id);
                    old_info.br_dateIn = br_dateIn;
                    old_info.br_dateOut = br_dateOut;
                    old_info.borrower_id = borrower_id;
                    old_info.returned = returned;
                    db.SaveChanges();
               
                }
                static public DATA_AL.borrow search_id(int id)
                {
                return db.borrows.Find(id);
                }
            static public List<DATA_AL.borrow> search(int id)
            {
                var res = from x in db.borrows
                          where x.br_id==id
                          select x;
                return res.ToList();
            }
            static public List<DATA_AL.borrow> search(string name_borrower)
            {
                var res = from x in db.borrows
                          where x.borrower.bwr_name.Contains(name_borrower)
                          select x;
                return res.ToList();
            }
            static public List<DATA_AL.borrow> return_all()
                {
                    var res = from x in db.borrows
                              select x;
                    return res.ToList();
                }
            static public List<DATA_AL.borrow> return_unreterned_books()
            {
                var res = from x in db.borrows
                          where x.returned == false
                          select x;
                return res.ToList();
            }
            static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.borrows
                               select x.br_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }
            }
            public class author
            {

                static public DATA_AL.author add_author(DATA_AL.author obj)
                {
                    obj.ah_id = NextID();
                    db.authors.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.author add_author(string ah_name)
                {
                    DATA_AL.author obj = new DATA_AL.author();
                    obj.ah_id = NextID();
                    obj.ah_name = ah_name;
                    db.authors.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void delete(int ah_id)
                {
                    DATA_AL.author obj = db.authors.Find(ah_id);
                    db.authors.Remove(obj);
                    db.SaveChanges();
                }
                static public void update(DATA_AL.author new_info)
                {
                    DATA_AL.author old_info = db.authors.Find(new_info.ah_id);
                    old_info.ah_name = new_info.ah_name;
                    db.SaveChanges();
                }
                static public void update(int ah_id, string ah_name)
                {
                    DATA_AL.author old_info = db.authors.Find(ah_id);
                    old_info.ah_name = ah_name;
                    db.SaveChanges();
                }
            static public bool has_relation(int author_id)
            {
                var res = from x in db.books
                          where x.authors_id == author_id
                          select x;
                if (res.ToList().Count > 0)
                    return true;
                return false;
            }
                static public DATA_AL.author search(int id)
                {
               return  db.authors.Find(id);        
                }
            static public List<DATA_AL.author> search(string name)
            {
                var res = from x in db.authors
                          where x.ah_name.Contains(name)
                          select x;
                return res.ToList();
            }
            static public List<DATA_AL.author> return_all()
                {
                    var res = from x in db.authors
                              select x;
                    return res.ToList();
                }
                static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.authors
                               select x.ah_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }
            static public int get_number_author_books(int author_id)
            {
                var res = from x in db.books
                          where x.authors_id == author_id
                          select x;
                return res.ToList().Count;
            }
        }
            public class book
            {
                static public DATA_AL.book add_book(DATA_AL.book obj)
                {
                    obj.bk_id = NextID();
                    db.books.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public DATA_AL.book add_book(string bk_name, string bk_notes, int bk_pages, int bk_parts, int bk_rate, int bk_volume, int categories_id,
                    bool del, string language, string map_plates, double price, DateTime publication_year, int authors_id, DateTime bk_entry_date)
                {
                    DATA_AL.book obj = new DATA_AL.book();
                    obj.bk_id = NextID();
                    obj.bk_name = bk_name;
                    obj.bk_notes = bk_notes;
                    obj.bk_pages = bk_pages;
                    obj.bk_parts = bk_parts;
                    obj.bk_rate = bk_rate;
                    obj.bk_volume = bk_volume;
                    obj.categories_id = categories_id;
                    obj.del = del;
                    obj.language = language;
                    obj.map_plates = map_plates;
                    obj.price = price;
                    obj.publication_year = publication_year;
                    obj.authors_id = authors_id;
                    obj.bk_entry_date = bk_entry_date;
                    db.books.Add(obj);
                    db.SaveChanges();
                    return obj;
                }
                static public void add_book_all_infos(DATA_AL.book book, DATA_AL.publisher publisher, DATA_AL.author author, DATA_AL.categorie categorie)
                {
                    author = table_opration.author.add_author(author);
                    categorie = table_opration.categorie.add_categorie(categorie);
                    publisher = table_opration.publisher.add_publisher(publisher);
                    book.categories_id = categorie.ct_id;
                    book.authors_id = author.ah_id;
                    book = add_book(book);
                    Many_book_publisher.Add_relation(book.bk_id, publisher.pp_id);
                }
                static public void delete(int bk_id)
                {
                    DATA_AL.book book = db.books.Find(bk_id);
                    db.books.Remove(book);
                    db.SaveChanges();
                }
                static public void hide(int bk_id)
                {
                    DATA_AL.book book = db.books.Find(bk_id);
                    book.del = true;
                    db.SaveChanges();
                }
                static public DATA_AL.book update(DATA_AL.book new_info)
                {
                    DATA_AL.book old_info = db.books.Find(new_info.bk_id);
                    old_info.bk_name = new_info.bk_name;
                    old_info.bk_notes = new_info.bk_notes;
                    old_info.bk_pages = new_info.bk_pages;
                    old_info.bk_parts = new_info.bk_parts;
                    old_info.bk_rate = new_info.bk_rate;
                    old_info.bk_volume = new_info.bk_volume;
                    old_info.categories_id = new_info.categories_id;
                    old_info.del = new_info.del;
                    old_info.language = new_info.language;
                    old_info.map_plates = new_info.map_plates;
                    old_info.price = new_info.price;
                    old_info.publication_year = new_info.publication_year;
                    old_info.authors_id = new_info.authors_id;
                    old_info.bk_entry_date = new_info.bk_entry_date;
                    db.SaveChanges();
                return old_info;
                }
                static public DATA_AL.book update(int bk_id, string bk_name, string bk_notes, int bk_pages, int bk_parts, int bk_rate, int bk_volume, int categories_id,
                    bool del, string language, string map_plates, double price, DateTime publication_year, int authors_id, DateTime bk_entry_date)
                {
                    DATA_AL.book old_info = db.books.Find(bk_id);
                    old_info.bk_name = bk_name;
                    old_info.bk_notes = bk_notes;
                    old_info.bk_pages = bk_pages;
                    old_info.bk_parts = bk_parts;
                    old_info.bk_rate = bk_rate;
                    old_info.bk_volume = bk_volume;
                    old_info.categories_id = categories_id;
                    old_info.del = del;
                    old_info.language = language;
                    old_info.map_plates = map_plates;
                    old_info.price = price;
                    old_info.publication_year = publication_year;
                    old_info.authors_id = authors_id;
                    old_info.bk_entry_date = bk_entry_date;
                    db.SaveChanges();
                return old_info;
                }
                static public List<DATA_AL.book> search(string name)
                {
                    var res = from x in db.books
                              where x.bk_name.Contains(name)
                              select x;
                    return res.ToList();

                }
            static public DATA_AL.book search(int id)
            {

                DATA_AL.book old_info = db.books.Find(id);
                return old_info;

            }
            static public List<DATA_AL.book> search_author(string name)
                {
                    var res = from x in db.books
                              where x.author.ah_name.Contains(name)
                              select x;
                    return res.ToList();

                }
                static public List<DATA_AL.book> search_categorie(string name)
                {
                    var res = from x in db.books
                              where x.categorie.ct_name.Contains(name)
                              select x;
                    return res.ToList();

                }

                static public List<DATA_AL.book> search_published_year(DateTime date)
                {
                    var res = from x in db.books
                              where x.publication_year == date
                              select x;
                    return res.ToList();

                }
                static public int NextID()
                {
                    var res = 0;
                    try
                    {
                        res = (from x in db.books
                               select x.bk_id).Max() + 1;
                    }
                    catch { res = 1; }
                    return res;
                }
                static public List<DATA_AL.book> get_all_books()
                {
                    var res = from x in db.books
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.book> get_none_deleted_books()
                {
                    var res = from x in db.books
                              where x.del != true
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.book> get_book_by_rate(int rate)
                {
                    var res = from x in db.books
                              where x.bk_rate >= rate
                              select x;
                    return res.ToList();
                }
                static public List<DATA_AL.book> order_book_by_author()
                {
                    var author = from x in db.authors
                                 select x.ah_id;
                    List<int> authors = author.ToList<int>();
                    List<List<DATA_AL.book>> books_list = new List<List<DATA_AL.book>>();
                    for (int x = 0; x < authors.Count; x++)
                    {
                        books_list.Add((from item in db.books
                                        where item.authors_id == authors[x]
                                        select item).ToList<DATA_AL.book>());
                    }
                    List<DATA_AL.book> books = new List<DATA_AL.book>();
                    for (int x = 0; x < books_list.Count; x++)
                    {
                        books.AddRange(books_list[x]);
                    }
                    return books.ToList();
                }
                static public List<DATA_AL.book> order_book_by_categorie()
                {
                    var categorie = from x in db.categories
                                    select x.ct_id;
                    List<int> categories = categorie.ToList<int>();
                    List<List<DATA_AL.book>> books_list = new List<List<DATA_AL.book>>();
                    for (int x = 0; x < categories.Count; x++)
                    {
                        books_list.Add((from item in db.books
                                        where item.categories_id == categories[x]
                                        select item).ToList<DATA_AL.book>());
                    }
                    List<DATA_AL.book> books = new List<DATA_AL.book>();
                    for (int x = 0; x < books_list.Count; x++)
                    {
                        books.AddRange(books_list[x]);
                    }
                    return books.ToList();
                }
                static public int? has_remaining_volumes(int id)
                {
                    List<DATA_AL.book> x = (from item in db.books
                                            where item.bk_id == id
                                            select item).ToList<DATA_AL.book>();
                    if (x.Count == 0)
                        return 0;
                    else
                        return x[0].bk_volume;

                }
                static public bool not_borrowed(int book_id)
                {
                    var result = db.books
                                   .Where(r => book_id == r.bk_id)
                                   .SelectMany(x => x.borrows)
                                   .Distinct();
                    var res = from x in result
                              where x.returned == false
                              select x;
                    return res.ToList().Count == 0;

                }
                static public void borrow_book(int book_id, int borrower_id, DateTime br_dateIn, DateTime br_dateOut)
                {
                    int borrow_id = borrow.NextID();
                    borrow.add_borrow(borrower_id, br_dateIn, br_dateOut, false);
                    Many_book_borrow.Add_relation(book_id, borrow_id);
                    DATA_AL.book book = db.books.Find(book_id);
                    book.bk_volume--;
                    db.SaveChanges();
                }
                static public void return_book(int borrow_id,int book_id)
                {
                   
                    DATA_AL.borrow find = db.borrows.Find(borrow_id);
                    find.returned = true;
                    DATA_AL.book book = db.books.Find(book_id);
                    book.bk_volume++;
                    db.SaveChanges();

                }
                static public List<DATA_AL.book> chose_cateigore_author_sort(int author_id, int categorie_id)
                {
                    return (from x in db.books
                            where x.authors_id == author_id && x.categories_id == categorie_id
                            select x).ToList();
                }
                static public List<DATA_AL.book> get_all_borrowed_books()
                {
                    return Many_book_borrow.get_all_borrowed_books();
                }
                static public List<DATA_AL.book> sort_by_pages(List<DATA_AL.book> list)
                {
                    return list.OrderBy(o => o.bk_pages).ToList(); 
                }
            static public List<DATA_AL.book> sort_by_pagesdesc(List<DATA_AL.book> list)
            {
                return list.OrderByDescending(o => o.bk_pages).ToList();
            }
            static public List<DATA_AL.book> sort_by_rate(List<DATA_AL.book> list)
                {
                    return list.OrderBy(o => o.bk_rate).ToList();

                }
            static public List<DATA_AL.book> sort_by_ratedesc(List<DATA_AL.book> list)
            {
                return list.OrderByDescending(o => o.bk_rate).ToList();

            }
            static public List<DATA_AL.book> sort_by_volume()
                {
                    return (from b in db.books
                            select b).ToList().OrderBy(o => o.bk_volume).ToList();

                }
                static public List<DATA_AL.book> sort_by_parts()
                {
                    return (from b in db.books
                            select b).ToList().OrderBy(o => o.bk_parts).ToList();

                }
                static public List<DATA_AL.book> sort_by_pages_desc()
                {
                    return (from b in db.books
                            select b).ToList().OrderByDescending(o => o.bk_pages).ToList(); ;

                }
                static public List<DATA_AL.book> sort_by_rate_desc()
                {
                    return (from b in db.books
                            select b).ToList().OrderByDescending(o => o.bk_rate).ToList();

                }
                static public List<DATA_AL.book> sort_by_volume_desc()
                {
                    return (from b in db.books
                            select b).ToList().OrderByDescending(o => o.bk_volume).ToList();

                }
                static public List<DATA_AL.book> sort_by_parts_desc()
                {
                    return (from b in db.books
                            select b).ToList().OrderByDescending(o => o.bk_parts).ToList();

                }
                static public List<DATA_AL.book> sort_by_alphbtic(List<DATA_AL.book> list)
                {
                    return list.OrderBy(o => o.bk_name).ToList();

                }
                static public List<DATA_AL.book> sort_by_alphbticdesc(List<DATA_AL.book> list)
                {
                    return list.OrderByDescending(o => o.bk_name).ToList(); 

                }
            static public List<DATA_AL.book> sort_by_id(List<DATA_AL.book> list)
            {
                return list.OrderBy(o => o.bk_id).ToList();

            }
            static public List<DATA_AL.book> sort_by_iddesc(List<DATA_AL.book> list)
            {
                return list.OrderByDescending(o => o.bk_id).ToList();

            }

        }
            public class warining
            {

                static public bool check_books_need_tobereturned_today()
                {
                    DateTime date = DateTime.Now;
                    DateTime date_only = date.Date;
                    return Many_book_borrow.get_all_borrowed_books(date_only).Count > 0;
                }
                static public List<DATA_AL.borrower> list_borrowers_will_return_today()
                {
                    DateTime date = DateTime.Now;
                    DateTime date_only = date.Date;
                    var result = from b in db.borrows
                                 where b.returned == false && b.br_dateIn == date_only
                                 select b;
                    var res = from b in result
                              select b.borrower;
                    return res.ToList();
                }
                static public bool check_if_last_copy(int book_id)
                {
                    DATA_AL.book book = db.books.Find(book_id);
                    if (book.bk_volume == 1)
                        return true;
                    return false;
                }
                static public bool check_if_book_has_parts_if_high_rate(int user_rate, int book_id)
                {
                    DATA_AL.book book = db.books.Find(book_id);
                    if (book.bk_parts > 1 && user_rate > 3)
                        return true;
                    return false;
                }
            }
        }
    }
