using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IRelationSaver
    {
        void Add(Relation aRelation);

        void Delete(Relation aRelation);

        void Modify(Relation original, Relation modified);

        Relation Fetch(Relation aRelation);

        Relation FetchWithPublication(Guid publicationId);

        List<Relation> FetchAllWithEntity(Guid entityId);

        List<Relation> FetchAllWithSentiment(Guid sentimentId);

        List<Relation> FetchAllWithAuthor(Guid authorId);

        List<Relation> FetchAll();      

        List<Publication> FetchAllPublicationsOfEntity(Guid entityId);     

        void Clear();
    }
}
