using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class PublicationDatabaseSaver : IPublicationSaver
    {
        public void AddPublication(Publication aPublication)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                PublicationDto newPublication = convert.ConvertToDto(aPublication);
                context.Publications.Add(newPublication);
                context.SaveChanges();
                aPublication.PublicationId = newPublication.PublicationDtoId;
            }
        }

        public void DeletePublication(Publication aPublication)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                PublicationDto publicationToDelete = context.Publications.FirstOrDefault(publication => publication.PublicationDtoId == aPublication.PublicationId);
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
                foreach (PublicationDto publication in context.Publications)
                {
                    allPublications.Add(convert.ConvertToObject(publication));
                }
                return allPublications;
            }
        }

        public Publication FetchPublication(Publication aPublication)
        {
            return FetchPublication(aPublication.PublicationId);
        }

        public Publication FetchPublication(int publicationId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                PublicationDto fetchedPublication = context.Publications.FirstOrDefault(publication => publication.PublicationDtoId == publicationId);
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

        public void ModifyPublication(Publication original, Publication modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                PublicationDto fetchedPublication = context.Publications.FirstOrDefault(publication => publication.PublicationDtoId == original.PublicationId);
                if (fetchedPublication == null)
                {
                    throw new ObjectDoesntExistException("Publicacion");
                }
                else
                {
                    fetchedPublication.Phrase = modified.Phrase;
                    fetchedPublication.Date = modified.Date;
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
