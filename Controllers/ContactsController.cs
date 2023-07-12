﻿using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {

            var viewModel = new ContactIndexViewModel
            {
                Breadcrumb = new BreadcrumbViewModel
                {
                    Title = "CONTACT",
                    Item_1 = "HOME",
                    Item_2 = "CONTACT",
                },

                GoogleMaps = new GoogleMapsViewModel { Map = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3323.846379992451!2d18.021943310261673!3d59.34492585222009!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x465f9d9d263b022d%3A0x82fc0f30ed84f9ed!2sNackademin!5e0!3m2!1ssv!2sse!4v1679451477145!5m2!1ssv!2sse" },

            };
            return View(viewModel);
        }
    }
}
