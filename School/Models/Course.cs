using System;
using System.Collections.Generic;

namespace School.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string Title { get; set; } = null!;

    public int Credits { get; set; }

    public virtual ICollection<EnrollmentDate> EnrollmentDates { get; set; } = new List<EnrollmentDate>();
}
