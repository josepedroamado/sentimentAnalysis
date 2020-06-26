using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class AuthorDatabaseSaver : IAuthorSaver
    {
        public void Add(Author anAuthor)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                if (context.Authors.Any(author => author.AuthorDtoId == anAuthor.AuthorId))
                {
                    throw new ObjectAlreadyExistsException("Autor");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    AuthorDto newAuthor = convert.ConvertToDto(anAuthor);
                    context.Authors.Add(newAuthor);
                    context.SaveChanges();
                }
            }
        }
        public void Delete(Author anAuthor)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                AuthorDto authorToDelete = context.Authors.FirstOrDefault(author => author.AuthorDtoId == anAuthor.AuthorId);
                if (authorToDelete == null)
                {
                    throw new ObjectDoesntExistException("Autor");
                }
                else
                {
                    context.Authors.Remove(authorToDelete);
                    context.SaveChanges();
                }
            }
        }

        public void Modify(Author original, Author modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                AuthorDto fetchedAuthor = context.Authors.FirstOrDefault(author => author.AuthorDtoId == original.AuthorId);
                if (fetchedAuthor == null)
                {
                    throw new ObjectDoesntExistException("Autor");
                }
                else
                {
                    fetchedAuthor.BirthDate = modified.BirthDate;
                    fetchedAuthor.FirstName = modified.FirstName;
                    fetchedAuthor.LastName = modified.LastName;
                    fetchedAuthor.UserName = modified.UserName;
                    context.SaveChanges();
                }
            }
        }

        public Author Fetch(Guid anAuthor)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                AuthorDto fetchedAuthor = context.Authors.FirstOrDefault(author => author.AuthorDtoId == anAuthor);
                if (fetchedAuthor == null)
                {
                    throw new ObjectDoesntExistException("Alarma");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    return convert.ConvertToObject(fetchedAuthor);
                }
            }
        }

        public List<Author> FetchAll()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                List<Author> allAuthors = new List<Author>();
                foreach (AuthorDto author in context.Authors)
                {
                    ObjectConversion convert = new ObjectConversion();
                    allAuthors.Add(convert.ConvertToObject(author));
                }
                return allAuthors;
            }
        }

        public void Clear()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                context.Authors.RemoveRange(context.Authors);
                context.SaveChanges();
            }
        }
    }
}
