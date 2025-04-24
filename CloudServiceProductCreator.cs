using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CloudServiceProductCreator : ProductCreator
{
    public override IDigitalProduct CreateProduct()
    {
        return new CloudServiceProduct();
    }
} 