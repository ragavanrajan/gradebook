using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            // arrange 
           

            // act 
           
           var book1 = GetBook("Book1"); 
           var book2 = GetBook("Book 2");
            //assert
          
          Assert.Equal("Ragavan's Grade Book", book1.Name);
          Assert.Equal("Ragavan's Grade Book", book2.Name);
          
        }
// return type is Book
        Book GetBook(string name)
        {
           return new Book(name);
        }
    }
}
