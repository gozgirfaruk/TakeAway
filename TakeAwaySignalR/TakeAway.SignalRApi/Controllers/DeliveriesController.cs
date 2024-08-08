using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.SignalRApi.DAL;

namespace TakeAway.SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private readonly Context _context;

        public DeliveriesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDeliveryList()
        {
            var values = _context.Deliveries.ToList();  
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult DetDeliveryById(int id)
        {
            var values = _context.Deliveries.Find(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDelivery(Delivery delivery)
        {
            _context.Deliveries.Add(delivery);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDelivery(Delivery delivery)
        {
            _context.Deliveries.Update(delivery);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteDelivery(int id)
        {
            var values = _context.Deliveries.Find(id);
            _context.Deliveries.Remove(values);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("GetDeliveryStatusIsYolda")]
        public IActionResult GetDeliveryStatusIsYolda()
        {
            int value = _context.Deliveries.Where(x=>x.Status=="Yolda").Count();
            return Ok(value);
        }
        [HttpGet("GetDeliveryStatusIsSirapisAlinda")]
        public IActionResult GetDeliveryStatusIsSirapisAlinda()
        {
            int value = _context.Deliveries.Where(x => x.Status == "Siparis Alındı").Count();
            return Ok(value);
        }
        [HttpGet("GetDeliveryStatusIsHazirlaniyor")]
        public IActionResult GetDeliveryStatusIsSiparisYolda()
        {
            int value = _context.Deliveries.Where(x => x.Status == "Hazırlanıyor").Count();
            return Ok(value);
        }
            [HttpGet("GetDeliveryStatusIsTeslimEdildi")]
        public IActionResult GetDeliveryStatusIsTeslimEdildi()
        {
            int value = _context.Deliveries.Where(x=>x.Status=="Teslim Edildi").Count();
            return Ok(value);
        }
        [HttpGet("TotalPrice")]
        public IActionResult TotalPrice()
        {
            decimal values= _context.Deliveries.Sum(x => x.TotalPrice);
            return Ok(values);
        }
        [HttpGet("TotalOrder")]
        public IActionResult TotalOrder()
        {
            int value = _context.Deliveries.Count();
            return Ok(value);
        }
    }
}
