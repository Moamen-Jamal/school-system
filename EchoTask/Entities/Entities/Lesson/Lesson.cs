﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Lesson : BaseModel
    {
        public string Name { get; set; }
        
        public virtual ICollection<ClassLesson> ClassLessons { get; set; }

    }
}
