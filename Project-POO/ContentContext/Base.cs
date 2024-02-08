using System;
using Curso.NotificationContext;

namespace Curso.ContentContext{
    public abstract class Base : Notifiable{
        public Base()
        {
            id = Guid.NewGuid();  // SPOF
        }
        public Guid id { get; set; }
    }
}