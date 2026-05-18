using System;
using System.Collections.Generic;

namespace School.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly EnrollmentDate { get; set; }

    public virtual ICollection<EnrollmentDate> EnrollmentDates { get; set; } = new List<EnrollmentDate>();
}
