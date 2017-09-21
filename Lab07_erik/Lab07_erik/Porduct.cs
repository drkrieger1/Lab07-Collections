using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_erik
{
    class Product
    {  
       public string Name { get; set; }
       public Color ProductColor { get; set; }
       
       public Product(string input)
        {
            Name = input;
        }  
        
    }

    enum Color
    {
        Red,
        White,
        Blue
    }
}
