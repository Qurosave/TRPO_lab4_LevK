﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=sharelink
    public class Var3Дисциплина
    {
        public string Название { get;}
        public string Сокращение { get;}

        public Var3Дисциплина(string название, string сокращение)
        {
            Название = название;
            Сокращение = сокращение;
        }   
    }
}
