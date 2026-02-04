namespace BorealERP.Api.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF_CNPJ { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }

}
