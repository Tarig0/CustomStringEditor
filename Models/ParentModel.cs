using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomStringEditorInNullModel.Models
{
    public class ParentModel
    {
        public IEnumerable<ModelWithCustomStringEditor> ModelWithCustomStringEditors { get; set; }
        public string Name { get; set; }
    }
}
