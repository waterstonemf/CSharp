/*
 * 
Use a static class as a unit of organization for methods not associated with particular objects. 
Also, a static class can make your implementation simpler and faster because you do not have to 
create an object in order to call its methods. 

It is useful to organize the methods inside the class in a meaningful way, 
such as the methods of the Math class in the System namespace.

Static classes:
1)Can neither create their instances, nor inherit them
2)Can have static members only.
3)Cannot implement interfaces
 
Sealed classes: 
A sealed class cannot be inherited: that is it's only difference from any other type of class.
1)Can create instances, but cannot inherit
2)Can contain static as well as nonstatic members.
  
+-------------------------+---+--------+--------+--------+----------+
|       Class Type        |   | normal | static | sealed | abstract |
+-------------------------+---+--------+--------+--------+----------+
| Can be instantiated     | : | yes    | no     | yes    | no       |
| Can be inherited        | : | yes    | no     | no     | yes      |
| Can inherit from others | : | yes    | no     | yes    | yes      |
+-------------------------+---+--------+--------+--------+----------+  
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiersDemo
{
    static class StaticSealedClass
    {
        //void IDemo.Show()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
