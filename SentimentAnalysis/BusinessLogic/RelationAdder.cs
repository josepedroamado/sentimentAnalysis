using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RelationAdder
    {
        private SystemData data;
        private PublicationAnalyzer publicationAnalyzer;

        public RelationAdder(SystemData data)
        {
            this.data = data;
            this.publicationAnalyzer = new PublicationAnalyzer(data.sentimentSaver, data.entitySaver);
        }
        
        public void AddRelation(Publication publication)
        {
            Relation relation = publicationAnalyzer.AnalyzePublication(publication);
            data.relationSaver.AddRelation(relation);
        }
    }
}
