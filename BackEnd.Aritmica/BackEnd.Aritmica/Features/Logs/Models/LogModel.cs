namespace BackEnd.Aritmica.Features.Logs.Models
{
    public class LogModel
    {
        public string Message { get; set; }
        public string Entity  { get; set; }
        public DateTime Time = DateTime.Now;
    }
}
