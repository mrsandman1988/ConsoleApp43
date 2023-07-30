using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string ClothesColor { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }

            Person person = obj as Person;
            if(person != null)
            {
             return   person.FirstName == this.FirstName
                    && person.LastName == this.LastName
                    && person.DOB == this.DOB;
            }

            return false;
        }

        public override int GetHashCode()
        {
            
            int hashCode = 0;
            int start = 17;
            hashCode = start + this.FirstName.GetHashCode();
            hashCode += this.LastName.GetHashCode();
            hashCode += this.DOB.GetHashCode();
            return hashCode;
        }


    }
}
