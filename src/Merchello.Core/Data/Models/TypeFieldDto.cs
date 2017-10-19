﻿namespace Merchello.Core.Data.Models
{
    using System;

    internal class TypeFieldDto
    {
        public Guid Pk { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}