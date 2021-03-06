﻿using System.Collections.Generic;

namespace CAPP.Domain.Entities
{
    public class OperationObject
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public List<OperationOperationObject> OperationOperationObjects { get; set; }
    }
}
