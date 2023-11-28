using System.ComponentModel.DataAnnotations;

namespace waterMeter.Models
{
    public class MeterReplacementHistory
    {
        /// <summary>
        /// Id замены счётчика
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дата установки
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? InstallationDate { get; set; }
        /// <summary>
        /// Показания заменяемого счётчика
        /// </summary>
        public double? Value { get; set; }
        /// <summary>
        /// Старый счётчик
        /// </summary>
        public Meter? OldMeter { get; set; }
        /// <summary>
        /// Новый счётчик
        /// </summary>
        public Meter? NewMeter { get; set; }
    }
}
