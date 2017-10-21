using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomStringEditorInNullModel.Models
{
    public class ModelWithCustomStringEditor
    {
        [UIHint("Custom")]
        public string SectionedKey { get; set; }
        public string hello { get; set; } = "I am in editor";
    }
}
