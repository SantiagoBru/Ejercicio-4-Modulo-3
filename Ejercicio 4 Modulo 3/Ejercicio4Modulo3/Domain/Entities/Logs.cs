﻿#nullable disable
using System;
using System.Collections.Generic;

namespace Ejercicio4Modulo3.Models;

public partial class Logs
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string Path { get; set; }
    public string Method { get; set; }
    public bool Success { get; set; }
}