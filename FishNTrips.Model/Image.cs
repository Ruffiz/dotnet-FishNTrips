using System;
using System.Collections.Generic;
using System.Text;

namespace FishNTrips.Model
{
    public class Image
    {

        /// <summary>
        /// Gets or sets the image identifier.
        /// </summary>
        /// <value>
        /// The image identifier.
        /// </value>
        public int ImageId { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the location img.
        /// </summary>
        /// <value>
        /// The location img.
        /// </value>
        public Location LocationImg { get; set; }
    }
}
