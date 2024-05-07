using AutoMapper;
using Business.Abstract;
using Business.DT0s.GameDetail;
using GameStream.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class DetailController : Controller
    {
        private readonly IGameDetailService _gameDetailService;
        private readonly IMapper _mapper;

        public DetailController(IGameDetailService gameDetailService, IMapper mapper)
        {
            _gameDetailService = gameDetailService;
            _mapper = mapper;
        }

        public IActionResult Detail(int id)
        {
            var gameDetail = new DetailPageDetailsViewModel
            {
                DetailsPageGameDetail = _mapper.Map<DetailsPageGameDetailDto>(_gameDetailService.GetById(6)),

                DetailsPageGameDetails = _mapper.Map<List<DetailsPageGameDetailDto>>(_gameDetailService.GetAll().ToList())
            };

            return View(gameDetail); 
        }

    }
}
