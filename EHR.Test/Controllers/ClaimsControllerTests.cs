using AutoMapper;
using EHR.Api.Controllers;
using EHR.AppService.Dtos;
using EHR.Core.Interfaces;
using EHR.Core.Models;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;

namespace EHR.Test.Controllers
{
    public class ClaimsControllerTests
    {
        [Fact]
        public async Task SubmitClaimsReturnOk()
        {
            //Arrange
            var _fakeEhrService = A.Fake<IEHRService>();
            var fakeClaimDto = A.Fake<ClaimDto>();
            var fakeClaim = A.Fake<Claim>();
            var fakeMapper = A.Fake<IMapper>();
            
            A.CallTo(() => fakeMapper.Map<Claim>(fakeClaimDto)).Returns(fakeClaim);
            A.CallTo(() => _fakeEhrService.Submit(fakeClaim)).Returns(1);
            var claimsController = new ClaimsController(_fakeEhrService);

            //Act
            var result = await claimsController.Submit(fakeClaimDto);

            //Assert
            Assert.IsType<ObjectResult>(result);

        }
    }
}
