namespace waterMeter.Models
{
    public class Apartment
    {
        /// <summary>
        /// Id квартиры
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя в формате xpath (<Улица>/<Дом>/<Номер квартиры>)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Текущий установленный счётчик
        /// </summary>
        public Meter? Meter { get; set; }

    }
}
