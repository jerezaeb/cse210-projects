public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address (string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street} \n \t {_city} {_state} {_country}";
    }
}