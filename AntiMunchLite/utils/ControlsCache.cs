using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AntiMunchLite
{
  public class ControlsCache<T> : List<T> where T : Control
  {
    private readonly Control.ControlCollection _HostCollection;
    private readonly Func<T> _CreateNewControlDelegate;


    public ControlsCache(Control.ControlCollection hostCollection, Func<T> createNewControlDelegate)
    {
      if (hostCollection == null) throw new ArgumentNullException("hostCollection");
      if (createNewControlDelegate == null) throw new ArgumentNullException("createNewControlDelegate");

      _HostCollection = hostCollection;
      _CreateNewControlDelegate = createNewControlDelegate;
    }

    public void AbjustSize(int newSize)
    {
      var currentSize = Count;

      if (currentSize > newSize)
        foreach (var controlToDelete in this.Take(currentSize - newSize).ToList())
        {
          Remove(controlToDelete);
          _HostCollection.Remove(controlToDelete);
          controlToDelete.Dispose();
        }

      if (currentSize < newSize)
        foreach (var newControl in Enumerable.Range(0, newSize - currentSize).Select(i => _CreateNewControlDelegate()))
        {
          Add(newControl);
          _HostCollection.Add(newControl);
        }
    }
  }
}