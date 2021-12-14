using System;

namespace Library.DataStructures
{
    /// <summary>
    /// The id of the author <img src="Assets/doxygen.png" />
    /// but the truth is
    /// that this is not that easy
    ///
    /// for instance this is an example
    /// - aaa
    /// - bbb
    /// </summary>
    public class Book
    {
        public Guid Id { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
