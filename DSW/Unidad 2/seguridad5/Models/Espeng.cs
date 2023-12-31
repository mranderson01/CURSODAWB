﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace seguridad5.Models;

[Table("Espeng")]
public partial class Espeng
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    [DisplayName("Español")]
    public string esp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    [DisplayName("Inglés")]
    public string ing { get; set; }

    public List<Frase> frase { get; set; }  
}