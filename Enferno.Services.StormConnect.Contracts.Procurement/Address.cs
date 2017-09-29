using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "Address", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class Address : Entity
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }
        [DataMember(Order = 2)]
        public string Attention { get; set; }
        [DataMember(Order = 3)]
        public string Line { get; set; }
        [DataMember(Order = 4)]
        public string Line2 { get; set; }
        [DataMember(Order = 5)]
        public string CareOf { get; set; }
        [DataMember(Order = 6)]
        public string ZipCode { get; set; }
        [DataMember(Order = 7)]
        public string City { get; set; }
        [DataMember(Order = 8)]
        public string Region { get; set; }
        [DataMember(Order = 9)]
        public string CountryName { get; set; }
        [DataMember(Order = 10)]
        public string CountryCode { get; set; }
    }
}
