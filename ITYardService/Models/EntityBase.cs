using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    //public class EntityBase : Entity
    //{
    //   public int Id;
    //    public string Name;
    //    public override void DisplayEntityInfo()
    //    {
    //        Console.WriteLine($"Id - {this.Id}, name - {this.Name}");
    //    }
    //    public override bool Validate()
    //    {
    //        if (string.IsNullOrWhiteSpace(this.Name))
    //        {
    //            return false;
    //        }
    //        return true;
    //    }
    //}

    public abstract class EntityBase<T>
    {
        public T Id { get; set; }
        public virtual void DisplayEntityInfo()
        {
            Console.WriteLine($"Id - {this.Id}");
        }
        public abstract bool Validator();

        public EntityBase(T id)
        {
            this.Id = id;
        }
    }





}
