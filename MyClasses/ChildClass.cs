namespace MyClasses
{
	public class ChildClass
	{
		private int _myNumber;

		public int TotalNumbers()
		{
			return _myNumber;
		}

		public void IncrementIfTempDirectoryExists()
		{
			if (System.IO.Directory.Exists("c:\\temp"))
			{
				_myNumber++;
			}
		}

		public void Clear()
		{
			_myNumber = 0;
		}
	}
}
