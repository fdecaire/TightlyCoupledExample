namespace MyClasses
{
    public class MyRootClass
    {
	    readonly ChildClass _childClass = new ChildClass();

		public bool CountExceeded()
	    {
		    if (_childClass.TotalNumbers() > 5)
		    {
			    return true;
		    }
		    return false;
	    }

	    public void Increment()
	    {
		    _childClass.IncrementIfTempDirectoryExists();
	    }
    }
}
