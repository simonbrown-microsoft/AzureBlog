﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlog.Models
{

    public class Article : IArticle
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Content { get; set; }
        public List<string> Categories { get; set; }
        public DateTimeOffset PublishedDateTime { get; set; }
        public String ImageUri { get; set; }

        public Article()
        {

        }

        public Article(string newTitle, List<String> newAuthors, string newContent, List<string> newCategories, DateTimeOffset publishedDateTime, String newImageUri)
        {
            Title = newTitle;
            Authors = newAuthors;
            Content = newContent;
            Categories = newCategories;
            PublishedDateTime = publishedDateTime;
            ImageUri = newImageUri;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
