﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ArchiveApp.Models
{
    public class Archive
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Стелаж
        public int Rack { get; set; }

        // Полка
        public int Shelf { get; set; }

        // Ячейка
        public int Cell { get; set; }

        [Range(0,100, ErrorMessage ="Неверные данные в Fullness. Свойство не может быть меньше нуля и больше ста!")]
        public int Fullness { get; set; }
    }
}
