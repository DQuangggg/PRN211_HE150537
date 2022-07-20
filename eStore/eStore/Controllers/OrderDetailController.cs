using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess.DataAccess;
using DataAccess.Repository;
using System;

namespace eStore.Controllers
{
    public class OrderDetailController : Controller
    {
        IOrderDetailRepository orderDetailRepository = null;
        public OrderDetailController() => orderDetailRepository = new OrderDetailRepository();
        // GET: OrderDetailController
        public ActionResult Index()
        {
            var orderDetailsList = orderDetailRepository.GetOrderDetails();
            return View(orderDetailsList);
        }

        // GET: OrderDetailController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var orderDetails = orderDetailRepository.GetOrderDetailsByID(id.Value);
            if (orderDetails == null) {
                return NotFound();
            }
            return View(orderDetails);
        }

        // GET: OrderDetailController/Create
        public ActionResult Create() => View();

        // POST: OrderDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderDetail orderDetail)
        {
            try
            {
                if (ModelState.IsValid) {
                    orderDetailRepository.AddOrderDetail(orderDetail);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(orderDetail);
            }
        }

        // GET: OrderDetailController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var orderDetails = orderDetailRepository.GetOrderDetailsByID(id.Value);
            if (orderDetails == null){
                return NotFound();
            }
            return View(orderDetails);
        }

        // POST: OrderDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OrderDetail orderDetail)
        {
            try
            {
                if (id != orderDetail.OrderId) {
                    return NotFound();
                }
                    if (ModelState.IsValid) {
                    orderDetailRepository.UpdateOrderDetail(orderDetail);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: OrderDetailController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var orderDetails = orderDetailRepository.GetOrderDetailsByID(id.Value);
            if (orderDetails == null) {
                return NotFound();
            }
            return View(orderDetails);
        }

        // POST: OrderDetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                orderDetailRepository.DeleteOrderDetail(id);
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
