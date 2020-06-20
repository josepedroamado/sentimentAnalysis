using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class PublicationDatabaseSaver : IPublicationSaver
    {
        public void Add(Publication aPublication)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                if (context.Publications.Include("Author").Any(publication => publication.Phrase == aPublication.Phrase))
                {
                    throw new ObjectAlreadyExistsException("Publicacion");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    PublicationDto newPublication = convert.ConvertToDto(aPublication);
                    context.Publications.Add(newPublication);
                    context.Entry(newPublication.Author).State = EntityState.Unchanged;
                    context.SaveChanges();
                }              
            }
        }

        public void Delete(Publication aPublication)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                PublicationDto publicationToDelete = context.Publications.Include("Author").FirstOrDefault(publication => publication.PublicationDtoId.Equals(aPublication.PublicationId));
                if (publicationToDelete == null)
                {
                    throw new ObjectDoesntExistException("Publicacion");
                }
                else
                {
                    context.Publications.Remove(publicationToDelete);
                    context.SaveChanges();
                }
            }
        }

        public List<Publication> FetchAll()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                List<Publication> allPublications = new List<Publication>();
                foreach (PublicationDto publication in context.Publications.Include("Author"))
                {
                    allPublications.Add(convert.ConvertToObject(publication));
                }
                return allPublications;
            }
        }

        public Publication Fetch(Publication aPublication)
        {
            return FetchPublication(aPublication.PublicationId);
        }

        public Publication FetchPublication(Guid publicationId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                PublicationDto fetchedPublication = context.Publications.Include("Author").FirstOrDefault(publication => publication.PublicationDtoId.Equals(publicationId));
                if (fetchedPublication == null)
                {
                    throw new ObjectDoesntExistException("Publicacion");
                }
                else
                {
                    return convert.ConvertToObject(fetchedPublication);
                }
            }
        }

        public void Modify(Publication original, Publication modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                PublicationDto fetchedPublication = context.Publications.Include("Author")
                    .FirstOrDefault(publication => publication.PublicationDtoId.Equals(original.PublicationId));
                if (fetchedPublication == null)
                {
                    throw new ObjectDoesntExistException("Publicacion");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    fetchedPublication.Phrase = modified.Phrase;
                    fetchedPublication.Date = modified.Date;
                    fetchedPublication.Author = convert.ConvertToDto(modified.Author);
                    context.Entry(fetchedPublication.Author).State = EntityState.Unchanged;
                    context.SaveChanges();
                }
            }
        }

        public void Clear()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                context.Publications.RemoveRange(context.Publications);
                context.SaveChanges();
            }
        }
    }
}
