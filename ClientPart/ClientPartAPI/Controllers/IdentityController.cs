﻿using ClientPartBLL.DTO.Requests;
using ClientPartBLL.DTO.Responses;
using ClientPartBLL.Services.Interfaces;
using ClientPartDAL.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientPartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private IUnitOfBisnes _UnitOfBisnes;
        private IValidator<ClientSignUpRequest> _SingUpValidator;
        private IValidator<ClientSignInRequest> _SingInValidator;



        [HttpPost("signIn")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JwtResponse>> SignInAsync(
            [FromBody] ClientSignInRequest request)
        {
            try
            {
                var valid = _SingInValidator.Validate(request);

                if (request == null) { throw new ArgumentNullException(nameof(request)); }
                if (!valid.IsValid) { throw new ValidationException(valid.Errors); }

                var response = await _UnitOfBisnes._IdentityService.SignInAsync(request);
                return Ok(response);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }



        [HttpPost("signUp")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<JwtResponse>> SignUpAsync(
         [FromBody] ClientSignUpRequest request)
        {
            try
            {
                if (request == null) { throw new ArgumentNullException(nameof(request)); }
                if (!_SingUpValidator.Validate(request).IsValid) { throw new Exception(nameof(request)); }

                var response = await _UnitOfBisnes._IdentityService.SignUpAsync(request);

                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
            }
        }










        public IdentityController(IUnitOfBisnes UnitOfBisnes, IValidator<ClientSignInRequest> singinvalidator, IValidator<ClientSignUpRequest> singupvalidator)
        {
            _UnitOfBisnes = UnitOfBisnes;
            _SingInValidator = singinvalidator;
            _SingUpValidator = singupvalidator;




        }
    }
}
