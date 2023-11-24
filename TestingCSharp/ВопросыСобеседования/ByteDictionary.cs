using System.Collections;

namespace TestingCSharp.ВопросыСобеседования;

public class ByteDictionary
{
    /*
        *    When using collections such as Dictionary or HashSet, in which the key
        *    will be an array of some type, key collisions do not work properly
        *    if two keys have equal value sequences stored in them as you would expect.
        *
        *    This is because an "array of somethign" is an object, which means it is a 
        *    reference type, even though the "something" it stores may be a "value" type.
        *    So when comparing for equality, C# is comparing it by reference, not value
        *    so two seperate arrays who share the same values will not equate to each other
        *    since their references are different.
        *
        *    This example makes use of the IEqualityComparer<T> interface to create our 
        *    own equality comparer to demonstrate how we can use byte[] as the key for
        *    a dictionary.
       */
    public static void Start()
    {
        //    This is the first byte array we'll be using as a key for our dictionary.
        byte[] bytes = new byte[] { 0x0, 0x1, 0x2 };

        //    This byte array is the same as b1. Using this in the dictionary should cause an
        //    exception...
        byte[] same_as_bytes = new byte[] { 0x0, 0x1, 0x2 };

        //    ... but as you can see with this output, if we compare the two for equality
        //    C# will say they are not equal, even though we created them equally.
        Console.WriteLine("Does 'bytes' equal 'same_as_byte': {0}", bytes == same_as_bytes);

        //    Create a new byte[], int dictionary with no equality comparer
        Dictionary<byte[], int> dict = new Dictionary<byte[], int>();

        //    Add 'bytes' array as a key to the dictionary
        dict.Add(bytes, 1);

        //    Now lets add 'same_as_bytes' as a key.  This has identicial values to 'bytes', so the 
        //    dictionary should say that we can't do this since the key is present and throw an 
        //    exception.
        dict.Add(same_as_bytes, 2);
        Console.WriteLine("Added item to dictionary with a key that was already present....");

        //    But it let us do it anyway. This is because an arrays are 'reference' types,
        //    even if what they are an array of is a 'value' type.  Since these two arrays
        //    are reference types, even with identicial values, they are still two seperate
        //    references.  So adding them to the dictioanry works this way.
        //
        //    So lets fix that
        //    First, we create a new dictionary using the ByteArrayComparer class from below ...
        Dictionary<byte[], int> dict_with_comparer = new Dictionary<byte[], int>(ByteArrayComparer.Default);

        //    ... next, we add the 'bytes' array as a key to the dictionary ...
        dict_with_comparer.Add(bytes, 1);

        //    ... and now we attempt to add the 'same_as_bytes' array as a key to the dictionary
        try
        {
            dict_with_comparer.Add(same_as_bytes, 1);
        }
        catch (Exception)
        {
            //    ... however, an exception was thrown this time. This is thanks to the ByteArrayComparer
            //    class handling properly comparing the two byte array's by values rather than the arrays
            //    as references.
            Console.WriteLine("Attempted to add item to dictionary with a key that is already present");
        }
    }
}

/// <summary>
///    An IEqualityComparer that compares two byte arrays to see if they
///    are equal to each other based on the value sequences contained within
///    the arrays.
/// </summary>
public class ByteArrayComparer : IEqualityComparer<byte[]>
{
    //    Private backing field for the Default property below.
    private static ByteArrayComparer _default;

    /// <summary>
    ///    Default instance of <see cref = "ByteArrayComparer"/>
    /// </summary>
    public static ByteArrayComparer Default
    {
        get
        {
            if (_default == null)
            {
                _default = new ByteArrayComparer();
            }

            return _default;
        }
    }

    /// <summary>
    ///    Tests for equality between two byte arrays based on their value
    ///    sequences.
    ///	<param name = "obj1">A byte array to test for equality against obj2.</param>
    /// <param name = "obj2">A byte array to test for equality againts obj1.</param>
    /// </summary>
    public bool Equals(byte[] obj1, byte[] obj2)
    {
        //    We can make use of the StructuralEqualityComparar class to see if these
        //    two arrays are equaly based on their value sequences.
        return StructuralComparisons.StructuralEqualityComparer.Equals(obj1, obj2);
    }

    /// <summary>
    ///    Gets a hash code to identify the given object.
    /// </summary>
    /// <param name = "obj">The byte array to generate a hash code for.</param>
    public int GetHashCode(byte[] obj)
    {
        //    Just like in the Equals method, we can use the StructuralEqualityComparer
        //    class to generate a hashcode for the object.
        return StructuralComparisons.StructuralEqualityComparer.GetHashCode(obj);
    }
}