using CodeDesignPlus.Core.Models.Pager;
using CodeDesignPlus.Core.Test.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesignPlus.Core.Test.Models.Pager
{
    public class ParametersTest
    {
        [Fact]
        public void Properties_AccessorsAndDataAnnotations_IsValid()
        {
            //Arrange
            var currenPage = new Random().Next(1, int.MaxValue);
            var maxPage = new Random().Next(1, int.MaxValue);
            var pageSize = new Random().Next(1, int.MaxValue);
            var parameters = new Parameters()
            {
                CurrentPage = currenPage,
                MaxPage=maxPage,
                PageSize=pageSize

            };
            //Act
            var result = parameters.Validate();

            //Assert
            Assert.Empty(result);
            Assert.Equal(currenPage, parameters.CurrentPage);
            Assert.Equal(maxPage, parameters.MaxPage);
            Assert.Equal(pageSize, parameters.PageSize);
        }
        [Fact]
        public void Property_CurrentPageIsInValid_OneValidationError()
        {
            //Arrange
            var currenPage = new Random().Next(( int.MaxValue * -1),0);
            var maxPage = new Random().Next(1, int.MaxValue);
            var pageSize = new Random().Next(1, int.MaxValue);
            var parameters = new Parameters()
            {
                CurrentPage = currenPage,
                MaxPage = maxPage,
                PageSize = pageSize

            };
            //Act
            var result = parameters.Validate();

            //Assert
            Assert.Equal(1, result.Count);
            Assert.Equal("The CurrentPage field not is valid",result.FirstOrDefault().ErrorMessage);
        }
        [Fact]
        public void Property_MaxPageIsInValid_OneValidationError()
        {
            //Arrange
            var currenPage = new Random().Next(1,int.MaxValue);
            var maxPage = new Random().Next((int.MaxValue * -1), 0);
            var pageSize = new Random().Next(1, int.MaxValue);
            var parameters = new Parameters()
            {
                CurrentPage = currenPage,
                MaxPage = maxPage,
                PageSize = pageSize

            };
            //Act
            var result = parameters.Validate();

            //Assert
            Assert.Equal(1, result.Count);
            Assert.Equal("The MaxPage field not is valid", result.FirstOrDefault().ErrorMessage);
        }
        [Fact]
        public void Property_PageSizeIsInValid_OneValidationError()
        {
            //Arrange
            var currenPage = new Random().Next(1,int.MaxValue);
            var maxPage = new Random().Next(1, int.MaxValue);
            var pageSize = new Random().Next((int.MaxValue * -1), 0);
            var parameters = new Parameters()
            {
                CurrentPage = currenPage,
                MaxPage = maxPage,
                PageSize = pageSize

            };
            //Act
            var result = parameters.Validate();

            //Assert
            Assert.Equal(1, result.Count);
            Assert.Equal("The PageSize field not is valid", result.FirstOrDefault().ErrorMessage);
        }
    }
}
