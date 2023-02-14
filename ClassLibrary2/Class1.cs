using System.Diagnostics;
using System.Windows.Controls;

namespace ClassLibrary2
{
    public class test
    {
        public int x;
        public void MyFunction(Button button)
        {
            Debug.WriteLine("hello");

            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();

            class1.test(button);
        }
    }
}
