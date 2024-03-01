﻿
namespace Projection
{
    internal class EmployeeDTO
        // Data Transfer Object
    {
        public string Name { get; set; }
        public int TotalSkills { get; set; }

        public override string ToString()
        {
            return $"{Name} {TotalSkills}";
        }

    }
}
