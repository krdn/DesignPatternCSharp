using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Strategy
{
    public class Article
    {
        private string _title;
        private List<string> _content;
        private string _footer;

        public Article(string title, List<string> content, string footer)
        {
            _title = title;
            _content = content;
            _footer = footer;
        }

        public string GetTitle()
        {
            return _title;
        }

        public List<string> GetContent()
        {
            return _content;
        }

        public string GetFooter()
        {
            return  _footer;    
        }
    }
}