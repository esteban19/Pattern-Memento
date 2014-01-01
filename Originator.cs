using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private string article;

        public void set(string newArticle)
        {
            Console.WriteLine("From Originator: Current Version of Article\n"
                + newArticle + "\n");
            article = newArticle;
        }
        public Memento storeInMemento()
        {
            Console.WriteLine("From Originator: Saving to Memento");
            return new Memento(article);
        }
        public string restoreFromMemento(Memento memento)
        {
            article = memento.getSavedState();
            Console.WriteLine("From Originator: Previous Article Saved in Memento\n"
                + article + "\n");
            return article;
        }
    }
}
