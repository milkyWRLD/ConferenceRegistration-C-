using System.ComponentModel.DataAnnotations;

namespace ConferenceRegistration.Server.Models
{
    /// <summary>
    /// Модель данных для участников конференции
    /// </summary>
    public class Participant
    {
        [Key]
        public int Id { get; set; }  // Уникальный идентификатор участника

        [Required]
        public string FullName { get; set; }  // ФИО участника

        [Required]
        public string Role { get; set; }  // Роль (Докладчик или Слушатель)

        public string? JobTitle { get; set; }  // Должность

        public string? AcademicDegree { get; set; }  // Ученая степень

        [Required]
        public string ContactInfo { get; set; }  // Контактная информация

        public string? ReportTitle { get; set; }  // Название доклада (если докладчик)

        public string? CoSpeakers { get; set; }  // Список содокладчиков (если докладчик)
    }
}
