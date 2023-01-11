using BuilderPattern.Products.Pastry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Workers
{
	// пекарь
	class Baker
	{
		public Bread Bake(BreadBuilder breadBuilder)
		{
			breadBuilder.CreateBread();
			breadBuilder.SetFlour();
			breadBuilder.SetSalt();
			breadBuilder.SetAdditives();
			return breadBuilder.Bread;
		}
	}
}
