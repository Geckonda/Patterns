using BuilderPattern2.Builders.Interfaces;
using BuilderPattern2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern2.Builders.Implementations
{
	internal class IPhoneDeveloper : IDeveloper
	{

		private Phone phone;
		public IPhoneDeveloper() => phone = new Phone();
		public void CreateBox() => phone.AppendData("Произведен корпус Samsung\n");

		public void CreateDisplay() => phone.AppendData("Произведен дисплей Iphone\n");

		public void SystemInstall() => phone.AppendData("Установлена система Iphone\n");

		public Phone GetPhone() => phone;
	}
}
