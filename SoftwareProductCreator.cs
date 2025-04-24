using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SoftwareProductCreator : ProductCreator
{
    public override IDigitalProduct CreateProduct()
    {
        return new SoftwareProduct();
    }
} 