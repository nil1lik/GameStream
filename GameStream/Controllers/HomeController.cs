using AutoMapper;
using Business.Abstract;
using Business.DT0s.GameDetail;
using GameStream.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameDetailService _gameDetailService;
        private readonly IMapper _mapper;

        public HomeController(IGameDetailService gameDetailService, IMapper mapper)
        {
            _gameDetailService = gameDetailService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var gameDetail = new DetailPageDetailsViewModel
            {
                DetailsPageGameDetail = _mapper.Map<DetailsPageGameDetailDto>(_gameDetailService.GetById(6)),

                DetailsPageGameDetails = _mapper.Map<List<DetailsPageGameDetailDto>>(_gameDetailService.GetAll().ToList())
            };

            return View(gameDetail);
        }

        public IActionResult Streams()
        {
            return View();
        }
    }
}
