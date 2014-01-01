using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Program
    {
        public static void Main()
        {
            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator();
            int saveFiles = 0, currentArticle = 0;

            string text1 = "This is new text.";
            originator.set(text1);
            caretaker.AddMemento(originator.storeInMemento());
            saveFiles++;
            currentArticle++;
            Console.WriteLine("Save Files " + saveFiles);

            if (currentArticle >= 1)
            {
                currentArticle--;
                string textBoxString = originator.restoreFromMemento(caretaker.GetMemento(currentArticle));
                Console.WriteLine(textBoxString);
            }

            if ((saveFiles - 1) > currentArticle)
            {
                currentArticle++;
                string textBoxString = originator.restoreFromMemento(caretaker.GetMemento(currentArticle));
                Console.WriteLine(textBoxString);
            }

            Console.WriteLine("---------------------");
            string text2 = "This is new 2 text.";
            originator.set(text2);
            caretaker.AddMemento(originator.storeInMemento());
            string text3 = "This is new 3 text.";
            originator.set(text3);
            caretaker.AddMemento(originator.storeInMemento());
            string text4 = "This is new 4 text.";
            originator.set(text4);
            caretaker.AddMemento(originator.storeInMemento());
            Console.WriteLine("---------------------");
            Console.WriteLine(originator.restoreFromMemento(caretaker.GetMemento(0)));
            Console.WriteLine(originator.restoreFromMemento(caretaker.GetMemento(1)));
            Console.WriteLine(originator.restoreFromMemento(caretaker.GetMemento(2)));
            Console.WriteLine(originator.restoreFromMemento(caretaker.GetMemento(3)));
        }
    }
}
