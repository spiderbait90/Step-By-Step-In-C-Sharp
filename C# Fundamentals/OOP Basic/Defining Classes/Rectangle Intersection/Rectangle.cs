using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rectangle
{
    private string id;
    private decimal width;
    private decimal height;
    private decimal coordinatesTopLeftX;
    private decimal coordinatesTopLeftY;

    public Rectangle(string id, decimal width, decimal height, decimal coordinatesTopLeftY, decimal coordinatesTopLeftX)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.coordinatesTopLeftX = coordinatesTopLeftX;
        this.coordinatesTopLeftY = coordinatesTopLeftY;

    }

    public string Id => this.id;

    public bool IntersectsRectangle(Rectangle r)
    {
        return this.ContainsRectangleCorner(r) || r.ContainsRectangleCorner(this);
    }

    private bool ContainsRectangleCorner(Rectangle r)
    {
        return this.ContainsPoint(r.coordinatesTopLeftX, r.coordinatesTopLeftY) ||
               this.ContainsPoint(r.coordinatesTopLeftX, r.coordinatesTopLeftY + height) ||
               this.ContainsPoint(r.coordinatesTopLeftX + width, r.coordinatesTopLeftY) ||
               this.ContainsPoint(r.coordinatesTopLeftX + width, r.coordinatesTopLeftY + height);
    }

    private bool ContainsPoint(decimal x, decimal y)
    {
        return x >= this.coordinatesTopLeftX && x <= this.coordinatesTopLeftX + width &&
               y >= this.coordinatesTopLeftY && y <= this.coordinatesTopLeftY + height;
    }
}

