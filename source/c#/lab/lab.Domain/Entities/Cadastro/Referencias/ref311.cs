﻿using lab.Domain.Entities.Bloco.b0;
using System;
using System.Collections.Generic;

namespace lab.Domain.Entities.Cadastro.Referencias
{
    public class Ref311
    {
        public int Id { get; private set; }
        public string Codigo { get; set; }
        public string Versao { get; set; }
        public string Leiaout { get; set; }
        public DateTime Periodo { get; set; }
        public virtual ICollection<Reg0000> Regs0000 { get; set; }
    }
}
