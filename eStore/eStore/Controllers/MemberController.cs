using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess.DataAccess;
using DataAccess.Repository;
using System;


namespace eStore.Controllers
{
    public class MemberController : Controller
    {
        IMemeberRepository memeberRepository = null;
        public MemberController() => memeberRepository = new MemberRepository();
        
        // GET: MemberController
        public ActionResult Index()
        {
            var memberList = memeberRepository.GetMembers();
            return View(memberList);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var member = memeberRepository.GetMemberByID(id.Value);
            if (member == null) {
                return NotFound();
            }
            return View(member);
        }

        // GET: MemberController/Create
        public ActionResult Create() => View();

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                if (ModelState.IsValid) {
                    memeberRepository.AddMember(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(member);
            }
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var member = memeberRepository.GetMemberByID(id.Value);
            if (member == null) {
                return NotFound();
            }

            return View(member);
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Member member)
        {
            try
            {
                if (id != member.MemberId) {
                    return NotFound();
                }
                if (ModelState.IsValid) {
                    memeberRepository.UpdateMember(member);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var member = memeberRepository.GetMemberByID(id.Value);
            if (member == null) {
                return NotFound();
            }

            return View(member);
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                memeberRepository.DeleteMember(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
