// This file was generated by liblab | https://liblab.com/

namespace PostmanClient.OneOf;

public class OneOf<Type0, Type1, Type2, Type3> : IOneOf
{
    public int Index { get; private set; }
    private Type0? _value0;
    private Type1? _value1;
    private Type2? _value2;
    private Type3? _value3;

    public OneOf() { }

    public OneOf(Type0 t)
    {
        Index = 0;
        _value0 = t;
        _value1 = default;
        _value2 = default;
        _value3 = default;
    }

    public OneOf(Type1 t)
    {
        Index = 1;
        _value0 = default;
        _value1 = t;
        _value2 = default;
        _value3 = default;
    }

    public OneOf(Type2 t)
    {
        Index = 2;
        _value0 = default;
        _value1 = default;
        _value2 = t;
        _value3 = default;
    }

    public OneOf(Type3 t)
    {
        Index = 3;
        _value0 = default;
        _value1 = default;
        _value2 = default;
        _value3 = t;
    }

    public static implicit operator OneOf<Type0, Type1, Type2, Type3>(Type0 t) => new(t);

    public static implicit operator OneOf<Type0, Type1, Type2, Type3>(Type1 t) => new(t);

    public static implicit operator OneOf<Type0, Type1, Type2, Type3>(Type2 t) => new(t);

    public static implicit operator OneOf<Type0, Type1, Type2, Type3>(Type3 t) => new(t);

    public object? Value =>
        Index switch
        {
            0 => _value0,
            1 => _value1,
            2 => _value2,
            3 => _value3,
            _ => throw new InvalidOperationException()
        };

    public void InitializeFromObject(int index, object obj)
    {
        Index = index;
        switch (index)
        {
            case 0:
                _value0 = (Type0)obj;
                break;
            case 1:
                _value1 = (Type1)obj;
                break;
            case 2:
                _value2 = (Type2)obj;
                break;
            case 3:
                _value3 = (Type3)obj;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    private bool IsType0 => Index == 0;
    private bool IsType1 => Index == 1;
    private bool IsType2 => Index == 2;
    private bool IsType3 => Index == 3;

    public Type0? AsType0 =>
        Index == 0
            ? _value0
            : throw new InvalidOperationException(
                $"Cannot return as Type0 as result is Type{Index}"
            );
    public Type1? AsType1 =>
        Index == 1
            ? _value1
            : throw new InvalidOperationException(
                $"Cannot return as Type1 as result is Type{Index}"
            );
    public Type2? AsType2 =>
        Index == 2
            ? _value2
            : throw new InvalidOperationException(
                $"Cannot return as Type2 as result is Type{Index}"
            );
    public Type3? AsType3 =>
        Index == 3
            ? _value3
            : throw new InvalidOperationException(
                $"Cannot return as Type3 as result is Type{Index}"
            );

    /// <summary>
    /// Specify the action to perform for each type.
    /// </summary>
    public void Switch(Action<Type0> f0, Action<Type1> f1, Action<Type2> f2, Action<Type3> f3)
    {
        if (Index == 0 && _value0 is not null)
        {
            f0(_value0);
            return;
        }
        if (Index == 1 && _value1 is not null)
        {
            f1(_value1);
            return;
        }
        if (Index == 2 && _value2 is not null)
        {
            f2(_value2);
            return;
        }
        if (Index == 3 && _value3 is not null)
        {
            f3(_value3);
            return;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Specify how to match each type to a result.
    /// </summary>
    public TResult Match<TResult>(
        Func<Type0, TResult> f0,
        Func<Type1, TResult> f1,
        Func<Type2, TResult> f2,
        Func<Type3, TResult> f3
    )
    {
        if (Index == 0 && _value0 is not null)
        {
            return f0(_value0);
        }
        if (Index == 1 && _value1 is not null)
        {
            return f1(_value1);
        }
        if (Index == 2 && _value2 is not null)
        {
            return f2(_value2);
        }
        if (Index == 3 && _value3 is not null)
        {
            return f3(_value3);
        }
        throw new InvalidOperationException();
    }

    public static OneOf<Type0, Type1, Type2, Type3> FromType0(Type0 input) => input;

    public static OneOf<Type0, Type1, Type2, Type3> FromType1(Type1 input) => input;

    public static OneOf<Type0, Type1, Type2, Type3> FromType2(Type2 input) => input;

    public static OneOf<Type0, Type1, Type2, Type3> FromType3(Type3 input) => input;

    /// <summary>
    /// Tries to pick the type 0.
    /// </summary>
    /// <param name="value">The output parameter to store the picked type.</param>
    /// <returns>True if the type was successfully picked, otherwise false.</returns>
    public bool TryPickType0(out Type0? value)
    {
        value = IsType0 ? AsType0 : default;
        return this.IsType0;
    }

    /// <summary>
    /// Tries to pick the type 1.
    /// </summary>
    /// <param name="value">The output parameter to store the picked type.</param>
    /// <returns>True if the type was successfully picked, otherwise false.</returns>
    public bool TryPickType1(out Type1? value)
    {
        value = IsType1 ? AsType1 : default;
        return this.IsType1;
    }

    /// <summary>
    /// Tries to pick the type 2.
    /// </summary>
    /// <param name="value">The output parameter to store the picked type.</param>
    /// <returns>True if the type was successfully picked, otherwise false.</returns>
    public bool TryPickType2(out Type2? value)
    {
        value = IsType2 ? AsType2 : default;
        return this.IsType2;
    }

    /// <summary>
    /// Tries to pick the type 3.
    /// </summary>
    /// <param name="value">The output parameter to store the picked type.</param>
    /// <returns>True if the type was successfully picked, otherwise false.</returns>
    public bool TryPickType3(out Type3? value)
    {
        value = IsType3 ? AsType3 : default;
        return this.IsType3;
    }

    private bool Equals(OneOf<Type0, Type1, Type2, Type3> other) =>
        Index == other.Index
        && Index switch
        {
            0 => Equals(_value0, other._value0),
            1 => Equals(_value1, other._value1),
            2 => Equals(_value2, other._value2),
            3 => Equals(_value3, other._value3),
            _ => false
        };

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        return obj is OneOf<Type0, Type1, Type2, Type3> o && Equals(o);
    }

    public override string ToString() =>
        Index switch
        {
            0 => FormatValue(_value0),
            1 => FormatValue(_value1),
            2 => FormatValue(_value2),
            3 => FormatValue(_value3),
            _
                => throw new InvalidOperationException(
                    "Unexpected index, which indicates a problem in the OneOf codegen."
                )
        };

    private static string FormatValue<T>(T value) => $"{typeof(T).FullName}: {value?.ToString()}";

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode =
                Index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
                    2 => _value2?.GetHashCode(),
                    3 => _value3?.GetHashCode(),
                    _ => 0
                } ?? 0;
            return (hashCode * 397) ^ Index;
        }
    }
}
