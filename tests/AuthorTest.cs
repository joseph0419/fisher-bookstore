using System;
using Fisher.Bookstore.Models;
using Xunit;
using System.Collections.Generic;

namespace tests.AuthorTest
{
    public class AuthorTest 
    {
        [Fact]
        public void ChangeAuthorName()
        {
            var Author = new Author()
            {
                Id = 2,
                Name = "Joseph Yu"
            };

            //Act
            var newAuthorName = "Joseph Yuu";
            Author.ChangeAuthorName(newAuthorName);

            //Assert 
            var expectedAuthorName = newAuthorName;
            var actualAuthorName = Author.Name;

            Assert.Equal(expectedAuthorName, actualAuthorName);
        }

        [Fact]
        public void AddBookTitle()
        {
            var Author = new Author()
            {
                Id = 3,
                Name = "Buckeye Yu",
                Titles = new List<Book>{}
                };
            
            var Book = new Book()
            {
                Id = 5,
                Title = "Ok",
            };
            //Act
            Author.Titles.Add(Book);
            var newBookTitles = Author.Titles;
            
            //Assert
            var expectedBookTitles = newBookTitles;
            var actualBookTitles = Author.Titles;

            Assert.Equal(expectedBookTitles, actualBookTitles);
            }
        }
    }
