using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class RoomList:ViewComponent
    {
        public IViewComponentResult Invoke(List<Room> data)
        {

            ViewBag.Count = data.Count;
            ViewBag.Total = data.Sum(i => i.TotalRoomRent);

            return View(data);
        }
    }
}
