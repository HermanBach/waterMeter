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
        /// Счётчик, на который заменили
        /// </summary>
        public Meter? Meter { get; set; }
    }
}
