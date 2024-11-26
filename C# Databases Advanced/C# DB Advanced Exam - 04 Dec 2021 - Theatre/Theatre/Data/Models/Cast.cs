﻿namespace Theatre.Data.Models;

using global::Theatre.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cast
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ValidatioConstants.CastFullNameMaxLength)]
    public string FullName { get; set; } = null!;

    public bool IsMainCharacter { get; set; }

    [Required]
    public string PhoneNumber { get; set; } = null!;

    [ForeignKey(nameof(Play))]
    public int 	PlayId  { get; set; }
    public virtual Play Play { get; set; } = null!;
}
