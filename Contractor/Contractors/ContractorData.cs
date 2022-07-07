using System.ComponentModel.DataAnnotations;

namespace Contractor.Contractors
{
	public class ContractorData
	{
        public int Id { get; set; }
        [MaxLengthAttribute(50)]
        public string? Name { get; set; }
        
        public int Nip { get; set; }
        public TypeOfContractor TypContractor { get; set; }
        [MaxLengthAttribute(500)]
        public string? Desctiption { get; set; }
        public bool Activ { get; set; }
    }

    public enum TypeOfContractor
    {
        klient,
        potencjalny_klient
    }
}

