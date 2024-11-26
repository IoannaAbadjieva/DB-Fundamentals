﻿namespace TeisterMask.DataProcessor.ImportDto;

using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


[XmlType("Task")]
public class ImportTaskDto
{
    [XmlElement("Name")]
    [Required]
    [MinLength(2)]
    [MaxLength(40)]
    public string Name { get; set; } = null!;

    [XmlElement("OpenDate")]
    [Required]
    public string OpenDate { get; set; } = null!;

    [XmlElement("DueDate")]
    [Required]
    public string DueDate { get; set; } = null!;

    [XmlElement("ExecutionType")]
    [Required]
    [Range(0, 3)]
    public int ExecutionType { get; set; }

    [XmlElement("LabelType")]
    [Required]
    [Range(0, 4)]
    public int LabelType { get; set; }
}
