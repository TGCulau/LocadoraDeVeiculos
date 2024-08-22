﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.Compartilhado;

public abstract class EntidadeBase
{
    public int Id { get; set; }

    public abstract List<string> Validar();
 }
