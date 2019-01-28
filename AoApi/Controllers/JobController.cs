﻿using AoApi.Data.Models;
using AoApi.Services.Data.DtoModels.JobDtos;
using AoApi.Services.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AoApi.Controllers
{
    [Route("api/employees/{employeeId}/job")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobRepository _jobRepository;

        public JobController(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }


        // make is possible to have more than one job??
        //[HttpGet]
        //public async Task<IActionResult> GetAllJobsAsync([FromRoute] Guid employeeId)
        //{
        //    if (!await _jobRepository.EntityExists<Employee>(e => e.Id == employeeId))
        //    {
        //        return NotFound();
        //    }

        //    var foundJob = await _jobRepository.GetJobByEmployeeId(employeeId); // make get ALL jobs

        //    var jobToReturn = Mapper.Map<JobDto>(foundJob);

        //    return Ok(jobToReturn);
        //}

        [HttpGet("{jobId}")]
        public async Task<IActionResult> GetOneJobAsync([FromRoute] Guid employeeId,[FromRoute] Guid jobId)
        {
            if (!await _jobRepository.EntityExists<Employee>(e => e.Id == employeeId))
            {
                return NotFound();
            }

            var foundJob = await _jobRepository.GetFirstByConditionAsync(j => j.Id == jobId);

            if (foundJob == null)
            {
                return NotFound();
            }

            return Ok(foundJob);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobAsync([FromBody] JobCreateDto jobToCreate)
        {
            var jobToAdd = Mapper.Map<Job>(jobToCreate);
            jobToAdd.Id = Guid.NewGuid();

            _jobRepository.Create(jobToAdd);

            await _jobRepository.SaveChangesAsync();

            var foundJob = await _jobRepository.GetFirstByConditionAsync(j => j.Id == jobToAdd.Id);

            return Ok();
        }

        [HttpPut("{jobId}")]
        public async Task<IActionResult> UpdateJobAsync([FromRoute] Guid jobId, [FromBody] JobUpdateDto jobToUpdate)
        {
            var foundJob = await _jobRepository.GetFirstByConditionAsync(j => j.Id == jobId);

            if (foundJob == null)
            {
                var jobToAdd = Mapper.Map<Job>(jobToUpdate);
                jobToAdd.Id = Guid.NewGuid();

                _jobRepository.Create(jobToAdd);

                await _jobRepository.SaveChangesAsync();

                var jobToReturn = await _jobRepository.GetFirstByConditionAsync(j => j.Id == jobToAdd.Id);

                return CreatedAtRoute("GetJob", new { jobId = jobToReturn.Id }, jobToReturn);
            }

            Mapper.Map(jobToUpdate, foundJob);

            _jobRepository.Update(foundJob);

            // check if it returns "old" job before update. Else find and return?
            return Ok(foundJob);

            //return NoContent();
        }

        [HttpPatch("{jobId}")]
        public async Task<IActionResult> PartialUpdateJobAsync([FromRoute] Guid jobId, [FromBody] JsonPatchDocument<JobUpdateDto> jobToPartialUpdate)
        {
            if (jobToPartialUpdate == null)
                return BadRequest();

            var foundJob = await _jobRepository.GetFirstByConditionAsync(j => j.Id == jobId);

            if (foundJob == null)
            {
                var jobToCreate = new JobUpdateDto();

                // check if necessary
                jobToPartialUpdate.ApplyTo(jobToCreate, ModelState);

                var jobToAdd = Mapper.Map<Job>(jobToCreate);
                jobToAdd.Id = Guid.NewGuid();

                _jobRepository.Create(jobToAdd);

                await _jobRepository.SaveChangesAsync();

                var jobToReturn = await _jobRepository.GetFirstByConditionAsync(j => j.Id == jobToAdd.Id);

                return CreatedAtRoute("GetJob", new { jobId = jobToReturn.Id }, jobToReturn);
            }
            // why map back and fourth?
            var jobToPatch = Mapper.Map<JobUpdateDto>(foundJob);

            // check if necessary
            jobToPartialUpdate.ApplyTo(jobToPatch, ModelState);

            // why map back and fourth?
            Mapper.Map(jobToPatch, foundJob);

            _jobRepository.Update(foundJob);

            await _jobRepository.SaveChangesAsync();

            // check if it returns "old" job before update. Else find and return?
            return Ok(foundJob);

            //return NoContent();
        }

        [HttpDelete("{jobId}")]
        public async Task<IActionResult> DeleteJobAsync([FromRoute] Guid jobId)
        {
            var foundJob = await _jobRepository.GetFirstByConditionAsync(j => j.Id == jobId);

            if (foundJob == null)
                return NotFound();

            _jobRepository.Delete(foundJob);
            return Ok();
        }
    }
}
