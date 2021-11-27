using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Database4Adult1.Domain
{
    public class Adult : Person
    {
        private IList<Adult> adults;
        
        public string Jobtitle { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        
    }
}