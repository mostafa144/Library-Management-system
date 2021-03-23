using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_system.BL
{
    class table_opration
    {
       // static DATA_AL.LibraryEntities5 db = new DATA_AL.LibraryEntities5();

        // handling staff operation
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
                          where x.sf_user == user && password == x.sf_pass
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
    }
}
