using System;
using System.Collections.Generic;
using chatbot.Models;

namespace chatbot.Interfaces
{
    public interface IDishCategory
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
