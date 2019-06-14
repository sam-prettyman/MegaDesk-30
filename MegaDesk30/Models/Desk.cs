using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk30.Models
{
    public class Desk
    {
        public int ID { get; set; }
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public Material newMaterial { get; set; }

        // Non-Default Constructor 
       /* public Desk(int newWidth, int newDepth, int newDrawers, int newMaterial)
        {
            this.width = newWidth;
            this.depth = newDepth;
            this.numDrawers = newDrawers;
            this.newMaterial.ID = newMaterial;
        }

    */
        public decimal surfaceArea()
        {
            return width * depth;
        }



    }
}
