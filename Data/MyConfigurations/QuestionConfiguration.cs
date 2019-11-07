using Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MyConfigurations
{
   public class QuestionConfiguration:EntityTypeConfiguration<Question>
    {

        public QuestionConfiguration()
        {
            Property(p => p.Content).HasColumnType("text");
        }
    }
}
