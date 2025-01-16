using buoi13_netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace buoi13_netcore.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>()
            {
                new Member(1,"Quan","Nghi Son","Thanh Hoa", "Viet Nam"),
                new Member(2,"Ngan","Nghi Son","Thanh Hoa", "Viet Nam"),
                new Member(3,"Hihi","Nghi Son","Thanh Hoa", "Viet Nam"),
            };
        public IActionResult Index()
        {
            ViewBag.Members = members;
            return View();
        }
        public IActionResult List()
        {
            return View(members);
        }
        public IActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Creat(Member member)
        {
            members.Add(member);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var mem = members.Where(x => x.Id == id).FirstOrDefault();
                return View(mem);
            }
        }
        [HttpPost]
        public IActionResult Edit(Member member)
        {
            for (int i = 0; i < members.Count; i++) 
            {
                if (members[i].Id == member.Id)
                {
                    members[i] = member;
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id) {
            
                var mem = members.FirstOrDefault(x => x.Id == id);
                return View(mem);
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var mem = members.FirstOrDefault(x => x.Id == id);
            if (mem != null)
            {
                members.Remove(mem); 
            }
            return RedirectToAction("List"); 
        }
        //public IActionResult Detail(int? id)
        //{
        //    if (id == null)
        //    {
        //        return RedirectToAction("List");
        //    }
        //    else
        //    {

        //    }
        //}
    }
}