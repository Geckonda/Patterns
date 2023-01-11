using BuilderPattern2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern2.Builders.Interfaces
{
	internal interface IDeveloper
	{
		void CreateDisplay();
		void CreateBox();
		void SystemInstall();
		Phone GetPhone();
	}
}
