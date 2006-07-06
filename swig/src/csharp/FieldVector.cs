/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.29
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Indri {

using System;
using System.Runtime.InteropServices;

public class FieldVector : IDisposable, System.Collections.IEnumerable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FieldVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FieldVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FieldVector() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      indri_csharpPINVOKE.delete_FieldVector(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public FieldVector(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (Field element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Field this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(System.Array array) {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(System.Array array, int arrayIndex) {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, System.Array array, int arrayIndex, int count) {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  // Type-safe version of IEnumerable.GetEnumerator
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new FieldVectorEnumerator(this);
  }

  public FieldVectorEnumerator GetEnumerator() {
    return new FieldVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class FieldVectorEnumerator : System.Collections.IEnumerator {
    private FieldVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public FieldVectorEnumerator(FieldVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Field Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (Field)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }
  }

  public void Clear() {
    indri_csharpPINVOKE.FieldVector_Clear(swigCPtr);
  }

  public void Add(Field value) {
    indri_csharpPINVOKE.FieldVector_Add(swigCPtr, Field.getCPtr(value));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = indri_csharpPINVOKE.FieldVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = indri_csharpPINVOKE.FieldVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    indri_csharpPINVOKE.FieldVector_reserve(swigCPtr, n);
  }

  public FieldVector() : this(indri_csharpPINVOKE.new_FieldVector__SWIG_0(), true) {
  }

  public FieldVector(int capacity) : this(indri_csharpPINVOKE.new_FieldVector__SWIG_1(capacity), true) {
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private Field getitemcopy(int index) {
    Field ret = new Field(indri_csharpPINVOKE.FieldVector_getitemcopy(swigCPtr, index), true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Field getitem(int index) {
    Field ret = new Field(indri_csharpPINVOKE.FieldVector_getitem(swigCPtr, index), false);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Field value) {
    indri_csharpPINVOKE.FieldVector_setitem(swigCPtr, index, Field.getCPtr(value));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(FieldVector values) {
    indri_csharpPINVOKE.FieldVector_AddRange(swigCPtr, FieldVector.getCPtr(values));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public FieldVector GetRange(int index, int count) {
    IntPtr cPtr = indri_csharpPINVOKE.FieldVector_GetRange(swigCPtr, index, count);
    FieldVector ret = (cPtr == IntPtr.Zero) ? null : new FieldVector(cPtr, true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Field value) {
    indri_csharpPINVOKE.FieldVector_Insert(swigCPtr, index, Field.getCPtr(value));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, FieldVector values) {
    indri_csharpPINVOKE.FieldVector_InsertRange(swigCPtr, index, FieldVector.getCPtr(values));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    indri_csharpPINVOKE.FieldVector_RemoveAt(swigCPtr, index);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    indri_csharpPINVOKE.FieldVector_RemoveRange(swigCPtr, index, count);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FieldVector Repeat(Field value, int count) {
    IntPtr cPtr = indri_csharpPINVOKE.FieldVector_Repeat(Field.getCPtr(value), count);
    FieldVector ret = (cPtr == IntPtr.Zero) ? null : new FieldVector(cPtr, true);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    indri_csharpPINVOKE.FieldVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    indri_csharpPINVOKE.FieldVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, FieldVector values) {
    indri_csharpPINVOKE.FieldVector_SetRange(swigCPtr, index, FieldVector.getCPtr(values));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}

}