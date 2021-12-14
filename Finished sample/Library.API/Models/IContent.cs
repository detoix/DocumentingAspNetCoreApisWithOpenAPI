using System;

namespace Library.API.Models
{

    public interface IContent<T>
    {
        T Content { get; }
    }    
}
