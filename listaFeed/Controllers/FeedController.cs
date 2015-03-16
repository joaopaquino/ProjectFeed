using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using listaFeed.Models;

namespace listaFeed.Controllers
{
    public class FeedController : Controller
    {
        public ActionResult Feeds()
        {
            List<Feed> feeds = new List<Feed>();            
            List<SyndicationItem> feedItens = readFeed("http://www.minutoseguros.com.br/blog/feed/");

            foreach (SyndicationItem item in feedItens)
            {
                Feed feed = new Feed();
                feed.Titulo = item.Title.Text;
                feed.Resumo = item.Summary.Text;
                feed.Link = item.Links[0].Uri;

                feeds.Add(feed);
            }
            return View(feeds);
        }

        //lista ultimos 10 feeds
        public List<SyndicationItem> readFeed(string urlBlogMinuto)
        {
            XmlReader readFeed = XmlReader.Create(urlBlogMinuto);
            SyndicationFeed feed = SyndicationFeed.Load(readFeed);
            IEnumerable<SyndicationItem> feedItens = feed.Items;
            feedItens.Skip(10);

            return feedItens.ToList();
        }
    }
}
