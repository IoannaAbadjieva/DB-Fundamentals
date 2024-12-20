﻿namespace SoftJail.Data.Models;

using SoftJail.Common;
using SoftJail.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Officer
{
    public Officer()
    {
        this.OfficerPrisoners = new HashSet<OfficerPrisoner>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ValidationConstants.OfficerFullNameMaxLength)]
    public string FullName { get; set; } = null!;

    public decimal Salary { get; set; }

    public Position Position { get; set; }

    public Weapon Weapon { get; set; }

    [ForeignKey(nameof(Department))]
    public int DepartmentId  { get; set; }
    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<OfficerPrisoner> OfficerPrisoners { get; set; }
}
