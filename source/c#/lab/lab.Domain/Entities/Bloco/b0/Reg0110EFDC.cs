namespace lab.Domain.Entities.Bloco.b0
{
    public class Reg0110EFDC
    {
        public int Id { get; set; }
        public string Reg { get; set; }
        public int CodIncTrib { get; set; }
        public int IndAproCred { get; set; }
        public int CodTipoCont { get; set; }
        public int IndRegCum { get; set; }
        public int Reg0000EFDCId { get; set; }
        public virtual Reg0000EFDC Reg0000EFDC { get; set; }
    }
}
