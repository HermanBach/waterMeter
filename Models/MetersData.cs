using System.ComponentModel.DataAnnotations;

namespace waterMeter.Models
{
    public class MetersData
    {
        /// <summary>
        /// Id показания счётчика
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Счётчик, с которого приняты показания
        /// </summary>
        public Meter Meter { get; set; }
        /// <summary>
        /// Переданные показания счётчика
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// Дата снятия показаний
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? TestimonyDate { get; set; }

    }
}
