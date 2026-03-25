using System.Xml.Serialization;

public partial class Person : PersonAddress
{
    private string nameField;
    private string surnameField;
    private long peselField;
    private PersonAddress[] addressesField;

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string surname
    {
        get
        {
            return this.surnameField;
        }
        set
        {
            this.surnameField = value;
        }
    }

    /// <remarks/>
    public long pesel
    {
        get
        {
            return this.peselField;
        }
        set
        {
            this.peselField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("address", IsNullable = false)]
    public PersonAddress[] adresses
    {
        get
        {
            return this.addressesField;
        }
        set
        {
            this.addressesField = value;
        }
    }
}

public partial class PersonAddress
{
    private string streetField;
    private string houseField;
    private string flatField;
    private string cityField;

    /// <remarks/>
    public string street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }

    /// <remarks/>
    public string house
    {
        get
        {
            return this.houseField;
        }
        set
        {
            this.houseField = value;
        }
    }

    /// <remarks/>
    public string flat
    {
        get
        {
            return this.flatField;
        }
        set
        {
            this.flatField = value;
        }
    }

    /// <remarks/>
    public string city
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }
}
