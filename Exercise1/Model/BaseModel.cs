
using System;

namespace Exercise1.Model
{
    public class BaseModel
    {
        public virtual int Id { get; internal set; }

        public virtual string Name { get; internal set; }

        public virtual DateTime InsertTime { get { return DateTime.Now; } }

        public virtual DateTime? DeleteTime { get; set; }
    }
}
