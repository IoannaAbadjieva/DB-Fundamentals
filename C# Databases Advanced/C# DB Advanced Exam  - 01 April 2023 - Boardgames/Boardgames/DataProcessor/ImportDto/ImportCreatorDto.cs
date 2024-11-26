﻿namespace Boardgames.DataProcessor.ImportDto;

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

using Boardgames.Common;

[XmlType("Creator")]
public class ImportCreatorDto
{

    [Required]
    [MinLength(ValidationConstants.CreatorFirstNameMinLength)]
    [MaxLength(ValidationConstants.CreatorFirstNameMaxLength)]
    public string FirstName { get; set; } = null!;

    [Required]
    [MinLength(ValidationConstants.CreatorLastNameMinLength)]
    [MaxLength(ValidationConstants.CreatorLastNameMaxLength)]
    public string LastName { get; set; } = null!;

    [XmlArray("Boardgames")]
    public ImportBoardgameDto[] Boardgames { get; set; } = null!;
}
