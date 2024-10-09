
using System.Text;

var currency1 = new CurrencyRecord("USD", 100, "SomeValue");
var currency2 = currency1 with { Value = 200 }; // cloning of records

var (name, value, _) = currency1; // deconstruction of the record

Console.WriteLine(currency1);
Console.WriteLine(currency2);
Console.WriteLine($"Is currency1 == currency2 ? {currency1 == currency2}");
Console.WriteLine($"Is object.ReferenceEquals(currency1, currency2) ? {object.ReferenceEquals(currency1, currency2)}");

public abstract record BaseCurrencyRecort(string SomeValue);
// record automatically overrides the methods ToString(), Equals(), GetHashCode() operators == and !=
// record can automatically create constructor
public record class CurrencyRecord(string Name, decimal Value, string SomeValue) : BaseCurrencyRecort(SomeValue), IDisposable
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

public class CurrencyClass
{
    public CurrencyClass( string name, decimal value)
    {
        Name = name;
        Value = value;
    }
    public string Name { get; set; }
    public decimal Value { get; set; }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append($"Currency: {{Name = {Name}, Value = {Value}}}");

        return builder.ToString();
    }

    public static bool operator !=(CurrencyClass left, CurrencyClass right)
    {
        return !(left == right);
    }

    public static bool operator ==(CurrencyClass left, CurrencyClass right)
    {
        return (object)left == right || ((object) left != null && left.Equals(right));
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode() ^ Name.GetHashCode();
    }


}


