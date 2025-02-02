using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWSChatBot
{
    /// <summary>
    /// A utility class to store all the current values from the intent's slots.
    /// </summary>
    public class FlowerOrder
    {
        public FlowerTypes? FlowerType { get; set; }

        public string PickUpTime { get; set; }

        public string PickUpDate { get; set; }



        [JsonIgnore]
        public bool HasRequiredFlowerFields
        {
            get
            {
                return !string.IsNullOrEmpty(PickUpDate)
                        && !string.IsNullOrEmpty(PickUpTime)
                        && !string.IsNullOrEmpty(FlowerType.ToString());

            }
        }



        public enum FlowerTypes
        {
            Roses,
            Lilies,
            Tulips,
            Null
        }
    }
}
