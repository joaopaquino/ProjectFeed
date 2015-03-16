using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;
using System.Xml;

namespace listaFeed.Models
{
    public class Feed
    {
        string titulo;
        string resumo;
        int numeroPalavras;
        Uri link;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }      

        public int NumeroPalavras
        {
            get { return numeroPalavras; }
            set { numeroPalavras = value; }
        }       

        public Uri Link
        {
            get { return link; }
            set { link = value; }
        }

        public string Resumo
        {
            get { return resumo; }
            set { resumo = value; }
        }
    }
}