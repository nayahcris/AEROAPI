namespace AEROAPI.Model
{
    public class Reserva
    {
        public int Id { get; set; }

        public int VooId { get; set; }

        public string Documento { get; set; }

        public int Poltrona { get; set; }
    }
}