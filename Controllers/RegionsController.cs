using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZwalks.CustomActions;
using NZwalks.Data;
using NZwalks.DTO;
using NZwalks.Models;
using NZwalks.Repositories;

namespace NZwalks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController( IRegionRepository regionRepository, IMapper mapper) : ControllerBase
    {

        public readonly IRegionRepository RegionRepository = regionRepository;

        public readonly IMapper mapper = mapper;  


        // get all regions
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Region> allRegions = await RegionRepository.GetRegionsAsync();
            List<RegionsResponseDTO> allRegionsResult = mapper.Map<List<RegionsResponseDTO>>(allRegions);

            return Ok(allRegionsResult);
        }


        // get region by id

        [HttpGet]
        [Route("{id:Guid}")]

        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            Region? regionById = await RegionRepository.GetRegionByIdAsync(id);

            if (regionById == null)
            {
                return NotFound();
            }

            RegionsResponseDTO res = mapper.Map<RegionsResponseDTO>(regionById);
            return Ok(res);
        }


        // create region
        [HttpPost]
        [ValidateModel]
        public async  Task<IActionResult> Create([FromBody] RegionsRequestDTO request) {
                Region regionToBeCreated = mapper.Map<Region>(request);
                Region regionCreated = await RegionRepository.CreateRegionAsync(regionToBeCreated);

                RegionsResponseDTO res = mapper.Map<RegionsResponseDTO>(regionCreated);


                return CreatedAtAction(nameof(GetById), new { id = regionCreated.Id }, res);
         }
    


        // update region

        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] RegionsUpdateRequestDTO request)
        {


                Region? regionToBeUpdated = await RegionRepository.UpdateRegionAsync(request, id);

                if (regionToBeUpdated == null)
                {
                    return NotFound();
                }

                RegionsResponseDTO response = mapper.Map<RegionsResponseDTO>(regionToBeUpdated);

                return Ok(response);
        }

        // delete region
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var regionDeleted = await RegionRepository.DeleteRegionAsync(id);
            if(regionDeleted == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
