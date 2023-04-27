using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Strategy
{
    public class SimpleDisplayArticle : DisplayArticleTemplate
    {
        public SimpleDisplayArticle(Article article) : base(article)
        {
        }

        protected override void DisplayTitle()
        {
            Console.WriteLine(_article.GetTitle());
        }

        protected override void DisplayContent()
        {
            foreach (var item in _article.GetContent())
            {
                Console.WriteLine(item);
            }
        }

        protected override void DisplayFooter()
        {
            Console.WriteLine(_article.GetFooter());
        }   
    }
}