using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.API.Employees
{
    public class EmployeeActionResponseDto
    {
        private object value;

        public EmployeeActionResponseDto(object value)
        {
            this.value = value;
        }

        public Guid Id { get; internal set; }
    }
}