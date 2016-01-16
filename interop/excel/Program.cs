using System;

namespace excel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			datastruct data = new datastruct();
			IOwrite write = new IOwrite (data);
			//набиране на данни в основната таблица

			data.addRow ("Мартин", "Симеонов", "30");
			data.addRow ("Весела", "Христова", "50");
			//Проверка на таблица
			data.PrintTable();

		}
	}
}
