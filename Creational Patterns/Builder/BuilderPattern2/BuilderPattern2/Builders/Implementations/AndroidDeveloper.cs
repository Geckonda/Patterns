using BuilderPattern2.Builders.Interfaces;
using BuilderPattern2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern2.Builders.Implementations
{
	internal class AndroidDeveloper : IDeveloper
	{
		private Phone phone;
		public AndroidDeveloper() => phone = new Phone();
		public void CreateBox() => phone.AppendData("Произведен корпус Samsung\n");

		public void CreateDisplay() => phone.AppendData("Произведен дисплей Samsung\n");

		public void SystemInstall() => phone.AppendData("Установлена система Android\n");

		public Phone GetPhone() => phone;

	}
}
