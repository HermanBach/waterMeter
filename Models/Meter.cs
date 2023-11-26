using System.ComponentModel.DataAnnotations;

namespace waterMeter.Models
{
    public class Meter
    {
        /// <summary>
        /// Id счетчика
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Заводской номер счетчика
        /// </summary>
        public string FactoryNumber { get; set; }
        /// <summary>
        /// Дата последней поверки
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? LastVerification { get; set; }
        /// <summary>
        /// Дата следующей поверки
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? NextVerification { get; set; }
    }
}
