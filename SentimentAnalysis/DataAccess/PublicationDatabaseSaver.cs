using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PublicationDatabaseSaver : IPublicationSaver
    {
        public void AddPublication(Publication aPublication)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                if (context.Publications.Any(publication => publication.PublicationDtoId == aPublication.PublicationId))
                {
                    throw new ObjectAlreadyExistsException("Publicacion");
                }
                else
                {
                    PublicationDto newPublication = ConvertToDto(aPublication);
                    context.Publications.Add(newPublication);
                    context.SaveChanges();
                    aPublication.PublicationId = newPublication.PublicationDtoId;
                }
            }
        }

        private PublicationDto ConvertToDto(Publication aPublication)
        {
            PublicationDto convertedPublication = new PublicationDto
            {
                PublicationDtoId = aPublication.PublicationId,
                Phrase = aPublication.Phrase,
                Date = aPublication.Date
            };
            return convertedPublication;
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
                List<Publication> allPublications = new List<Publication>();
                foreach (PublicationDto publication in context.Publications)
                {
                    allPublications.Add(ConvertToObject(publication));
                }
                return allPublications;
            }
        }

        private Publication ConvertToObject(PublicationDto aPublication)
        {
            Publication convertedPublication = new Publication(aPublication.Phrase, aPublication.Date)
            {
                PublicationId = aPublication.PublicationDtoId
            };
            return convertedPublication;
        }

        public Publication FetchPublication(Publication aPublication)
        {
            return FetchPublication(aPublication.PublicationId);
        }
        public Publication FetchPublication(int publicationId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                PublicationDto fetchedPublication = context.Publications.FirstOrDefault(publication => publication.PublicationDtoId == publicationId);
                if (fetchedPublication == null)
                {
                    throw new ObjectDoesntExistException("Publicacion");
                }
                else
                {
                    return ConvertToObject(fetchedPublication);
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
