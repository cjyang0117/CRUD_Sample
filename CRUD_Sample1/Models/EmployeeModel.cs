using CRUD_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Sample1.Models
{
    public class EmployeeModel
    {
        private NorthwindEntities db = new NorthwindEntities();

        /// <summary>
        /// 三斜線註解
        /// get, set設定存取子，在model中使用 (可存取的放資料的變數)
        /// </summary>
        public List<Employees> EmployeeList { get; set; }

        public EmployeeModel()
        {
            EmployeeList = new List<Employees>();
        }

        public List<Employees> GetEmployeeList()
        {
            return db.Employees.ToList();
        }

        public Employees Form1 { get; set; }

        public void Add(Employees item)
        {
            db.Employees.Add(item);
            db.SaveChanges();
        }

        /// <summary>
        /// 取得指定的員工資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employees GetEmployee(int id)
        {
            return db.Employees.SingleOrDefault(q => q.EmployeeID == id);
        }

        /// <summary>
        /// 更新員工資料
        /// </summary>
        /// <param name="item"></param>
        public void Update(Employees item)
        {
            var entity = db.Employees.SingleOrDefault(q => q.EmployeeID == item.EmployeeID);
            entity.LastName = item.LastName;
            entity.FirstName = item.FirstName;
            db.SaveChanges();
        }

        /// <summary>
        /// 刪除員工資料
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var entity = db.Employees.SingleOrDefault(q => q.EmployeeID == id);
            db.Employees.Remove(entity);
            db.SaveChanges();
        }
    }
}