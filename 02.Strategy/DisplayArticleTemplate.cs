using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Strategy
{
    public abstract class DisplayArticleTemplate
    {
        protected Article _article;

        public DisplayArticleTemplate(Article article)
        {
            _article = article;
        }

        public void Display()
        {
            DisplayTitle();
            DisplayContent();
            DisplayFooter();
        }

        protected abstract void DisplayTitle();
        protected abstract void DisplayContent();
        protected abstract void DisplayFooter();


    }
}