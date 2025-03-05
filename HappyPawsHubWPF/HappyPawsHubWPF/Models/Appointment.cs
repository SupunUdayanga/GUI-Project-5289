namespace HappyPawsHubWPF.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PetType { get; set; }
        public string PetName { get; set; }
        public string DoctorName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
