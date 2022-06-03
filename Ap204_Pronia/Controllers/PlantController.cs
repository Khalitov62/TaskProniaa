﻿using Ap204_Pronia.DAL;
using Ap204_Pronia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pronia.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap204_Pronia.Controllers
{
    public class PlantController : Controller
    {
        private readonly AppDbContext _context;

        public PlantController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> AddBasket(int id)
        {
            Plant plant = await _context.Plants.FirstOrDefaultAsync(p => p.Id == id);
            if (plant == null) return NotFound();
            string basketStr = HttpContext.Request.Cookies["Basket"];
            BasketVM basket;
            string itemStr;
            if (string.IsNullOrEmpty(basketStr))
            {  
                basket = new BasketVM();
                BasketItemVM item = new BasketItemVM
                {
                    Plant = plant,
                    Count = 1
                };
                basket.BasketItemVMs.Add(item);
                basket.TotalPrice = item.Plant.Price;
                basket.Count = 1;
                itemStr = JsonConvert.SerializeObject(basket);


            }
            else
            {
                basket = JsonConvert.DeserializeObject<BasketVM>(basketStr);

                BasketItemVM existedItem = basket.BasketItemVMs.FirstOrDefault(i=> i.Plant.Id == id);
                if (existedItem == null)
                {
                    BasketItemVM item = new BasketItemVM
                    {
                        Plant = plant,
                        Count = 1
                    };
                    basket.BasketItemVMs.Add(item);
                }
                else
                {
                    existedItem.Count++;
                }
                decimal total = default;
                foreach (BasketItemVM item in basket.BasketItemVMs)
                {
                    total += item.Plant.Price * item.Count;
                }
                basket.TotalPrice = total;
                basket.Count = basket.BasketItemVMs.Count;
                itemStr = JsonConvert.SerializeObject(basket);

            }
            HttpContext.Response.Cookies.Append("Basket", itemStr);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowBasket()
        {
            return Content(HttpContext.Request.Cookies["Basket"]);
        }
    }
}
