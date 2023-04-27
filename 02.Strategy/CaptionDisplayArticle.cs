using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Strategy
{
    public class CaptionDisplayArticle : DisplayArticleTemplate
    {
        public CaptionDisplayArticle(Article article) : base(article)
        {
        }

        protected override void DisplayTitle()
        {
            Console.WriteLine("TITLE: " + _article.GetTitle());
        }

        protected override void DisplayContent()
        {
            Console.WriteLine("CONTENT: ");
            foreach (var item in _article.GetContent())
            {
                Console.WriteLine("    " + item);
            }
        }

        protected override void DisplayFooter()
        {
            Console.WriteLine("FOOTER: " + _article.GetFooter());
        }
    }
}