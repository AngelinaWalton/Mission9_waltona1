using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_waltona1.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public virtual void AddItem (Books books, int qty, double price)
        {
            BasketLineItem Line = Items
                .Where(b => b.Books.BookId == books.BookId)
                .FirstOrDefault();

            if (Line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Books = books,
                    Quantity = qty,
                    Price = price
                });
            }
            else
            {
                Line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Books books)
        {
            Items.RemoveAll(x => x.Books.BookId == books.BookId);
        }
        public virtual void ClearBasket()
        {
            Items.Clear();
        }
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Price);

            return sum;
        }
    }

    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Books Books { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
