using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PMQLKSCK.Models;

namespace PMQLKSCK.Controllers
{
    public class AccsController : Controller
    {
        private DemoDbContext db = new DemoDbContext();
        Encrytion encry = new Encrytion();


        // GET: Accs
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]

        public ActionResult Register(Acc acc)
        {
            if (ModelState.IsValid)
            {
              //  acc.Password = encry.PasswordEncrytion(acc.Password);//
                db.Accs.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Accs");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Acc acc)
        {
            if (ModelState.IsValid)
            {
                string encytionpass = encry.PasswordEncrytion(acc.Password);
                var model = db.Accs.Where(m => m.UserName == acc.UserName && m.Password == acc.Password).ToList().Count();

                if(model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirectToAction("Index", "Home");

                }    
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");

                }
                if (User.Identity.IsAuthenticated)
                {
                    return Redirect("Home/Index");
                }


            }
            return View(acc);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        

        public ActionResult Index()
        {
            return View(db.Accs.ToList());
        }

        // GET: Accs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acc acc = db.Accs.Find(id);
            if (acc == null)
            {
                return HttpNotFound();
            }
            return View(acc);
        }

        // GET: Accs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDacc,UserName,Password")] Acc acc)
        {
            if (ModelState.IsValid)
            {
                db.Accs.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acc);
        }

        // GET: Accs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acc acc = db.Accs.Find(id);
            if (acc == null)
            {
                return HttpNotFound();
            }
            return View(acc);
        }

        // POST: Accs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDacc,UserName,Password")] Acc acc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acc);
        }

        // GET: Accs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acc acc = db.Accs.Find(id);
            if (acc == null)
            {
                return HttpNotFound();
            }
            return View(acc);
        }

        // POST: Accs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Acc acc = db.Accs.Find(id);
            db.Accs.Remove(acc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
