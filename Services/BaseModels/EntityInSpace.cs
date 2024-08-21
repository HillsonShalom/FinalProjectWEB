﻿using System.Drawing;

namespace FinalProjectWEB.Services.BaseModels
{
    public abstract class EntityInSpace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }

        
        public Point Location
        {
            get
            {
                return new Point(LocationX, LocationY);
            }
            set
            {
                LocationX = value.X;
                LocationY = value.Y;
            }
        }
    }
}
