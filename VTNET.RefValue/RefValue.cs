namespace VTNET.RefValue;
public class RefValue<T>
{
    public RefValue(T? value)
    {
        _value = value;
    }
    readonly T? _value;
    public T? Value => _value;
}