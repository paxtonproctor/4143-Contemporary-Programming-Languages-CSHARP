// Paxton Proctor
// 12/1/2022
// Contemporary Programming languages C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibraryProgram_8
{
    [Serializable]
    public class RecordSerializable
    {

        // default constructor sets members to default values
        public RecordSerializable() 
            : this(0, string.Empty, 0,0) { }

        // overloaded constructor sets members to parameter values
        public RecordSerializable(int id, string name,
           double price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


    }
}
