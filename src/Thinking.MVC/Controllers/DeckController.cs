using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Thinking.Data;

namespace Thinking.MVC.Controllers
{
    public class DeckController : Controller
    {
        private readonly IDeckData _deckData;

        public DeckController(IDeckData deckData)
        {
            _deckData = deckData;
        }


        public IActionResult Index()
        {


            return View();
        }
    }
}
