using System;
using System.Collections.Generic;

namespace DatabaseFirstEntetiy.Models;

public partial class Student
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public int? Year { get; set; }
}
