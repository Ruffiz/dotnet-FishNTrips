using System;
using System.Collections.Generic;
using System.Text;

namespace FishNTrips.Model
{
    public class Location
    {
        /// <summary>
        /// Gets or sets the location identifier.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        /// <value>
        /// The name of the location.
        /// </value>
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or sets the location cords.
        /// </summary>
        /// <value>
        /// The location cords.
        /// </value>
        public double LocationCords { get; set; }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>
        /// The image URL.
        /// </value>
        public ICollection<Image> ImageUrl { get; set; } = new List<Image>();

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
