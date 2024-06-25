using Flowers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers.Domain.Models
{
    public class FlowersListModel<T>
    {
        // запрошенный список объектов
        public List<T> Items { get; set; } = new();
        // номер текущей страницы
        public int CurrentPage { get; set; } = 1;
        // общее количество страниц
        public int TotalPages { get; set; } = 1;

        public static implicit operator FlowersListModel<T>(FlowersListModel<Flower> v)
        {
            throw new NotImplementedException();
        }
    }
}
