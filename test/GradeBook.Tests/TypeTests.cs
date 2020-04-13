using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {


        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            // arrange 


            // act 

            var x = GetInt();
            SetInt(ref x);

            //assert

            Assert.Equal(42, x);


        }
        // pass by reference which is 42
        private void SetInt(ref int x)
        {
            //original value is unaffected 
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            // arrange 


            // act 

            var book1 = GetBook("Book1");
            GetBookSetName(out book1, "New Name");

            //assert

            Assert.Equal("New Name", book1.Name);


        }
        // reference to the memory location where the variable is stored 
        // alternative to ref key word is out > difference is out will assume incoming ref is not been initialized by C# compiler
        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);


        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange 


            // act 

            var book1 = GetBook("Book1");
            GetBookSetName(book1, "New Name");

            //assert

            Assert.Equal("Book1", book1.Name);


        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);


        }
        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange 


            // act 

            var book1 = GetBook("Book1");
            SetName(book1, "New Name");

            //assert

            Assert.Equal("New Name", book1.Name);


        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            //Given
            string name = "Scott";
            var upper = MakeUpperCase(name);

            //When

            //Then

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUpperCase(string parameter)
        {
           return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange 


            // act 

            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");
            //assert

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            // arrange 


            // act 

            var book1 = GetBook("Book1");
            var book2 = book1;
            //assert

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }
        // return type is Book
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
