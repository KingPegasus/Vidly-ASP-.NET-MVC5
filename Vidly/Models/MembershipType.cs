namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte Mem0 = 1;
        public static readonly byte Mem10 = 2;
        public static readonly byte Mem15 = 3;
        public static readonly byte Mem20 = 4;


    }
}