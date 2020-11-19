namespace AEROAPI.Request
{
    public class EfetuarReservaRequest
    {
        public int VooId { get; set; }

        public string Documento { get; set; }

        public int Poltrona { get; set; }
    }
}