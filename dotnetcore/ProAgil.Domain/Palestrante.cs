﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProAgil.Domain
{
    class Palestrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string MiniCurriculo { get; set; }
        public string ImagemUtl { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<RedeSocial> RedesSociais { get; set; }
    }
}
