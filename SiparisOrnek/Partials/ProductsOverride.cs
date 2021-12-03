namespace SiparisOrnek.Models
{
    public partial class Product 
    {
        public override string ToString()
        {
            return $"{ ProductName} - {UnitPrice:c2}";
        }
    }
}
