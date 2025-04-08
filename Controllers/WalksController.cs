using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZwalks.CustomActions;
using NZwalks.DTO;
using NZwalks.Models;
using NZwalks.Repositories;

namespace NZwalks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController(IWalksRepository walksRepository, IMapper mapper) : ControllerBase
    {
        private readonly IWalksRepository _walksRepository = walksRepository;
        private readonly IMapper _mapper = mapper;


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Walks> walks = await _walksRepository.GetAllWalksAsync();
            List<WalksResponseDTO> walksResponse = _mapper.Map<List<WalksResponseDTO>>(walks);
            return Ok(walksResponse);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            WalksResponseDTO walkById = _mapper.Map<WalksResponseDTO>(await _walksRepository.GetWalksByIdAsync(id));

            if (walkById == null) {
                return NotFound();
            }

            return Ok(walkById);
        }


        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> CreateWalk([FromBody] WalksRequestDTO request)
        {
                Walks walkToBeCreated = _mapper.Map<Walks>(request);

                Walks res = await _walksRepository.CreateWalkAsync(walkToBeCreated);

                WalksResponseDTO walksResponse = _mapper.Map<WalksResponseDTO>(res);

                return CreatedAtAction(nameof(GetById), new { id = walksResponse.Id }, walksResponse);
            
        }

        [HttpDelete]
        [Route("${id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var isDeleted = await _walksRepository.DeleteWalkAsync(id);

            if (!isDeleted)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }

        [HttpPut]
        [Route("${id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> UpdateWalks([FromRoute] Guid id, [FromBody] WalksRequestDTO updateRequest)
        {

                var walksRequest = _mapper.Map<Walks>(updateRequest);
                var updatedWalk = await _walksRepository.UpdateWalkAsync(id, walksRequest);

                if (updatedWalk != null)
                {
                    return Ok(_mapper.Map<WalksResponseDTO>(updatedWalk));
                }
                else
                {
                    return NotFound();
                }

        }

    }
}
