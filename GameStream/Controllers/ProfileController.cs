using AutoMapper;
using Business.Abstract;
using Business.DT0s.GameDetail;
using GameStream.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class ProfileController : Controller
    {

        private readonly IGameDetailService _gameDetailService;
        private readonly IMapper _mapper;

        public ProfileController(IGameDetailService gameDetailService, IMapper mapper)
        {
            _gameDetailService = gameDetailService;
            _mapper = mapper;
        }
        public IActionResult Profile()
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


