using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook.Core.Domain
{
    public class Note : Entity
    {
        public string Title { get; protected set; }
        public string Content { get; protected set; }
        public string KeyWordsSummary { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        public Note()
        {

        }
        public Note(Guid id, string title, string content, string keyWordsSummary)
        {
            Id = id;
            SetTitle(title);
            SetContent(content);
            SetKeyWordsSummary(keyWordsSummary);
            Content = content;
            KeyWordsSummary = keyWordsSummary;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception($"Note with id: '{Id}' can not have an empty title.");
            }
            Title = title;
            UpdatedAt = DateTime.UtcNow;
        }
        public void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new Exception($"Note with id: '{Id}' can not have an empty content.");
            }
            Content = content;
            UpdatedAt = DateTime.UtcNow;
        }
        public void SetKeyWordsSummary(string keyWordsSummary)
        {
            if (string.IsNullOrWhiteSpace(keyWordsSummary))
            {
                throw new Exception($"Note with id: '{Id}' can not have an empty keyWordsSummary.");
            }
            KeyWordsSummary = keyWordsSummary;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
